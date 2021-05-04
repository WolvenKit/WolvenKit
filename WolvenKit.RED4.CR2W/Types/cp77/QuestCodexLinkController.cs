using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestCodexLinkController : BaseCodexLinkController
	{
		private inkWidgetReference _linkLabelContainer;
		private CHandle<gameJournalEntry> _journalEntry;

		[Ordinal(5)] 
		[RED("linkLabelContainer")] 
		public inkWidgetReference LinkLabelContainer
		{
			get => GetProperty(ref _linkLabelContainer);
			set => SetProperty(ref _linkLabelContainer, value);
		}

		[Ordinal(6)] 
		[RED("journalEntry")] 
		public CHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		public QuestCodexLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
