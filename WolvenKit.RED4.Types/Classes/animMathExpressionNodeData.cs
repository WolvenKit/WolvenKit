using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animMathExpressionNodeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("expression")] 
		public CHandle<mathExprExpression> Expression
		{
			get => GetPropertyValue<CHandle<mathExprExpression>>();
			set => SetPropertyValue<CHandle<mathExprExpression>>(value);
		}

		[Ordinal(1)] 
		[RED("floatSockets")] 
		public CArray<animAnimMathExpressionFloatSocket> FloatSockets
		{
			get => GetPropertyValue<CArray<animAnimMathExpressionFloatSocket>>();
			set => SetPropertyValue<CArray<animAnimMathExpressionFloatSocket>>(value);
		}

		[Ordinal(2)] 
		[RED("vectorSockets")] 
		public CArray<animAnimMathExpressionVectorSocket> VectorSockets
		{
			get => GetPropertyValue<CArray<animAnimMathExpressionVectorSocket>>();
			set => SetPropertyValue<CArray<animAnimMathExpressionVectorSocket>>(value);
		}

		[Ordinal(3)] 
		[RED("quaternionSockets")] 
		public CArray<animAnimMathExpressionQuaternionSocket> QuaternionSockets
		{
			get => GetPropertyValue<CArray<animAnimMathExpressionQuaternionSocket>>();
			set => SetPropertyValue<CArray<animAnimMathExpressionQuaternionSocket>>(value);
		}

		public animMathExpressionNodeData()
		{
			FloatSockets = new();
			VectorSockets = new();
			QuaternionSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
