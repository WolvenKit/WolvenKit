using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animMathExpressionNodeData : CVariable
	{
		[Ordinal(0)]  [RED("expression")] public CHandle<mathExprExpression> Expression { get; set; }
		[Ordinal(1)]  [RED("floatSockets")] public CArray<animAnimMathExpressionFloatSocket> FloatSockets { get; set; }
		[Ordinal(2)]  [RED("quaternionSockets")] public CArray<animAnimMathExpressionQuaternionSocket> QuaternionSockets { get; set; }
		[Ordinal(3)]  [RED("vectorSockets")] public CArray<animAnimMathExpressionVectorSocket> VectorSockets { get; set; }

		public animMathExpressionNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
