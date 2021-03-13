using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrightnessSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("s_brightnessGroup")] public CName S_brightnessGroup { get; set; }
		[Ordinal(4)] [RED("settingsOptionsList")] public inkCompoundWidgetReference SettingsOptionsList { get; set; }
		[Ordinal(5)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(6)] [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(7)] [RED("settingsListener")] public CHandle<BrightnessSettingsVarListener> SettingsListener { get; set; }
		[Ordinal(8)] [RED("SettingsElements")] public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements { get; set; }
		[Ordinal(9)] [RED("isPreGame")] public CBool IsPreGame { get; set; }

		public BrightnessSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
