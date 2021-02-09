using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		[Ordinal(31)]  [RED("useAreaLoot")] public CBool UseAreaLoot { get; set; }
		[Ordinal(32)]  [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }
		[Ordinal(33)]  [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }
		[Ordinal(34)]  [RED("isIllegal")] public CBool IsIllegal { get; set; }
		[Ordinal(35)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(36)]  [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(37)]  [RED("wasLootInitalized")] public CBool WasLootInitalized { get; set; }
		[Ordinal(38)]  [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(39)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(40)]  [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }

		public gameLootContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
