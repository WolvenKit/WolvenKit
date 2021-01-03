using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("clamp")] public CBool Clamp { get; set; }
		[Ordinal(1)]  [RED("curValue")] public animFloatLink CurValue { get; set; }
		[Ordinal(2)]  [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(3)]  [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(4)]  [RED("maxValue")] public animFloatLink MaxValue { get; set; }
		[Ordinal(5)]  [RED("minValue")] public animFloatLink MinValue { get; set; }
		[Ordinal(6)]  [RED("normalize180")] public CBool Normalize180 { get; set; }
		[Ordinal(7)]  [RED("normalize180Input")] public animBoolLink Normalize180Input { get; set; }
		[Ordinal(8)]  [RED("override")] public animBoolLink Override { get; set; }
		[Ordinal(9)]  [RED("resetExternalEventName")] public CName ResetExternalEventName { get; set; }
		[Ordinal(10)]  [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(11)]  [RED("resetSpeed")] public animFloatLink ResetSpeed { get; set; }

		public animAnimNode_FloatCumulative(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
