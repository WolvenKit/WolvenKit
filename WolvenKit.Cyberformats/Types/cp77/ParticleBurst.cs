using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ParticleBurst : CVariable
	{
		[Ordinal(0)] [RED("burstTime")] public CFloat BurstTime { get; set; }
		[Ordinal(1)] [RED("spawnCount")] public CUInt32 SpawnCount { get; set; }
		[Ordinal(2)] [RED("spawnTimeRange")] public CFloat SpawnTimeRange { get; set; }
		[Ordinal(3)] [RED("repeatTime")] public CFloat RepeatTime { get; set; }

		public ParticleBurst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
