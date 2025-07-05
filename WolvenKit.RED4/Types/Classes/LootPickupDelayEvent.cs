using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootPickupDelayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enableLootInteraction")] 
		public CBool EnableLootInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LootPickupDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
