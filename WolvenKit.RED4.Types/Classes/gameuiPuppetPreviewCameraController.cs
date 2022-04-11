using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreviewCameraController : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cameraSetup")] 
		public CArray<gameuiPuppetPreviewCameraSetup> CameraSetup
		{
			get => GetPropertyValue<CArray<gameuiPuppetPreviewCameraSetup>>();
			set => SetPropertyValue<CArray<gameuiPuppetPreviewCameraSetup>>(value);
		}

		[Ordinal(1)] 
		[RED("activeSetup")] 
		public CUInt32 ActiveSetup
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("transitionDelay")] 
		public CFloat TransitionDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPuppetPreviewCameraController()
		{
			CameraSetup = new();
			TransitionDelay = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
