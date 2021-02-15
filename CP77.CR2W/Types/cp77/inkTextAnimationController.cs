using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("playOnInitialize")] public CBool PlayOnInitialize { get; set; }
		[Ordinal(2)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(3)] [RED("useDefaultAnimation")] public CBool UseDefaultAnimation { get; set; }
		[Ordinal(4)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(5)] [RED("startDelay")] public CFloat StartDelay { get; set; }
		[Ordinal(6)] [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(7)] [RED("endValue")] public CFloat EndValue { get; set; }

		public inkTextAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
