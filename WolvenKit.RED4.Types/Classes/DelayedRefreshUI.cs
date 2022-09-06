
namespace WolvenKit.RED4.Types
{
	public partial class DelayedRefreshUI : redEvent
	{
		public DelayedRefreshUI()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
