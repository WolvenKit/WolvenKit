
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAudioAttractAreaNotifier : worldITriggerAreaNotifer
	{

		public worldAudioAttractAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
