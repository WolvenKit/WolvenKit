using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("factToAdd")] public CName FactToAdd { get; set; }
		[Ordinal(6)] [RED("itemID")] public CString ItemID { get; set; }
		[Ordinal(7)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(8)] [RED("adsOffset")] public CFloat AdsOffset { get; set; }
		[Ordinal(9)] [RED("timeToScan")] public CFloat TimeToScan { get; set; }
		[Ordinal(10)] [RED("slot")] public CString Slot { get; set; }

		public InspectableObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
