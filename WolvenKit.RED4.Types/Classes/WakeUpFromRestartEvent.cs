
namespace WolvenKit.RED4.Types
{
	public partial class WakeUpFromRestartEvent : redEvent
	{
		public WakeUpFromRestartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
