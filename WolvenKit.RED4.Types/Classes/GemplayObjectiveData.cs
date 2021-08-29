using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GemplayObjectiveData : IScriptable
	{
		private CString _questUniqueId;
		private CString _questTitle;
		private CString _objectiveDescription;
		private CString _uniqueId;
		private entEntityID _ownerID;
		private CString _objectiveEntryID;
		private CString _uniqueIdPrefix;
		private CEnum<gameJournalEntryState> _objectiveState;

		[Ordinal(0)] 
		[RED("questUniqueId")] 
		public CString QuestUniqueId
		{
			get => GetProperty(ref _questUniqueId);
			set => SetProperty(ref _questUniqueId, value);
		}

		[Ordinal(1)] 
		[RED("questTitle")] 
		public CString QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(2)] 
		[RED("objectiveDescription")] 
		public CString ObjectiveDescription
		{
			get => GetProperty(ref _objectiveDescription);
			set => SetProperty(ref _objectiveDescription, value);
		}

		[Ordinal(3)] 
		[RED("uniqueId")] 
		public CString UniqueId
		{
			get => GetProperty(ref _uniqueId);
			set => SetProperty(ref _uniqueId, value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(5)] 
		[RED("objectiveEntryID")] 
		public CString ObjectiveEntryID
		{
			get => GetProperty(ref _objectiveEntryID);
			set => SetProperty(ref _objectiveEntryID, value);
		}

		[Ordinal(6)] 
		[RED("uniqueIdPrefix")] 
		public CString UniqueIdPrefix
		{
			get => GetProperty(ref _uniqueIdPrefix);
			set => SetProperty(ref _uniqueIdPrefix, value);
		}

		[Ordinal(7)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get => GetProperty(ref _objectiveState);
			set => SetProperty(ref _objectiveState, value);
		}
	}
}
