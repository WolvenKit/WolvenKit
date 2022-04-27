
namespace WolvenKit.RED4.Types
{
	public partial class worldAudioSignpostTriggerNotifier : worldITriggerAreaNotifer
	{
		public worldAudioSignpostTriggerNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
