using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimeMenuGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("selectTimeText")] public inkWidgetReference SelectTimeText { get; set; }
		[Ordinal(3)] [RED("selectorRef")] public inkWidgetReference SelectorRef { get; set; }
		[Ordinal(4)] [RED("currentTime")] public inkTextWidgetReference CurrentTime { get; set; }
		[Ordinal(5)] [RED("applyBtn")] public inkWidgetReference ApplyBtn { get; set; }
		[Ordinal(6)] [RED("backBtn")] public inkWidgetReference BackBtn { get; set; }
		[Ordinal(7)] [RED("combatWarning")] public inkTextWidgetReference CombatWarning { get; set; }
		[Ordinal(8)] [RED("data")] public CHandle<TimeSkipPopupData> Data { get; set; }
		[Ordinal(9)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(10)] [RED("inputEnabled")] public CBool InputEnabled { get; set; }
		[Ordinal(11)] [RED("timeChanged")] public CBool TimeChanged { get; set; }
		[Ordinal(12)] [RED("selectorCtrl")] public wCHandle<inkSelectorController> SelectorCtrl { get; set; }
		[Ordinal(13)] [RED("timeSystem")] public CHandle<gameTimeSystem> TimeSystem { get; set; }
		[Ordinal(14)] [RED("hoursToSkip")] public CInt32 HoursToSkip { get; set; }
		[Ordinal(15)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(16)] [RED("currentTimeTextParams")] public CHandle<textTextParameterSet> CurrentTimeTextParams { get; set; }
		[Ordinal(17)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(18)] [RED("playerSpawnedCallbackID")] public CUInt32 PlayerSpawnedCallbackID { get; set; }

		public TimeMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
