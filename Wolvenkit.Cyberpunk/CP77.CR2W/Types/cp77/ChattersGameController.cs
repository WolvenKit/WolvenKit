using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChattersGameController : BaseSubtitlesGameController
	{
		[Ordinal(0)]  [RED("AllControllers")] public CArray<ChatterKeyValuePair> AllControllers { get; set; }
		[Ordinal(1)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(2)]  [RED("broadcastBlockingLines")] public CArray<CRUID> BroadcastBlockingLines { get; set; }
		[Ordinal(3)]  [RED("c_CloseDisplayRange")] public CFloat C_CloseDisplayRange { get; set; }
		[Ordinal(4)]  [RED("c_DisplayRange")] public CFloat C_DisplayRange { get; set; }
		[Ordinal(5)]  [RED("c_TimeToUnblockSec")] public CFloat C_TimeToUnblockSec { get; set; }
		[Ordinal(6)]  [RED("lastBroadcastBlockingLineTime")] public EngineTime LastBroadcastBlockingLineTime { get; set; }
		[Ordinal(7)]  [RED("lastChoiceTime")] public EngineTime LastChoiceTime { get; set; }
		[Ordinal(8)]  [RED("playerInDialogChoice")] public CBool PlayerInDialogChoice { get; set; }
		[Ordinal(9)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(10)]  [RED("sceneTier")] public CInt32 SceneTier { get; set; }
		[Ordinal(11)]  [RED("targetingSystem")] public CHandle<gametargetingTargetingSystem> TargetingSystem { get; set; }

		public ChattersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
