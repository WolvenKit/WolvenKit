
namespace WolvenKit.RED4.Types
{
	public partial class worldSaveSanitizationForbiddenAreaNotifier : worldITriggerAreaNotifer
	{
		public worldSaveSanitizationForbiddenAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
