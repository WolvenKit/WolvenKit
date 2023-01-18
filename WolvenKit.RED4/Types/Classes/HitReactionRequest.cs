using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitReactionRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		public HitReactionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
