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
			get
			{
				if (_questData == null)
				{
					_questData = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "questData", cr2w, this);
				}
				return _questData;
			}
			set
			{
				if (_questData == value)
				{
					return;
				}
				_questData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get
			{
				if (_skipAnimation == null)
				{
					_skipAnimation = (CBool) CR2WTypeManager.Create("Bool", "skipAnimation", cr2w, this);
				}
				return _skipAnimation;
			}
			set
			{
				if (_skipAnimation == value)
				{
					return;
				}
				_skipAnimation = value;
				PropertySet(this);
			}
		}

		public QuestlListItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
