using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalTarot : gameJournalEntry
	{
		[Ordinal(0)]  [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(1)]  [RED("imagePart")] public CName ImagePart { get; set; }
		[Ordinal(2)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(3)]  [RED("name")] public LocalizationString Name { get; set; }

		public gameJournalTarot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
