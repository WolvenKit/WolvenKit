
namespace WolvenKit.RED4.Types
{
	public partial class worldPerformanceAreaNotifier : worldITriggerAreaNotifer
	{
		public worldPerformanceAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
