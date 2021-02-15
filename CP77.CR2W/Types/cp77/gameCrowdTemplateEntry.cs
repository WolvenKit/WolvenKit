using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateEntry : CVariable
	{
		[Ordinal(0)] [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(1)] [RED("markings")] public CArray<CName> Markings { get; set; }
		[Ordinal(2)] [RED("phases")] public CArray<gameCrowdTemplateEntryPhase> Phases { get; set; }
		[Ordinal(3)] [RED("type")] public CEnum<gameCrowdEntryType> Type { get; set; }

		public gameCrowdTemplateEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
