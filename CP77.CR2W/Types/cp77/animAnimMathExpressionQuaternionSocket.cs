using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionQuaternionSocket : CVariable
	{
		[Ordinal(0)]  [RED("expressionVarId")] public CUInt16 ExpressionVarId { get; set; }
		[Ordinal(1)]  [RED("link")] public animQuaternionLink Link { get; set; }

		public animAnimMathExpressionQuaternionSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
