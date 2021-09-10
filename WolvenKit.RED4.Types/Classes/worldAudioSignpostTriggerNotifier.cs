
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAudioSignpostTriggerNotifier : worldITriggerAreaNotifer
	{

		public worldAudioSignpostTriggerNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
