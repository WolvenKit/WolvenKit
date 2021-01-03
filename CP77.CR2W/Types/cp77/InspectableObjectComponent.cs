using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("adsOffset")] public CFloat AdsOffset { get; set; }
		[Ordinal(1)]  [RED("factToAdd")] public CName FactToAdd { get; set; }
		[Ordinal(2)]  [RED("itemID")] public CString ItemID { get; set; }
		[Ordinal(3)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(4)]  [RED("slot")] public CString Slot { get; set; }
		[Ordinal(5)]  [RED("timeToScan")] public CFloat TimeToScan { get; set; }

		public InspectableObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
