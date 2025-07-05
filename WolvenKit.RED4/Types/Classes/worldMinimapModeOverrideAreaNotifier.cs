
namespace WolvenKit.RED4.Types
{
	public partial class worldMinimapModeOverrideAreaNotifier : worldITriggerAreaNotifer
	{
		public worldMinimapModeOverrideAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Player;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
