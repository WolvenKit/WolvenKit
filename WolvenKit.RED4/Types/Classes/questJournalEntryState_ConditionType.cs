using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalEntryState_ConditionType : questIJournalConditionType
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
		public CEnum<gameJournalEntryState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(2)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questJournalEntryState_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
