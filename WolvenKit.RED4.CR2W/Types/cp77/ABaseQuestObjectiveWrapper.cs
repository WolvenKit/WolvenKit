using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ABaseQuestObjectiveWrapper : AJournalEntryWrapper
	{
		private wCHandle<gameJournalQuestObjectiveBase> _questObjective;
		private CEnum<gameJournalEntryState> _objectiveStatus;
		private CBool _isTracked;
		private CInt32 _currentCounter;
		private CInt32 _totalCounter;

		[Ordinal(1)] 
		[RED("questObjective")] 
		public wCHandle<gameJournalQuestObjectiveBase> QuestObjective
		{
			get => GetProperty(ref _questObjective);
			set => SetProperty(ref _questObjective, value);
		}

		[Ordinal(2)] 
		[RED("objectiveStatus")] 
		public CEnum<gameJournalEntryState> ObjectiveStatus
		{
			get => GetProperty(ref _objectiveStatus);
			set => SetProperty(ref _objectiveStatus, value);
		}

		[Ordinal(3)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetProperty(ref _isTracked);
			set => SetProperty(ref _isTracked, value);
		}

		[Ordinal(4)] 
		[RED("currentCounter")] 
		public CInt32 CurrentCounter
		{
			get => GetProperty(ref _currentCounter);
			set => SetProperty(ref _currentCounter, value);
		}

		[Ordinal(5)] 
		[RED("totalCounter")] 
		public CInt32 TotalCounter
		{
			get => GetProperty(ref _totalCounter);
			set => SetProperty(ref _totalCounter, value);
		}

		public ABaseQuestObjectiveWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
