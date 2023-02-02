using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDamageReceivedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameeventsDamageReceivedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
