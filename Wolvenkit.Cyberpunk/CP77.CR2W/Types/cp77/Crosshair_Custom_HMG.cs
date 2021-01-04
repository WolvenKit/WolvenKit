using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Custom_HMG : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("bottomPart")] public inkWidgetReference BottomPart { get; set; }
		[Ordinal(1)]  [RED("crosshairContainer")] public inkCanvasWidgetReference CrosshairContainer { get; set; }
		[Ordinal(2)]  [RED("forcedCooldownOptions")] public inkanimPlaybackOptions ForcedCooldownOptions { get; set; }
		[Ordinal(3)]  [RED("forcedCooldownProxy")] public CHandle<inkanimProxy> ForcedCooldownProxy { get; set; }
		[Ordinal(4)]  [RED("forcedOverheatBBID")] public CUInt32 ForcedOverheatBBID { get; set; }
		[Ordinal(5)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(6)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(7)]  [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(8)]  [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(9)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(10)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(11)]  [RED("overheatBBID")] public CUInt32 OverheatBBID { get; set; }
		[Ordinal(12)]  [RED("overheatContainer")] public inkWidgetReference OverheatContainer { get; set; }
		[Ordinal(13)]  [RED("overheatMask")] public inkWidgetReference OverheatMask { get; set; }
		[Ordinal(14)]  [RED("overheatValueL")] public inkTextWidgetReference OverheatValueL { get; set; }
		[Ordinal(15)]  [RED("overheatValueR")] public inkTextWidgetReference OverheatValueR { get; set; }
		[Ordinal(16)]  [RED("overheatWarning")] public inkWidgetReference OverheatWarning { get; set; }
		[Ordinal(17)]  [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(18)]  [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(19)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(20)]  [RED("topPart")] public inkWidgetReference TopPart { get; set; }
		[Ordinal(21)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(22)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }

		public Crosshair_Custom_HMG(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
