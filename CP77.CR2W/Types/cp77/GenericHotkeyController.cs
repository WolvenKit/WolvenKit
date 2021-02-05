using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericHotkeyController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("debugCommands")] public CArray<CUInt32> DebugCommands { get; set; }
		[Ordinal(8)]  [RED("hotkeyBackground")] public inkImageWidgetReference HotkeyBackground { get; set; }
		[Ordinal(9)]  [RED("buttonHint")] public inkWidgetReference ButtonHint { get; set; }
		[Ordinal(10)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(11)]  [RED("pressStarted")] public CBool PressStarted { get; set; }
		[Ordinal(12)]  [RED("buttonHintController")] public CHandle<inkInputDisplayController> ButtonHintController { get; set; }
		[Ordinal(13)]  [RED("questActivatingFact")] public CName QuestActivatingFact { get; set; }
		[Ordinal(14)]  [RED("restrictions")] public CArray<CName> Restrictions { get; set; }
		[Ordinal(15)]  [RED("statusEffectsListener")] public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener { get; set; }
		[Ordinal(16)]  [RED("factListenerId")] public CUInt32 FactListenerId { get; set; }

		public GenericHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
