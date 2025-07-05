
namespace WolvenKit.RED4.Types
{
	public partial class questTriggerNotifier_Quest : worldITriggerAreaNotifer
	{
		public questTriggerNotifier_Quest()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
