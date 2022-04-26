
namespace WolvenKit.RED4.Types
{
	public partial class worldAudioAttractAreaNotifier : worldITriggerAreaNotifer
	{
		public worldAudioAttractAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
