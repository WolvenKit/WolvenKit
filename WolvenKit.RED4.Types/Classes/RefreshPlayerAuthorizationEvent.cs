
namespace WolvenKit.RED4.Types
{
	public partial class RefreshPlayerAuthorizationEvent : redEvent
	{
		public RefreshPlayerAuthorizationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
