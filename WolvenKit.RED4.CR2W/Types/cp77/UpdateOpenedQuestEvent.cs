using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateOpenedQuestEvent : redEvent
	{
		private wCHandle<gameJournalQuest> _openedQuest;

		[Ordinal(0)] 
		[RED("openedQuest")] 
		public wCHandle<gameJournalQuest> OpenedQuest
		{
			get
			{
				if (_openedQuest == null)
				{
					_openedQuest = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "openedQuest", cr2w, this);
				}
				return _openedQuest;
			}
			set
			{
				if (_openedQuest == value)
				{
					return;
				}
				_openedQuest = value;
				PropertySet(this);
			}
		}

		public UpdateOpenedQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
