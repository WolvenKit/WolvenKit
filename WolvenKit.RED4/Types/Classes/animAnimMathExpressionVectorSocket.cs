using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimMathExpressionVectorSocket : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("link")] 
		public animVectorLink Link
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animAnimMathExpressionVectorSocket()
		{
			Link = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
