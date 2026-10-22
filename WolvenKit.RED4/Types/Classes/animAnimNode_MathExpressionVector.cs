using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MathExpressionVector : animAnimNode_VectorValue
	{
		[Ordinal(1)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetPropertyValue<animMathExpressionNodeData>();
			set => SetPropertyValue<animMathExpressionNodeData>(value);
		}

		public animAnimNode_MathExpressionVector()
		{
			Id = uint.MaxValue;
			ExpressionData = new animMathExpressionNodeData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
