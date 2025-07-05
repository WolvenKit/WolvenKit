using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalBulkUpdate_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("requiredEntryType")] 
		public CName RequiredEntryType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("requiredEntryState")] 
		public CName RequiredEntryState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("newEntryState")] 
		public CName NewEntryState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("propagateChange")] 
		public CBool PropagateChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJournalBulkUpdate_NodeType()
		{
			RequiredEntryState = "Any";
			NewEntryState = "Inactive";
			SendNotification = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
