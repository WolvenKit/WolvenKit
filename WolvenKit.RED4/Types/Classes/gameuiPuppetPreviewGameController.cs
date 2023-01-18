using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreviewGameController : gameuiPreviewGameController
	{
		[Ordinal(7)] 
		[RED("cameraController")] 
		public gameuiPuppetPreviewCameraController CameraController
		{
			get => GetPropertyValue<gameuiPuppetPreviewCameraController>();
			set => SetPropertyValue<gameuiPuppetPreviewCameraController>(value);
		}

		public gameuiPuppetPreviewGameController()
		{
			YawSpeed = 1.250000F;
			YawDefault = -125.000000F;
			RotationSpeed = 30.000000F;
			CameraController = new() { CameraSetup = new(), TransitionDelay = 0.500000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
