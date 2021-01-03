using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalResource : gameJournalBaseResource
	{
		[Ordinal(0)]  [RED("entry")] public CHandle<gameJournalEntry> Entry { get; set; }

		public gameJournalResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
