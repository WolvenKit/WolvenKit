using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEntryVisitedStatusData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isVisited")] 
		public CBool IsVisited
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalEntryVisitedStatusData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
