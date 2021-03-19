using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDataWrapper : AJournalEntryWrapper
	{
		private CBool _isNew;
		private wCHandle<gameJournalQuest> _quest;
		private CString _title;
		private CString _description;
		private CArray<CHandle<QuestObjectiveWrapper>> _questObjectives;
		private CArray<wCHandle<gameJournalEntry>> _links;
		private CEnum<gameJournalEntryState> _questStatus;
		private CBool _isTracked;
		private CBool _isChildTracked;
		private CInt32 _recommendedLevel;
		private CHandle<gamedataDistrict_Record> _district;

		[Ordinal(1)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public wCHandle<gameJournalQuest> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(5)] 
		[RED("questObjectives")] 
		public CArray<CHandle<QuestObjectiveWrapper>> QuestObjectives
		{
			get => GetProperty(ref _questObjectives);
			set => SetProperty(ref _questObjectives, value);
		}

		[Ordinal(6)] 
		[RED("links")] 
		public CArray<wCHandle<gameJournalEntry>> Links
		{
			get => GetProperty(ref _links);
			set => SetProperty(ref _links, value);
		}

		[Ordinal(7)] 
		[RED("questStatus")] 
		public CEnum<gameJournalEntryState> QuestStatus
		{
			get => GetProperty(ref _questStatus);
			set => SetProperty(ref _questStatus, value);
		}

		[Ordinal(8)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetProperty(ref _isTracked);
			set => SetProperty(ref _isTracked, value);
		}

		[Ordinal(9)] 
		[RED("isChildTracked")] 
		public CBool IsChildTracked
		{
			get => GetProperty(ref _isChildTracked);
			set => SetProperty(ref _isChildTracked, value);
		}

		[Ordinal(10)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(11)] 
		[RED("district")] 
		public CHandle<gamedataDistrict_Record> District
		{
			get => GetProperty(ref _district);
			set => SetProperty(ref _district, value);
		}

		public QuestDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
