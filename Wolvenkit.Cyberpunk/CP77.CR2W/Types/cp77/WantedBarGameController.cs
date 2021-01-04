using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WantedBarGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("WANTED_MIN")] public CFloat WANTED_MIN { get; set; }
		[Ordinal(1)]  [RED("WANTED_TIER_1")] public CFloat WANTED_TIER_1 { get; set; }
		[Ordinal(2)]  [RED("animOptionsLoop")] public inkanimPlaybackOptions AnimOptionsLoop { get; set; }
		[Ordinal(3)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(4)]  [RED("attentionAnimProxy")] public CHandle<inkanimProxy> AttentionAnimProxy { get; set; }
		[Ordinal(5)]  [RED("bountyAnimProxy")] public CHandle<inkanimProxy> BountyAnimProxy { get; set; }
		[Ordinal(6)]  [RED("rootWidget")] public CHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(7)]  [RED("starsWidget")] public CArray<inkWidgetReference> StarsWidget { get; set; }
		[Ordinal(8)]  [RED("wantedBlackboard")] public CHandle<gameIBlackboard> WantedBlackboard { get; set; }
		[Ordinal(9)]  [RED("wantedBlackboardDef")] public CHandle<UI_WantedBarDef> WantedBlackboardDef { get; set; }
		[Ordinal(10)]  [RED("wantedCallbackID")] public CUInt32 WantedCallbackID { get; set; }
		[Ordinal(11)]  [RED("wantedLevel")] public CInt32 WantedLevel { get; set; }

		public WantedBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
