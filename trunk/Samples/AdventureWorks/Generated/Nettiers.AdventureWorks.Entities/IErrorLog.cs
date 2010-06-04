﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'ErrorLog' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IErrorLog 
	{
		/// <summary>			
		/// ErrorLogID : Primary key for ErrorLog records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ErrorLog"</remarks>
		System.Int32 ErrorLogId { get; set; }
				
		
		
		/// <summary>
		/// ErrorTime : The date and time at which the error occurred.
		/// </summary>
		System.DateTime  ErrorTime  { get; set; }
		
		/// <summary>
		/// UserName : The user who executed the batch in which the error occurred.
		/// </summary>
		System.String  UserName  { get; set; }
		
		/// <summary>
		/// ErrorNumber : The error number of the error that occurred.
		/// </summary>
		System.Int32  ErrorNumber  { get; set; }
		
		/// <summary>
		/// ErrorSeverity : The severity of the error that occurred.
		/// </summary>
		System.Int32?  ErrorSeverity  { get; set; }
		
		/// <summary>
		/// ErrorState : The state number of the error that occurred.
		/// </summary>
		System.Int32?  ErrorState  { get; set; }
		
		/// <summary>
		/// ErrorProcedure : The name of the stored procedure or trigger where the error occurred.
		/// </summary>
		System.String  ErrorProcedure  { get; set; }
		
		/// <summary>
		/// ErrorLine : The line number at which the error occurred.
		/// </summary>
		System.Int32?  ErrorLine  { get; set; }
		
		/// <summary>
		/// ErrorMessage : The message text of the error that occurred.
		/// </summary>
		System.String  ErrorMessage  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


