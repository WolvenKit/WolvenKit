using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		[Ordinal(0)]  [RED("bbcharge")] public CUInt32 Bbcharge { get; set; }
		[Ordinal(1)]  [RED("chargeBar")] public wCHandle<inkCanvasWidget> ChargeBar { get; set; }
		[Ordinal(2)]  [RED("chargeBarFG")] public wCHandle<inkRectangleWidget> ChargeBarFG { get; set; }
		[Ordinal(3)]  [RED("chargeBarMask")] public wCHandle<inkMaskWidget> ChargeBarMask { get; set; }
		[Ordinal(4)]  [RED("chargeBarMonoBottom")] public wCHandle<inkImageWidget> ChargeBarMonoBottom { get; set; }
		[Ordinal(5)]  [RED("chargeBarMonoTop")] public wCHandle<inkImageWidget> ChargeBarMonoTop { get; set; }
		[Ordinal(6)]  [RED("chargeValueL")] public wCHandle<inkTextWidget> ChargeValueL { get; set; }
		[Ordinal(7)]  [RED("chargeValueR")] public wCHandle<inkTextWidget> ChargeValueR { get; set; }
		[Ordinal(8)]  [RED("displayChargeBar")] public CBool DisplayChargeBar { get; set; }
		[Ordinal(9)]  [RED("meleeResourcePoolListener")] public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener { get; set; }
		[Ordinal(10)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(11)]  [RED("weaponID")] public entEntityID WeaponID { get; set; }
		[Ordinal(12)]  [RED("weaponlocalBB")] public CHandle<gameIBlackboard> WeaponlocalBB { get; set; }

		public CrosshairGameController_Melee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
