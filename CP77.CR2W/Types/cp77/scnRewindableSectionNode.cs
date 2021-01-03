using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
