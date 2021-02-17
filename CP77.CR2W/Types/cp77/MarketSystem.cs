using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MarketSystem : gameIMarketSystem
	{
		[Ordinal(0)] [RED("vendors")] public CArray<CHandle<Vendor>> Vendors { get; set; }
		[Ordinal(1)] [RED("vendingMachinesVendors")] public CArray<CHandle<Vendor>> VendingMachinesVendors { get; set; }

		public MarketSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
