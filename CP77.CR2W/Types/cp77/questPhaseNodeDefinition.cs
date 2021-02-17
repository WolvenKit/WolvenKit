using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhaseNodeDefinition : questEmbeddedGraphNodeDefinition
	{
		[Ordinal(2)] [RED("saveLock")] public CBool SaveLock { get; set; }
		[Ordinal(3)] [RED("phaseResource")] public raRef<questQuestPhaseResource> PhaseResource { get; set; }
		[Ordinal(4)] [RED("unfreezingTriggerNodeRef")] public NodeRef UnfreezingTriggerNodeRef { get; set; }
		[Ordinal(5)] [RED("phaseInstancePrefabs")] public CArray<questQuestPrefabEntry> PhaseInstancePrefabs { get; set; }
		[Ordinal(6)] [RED("phaseGraph")] public CHandle<questGraphDefinition> PhaseGraph { get; set; }

		public questPhaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
