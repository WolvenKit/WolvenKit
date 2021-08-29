using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalMetaQuestObjective : gameJournalEntry
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
	}
}
