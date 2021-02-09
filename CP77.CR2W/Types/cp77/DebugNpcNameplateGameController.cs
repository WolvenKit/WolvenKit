using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(7)]  [RED("isToggledOn")] public CBool IsToggledOn { get; set; }
		[Ordinal(8)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(9)]  [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(10)]  [RED("nameplateProjection")] public CHandle<inkScreenProjection> NameplateProjection { get; set; }
		[Ordinal(11)]  [RED("bufferedNPC")] public wCHandle<gameObject> BufferedNPC { get; set; }
		[Ordinal(12)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(13)]  [RED("debugText1")] public wCHandle<inkTextWidget> DebugText1 { get; set; }
		[Ordinal(14)]  [RED("debugText2")] public wCHandle<inkTextWidget> DebugText2 { get; set; }

		public DebugNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
