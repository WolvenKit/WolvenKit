using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDirectorSystemSettings : audioAudioMetadata
	{
		private CName _mixSettingsName;
		private CName _combatVoManagerSettingsName;
		private CFloat _singleConversationMinRepeatTime;
		private CFloat _allConversationsMinRepeatTime;
		private CFloat _maxVelocityMagnitudeToConsiderPlayerVehicleInactive;
		private CFloat _maxVelocityMagnitudeToConsiderTrafficVehicleIdle;
		private CFloat _playerInactiveMinTimeNeededToEngageMovingFaster;
		private audioVehicleEngageMovingFasterInterpolationData _vehEngageMovingFasterInterpolation;
		private CFloat _trafficSpeedRC;
		private CFloat _trafficAccelerationRC;
		private CFloat _trafficRpmRC;
		private CFloat _overHeadVisibilityMaxOcclusion;
		private CFloat _overHeadVisibilityMaxObstruction;
		private CFloat _conversationMixCooldown;
		private CFloat _enemyPingCooldown;
		private CFloat _idleTimeBeforeAllowingOwMusicChange;
		private CFloat _drivingStreamingAmbientEmittersDistanceRolloff;
		private CFloat _lowHealthStateMaxTime;

		[Ordinal(1)] 
		[RED("mixSettingsName")] 
		public CName MixSettingsName
		{
			get => GetProperty(ref _mixSettingsName);
			set => SetProperty(ref _mixSettingsName, value);
		}

		[Ordinal(2)] 
		[RED("combatVoManagerSettingsName")] 
		public CName CombatVoManagerSettingsName
		{
			get => GetProperty(ref _combatVoManagerSettingsName);
			set => SetProperty(ref _combatVoManagerSettingsName, value);
		}

		[Ordinal(3)] 
		[RED("singleConversationMinRepeatTime")] 
		public CFloat SingleConversationMinRepeatTime
		{
			get => GetProperty(ref _singleConversationMinRepeatTime);
			set => SetProperty(ref _singleConversationMinRepeatTime, value);
		}

		[Ordinal(4)] 
		[RED("allConversationsMinRepeatTime")] 
		public CFloat AllConversationsMinRepeatTime
		{
			get => GetProperty(ref _allConversationsMinRepeatTime);
			set => SetProperty(ref _allConversationsMinRepeatTime, value);
		}

		[Ordinal(5)] 
		[RED("maxVelocityMagnitudeToConsiderPlayerVehicleInactive")] 
		public CFloat MaxVelocityMagnitudeToConsiderPlayerVehicleInactive
		{
			get => GetProperty(ref _maxVelocityMagnitudeToConsiderPlayerVehicleInactive);
			set => SetProperty(ref _maxVelocityMagnitudeToConsiderPlayerVehicleInactive, value);
		}

		[Ordinal(6)] 
		[RED("maxVelocityMagnitudeToConsiderTrafficVehicleIdle")] 
		public CFloat MaxVelocityMagnitudeToConsiderTrafficVehicleIdle
		{
			get => GetProperty(ref _maxVelocityMagnitudeToConsiderTrafficVehicleIdle);
			set => SetProperty(ref _maxVelocityMagnitudeToConsiderTrafficVehicleIdle, value);
		}

		[Ordinal(7)] 
		[RED("playerInactiveMinTimeNeededToEngageMovingFaster")] 
		public CFloat PlayerInactiveMinTimeNeededToEngageMovingFaster
		{
			get => GetProperty(ref _playerInactiveMinTimeNeededToEngageMovingFaster);
			set => SetProperty(ref _playerInactiveMinTimeNeededToEngageMovingFaster, value);
		}

		[Ordinal(8)] 
		[RED("vehEngageMovingFasterInterpolation")] 
		public audioVehicleEngageMovingFasterInterpolationData VehEngageMovingFasterInterpolation
		{
			get => GetProperty(ref _vehEngageMovingFasterInterpolation);
			set => SetProperty(ref _vehEngageMovingFasterInterpolation, value);
		}

		[Ordinal(9)] 
		[RED("trafficSpeedRC")] 
		public CFloat TrafficSpeedRC
		{
			get => GetProperty(ref _trafficSpeedRC);
			set => SetProperty(ref _trafficSpeedRC, value);
		}

		[Ordinal(10)] 
		[RED("trafficAccelerationRC")] 
		public CFloat TrafficAccelerationRC
		{
			get => GetProperty(ref _trafficAccelerationRC);
			set => SetProperty(ref _trafficAccelerationRC, value);
		}

		[Ordinal(11)] 
		[RED("trafficRpmRC")] 
		public CFloat TrafficRpmRC
		{
			get => GetProperty(ref _trafficRpmRC);
			set => SetProperty(ref _trafficRpmRC, value);
		}

		[Ordinal(12)] 
		[RED("overHeadVisibilityMaxOcclusion")] 
		public CFloat OverHeadVisibilityMaxOcclusion
		{
			get => GetProperty(ref _overHeadVisibilityMaxOcclusion);
			set => SetProperty(ref _overHeadVisibilityMaxOcclusion, value);
		}

		[Ordinal(13)] 
		[RED("overHeadVisibilityMaxObstruction")] 
		public CFloat OverHeadVisibilityMaxObstruction
		{
			get => GetProperty(ref _overHeadVisibilityMaxObstruction);
			set => SetProperty(ref _overHeadVisibilityMaxObstruction, value);
		}

		[Ordinal(14)] 
		[RED("conversationMixCooldown")] 
		public CFloat ConversationMixCooldown
		{
			get => GetProperty(ref _conversationMixCooldown);
			set => SetProperty(ref _conversationMixCooldown, value);
		}

		[Ordinal(15)] 
		[RED("enemyPingCooldown")] 
		public CFloat EnemyPingCooldown
		{
			get => GetProperty(ref _enemyPingCooldown);
			set => SetProperty(ref _enemyPingCooldown, value);
		}

		[Ordinal(16)] 
		[RED("idleTimeBeforeAllowingOwMusicChange")] 
		public CFloat IdleTimeBeforeAllowingOwMusicChange
		{
			get => GetProperty(ref _idleTimeBeforeAllowingOwMusicChange);
			set => SetProperty(ref _idleTimeBeforeAllowingOwMusicChange, value);
		}

		[Ordinal(17)] 
		[RED("drivingStreamingAmbientEmittersDistanceRolloff")] 
		public CFloat DrivingStreamingAmbientEmittersDistanceRolloff
		{
			get => GetProperty(ref _drivingStreamingAmbientEmittersDistanceRolloff);
			set => SetProperty(ref _drivingStreamingAmbientEmittersDistanceRolloff, value);
		}

		[Ordinal(18)] 
		[RED("lowHealthStateMaxTime")] 
		public CFloat LowHealthStateMaxTime
		{
			get => GetProperty(ref _lowHealthStateMaxTime);
			set => SetProperty(ref _lowHealthStateMaxTime, value);
		}

		public audioDirectorSystemSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
