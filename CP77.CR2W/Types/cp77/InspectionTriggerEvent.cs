using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InspectionTriggerEvent : redEvent
	{
		[Ordinal(0)]  [RED("adsOffset")] public CFloat AdsOffset { get; set; }
		[Ordinal(1)]  [RED("inspectedObjID")] public entEntityID InspectedObjID { get; set; }
		[Ordinal(2)]  [RED("item")] public CString Item { get; set; }
		[Ordinal(3)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(4)]  [RED("timeToScan")] public CFloat TimeToScan { get; set; }

		public InspectionTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
