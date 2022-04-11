using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponPositionComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("playerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(6)] 
		[RED("tweakPoseState")] 
		public CEnum<TweakWeaponPose> TweakPoseState
		{
			get => GetPropertyValue<CEnum<TweakWeaponPose>>();
			set => SetPropertyValue<CEnum<TweakWeaponPose>>(value);
		}

		[Ordinal(7)] 
		[RED("tweakPosition")] 
		public CBool TweakPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("tweakRotation")] 
		public CBool TweakRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("fineTuneWeaponPose")] 
		public CBool FineTuneWeaponPose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("positionSensitivity")] 
		public CFloat PositionSensitivity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("positionSensitivityFineTuning")] 
		public CFloat PositionSensitivityFineTuning
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("rotationSensitivity")] 
		public CFloat RotationSensitivity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("rotationSensitivityFineTuning")] 
		public CFloat RotationSensitivityFineTuning
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("visionSwitch")] 
		public CBool VisionSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("visSys")] 
		public CHandle<gameVisionModeSystem> VisSys
		{
			get => GetPropertyValue<CHandle<gameVisionModeSystem>>();
			set => SetPropertyValue<CHandle<gameVisionModeSystem>>(value);
		}

		[Ordinal(16)] 
		[RED("weaponPosDeltaX")] 
		public CFloat WeaponPosDeltaX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("weaponPosDeltaY")] 
		public CFloat WeaponPosDeltaY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("weaponPosDeltaZ")] 
		public CFloat WeaponPosDeltaZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("weaponRotDeltaX")] 
		public CFloat WeaponRotDeltaX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("weaponRotDeltaY")] 
		public CFloat WeaponRotDeltaY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("weaponRotDeltaZ")] 
		public CFloat WeaponRotDeltaZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("weaponPosVec")] 
		public Vector4 WeaponPosVec
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(23)] 
		[RED("weaponRotVec")] 
		public Vector4 WeaponRotVec
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(24)] 
		[RED("weaponAimPosVec")] 
		public Vector4 WeaponAimPosVec
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(25)] 
		[RED("weaponAimRotVec")] 
		public Vector4 WeaponAimRotVec
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(26)] 
		[RED("weaponPosOffsetFromInput")] 
		public Vector4 WeaponPosOffsetFromInput
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(27)] 
		[RED("weaponRotOffsetFromInput")] 
		public Vector4 WeaponRotOffsetFromInput
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(28)] 
		[RED("weaponAimPosOffsetFromInput")] 
		public Vector4 WeaponAimPosOffsetFromInput
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(29)] 
		[RED("weaponAimRotOffsetFromInput")] 
		public Vector4 WeaponAimRotOffsetFromInput
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(30)] 
		[RED("cameraStandHeight")] 
		public CFloat CameraStandHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("cameraCrouchHeight")] 
		public CFloat CameraCrouchHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("cameraResetPitch")] 
		public CBool CameraResetPitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("cameraHeightOffset")] 
		public CFloat CameraHeightOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("UILayerID0")] 
		public CUInt32 UILayerID0
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(35)] 
		[RED("UILayerID1")] 
		public CUInt32 UILayerID1
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(36)] 
		[RED("UILayerID2")] 
		public CUInt32 UILayerID2
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(37)] 
		[RED("UILayerID3")] 
		public CUInt32 UILayerID3
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public WeaponPositionComponent()
		{
			WeaponPosVec = new();
			WeaponRotVec = new();
			WeaponAimPosVec = new();
			WeaponAimRotVec = new();
			WeaponPosOffsetFromInput = new();
			WeaponRotOffsetFromInput = new();
			WeaponAimPosOffsetFromInput = new();
			WeaponAimRotOffsetFromInput = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
