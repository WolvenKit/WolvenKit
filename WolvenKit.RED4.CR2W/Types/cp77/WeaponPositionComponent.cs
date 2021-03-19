using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponPositionComponent : gameScriptableComponent
	{
		private wCHandle<PlayerPuppet> _playerPuppet;
		private CEnum<TweakWeaponPose> _tweakPoseState;
		private CBool _tweakPosition;
		private CBool _tweakRotation;
		private CBool _fineTuneWeaponPose;
		private CFloat _positionSensitivity;
		private CFloat _positionSensitivityFineTuning;
		private CFloat _rotationSensitivity;
		private CFloat _rotationSensitivityFineTuning;
		private CBool _visionSwitch;
		private CHandle<gameVisionModeSystem> _visSys;
		private CFloat _weaponPosDeltaX;
		private CFloat _weaponPosDeltaY;
		private CFloat _weaponPosDeltaZ;
		private CFloat _weaponRotDeltaX;
		private CFloat _weaponRotDeltaY;
		private CFloat _weaponRotDeltaZ;
		private Vector4 _weaponPosVec;
		private Vector4 _weaponRotVec;
		private Vector4 _weaponAimPosVec;
		private Vector4 _weaponAimRotVec;
		private Vector4 _weaponPosOffsetFromInput;
		private Vector4 _weaponRotOffsetFromInput;
		private Vector4 _weaponAimPosOffsetFromInput;
		private Vector4 _weaponAimRotOffsetFromInput;
		private CFloat _cameraStandHeight;
		private CFloat _cameraCrouchHeight;
		private CBool _cameraResetPitch;
		private CFloat _cameraHeightOffset;
		private CUInt32 _uILayerID0;
		private CUInt32 _uILayerID1;
		private CUInt32 _uILayerID2;
		private CUInt32 _uILayerID3;

		[Ordinal(5)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(6)] 
		[RED("tweakPoseState")] 
		public CEnum<TweakWeaponPose> TweakPoseState
		{
			get => GetProperty(ref _tweakPoseState);
			set => SetProperty(ref _tweakPoseState, value);
		}

		[Ordinal(7)] 
		[RED("tweakPosition")] 
		public CBool TweakPosition
		{
			get => GetProperty(ref _tweakPosition);
			set => SetProperty(ref _tweakPosition, value);
		}

		[Ordinal(8)] 
		[RED("tweakRotation")] 
		public CBool TweakRotation
		{
			get => GetProperty(ref _tweakRotation);
			set => SetProperty(ref _tweakRotation, value);
		}

		[Ordinal(9)] 
		[RED("fineTuneWeaponPose")] 
		public CBool FineTuneWeaponPose
		{
			get => GetProperty(ref _fineTuneWeaponPose);
			set => SetProperty(ref _fineTuneWeaponPose, value);
		}

		[Ordinal(10)] 
		[RED("positionSensitivity")] 
		public CFloat PositionSensitivity
		{
			get => GetProperty(ref _positionSensitivity);
			set => SetProperty(ref _positionSensitivity, value);
		}

		[Ordinal(11)] 
		[RED("positionSensitivityFineTuning")] 
		public CFloat PositionSensitivityFineTuning
		{
			get => GetProperty(ref _positionSensitivityFineTuning);
			set => SetProperty(ref _positionSensitivityFineTuning, value);
		}

		[Ordinal(12)] 
		[RED("rotationSensitivity")] 
		public CFloat RotationSensitivity
		{
			get => GetProperty(ref _rotationSensitivity);
			set => SetProperty(ref _rotationSensitivity, value);
		}

		[Ordinal(13)] 
		[RED("rotationSensitivityFineTuning")] 
		public CFloat RotationSensitivityFineTuning
		{
			get => GetProperty(ref _rotationSensitivityFineTuning);
			set => SetProperty(ref _rotationSensitivityFineTuning, value);
		}

		[Ordinal(14)] 
		[RED("visionSwitch")] 
		public CBool VisionSwitch
		{
			get => GetProperty(ref _visionSwitch);
			set => SetProperty(ref _visionSwitch, value);
		}

		[Ordinal(15)] 
		[RED("visSys")] 
		public CHandle<gameVisionModeSystem> VisSys
		{
			get => GetProperty(ref _visSys);
			set => SetProperty(ref _visSys, value);
		}

		[Ordinal(16)] 
		[RED("weaponPosDeltaX")] 
		public CFloat WeaponPosDeltaX
		{
			get => GetProperty(ref _weaponPosDeltaX);
			set => SetProperty(ref _weaponPosDeltaX, value);
		}

		[Ordinal(17)] 
		[RED("weaponPosDeltaY")] 
		public CFloat WeaponPosDeltaY
		{
			get => GetProperty(ref _weaponPosDeltaY);
			set => SetProperty(ref _weaponPosDeltaY, value);
		}

		[Ordinal(18)] 
		[RED("weaponPosDeltaZ")] 
		public CFloat WeaponPosDeltaZ
		{
			get => GetProperty(ref _weaponPosDeltaZ);
			set => SetProperty(ref _weaponPosDeltaZ, value);
		}

		[Ordinal(19)] 
		[RED("weaponRotDeltaX")] 
		public CFloat WeaponRotDeltaX
		{
			get => GetProperty(ref _weaponRotDeltaX);
			set => SetProperty(ref _weaponRotDeltaX, value);
		}

		[Ordinal(20)] 
		[RED("weaponRotDeltaY")] 
		public CFloat WeaponRotDeltaY
		{
			get => GetProperty(ref _weaponRotDeltaY);
			set => SetProperty(ref _weaponRotDeltaY, value);
		}

		[Ordinal(21)] 
		[RED("weaponRotDeltaZ")] 
		public CFloat WeaponRotDeltaZ
		{
			get => GetProperty(ref _weaponRotDeltaZ);
			set => SetProperty(ref _weaponRotDeltaZ, value);
		}

		[Ordinal(22)] 
		[RED("weaponPosVec")] 
		public Vector4 WeaponPosVec
		{
			get => GetProperty(ref _weaponPosVec);
			set => SetProperty(ref _weaponPosVec, value);
		}

		[Ordinal(23)] 
		[RED("weaponRotVec")] 
		public Vector4 WeaponRotVec
		{
			get => GetProperty(ref _weaponRotVec);
			set => SetProperty(ref _weaponRotVec, value);
		}

		[Ordinal(24)] 
		[RED("weaponAimPosVec")] 
		public Vector4 WeaponAimPosVec
		{
			get => GetProperty(ref _weaponAimPosVec);
			set => SetProperty(ref _weaponAimPosVec, value);
		}

		[Ordinal(25)] 
		[RED("weaponAimRotVec")] 
		public Vector4 WeaponAimRotVec
		{
			get => GetProperty(ref _weaponAimRotVec);
			set => SetProperty(ref _weaponAimRotVec, value);
		}

		[Ordinal(26)] 
		[RED("weaponPosOffsetFromInput")] 
		public Vector4 WeaponPosOffsetFromInput
		{
			get => GetProperty(ref _weaponPosOffsetFromInput);
			set => SetProperty(ref _weaponPosOffsetFromInput, value);
		}

		[Ordinal(27)] 
		[RED("weaponRotOffsetFromInput")] 
		public Vector4 WeaponRotOffsetFromInput
		{
			get => GetProperty(ref _weaponRotOffsetFromInput);
			set => SetProperty(ref _weaponRotOffsetFromInput, value);
		}

		[Ordinal(28)] 
		[RED("weaponAimPosOffsetFromInput")] 
		public Vector4 WeaponAimPosOffsetFromInput
		{
			get => GetProperty(ref _weaponAimPosOffsetFromInput);
			set => SetProperty(ref _weaponAimPosOffsetFromInput, value);
		}

		[Ordinal(29)] 
		[RED("weaponAimRotOffsetFromInput")] 
		public Vector4 WeaponAimRotOffsetFromInput
		{
			get => GetProperty(ref _weaponAimRotOffsetFromInput);
			set => SetProperty(ref _weaponAimRotOffsetFromInput, value);
		}

		[Ordinal(30)] 
		[RED("cameraStandHeight")] 
		public CFloat CameraStandHeight
		{
			get => GetProperty(ref _cameraStandHeight);
			set => SetProperty(ref _cameraStandHeight, value);
		}

		[Ordinal(31)] 
		[RED("cameraCrouchHeight")] 
		public CFloat CameraCrouchHeight
		{
			get => GetProperty(ref _cameraCrouchHeight);
			set => SetProperty(ref _cameraCrouchHeight, value);
		}

		[Ordinal(32)] 
		[RED("cameraResetPitch")] 
		public CBool CameraResetPitch
		{
			get => GetProperty(ref _cameraResetPitch);
			set => SetProperty(ref _cameraResetPitch, value);
		}

		[Ordinal(33)] 
		[RED("cameraHeightOffset")] 
		public CFloat CameraHeightOffset
		{
			get => GetProperty(ref _cameraHeightOffset);
			set => SetProperty(ref _cameraHeightOffset, value);
		}

		[Ordinal(34)] 
		[RED("UILayerID0")] 
		public CUInt32 UILayerID0
		{
			get => GetProperty(ref _uILayerID0);
			set => SetProperty(ref _uILayerID0, value);
		}

		[Ordinal(35)] 
		[RED("UILayerID1")] 
		public CUInt32 UILayerID1
		{
			get => GetProperty(ref _uILayerID1);
			set => SetProperty(ref _uILayerID1, value);
		}

		[Ordinal(36)] 
		[RED("UILayerID2")] 
		public CUInt32 UILayerID2
		{
			get => GetProperty(ref _uILayerID2);
			set => SetProperty(ref _uILayerID2, value);
		}

		[Ordinal(37)] 
		[RED("UILayerID3")] 
		public CUInt32 UILayerID3
		{
			get => GetProperty(ref _uILayerID3);
			set => SetProperty(ref _uILayerID3, value);
		}

		public WeaponPositionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
