
namespace WolvenKit.RED4.Types
{
	public partial class DelayedUpdateLayoutEvent : redEvent
	{
		public DelayedUpdateLayoutEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
