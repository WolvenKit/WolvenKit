using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarketSystem : gameIMarketSystem
	{
		[Ordinal(0)] [RED("vendors")] public CArray<CHandle<Vendor>> Vendors { get; set; }
		[Ordinal(1)] [RED("vendingMachinesVendors")] public CArray<CHandle<Vendor>> VendingMachinesVendors { get; set; }

		public MarketSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
