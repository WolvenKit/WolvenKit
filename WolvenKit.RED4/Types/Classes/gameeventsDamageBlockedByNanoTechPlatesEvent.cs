using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDamageBlockedByNanoTechPlatesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		public gameeventsDamageBlockedByNanoTechPlatesEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
