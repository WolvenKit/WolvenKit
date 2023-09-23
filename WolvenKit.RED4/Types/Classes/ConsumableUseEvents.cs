using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConsumableUseEvents : ConsumableTransitions
	{
		[Ordinal(0)] 
		[RED("effectsApplied")] 
		public CBool EffectsApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("modelRemoved")] 
		public CBool ModelRemoved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("activeConsumable")] 
		public gameItemID ActiveConsumable
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public ConsumableUseEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
