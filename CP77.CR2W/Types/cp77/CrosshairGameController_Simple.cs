using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("leftPart")] public inkImageWidgetReference LeftPart { get; set; }
		[Ordinal(19)] [RED("rightPart")] public inkImageWidgetReference RightPart { get; set; }
		[Ordinal(20)] [RED("leftPartExtra")] public inkImageWidgetReference LeftPartExtra { get; set; }
		[Ordinal(21)] [RED("rightPartExtra")] public inkImageWidgetReference RightPartExtra { get; set; }
		[Ordinal(22)] [RED("offsetLeftRight")] public CFloat OffsetLeftRight { get; set; }
		[Ordinal(23)] [RED("offsetLeftRightExtra")] public CFloat OffsetLeftRightExtra { get; set; }
		[Ordinal(24)] [RED("latchVertical")] public CFloat LatchVertical { get; set; }
		[Ordinal(25)] [RED("topPart")] public inkImageWidgetReference TopPart { get; set; }
		[Ordinal(26)] [RED("bottomPart")] public inkImageWidgetReference BottomPart { get; set; }
		[Ordinal(27)] [RED("horiPart")] public inkWidgetReference HoriPart { get; set; }
		[Ordinal(28)] [RED("vertPart")] public inkWidgetReference VertPart { get; set; }
		[Ordinal(29)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(30)] [RED("middlePart")] public inkWidgetReference MiddlePart { get; set; }
		[Ordinal(31)] [RED("overheatShake")] public inkWidgetReference OverheatShake { get; set; }
		[Ordinal(32)] [RED("overheatTL")] public inkWidgetReference OverheatTL { get; set; }
		[Ordinal(33)] [RED("overheatBL")] public inkWidgetReference OverheatBL { get; set; }
		[Ordinal(34)] [RED("overheatTR")] public inkWidgetReference OverheatTR { get; set; }
		[Ordinal(35)] [RED("overheatBR")] public inkWidgetReference OverheatBR { get; set; }
		[Ordinal(36)] [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(37)] [RED("onChargeChangeBBID")] public CUInt32 OnChargeChangeBBID { get; set; }
		[Ordinal(38)] [RED("shakeAnimation")] public CHandle<inkanimProxy> ShakeAnimation { get; set; }
		[Ordinal(39)] [RED("isInForcedCool")] public CBool IsInForcedCool { get; set; }

		public CrosshairGameController_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
