using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestEntry_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _sendNotification;
		private CBool _trackQuest;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get
			{
				if (_sendNotification == null)
				{
					_sendNotification = (CBool) CR2WTypeManager.Create("Bool", "sendNotification", cr2w, this);
				}
				return _sendNotification;
			}
			set
			{
				if (_sendNotification == value)
				{
					return;
				}
				_sendNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackQuest")] 
		public CBool TrackQuest
		{
			get
			{
				if (_trackQuest == null)
				{
					_trackQuest = (CBool) CR2WTypeManager.Create("Bool", "trackQuest", cr2w, this);
				}
				return _trackQuest;
			}
			set
			{
				if (_trackQuest == value)
				{
					return;
				}
				_trackQuest = value;
				PropertySet(this);
			}
		}

		public questJournalQuestEntry_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
