using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
		private inkTextWidgetReference _messageText;
		private inkImageWidgetReference _avatar;
		private inkTextWidgetReference _descriptionText;
		private inkImageWidgetReference _mappinIcon;
		private inkWidgetReference _envelopIcon;
		private CHandle<gameIBlackboard> _interactionsBlackboard;
		private CUInt32 _bbListenerId;
		private CHandle<gameuiPhoneMessageNotificationViewData> _messageData;
		private CHandle<inkanimProxy> _animProxy;
		private CInt32 _textSizeLimit;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;

		[Ordinal(12)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get
			{
				if (_messageText == null)
				{
					_messageText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "messageText", cr2w, this);
				}
				return _messageText;
			}
			set
			{
				if (_messageText == value)
				{
					return;
				}
				_messageText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("avatar")] 
		public inkImageWidgetReference Avatar
		{
			get
			{
				if (_avatar == null)
				{
					_avatar = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "avatar", cr2w, this);
				}
				return _avatar;
			}
			set
			{
				if (_avatar == value)
				{
					return;
				}
				_avatar = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("mappinIcon")] 
		public inkImageWidgetReference MappinIcon
		{
			get
			{
				if (_mappinIcon == null)
				{
					_mappinIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "mappinIcon", cr2w, this);
				}
				return _mappinIcon;
			}
			set
			{
				if (_mappinIcon == value)
				{
					return;
				}
				_mappinIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("envelopIcon")] 
		public inkWidgetReference EnvelopIcon
		{
			get
			{
				if (_envelopIcon == null)
				{
					_envelopIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "envelopIcon", cr2w, this);
				}
				return _envelopIcon;
			}
			set
			{
				if (_envelopIcon == value)
				{
					return;
				}
				_envelopIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("interactionsBlackboard")] 
		public CHandle<gameIBlackboard> InteractionsBlackboard
		{
			get
			{
				if (_interactionsBlackboard == null)
				{
					_interactionsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "interactionsBlackboard", cr2w, this);
				}
				return _interactionsBlackboard;
			}
			set
			{
				if (_interactionsBlackboard == value)
				{
					return;
				}
				_interactionsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bbListenerId")] 
		public CUInt32 BbListenerId
		{
			get
			{
				if (_bbListenerId == null)
				{
					_bbListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbListenerId", cr2w, this);
				}
				return _bbListenerId;
			}
			set
			{
				if (_bbListenerId == value)
				{
					return;
				}
				_bbListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("messageData")] 
		public CHandle<gameuiPhoneMessageNotificationViewData> MessageData
		{
			get
			{
				if (_messageData == null)
				{
					_messageData = (CHandle<gameuiPhoneMessageNotificationViewData>) CR2WTypeManager.Create("handle:gameuiPhoneMessageNotificationViewData", "messageData", cr2w, this);
				}
				return _messageData;
			}
			set
			{
				if (_messageData == value)
				{
					return;
				}
				_messageData = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("textSizeLimit")] 
		public CInt32 TextSizeLimit
		{
			get
			{
				if (_textSizeLimit == null)
				{
					_textSizeLimit = (CInt32) CR2WTypeManager.Create("Int32", "textSizeLimit", cr2w, this);
				}
				return _textSizeLimit;
			}
			set
			{
				if (_textSizeLimit == value)
				{
					return;
				}
				_textSizeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get
			{
				if (_mappinSystem == null)
				{
					_mappinSystem = (wCHandle<gamemappinsMappinSystem>) CR2WTypeManager.Create("whandle:gamemappinsMappinSystem", "mappinSystem", cr2w, this);
				}
				return _mappinSystem;
			}
			set
			{
				if (_mappinSystem == value)
				{
					return;
				}
				_mappinSystem = value;
				PropertySet(this);
			}
		}

		public MessengerNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
