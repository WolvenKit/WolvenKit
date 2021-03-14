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
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tweakPoseState")] 
		public CEnum<TweakWeaponPose> TweakPoseState
		{
			get
			{
				if (_tweakPoseState == null)
				{
					_tweakPoseState = (CEnum<TweakWeaponPose>) CR2WTypeManager.Create("TweakWeaponPose", "tweakPoseState", cr2w, this);
				}
				return _tweakPoseState;
			}
			set
			{
				if (_tweakPoseState == value)
				{
					return;
				}
				_tweakPoseState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tweakPosition")] 
		public CBool TweakPosition
		{
			get
			{
				if (_tweakPosition == null)
				{
					_tweakPosition = (CBool) CR2WTypeManager.Create("Bool", "tweakPosition", cr2w, this);
				}
				return _tweakPosition;
			}
			set
			{
				if (_tweakPosition == value)
				{
					return;
				}
				_tweakPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tweakRotation")] 
		public CBool TweakRotation
		{
			get
			{
				if (_tweakRotation == null)
				{
					_tweakRotation = (CBool) CR2WTypeManager.Create("Bool", "tweakRotation", cr2w, this);
				}
				return _tweakRotation;
			}
			set
			{
				if (_tweakRotation == value)
				{
					return;
				}
				_tweakRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fineTuneWeaponPose")] 
		public CBool FineTuneWeaponPose
		{
			get
			{
				if (_fineTuneWeaponPose == null)
				{
					_fineTuneWeaponPose = (CBool) CR2WTypeManager.Create("Bool", "fineTuneWeaponPose", cr2w, this);
				}
				return _fineTuneWeaponPose;
			}
			set
			{
				if (_fineTuneWeaponPose == value)
				{
					return;
				}
				_fineTuneWeaponPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("positionSensitivity")] 
		public CFloat PositionSensitivity
		{
			get
			{
				if (_positionSensitivity == null)
				{
					_positionSensitivity = (CFloat) CR2WTypeManager.Create("Float", "positionSensitivity", cr2w, this);
				}
				return _positionSensitivity;
			}
			set
			{
				if (_positionSensitivity == value)
				{
					return;
				}
				_positionSensitivity = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("positionSensitivityFineTuning")] 
		public CFloat PositionSensitivityFineTuning
		{
			get
			{
				if (_positionSensitivityFineTuning == null)
				{
					_positionSensitivityFineTuning = (CFloat) CR2WTypeManager.Create("Float", "positionSensitivityFineTuning", cr2w, this);
				}
				return _positionSensitivityFineTuning;
			}
			set
			{
				if (_positionSensitivityFineTuning == value)
				{
					return;
				}
				_positionSensitivityFineTuning = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rotationSensitivity")] 
		public CFloat RotationSensitivity
		{
			get
			{
				if (_rotationSensitivity == null)
				{
					_rotationSensitivity = (CFloat) CR2WTypeManager.Create("Float", "rotationSensitivity", cr2w, this);
				}
				return _rotationSensitivity;
			}
			set
			{
				if (_rotationSensitivity == value)
				{
					return;
				}
				_rotationSensitivity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rotationSensitivityFineTuning")] 
		public CFloat RotationSensitivityFineTuning
		{
			get
			{
				if (_rotationSensitivityFineTuning == null)
				{
					_rotationSensitivityFineTuning = (CFloat) CR2WTypeManager.Create("Float", "rotationSensitivityFineTuning", cr2w, this);
				}
				return _rotationSensitivityFineTuning;
			}
			set
			{
				if (_rotationSensitivityFineTuning == value)
				{
					return;
				}
				_rotationSensitivityFineTuning = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("visionSwitch")] 
		public CBool VisionSwitch
		{
			get
			{
				if (_visionSwitch == null)
				{
					_visionSwitch = (CBool) CR2WTypeManager.Create("Bool", "visionSwitch", cr2w, this);
				}
				return _visionSwitch;
			}
			set
			{
				if (_visionSwitch == value)
				{
					return;
				}
				_visionSwitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("visSys")] 
		public CHandle<gameVisionModeSystem> VisSys
		{
			get
			{
				if (_visSys == null)
				{
					_visSys = (CHandle<gameVisionModeSystem>) CR2WTypeManager.Create("handle:gameVisionModeSystem", "visSys", cr2w, this);
				}
				return _visSys;
			}
			set
			{
				if (_visSys == value)
				{
					return;
				}
				_visSys = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("weaponPosDeltaX")] 
		public CFloat WeaponPosDeltaX
		{
			get
			{
				if (_weaponPosDeltaX == null)
				{
					_weaponPosDeltaX = (CFloat) CR2WTypeManager.Create("Float", "weaponPosDeltaX", cr2w, this);
				}
				return _weaponPosDeltaX;
			}
			set
			{
				if (_weaponPosDeltaX == value)
				{
					return;
				}
				_weaponPosDeltaX = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("weaponPosDeltaY")] 
		public CFloat WeaponPosDeltaY
		{
			get
			{
				if (_weaponPosDeltaY == null)
				{
					_weaponPosDeltaY = (CFloat) CR2WTypeManager.Create("Float", "weaponPosDeltaY", cr2w, this);
				}
				return _weaponPosDeltaY;
			}
			set
			{
				if (_weaponPosDeltaY == value)
				{
					return;
				}
				_weaponPosDeltaY = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weaponPosDeltaZ")] 
		public CFloat WeaponPosDeltaZ
		{
			get
			{
				if (_weaponPosDeltaZ == null)
				{
					_weaponPosDeltaZ = (CFloat) CR2WTypeManager.Create("Float", "weaponPosDeltaZ", cr2w, this);
				}
				return _weaponPosDeltaZ;
			}
			set
			{
				if (_weaponPosDeltaZ == value)
				{
					return;
				}
				_weaponPosDeltaZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weaponRotDeltaX")] 
		public CFloat WeaponRotDeltaX
		{
			get
			{
				if (_weaponRotDeltaX == null)
				{
					_weaponRotDeltaX = (CFloat) CR2WTypeManager.Create("Float", "weaponRotDeltaX", cr2w, this);
				}
				return _weaponRotDeltaX;
			}
			set
			{
				if (_weaponRotDeltaX == value)
				{
					return;
				}
				_weaponRotDeltaX = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("weaponRotDeltaY")] 
		public CFloat WeaponRotDeltaY
		{
			get
			{
				if (_weaponRotDeltaY == null)
				{
					_weaponRotDeltaY = (CFloat) CR2WTypeManager.Create("Float", "weaponRotDeltaY", cr2w, this);
				}
				return _weaponRotDeltaY;
			}
			set
			{
				if (_weaponRotDeltaY == value)
				{
					return;
				}
				_weaponRotDeltaY = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("weaponRotDeltaZ")] 
		public CFloat WeaponRotDeltaZ
		{
			get
			{
				if (_weaponRotDeltaZ == null)
				{
					_weaponRotDeltaZ = (CFloat) CR2WTypeManager.Create("Float", "weaponRotDeltaZ", cr2w, this);
				}
				return _weaponRotDeltaZ;
			}
			set
			{
				if (_weaponRotDeltaZ == value)
				{
					return;
				}
				_weaponRotDeltaZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("weaponPosVec")] 
		public Vector4 WeaponPosVec
		{
			get
			{
				if (_weaponPosVec == null)
				{
					_weaponPosVec = (Vector4) CR2WTypeManager.Create("Vector4", "weaponPosVec", cr2w, this);
				}
				return _weaponPosVec;
			}
			set
			{
				if (_weaponPosVec == value)
				{
					return;
				}
				_weaponPosVec = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("weaponRotVec")] 
		public Vector4 WeaponRotVec
		{
			get
			{
				if (_weaponRotVec == null)
				{
					_weaponRotVec = (Vector4) CR2WTypeManager.Create("Vector4", "weaponRotVec", cr2w, this);
				}
				return _weaponRotVec;
			}
			set
			{
				if (_weaponRotVec == value)
				{
					return;
				}
				_weaponRotVec = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("weaponAimPosVec")] 
		public Vector4 WeaponAimPosVec
		{
			get
			{
				if (_weaponAimPosVec == null)
				{
					_weaponAimPosVec = (Vector4) CR2WTypeManager.Create("Vector4", "weaponAimPosVec", cr2w, this);
				}
				return _weaponAimPosVec;
			}
			set
			{
				if (_weaponAimPosVec == value)
				{
					return;
				}
				_weaponAimPosVec = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("weaponAimRotVec")] 
		public Vector4 WeaponAimRotVec
		{
			get
			{
				if (_weaponAimRotVec == null)
				{
					_weaponAimRotVec = (Vector4) CR2WTypeManager.Create("Vector4", "weaponAimRotVec", cr2w, this);
				}
				return _weaponAimRotVec;
			}
			set
			{
				if (_weaponAimRotVec == value)
				{
					return;
				}
				_weaponAimRotVec = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("weaponPosOffsetFromInput")] 
		public Vector4 WeaponPosOffsetFromInput
		{
			get
			{
				if (_weaponPosOffsetFromInput == null)
				{
					_weaponPosOffsetFromInput = (Vector4) CR2WTypeManager.Create("Vector4", "weaponPosOffsetFromInput", cr2w, this);
				}
				return _weaponPosOffsetFromInput;
			}
			set
			{
				if (_weaponPosOffsetFromInput == value)
				{
					return;
				}
				_weaponPosOffsetFromInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("weaponRotOffsetFromInput")] 
		public Vector4 WeaponRotOffsetFromInput
		{
			get
			{
				if (_weaponRotOffsetFromInput == null)
				{
					_weaponRotOffsetFromInput = (Vector4) CR2WTypeManager.Create("Vector4", "weaponRotOffsetFromInput", cr2w, this);
				}
				return _weaponRotOffsetFromInput;
			}
			set
			{
				if (_weaponRotOffsetFromInput == value)
				{
					return;
				}
				_weaponRotOffsetFromInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("weaponAimPosOffsetFromInput")] 
		public Vector4 WeaponAimPosOffsetFromInput
		{
			get
			{
				if (_weaponAimPosOffsetFromInput == null)
				{
					_weaponAimPosOffsetFromInput = (Vector4) CR2WTypeManager.Create("Vector4", "weaponAimPosOffsetFromInput", cr2w, this);
				}
				return _weaponAimPosOffsetFromInput;
			}
			set
			{
				if (_weaponAimPosOffsetFromInput == value)
				{
					return;
				}
				_weaponAimPosOffsetFromInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("weaponAimRotOffsetFromInput")] 
		public Vector4 WeaponAimRotOffsetFromInput
		{
			get
			{
				if (_weaponAimRotOffsetFromInput == null)
				{
					_weaponAimRotOffsetFromInput = (Vector4) CR2WTypeManager.Create("Vector4", "weaponAimRotOffsetFromInput", cr2w, this);
				}
				return _weaponAimRotOffsetFromInput;
			}
			set
			{
				if (_weaponAimRotOffsetFromInput == value)
				{
					return;
				}
				_weaponAimRotOffsetFromInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("cameraStandHeight")] 
		public CFloat CameraStandHeight
		{
			get
			{
				if (_cameraStandHeight == null)
				{
					_cameraStandHeight = (CFloat) CR2WTypeManager.Create("Float", "cameraStandHeight", cr2w, this);
				}
				return _cameraStandHeight;
			}
			set
			{
				if (_cameraStandHeight == value)
				{
					return;
				}
				_cameraStandHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("cameraCrouchHeight")] 
		public CFloat CameraCrouchHeight
		{
			get
			{
				if (_cameraCrouchHeight == null)
				{
					_cameraCrouchHeight = (CFloat) CR2WTypeManager.Create("Float", "cameraCrouchHeight", cr2w, this);
				}
				return _cameraCrouchHeight;
			}
			set
			{
				if (_cameraCrouchHeight == value)
				{
					return;
				}
				_cameraCrouchHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("cameraResetPitch")] 
		public CBool CameraResetPitch
		{
			get
			{
				if (_cameraResetPitch == null)
				{
					_cameraResetPitch = (CBool) CR2WTypeManager.Create("Bool", "cameraResetPitch", cr2w, this);
				}
				return _cameraResetPitch;
			}
			set
			{
				if (_cameraResetPitch == value)
				{
					return;
				}
				_cameraResetPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("cameraHeightOffset")] 
		public CFloat CameraHeightOffset
		{
			get
			{
				if (_cameraHeightOffset == null)
				{
					_cameraHeightOffset = (CFloat) CR2WTypeManager.Create("Float", "cameraHeightOffset", cr2w, this);
				}
				return _cameraHeightOffset;
			}
			set
			{
				if (_cameraHeightOffset == value)
				{
					return;
				}
				_cameraHeightOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("UILayerID0")] 
		public CUInt32 UILayerID0
		{
			get
			{
				if (_uILayerID0 == null)
				{
					_uILayerID0 = (CUInt32) CR2WTypeManager.Create("Uint32", "UILayerID0", cr2w, this);
				}
				return _uILayerID0;
			}
			set
			{
				if (_uILayerID0 == value)
				{
					return;
				}
				_uILayerID0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("UILayerID1")] 
		public CUInt32 UILayerID1
		{
			get
			{
				if (_uILayerID1 == null)
				{
					_uILayerID1 = (CUInt32) CR2WTypeManager.Create("Uint32", "UILayerID1", cr2w, this);
				}
				return _uILayerID1;
			}
			set
			{
				if (_uILayerID1 == value)
				{
					return;
				}
				_uILayerID1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("UILayerID2")] 
		public CUInt32 UILayerID2
		{
			get
			{
				if (_uILayerID2 == null)
				{
					_uILayerID2 = (CUInt32) CR2WTypeManager.Create("Uint32", "UILayerID2", cr2w, this);
				}
				return _uILayerID2;
			}
			set
			{
				if (_uILayerID2 == value)
				{
					return;
				}
				_uILayerID2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("UILayerID3")] 
		public CUInt32 UILayerID3
		{
			get
			{
				if (_uILayerID3 == null)
				{
					_uILayerID3 = (CUInt32) CR2WTypeManager.Create("Uint32", "UILayerID3", cr2w, this);
				}
				return _uILayerID3;
			}
			set
			{
				if (_uILayerID3 == value)
				{
					return;
				}
				_uILayerID3 = value;
				PropertySet(this);
			}
		}

		public WeaponPositionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
