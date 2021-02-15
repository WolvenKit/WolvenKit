using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpawnerData : CVariable
	{
		[Ordinal(0)] [RED("spawnerID")] public entEntityID SpawnerID { get; set; }
		[Ordinal(1)] [RED("entryNames")] public CArray<CName> EntryNames { get; set; }

		public SpawnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
