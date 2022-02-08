
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhaseFreezingAreaNotifier : worldITriggerAreaNotifer
	{

		public questPhaseFreezingAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
