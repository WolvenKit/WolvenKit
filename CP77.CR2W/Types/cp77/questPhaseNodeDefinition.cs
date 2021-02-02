using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPhaseNodeDefinition : questEmbeddedGraphNodeDefinition
	{
		[Ordinal(0)]  [RED("phaseGraph")] public CHandle<questGraphDefinition> PhaseGraph { get; set; }
		[Ordinal(1)]  [RED("phaseInstancePrefabs")] public CArray<questQuestPrefabEntry> PhaseInstancePrefabs { get; set; }
		[Ordinal(2)]  [RED("unfreezingTriggerNodeRef")] public NodeRef UnfreezingTriggerNodeRef { get; set; }
		[Ordinal(3)]  [RED("phaseResource")] public raRef<questQuestPhaseResource> PhaseResource { get; set; }
		[Ordinal(4)]  [RED("saveLock")] public CBool SaveLock { get; set; }

		public questPhaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
