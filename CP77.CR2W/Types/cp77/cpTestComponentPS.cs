using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpTestComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("something")] public CInt32 Something { get; set; }
		[Ordinal(1)] [RED("somethingNotInstanceEdiable")] public CBool SomethingNotInstanceEdiable { get; set; }
		[Ordinal(2)] [RED("nameEditable")] public CName NameEditable { get; set; }
		[Ordinal(3)] [RED("nameInstanceEditable")] public CName NameInstanceEditable { get; set; }
		[Ordinal(4)] [RED("namePersistent")] public CName NamePersistent { get; set; }
		[Ordinal(5)] [RED("namePersistentEdiable")] public CName NamePersistentEdiable { get; set; }
		[Ordinal(6)] [RED("namePersistentInstanceEditable")] public CName NamePersistentInstanceEditable { get; set; }

		public cpTestComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
