using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MarketSystem : gameIMarketSystem
	{
		private CArray<CHandle<Vendor>> _vendors;
		private CArray<CHandle<Vendor>> _vendingMachinesVendors;

		[Ordinal(0)] 
		[RED("vendors")] 
		public CArray<CHandle<Vendor>> Vendors
		{
			get => GetProperty(ref _vendors);
			set => SetProperty(ref _vendors, value);
		}

		[Ordinal(1)] 
		[RED("vendingMachinesVendors")] 
		public CArray<CHandle<Vendor>> VendingMachinesVendors
		{
			get => GetProperty(ref _vendingMachinesVendors);
			set => SetProperty(ref _vendingMachinesVendors, value);
		}
	}
}
