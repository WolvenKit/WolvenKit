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
			get => GetProperty(ref _fov);
			set => SetProperty(ref _fov, value);
		}

		[Ordinal(1)] 
		[RED("deltaYaw")] 
		public CFloat DeltaYaw
		{
			get => GetProperty(ref _deltaYaw);
			set => SetProperty(ref _deltaYaw, value);
		}

		[Ordinal(2)] 
		[RED("deltaYawExternal")] 
		public CFloat DeltaYawExternal
		{
			get => GetProperty(ref _deltaYawExternal);
			set => SetProperty(ref _deltaYawExternal, value);
		}

		[Ordinal(3)] 
		[RED("deltaYawInput")] 
		public CFloat DeltaYawInput
		{
			get => GetProperty(ref _deltaYawInput);
			set => SetProperty(ref _deltaYawInput, value);
		}

		[Ordinal(4)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get => GetProperty(ref _yawSpeed);
			set => SetProperty(ref _yawSpeed, value);
		}

		[Ordinal(5)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get => GetProperty(ref _yawMaxLeft);
			set => SetProperty(ref _yawMaxLeft, value);
		}

		[Ordinal(6)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get => GetProperty(ref _yawMaxRight);
			set => SetProperty(ref _yawMaxRight, value);
		}

		[Ordinal(7)] 
		[RED("deltaPitch")] 
		public CFloat DeltaPitch
		{
			get => GetProperty(ref _deltaPitch);
			set => SetProperty(ref _deltaPitch, value);
		}

		[Ordinal(8)] 
		[RED("deltaPitchExternal")] 
		public CFloat DeltaPitchExternal
		{
			get => GetProperty(ref _deltaPitchExternal);
			set => SetProperty(ref _deltaPitchExternal, value);
		}

		[Ordinal(9)] 
		[RED("deltaPitchInput")] 
		public CFloat DeltaPitchInput
		{
			get => GetProperty(ref _deltaPitchInput);
			set => SetProperty(ref _deltaPitchInput, value);
		}

		[Ordinal(10)] 
		[RED("pitchSpeed")] 
		public CFloat PitchSpeed
		{
			get => GetProperty(ref _pitchSpeed);
			set => SetProperty(ref _pitchSpeed, value);
		}

		[Ordinal(11)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get => GetProperty(ref _pitchMin);
			set => SetProperty(ref _pitchMin, value);
		}

		[Ordinal(12)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get => GetProperty(ref _pitchMax);
			set => SetProperty(ref _pitchMax, value);
		}

		[Ordinal(13)] 
		[RED("resetYawSpeed")] 
		public CFloat ResetYawSpeed
		{
			get => GetProperty(ref _resetYawSpeed);
			set => SetProperty(ref _resetYawSpeed, value);
		}

		[Ordinal(14)] 
		[RED("resetPitchSpeed")] 
		public CFloat ResetPitchSpeed
		{
			get => GetProperty(ref _resetPitchSpeed);
			set => SetProperty(ref _resetPitchSpeed, value);
		}

		[Ordinal(15)] 
		[RED("resetExternalsSpeed")] 
		public CFloat ResetExternalsSpeed
		{
			get => GetProperty(ref _resetExternalsSpeed);
			set => SetProperty(ref _resetExternalsSpeed, value);
		}

		[Ordinal(16)] 
		[RED("isSceneMode")] 
		public CBool IsSceneMode
		{
			get => GetProperty(ref _isSceneMode);
			set => SetProperty(ref _isSceneMode, value);
		}

		[Ordinal(17)] 
		[RED("t4Blend")] 
		public CFloat T4Blend
		{
			get => GetProperty(ref _t4Blend);
			set => SetProperty(ref _t4Blend, value);
		}

		[Ordinal(18)] 
		[RED("t4Pitch")] 
		public CFloat T4Pitch
		{
			get => GetProperty(ref _t4Pitch);
			set => SetProperty(ref _t4Pitch, value);
		}

		[Ordinal(19)] 
		[RED("t4Yaw")] 
		public CFloat T4Yaw
		{
			get => GetProperty(ref _t4Yaw);
			set => SetProperty(ref _t4Yaw, value);
		}

		[Ordinal(20)] 
		[RED("t4Roll")] 
		public CFloat T4Roll
		{
			get => GetProperty(ref _t4Roll);
			set => SetProperty(ref _t4Roll, value);
		}

		[Ordinal(21)] 
		[RED("t4CopyPitchAndYaw")] 
		public CBool T4CopyPitchAndYaw
		{
			get => GetProperty(ref _t4CopyPitchAndYaw);
			set => SetProperty(ref _t4CopyPitchAndYaw, value);
		}

		[Ordinal(22)] 
		[RED("sceneCameraUseTrajectorySpace")] 
		public CBool SceneCameraUseTrajectorySpace
		{
			get => GetProperty(ref _sceneCameraUseTrajectorySpace);
			set => SetProperty(ref _sceneCameraUseTrajectorySpace, value);
		}

		[Ordinal(23)] 
		[RED("sceneTransitioningToGameplay")] 
		public CBool SceneTransitioningToGameplay
		{
			get => GetProperty(ref _sceneTransitioningToGameplay);
			set => SetProperty(ref _sceneTransitioningToGameplay, value);
		}

		[Ordinal(24)] 
		[RED("yawMultiplier")] 
		public CFloat YawMultiplier
		{
			get => GetProperty(ref _yawMultiplier);
			set => SetProperty(ref _yawMultiplier, value);
		}

		[Ordinal(25)] 
		[RED("pitchMultiplier")] 
		public CFloat PitchMultiplier
		{
			get => GetProperty(ref _pitchMultiplier);
			set => SetProperty(ref _pitchMultiplier, value);
		}

		[Ordinal(26)] 
		[RED("overridePitchInput")] 
		public CFloat OverridePitchInput
		{
			get => GetProperty(ref _overridePitchInput);
			set => SetProperty(ref _overridePitchInput, value);
		}

		[Ordinal(27)] 
		[RED("overridePitchRef")] 
		public CFloat OverridePitchRef
		{
			get => GetProperty(ref _overridePitchRef);
			set => SetProperty(ref _overridePitchRef, value);
		}

		[Ordinal(28)] 
		[RED("overrideYawInput")] 
		public CFloat OverrideYawInput
		{
			get => GetProperty(ref _overrideYawInput);
			set => SetProperty(ref _overrideYawInput, value);
		}

		[Ordinal(29)] 
		[RED("overrideYawRef")] 
		public CFloat OverrideYawRef
		{
			get => GetProperty(ref _overrideYawRef);
			set => SetProperty(ref _overrideYawRef, value);
		}

		[Ordinal(30)] 
		[RED("override")] 
		public CFloat Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(31)] 
		[RED("parallaxSide")] 
		public CFloat ParallaxSide
		{
			get => GetProperty(ref _parallaxSide);
			set => SetProperty(ref _parallaxSide, value);
		}

		[Ordinal(32)] 
		[RED("parallaxForward")] 
		public CFloat ParallaxForward
		{
			get => GetProperty(ref _parallaxForward);
			set => SetProperty(ref _parallaxForward, value);
		}

		[Ordinal(33)] 
		[RED("parallaxSpace")] 
		public CFloat ParallaxSpace
		{
			get => GetProperty(ref _parallaxSpace);
			set => SetProperty(ref _parallaxSpace, value);
		}

		[Ordinal(34)] 
		[RED("normalizeYaw")] 
		public CBool NormalizeYaw
		{
			get => GetProperty(ref _normalizeYaw);
			set => SetProperty(ref _normalizeYaw, value);
		}

		[Ordinal(35)] 
		[RED("vehicleOffsetWeight")] 
		public CFloat VehicleOffsetWeight
		{
			get => GetProperty(ref _vehicleOffsetWeight);
			set => SetProperty(ref _vehicleOffsetWeight, value);
		}

		[Ordinal(36)] 
		[RED("gameplayCameraPoseWeight")] 
		public CFloat GameplayCameraPoseWeight
		{
			get => GetProperty(ref _gameplayCameraPoseWeight);
			set => SetProperty(ref _gameplayCameraPoseWeight, value);
		}

		[Ordinal(37)] 
		[RED("additiveCameraMovementsWeight")] 
		public CFloat AdditiveCameraMovementsWeight
		{
			get => GetProperty(ref _additiveCameraMovementsWeight);
			set => SetProperty(ref _additiveCameraMovementsWeight, value);
		}

		[Ordinal(38)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get => GetProperty(ref _vehicleProceduralCameraWeight);
			set => SetProperty(ref _vehicleProceduralCameraWeight, value);
		}

		[Ordinal(39)] 
		[RED("t4CameraIdleOrientation")] 
		public Quaternion T4CameraIdleOrientation
		{
			get => GetProperty(ref _t4CameraIdleOrientation);
			set => SetProperty(ref _t4CameraIdleOrientation, value);
		}

		[Ordinal(40)] 
		[RED("t4UseCameraIdleOrientation")] 
		public CBool T4UseCameraIdleOrientation
		{
			get => GetProperty(ref _t4UseCameraIdleOrientation);
			set => SetProperty(ref _t4UseCameraIdleOrientation, value);
		}

		[Ordinal(41)] 
		[RED("t4CameraControlIdleOrientation")] 
		public Quaternion T4CameraControlIdleOrientation
		{
			get => GetProperty(ref _t4CameraControlIdleOrientation);
			set => SetProperty(ref _t4CameraControlIdleOrientation, value);
		}

		public animAnimFeature_FPPCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
