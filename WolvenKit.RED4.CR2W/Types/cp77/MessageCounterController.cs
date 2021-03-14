using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageCounterController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _messageCounter;
		private wCHandle<inkWidget> _rootWidget;
		private CUInt32 _callInformationBBID;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameObject> _owner;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CallInformationBBID")] 
		public CUInt32 CallInformationBBID
		{
			get
			{
				if (_callInformationBBID == null)
				{
					_callInformationBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "CallInformationBBID", cr2w, this);
				}
				return _callInformationBBID;
			}
			set
			{
				if (_callInformationBBID == value)
				{
					return;
				}
				_callInformationBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "Owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public MessageCounterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
