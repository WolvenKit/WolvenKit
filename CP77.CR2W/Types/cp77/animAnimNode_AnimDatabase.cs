using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AnimDatabase : animAnimNode_SkPhaseWithDurationAnim
	{
		[Ordinal(20)] [RED("animDataBase")] public animAnimDatabaseCollectionEntry AnimDataBase { get; set; }
		[Ordinal(21)] [RED("inputLinks")] public CArray<animIntLink> InputLinks { get; set; }

		public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
