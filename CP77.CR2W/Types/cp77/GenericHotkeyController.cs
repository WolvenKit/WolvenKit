using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GenericHotkeyController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("buttonHint")] public inkWidgetReference ButtonHint { get; set; }
		[Ordinal(1)]  [RED("buttonHintController")] public CHandle<inkInputDisplayController> ButtonHintController { get; set; }
		[Ordinal(2)]  [RED("debugCommands")] public CArray<CUInt32> DebugCommands { get; set; }
		[Ordinal(3)]  [RED("factListenerId")] public CUInt32 FactListenerId { get; set; }
		[Ordinal(4)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(5)]  [RED("hotkeyBackground")] public inkImageWidgetReference HotkeyBackground { get; set; }
		[Ordinal(6)]  [RED("pressStarted")] public CBool PressStarted { get; set; }
		[Ordinal(7)]  [RED("questActivatingFact")] public CName QuestActivatingFact { get; set; }
		[Ordinal(8)]  [RED("restrictions")] public CArray<CName> Restrictions { get; set; }
		[Ordinal(9)]  [RED("statusEffectsListener")] public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener { get; set; }

		public GenericHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
