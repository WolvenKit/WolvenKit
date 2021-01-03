using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendParticleBurst : CVariable
	{
		[Ordinal(0)]  [RED("burstTime")] public CFloat BurstTime { get; set; }
		[Ordinal(1)]  [RED("repeatTime")] public CFloat RepeatTime { get; set; }
		[Ordinal(2)]  [RED("spawnCount")] public CUInt32 SpawnCount { get; set; }
		[Ordinal(3)]  [RED("spawnTimeRange")] public CFloat SpawnTimeRange { get; set; }

		public rendParticleBurst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
