using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(3)] [RED("sceneLocation")] public scnWorldMarker SceneLocation { get; set; }
		[Ordinal(4)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
		[Ordinal(5)] [RED("syncToMusic")] public CBool SyncToMusic { get; set; }
		[Ordinal(6)] [RED("notAllowedToBeFrozen")] public CBool NotAllowedToBeFrozen { get; set; }
		[Ordinal(7)] [RED("reapplyInterruptionOperationsAfterGameLoad")] public CBool ReapplyInterruptionOperationsAfterGameLoad { get; set; }

		public questSceneNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
