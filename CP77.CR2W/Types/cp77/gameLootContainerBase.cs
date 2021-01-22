using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		[Ordinal(0)]  [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }
		[Ordinal(1)]  [RED("contentAssignment")] public TweakDBID ContentAssignment { get; set; }
		[Ordinal(2)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(3)]  [RED("hasQuestItems")] public CBool HasQuestItems { get; set; }
		[Ordinal(4)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(5)]  [RED("isIllegal")] public CBool IsIllegal { get; set; }
		[Ordinal(6)]  [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(7)]  [RED("lootQuality")] public CEnum<gamedataQuality> LootQuality { get; set; }
		[Ordinal(8)]  [RED("lootTables")] public CArray<TweakDBID> LootTables { get; set; }
		[Ordinal(9)]  [RED("useAreaLoot")] public CBool UseAreaLoot { get; set; }
		[Ordinal(10)]  [RED("wasLootInitalized")] public CBool WasLootInitalized { get; set; }

		public gameLootContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
