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
		[RED("isOneTimeReward")] 
		public CBool IsOneTimeReward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("genericData")] 
		public GenericTemplatePersistentData GenericData
		{
			get => GetPropertyValue<GenericTemplatePersistentData>();
			set => SetPropertyValue<GenericTemplatePersistentData>(value);
		}

		[Ordinal(3)] 
		[RED("uniqueData")] 
		public UniqueTemplateData UniqueData
		{
			get => GetPropertyValue<UniqueTemplateData>();
			set => SetPropertyValue<UniqueTemplateData>(value);
		}

		public VehicleVisualCustomizationTemplate()
		{
			GenericData = new GenericTemplatePersistentData();
			UniqueData = new UniqueTemplateData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
