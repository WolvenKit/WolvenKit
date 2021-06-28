using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNaryOperatorExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CEnum<AIbehaviorNaryExpressionOperators> _operator;
		private CArray<CHandle<AIbehaviorExpressionSocket>> _operands;

		[Ordinal(0)] 
		[RED("operator")] 
		public CEnum<AIbehaviorNaryExpressionOperators> Operator
		{
			get => GetProperty(ref _operator);
			set => SetProperty(ref _operator, value);
		}

		[Ordinal(1)] 
		[RED("operands")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> Operands
		{
			get => GetProperty(ref _operands);
			set => SetProperty(ref _operands, value);
		}

		public AIbehaviorNaryOperatorExpressionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
