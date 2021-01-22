using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(1)]  [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(2)]  [RED("isInForcedCool")] public CBool IsInForcedCool { get; set; }
		[Ordinal(3)]  [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(4)]  [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(5)]  [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(6)]  [RED("middlePart")] public inkWidgetReference MiddlePart { get; set; }
		[Ordinal(7)]  [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(8)]  [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(9)]  [RED("onChargeChangeBBID")] public CUInt32 OnChargeChangeBBID { get; set; }
		[Ordinal(10)]  [RED("overheatBL")] public inkWidgetReference OverheatBL { get; set; }
		[Ordinal(11)]  [RED("overheatBR")] public inkWidgetReference OverheatBR { get; set; }
		[Ordinal(12)]  [RED("overheatShake")] public inkWidgetReference OverheatShake { get; set; }
		[Ordinal(13)]  [RED("overheatTL")] public inkWidgetReference OverheatTL { get; set; }
		[Ordinal(14)]  [RED("overheatTR")] public inkWidgetReference OverheatTR { get; set; }
		[Ordinal(15)]  [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(16)]  [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(17)]  [RED("shakeAnimation")] public CHandle<inkanimProxy> ShakeAnimation { get; set; }
		[Ordinal(18)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(19)]  [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(20)]  [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(21)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }

		public CrosshairGameController_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
