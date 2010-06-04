﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'NullFKeyParent' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface INullFkeyParent 
	{
		/// <summary>			
		/// NullFKeyParentID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "NullFKeyParent"</remarks>
		System.Int32 NullFkeyParentId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalNullFkeyParentId { get; set; }
			
		
		
		/// <summary>
		/// SomeText : 
		/// </summary>
		System.String  SomeText  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _nullFkeyChildNullFkeyParentId
		/// </summary>	
		TList<NullFkeyChild> NullFkeyChildCollection {  get;  set;}	

		#endregion Data Properties

	}
}


