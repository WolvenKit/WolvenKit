using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChattersGameController : BaseSubtitlesGameController
	{
		[Ordinal(28)] [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(29)] [RED("c_CloseDisplayRange")] public CFloat C_CloseDisplayRange { get; set; }
		[Ordinal(30)] [RED("c_TimeToUnblockSec")] public CFloat C_TimeToUnblockSec { get; set; }
		[Ordinal(31)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(32)] [RED("AllControllers")] public CArray<ChatterKeyValuePair> AllControllers { get; set; }
		[Ordinal(33)] [RED("targetingSystem")] public CHandle<gametargetingTargetingSystem> TargetingSystem { get; set; }
		[Ordinal(34)] [RED("broadcastBlockingLines")] public CArray<CRUID> BroadcastBlockingLines { get; set; }
		[Ordinal(35)] [RED("playerInDialogChoice")] public CBool PlayerInDialogChoice { get; set; }
		[Ordinal(36)] [RED("lastBroadcastBlockingLineTime")] public EngineTime LastBroadcastBlockingLineTime { get; set; }
		[Ordinal(37)] [RED("lastChoiceTime")] public EngineTime LastChoiceTime { get; set; }
		[Ordinal(38)] [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(39)] [RED("sceneTier")] public CInt32 SceneTier { get; set; }

		public ChattersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
