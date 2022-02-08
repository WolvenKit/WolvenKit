
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTriggerNotifier_Quest : worldITriggerAreaNotifer
	{

		public questTriggerNotifier_Quest()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
