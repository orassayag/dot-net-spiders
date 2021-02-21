﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3607
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="CVBilly")]
public partial class CVBillyDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCVMail(CVMail instance);
  partial void UpdateCVMail(CVMail instance);
  partial void DeleteCVMail(CVMail instance);
  partial void InsertLastID(LastID instance);
  partial void UpdateLastID(LastID instance);
  partial void DeleteLastID(LastID instance);
  #endregion
	
	public CVBillyDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CVBillyConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CVBillyDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CVBillyDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CVBillyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CVBillyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<CVMail> CVMails
	{
		get
		{
			return this.GetTable<CVMail>();
		}
	}
	
	public System.Data.Linq.Table<LastID> LastIDs
	{
		get
		{
			return this.GetTable<LastID>();
		}
	}
}

[Table(Name="dbo.CVMail")]
public partial class CVMail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _Mail;
	
	private long _asdws;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnasdwsChanging(long value);
    partial void OnasdwsChanged();
    #endregion
	
	public CVMail()
	{
		OnCreated();
	}
	
	[Column(Storage="_Mail", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Mail
	{
		get
		{
			return this._Mail;
		}
		set
		{
			if ((this._Mail != value))
			{
				this.OnMailChanging(value);
				this.SendPropertyChanging();
				this._Mail = value;
				this.SendPropertyChanged("Mail");
				this.OnMailChanged();
			}
		}
	}
	
	[Column(Storage="_asdws", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
	public long asdws
	{
		get
		{
			return this._asdws;
		}
		set
		{
			if ((this._asdws != value))
			{
				this.OnasdwsChanging(value);
				this.SendPropertyChanging();
				this._asdws = value;
				this.SendPropertyChanged("asdws");
				this.OnasdwsChanged();
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

[Table(Name="dbo.LastID")]
public partial class LastID : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _sdfsdgdf;
	
	private long _LastID1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsdfsdgdfChanging(string value);
    partial void OnsdfsdgdfChanged();
    partial void OnLastID1Changing(long value);
    partial void OnLastID1Changed();
    #endregion
	
	public LastID()
	{
		OnCreated();
	}
	
	[Column(Storage="_sdfsdgdf", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string sdfsdgdf
	{
		get
		{
			return this._sdfsdgdf;
		}
		set
		{
			if ((this._sdfsdgdf != value))
			{
				this.OnsdfsdgdfChanging(value);
				this.SendPropertyChanging();
				this._sdfsdgdf = value;
				this.SendPropertyChanged("sdfsdgdf");
				this.OnsdfsdgdfChanged();
			}
		}
	}
	
	[Column(Name="LastID", Storage="_LastID1", DbType="BigInt NOT NULL")]
	public long LastID1
	{
		get
		{
			return this._LastID1;
		}
		set
		{
			if ((this._LastID1 != value))
			{
				this.OnLastID1Changing(value);
				this.SendPropertyChanging();
				this._LastID1 = value;
				this.SendPropertyChanged("LastID1");
				this.OnLastID1Changed();
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
#pragma warning restore 1591