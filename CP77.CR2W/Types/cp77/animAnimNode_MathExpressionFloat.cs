using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionFloat : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }

		public animAnimNode_MathExpressionFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
