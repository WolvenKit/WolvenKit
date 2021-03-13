using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPinInfo : CVariable
	{
		[Ordinal(0)] [RED("shouldShow")] public CBool ShouldShow { get; set; }
		[Ordinal(1)] [RED("showFloorAbove")] public CBool ShowFloorAbove { get; set; }
		[Ordinal(2)] [RED("showFloorBelow")] public CBool ShowFloorBelow { get; set; }
		[Ordinal(3)] [RED("iconType")] public CInt32 IconType { get; set; }
		[Ordinal(4)] [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(5)] [RED("displayText")] public CString DisplayText { get; set; }

		public gameuiPinInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
