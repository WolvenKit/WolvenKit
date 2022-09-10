using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetItemAppearanceInSlotDelayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ResetItemAppearanceInSlotDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
