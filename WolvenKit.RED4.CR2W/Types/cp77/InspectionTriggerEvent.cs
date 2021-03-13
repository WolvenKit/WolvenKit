using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionTriggerEvent : redEvent
	{
		[Ordinal(0)] [RED("item")] public CString Item { get; set; }
		[Ordinal(1)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(2)] [RED("adsOffset")] public CFloat AdsOffset { get; set; }
		[Ordinal(3)] [RED("timeToScan")] public CFloat TimeToScan { get; set; }
		[Ordinal(4)] [RED("inspectedObjID")] public entEntityID InspectedObjID { get; set; }

		public InspectionTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
