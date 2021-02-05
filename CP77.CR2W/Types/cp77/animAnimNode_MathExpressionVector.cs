using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionVector : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }

        [Ordinal(999)] [RED("expressionString")] public CString expressionString { get; set; }

		public animAnimNode_MathExpressionVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
