using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animMathExpressionNodeData : CVariable
	{
		[Ordinal(0)]  [RED("expression")] public CHandle<mathExprExpression> Expression { get; set; }
		[Ordinal(1)]  [RED("floatSockets")] public CArray<animAnimMathExpressionFloatSocket> FloatSockets { get; set; }
		[Ordinal(2)]  [RED("vectorSockets")] public CArray<animAnimMathExpressionVectorSocket> VectorSockets { get; set; }
		[Ordinal(3)]  [RED("quaternionSockets")] public CArray<animAnimMathExpressionQuaternionSocket> QuaternionSockets { get; set; }

		public animMathExpressionNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
