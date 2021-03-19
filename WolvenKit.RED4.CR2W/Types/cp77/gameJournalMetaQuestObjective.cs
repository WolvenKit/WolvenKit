using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalMetaQuestObjective : gameJournalEntry
	{
		private LocalizationString _description;
		private CUInt32 _progressPercent;
		private TweakDBID _iconID;

		[Ordinal(1)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("progressPercent")] 
		public CUInt32 ProgressPercent
		{
			get => GetProperty(ref _progressPercent);
			set => SetProperty(ref _progressPercent, value);
		}

		[Ordinal(3)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		public gameJournalMetaQuestObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
