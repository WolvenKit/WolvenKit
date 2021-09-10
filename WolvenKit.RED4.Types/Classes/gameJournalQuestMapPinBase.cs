using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestMapPinBase : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("enableGPS")] 
		public CBool EnableGPS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
