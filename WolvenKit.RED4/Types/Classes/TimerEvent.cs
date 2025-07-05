
namespace WolvenKit.RED4.Types
{
	public partial class TimerEvent : redEvent
	{
		public TimerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
