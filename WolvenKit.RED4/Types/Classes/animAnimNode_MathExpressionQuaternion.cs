using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MathExpressionQuaternion : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetPropertyValue<animMathExpressionNodeData>();
			set => SetPropertyValue<animMathExpressionNodeData>(value);
		}

		public animAnimNode_MathExpressionQuaternion()
		{
			Id = uint.MaxValue;
			ExpressionData = new animMathExpressionNodeData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
