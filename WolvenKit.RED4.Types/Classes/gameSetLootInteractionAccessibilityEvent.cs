using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetLootInteractionAccessibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetLootInteractionAccessibilityEvent()
		{
			Accessible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
