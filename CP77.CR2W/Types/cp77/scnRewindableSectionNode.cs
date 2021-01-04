using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRewindableSectionNode : scnSceneGraphNode
	{
		[Ordinal(0)]  [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
		[Ordinal(1)]  [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
		[Ordinal(2)]  [RED("playSpeedModifiers")] public scnRewindableSectionPlaySpeedModifiers PlaySpeedModifiers { get; set; }
		[Ordinal(3)]  [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }

		public scnRewindableSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
