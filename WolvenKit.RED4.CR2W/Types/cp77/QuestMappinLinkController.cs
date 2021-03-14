using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMappinLinkController : BaseCodexLinkController
	{
		private CHandle<gameJournalQuestMapPinBase> _mappinEntry;
		private Vector3 _jumpTo;

		[Ordinal(4)] 
		[RED("mappinEntry")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntry
		{
			get
			{
				if (_mappinEntry == null)
				{
					_mappinEntry = (CHandle<gameJournalQuestMapPinBase>) CR2WTypeManager.Create("handle:gameJournalQuestMapPinBase", "mappinEntry", cr2w, this);
				}
				return _mappinEntry;
			}
			set
			{
				if (_mappinEntry == value)
				{
					return;
				}
				_mappinEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get
			{
				if (_jumpTo == null)
				{
					_jumpTo = (Vector3) CR2WTypeManager.Create("Vector3", "jumpTo", cr2w, this);
				}
				return _jumpTo;
			}
			set
			{
				if (_jumpTo == value)
				{
					return;
				}
				_jumpTo = value;
				PropertySet(this);
			}
		}

		public QuestMappinLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
