using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		[Ordinal(20)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(21)] [RED("chargeBar")] public wCHandle<inkCanvasWidget> ChargeBar { get; set; }
		[Ordinal(22)] [RED("chargeBarFG")] public wCHandle<inkRectangleWidget> ChargeBarFG { get; set; }
		[Ordinal(23)] [RED("chargeBarMonoTop")] public wCHandle<inkImageWidget> ChargeBarMonoTop { get; set; }
		[Ordinal(24)] [RED("chargeBarMonoBottom")] public wCHandle<inkImageWidget> ChargeBarMonoBottom { get; set; }
		[Ordinal(25)] [RED("chargeBarMask")] public wCHandle<inkMaskWidget> ChargeBarMask { get; set; }
		[Ordinal(26)] [RED("chargeValueL")] public wCHandle<inkTextWidget> ChargeValueL { get; set; }
		[Ordinal(27)] [RED("chargeValueR")] public wCHandle<inkTextWidget> ChargeValueR { get; set; }
		[Ordinal(28)] [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(29)] [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }
		[Ordinal(30)] [RED("meleeResourcePoolListener")] public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener { get; set; }
		[Ordinal(31)] [RED("weaponID")] public entEntityID WeaponID { get; set; }
		[Ordinal(32)] [RED("displayChargeBar")] public CBool DisplayChargeBar { get; set; }

		public CrosshairGameController_Melee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
