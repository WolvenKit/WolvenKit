using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowingKnifePickupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("throwCooldownSE")] 
		public TweakDBID ThrowCooldownSE
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ThrowingKnifePickupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
