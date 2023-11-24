
namespace WolvenKit.RED4.Types
{
	public partial class DelayedRefreshItems : redEvent
	{
		public DelayedRefreshItems()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
