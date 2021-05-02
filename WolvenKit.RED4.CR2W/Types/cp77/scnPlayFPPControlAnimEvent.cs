using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayFPPControlAnimEvent : scnPlayAnimEvent
	{
		private CHandle<scnAnimName> _gameplayAnimName;
		private CBool _fPPControlActive;
		private CEnum<scnfppBlendOverride> _blendOverride;
		private CBool _cameraUseTrajectorySpace;
		private CFloat _cameraBlendInDuration;
		private CFloat _cameraBlendOutDuration;
		private CBool _stayInScene;
		private CBool _idleIsMountedWorkspot;
		private CFloat _cameraParallaxWeight;
		private CEnum<scnfppParallaxSpace> _cameraParallaxSpace;
		private CFloat _vehicleProceduralCameraWeight;
		private CFloat _yawLimitLeft;
		private CFloat _yawLimitRight;
		private CFloat _pitchLimitTop;
		private CFloat _pitchLimitBottom;
		private CArray<scnfppGenderSpecificParams> _genderSpecificParams;

		[Ordinal(15)] 
		[RED("gameplayAnimName")] 
		public CHandle<scnAnimName> GameplayAnimName
		{
			get => GetProperty(ref _gameplayAnimName);
			set => SetProperty(ref _gameplayAnimName, value);
		}

		[Ordinal(16)] 
		[RED("FPPControlActive")] 
		public CBool FPPControlActive
		{
			get => GetProperty(ref _fPPControlActive);
			set => SetProperty(ref _fPPControlActive, value);
		}

		[Ordinal(17)] 
		[RED("blendOverride")] 
		public CEnum<scnfppBlendOverride> BlendOverride
		{
			get => GetProperty(ref _blendOverride);
			set => SetProperty(ref _blendOverride, value);
		}

		[Ordinal(18)] 
		[RED("cameraUseTrajectorySpace")] 
		public CBool CameraUseTrajectorySpace
		{
			get => GetProperty(ref _cameraUseTrajectorySpace);
			set => SetProperty(ref _cameraUseTrajectorySpace, value);
		}

		[Ordinal(19)] 
		[RED("cameraBlendInDuration")] 
		public CFloat CameraBlendInDuration
		{
			get => GetProperty(ref _cameraBlendInDuration);
			set => SetProperty(ref _cameraBlendInDuration, value);
		}

		[Ordinal(20)] 
		[RED("cameraBlendOutDuration")] 
		public CFloat CameraBlendOutDuration
		{
			get => GetProperty(ref _cameraBlendOutDuration);
			set => SetProperty(ref _cameraBlendOutDuration, value);
		}

		[Ordinal(21)] 
		[RED("stayInScene")] 
		public CBool StayInScene
		{
			get => GetProperty(ref _stayInScene);
			set => SetProperty(ref _stayInScene, value);
		}

		[Ordinal(22)] 
		[RED("idleIsMountedWorkspot")] 
		public CBool IdleIsMountedWorkspot
		{
			get => GetProperty(ref _idleIsMountedWorkspot);
			set => SetProperty(ref _idleIsMountedWorkspot, value);
		}

		[Ordinal(23)] 
		[RED("cameraParallaxWeight")] 
		public CFloat CameraParallaxWeight
		{
			get => GetProperty(ref _cameraParallaxWeight);
			set => SetProperty(ref _cameraParallaxWeight, value);
		}

		[Ordinal(24)] 
		[RED("cameraParallaxSpace")] 
		public CEnum<scnfppParallaxSpace> CameraParallaxSpace
		{
			get => GetProperty(ref _cameraParallaxSpace);
			set => SetProperty(ref _cameraParallaxSpace, value);
		}

		[Ordinal(25)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get => GetProperty(ref _vehicleProceduralCameraWeight);
			set => SetProperty(ref _vehicleProceduralCameraWeight, value);
		}

		[Ordinal(26)] 
		[RED("yawLimitLeft")] 
		public CFloat YawLimitLeft
		{
			get => GetProperty(ref _yawLimitLeft);
			set => SetProperty(ref _yawLimitLeft, value);
		}

		[Ordinal(27)] 
		[RED("yawLimitRight")] 
		public CFloat YawLimitRight
		{
			get => GetProperty(ref _yawLimitRight);
			set => SetProperty(ref _yawLimitRight, value);
		}

		[Ordinal(28)] 
		[RED("pitchLimitTop")] 
		public CFloat PitchLimitTop
		{
			get => GetProperty(ref _pitchLimitTop);
			set => SetProperty(ref _pitchLimitTop, value);
		}

		[Ordinal(29)] 
		[RED("pitchLimitBottom")] 
		public CFloat PitchLimitBottom
		{
			get => GetProperty(ref _pitchLimitBottom);
			set => SetProperty(ref _pitchLimitBottom, value);
		}

		[Ordinal(30)] 
		[RED("genderSpecificParams")] 
		public CArray<scnfppGenderSpecificParams> GenderSpecificParams
		{
			get => GetProperty(ref _genderSpecificParams);
			set => SetProperty(ref _genderSpecificParams, value);
		}

		public scnPlayFPPControlAnimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
