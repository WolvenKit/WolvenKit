using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUseWorkspotPlayerParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<questUseWorkspotTier> Tier
		{
			get => GetPropertyValue<CEnum<questUseWorkspotTier>>();
			set => SetPropertyValue<CEnum<questUseWorkspotTier>>(value);
		}

		[Ordinal(1)] 
		[RED("cameraSettings")] 
		public gameTier3CameraSettings CameraSettings
		{
			get => GetPropertyValue<gameTier3CameraSettings>();
			set => SetPropertyValue<gameTier3CameraSettings>(value);
		}

		[Ordinal(2)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("cameraUseTrajectorySpace")] 
		public CBool CameraUseTrajectorySpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("applyCameraParams")] 
		public CBool ApplyCameraParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("parallaxWeight")] 
		public CFloat ParallaxWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("parallaxSpace")] 
		public CEnum<questCameraParallaxSpace> ParallaxSpace
		{
			get => GetPropertyValue<CEnum<questCameraParallaxSpace>>();
			set => SetPropertyValue<CEnum<questCameraParallaxSpace>>(value);
		}

		public questUseWorkspotPlayerParams()
		{
			CameraSettings = new() { YawLeftLimit = 60.000000F, YawRightLimit = 60.000000F, PitchTopLimit = 60.000000F, PitchBottomLimit = 45.000000F, PitchSpeedMultiplier = 1.000000F, YawSpeedMultiplier = 1.000000F };
			CameraUseTrajectorySpace = true;
			VehicleProceduralCameraWeight = 1.000000F;
			ParallaxWeight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
