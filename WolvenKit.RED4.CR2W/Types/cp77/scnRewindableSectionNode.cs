using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRewindableSectionNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
		[Ordinal(4)] [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }
		[Ordinal(5)] [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
		[Ordinal(6)] [RED("playSpeedModifiers")] public scnRewindableSectionPlaySpeedModifiers PlaySpeedModifiers { get; set; }

		public scnRewindableSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
