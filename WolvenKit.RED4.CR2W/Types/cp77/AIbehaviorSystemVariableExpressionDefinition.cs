using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSystemVariableExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("variable")] public CEnum<AIbehaviorSystemVariableExpressionTypes> Variable { get; set; }

		public AIbehaviorSystemVariableExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
