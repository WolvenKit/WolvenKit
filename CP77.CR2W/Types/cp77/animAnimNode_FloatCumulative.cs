using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("clamp")] public CBool Clamp { get; set; }
		[Ordinal(2)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(3)] [RED("normalize180")] public CBool Normalize180 { get; set; }
		[Ordinal(4)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(5)] [RED("resetExternalEventName")] public CName ResetExternalEventName { get; set; }
		[Ordinal(6)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(7)] [RED("minValue")] public animFloatLink MinValue { get; set; }
		[Ordinal(8)] [RED("maxValue")] public animFloatLink MaxValue { get; set; }
		[Ordinal(9)] [RED("resetSpeed")] public animFloatLink ResetSpeed { get; set; }
		[Ordinal(10)] [RED("override")] public animBoolLink Override { get; set; }
		[Ordinal(11)] [RED("curValue")] public animFloatLink CurValue { get; set; }
		[Ordinal(12)] [RED("normalize180Input")] public animBoolLink Normalize180Input { get; set; }

		public animAnimNode_FloatCumulative(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
