using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayerLookAtEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("lookAtParams")] public scneventsPlayerLookAtEventParams LookAtParams { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("performer")] public scnPerformerId Performer { get; set; }

		public scneventsPlayerLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
