
namespace WolvenKit.RED4.Types
{
	public partial class PurgeAllTransitions : redEvent
	{
		public PurgeAllTransitions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
