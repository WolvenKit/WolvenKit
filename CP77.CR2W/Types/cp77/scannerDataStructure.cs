using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scannerDataStructure : CVariable
	{
		[Ordinal(0)]  [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(1)]  [RED("entityName")] public CString EntityName { get; set; }
		[Ordinal(2)]  [RED("questEntries")] public CArray<scannerQuestEntry> QuestEntries { get; set; }
		[Ordinal(3)]  [RED("quickHackDesc")] public CString QuickHackDesc { get; set; }
		[Ordinal(4)]  [RED("quickHackName")] public CString QuickHackName { get; set; }

		public scannerDataStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
