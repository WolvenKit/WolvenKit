using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestUpdateUserData : inkGameNotificationData
	{
		private wCHandle<gameJournalQuest> _data;

		[Ordinal(6)] 
		[RED("data")] 
		public wCHandle<gameJournalQuest> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<gameJournalQuest>) CR2WTypeManager.Create("whandle:gameJournalQuest", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public QuestUpdateUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
