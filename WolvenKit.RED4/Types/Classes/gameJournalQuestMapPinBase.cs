using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestMapPinBase : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("enableGPS")] 
		public CBool EnableGPS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalQuestMapPinBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
