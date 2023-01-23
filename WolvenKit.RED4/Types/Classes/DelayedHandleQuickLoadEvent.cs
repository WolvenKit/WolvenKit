
namespace WolvenKit.RED4.Types
{
	public partial class DelayedHandleQuickLoadEvent : redEvent
	{
		public DelayedHandleQuickLoadEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
