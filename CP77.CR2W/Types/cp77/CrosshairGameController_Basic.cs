using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("RicochetChance")] public CUInt32 RicochetChance { get; set; }
		[Ordinal(1)]  [RED("bbcurrentFireMode")] public CUInt32 BbcurrentFireMode { get; set; }
		[Ordinal(2)]  [RED("bufferedSpread")] public Vector2 BufferedSpread { get; set; }
		[Ordinal(3)]  [RED("centerPart")] public inkImageWidgetReference CenterPart { get; set; }
		[Ordinal(4)]  [RED("currentFireMode")] public CEnum<gamedataTriggerMode> CurrentFireMode { get; set; }
		[Ordinal(5)]  [RED("downPart")] public inkImageWidgetReference DownPart { get; set; }
		[Ordinal(6)]  [RED("gameplaySpreadMultiplier")] public CFloat GameplaySpreadMultiplier { get; set; }
		[Ordinal(7)]  [RED("horizontalMinSpread")] public CFloat HorizontalMinSpread { get; set; }
		[Ordinal(8)]  [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(9)]  [RED("ricochetModeActive")] public CUInt32 RicochetModeActive { get; set; }
		[Ordinal(10)]  [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(11)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(12)]  [RED("upPart")] public inkImageWidgetReference UpPart { get; set; }
		[Ordinal(13)]  [RED("verticalMinSpread")] public CFloat VerticalMinSpread { get; set; }
		[Ordinal(14)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }

		public CrosshairGameController_Basic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
