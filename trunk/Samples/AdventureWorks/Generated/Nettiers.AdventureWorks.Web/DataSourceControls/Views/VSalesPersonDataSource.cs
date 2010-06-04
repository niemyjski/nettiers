﻿#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;
using Nettiers.AdventureWorks.Services;
#endregion

namespace Nettiers.AdventureWorks.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.VSalesPersonProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VSalesPersonDataSourceDesigner))]
	public class VSalesPersonDataSource : ReadOnlyDataSource<VSalesPerson>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VSalesPersonDataSource class.
		/// </summary>
		public VSalesPersonDataSource() : base(new VSalesPersonService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VSalesPersonDataSourceView used by the VSalesPersonDataSource.
		/// </summary>
		protected VSalesPersonDataSourceView VSalesPersonView
		{
			get { return ( View as VSalesPersonDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VSalesPersonDataSourceView class that is to be
		/// used by the VSalesPersonDataSource.
		/// </summary>
		/// <returns>An instance of the VSalesPersonDataSourceView class.</returns>
		protected override BaseDataSourceView<VSalesPerson, Object> GetNewDataSourceView()
		{
			return new VSalesPersonDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the VSalesPersonDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VSalesPersonDataSourceView : ReadOnlyDataSourceView<VSalesPerson>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VSalesPersonDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VSalesPersonDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VSalesPersonDataSourceView(VSalesPersonDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VSalesPersonDataSource VSalesPersonOwner
		{
			get { return Owner as VSalesPersonDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VSalesPersonService VSalesPersonProvider
		{
			get { return Provider as VSalesPersonService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VSalesPersonDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VSalesPersonDataSource class.
	/// </summary>
	public class VSalesPersonDataSourceDesigner : ReadOnlyDataSourceDesigner<VSalesPerson>
	{
	}

	#endregion VSalesPersonDataSourceDesigner

	#region VSalesPersonFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VSalesPerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VSalesPersonFilter : SqlFilter<VSalesPersonColumn>
	{
	}

	#endregion VSalesPersonFilter

	#region VSalesPersonExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VSalesPerson"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VSalesPersonExpressionBuilder : SqlExpressionBuilder<VSalesPersonColumn>
	{
	}
	
	#endregion VSalesPersonExpressionBuilder		
}

