using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsUIAnimationBraindanceEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }

		public scneventsUIAnimationBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
