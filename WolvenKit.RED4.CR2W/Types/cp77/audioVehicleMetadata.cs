using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(1)] [RED("generalData")] public audioVehicleGeneralData GeneralData { get; set; }
		[Ordinal(2)] [RED("mechanicalData")] public audioVehicleMechanicalData MechanicalData { get; set; }
		[Ordinal(3)] [RED("wheelData")] public audioVehicleWheelData WheelData { get; set; }
		[Ordinal(4)] [RED("emitterPositionData")] public audioVehicleEmitterPositionData EmitterPositionData { get; set; }
		[Ordinal(5)] [RED("minRpm")] public CFloat MinRpm { get; set; }
		[Ordinal(6)] [RED("maxRpm")] public CFloat MaxRpm { get; set; }
		[Ordinal(7)] [RED("vehicleCollisionSettings")] public CName VehicleCollisionSettings { get; set; }
		[Ordinal(8)] [RED("vehicleGridDestructionSettings")] public CName VehicleGridDestructionSettings { get; set; }
		[Ordinal(9)] [RED("vehiclePartSettings")] public CName VehiclePartSettings { get; set; }
		[Ordinal(10)] [RED("collisionCooldown")] public CFloat CollisionCooldown { get; set; }
		[Ordinal(11)] [RED("maxPlayingDistance")] public CFloat MaxPlayingDistance { get; set; }
		[Ordinal(12)] [RED("dopplerFactor")] public CFloat DopplerFactor { get; set; }
		[Ordinal(13)] [RED("suspensionSqueekTimeout")] public CFloat SuspensionSqueekTimeout { get; set; }
		[Ordinal(14)] [RED("exitDelay")] public CFloat ExitDelay { get; set; }
		[Ordinal(15)] [RED("gearSweeteners")] public CArray<CName> GearSweeteners { get; set; }
		[Ordinal(16)] [RED("testWheelMaterial")] public CBool TestWheelMaterial { get; set; }
		[Ordinal(17)] [RED("hasRadioReceiver")] public CBool HasRadioReceiver { get; set; }
		[Ordinal(18)] [RED("usesPoliceRadioStation")] public CBool UsesPoliceRadioStation { get; set; }
		[Ordinal(19)] [RED("acousticIsolationFactor")] public CFloat AcousticIsolationFactor { get; set; }
		[Ordinal(20)] [RED("trafficEmitterMetadata")] public CName TrafficEmitterMetadata { get; set; }
		[Ordinal(21)] [RED("radioReceiverType")] public CName RadioReceiverType { get; set; }
		[Ordinal(22)] [RED("matchingStartupRadioStations")] public CArray<CName> MatchingStartupRadioStations { get; set; }
		[Ordinal(23)] [RED("radioPlaysWhenEngineStartsProbability")] public CFloat RadioPlaysWhenEngineStartsProbability { get; set; }

		public audioVehicleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
