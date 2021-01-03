using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioDirectorSystemSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("allConversationsMinRepeatTime")] public CFloat AllConversationsMinRepeatTime { get; set; }
		[Ordinal(1)]  [RED("combatVoManagerSettingsName")] public CName CombatVoManagerSettingsName { get; set; }
		[Ordinal(2)]  [RED("conversationMixCooldown")] public CFloat ConversationMixCooldown { get; set; }
		[Ordinal(3)]  [RED("drivingStreamingAmbientEmittersDistanceRolloff")] public CFloat DrivingStreamingAmbientEmittersDistanceRolloff { get; set; }
		[Ordinal(4)]  [RED("enemyPingCooldown")] public CFloat EnemyPingCooldown { get; set; }
		[Ordinal(5)]  [RED("idleTimeBeforeAllowingOwMusicChange")] public CFloat IdleTimeBeforeAllowingOwMusicChange { get; set; }
		[Ordinal(6)]  [RED("lowHealthStateMaxTime")] public CFloat LowHealthStateMaxTime { get; set; }
		[Ordinal(7)]  [RED("maxVelocityMagnitudeToConsiderPlayerVehicleInactive")] public CFloat MaxVelocityMagnitudeToConsiderPlayerVehicleInactive { get; set; }
		[Ordinal(8)]  [RED("maxVelocityMagnitudeToConsiderTrafficVehicleIdle")] public CFloat MaxVelocityMagnitudeToConsiderTrafficVehicleIdle { get; set; }
		[Ordinal(9)]  [RED("mixSettingsName")] public CName MixSettingsName { get; set; }
		[Ordinal(10)]  [RED("overHeadVisibilityMaxObstruction")] public CFloat OverHeadVisibilityMaxObstruction { get; set; }
		[Ordinal(11)]  [RED("overHeadVisibilityMaxOcclusion")] public CFloat OverHeadVisibilityMaxOcclusion { get; set; }
		[Ordinal(12)]  [RED("playerInactiveMinTimeNeededToEngageMovingFaster")] public CFloat PlayerInactiveMinTimeNeededToEngageMovingFaster { get; set; }
		[Ordinal(13)]  [RED("singleConversationMinRepeatTime")] public CFloat SingleConversationMinRepeatTime { get; set; }
		[Ordinal(14)]  [RED("trafficAccelerationRC")] public CFloat TrafficAccelerationRC { get; set; }
		[Ordinal(15)]  [RED("trafficRpmRC")] public CFloat TrafficRpmRC { get; set; }
		[Ordinal(16)]  [RED("trafficSpeedRC")] public CFloat TrafficSpeedRC { get; set; }
		[Ordinal(17)]  [RED("vehEngageMovingFasterInterpolation")] public audioVehicleEngageMovingFasterInterpolationData VehEngageMovingFasterInterpolation { get; set; }

		public audioDirectorSystemSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
