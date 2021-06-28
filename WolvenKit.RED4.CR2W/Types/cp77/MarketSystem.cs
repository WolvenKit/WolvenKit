using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketSystem : gameIMarketSystem
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

		public MarketSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
