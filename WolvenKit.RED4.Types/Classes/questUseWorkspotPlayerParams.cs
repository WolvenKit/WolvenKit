using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUseWorkspotPlayerParams : RedBaseClass
	{
		private CEnum<questUseWorkspotTier> _tier;
		private gameTier3CameraSettings _cameraSettings;
		private CBool _emptyHands;
		private CBool _cameraUseTrajectorySpace;
		private CBool _applyCameraParams;
		private CFloat _vehicleProceduralCameraWeight;
		private CFloat _parallaxWeight;
		private CEnum<questCameraParallaxSpace> _parallaxSpace;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<questUseWorkspotTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(1)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get => GetProperty(ref _cameraSettings);
			set => SetProperty(ref _cameraSettings, value);
		}

		[Ordinal(2)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get => GetProperty(ref _emptyHands);
			set => SetProperty(ref _emptyHands, value);
		}

		[Ordinal(3)] 
		[RED("cameraUseTrajectorySpace")] 
		public CBool CameraUseTrajectorySpace
		{
			get => GetProperty(ref _cameraUseTrajectorySpace);
			set => SetProperty(ref _cameraUseTrajectorySpace, value);
		}

		[Ordinal(4)] 
		[RED("applyCameraParams")] 
		public CBool ApplyCameraParams
		{
			get => GetProperty(ref _applyCameraParams);
			set => SetProperty(ref _applyCameraParams, value);
		}

		[Ordinal(5)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get => GetProperty(ref _vehicleProceduralCameraWeight);
			set => SetProperty(ref _vehicleProceduralCameraWeight, value);
		}

		[Ordinal(6)] 
		[RED("parallaxWeight")] 
		public CFloat ParallaxWeight
		{
			get => GetProperty(ref _parallaxWeight);
			set => SetProperty(ref _parallaxWeight, value);
		}

		[Ordinal(7)] 
		[RED("parallaxSpace")] 
		public CEnum<questCameraParallaxSpace> ParallaxSpace
		{
			get => GetProperty(ref _parallaxSpace);
			set => SetProperty(ref _parallaxSpace, value);
		}

		public questUseWorkspotPlayerParams()
		{
			_cameraUseTrajectorySpace = true;
			_vehicleProceduralCameraWeight = 1.000000F;
			_parallaxWeight = 1.000000F;
		}
	}
}
