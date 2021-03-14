using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHDRSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("callibrationScreen")] public rRef<CBitmapTexture> CallibrationScreen { get; set; }
		[Ordinal(4)] [RED("callibrationScreenTarget")] public inkWidgetReference CallibrationScreenTarget { get; set; }
		[Ordinal(5)] [RED("callibrationScreenAtlas")] public raRef<inkTextureAtlas> CallibrationScreenAtlas { get; set; }
		[Ordinal(6)] [RED("s_maxBrightnessGroup")] public CName S_maxBrightnessGroup { get; set; }
		[Ordinal(7)] [RED("s_paperWhiteGroup")] public CName S_paperWhiteGroup { get; set; }
		[Ordinal(8)] [RED("s_toneMappingeGroup")] public CName S_toneMappingeGroup { get; set; }
		[Ordinal(9)] [RED("s_calibrationImageDay")] public CName S_calibrationImageDay { get; set; }
		[Ordinal(10)] [RED("s_calibrationImageNight")] public CName S_calibrationImageNight { get; set; }
		[Ordinal(11)] [RED("s_currentCalibrationImage")] public CName S_currentCalibrationImage { get; set; }
		[Ordinal(12)] [RED("paperWhiteOptionSelector")] public inkCompoundWidgetReference PaperWhiteOptionSelector { get; set; }
		[Ordinal(13)] [RED("maxBrightnessOptionSelector")] public inkCompoundWidgetReference MaxBrightnessOptionSelector { get; set; }
		[Ordinal(14)] [RED("toneMappingOptionSelector")] public inkCompoundWidgetReference ToneMappingOptionSelector { get; set; }
		[Ordinal(15)] [RED("targetImageWidget")] public inkWidgetReference TargetImageWidget { get; set; }
		[Ordinal(16)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(17)] [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(18)] [RED("settingsListener")] public CHandle<HDRSettingsVarListener> SettingsListener { get; set; }
		[Ordinal(19)] [RED("SettingsElements")] public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements { get; set; }
		[Ordinal(20)] [RED("isPreGame")] public CBool IsPreGame { get; set; }
		[Ordinal(21)] [RED("calibrationImagesCycleAnimDef")] public CHandle<inkanimDefinition> CalibrationImagesCycleAnimDef { get; set; }
		[Ordinal(22)] [RED("calibrationImagesCycleProxy")] public CHandle<inkanimProxy> CalibrationImagesCycleProxy { get; set; }

		public gameuiHDRSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
