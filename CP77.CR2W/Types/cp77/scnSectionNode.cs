using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSectionNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
		[Ordinal(4)] [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }
		[Ordinal(5)] [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
		[Ordinal(6)] [RED("isFocusClue")] public CBool IsFocusClue { get; set; }

		public scnSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
