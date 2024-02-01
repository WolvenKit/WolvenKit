using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StoreVisualCustomizationDataForIDEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public TweakDBID ID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("definition")] 
		public vehicleVisualModdingDefinition Definition
		{
			get => GetPropertyValue<vehicleVisualModdingDefinition>();
			set => SetPropertyValue<vehicleVisualModdingDefinition>(value);
		}

		public StoreVisualCustomizationDataForIDEvent()
		{
			Definition = new vehicleVisualModdingDefinition();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
