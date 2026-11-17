using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MathExpressionFloat : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetPropertyValue<animMathExpressionNodeData>();
			set => SetPropertyValue<animMathExpressionNodeData>(value);
		}

		public animAnimNode_MathExpressionFloat()
		{
			Id = uint.MaxValue;
			ExpressionData = new animMathExpressionNodeData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
