using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputLinks")] public CArray<animFloatLink> InputLinks { get; set; }
		[Ordinal(12)] [RED("blendSpace")] public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace { get; set; }
		[Ordinal(13)] [RED("progressLink")] public animFloatLink ProgressLink { get; set; }
		[Ordinal(14)] [RED("fireAnimEndEvent")] public CBool FireAnimEndEvent { get; set; }
		[Ordinal(15)] [RED("animEndEventName")] public CName AnimEndEventName { get; set; }
		[Ordinal(16)] [RED("isLooped")] public CBool IsLooped { get; set; }

		public animAnimNode_BlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
