using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVisualCustomizationPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public TweakDBID ID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("visualCustomizationData")] 
		public vehicleVisualModdingDefinition VisualCustomizationData
		{
			get => GetPropertyValue<vehicleVisualModdingDefinition>();
			set => SetPropertyValue<vehicleVisualModdingDefinition>(value);
		}

		public vehicleVisualCustomizationPersistentData()
		{
			VisualCustomizationData = new vehicleVisualModdingDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
