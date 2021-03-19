using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestlListItemClicked : redEvent
	{
		private wCHandle<gameJournalQuest> _questData;
		private CBool _skipAnimation;

		[Ordinal(0)] 
		[RED("questData")] 
		public wCHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetProperty(ref _skipAnimation);
			set => SetProperty(ref _skipAnimation, value);
		}

		public QuestlListItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
