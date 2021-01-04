using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleCollisionMapItem : CVariable
	{
		[Ordinal(0)]  [RED("impactEvent")] public CName ImpactEvent { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("scrapingLoopEnd")] public CName ScrapingLoopEnd { get; set; }
		[Ordinal(3)]  [RED("scrapingLoopStart")] public CName ScrapingLoopStart { get; set; }

		public audioVehicleCollisionMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
