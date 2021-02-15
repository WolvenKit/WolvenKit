using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scannerQuestEntry : CVariable
	{
		[Ordinal(0)] [RED("categoryName")] public CName CategoryName { get; set; }
		[Ordinal(1)] [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(2)] [RED("recordID")] public TweakDBID RecordID { get; set; }

		public scannerQuestEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
