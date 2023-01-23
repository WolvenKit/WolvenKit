using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimMathExpressionQuaternionSocket : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("link")] 
		public animQuaternionLink Link
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animAnimMathExpressionQuaternionSocket()
		{
			Link = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
