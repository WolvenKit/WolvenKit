using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionEquipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		[Ordinal(1)] [RED("slotId")] public CHandle<AIArgumentMapping> SlotId { get; set; }
		[Ordinal(2)] [RED("itemId")] public CHandle<AIArgumentMapping> ItemId { get; set; }
		[Ordinal(3)] [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
		[Ordinal(4)] [RED("failIfItemNotFound")] public CHandle<AIArgumentMapping> FailIfItemNotFound { get; set; }
		[Ordinal(5)] [RED("spawnDelay")] public CHandle<AIArgumentMapping> SpawnDelay { get; set; }

		public AIbehaviorActionEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
