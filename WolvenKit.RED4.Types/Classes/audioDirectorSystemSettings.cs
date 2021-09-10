using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDirectorSystemSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mixSettingsName")] 
		public CName MixSettingsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("combatVoManagerSettingsName")] 
		public CName CombatVoManagerSettingsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("singleConversationMinRepeatTime")] 
		public CFloat SingleConversationMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("allConversationsMinRepeatTime")] 
		public CFloat AllConversationsMinRepeatTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxVelocityMagnitudeToConsiderPlayerVehicleInactive")] 
		public CFloat MaxVelocityMagnitudeToConsiderPlayerVehicleInactive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("maxVelocityMagnitudeToConsiderTrafficVehicleIdle")] 
		public CFloat MaxVelocityMagnitudeToConsiderTrafficVehicleIdle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("playerInactiveMinTimeNeededToEngageMovingFaster")] 
		public CFloat PlayerInactiveMinTimeNeededToEngageMovingFaster
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("vehEngageMovingFasterInterpolation")] 
		public audioVehicleEngageMovingFasterInterpolationData VehEngageMovingFasterInterpolation
		{
			get => GetPropertyValue<audioVehicleEngageMovingFasterInterpolationData>();
			set => SetPropertyValue<audioVehicleEngageMovingFasterInterpolationData>(value);
		}

		[Ordinal(9)] 
		[RED("trafficSpeedRC")] 
		public CFloat TrafficSpeedRC
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("trafficAccelerationRC")] 
		public CFloat TrafficAccelerationRC
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("trafficRpmRC")] 
		public CFloat TrafficRpmRC
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("overHeadVisibilityMaxOcclusion")] 
		public CFloat OverHeadVisibilityMaxOcclusion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("overHeadVisibilityMaxObstruction")] 
		public CFloat OverHeadVisibilityMaxObstruction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("conversationMixCooldown")] 
		public CFloat ConversationMixCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("enemyPingCooldown")] 
		public CFloat EnemyPingCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("idleTimeBeforeAllowingOwMusicChange")] 
		public CFloat IdleTimeBeforeAllowingOwMusicChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("drivingStreamingAmbientEmittersDistanceRolloff")] 
		public CFloat DrivingStreamingAmbientEmittersDistanceRolloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("lowHealthStateMaxTime")] 
		public CFloat LowHealthStateMaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("lowGearMaxTrafficSpeed")] 
		public CFloat LowGearMaxTrafficSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("lowGearAccelerationThreshold")] 
		public CFloat LowGearAccelerationThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("mediumGearMaxTrafficSpeed")] 
		public CFloat MediumGearMaxTrafficSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("mediumGearAccelerationThreshold")] 
		public CFloat MediumGearAccelerationThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("highGearAccelerationThreshold")] 
		public CFloat HighGearAccelerationThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioDirectorSystemSettings()
		{
			SingleConversationMinRepeatTime = 40.000000F;
			AllConversationsMinRepeatTime = 8.000000F;
			MaxVelocityMagnitudeToConsiderPlayerVehicleInactive = 10.000000F;
			MaxVelocityMagnitudeToConsiderTrafficVehicleIdle = 0.100000F;
			PlayerInactiveMinTimeNeededToEngageMovingFaster = 8.000000F;
			VehEngageMovingFasterInterpolation = new() { EnterCurveType = Enums.audioESoundCurveType.Linear, EnterCurveTime = 3.000000F, ExitCurveType = Enums.audioESoundCurveType.Linear, ExitCurveTime = 3.000000F };
			TrafficSpeedRC = 0.050000F;
			TrafficAccelerationRC = 0.200000F;
			TrafficRpmRC = 0.200000F;
			OverHeadVisibilityMaxOcclusion = 0.200000F;
			OverHeadVisibilityMaxObstruction = 0.400000F;
			ConversationMixCooldown = 5.000000F;
			EnemyPingCooldown = 5.000000F;
			IdleTimeBeforeAllowingOwMusicChange = 5.000000F;
			DrivingStreamingAmbientEmittersDistanceRolloff = 32.000000F;
			LowHealthStateMaxTime = 5.000000F;
			LowGearMaxTrafficSpeed = 0.230000F;
			MediumGearMaxTrafficSpeed = 0.570000F;
			MediumGearAccelerationThreshold = -1.000000F;
			HighGearAccelerationThreshold = -2.000000F;
		}
	}
}
