using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwarePreviewSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("apperanceCameraLocation")] 
		public CName ApperanceCameraLocation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("femaleColorCustomizationCameraLocation")] 
		public CName FemaleColorCustomizationCameraLocation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("maleColorCustomizationCameraLocation")] 
		public CName MaleColorCustomizationCameraLocation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CyberwarePreviewSettings()
		{
			ApperanceCameraLocation = "UIWardrobePreview";
			FemaleColorCustomizationCameraLocation = "UIWardrobePreview";
			MaleColorCustomizationCameraLocation = "UIWardrobePreview";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
