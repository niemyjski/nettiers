﻿#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;

#endregion

namespace Nettiers.AdventureWorks.Data.WebServiceClient
{
	///<summary>
	/// This class is the WebServiceClient Data Access Logic Component implementation for the <see cref="TestProduct"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class WsTestProductProvider: WsTestProductProviderBase
	{		
		/// <summary>
		/// Creates a new <see cref="WsTestProductProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="url">The url to the nettiers webservice.</param>
		public WsTestProductProvider(string url): base(url){}
	}
}
