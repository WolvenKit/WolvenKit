
namespace WolvenKit.RED4.Types
{
	public partial class questGatherTriggerNotifier_Quest : worldITriggerAreaNotifer
	{
		public questGatherTriggerNotifier_Quest()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
