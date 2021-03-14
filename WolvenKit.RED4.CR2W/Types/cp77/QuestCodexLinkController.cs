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
			get
			{
				if (_codexEntry == null)
				{
					_codexEntry = (CHandle<gameJournalCodexEntry>) CR2WTypeManager.Create("handle:gameJournalCodexEntry", "codexEntry", cr2w, this);
				}
				return _codexEntry;
			}
			set
			{
				if (_codexEntry == value)
				{
					return;
				}
				_codexEntry = value;
				PropertySet(this);
			}
		}

		public QuestCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
