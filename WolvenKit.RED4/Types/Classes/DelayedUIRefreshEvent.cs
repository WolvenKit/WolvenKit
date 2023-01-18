
namespace WolvenKit.RED4.Types
{
	public partial class DelayedUIRefreshEvent : redEvent
	{
		public DelayedUIRefreshEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
