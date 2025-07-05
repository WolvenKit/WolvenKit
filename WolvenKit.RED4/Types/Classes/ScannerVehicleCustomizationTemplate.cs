using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerVehicleCustomizationTemplate : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("VehicleCustomizationTemplate")] 
		public VehicleVisualCustomizationTemplate VehicleCustomizationTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(1)] 
		[RED("ProfileRestricted")] 
		public CBool ProfileRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ModelName")] 
		public CName ModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ScannerVehicleCustomizationTemplate()
		{
			VehicleCustomizationTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
