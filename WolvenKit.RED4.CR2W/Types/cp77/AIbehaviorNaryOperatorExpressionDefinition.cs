using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNaryOperatorExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("operator")] public CEnum<AIbehaviorNaryExpressionOperators> Operator { get; set; }
		[Ordinal(1)] [RED("operands")] public CArray<CHandle<AIbehaviorExpressionSocket>> Operands { get; set; }

		public AIbehaviorNaryOperatorExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
