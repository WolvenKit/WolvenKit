using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCommunityEntryInitialState : CVariable
	{
		[Ordinal(0)]  [RED("entryActiveOnStart")] public CBool EntryActiveOnStart { get; set; }
		[Ordinal(1)]  [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(2)]  [RED("initialPhaseName")] public CName InitialPhaseName { get; set; }

		public worldCommunityEntryInitialState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
