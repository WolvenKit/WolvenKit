using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("s_brightnessGroup")] public CName S_brightnessGroup { get; set; }
		[Ordinal(2)]  [RED("settingsOptionsList")] public inkCompoundWidgetReference SettingsOptionsList { get; set; }
		[Ordinal(3)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(4)]  [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(5)]  [RED("settingsListener")] public CHandle<BrightnessSettingsVarListener> SettingsListener { get; set; }
		[Ordinal(6)]  [RED("SettingsElements")] public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements { get; set; }
		[Ordinal(7)]  [RED("isPreGame")] public CBool IsPreGame { get; set; }

		public BrightnessSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
