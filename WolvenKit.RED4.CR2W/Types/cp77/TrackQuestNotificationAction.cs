using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		private wCHandle<gameJournalQuest> _questEntry;
		private wCHandle<gameJournalManager> _journalMgr;

		[Ordinal(0)] 
		[RED("questEntry")] 
		public wCHandle<gameJournalQuest> QuestEntry
		{
			get
			{
				if (_questEntry == null)
				{
					_questEntry = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "questEntry", cr2w, this);
				}
				return _questEntry;
			}
			set
			{
				if (_questEntry == value)
				{
					return;
				}
				_questEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get
			{
				if (_journalMgr == null)
				{
					_journalMgr = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalMgr", cr2w, this);
				}
				return _journalMgr;
			}
			set
			{
				if (_journalMgr == value)
				{
					return;
				}
				_journalMgr = value;
				PropertySet(this);
			}
		}

		public TrackQuestNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
