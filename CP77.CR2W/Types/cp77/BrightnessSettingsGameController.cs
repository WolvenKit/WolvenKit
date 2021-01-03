using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("SettingsElements")] public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements { get; set; }
		[Ordinal(1)]  [RED("isPreGame")] public CBool IsPreGame { get; set; }
		[Ordinal(2)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(3)]  [RED("s_brightnessGroup")] public CName S_brightnessGroup { get; set; }
		[Ordinal(4)]  [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(5)]  [RED("settingsListener")] public CHandle<BrightnessSettingsVarListener> SettingsListener { get; set; }
		[Ordinal(6)]  [RED("settingsOptionsList")] public inkCompoundWidgetReference SettingsOptionsList { get; set; }

		public BrightnessSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
