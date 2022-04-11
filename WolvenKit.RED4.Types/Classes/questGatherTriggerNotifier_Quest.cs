
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGatherTriggerNotifier_Quest : worldITriggerAreaNotifer
	{

		public questGatherTriggerNotifier_Quest()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
