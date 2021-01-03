using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_AnimationData : CVariable
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
		[Ordinal(2)]  [RED("streamingContext")] public CName StreamingContext { get; set; }

		public animGenericAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
