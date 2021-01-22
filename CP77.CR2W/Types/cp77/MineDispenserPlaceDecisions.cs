using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MineDispenserPlaceDecisions : MineDispenserTransition
	{
		[Ordinal(0)]  [RED("spawnNormal")] public Vector4 SpawnNormal { get; set; }
		[Ordinal(1)]  [RED("spawnPosition")] public Vector4 SpawnPosition { get; set; }

		public MineDispenserPlaceDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
