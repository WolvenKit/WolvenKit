using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestCodexLink : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		public gameJournalQuestCodexLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
