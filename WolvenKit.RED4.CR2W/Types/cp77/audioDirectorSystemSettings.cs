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
			get
			{
				if (_mixSettingsName == null)
				{
					_mixSettingsName = (CName) CR2WTypeManager.Create("CName", "mixSettingsName", cr2w, this);
				}
				return _mixSettingsName;
			}
			set
			{
				if (_mixSettingsName == value)
				{
					return;
				}
				_mixSettingsName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("combatVoManagerSettingsName")] 
		public CName CombatVoManagerSettingsName
		{
			get
			{
				if (_combatVoManagerSettingsName == null)
				{
					_combatVoManagerSettingsName = (CName) CR2WTypeManager.Create("CName", "combatVoManagerSettingsName", cr2w, this);
				}
				return _combatVoManagerSettingsName;
			}
			set
			{
				if (_combatVoManagerSettingsName == value)
				{
					return;
				}
				_combatVoManagerSettingsName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("singleConversationMinRepeatTime")] 
		public CFloat SingleConversationMinRepeatTime
		{
			get
			{
				if (_singleConversationMinRepeatTime == null)
				{
					_singleConversationMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "singleConversationMinRepeatTime", cr2w, this);
				}
				return _singleConversationMinRepeatTime;
			}
			set
			{
				if (_singleConversationMinRepeatTime == value)
				{
					return;
				}
				_singleConversationMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("allConversationsMinRepeatTime")] 
		public CFloat AllConversationsMinRepeatTime
		{
			get
			{
				if (_allConversationsMinRepeatTime == null)
				{
					_allConversationsMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "allConversationsMinRepeatTime", cr2w, this);
				}
				return _allConversationsMinRepeatTime;
			}
			set
			{
				if (_allConversationsMinRepeatTime == value)
				{
					return;
				}
				_allConversationsMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxVelocityMagnitudeToConsiderPlayerVehicleInactive")] 
		public CFloat MaxVelocityMagnitudeToConsiderPlayerVehicleInactive
		{
			get
			{
				if (_maxVelocityMagnitudeToConsiderPlayerVehicleInactive == null)
				{
					_maxVelocityMagnitudeToConsiderPlayerVehicleInactive = (CFloat) CR2WTypeManager.Create("Float", "maxVelocityMagnitudeToConsiderPlayerVehicleInactive", cr2w, this);
				}
				return _maxVelocityMagnitudeToConsiderPlayerVehicleInactive;
			}
			set
			{
				if (_maxVelocityMagnitudeToConsiderPlayerVehicleInactive == value)
				{
					return;
				}
				_maxVelocityMagnitudeToConsiderPlayerVehicleInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxVelocityMagnitudeToConsiderTrafficVehicleIdle")] 
		public CFloat MaxVelocityMagnitudeToConsiderTrafficVehicleIdle
		{
			get
			{
				if (_maxVelocityMagnitudeToConsiderTrafficVehicleIdle == null)
				{
					_maxVelocityMagnitudeToConsiderTrafficVehicleIdle = (CFloat) CR2WTypeManager.Create("Float", "maxVelocityMagnitudeToConsiderTrafficVehicleIdle", cr2w, this);
				}
				return _maxVelocityMagnitudeToConsiderTrafficVehicleIdle;
			}
			set
			{
				if (_maxVelocityMagnitudeToConsiderTrafficVehicleIdle == value)
				{
					return;
				}
				_maxVelocityMagnitudeToConsiderTrafficVehicleIdle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerInactiveMinTimeNeededToEngageMovingFaster")] 
		public CFloat PlayerInactiveMinTimeNeededToEngageMovingFaster
		{
			get
			{
				if (_playerInactiveMinTimeNeededToEngageMovingFaster == null)
				{
					_playerInactiveMinTimeNeededToEngageMovingFaster = (CFloat) CR2WTypeManager.Create("Float", "playerInactiveMinTimeNeededToEngageMovingFaster", cr2w, this);
				}
				return _playerInactiveMinTimeNeededToEngageMovingFaster;
			}
			set
			{
				if (_playerInactiveMinTimeNeededToEngageMovingFaster == value)
				{
					return;
				}
				_playerInactiveMinTimeNeededToEngageMovingFaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehEngageMovingFasterInterpolation")] 
		public audioVehicleEngageMovingFasterInterpolationData VehEngageMovingFasterInterpolation
		{
			get
			{
				if (_vehEngageMovingFasterInterpolation == null)
				{
					_vehEngageMovingFasterInterpolation = (audioVehicleEngageMovingFasterInterpolationData) CR2WTypeManager.Create("audioVehicleEngageMovingFasterInterpolationData", "vehEngageMovingFasterInterpolation", cr2w, this);
				}
				return _vehEngageMovingFasterInterpolation;
			}
			set
			{
				if (_vehEngageMovingFasterInterpolation == value)
				{
					return;
				}
				_vehEngageMovingFasterInterpolation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("trafficSpeedRC")] 
		public CFloat TrafficSpeedRC
		{
			get
			{
				if (_trafficSpeedRC == null)
				{
					_trafficSpeedRC = (CFloat) CR2WTypeManager.Create("Float", "trafficSpeedRC", cr2w, this);
				}
				return _trafficSpeedRC;
			}
			set
			{
				if (_trafficSpeedRC == value)
				{
					return;
				}
				_trafficSpeedRC = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("trafficAccelerationRC")] 
		public CFloat TrafficAccelerationRC
		{
			get
			{
				if (_trafficAccelerationRC == null)
				{
					_trafficAccelerationRC = (CFloat) CR2WTypeManager.Create("Float", "trafficAccelerationRC", cr2w, this);
				}
				return _trafficAccelerationRC;
			}
			set
			{
				if (_trafficAccelerationRC == value)
				{
					return;
				}
				_trafficAccelerationRC = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("trafficRpmRC")] 
		public CFloat TrafficRpmRC
		{
			get
			{
				if (_trafficRpmRC == null)
				{
					_trafficRpmRC = (CFloat) CR2WTypeManager.Create("Float", "trafficRpmRC", cr2w, this);
				}
				return _trafficRpmRC;
			}
			set
			{
				if (_trafficRpmRC == value)
				{
					return;
				}
				_trafficRpmRC = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("overHeadVisibilityMaxOcclusion")] 
		public CFloat OverHeadVisibilityMaxOcclusion
		{
			get
			{
				if (_overHeadVisibilityMaxOcclusion == null)
				{
					_overHeadVisibilityMaxOcclusion = (CFloat) CR2WTypeManager.Create("Float", "overHeadVisibilityMaxOcclusion", cr2w, this);
				}
				return _overHeadVisibilityMaxOcclusion;
			}
			set
			{
				if (_overHeadVisibilityMaxOcclusion == value)
				{
					return;
				}
				_overHeadVisibilityMaxOcclusion = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("overHeadVisibilityMaxObstruction")] 
		public CFloat OverHeadVisibilityMaxObstruction
		{
			get
			{
				if (_overHeadVisibilityMaxObstruction == null)
				{
					_overHeadVisibilityMaxObstruction = (CFloat) CR2WTypeManager.Create("Float", "overHeadVisibilityMaxObstruction", cr2w, this);
				}
				return _overHeadVisibilityMaxObstruction;
			}
			set
			{
				if (_overHeadVisibilityMaxObstruction == value)
				{
					return;
				}
				_overHeadVisibilityMaxObstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("conversationMixCooldown")] 
		public CFloat ConversationMixCooldown
		{
			get
			{
				if (_conversationMixCooldown == null)
				{
					_conversationMixCooldown = (CFloat) CR2WTypeManager.Create("Float", "conversationMixCooldown", cr2w, this);
				}
				return _conversationMixCooldown;
			}
			set
			{
				if (_conversationMixCooldown == value)
				{
					return;
				}
				_conversationMixCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("enemyPingCooldown")] 
		public CFloat EnemyPingCooldown
		{
			get
			{
				if (_enemyPingCooldown == null)
				{
					_enemyPingCooldown = (CFloat) CR2WTypeManager.Create("Float", "enemyPingCooldown", cr2w, this);
				}
				return _enemyPingCooldown;
			}
			set
			{
				if (_enemyPingCooldown == value)
				{
					return;
				}
				_enemyPingCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("idleTimeBeforeAllowingOwMusicChange")] 
		public CFloat IdleTimeBeforeAllowingOwMusicChange
		{
			get
			{
				if (_idleTimeBeforeAllowingOwMusicChange == null)
				{
					_idleTimeBeforeAllowingOwMusicChange = (CFloat) CR2WTypeManager.Create("Float", "idleTimeBeforeAllowingOwMusicChange", cr2w, this);
				}
				return _idleTimeBeforeAllowingOwMusicChange;
			}
			set
			{
				if (_idleTimeBeforeAllowingOwMusicChange == value)
				{
					return;
				}
				_idleTimeBeforeAllowingOwMusicChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("drivingStreamingAmbientEmittersDistanceRolloff")] 
		public CFloat DrivingStreamingAmbientEmittersDistanceRolloff
		{
			get
			{
				if (_drivingStreamingAmbientEmittersDistanceRolloff == null)
				{
					_drivingStreamingAmbientEmittersDistanceRolloff = (CFloat) CR2WTypeManager.Create("Float", "drivingStreamingAmbientEmittersDistanceRolloff", cr2w, this);
				}
				return _drivingStreamingAmbientEmittersDistanceRolloff;
			}
			set
			{
				if (_drivingStreamingAmbientEmittersDistanceRolloff == value)
				{
					return;
				}
				_drivingStreamingAmbientEmittersDistanceRolloff = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("lowHealthStateMaxTime")] 
		public CFloat LowHealthStateMaxTime
		{
			get
			{
				if (_lowHealthStateMaxTime == null)
				{
					_lowHealthStateMaxTime = (CFloat) CR2WTypeManager.Create("Float", "lowHealthStateMaxTime", cr2w, this);
				}
				return _lowHealthStateMaxTime;
			}
			set
			{
				if (_lowHealthStateMaxTime == value)
				{
					return;
				}
				_lowHealthStateMaxTime = value;
				PropertySet(this);
			}
		}

		public audioDirectorSystemSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
