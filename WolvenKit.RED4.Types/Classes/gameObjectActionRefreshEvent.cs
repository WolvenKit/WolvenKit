
namespace WolvenKit.RED4.Types
{
	public partial class gameObjectActionRefreshEvent : redEvent
	{
		public gameObjectActionRefreshEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
