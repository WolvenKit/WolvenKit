using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsMainGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("scrollPanel")] public inkWidgetReference ScrollPanel { get; set; }
		[Ordinal(2)]  [RED("selectorWidget")] public inkWidgetReference SelectorWidget { get; set; }
		[Ordinal(3)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(4)]  [RED("settingsOptionsList")] public inkCompoundWidgetReference SettingsOptionsList { get; set; }
		[Ordinal(5)]  [RED("applyButton")] public inkWidgetReference ApplyButton { get; set; }
		[Ordinal(6)]  [RED("resetButton")] public inkWidgetReference ResetButton { get; set; }
		[Ordinal(7)]  [RED("defaultButton")] public inkWidgetReference DefaultButton { get; set; }
		[Ordinal(8)]  [RED("brightnessButton")] public inkWidgetReference BrightnessButton { get; set; }
		[Ordinal(9)]  [RED("hdrButton")] public inkWidgetReference HdrButton { get; set; }
		[Ordinal(10)]  [RED("controllerButton")] public inkWidgetReference ControllerButton { get; set; }
		[Ordinal(11)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(12)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(13)]  [RED("settingsElements")] public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements { get; set; }
		[Ordinal(14)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(15)]  [RED("data")] public CArray<SettingsCategory> Data { get; set; }
		[Ordinal(16)]  [RED("menusList")] public CArray<CName> MenusList { get; set; }
		[Ordinal(17)]  [RED("eventsList")] public CArray<CName> EventsList { get; set; }
		[Ordinal(18)]  [RED("settingsListener")] public CHandle<SettingsVarListener> SettingsListener { get; set; }
		[Ordinal(19)]  [RED("settingsNotificationListener")] public CHandle<SettingsNotificationListener> SettingsNotificationListener { get; set; }
		[Ordinal(20)]  [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(21)]  [RED("isPreGame")] public CBool IsPreGame { get; set; }
		[Ordinal(22)]  [RED("applyButtonEnabled")] public CBool ApplyButtonEnabled { get; set; }
		[Ordinal(23)]  [RED("resetButtonEnabled")] public CBool ResetButtonEnabled { get; set; }
		[Ordinal(24)]  [RED("closeSettingsRequest")] public CBool CloseSettingsRequest { get; set; }
		[Ordinal(25)]  [RED("selectorCtrl")] public wCHandle<inkListController> SelectorCtrl { get; set; }

		public SettingsMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
