using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("operationType")] public CEnum<animEAnimGraphMathOp> OperationType { get; set; }
		[Ordinal(12)] [RED("firstInputNode")] public animFloatLink FirstInputNode { get; set; }
		[Ordinal(13)] [RED("secondInputNode")] public animFloatLink SecondInputNode { get; set; }

		public animAnimNode_FloatMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
