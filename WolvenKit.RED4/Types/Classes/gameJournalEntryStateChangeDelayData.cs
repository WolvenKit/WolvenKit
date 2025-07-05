using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalEntryStateChangeDelayData : RedBaseClass
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
		[RED("oldState")] 
		public CEnum<gameJournalEntryState> OldState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(3)] 
		[RED("newState")] 
		public CEnum<gameJournalEntryState> NewState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(4)] 
		[RED("notifyOption")] 
		public CEnum<gameJournalNotifyOption> NotifyOption
		{
			get => GetPropertyValue<CEnum<gameJournalNotifyOption>>();
			set => SetPropertyValue<CEnum<gameJournalNotifyOption>>(value);
		}

		[Ordinal(5)] 
		[RED("changeType")] 
		public CEnum<gameJournalChangeType> ChangeType
		{
			get => GetPropertyValue<CEnum<gameJournalChangeType>>();
			set => SetPropertyValue<CEnum<gameJournalChangeType>>(value);
		}

		[Ordinal(6)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameJournalEntryStateChangeDelayData()
		{
			NotifyOption = Enums.gameJournalNotifyOption.DoNotNotify;
			ChangeType = Enums.gameJournalChangeType.Direct;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
