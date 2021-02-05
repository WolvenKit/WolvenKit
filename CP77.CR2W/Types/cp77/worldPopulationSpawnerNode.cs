using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPopulationSpawnerNode : worldNode
	{
		[Ordinal(0)]  [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }
		[Ordinal(1)]  [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(2)]  [RED("spawnOnStart")] public CBool SpawnOnStart { get; set; }
		[Ordinal(3)]  [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }
		[Ordinal(4)]  [RED("spawnInView")] public CEnum<gameSpawnInViewState> SpawnInView { get; set; }
		[Ordinal(5)]  [RED("prefetchAppearance")] public CBool PrefetchAppearance { get; set; }

		public worldPopulationSpawnerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
