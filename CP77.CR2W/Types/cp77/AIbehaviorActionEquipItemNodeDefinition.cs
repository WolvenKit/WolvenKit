using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionEquipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		[Ordinal(0)]  [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
		[Ordinal(1)]  [RED("failIfItemNotFound")] public CHandle<AIArgumentMapping> FailIfItemNotFound { get; set; }
		[Ordinal(2)]  [RED("itemId")] public CHandle<AIArgumentMapping> ItemId { get; set; }
		[Ordinal(3)]  [RED("slotId")] public CHandle<AIArgumentMapping> SlotId { get; set; }
		[Ordinal(4)]  [RED("spawnDelay")] public CHandle<AIArgumentMapping> SpawnDelay { get; set; }

		public AIbehaviorActionEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
