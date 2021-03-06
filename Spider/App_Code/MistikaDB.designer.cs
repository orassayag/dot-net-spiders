﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MistikaDB")]
public partial class MistikaDBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCVMail(CVMail instance);
  partial void UpdateCVMail(CVMail instance);
  partial void DeleteCVMail(CVMail instance);
  #endregion
	
	public MistikaDBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MistikaDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public MistikaDBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MistikaDBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MistikaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MistikaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CVMail")]
public partial class CVMail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private long _MailID;
	
	private string _MailValue;
	
	private System.Nullable<bool> _MailSent;
	
	private System.Nullable<System.DateTime> _MailDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailIDChanging(long value);
    partial void OnMailIDChanged();
    partial void OnMailValueChanging(string value);
    partial void OnMailValueChanged();
    partial void OnMailSentChanging(System.Nullable<bool> value);
    partial void OnMailSentChanged();
    partial void OnMailDateChanging(System.Nullable<System.DateTime> value);
    partial void OnMailDateChanged();
    #endregion
	
	public CVMail()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
	public long MailID
	{
		get
		{
			return this._MailID;
		}
		set
		{
			if ((this._MailID != value))
			{
				this.OnMailIDChanging(value);
				this.SendPropertyChanging();
				this._MailID = value;
				this.SendPropertyChanged("MailID");
				this.OnMailIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailValue", DbType="NVarChar(MAX)")]
	public string MailValue
	{
		get
		{
			return this._MailValue;
		}
		set
		{
			if ((this._MailValue != value))
			{
				this.OnMailValueChanging(value);
				this.SendPropertyChanging();
				this._MailValue = value;
				this.SendPropertyChanged("MailValue");
				this.OnMailValueChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailSent", DbType="Bit")]
	public System.Nullable<bool> MailSent
	{
		get
		{
			return this._MailSent;
		}
		set
		{
			if ((this._MailSent != value))
			{
				this.OnMailSentChanging(value);
				this.SendPropertyChanging();
				this._MailSent = value;
				this.SendPropertyChanged("MailSent");
				this.OnMailSentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MailDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> MailDate
	{
		get
		{
			return this._MailDate;
		}
		set
		{
			if ((this._MailDate != value))
			{
				this.OnMailDateChanging(value);
				this.SendPropertyChanging();
				this._MailDate = value;
				this.SendPropertyChanged("MailDate");
				this.OnMailDateChanged();
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
