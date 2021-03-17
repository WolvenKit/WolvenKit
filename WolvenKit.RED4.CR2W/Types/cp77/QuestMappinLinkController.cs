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
			get => GetProperty(ref _mappinEntry);
			set => SetProperty(ref _mappinEntry, value);
		}

		[Ordinal(5)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get => GetProperty(ref _jumpTo);
			set => SetProperty(ref _jumpTo, value);
		}

		public QuestMappinLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
