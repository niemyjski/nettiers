﻿/*
	File generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file VJobCandidate.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace Nettiers.AdventureWorks.Entities
{
	///<summary>
	/// Job candidate names and resumes.	
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VJobCandidateBase")]
	public abstract partial class VJobCandidateBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{
		
		#region Variable Declarations
		
		/// <summary>
		/// JobCandidateID : 
		/// </summary>
		private System.Int32		  _jobCandidateId = (int)0;
		
		/// <summary>
		/// EmployeeID : 
		/// </summary>
		private System.Int32?		  _employeeId = null;
		
		/// <summary>
		/// Name.Prefix : 
		/// </summary>
		private System.String		  _safeNameNamePrefix = null;
		
		/// <summary>
		/// Name.First : 
		/// </summary>
		private System.String		  _safeNameNameFirst = null;
		
		/// <summary>
		/// Name.Middle : 
		/// </summary>
		private System.String		  _safeNameNameMiddle = null;
		
		/// <summary>
		/// Name.Last : 
		/// </summary>
		private System.String		  _safeNameNameLast = null;
		
		/// <summary>
		/// Name.Suffix : 
		/// </summary>
		private System.String		  _safeNameNameSuffix = null;
		
		/// <summary>
		/// Skills : 
		/// </summary>
		private System.String		  _skills = null;
		
		/// <summary>
		/// Addr.Type : 
		/// </summary>
		private System.String		  _safeNameAddrType = null;
		
		/// <summary>
		/// Addr.Loc.CountryRegion : 
		/// </summary>
		private System.String		  _safeNameAddrLocCountryRegion = null;
		
		/// <summary>
		/// Addr.Loc.State : 
		/// </summary>
		private System.String		  _safeNameAddrLocState = null;
		
		/// <summary>
		/// Addr.Loc.City : 
		/// </summary>
		private System.String		  _safeNameAddrLocCity = null;
		
		/// <summary>
		/// Addr.PostalCode : 
		/// </summary>
		private System.String		  _safeNameAddrPostalCode = null;
		
		/// <summary>
		/// EMail : 
		/// </summary>
		private System.String		  _email = null;
		
		/// <summary>
		/// WebSite : 
		/// </summary>
		private System.String		  _webSite = null;
		
		/// <summary>
		/// ModifiedDate : 
		/// </summary>
		private System.DateTime		  _modifiedDate = DateTime.MinValue;
		
		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;
		
		/// <summary>
		/// Suppresses Entity Events from Firing, 
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized] 
		private bool suppressEntityEvents = false;
		
		#endregion Variable Declarations
		
		#region Constructors
		///<summary>
		/// Creates a new <see cref="VJobCandidateBase"/> instance.
		///</summary>
		public VJobCandidateBase()
		{
		}		
		
		///<summary>
		/// Creates a new <see cref="VJobCandidateBase"/> instance.
		///</summary>
		///<param name="_jobCandidateId"></param>
		///<param name="_employeeId"></param>
		///<param name="_safeNameNamePrefix"></param>
		///<param name="_safeNameNameFirst"></param>
		///<param name="_safeNameNameMiddle"></param>
		///<param name="_safeNameNameLast"></param>
		///<param name="_safeNameNameSuffix"></param>
		///<param name="_skills"></param>
		///<param name="_safeNameAddrType"></param>
		///<param name="_safeNameAddrLocCountryRegion"></param>
		///<param name="_safeNameAddrLocState"></param>
		///<param name="_safeNameAddrLocCity"></param>
		///<param name="_safeNameAddrPostalCode"></param>
		///<param name="_email"></param>
		///<param name="_webSite"></param>
		///<param name="_modifiedDate"></param>
		public VJobCandidateBase(System.Int32 _jobCandidateId, System.Int32? _employeeId, System.String _safeNameNamePrefix, System.String _safeNameNameFirst, System.String _safeNameNameMiddle, System.String _safeNameNameLast, System.String _safeNameNameSuffix, System.String _skills, System.String _safeNameAddrType, System.String _safeNameAddrLocCountryRegion, System.String _safeNameAddrLocState, System.String _safeNameAddrLocCity, System.String _safeNameAddrPostalCode, System.String _email, System.String _webSite, System.DateTime _modifiedDate)
		{
			this._jobCandidateId = _jobCandidateId;
			this._employeeId = _employeeId;
			this._safeNameNamePrefix = _safeNameNamePrefix;
			this._safeNameNameFirst = _safeNameNameFirst;
			this._safeNameNameMiddle = _safeNameNameMiddle;
			this._safeNameNameLast = _safeNameNameLast;
			this._safeNameNameSuffix = _safeNameNameSuffix;
			this._skills = _skills;
			this._safeNameAddrType = _safeNameAddrType;
			this._safeNameAddrLocCountryRegion = _safeNameAddrLocCountryRegion;
			this._safeNameAddrLocState = _safeNameAddrLocState;
			this._safeNameAddrLocCity = _safeNameAddrLocCity;
			this._safeNameAddrPostalCode = _safeNameAddrPostalCode;
			this._email = _email;
			this._webSite = _webSite;
			this._modifiedDate = _modifiedDate;
		}
		
		///<summary>
		/// A simple factory method to create a new <see cref="VJobCandidate"/> instance.
		///</summary>
		///<param name="_jobCandidateId"></param>
		///<param name="_employeeId"></param>
		///<param name="_safeNameNamePrefix"></param>
		///<param name="_safeNameNameFirst"></param>
		///<param name="_safeNameNameMiddle"></param>
		///<param name="_safeNameNameLast"></param>
		///<param name="_safeNameNameSuffix"></param>
		///<param name="_skills"></param>
		///<param name="_safeNameAddrType"></param>
		///<param name="_safeNameAddrLocCountryRegion"></param>
		///<param name="_safeNameAddrLocState"></param>
		///<param name="_safeNameAddrLocCity"></param>
		///<param name="_safeNameAddrPostalCode"></param>
		///<param name="_email"></param>
		///<param name="_webSite"></param>
		///<param name="_modifiedDate"></param>
		public static VJobCandidate CreateVJobCandidate(System.Int32 _jobCandidateId, System.Int32? _employeeId, System.String _safeNameNamePrefix, System.String _safeNameNameFirst, System.String _safeNameNameMiddle, System.String _safeNameNameLast, System.String _safeNameNameSuffix, System.String _skills, System.String _safeNameAddrType, System.String _safeNameAddrLocCountryRegion, System.String _safeNameAddrLocState, System.String _safeNameAddrLocCity, System.String _safeNameAddrPostalCode, System.String _email, System.String _webSite, System.DateTime _modifiedDate)
		{
			VJobCandidate newVJobCandidate = new VJobCandidate();
			newVJobCandidate.JobCandidateId = _jobCandidateId;
			newVJobCandidate.EmployeeId = _employeeId;
			newVJobCandidate.SafeNameNamePrefix = _safeNameNamePrefix;
			newVJobCandidate.SafeNameNameFirst = _safeNameNameFirst;
			newVJobCandidate.SafeNameNameMiddle = _safeNameNameMiddle;
			newVJobCandidate.SafeNameNameLast = _safeNameNameLast;
			newVJobCandidate.SafeNameNameSuffix = _safeNameNameSuffix;
			newVJobCandidate.Skills = _skills;
			newVJobCandidate.SafeNameAddrType = _safeNameAddrType;
			newVJobCandidate.SafeNameAddrLocCountryRegion = _safeNameAddrLocCountryRegion;
			newVJobCandidate.SafeNameAddrLocState = _safeNameAddrLocState;
			newVJobCandidate.SafeNameAddrLocCity = _safeNameAddrLocCity;
			newVJobCandidate.SafeNameAddrPostalCode = _safeNameAddrPostalCode;
			newVJobCandidate.Email = _email;
			newVJobCandidate.WebSite = _webSite;
			newVJobCandidate.ModifiedDate = _modifiedDate;
			return newVJobCandidate;
		}
				
		#endregion Constructors
		
		#region Properties	
		/// <summary>
		/// 	Gets or Sets the JobCandidateID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 JobCandidateId
		{
			get
			{
				return this._jobCandidateId; 
			}
			set
			{
				if (_jobCandidateId == value)
					return;
					
				this._jobCandidateId = value;
				this._isDirty = true;
				
				OnPropertyChanged("JobCandidateId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the EmployeeID property. 
		///		
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can be set to null. 
		/// If this column is null, this property will return (int)0. It is up to the developer
		/// to check the value of IsEmployeeIdNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32? EmployeeId
		{
			get
			{
				return this._employeeId; 
			}
			set
			{
				if (_employeeId == value && EmployeeId != null )
					return;
					
				this._employeeId = value;
				this._isDirty = true;
				
				OnPropertyChanged("EmployeeId");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name.Prefix property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameNamePrefix
		{
			get
			{
				return this._safeNameNamePrefix; 
			}
			set
			{
				if (_safeNameNamePrefix == value)
					return;
					
				this._safeNameNamePrefix = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameNamePrefix");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name.First property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameNameFirst
		{
			get
			{
				return this._safeNameNameFirst; 
			}
			set
			{
				if (_safeNameNameFirst == value)
					return;
					
				this._safeNameNameFirst = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameNameFirst");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name.Middle property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameNameMiddle
		{
			get
			{
				return this._safeNameNameMiddle; 
			}
			set
			{
				if (_safeNameNameMiddle == value)
					return;
					
				this._safeNameNameMiddle = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameNameMiddle");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name.Last property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameNameLast
		{
			get
			{
				return this._safeNameNameLast; 
			}
			set
			{
				if (_safeNameNameLast == value)
					return;
					
				this._safeNameNameLast = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameNameLast");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Name.Suffix property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameNameSuffix
		{
			get
			{
				return this._safeNameNameSuffix; 
			}
			set
			{
				if (_safeNameNameSuffix == value)
					return;
					
				this._safeNameNameSuffix = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameNameSuffix");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Skills property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Skills
		{
			get
			{
				return this._skills; 
			}
			set
			{
				if (_skills == value)
					return;
					
				this._skills = value;
				this._isDirty = true;
				
				OnPropertyChanged("Skills");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Addr.Type property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameAddrType
		{
			get
			{
				return this._safeNameAddrType; 
			}
			set
			{
				if (_safeNameAddrType == value)
					return;
					
				this._safeNameAddrType = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameAddrType");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Addr.Loc.CountryRegion property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameAddrLocCountryRegion
		{
			get
			{
				return this._safeNameAddrLocCountryRegion; 
			}
			set
			{
				if (_safeNameAddrLocCountryRegion == value)
					return;
					
				this._safeNameAddrLocCountryRegion = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameAddrLocCountryRegion");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Addr.Loc.State property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameAddrLocState
		{
			get
			{
				return this._safeNameAddrLocState; 
			}
			set
			{
				if (_safeNameAddrLocState == value)
					return;
					
				this._safeNameAddrLocState = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameAddrLocState");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Addr.Loc.City property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameAddrLocCity
		{
			get
			{
				return this._safeNameAddrLocCity; 
			}
			set
			{
				if (_safeNameAddrLocCity == value)
					return;
					
				this._safeNameAddrLocCity = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameAddrLocCity");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the Addr.PostalCode property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameAddrPostalCode
		{
			get
			{
				return this._safeNameAddrPostalCode; 
			}
			set
			{
				if (_safeNameAddrPostalCode == value)
					return;
					
				this._safeNameAddrPostalCode = value;
				this._isDirty = true;
				
				OnPropertyChanged("SafeNameAddrPostalCode");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the EMail property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String Email
		{
			get
			{
				return this._email; 
			}
			set
			{
				if (_email == value)
					return;
					
				this._email = value;
				this._isDirty = true;
				
				OnPropertyChanged("Email");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the WebSite property. 
		///		
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String WebSite
		{
			get
			{
				return this._webSite; 
			}
			set
			{
				if (_webSite == value)
					return;
					
				this._webSite = value;
				this._isDirty = true;
				
				OnPropertyChanged("WebSite");
			}
		}
		
		/// <summary>
		/// 	Gets or Sets the ModifiedDate property. 
		///		
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can not be set to null. 
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				return this._modifiedDate; 
			}
			set
			{
				if (_modifiedDate == value)
					return;
					
				this._modifiedDate = value;
				this._isDirty = true;
				
				OnPropertyChanged("ModifiedDate");
			}
		}
		
		
		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;
		
				this._tag = value;
			}
		}
	
		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{	
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}	
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}
		

		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "vJobCandidate"; }
		}

		
		#endregion
		
		#region Methods	
		
		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}
		
		
		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}
		
		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}
		
		#region ICloneable Members
		///<summary>
		///  Returns a Typed VJobCandidateBase Entity 
		///</summary>
		public virtual VJobCandidateBase Copy()
		{
			//shallow copy entity
			VJobCandidate copy = new VJobCandidate();
				copy.JobCandidateId = this.JobCandidateId;
				copy.EmployeeId = this.EmployeeId;
				copy.SafeNameNamePrefix = this.SafeNameNamePrefix;
				copy.SafeNameNameFirst = this.SafeNameNameFirst;
				copy.SafeNameNameMiddle = this.SafeNameNameMiddle;
				copy.SafeNameNameLast = this.SafeNameNameLast;
				copy.SafeNameNameSuffix = this.SafeNameNameSuffix;
				copy.Skills = this.Skills;
				copy.SafeNameAddrType = this.SafeNameAddrType;
				copy.SafeNameAddrLocCountryRegion = this.SafeNameAddrLocCountryRegion;
				copy.SafeNameAddrLocState = this.SafeNameAddrLocState;
				copy.SafeNameAddrLocCity = this.SafeNameAddrLocCity;
				copy.SafeNameAddrPostalCode = this.SafeNameAddrPostalCode;
				copy.Email = this.Email;
				copy.WebSite = this.WebSite;
				copy.ModifiedDate = this.ModifiedDate;
			copy.AcceptChanges();
			return (VJobCandidate)copy;
		}
		
		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}
		
		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion
		
		
		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="VJobCandidateBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VJobCandidateBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}
		
		
		///<summary>
		/// Determines whether the specified <see cref="VJobCandidateBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VJobCandidateBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VJobCandidateBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VJobCandidateBase Object1, VJobCandidateBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.JobCandidateId != Object2.JobCandidateId)
				equal = false;
			if (Object1.EmployeeId != null && Object2.EmployeeId != null )
			{
				if (Object1.EmployeeId != Object2.EmployeeId)
					equal = false;
			}
			else if (Object1.EmployeeId == null ^ Object1.EmployeeId == null )
			{
				equal = false;
			}
			if (Object1.SafeNameNamePrefix != null && Object2.SafeNameNamePrefix != null )
			{
				if (Object1.SafeNameNamePrefix != Object2.SafeNameNamePrefix)
					equal = false;
			}
			else if (Object1.SafeNameNamePrefix == null ^ Object1.SafeNameNamePrefix == null )
			{
				equal = false;
			}
			if (Object1.SafeNameNameFirst != null && Object2.SafeNameNameFirst != null )
			{
				if (Object1.SafeNameNameFirst != Object2.SafeNameNameFirst)
					equal = false;
			}
			else if (Object1.SafeNameNameFirst == null ^ Object1.SafeNameNameFirst == null )
			{
				equal = false;
			}
			if (Object1.SafeNameNameMiddle != null && Object2.SafeNameNameMiddle != null )
			{
				if (Object1.SafeNameNameMiddle != Object2.SafeNameNameMiddle)
					equal = false;
			}
			else if (Object1.SafeNameNameMiddle == null ^ Object1.SafeNameNameMiddle == null )
			{
				equal = false;
			}
			if (Object1.SafeNameNameLast != null && Object2.SafeNameNameLast != null )
			{
				if (Object1.SafeNameNameLast != Object2.SafeNameNameLast)
					equal = false;
			}
			else if (Object1.SafeNameNameLast == null ^ Object1.SafeNameNameLast == null )
			{
				equal = false;
			}
			if (Object1.SafeNameNameSuffix != null && Object2.SafeNameNameSuffix != null )
			{
				if (Object1.SafeNameNameSuffix != Object2.SafeNameNameSuffix)
					equal = false;
			}
			else if (Object1.SafeNameNameSuffix == null ^ Object1.SafeNameNameSuffix == null )
			{
				equal = false;
			}
			if (Object1.Skills != null && Object2.Skills != null )
			{
				if (Object1.Skills != Object2.Skills)
					equal = false;
			}
			else if (Object1.Skills == null ^ Object1.Skills == null )
			{
				equal = false;
			}
			if (Object1.SafeNameAddrType != null && Object2.SafeNameAddrType != null )
			{
				if (Object1.SafeNameAddrType != Object2.SafeNameAddrType)
					equal = false;
			}
			else if (Object1.SafeNameAddrType == null ^ Object1.SafeNameAddrType == null )
			{
				equal = false;
			}
			if (Object1.SafeNameAddrLocCountryRegion != null && Object2.SafeNameAddrLocCountryRegion != null )
			{
				if (Object1.SafeNameAddrLocCountryRegion != Object2.SafeNameAddrLocCountryRegion)
					equal = false;
			}
			else if (Object1.SafeNameAddrLocCountryRegion == null ^ Object1.SafeNameAddrLocCountryRegion == null )
			{
				equal = false;
			}
			if (Object1.SafeNameAddrLocState != null && Object2.SafeNameAddrLocState != null )
			{
				if (Object1.SafeNameAddrLocState != Object2.SafeNameAddrLocState)
					equal = false;
			}
			else if (Object1.SafeNameAddrLocState == null ^ Object1.SafeNameAddrLocState == null )
			{
				equal = false;
			}
			if (Object1.SafeNameAddrLocCity != null && Object2.SafeNameAddrLocCity != null )
			{
				if (Object1.SafeNameAddrLocCity != Object2.SafeNameAddrLocCity)
					equal = false;
			}
			else if (Object1.SafeNameAddrLocCity == null ^ Object1.SafeNameAddrLocCity == null )
			{
				equal = false;
			}
			if (Object1.SafeNameAddrPostalCode != null && Object2.SafeNameAddrPostalCode != null )
			{
				if (Object1.SafeNameAddrPostalCode != Object2.SafeNameAddrPostalCode)
					equal = false;
			}
			else if (Object1.SafeNameAddrPostalCode == null ^ Object1.SafeNameAddrPostalCode == null )
			{
				equal = false;
			}
			if (Object1.Email != null && Object2.Email != null )
			{
				if (Object1.Email != Object2.Email)
					equal = false;
			}
			else if (Object1.Email == null ^ Object1.Email == null )
			{
				equal = false;
			}
			if (Object1.WebSite != null && Object2.WebSite != null )
			{
				if (Object1.WebSite != Object2.WebSite)
					equal = false;
			}
			else if (Object1.WebSite == null ^ Object1.WebSite == null )
			{
				equal = false;
			}
			if (Object1.ModifiedDate != Object2.ModifiedDate)
				equal = false;
			return equal;
		}
		
		#endregion
		
		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}
	
		#endregion
		
		#region INotifyPropertyChanged Members
		
		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{ 
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}
		
		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}
		
		#endregion
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(VJobCandidate entity, string propertyName)
		{
			switch (propertyName)
			{
				case "JobCandidateId":
					return entity.JobCandidateId;
				case "EmployeeId":
					return entity.EmployeeId;
				case "SafeNameNamePrefix":
					return entity.SafeNameNamePrefix;
				case "SafeNameNameFirst":
					return entity.SafeNameNameFirst;
				case "SafeNameNameMiddle":
					return entity.SafeNameNameMiddle;
				case "SafeNameNameLast":
					return entity.SafeNameNameLast;
				case "SafeNameNameSuffix":
					return entity.SafeNameNameSuffix;
				case "Skills":
					return entity.Skills;
				case "SafeNameAddrType":
					return entity.SafeNameAddrType;
				case "SafeNameAddrLocCountryRegion":
					return entity.SafeNameAddrLocCountryRegion;
				case "SafeNameAddrLocState":
					return entity.SafeNameAddrLocState;
				case "SafeNameAddrLocCity":
					return entity.SafeNameAddrLocCity;
				case "SafeNameAddrPostalCode":
					return entity.SafeNameAddrPostalCode;
				case "Email":
					return entity.Email;
				case "WebSite":
					return entity.WebSite;
				case "ModifiedDate":
					return entity.ModifiedDate;
			}
			return null;
		}
				
		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{			
			return GetPropertyValueByName(this as VJobCandidate, propertyName);
		}
		
		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{17}{16}- JobCandidateId: {0}{16}- EmployeeId: {1}{16}- SafeNameNamePrefix: {2}{16}- SafeNameNameFirst: {3}{16}- SafeNameNameMiddle: {4}{16}- SafeNameNameLast: {5}{16}- SafeNameNameSuffix: {6}{16}- Skills: {7}{16}- SafeNameAddrType: {8}{16}- SafeNameAddrLocCountryRegion: {9}{16}- SafeNameAddrLocState: {10}{16}- SafeNameAddrLocCity: {11}{16}- SafeNameAddrPostalCode: {12}{16}- Email: {13}{16}- WebSite: {14}{16}- ModifiedDate: {15}{16}", 
				this.JobCandidateId,
				(this.EmployeeId == null) ? string.Empty : this.EmployeeId.ToString(),
			     
				(this.SafeNameNamePrefix == null) ? string.Empty : this.SafeNameNamePrefix.ToString(),
			     
				(this.SafeNameNameFirst == null) ? string.Empty : this.SafeNameNameFirst.ToString(),
			     
				(this.SafeNameNameMiddle == null) ? string.Empty : this.SafeNameNameMiddle.ToString(),
			     
				(this.SafeNameNameLast == null) ? string.Empty : this.SafeNameNameLast.ToString(),
			     
				(this.SafeNameNameSuffix == null) ? string.Empty : this.SafeNameNameSuffix.ToString(),
			     
				(this.Skills == null) ? string.Empty : this.Skills.ToString(),
			     
				(this.SafeNameAddrType == null) ? string.Empty : this.SafeNameAddrType.ToString(),
			     
				(this.SafeNameAddrLocCountryRegion == null) ? string.Empty : this.SafeNameAddrLocCountryRegion.ToString(),
			     
				(this.SafeNameAddrLocState == null) ? string.Empty : this.SafeNameAddrLocState.ToString(),
			     
				(this.SafeNameAddrLocCity == null) ? string.Empty : this.SafeNameAddrLocCity.ToString(),
			     
				(this.SafeNameAddrPostalCode == null) ? string.Empty : this.SafeNameAddrPostalCode.ToString(),
			     
				(this.Email == null) ? string.Empty : this.Email.ToString(),
			     
				(this.WebSite == null) ? string.Empty : this.WebSite.ToString(),
			     
				this.ModifiedDate,
				System.Environment.NewLine, 
				this.GetType());
		}
	
	}//End Class
	
	
	/// <summary>
	/// Enumerate the VJobCandidate columns.
	/// </summary>
	[Serializable]
	public enum VJobCandidateColumn
	{
		/// <summary>
		/// JobCandidateID : 
		/// </summary>
		[EnumTextValue("JobCandidateID")]
		[ColumnEnum("JobCandidateID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		JobCandidateId,
		/// <summary>
		/// EmployeeID : 
		/// </summary>
		[EnumTextValue("EmployeeID")]
		[ColumnEnum("EmployeeID", typeof(System.Int32), System.Data.DbType.Int32, false, false, true)]
		EmployeeId,
		/// <summary>
		/// Name.Prefix : 
		/// </summary>
		[EnumTextValue("Name.Prefix")]
		[ColumnEnum("Name.Prefix", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameNamePrefix,
		/// <summary>
		/// Name.First : 
		/// </summary>
		[EnumTextValue("Name.First")]
		[ColumnEnum("Name.First", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameNameFirst,
		/// <summary>
		/// Name.Middle : 
		/// </summary>
		[EnumTextValue("Name.Middle")]
		[ColumnEnum("Name.Middle", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameNameMiddle,
		/// <summary>
		/// Name.Last : 
		/// </summary>
		[EnumTextValue("Name.Last")]
		[ColumnEnum("Name.Last", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameNameLast,
		/// <summary>
		/// Name.Suffix : 
		/// </summary>
		[EnumTextValue("Name.Suffix")]
		[ColumnEnum("Name.Suffix", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameNameSuffix,
		/// <summary>
		/// Skills : 
		/// </summary>
		[EnumTextValue("Skills")]
		[ColumnEnum("Skills", typeof(System.String), System.Data.DbType.String, false, false, true)]
		Skills,
		/// <summary>
		/// Addr.Type : 
		/// </summary>
		[EnumTextValue("Addr.Type")]
		[ColumnEnum("Addr.Type", typeof(System.String), System.Data.DbType.String, false, false, true, 30)]
		SafeNameAddrType,
		/// <summary>
		/// Addr.Loc.CountryRegion : 
		/// </summary>
		[EnumTextValue("Addr.Loc.CountryRegion")]
		[ColumnEnum("Addr.Loc.CountryRegion", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameAddrLocCountryRegion,
		/// <summary>
		/// Addr.Loc.State : 
		/// </summary>
		[EnumTextValue("Addr.Loc.State")]
		[ColumnEnum("Addr.Loc.State", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameAddrLocState,
		/// <summary>
		/// Addr.Loc.City : 
		/// </summary>
		[EnumTextValue("Addr.Loc.City")]
		[ColumnEnum("Addr.Loc.City", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameAddrLocCity,
		/// <summary>
		/// Addr.PostalCode : 
		/// </summary>
		[EnumTextValue("Addr.PostalCode")]
		[ColumnEnum("Addr.PostalCode", typeof(System.String), System.Data.DbType.String, false, false, true, 20)]
		SafeNameAddrPostalCode,
		/// <summary>
		/// EMail : 
		/// </summary>
		[EnumTextValue("EMail")]
		[ColumnEnum("EMail", typeof(System.String), System.Data.DbType.String, false, false, true)]
		Email,
		/// <summary>
		/// WebSite : 
		/// </summary>
		[EnumTextValue("WebSite")]
		[ColumnEnum("WebSite", typeof(System.String), System.Data.DbType.String, false, false, true)]
		WebSite,
		/// <summary>
		/// ModifiedDate : 
		/// </summary>
		[EnumTextValue("ModifiedDate")]
		[ColumnEnum("ModifiedDate", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, false)]
		ModifiedDate
	}//End enum

} // end namespace
