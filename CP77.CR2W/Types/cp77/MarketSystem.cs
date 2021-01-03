using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MarketSystem : gameIMarketSystem
	{
		[Ordinal(0)]  [RED("vendingMachinesVendors")] public CArray<CHandle<Vendor>> VendingMachinesVendors { get; set; }
		[Ordinal(1)]  [RED("vendors")] public CArray<CHandle<Vendor>> Vendors { get; set; }

		public MarketSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
