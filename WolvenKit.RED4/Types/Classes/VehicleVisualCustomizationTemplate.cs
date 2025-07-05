using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleVisualCustomizationTemplate : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasUniqueTemplate")] 
		public CBool HasUniqueTemplate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("genericData")] 
		public GenericTemplatePersistentData GenericData
		{
			get => GetPropertyValue<GenericTemplatePersistentData>();
			set => SetPropertyValue<GenericTemplatePersistentData>(value);
		}

		[Ordinal(2)] 
		[RED("uniqueData")] 
		public UniqueTemplateData UniqueData
		{
			get => GetPropertyValue<UniqueTemplateData>();
			set => SetPropertyValue<UniqueTemplateData>(value);
		}

		public VehicleVisualCustomizationTemplate()
		{
			GenericData = new GenericTemplatePersistentData();
			UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
