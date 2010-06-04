﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'Document' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDocument 
	{
		/// <summary>			
		/// DocumentID : Primary key for Document records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Document"</remarks>
		System.Int32 DocumentId { get; set; }
				
		
		
		/// <summary>
		/// Title : Title of the document.
		/// </summary>
		System.String  Title  { get; set; }
		
		/// <summary>
		/// FileName : Directory path and file name of the document
		/// </summary>
		System.String  FileName  { get; set; }
		
		/// <summary>
		/// FileExtension : File extension indicating the document type. For example, .doc or .txt.
		/// </summary>
		System.String  FileExtension  { get; set; }
		
		/// <summary>
		/// Revision : Revision number of the document. 
		/// </summary>
		System.String  Revision  { get; set; }
		
		/// <summary>
		/// ChangeNumber : Engineering change approval number.
		/// </summary>
		System.Int32  ChangeNumber  { get; set; }
		
		/// <summary>
		/// Status : 1 = Pending approval, 2 = Approved, 3 = Obsolete
		/// </summary>
		System.Byte  Status  { get; set; }
		
		/// <summary>
		/// DocumentSummary : Document abstract.
		/// </summary>
		System.String  DocumentSummary  { get; set; }
		
		/// <summary>
		/// Document : Complete document.
		/// </summary>
		System.Byte[]  Document  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _productDocumentDocumentId
		/// </summary>	
		TList<ProductDocument> ProductDocumentCollection {  get;  set;}	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table productIdProductCollectionFromProductDocument
		/// </summary>	
		TList<Product> ProductIdProductCollection_From_ProductDocument { get; set; }	

		#endregion Data Properties

	}
}


