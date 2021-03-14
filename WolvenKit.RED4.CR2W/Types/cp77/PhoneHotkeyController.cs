using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _mainIcon;
		private inkTextWidgetReference _messagePrompt;
		private inkTextWidgetReference _messageCounter;
		private wCHandle<gameJournalManager> _journalManager;
		private CString _phoneIconAtlas;
		private CName _phoneIconName;

		[Ordinal(19)] 
		[RED("mainIcon")] 
		public inkImageWidgetReference MainIcon
		{
			get
			{
				if (_mainIcon == null)
				{
					_mainIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "mainIcon", cr2w, this);
				}
				return _mainIcon;
			}
			set
			{
				if (_mainIcon == value)
				{
					return;
				}
				_mainIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("messagePrompt")] 
		public inkTextWidgetReference MessagePrompt
		{
			get
			{
				if (_messagePrompt == null)
				{
					_messagePrompt = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "messagePrompt", cr2w, this);
				}
				return _messagePrompt;
			}
			set
			{
				if (_messagePrompt == value)
				{
					return;
				}
				_messagePrompt = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get
			{
				if (_messageCounter == null)
				{
					_messageCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "messageCounter", cr2w, this);
				}
				return _messageCounter;
			}
			set
			{
				if (_messageCounter == value)
				{
					return;
				}
				_messageCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("phoneIconAtlas")] 
		public CString PhoneIconAtlas
		{
			get
			{
				if (_phoneIconAtlas == null)
				{
					_phoneIconAtlas = (CString) CR2WTypeManager.Create("String", "phoneIconAtlas", cr2w, this);
				}
				return _phoneIconAtlas;
			}
			set
			{
				if (_phoneIconAtlas == value)
				{
					return;
				}
				_phoneIconAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("phoneIconName")] 
		public CName PhoneIconName
		{
			get
			{
				if (_phoneIconName == null)
				{
					_phoneIconName = (CName) CR2WTypeManager.Create("CName", "phoneIconName", cr2w, this);
				}
				return _phoneIconName;
			}
			set
			{
				if (_phoneIconName == value)
				{
					return;
				}
				_phoneIconName = value;
				PropertySet(this);
			}
		}

		public PhoneHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
