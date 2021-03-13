using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(19)] [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(20)] [RED("upPart")] public inkImageWidgetReference UpPart { get; set; }
		[Ordinal(21)] [RED("downPart")] public inkImageWidgetReference DownPart { get; set; }
		[Ordinal(22)] [RED("centerPart")] public inkImageWidgetReference CenterPart { get; set; }
		[Ordinal(23)] [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(24)] [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(25)] [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(26)] [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(27)] [RED("ricochetModeActive")] public CUInt32 RicochetModeActive { get; set; }
		[Ordinal(28)] [RED("RicochetChance")] public CUInt32 RicochetChance { get; set; }
		[Ordinal(29)] [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(30)] [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(31)] [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(32)] [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }

		public CrosshairGameController_Basic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
