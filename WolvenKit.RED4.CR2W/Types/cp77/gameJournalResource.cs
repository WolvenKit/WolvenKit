using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalResource : gameJournalBaseResource
	{
		private CHandle<gameJournalEntry> _entry;

		[Ordinal(1)] 
		[RED("entry")] 
		public CHandle<gameJournalEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		public gameJournalResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
