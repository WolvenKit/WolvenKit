using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrowserGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _logicControllerRef;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<CName> _locationTags;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("locationTags")] 
		public CArray<CName> LocationTags
		{
			get
			{
				if (_locationTags == null)
				{
					_locationTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "locationTags", cr2w, this);
				}
				return _locationTags;
			}
			set
			{
				if (_locationTags == value)
				{
					return;
				}
				_locationTags = value;
				PropertySet(this);
			}
		}

		public BrowserGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
