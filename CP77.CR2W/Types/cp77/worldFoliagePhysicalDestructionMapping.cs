using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		[Ordinal(3)] [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(4)] [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }
		[Ordinal(5)] [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }

		public worldFoliagePhysicalDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
