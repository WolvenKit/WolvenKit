using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		[Ordinal(40)] [RED("useAreaLoot")] public CBool UseAreaLoot { get; set; }
		[Ordinal(41)] [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }
		[Ordinal(42)] [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }
		[Ordinal(43)] [RED("isIllegal")] public CBool IsIllegal { get; set; }
		[Ordinal(44)] [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(45)] [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(46)] [RED("wasLootInitalized")] public CBool WasLootInitalized { get; set; }
		[Ordinal(47)] [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(48)] [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(49)] [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }

		public gameLootContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
