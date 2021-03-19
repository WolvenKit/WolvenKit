using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestCodexLinkController : BaseCodexLinkController
	{
		private CHandle<gameJournalCodexEntry> _codexEntry;

		[Ordinal(4)] 
		[RED("codexEntry")] 
		public CHandle<gameJournalCodexEntry> CodexEntry
		{
			get => GetProperty(ref _codexEntry);
			set => SetProperty(ref _codexEntry, value);
		}

		public QuestCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
