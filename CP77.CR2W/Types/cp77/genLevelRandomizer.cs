using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class genLevelRandomizer : gameObject
	{
		[Ordinal(0)]  [RED("dataSource")] public CEnum<genLevelRandomizerDataSource> DataSource { get; set; }
		[Ordinal(1)]  [RED("debugSpawnAll")] public CBool DebugSpawnAll { get; set; }
		[Ordinal(2)]  [RED("entries")] public CArray<genLevelRandomizerEntry> Entries { get; set; }
		[Ordinal(3)]  [RED("seed")] public CUInt32 Seed { get; set; }
		[Ordinal(4)]  [RED("supervisorType")] public CName SupervisorType { get; set; }

		public genLevelRandomizer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
