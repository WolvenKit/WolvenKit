using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSquadMemberComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("entries")] public CArray<gameSquadMemberDataEntry> Entries { get; set; }

		public gameSquadMemberComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
