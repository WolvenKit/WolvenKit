using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGeneralData : CVariable
	{
		[Ordinal(0)]  [RED("acoustingIsolationFactor")] public CName AcoustingIsolationFactor { get; set; }
		[Ordinal(1)]  [RED("collisionSoundEvent")] public CName CollisionSoundEvent { get; set; }
		[Ordinal(2)]  [RED("dopplerShift")] public CName DopplerShift { get; set; }
		[Ordinal(3)]  [RED("enterVehicleEvent")] public CName EnterVehicleEvent { get; set; }
		[Ordinal(4)]  [RED("exitVehicleEvent")] public CName ExitVehicleEvent { get; set; }
		[Ordinal(5)]  [RED("hornOffEvent")] public CName HornOffEvent { get; set; }
		[Ordinal(6)]  [RED("hornOnEvent")] public CName HornOnEvent { get; set; }
		[Ordinal(7)]  [RED("ignitionEndEvent")] public CName IgnitionEndEvent { get; set; }
		[Ordinal(8)]  [RED("ignitionStartEvent")] public CName IgnitionStartEvent { get; set; }
		[Ordinal(9)]  [RED("impactGridCellRawChange")] public CName ImpactGridCellRawChange { get; set; }
		[Ordinal(10)]  [RED("impactVelocity")] public CName ImpactVelocity { get; set; }
		[Ordinal(11)]  [RED("inclination")] public CName Inclination { get; set; }
		[Ordinal(12)]  [RED("interiorReverbBus")] public CName InteriorReverbBus { get; set; }
		[Ordinal(13)]  [RED("policeHornOffEvent")] public CName PoliceHornOffEvent { get; set; }
		[Ordinal(14)]  [RED("policeHornOnEvent")] public CName PoliceHornOnEvent { get; set; }
		[Ordinal(15)]  [RED("rainStartEvent")] public CName RainStartEvent { get; set; }
		[Ordinal(16)]  [RED("rainStopEvent")] public CName RainStopEvent { get; set; }
		[Ordinal(17)]  [RED("revElectricSoundbankName")] public CName RevElectricSoundbankName { get; set; }
		[Ordinal(18)]  [RED("revSoundbankName")] public CName RevSoundbankName { get; set; }
		[Ordinal(19)]  [RED("sirenOffEvent")] public CName SirenOffEvent { get; set; }
		[Ordinal(20)]  [RED("sirenOnEvent")] public CName SirenOnEvent { get; set; }
		[Ordinal(21)]  [RED("skid")] public CName Skid { get; set; }
		[Ordinal(22)]  [RED("tyreBurstEvent")] public CName TyreBurstEvent { get; set; }
		[Ordinal(23)]  [RED("vehicleDoorsSettings")] public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings { get; set; }
		[Ordinal(24)]  [RED("vehicleInteriorParameterData")] public audioVehicleInteriorParameterData VehicleInteriorParameterData { get; set; }
		[Ordinal(25)]  [RED("vehicleTemperatureSettings")] public audioVehicleTemperatureSettings VehicleTemperatureSettings { get; set; }

		public audioVehicleGeneralData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
