using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("clamp")] public CBool Clamp { get; set; }
		[Ordinal(12)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(13)] [RED("normalize180")] public CBool Normalize180 { get; set; }
		[Ordinal(14)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(15)] [RED("resetExternalEventName")] public CName ResetExternalEventName { get; set; }
		[Ordinal(16)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(17)] [RED("minValue")] public animFloatLink MinValue { get; set; }
		[Ordinal(18)] [RED("maxValue")] public animFloatLink MaxValue { get; set; }
		[Ordinal(19)] [RED("resetSpeed")] public animFloatLink ResetSpeed { get; set; }
		[Ordinal(20)] [RED("override")] public animBoolLink Override { get; set; }
		[Ordinal(21)] [RED("curValue")] public animFloatLink CurValue { get; set; }
		[Ordinal(22)] [RED("normalize180Input")] public animBoolLink Normalize180Input { get; set; }

		public animAnimNode_FloatCumulative(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
