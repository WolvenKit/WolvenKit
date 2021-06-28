using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorComparisonExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _leftHandSide;
		private CEnum<EComparisonType> _operator;
		private CHandle<AIbehaviorExpressionSocket> _rightHandSide;

		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> LeftHandSide
		{
			get => GetProperty(ref _leftHandSide);
			set => SetProperty(ref _leftHandSide, value);
		}

		[Ordinal(1)] 
		[RED("operator")] 
		public CEnum<EComparisonType> Operator
		{
			get => GetProperty(ref _operator);
			set => SetProperty(ref _operator, value);
		}

		[Ordinal(2)] 
		[RED("rightHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> RightHandSide
		{
			get => GetProperty(ref _rightHandSide);
			set => SetProperty(ref _rightHandSide, value);
		}

		public AIbehaviorComparisonExpressionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
