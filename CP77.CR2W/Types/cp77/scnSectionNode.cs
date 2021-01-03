using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSectionNode : scnSceneGraphNode
	{
		[Ordinal(0)]  [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
		[Ordinal(1)]  [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
		[Ordinal(2)]  [RED("isFocusClue")] public CBool IsFocusClue { get; set; }
		[Ordinal(3)]  [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }

		public scnSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
