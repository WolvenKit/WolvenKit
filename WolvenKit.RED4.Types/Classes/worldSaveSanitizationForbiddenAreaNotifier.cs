
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSaveSanitizationForbiddenAreaNotifier : worldITriggerAreaNotifer
	{

		public worldSaveSanitizationForbiddenAreaNotifier()
		{
			IsEnabled = true;
			IncludeChannels = Enums.TriggerChannel.TC_Default;
		}
	}
}
