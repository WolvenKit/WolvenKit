using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _content;
		private inkTextWidgetReference _title;
		private inkImageWidgetReference _avatarImage;
		private inkWidgetReference _menuBackgrouns;
		private inkWidgetReference _hintTrack;
		private inkWidgetReference _hintClose;
		private inkWidgetReference _hintReply;
		private inkWidgetReference _hintMessenger;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_ComDeviceDef> _blackboardDef;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameObject> _player;
		private wCHandle<gameJournalManager> _journalMgr;
		private CHandle<JournalNotificationData> _data;
		private wCHandle<gameJournalPhoneMessage> _entry;
		private wCHandle<gameJournalContact> _contactEntry;
		private wCHandle<gameJournalEntry> _attachment;
		private CUInt32 _attachmentHash;
		private wCHandle<gameJournalEntry> _activeEntry;
		private wCHandle<MessengerDialogViewController> _dialogViewController;
		private CHandle<inkanimProxy> _proxy;

		[Ordinal(2)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get
			{
				if (_content == null)
				{
					_content = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get
			{
				if (_avatarImage == null)
				{
					_avatarImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "avatarImage", cr2w, this);
				}
				return _avatarImage;
			}
			set
			{
				if (_avatarImage == value)
				{
					return;
				}
				_avatarImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("menuBackgrouns")] 
		public inkWidgetReference MenuBackgrouns
		{
			get
			{
				if (_menuBackgrouns == null)
				{
					_menuBackgrouns = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuBackgrouns", cr2w, this);
				}
				return _menuBackgrouns;
			}
			set
			{
				if (_menuBackgrouns == value)
				{
					return;
				}
				_menuBackgrouns = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hintTrack")] 
		public inkWidgetReference HintTrack
		{
			get
			{
				if (_hintTrack == null)
				{
					_hintTrack = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintTrack", cr2w, this);
				}
				return _hintTrack;
			}
			set
			{
				if (_hintTrack == value)
				{
					return;
				}
				_hintTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hintClose")] 
		public inkWidgetReference HintClose
		{
			get
			{
				if (_hintClose == null)
				{
					_hintClose = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintClose", cr2w, this);
				}
				return _hintClose;
			}
			set
			{
				if (_hintClose == value)
				{
					return;
				}
				_hintClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hintReply")] 
		public inkWidgetReference HintReply
		{
			get
			{
				if (_hintReply == null)
				{
					_hintReply = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintReply", cr2w, this);
				}
				return _hintReply;
			}
			set
			{
				if (_hintReply == value)
				{
					return;
				}
				_hintReply = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get
			{
				if (_hintMessenger == null)
				{
					_hintMessenger = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintMessenger", cr2w, this);
				}
				return _hintMessenger;
			}
			set
			{
				if (_hintMessenger == value)
				{
					return;
				}
				_hintMessenger = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get
			{
				if (_blackboardDef == null)
				{
					_blackboardDef = (CHandle<UI_ComDeviceDef>) CR2WTypeManager.Create("handle:UI_ComDeviceDef", "blackboardDef", cr2w, this);
				}
				return _blackboardDef;
			}
			set
			{
				if (_blackboardDef == value)
				{
					return;
				}
				_blackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get
			{
				if (_uiSystem == null)
				{
					_uiSystem = (CHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("handle:gameuiGameSystemUI", "uiSystem", cr2w, this);
				}
				return _uiSystem;
			}
			set
			{
				if (_uiSystem == value)
				{
					return;
				}
				_uiSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<JournalNotificationData>) CR2WTypeManager.Create("handle:JournalNotificationData", "data", cr2w, this);
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

		[Ordinal(16)] 
		[RED("entry")] 
		public wCHandle<gameJournalPhoneMessage> Entry
		{
			get
			{
				if (_entry == null)
				{
					_entry = (wCHandle<gameJournalPhoneMessage>) CR2WTypeManager.Create("whandle:gameJournalPhoneMessage", "entry", cr2w, this);
				}
				return _entry;
			}
			set
			{
				if (_entry == value)
				{
					return;
				}
				_entry = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("contactEntry")] 
		public wCHandle<gameJournalContact> ContactEntry
		{
			get
			{
				if (_contactEntry == null)
				{
					_contactEntry = (wCHandle<gameJournalContact>) CR2WTypeManager.Create("whandle:gameJournalContact", "contactEntry", cr2w, this);
				}
				return _contactEntry;
			}
			set
			{
				if (_contactEntry == value)
				{
					return;
				}
				_contactEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("attachment")] 
		public wCHandle<gameJournalEntry> Attachment
		{
			get
			{
				if (_attachment == null)
				{
					_attachment = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "attachment", cr2w, this);
				}
				return _attachment;
			}
			set
			{
				if (_attachment == value)
				{
					return;
				}
				_attachment = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("attachmentHash")] 
		public CUInt32 AttachmentHash
		{
			get
			{
				if (_attachmentHash == null)
				{
					_attachmentHash = (CUInt32) CR2WTypeManager.Create("Uint32", "attachmentHash", cr2w, this);
				}
				return _attachmentHash;
			}
			set
			{
				if (_attachmentHash == value)
				{
					return;
				}
				_attachmentHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("activeEntry")] 
		public wCHandle<gameJournalEntry> ActiveEntry
		{
			get
			{
				if (_activeEntry == null)
				{
					_activeEntry = (wCHandle<gameJournalEntry>) CR2WTypeManager.Create("whandle:gameJournalEntry", "activeEntry", cr2w, this);
				}
				return _activeEntry;
			}
			set
			{
				if (_activeEntry == value)
				{
					return;
				}
				_activeEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("dialogViewController")] 
		public wCHandle<MessengerDialogViewController> DialogViewController
		{
			get
			{
				if (_dialogViewController == null)
				{
					_dialogViewController = (wCHandle<MessengerDialogViewController>) CR2WTypeManager.Create("whandle:MessengerDialogViewController", "dialogViewController", cr2w, this);
				}
				return _dialogViewController;
			}
			set
			{
				if (_dialogViewController == value)
				{
					return;
				}
				_dialogViewController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get
			{
				if (_proxy == null)
				{
					_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "proxy", cr2w, this);
				}
				return _proxy;
			}
			set
			{
				if (_proxy == value)
				{
					return;
				}
				_proxy = value;
				PropertySet(this);
			}
		}

		public PhoneMessagePopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
