using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class blunderbussWeaponController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("chargeWidgetInitialY")] public CFloat ChargeWidgetInitialY { get; set; }
		[Ordinal(3)] [RED("chargeWidgetSize")] public Vector2 ChargeWidgetSize { get; set; }
		[Ordinal(4)] [RED("semiAutoModeInfo")] public wCHandle<inkWidget> SemiAutoModeInfo { get; set; }
		[Ordinal(5)] [RED("chargeModeInfo")] public wCHandle<inkWidget> ChargeModeInfo { get; set; }
		[Ordinal(6)] [RED("semiAutoModeIndicator")] public wCHandle<inkWidget> SemiAutoModeIndicator { get; set; }
		[Ordinal(7)] [RED("chargeModeIndicator")] public wCHandle<inkWidget> ChargeModeIndicator { get; set; }
		[Ordinal(8)] [RED("shots")] public CArray<wCHandle<inkWidget>> Shots { get; set; }
		[Ordinal(9)] [RED("charge")] public wCHandle<inkWidget> Charge { get; set; }
		[Ordinal(10)] [RED("onCharge")] public CUInt32 OnCharge { get; set; }
		[Ordinal(11)] [RED("onTriggerMode")] public CUInt32 OnTriggerMode { get; set; }
		[Ordinal(12)] [RED("onMagazineAmmoCount")] public CUInt32 OnMagazineAmmoCount { get; set; }
		[Ordinal(13)] [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }

		public blunderbussWeaponController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
