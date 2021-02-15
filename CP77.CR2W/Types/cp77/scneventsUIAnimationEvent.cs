using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsUIAnimationEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(7)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(8)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public scneventsUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
