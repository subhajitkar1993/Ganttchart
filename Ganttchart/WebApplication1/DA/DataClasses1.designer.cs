﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.DA
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyProject")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGanttData(GanttData instance);
    partial void UpdateGanttData(GanttData instance);
    partial void DeleteGanttData(GanttData instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyProjectConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GanttData> GanttDatas
		{
			get
			{
				return this.GetTable<GanttData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GanttData")]
	public partial class GanttData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PID;
		
		private string _PNAME;
		
		private string _P_MGR;
		
		private System.DateTime _P_START;
		
		private System.Nullable<System.DateTime> _P_END;
		
		private System.Nullable<int> _Progress;
		
		private System.Nullable<bool> _Progressbyworklog;
		
		private string _Description;
		
		private string _Status;
		
		private System.Nullable<bool> _Canwrite;
		
		private System.Nullable<int> _Duration;
		
		private System.Nullable<bool> _Haschild;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPIDChanging(int value);
    partial void OnPIDChanged();
    partial void OnPNAMEChanging(string value);
    partial void OnPNAMEChanged();
    partial void OnP_MGRChanging(string value);
    partial void OnP_MGRChanged();
    partial void OnP_STARTChanging(System.DateTime value);
    partial void OnP_STARTChanged();
    partial void OnP_ENDChanging(System.Nullable<System.DateTime> value);
    partial void OnP_ENDChanged();
    partial void OnProgressChanging(System.Nullable<int> value);
    partial void OnProgressChanged();
    partial void OnProgressbyworklogChanging(System.Nullable<bool> value);
    partial void OnProgressbyworklogChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnCanwriteChanging(System.Nullable<bool> value);
    partial void OnCanwriteChanged();
    partial void OnDurationChanging(System.Nullable<int> value);
    partial void OnDurationChanged();
    partial void OnHaschildChanging(System.Nullable<bool> value);
    partial void OnHaschildChanged();
    #endregion
		
		public GanttData()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					this.OnPIDChanging(value);
					this.SendPropertyChanging();
					this._PID = value;
					this.SendPropertyChanged("PID");
					this.OnPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PNAME", DbType="VarChar(50)")]
		public string PNAME
		{
			get
			{
				return this._PNAME;
			}
			set
			{
				if ((this._PNAME != value))
				{
					this.OnPNAMEChanging(value);
					this.SendPropertyChanging();
					this._PNAME = value;
					this.SendPropertyChanged("PNAME");
					this.OnPNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_MGR", DbType="VarChar(50)")]
		public string P_MGR
		{
			get
			{
				return this._P_MGR;
			}
			set
			{
				if ((this._P_MGR != value))
				{
					this.OnP_MGRChanging(value);
					this.SendPropertyChanging();
					this._P_MGR = value;
					this.SendPropertyChanged("P_MGR");
					this.OnP_MGRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_START", DbType="Date NOT NULL")]
		public System.DateTime P_START
		{
			get
			{
				return this._P_START;
			}
			set
			{
				if ((this._P_START != value))
				{
					this.OnP_STARTChanging(value);
					this.SendPropertyChanging();
					this._P_START = value;
					this.SendPropertyChanged("P_START");
					this.OnP_STARTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_END", DbType="Date")]
		public System.Nullable<System.DateTime> P_END
		{
			get
			{
				return this._P_END;
			}
			set
			{
				if ((this._P_END != value))
				{
					this.OnP_ENDChanging(value);
					this.SendPropertyChanging();
					this._P_END = value;
					this.SendPropertyChanged("P_END");
					this.OnP_ENDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Progress", DbType="Int")]
		public System.Nullable<int> Progress
		{
			get
			{
				return this._Progress;
			}
			set
			{
				if ((this._Progress != value))
				{
					this.OnProgressChanging(value);
					this.SendPropertyChanging();
					this._Progress = value;
					this.SendPropertyChanged("Progress");
					this.OnProgressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Progressbyworklog", DbType="Bit")]
		public System.Nullable<bool> Progressbyworklog
		{
			get
			{
				return this._Progressbyworklog;
			}
			set
			{
				if ((this._Progressbyworklog != value))
				{
					this.OnProgressbyworklogChanging(value);
					this.SendPropertyChanging();
					this._Progressbyworklog = value;
					this.SendPropertyChanged("Progressbyworklog");
					this.OnProgressbyworklogChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(MAX)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Canwrite", DbType="Bit")]
		public System.Nullable<bool> Canwrite
		{
			get
			{
				return this._Canwrite;
			}
			set
			{
				if ((this._Canwrite != value))
				{
					this.OnCanwriteChanging(value);
					this.SendPropertyChanging();
					this._Canwrite = value;
					this.SendPropertyChanged("Canwrite");
					this.OnCanwriteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="Int")]
		public System.Nullable<int> Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this.OnDurationChanging(value);
					this.SendPropertyChanging();
					this._Duration = value;
					this.SendPropertyChanged("Duration");
					this.OnDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Haschild", DbType="Bit")]
		public System.Nullable<bool> Haschild
		{
			get
			{
				return this._Haschild;
			}
			set
			{
				if ((this._Haschild != value))
				{
					this.OnHaschildChanging(value);
					this.SendPropertyChanging();
					this._Haschild = value;
					this.SendPropertyChanged("Haschild");
					this.OnHaschildChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
