using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		[Ordinal(0)]  [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(1)]  [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }
		[Ordinal(2)]  [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }

		public worldFoliagePhysicalDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
