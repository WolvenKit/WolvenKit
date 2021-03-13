using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimMathExpressionVectorSocket : CVariable
	{
		[Ordinal(0)] [RED("link")] public animVectorLink Link { get; set; }
		[Ordinal(1)] [RED("expressionVarId")] public CUInt16 ExpressionVarId { get; set; }

		public animAnimMathExpressionVectorSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
