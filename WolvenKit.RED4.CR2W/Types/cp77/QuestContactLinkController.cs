using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestContactLinkController : BaseCodexLinkController
	{
		private inkTextWidgetReference _msgLabel;
		private inkWidgetReference _msgContainer;
		private CInt32 _msgCounter;
		private CHandle<gameJournalContact> _contactEntry;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<PhoneSystem> _phoneSystem;

		[Ordinal(4)] 
		[RED("msgLabel")] 
		public inkTextWidgetReference MsgLabel
		{
			get
			{
				if (_msgLabel == null)
				{
					_msgLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "msgLabel", cr2w, this);
				}
				return _msgLabel;
			}
			set
			{
				if (_msgLabel == value)
				{
					return;
				}
				_msgLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("msgContainer")] 
		public inkWidgetReference MsgContainer
		{
			get
			{
				if (_msgContainer == null)
				{
					_msgContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "msgContainer", cr2w, this);
				}
				return _msgContainer;
			}
			set
			{
				if (_msgContainer == value)
				{
					return;
				}
				_msgContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("msgCounter")] 
		public CInt32 MsgCounter
		{
			get
			{
				if (_msgCounter == null)
				{
					_msgCounter = (CInt32) CR2WTypeManager.Create("Int32", "msgCounter", cr2w, this);
				}
				return _msgCounter;
			}
			set
			{
				if (_msgCounter == value)
				{
					return;
				}
				_msgCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get
			{
				if (_contactEntry == null)
				{
					_contactEntry = (CHandle<gameJournalContact>) CR2WTypeManager.Create("handle:gameJournalContact", "contactEntry", cr2w, this);
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get
			{
				if (_phoneSystem == null)
				{
					_phoneSystem = (wCHandle<PhoneSystem>) CR2WTypeManager.Create("whandle:PhoneSystem", "phoneSystem", cr2w, this);
				}
				return _phoneSystem;
			}
			set
			{
				if (_phoneSystem == value)
				{
					return;
				}
				_phoneSystem = value;
				PropertySet(this);
			}
		}

		public QuestContactLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
