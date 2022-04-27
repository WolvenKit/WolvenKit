
namespace WolvenKit.RED4.Types
{
	public partial class questPhaseFreezingAreaNotifier : worldITriggerAreaNotifer
	{
		public questPhaseFreezingAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
