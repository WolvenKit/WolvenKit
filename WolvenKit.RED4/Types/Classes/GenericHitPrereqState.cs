using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericHitPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<HitCallback> Listener
		{
			get => GetPropertyValue<CHandle<HitCallback>>();
			set => SetPropertyValue<CHandle<HitCallback>>(value);
		}

		[Ordinal(1)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		[Ordinal(2)] 
		[RED("missEvent")] 
		public CHandle<gameeventsMissEvent> MissEvent
		{
			get => GetPropertyValue<CHandle<gameeventsMissEvent>>();
			set => SetPropertyValue<CHandle<gameeventsMissEvent>>(value);
		}

		public GenericHitPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
