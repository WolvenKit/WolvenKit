using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnOpenCodexAtEntryEvent : redEvent
	{
		private wCHandle<gameJournalCodexEntry> _entry;

		[Ordinal(0)] 
		[RED("entry")] 
		public wCHandle<gameJournalCodexEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		public OnOpenCodexAtEntryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
