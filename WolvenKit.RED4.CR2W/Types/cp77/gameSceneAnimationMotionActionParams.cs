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
		private CArray<scnAnimationMotionSample> _trajectoryLOD;
		private CUInt64 _dynamicAnimSetupHash;

		[Ordinal(0)] 
		[RED("motionType")] 
		public CEnum<gameSceneAnimationMotionActionParamsMotionType> MotionType
		{
			get => GetProperty(ref _motionType);
			set => SetProperty(ref _motionType, value);
		}

		[Ordinal(1)] 
		[RED("placementTransform")] 
		public WorldTransform PlacementTransform
		{
			get => GetProperty(ref _placementTransform);
			set => SetProperty(ref _placementTransform, value);
		}

		[Ordinal(2)] 
		[RED("motionBlendInTime")] 
		public CFloat MotionBlendInTime
		{
			get => GetProperty(ref _motionBlendInTime);
			set => SetProperty(ref _motionBlendInTime, value);
		}

		[Ordinal(3)] 
		[RED("poseBlendInTime")] 
		public CFloat PoseBlendInTime
		{
			get => GetProperty(ref _poseBlendInTime);
			set => SetProperty(ref _poseBlendInTime, value);
		}

		[Ordinal(4)] 
		[RED("blendInCurve")] 
		public CEnum<gameSceneAnimationMotionActionParamsEasingType> BlendInCurve
		{
			get => GetProperty(ref _blendInCurve);
			set => SetProperty(ref _blendInCurve, value);
		}

		[Ordinal(5)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(6)] 
		[RED("placementMode")] 
		public CEnum<gameSceneAnimationMotionActionParamsPlacementMode> PlacementMode
		{
			get => GetProperty(ref _placementMode);
			set => SetProperty(ref _placementMode, value);
		}

		[Ordinal(7)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(8)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetProperty(ref _endTime);
			set => SetProperty(ref _endTime, value);
		}

		[Ordinal(9)] 
		[RED("initialDt")] 
		public CFloat InitialDt
		{
			get => GetProperty(ref _initialDt);
			set => SetProperty(ref _initialDt, value);
		}

		[Ordinal(10)] 
		[RED("globalTimeToAnimTime")] 
		public CFloat GlobalTimeToAnimTime
		{
			get => GetProperty(ref _globalTimeToAnimTime);
			set => SetProperty(ref _globalTimeToAnimTime, value);
		}

		[Ordinal(11)] 
		[RED("mountDescriptor")] 
		public gameMountDescriptor MountDescriptor
		{
			get => GetProperty(ref _mountDescriptor);
			set => SetProperty(ref _mountDescriptor, value);
		}

		[Ordinal(12)] 
		[RED("playerParams")] 
		public gameScenePlayerAnimationParams PlayerParams
		{
			get => GetProperty(ref _playerParams);
			set => SetProperty(ref _playerParams, value);
		}

		[Ordinal(13)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get => GetProperty(ref _trajectoryLOD);
			set => SetProperty(ref _trajectoryLOD, value);
		}

		[Ordinal(14)] 
		[RED("dynamicAnimSetupHash")] 
		public CUInt64 DynamicAnimSetupHash
		{
			get => GetProperty(ref _dynamicAnimSetupHash);
			set => SetProperty(ref _dynamicAnimSetupHash, value);
		}

		public gameSceneAnimationMotionActionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
