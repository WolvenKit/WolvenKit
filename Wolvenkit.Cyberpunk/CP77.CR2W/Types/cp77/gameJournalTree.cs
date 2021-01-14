using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalTree : ISerializable
	{
		[Ordinal(0)]  [RED("rootEntries")] public CArray<CHandle<gameJournalRootFolderEntry>> RootEntries { get; set; }

		public gameJournalTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
