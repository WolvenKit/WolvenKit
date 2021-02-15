using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WantedBarGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("starsWidget")] public CArray<inkWidgetReference> StarsWidget { get; set; }
		[Ordinal(10)] [RED("wantedBlackboard")] public CHandle<gameIBlackboard> WantedBlackboard { get; set; }
		[Ordinal(11)] [RED("wantedBlackboardDef")] public CHandle<UI_WantedBarDef> WantedBlackboardDef { get; set; }
		[Ordinal(12)] [RED("wantedCallbackID")] public CUInt32 WantedCallbackID { get; set; }
		[Ordinal(13)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(14)] [RED("attentionAnimProxy")] public CHandle<inkanimProxy> AttentionAnimProxy { get; set; }
		[Ordinal(15)] [RED("bountyAnimProxy")] public CHandle<inkanimProxy> BountyAnimProxy { get; set; }
		[Ordinal(16)] [RED("animOptionsLoop")] public inkanimPlaybackOptions AnimOptionsLoop { get; set; }
		[Ordinal(17)] [RED("wantedLevel")] public CInt32 WantedLevel { get; set; }
		[Ordinal(18)] [RED("rootWidget")] public CHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(19)] [RED("WANTED_TIER_1")] public CFloat WANTED_TIER_1 { get; set; }
		[Ordinal(20)] [RED("WANTED_MIN")] public CFloat WANTED_MIN { get; set; }

		public WantedBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
