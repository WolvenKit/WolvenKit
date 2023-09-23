using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalWrapper : ABaseWrapper
	{
		[Ordinal(0)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(1)] 
		[RED("journalContext")] 
		public gameJournalRequestContext JournalContext
		{
			get => GetPropertyValue<gameJournalRequestContext>();
			set => SetPropertyValue<gameJournalRequestContext>(value);
		}

		[Ordinal(2)] 
		[RED("journalSubQuestContext")] 
		public gameJournalRequestContext JournalSubQuestContext
		{
			get => GetPropertyValue<gameJournalRequestContext>();
			set => SetPropertyValue<gameJournalRequestContext>(value);
		}

		[Ordinal(3)] 
		[RED("listOfJournalEntries")] 
		public CArray<CWeakHandle<gameJournalEntry>> ListOfJournalEntries
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(4)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public JournalWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
