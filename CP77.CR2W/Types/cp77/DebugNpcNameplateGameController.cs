using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DebugNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("bbNPCStatsInfo")] public CUInt32 BbNPCStatsInfo { get; set; }
		[Ordinal(1)]  [RED("bufferedNPC")] public wCHandle<gameObject> BufferedNPC { get; set; }
		[Ordinal(2)]  [RED("debugText1")] public wCHandle<inkTextWidget> DebugText1 { get; set; }
		[Ordinal(3)]  [RED("debugText2")] public wCHandle<inkTextWidget> DebugText2 { get; set; }
		[Ordinal(4)]  [RED("isToggledOn")] public CBool IsToggledOn { get; set; }
		[Ordinal(5)]  [RED("nameplateProjection")] public CHandle<inkScreenProjection> NameplateProjection { get; set; }
		[Ordinal(6)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(7)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }

		public DebugNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
