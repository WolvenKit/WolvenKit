using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleUIGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("UIEnabled")] public CBool UIEnabled { get; set; }
		[Ordinal(1)]  [RED("analogSpeedWidget")] public inkWidgetReference AnalogSpeedWidget { get; set; }
		[Ordinal(2)]  [RED("analogTachWidget")] public inkWidgetReference AnalogTachWidget { get; set; }
		[Ordinal(3)]  [RED("endAnimProxy")] public CHandle<inkanimProxy> EndAnimProxy { get; set; }
		[Ordinal(4)]  [RED("gearBox")] public inkWidgetReference GearBox { get; set; }
		[Ordinal(5)]  [RED("instruments")] public inkWidgetReference Instruments { get; set; }
		[Ordinal(6)]  [RED("isVehicleReady")] public CBool IsVehicleReady { get; set; }
		[Ordinal(7)]  [RED("loopAnimProxy")] public CHandle<inkanimProxy> LoopAnimProxy { get; set; }
		[Ordinal(8)]  [RED("loopingBootProxy")] public CHandle<inkanimProxy> LoopingBootProxy { get; set; }
		[Ordinal(9)]  [RED("radio")] public inkWidgetReference Radio { get; set; }
		[Ordinal(10)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(11)]  [RED("speedometerWidget")] public inkWidgetReference SpeedometerWidget { get; set; }
		[Ordinal(12)]  [RED("startAnimProxy")] public CHandle<inkanimProxy> StartAnimProxy { get; set; }
		[Ordinal(13)]  [RED("tachometerWidget")] public inkWidgetReference TachometerWidget { get; set; }
		[Ordinal(14)]  [RED("timeWidget")] public inkWidgetReference TimeWidget { get; set; }
		[Ordinal(15)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(16)]  [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(17)]  [RED("vehicleBBUIActivId")] public CUInt32 VehicleBBUIActivId { get; set; }
		[Ordinal(18)]  [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(19)]  [RED("vehicleCollisionBBStateID")] public CUInt32 VehicleCollisionBBStateID { get; set; }
		[Ordinal(20)]  [RED("vehiclePS")] public CHandle<VehicleComponentPS> VehiclePS { get; set; }

		public vehicleUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
