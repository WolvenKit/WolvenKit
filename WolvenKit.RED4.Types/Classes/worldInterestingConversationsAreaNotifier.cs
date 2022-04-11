
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInterestingConversationsAreaNotifier : worldITriggerAreaNotifer
	{

		public worldInterestingConversationsAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;
		}
	}
}
