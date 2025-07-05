using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEntryStateChangeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CString EntryName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("isEntryTracked")] 
		public CBool IsEntryTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isQuestEntryTracked")] 
		public CBool IsQuestEntryTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("oldState")] 
		public CEnum<gameJournalEntryState> OldState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(6)] 
		[RED("newState")] 
		public CEnum<gameJournalEntryState> NewState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(7)] 
		[RED("notifyOption")] 
		public CEnum<gameJournalNotifyOption> NotifyOption
		{
			get => GetPropertyValue<CEnum<gameJournalNotifyOption>>();
			set => SetPropertyValue<CEnum<gameJournalNotifyOption>>(value);
		}

		[Ordinal(8)] 
		[RED("changeType")] 
		public CEnum<gameJournalChangeType> ChangeType
		{
			get => GetPropertyValue<CEnum<gameJournalChangeType>>();
			set => SetPropertyValue<CEnum<gameJournalChangeType>>(value);
		}

		public gameJournalEntryStateChangeData()
		{
			NotifyOption = Enums.gameJournalNotifyOption.DoNotNotify;
			ChangeType = Enums.gameJournalChangeType.Direct;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
