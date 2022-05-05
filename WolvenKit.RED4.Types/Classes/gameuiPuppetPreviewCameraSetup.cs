using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreviewCameraSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("cameraZoom")] 
		public CFloat CameraZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("interpolationTime")] 
		public CFloat InterpolationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPuppetPreviewCameraSetup()
		{
			CameraZoom = -1.000000F;
			InterpolationTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
