
namespace WolvenKit.RED4.Types
{
	public partial class OnReleaseWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		public OnReleaseWorkspotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
