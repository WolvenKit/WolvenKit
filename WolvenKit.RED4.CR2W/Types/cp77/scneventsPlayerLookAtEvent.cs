using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayerLookAtEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(7)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(8)] [RED("lookAtParams")] public scneventsPlayerLookAtEventParams LookAtParams { get; set; }

		public scneventsPlayerLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
