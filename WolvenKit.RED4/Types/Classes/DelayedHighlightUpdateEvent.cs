
namespace WolvenKit.RED4.Types
{
	public partial class DelayedHighlightUpdateEvent : redEvent
	{
		public DelayedHighlightUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
