using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GemplayObjectiveData : IScriptable
	{
		[Ordinal(0)] 
		[RED("questUniqueId")] 
		public CString QuestUniqueId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("questTitle")] 
		public CString QuestTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("objectiveDescription")] 
		public CString ObjectiveDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("uniqueId")] 
		public CString UniqueId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(5)] 
		[RED("objectiveEntryID")] 
		public CString ObjectiveEntryID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("uniqueIdPrefix")] 
		public CString UniqueIdPrefix
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		public GemplayObjectiveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
