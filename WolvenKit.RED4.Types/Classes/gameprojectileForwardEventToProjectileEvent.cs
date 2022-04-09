using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileForwardEventToProjectileEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("eventToForward")] 
		public CHandle<redEvent> EventToForward
		{
			get => GetPropertyValue<CHandle<redEvent>>();
			set => SetPropertyValue<CHandle<redEvent>>(value);
		}

		public gameprojectileForwardEventToProjectileEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
