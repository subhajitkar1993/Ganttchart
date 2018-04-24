using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DA;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var vm = (from uh in db.GanttDatas
                     select new Project()
                     {
                       PID=uh.PID,
                       PNAME=uh.PNAME,
                       P_START=uh.P_START,
                       P_MGR=uh.P_MGR,
                       P_END=(DateTime)uh.P_END,

                     }).ToList();

            var result = ProjectViewModels.GetView(vm);

            return View(result);
        }


        public ActionResult About()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var vm = (from uh in db.GanttDatas
                      select new Project()
                      {
                          PID = uh.PID,
                          PNAME = uh.PNAME,
                          P_START = uh.P_START,
                          P_MGR = uh.P_MGR,
                          P_END = (DateTime)uh.P_END,

                      }).ToList();

            var result = ProjectViewModels.GetView(vm);

            return View(result);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}