using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalTarot : gameJournalEntry
	{
		[Ordinal(0)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)]  [RED("name")] public LocalizationString Name { get; set; }
		[Ordinal(2)]  [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(3)]  [RED("imagePart")] public CName ImagePart { get; set; }

		public gameJournalTarot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
