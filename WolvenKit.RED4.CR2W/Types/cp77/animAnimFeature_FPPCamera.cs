using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_FPPCamera : animAnimFeature
	{
		private CFloat _fov;
		private CFloat _deltaYaw;
		private CFloat _deltaYawExternal;
		private CFloat _deltaYawInput;
		private CFloat _yawSpeed;
		private CFloat _yawMaxLeft;
		private CFloat _yawMaxRight;
		private CFloat _deltaPitch;
		private CFloat _deltaPitchExternal;
		private CFloat _deltaPitchInput;
		private CFloat _pitchSpeed;
		private CFloat _pitchMin;
		private CFloat _pitchMax;
		private CFloat _resetYawSpeed;
		private CFloat _resetPitchSpeed;
		private CFloat _resetExternalsSpeed;
		private CBool _isSceneMode;
		private CFloat _t4Blend;
		private CFloat _t4Pitch;
		private CFloat _t4Yaw;
		private CFloat _t4Roll;
		private CBool _t4CopyPitchAndYaw;
		private CBool _sceneCameraUseTrajectorySpace;
		private CBool _sceneTransitioningToGameplay;
		private CFloat _yawMultiplier;
		private CFloat _pitchMultiplier;
		private CFloat _overridePitchInput;
		private CFloat _overridePitchRef;
		private CFloat _overrideYawInput;
		private CFloat _overrideYawRef;
		private CFloat _override;
		private CFloat _parallaxSide;
		private CFloat _parallaxForward;
		private CFloat _parallaxSpace;
		private CBool _normalizeYaw;
		private CFloat _vehicleOffsetWeight;
		private CFloat _gameplayCameraPoseWeight;
		private CFloat _additiveCameraMovementsWeight;
		private CFloat _vehicleProceduralCameraWeight;
		private Quaternion _t4CameraIdleOrientation;
		private CBool _t4UseCameraIdleOrientation;
		private Quaternion _t4CameraControlIdleOrientation;

		[Ordinal(0)] 
		[RED("fov")] 
		public CFloat Fov
		{
			get
			{
				if (_fov == null)
				{
					_fov = (CFloat) CR2WTypeManager.Create("Float", "fov", cr2w, this);
				}
				return _fov;
			}
			set
			{
				if (_fov == value)
				{
					return;
				}
				_fov = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deltaYaw")] 
		public CFloat DeltaYaw
		{
			get
			{
				if (_deltaYaw == null)
				{
					_deltaYaw = (CFloat) CR2WTypeManager.Create("Float", "deltaYaw", cr2w, this);
				}
				return _deltaYaw;
			}
			set
			{
				if (_deltaYaw == value)
				{
					return;
				}
				_deltaYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("deltaYawExternal")] 
		public CFloat DeltaYawExternal
		{
			get
			{
				if (_deltaYawExternal == null)
				{
					_deltaYawExternal = (CFloat) CR2WTypeManager.Create("Float", "deltaYawExternal", cr2w, this);
				}
				return _deltaYawExternal;
			}
			set
			{
				if (_deltaYawExternal == value)
				{
					return;
				}
				_deltaYawExternal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("deltaYawInput")] 
		public CFloat DeltaYawInput
		{
			get
			{
				if (_deltaYawInput == null)
				{
					_deltaYawInput = (CFloat) CR2WTypeManager.Create("Float", "deltaYawInput", cr2w, this);
				}
				return _deltaYawInput;
			}
			set
			{
				if (_deltaYawInput == value)
				{
					return;
				}
				_deltaYawInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get
			{
				if (_yawSpeed == null)
				{
					_yawSpeed = (CFloat) CR2WTypeManager.Create("Float", "yawSpeed", cr2w, this);
				}
				return _yawSpeed;
			}
			set
			{
				if (_yawSpeed == value)
				{
					return;
				}
				_yawSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get
			{
				if (_yawMaxLeft == null)
				{
					_yawMaxLeft = (CFloat) CR2WTypeManager.Create("Float", "yawMaxLeft", cr2w, this);
				}
				return _yawMaxLeft;
			}
			set
			{
				if (_yawMaxLeft == value)
				{
					return;
				}
				_yawMaxLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get
			{
				if (_yawMaxRight == null)
				{
					_yawMaxRight = (CFloat) CR2WTypeManager.Create("Float", "yawMaxRight", cr2w, this);
				}
				return _yawMaxRight;
			}
			set
			{
				if (_yawMaxRight == value)
				{
					return;
				}
				_yawMaxRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deltaPitch")] 
		public CFloat DeltaPitch
		{
			get
			{
				if (_deltaPitch == null)
				{
					_deltaPitch = (CFloat) CR2WTypeManager.Create("Float", "deltaPitch", cr2w, this);
				}
				return _deltaPitch;
			}
			set
			{
				if (_deltaPitch == value)
				{
					return;
				}
				_deltaPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("deltaPitchExternal")] 
		public CFloat DeltaPitchExternal
		{
			get
			{
				if (_deltaPitchExternal == null)
				{
					_deltaPitchExternal = (CFloat) CR2WTypeManager.Create("Float", "deltaPitchExternal", cr2w, this);
				}
				return _deltaPitchExternal;
			}
			set
			{
				if (_deltaPitchExternal == value)
				{
					return;
				}
				_deltaPitchExternal = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("deltaPitchInput")] 
		public CFloat DeltaPitchInput
		{
			get
			{
				if (_deltaPitchInput == null)
				{
					_deltaPitchInput = (CFloat) CR2WTypeManager.Create("Float", "deltaPitchInput", cr2w, this);
				}
				return _deltaPitchInput;
			}
			set
			{
				if (_deltaPitchInput == value)
				{
					return;
				}
				_deltaPitchInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("pitchSpeed")] 
		public CFloat PitchSpeed
		{
			get
			{
				if (_pitchSpeed == null)
				{
					_pitchSpeed = (CFloat) CR2WTypeManager.Create("Float", "pitchSpeed", cr2w, this);
				}
				return _pitchSpeed;
			}
			set
			{
				if (_pitchSpeed == value)
				{
					return;
				}
				_pitchSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get
			{
				if (_pitchMin == null)
				{
					_pitchMin = (CFloat) CR2WTypeManager.Create("Float", "pitchMin", cr2w, this);
				}
				return _pitchMin;
			}
			set
			{
				if (_pitchMin == value)
				{
					return;
				}
				_pitchMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get
			{
				if (_pitchMax == null)
				{
					_pitchMax = (CFloat) CR2WTypeManager.Create("Float", "pitchMax", cr2w, this);
				}
				return _pitchMax;
			}
			set
			{
				if (_pitchMax == value)
				{
					return;
				}
				_pitchMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("resetYawSpeed")] 
		public CFloat ResetYawSpeed
		{
			get
			{
				if (_resetYawSpeed == null)
				{
					_resetYawSpeed = (CFloat) CR2WTypeManager.Create("Float", "resetYawSpeed", cr2w, this);
				}
				return _resetYawSpeed;
			}
			set
			{
				if (_resetYawSpeed == value)
				{
					return;
				}
				_resetYawSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("resetPitchSpeed")] 
		public CFloat ResetPitchSpeed
		{
			get
			{
				if (_resetPitchSpeed == null)
				{
					_resetPitchSpeed = (CFloat) CR2WTypeManager.Create("Float", "resetPitchSpeed", cr2w, this);
				}
				return _resetPitchSpeed;
			}
			set
			{
				if (_resetPitchSpeed == value)
				{
					return;
				}
				_resetPitchSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("resetExternalsSpeed")] 
		public CFloat ResetExternalsSpeed
		{
			get
			{
				if (_resetExternalsSpeed == null)
				{
					_resetExternalsSpeed = (CFloat) CR2WTypeManager.Create("Float", "resetExternalsSpeed", cr2w, this);
				}
				return _resetExternalsSpeed;
			}
			set
			{
				if (_resetExternalsSpeed == value)
				{
					return;
				}
				_resetExternalsSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isSceneMode")] 
		public CBool IsSceneMode
		{
			get
			{
				if (_isSceneMode == null)
				{
					_isSceneMode = (CBool) CR2WTypeManager.Create("Bool", "isSceneMode", cr2w, this);
				}
				return _isSceneMode;
			}
			set
			{
				if (_isSceneMode == value)
				{
					return;
				}
				_isSceneMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("t4Blend")] 
		public CFloat T4Blend
		{
			get
			{
				if (_t4Blend == null)
				{
					_t4Blend = (CFloat) CR2WTypeManager.Create("Float", "t4Blend", cr2w, this);
				}
				return _t4Blend;
			}
			set
			{
				if (_t4Blend == value)
				{
					return;
				}
				_t4Blend = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("t4Pitch")] 
		public CFloat T4Pitch
		{
			get
			{
				if (_t4Pitch == null)
				{
					_t4Pitch = (CFloat) CR2WTypeManager.Create("Float", "t4Pitch", cr2w, this);
				}
				return _t4Pitch;
			}
			set
			{
				if (_t4Pitch == value)
				{
					return;
				}
				_t4Pitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("t4Yaw")] 
		public CFloat T4Yaw
		{
			get
			{
				if (_t4Yaw == null)
				{
					_t4Yaw = (CFloat) CR2WTypeManager.Create("Float", "t4Yaw", cr2w, this);
				}
				return _t4Yaw;
			}
			set
			{
				if (_t4Yaw == value)
				{
					return;
				}
				_t4Yaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("t4Roll")] 
		public CFloat T4Roll
		{
			get
			{
				if (_t4Roll == null)
				{
					_t4Roll = (CFloat) CR2WTypeManager.Create("Float", "t4Roll", cr2w, this);
				}
				return _t4Roll;
			}
			set
			{
				if (_t4Roll == value)
				{
					return;
				}
				_t4Roll = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("t4CopyPitchAndYaw")] 
		public CBool T4CopyPitchAndYaw
		{
			get
			{
				if (_t4CopyPitchAndYaw == null)
				{
					_t4CopyPitchAndYaw = (CBool) CR2WTypeManager.Create("Bool", "t4CopyPitchAndYaw", cr2w, this);
				}
				return _t4CopyPitchAndYaw;
			}
			set
			{
				if (_t4CopyPitchAndYaw == value)
				{
					return;
				}
				_t4CopyPitchAndYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("sceneCameraUseTrajectorySpace")] 
		public CBool SceneCameraUseTrajectorySpace
		{
			get
			{
				if (_sceneCameraUseTrajectorySpace == null)
				{
					_sceneCameraUseTrajectorySpace = (CBool) CR2WTypeManager.Create("Bool", "sceneCameraUseTrajectorySpace", cr2w, this);
				}
				return _sceneCameraUseTrajectorySpace;
			}
			set
			{
				if (_sceneCameraUseTrajectorySpace == value)
				{
					return;
				}
				_sceneCameraUseTrajectorySpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("sceneTransitioningToGameplay")] 
		public CBool SceneTransitioningToGameplay
		{
			get
			{
				if (_sceneTransitioningToGameplay == null)
				{
					_sceneTransitioningToGameplay = (CBool) CR2WTypeManager.Create("Bool", "sceneTransitioningToGameplay", cr2w, this);
				}
				return _sceneTransitioningToGameplay;
			}
			set
			{
				if (_sceneTransitioningToGameplay == value)
				{
					return;
				}
				_sceneTransitioningToGameplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("yawMultiplier")] 
		public CFloat YawMultiplier
		{
			get
			{
				if (_yawMultiplier == null)
				{
					_yawMultiplier = (CFloat) CR2WTypeManager.Create("Float", "yawMultiplier", cr2w, this);
				}
				return _yawMultiplier;
			}
			set
			{
				if (_yawMultiplier == value)
				{
					return;
				}
				_yawMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("pitchMultiplier")] 
		public CFloat PitchMultiplier
		{
			get
			{
				if (_pitchMultiplier == null)
				{
					_pitchMultiplier = (CFloat) CR2WTypeManager.Create("Float", "pitchMultiplier", cr2w, this);
				}
				return _pitchMultiplier;
			}
			set
			{
				if (_pitchMultiplier == value)
				{
					return;
				}
				_pitchMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("overridePitchInput")] 
		public CFloat OverridePitchInput
		{
			get
			{
				if (_overridePitchInput == null)
				{
					_overridePitchInput = (CFloat) CR2WTypeManager.Create("Float", "overridePitchInput", cr2w, this);
				}
				return _overridePitchInput;
			}
			set
			{
				if (_overridePitchInput == value)
				{
					return;
				}
				_overridePitchInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("overridePitchRef")] 
		public CFloat OverridePitchRef
		{
			get
			{
				if (_overridePitchRef == null)
				{
					_overridePitchRef = (CFloat) CR2WTypeManager.Create("Float", "overridePitchRef", cr2w, this);
				}
				return _overridePitchRef;
			}
			set
			{
				if (_overridePitchRef == value)
				{
					return;
				}
				_overridePitchRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("overrideYawInput")] 
		public CFloat OverrideYawInput
		{
			get
			{
				if (_overrideYawInput == null)
				{
					_overrideYawInput = (CFloat) CR2WTypeManager.Create("Float", "overrideYawInput", cr2w, this);
				}
				return _overrideYawInput;
			}
			set
			{
				if (_overrideYawInput == value)
				{
					return;
				}
				_overrideYawInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("overrideYawRef")] 
		public CFloat OverrideYawRef
		{
			get
			{
				if (_overrideYawRef == null)
				{
					_overrideYawRef = (CFloat) CR2WTypeManager.Create("Float", "overrideYawRef", cr2w, this);
				}
				return _overrideYawRef;
			}
			set
			{
				if (_overrideYawRef == value)
				{
					return;
				}
				_overrideYawRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("override")] 
		public CFloat Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CFloat) CR2WTypeManager.Create("Float", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("parallaxSide")] 
		public CFloat ParallaxSide
		{
			get
			{
				if (_parallaxSide == null)
				{
					_parallaxSide = (CFloat) CR2WTypeManager.Create("Float", "parallaxSide", cr2w, this);
				}
				return _parallaxSide;
			}
			set
			{
				if (_parallaxSide == value)
				{
					return;
				}
				_parallaxSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("parallaxForward")] 
		public CFloat ParallaxForward
		{
			get
			{
				if (_parallaxForward == null)
				{
					_parallaxForward = (CFloat) CR2WTypeManager.Create("Float", "parallaxForward", cr2w, this);
				}
				return _parallaxForward;
			}
			set
			{
				if (_parallaxForward == value)
				{
					return;
				}
				_parallaxForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("parallaxSpace")] 
		public CFloat ParallaxSpace
		{
			get
			{
				if (_parallaxSpace == null)
				{
					_parallaxSpace = (CFloat) CR2WTypeManager.Create("Float", "parallaxSpace", cr2w, this);
				}
				return _parallaxSpace;
			}
			set
			{
				if (_parallaxSpace == value)
				{
					return;
				}
				_parallaxSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("normalizeYaw")] 
		public CBool NormalizeYaw
		{
			get
			{
				if (_normalizeYaw == null)
				{
					_normalizeYaw = (CBool) CR2WTypeManager.Create("Bool", "normalizeYaw", cr2w, this);
				}
				return _normalizeYaw;
			}
			set
			{
				if (_normalizeYaw == value)
				{
					return;
				}
				_normalizeYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("vehicleOffsetWeight")] 
		public CFloat VehicleOffsetWeight
		{
			get
			{
				if (_vehicleOffsetWeight == null)
				{
					_vehicleOffsetWeight = (CFloat) CR2WTypeManager.Create("Float", "vehicleOffsetWeight", cr2w, this);
				}
				return _vehicleOffsetWeight;
			}
			set
			{
				if (_vehicleOffsetWeight == value)
				{
					return;
				}
				_vehicleOffsetWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("gameplayCameraPoseWeight")] 
		public CFloat GameplayCameraPoseWeight
		{
			get
			{
				if (_gameplayCameraPoseWeight == null)
				{
					_gameplayCameraPoseWeight = (CFloat) CR2WTypeManager.Create("Float", "gameplayCameraPoseWeight", cr2w, this);
				}
				return _gameplayCameraPoseWeight;
			}
			set
			{
				if (_gameplayCameraPoseWeight == value)
				{
					return;
				}
				_gameplayCameraPoseWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("additiveCameraMovementsWeight")] 
		public CFloat AdditiveCameraMovementsWeight
		{
			get
			{
				if (_additiveCameraMovementsWeight == null)
				{
					_additiveCameraMovementsWeight = (CFloat) CR2WTypeManager.Create("Float", "additiveCameraMovementsWeight", cr2w, this);
				}
				return _additiveCameraMovementsWeight;
			}
			set
			{
				if (_additiveCameraMovementsWeight == value)
				{
					return;
				}
				_additiveCameraMovementsWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get
			{
				if (_vehicleProceduralCameraWeight == null)
				{
					_vehicleProceduralCameraWeight = (CFloat) CR2WTypeManager.Create("Float", "vehicleProceduralCameraWeight", cr2w, this);
				}
				return _vehicleProceduralCameraWeight;
			}
			set
			{
				if (_vehicleProceduralCameraWeight == value)
				{
					return;
				}
				_vehicleProceduralCameraWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("t4CameraIdleOrientation")] 
		public Quaternion T4CameraIdleOrientation
		{
			get
			{
				if (_t4CameraIdleOrientation == null)
				{
					_t4CameraIdleOrientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "t4CameraIdleOrientation", cr2w, this);
				}
				return _t4CameraIdleOrientation;
			}
			set
			{
				if (_t4CameraIdleOrientation == value)
				{
					return;
				}
				_t4CameraIdleOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("t4UseCameraIdleOrientation")] 
		public CBool T4UseCameraIdleOrientation
		{
			get
			{
				if (_t4UseCameraIdleOrientation == null)
				{
					_t4UseCameraIdleOrientation = (CBool) CR2WTypeManager.Create("Bool", "t4UseCameraIdleOrientation", cr2w, this);
				}
				return _t4UseCameraIdleOrientation;
			}
			set
			{
				if (_t4UseCameraIdleOrientation == value)
				{
					return;
				}
				_t4UseCameraIdleOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("t4CameraControlIdleOrientation")] 
		public Quaternion T4CameraControlIdleOrientation
		{
			get
			{
				if (_t4CameraControlIdleOrientation == null)
				{
					_t4CameraControlIdleOrientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "t4CameraControlIdleOrientation", cr2w, this);
				}
				return _t4CameraControlIdleOrientation;
			}
			set
			{
				if (_t4CameraControlIdleOrientation == value)
				{
					return;
				}
				_t4CameraControlIdleOrientation = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_FPPCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
