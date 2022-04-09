using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class mathExprExpression : ISerializable
	{
		[Ordinal(0)] 
		[RED("tokenData")] 
		public CArray<CUInt32> TokenData
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("valuesData")] 
		public CArray<CFloat> ValuesData
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("returnVarType")] 
		public CUInt16 ReturnVarType
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public mathExprExpression()
		{
			TokenData = new();
			ValuesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
