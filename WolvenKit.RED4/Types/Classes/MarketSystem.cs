using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarketSystem : gameIMarketSystem
	{
		[Ordinal(0)] 
		[RED("vendors")] 
		public CArray<CHandle<Vendor>> Vendors
		{
			get => GetPropertyValue<CArray<CHandle<Vendor>>>();
			set => SetPropertyValue<CArray<CHandle<Vendor>>>(value);
		}

		[Ordinal(1)] 
		[RED("vendingMachinesVendors")] 
		public CArray<CHandle<Vendor>> VendingMachinesVendors
		{
			get => GetPropertyValue<CArray<CHandle<Vendor>>>();
			set => SetPropertyValue<CArray<CHandle<Vendor>>>(value);
		}

		public MarketSystem()
		{
			Vendors = new();
			VendingMachinesVendors = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
