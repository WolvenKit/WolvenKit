using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class blunderbussWeaponController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("charge")] public wCHandle<inkWidget> Charge { get; set; }
		[Ordinal(2)]  [RED("chargeModeIndicator")] public wCHandle<inkWidget> ChargeModeIndicator { get; set; }
		[Ordinal(3)]  [RED("chargeModeInfo")] public wCHandle<inkWidget> ChargeModeInfo { get; set; }
		[Ordinal(4)]  [RED("chargeWidgetInitialY")] public CFloat ChargeWidgetInitialY { get; set; }
		[Ordinal(5)]  [RED("chargeWidgetSize")] public Vector2 ChargeWidgetSize { get; set; }
		[Ordinal(6)]  [RED("onCharge")] public CUInt32 OnCharge { get; set; }
		[Ordinal(7)]  [RED("onMagazineAmmoCount")] public CUInt32 OnMagazineAmmoCount { get; set; }
		[Ordinal(8)]  [RED("onTriggerMode")] public CUInt32 OnTriggerMode { get; set; }
		[Ordinal(9)]  [RED("semiAutoModeIndicator")] public wCHandle<inkWidget> SemiAutoModeIndicator { get; set; }
		[Ordinal(10)]  [RED("semiAutoModeInfo")] public wCHandle<inkWidget> SemiAutoModeInfo { get; set; }
		[Ordinal(11)]  [RED("shots")] public CArray<wCHandle<inkWidget>> Shots { get; set; }

		public blunderbussWeaponController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
