
namespace WolvenKit.RED4.Types
{
	public partial class worldInterestingConversationsAreaNotifier : worldITriggerAreaNotifer
	{
		public worldInterestingConversationsAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
