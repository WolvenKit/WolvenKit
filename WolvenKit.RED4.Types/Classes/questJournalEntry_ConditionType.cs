using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalEntry_ConditionType : questIJournalConditionType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gameJournalEntryUserState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryUserState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryUserState>>(value);
		}

		public questJournalEntry_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
