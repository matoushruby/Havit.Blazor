﻿namespace Havit.Blazor.Components.Web.Bootstrap
{
	/// <summary>
	/// Data provider (delegate).
	/// </summary>
	public delegate Task<GridDataProviderResult<TItem>> GridDataProviderDelegate<TItem>(GridDataProviderRequest<TItem> request);
}
