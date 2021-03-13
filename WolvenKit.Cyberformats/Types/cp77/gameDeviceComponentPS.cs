using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDeviceComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("markAsQuest")] public CBool MarkAsQuest { get; set; }
		[Ordinal(1)] [RED("autoToggleQuestMark")] public CBool AutoToggleQuestMark { get; set; }
		[Ordinal(2)] [RED("factToDisableQuestMark")] public CName FactToDisableQuestMark { get; set; }
		[Ordinal(3)] [RED("callbackToDisableQuestMarkID")] public CUInt32 CallbackToDisableQuestMarkID { get; set; }
		[Ordinal(4)] [RED("backdoorObjectiveData")] public CHandle<BackDoorObjectiveData> BackdoorObjectiveData { get; set; }
		[Ordinal(5)] [RED("controlPanelObjectiveData")] public CHandle<ControlPanelObjectiveData> ControlPanelObjectiveData { get; set; }
		[Ordinal(6)] [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(7)] [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(8)] [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(9)] [RED("exposeQuickHacks")] public CBool ExposeQuickHacks { get; set; }
		[Ordinal(10)] [RED("isAttachedToGame")] public CBool IsAttachedToGame { get; set; }
		[Ordinal(11)] [RED("isLogicReady")] public CBool IsLogicReady { get; set; }

		public gameDeviceComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
