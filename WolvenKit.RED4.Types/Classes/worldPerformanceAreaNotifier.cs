
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPerformanceAreaNotifier : worldITriggerAreaNotifer
	{

		public worldPerformanceAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
