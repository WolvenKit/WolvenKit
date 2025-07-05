
namespace WolvenKit.RED4.Types
{
	public partial class entTriggerNotifier_Script : worldITriggerAreaNotifer
	{
		public entTriggerNotifier_Script()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
