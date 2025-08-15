
namespace WolvenKit.RED4.Types
{
	public partial class DelayedDeleteNotificationOKEvent : redEvent
	{
		public DelayedDeleteNotificationOKEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
