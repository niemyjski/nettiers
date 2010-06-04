﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'SalesOrderDetail' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ISalesOrderDetail 
	{
		/// <summary>			
		/// SalesOrderID : Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SalesOrderDetail"</remarks>
		System.Int32 SalesOrderId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalSalesOrderId { get; set; }
			
		/// <summary>			
		/// SalesOrderDetailID : Primary key. One incremental unique number per product sold.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "SalesOrderDetail"</remarks>
		System.Int32 SalesOrderDetailId { get; set; }
				
		
		
		/// <summary>
		/// CarrierTrackingNumber : Shipment tracking number supplied by the shipper.
		/// </summary>
		System.String  CarrierTrackingNumber  { get; set; }
		
		/// <summary>
		/// OrderQty : Quantity ordered per product.
		/// </summary>
		System.Int16  OrderQty  { get; set; }
		
		/// <summary>
		/// ProductID : Product sold to customer. Foreign key to Product.ProductID.
		/// </summary>
		System.Int32  ProductId  { get; set; }
		
		/// <summary>
		/// SpecialOfferID : Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
		/// </summary>
		System.Int32  SpecialOfferId  { get; set; }
		
		/// <summary>
		/// UnitPrice : Selling price of a single product.
		/// </summary>
		System.Decimal  UnitPrice  { get; set; }
		
		/// <summary>
		/// UnitPriceDiscount : Discount amount.
		/// </summary>
		System.Decimal  UnitPriceDiscount  { get; set; }
		
		/// <summary>
		/// LineTotal : Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
		/// </summary>
		System.Decimal  LineTotal  { get; set; }
		
		/// <summary>
		/// rowguid : ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
		/// </summary>
		System.Guid  Rowguid  { get; set; }
		
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

		#endregion Data Properties

	}
}


