using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_AnimationData : CVariable
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)] [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(2)] [RED("streamingContext")] public CName StreamingContext { get; set; }

		public animGenericAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
