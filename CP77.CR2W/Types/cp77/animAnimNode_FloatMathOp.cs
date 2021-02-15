using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("operationType")] public CEnum<animEAnimGraphMathOp> OperationType { get; set; }
		[Ordinal(2)] [RED("firstInputNode")] public animFloatLink FirstInputNode { get; set; }
		[Ordinal(3)] [RED("secondInputNode")] public animFloatLink SecondInputNode { get; set; }

		public animAnimNode_FloatMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
