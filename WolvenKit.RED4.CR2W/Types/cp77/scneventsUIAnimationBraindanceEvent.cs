using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUIAnimationBraindanceEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(7)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(8)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public scneventsUIAnimationBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
