using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Custom_HMG : gameuiCrosshairBaseGameController
	{
		[Ordinal(16)]  [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(17)]  [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(18)]  [RED("topPart")] public inkWidgetReference TopPart { get; set; }
		[Ordinal(19)]  [RED("bottomPart")] public inkWidgetReference BottomPart { get; set; }
		[Ordinal(20)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(21)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(22)]  [RED("overheatContainer")] public inkWidgetReference OverheatContainer { get; set; }
		[Ordinal(23)]  [RED("overheatWarning")] public inkWidgetReference OverheatWarning { get; set; }
		[Ordinal(24)]  [RED("overheatMask")] public inkWidgetReference OverheatMask { get; set; }
		[Ordinal(25)]  [RED("overheatValueL")] public inkTextWidgetReference OverheatValueL { get; set; }
		[Ordinal(26)]  [RED("overheatValueR")] public inkTextWidgetReference OverheatValueR { get; set; }
		[Ordinal(27)]  [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(28)]  [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(29)]  [RED("crosshairContainer")] public inkCanvasWidgetReference CrosshairContainer { get; set; }
		[Ordinal(30)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(31)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(32)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(33)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(34)]  [RED("overheatBBID")] public CUInt32 OverheatBBID { get; set; }
		[Ordinal(35)]  [RED("forcedOverheatBBID")] public CUInt32 ForcedOverheatBBID { get; set; }
		[Ordinal(36)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(37)]  [RED("forcedCooldownProxy")] public CHandle<inkanimProxy> ForcedCooldownProxy { get; set; }
		[Ordinal(38)]  [RED("forcedCooldownOptions")] public inkanimPlaybackOptions ForcedCooldownOptions { get; set; }

		public Crosshair_Custom_HMG(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
