using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneAnimationMotionActionParams : IScriptable
	{
		private CEnum<gameSceneAnimationMotionActionParamsMotionType> _motionType;
		private WorldTransform _placementTransform;
		private CFloat _motionBlendInTime;
		private CFloat _poseBlendInTime;
		private CEnum<gameSceneAnimationMotionActionParamsEasingType> _blendInCurve;
		private CName _animationName;
		private CEnum<gameSceneAnimationMotionActionParamsPlacementMode> _placementMode;
		private CFloat _startTime;
		private CFloat _endTime;
		private CFloat _initialDt;
		private CFloat _globalTimeToAnimTime;
		private gameMountDescriptor _mountDescriptor;
		private gameScenePlayerAnimationParams _playerParams;
		private CEnum<gameSceneAnimationMotionActionParamsActionPlayDirection> _hACK_eventPlayDirection;
		private CArray<scnAnimationMotionSample> _trajectoryLOD;
		private CUInt64 _dynamicAnimSetupHash;

		[Ordinal(0)] 
		[RED("motionType")] 
		public CEnum<gameSceneAnimationMotionActionParamsMotionType> MotionType
		{
			get
			{
				if (_motionType == null)
				{
					_motionType = (CEnum<gameSceneAnimationMotionActionParamsMotionType>) CR2WTypeManager.Create("gameSceneAnimationMotionActionParamsMotionType", "motionType", cr2w, this);
				}
				return _motionType;
			}
			set
			{
				if (_motionType == value)
				{
					return;
				}
				_motionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("placementTransform")] 
		public WorldTransform PlacementTransform
		{
			get
			{
				if (_placementTransform == null)
				{
					_placementTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "placementTransform", cr2w, this);
				}
				return _placementTransform;
			}
			set
			{
				if (_placementTransform == value)
				{
					return;
				}
				_placementTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("motionBlendInTime")] 
		public CFloat MotionBlendInTime
		{
			get
			{
				if (_motionBlendInTime == null)
				{
					_motionBlendInTime = (CFloat) CR2WTypeManager.Create("Float", "motionBlendInTime", cr2w, this);
				}
				return _motionBlendInTime;
			}
			set
			{
				if (_motionBlendInTime == value)
				{
					return;
				}
				_motionBlendInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("poseBlendInTime")] 
		public CFloat PoseBlendInTime
		{
			get
			{
				if (_poseBlendInTime == null)
				{
					_poseBlendInTime = (CFloat) CR2WTypeManager.Create("Float", "poseBlendInTime", cr2w, this);
				}
				return _poseBlendInTime;
			}
			set
			{
				if (_poseBlendInTime == value)
				{
					return;
				}
				_poseBlendInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendInCurve")] 
		public CEnum<gameSceneAnimationMotionActionParamsEasingType> BlendInCurve
		{
			get
			{
				if (_blendInCurve == null)
				{
					_blendInCurve = (CEnum<gameSceneAnimationMotionActionParamsEasingType>) CR2WTypeManager.Create("gameSceneAnimationMotionActionParamsEasingType", "blendInCurve", cr2w, this);
				}
				return _blendInCurve;
			}
			set
			{
				if (_blendInCurve == value)
				{
					return;
				}
				_blendInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("placementMode")] 
		public CEnum<gameSceneAnimationMotionActionParamsPlacementMode> PlacementMode
		{
			get
			{
				if (_placementMode == null)
				{
					_placementMode = (CEnum<gameSceneAnimationMotionActionParamsPlacementMode>) CR2WTypeManager.Create("gameSceneAnimationMotionActionParamsPlacementMode", "placementMode", cr2w, this);
				}
				return _placementMode;
			}
			set
			{
				if (_placementMode == value)
				{
					return;
				}
				_placementMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get
			{
				if (_endTime == null)
				{
					_endTime = (CFloat) CR2WTypeManager.Create("Float", "endTime", cr2w, this);
				}
				return _endTime;
			}
			set
			{
				if (_endTime == value)
				{
					return;
				}
				_endTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("initialDt")] 
		public CFloat InitialDt
		{
			get
			{
				if (_initialDt == null)
				{
					_initialDt = (CFloat) CR2WTypeManager.Create("Float", "initialDt", cr2w, this);
				}
				return _initialDt;
			}
			set
			{
				if (_initialDt == value)
				{
					return;
				}
				_initialDt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("globalTimeToAnimTime")] 
		public CFloat GlobalTimeToAnimTime
		{
			get
			{
				if (_globalTimeToAnimTime == null)
				{
					_globalTimeToAnimTime = (CFloat) CR2WTypeManager.Create("Float", "globalTimeToAnimTime", cr2w, this);
				}
				return _globalTimeToAnimTime;
			}
			set
			{
				if (_globalTimeToAnimTime == value)
				{
					return;
				}
				_globalTimeToAnimTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("mountDescriptor")] 
		public gameMountDescriptor MountDescriptor
		{
			get
			{
				if (_mountDescriptor == null)
				{
					_mountDescriptor = (gameMountDescriptor) CR2WTypeManager.Create("gameMountDescriptor", "mountDescriptor", cr2w, this);
				}
				return _mountDescriptor;
			}
			set
			{
				if (_mountDescriptor == value)
				{
					return;
				}
				_mountDescriptor = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerParams")] 
		public gameScenePlayerAnimationParams PlayerParams
		{
			get
			{
				if (_playerParams == null)
				{
					_playerParams = (gameScenePlayerAnimationParams) CR2WTypeManager.Create("gameScenePlayerAnimationParams", "playerParams", cr2w, this);
				}
				return _playerParams;
			}
			set
			{
				if (_playerParams == value)
				{
					return;
				}
				_playerParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("HACK_eventPlayDirection")] 
		public CEnum<gameSceneAnimationMotionActionParamsActionPlayDirection> HACK_eventPlayDirection
		{
			get
			{
				if (_hACK_eventPlayDirection == null)
				{
					_hACK_eventPlayDirection = (CEnum<gameSceneAnimationMotionActionParamsActionPlayDirection>) CR2WTypeManager.Create("gameSceneAnimationMotionActionParamsActionPlayDirection", "HACK_eventPlayDirection", cr2w, this);
				}
				return _hACK_eventPlayDirection;
			}
			set
			{
				if (_hACK_eventPlayDirection == value)
				{
					return;
				}
				_hACK_eventPlayDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get
			{
				if (_trajectoryLOD == null)
				{
					_trajectoryLOD = (CArray<scnAnimationMotionSample>) CR2WTypeManager.Create("array:scnAnimationMotionSample", "trajectoryLOD", cr2w, this);
				}
				return _trajectoryLOD;
			}
			set
			{
				if (_trajectoryLOD == value)
				{
					return;
				}
				_trajectoryLOD = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dynamicAnimSetupHash")] 
		public CUInt64 DynamicAnimSetupHash
		{
			get
			{
				if (_dynamicAnimSetupHash == null)
				{
					_dynamicAnimSetupHash = (CUInt64) CR2WTypeManager.Create("Uint64", "dynamicAnimSetupHash", cr2w, this);
				}
				return _dynamicAnimSetupHash;
			}
			set
			{
				if (_dynamicAnimSetupHash == value)
				{
					return;
				}
				_dynamicAnimSetupHash = value;
				PropertySet(this);
			}
		}

		public gameSceneAnimationMotionActionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
