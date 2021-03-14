using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BriefingScreen : gameuiHUDGameController
	{
		private inkWidgetReference _logicControllerRef;
		private wCHandle<gameJournalManager> _journalManager;
		private CUInt32 _bbOpenerEventID;
		private CUInt32 _bbSizeEventID;
		private CUInt32 _bbAlignmentEventID;

		[Ordinal(9)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get
			{
				if (_logicControllerRef == null)
				{
					_logicControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "logicControllerRef", cr2w, this);
				}
				return _logicControllerRef;
			}
			set
			{
				if (_logicControllerRef == value)
				{
					return;
				}
				_logicControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("bbOpenerEventID")] 
		public CUInt32 BbOpenerEventID
		{
			get
			{
				if (_bbOpenerEventID == null)
				{
					_bbOpenerEventID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbOpenerEventID", cr2w, this);
				}
				return _bbOpenerEventID;
			}
			set
			{
				if (_bbOpenerEventID == value)
				{
					return;
				}
				_bbOpenerEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bbSizeEventID")] 
		public CUInt32 BbSizeEventID
		{
			get
			{
				if (_bbSizeEventID == null)
				{
					_bbSizeEventID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbSizeEventID", cr2w, this);
				}
				return _bbSizeEventID;
			}
			set
			{
				if (_bbSizeEventID == value)
				{
					return;
				}
				_bbSizeEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbAlignmentEventID")] 
		public CUInt32 BbAlignmentEventID
		{
			get
			{
				if (_bbAlignmentEventID == null)
				{
					_bbAlignmentEventID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbAlignmentEventID", cr2w, this);
				}
				return _bbAlignmentEventID;
			}
			set
			{
				if (_bbAlignmentEventID == value)
				{
					return;
				}
				_bbAlignmentEventID = value;
				PropertySet(this);
			}
		}

		public BriefingScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
