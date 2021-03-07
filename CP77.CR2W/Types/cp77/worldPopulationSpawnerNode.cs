using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPopulationSpawnerNode : worldNode
	{
		[Ordinal(4)] [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }
		[Ordinal(5)] [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(6)] [RED("spawnOnStart")] public CBool SpawnOnStart { get; set; }
		[Ordinal(7)] [RED("alwaysSpawned")] public CEnum<gameAlwaysSpawnedState> AlwaysSpawned { get; set; }
		[Ordinal(8)] [RED("spawnInView")] public CEnum<gameSpawnInViewState> SpawnInView { get; set; }
		[Ordinal(9)] [RED("prefetchAppearance")] public CBool PrefetchAppearance { get; set; }

		public worldPopulationSpawnerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
