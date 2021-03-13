using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_AnimationData : CVariable
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)] [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(2)] [RED("inTransitionDuration")] public CFloat InTransitionDuration { get; set; }
		[Ordinal(3)] [RED("inCanRequestInertialization")] public CBool InCanRequestInertialization { get; set; }
		[Ordinal(4)] [RED("outTransitionDuration")] public CFloat OutTransitionDuration { get; set; }
		[Ordinal(5)] [RED("outCanRequestInertialization")] public CBool OutCanRequestInertialization { get; set; }
		[Ordinal(6)] [RED("streamingContext")] public CName StreamingContext { get; set; }

		public animActionAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
