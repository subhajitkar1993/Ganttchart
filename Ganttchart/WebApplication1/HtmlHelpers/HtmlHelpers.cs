using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebApplication1.HtmlHelpers
{
    public static class HtmlHelpers
    {
        public static double UnixTicks(this DateTime dt)
        {
            DateTime d1 = new DateTime(1970, 1, 1);
            DateTime d2 = dt.ToUniversalTime();
            TimeSpan ts = new TimeSpan(d2.Ticks - d1.Ticks);
            return ts.TotalMilliseconds;
        }
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString JSVariableFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            return JSVariable(htmlHelper,
                                ExpressionHelper.GetExpressionText(expression),
                                metadata.Model);
        }

        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "This is an appropriate nesting of generic types")]
        public static MvcHtmlString JSVariable(this HtmlHelper htmlHelper, string varName, object value)
        {
            return MvcHtmlString.Create(string.Format("var {0} = {1};", varName, serializeValue(value)));
        }


        public static MvcHtmlString JSValue(this HtmlHelper helper, object value)
        {
            return MvcHtmlString.Create(serializeValue(value));
        }

        public static MvcHtmlString PageID(this HtmlHelper helper)
        {
            var controller = helper.ViewContext.RouteData.Values["controller"].ToString();
            var action = helper.ViewContext.RouteData.Values["action"].ToString();
            return MvcHtmlString.Create(string.Format("pgid:{0}.{1}", controller, action));
        }


        private static string serializeValue(object value)
        {
            var varValue = "";
            if (value == null) varValue = "null";
            else if (value is string) varValue = quoteString(value.ToString());
            else if (value is DateTime) value = quoteString(Convert.ToString("mm/dd/YYYY"));
            else if (value is DateTime?) value = quoteString(Convert.ToString("mm/dd/YYYY"));
            else if (value is bool || value is bool?) varValue = value.ToString().ToLower();
            else if (value is int || value is int?
                    || value is byte || value is byte?
                    || value is long || value is long?
                    || value is float || value is float?
                    || value is double || value is double?
                    || value is decimal || value is decimal) varValue = value.ToString();
            else if (value is char || value is char?) varValue = quoteString(value.ToString());
            else
            {
                var sb = new System.Text.StringBuilder();
                var serializer = new JavaScriptSerializer();
                serializer.Serialize(value, sb);
                varValue = sb.ToString();
            }
            return varValue;
        }

        private static string quoteString(string s)
        {
            return "'"
                + s
                    .Replace("\\", "\\\\")
                    .Replace("'", "\'")
                    .Replace("\n", "\\n")
                    .Replace("\r", "\\r")
                + "'";
        }
    }
}
