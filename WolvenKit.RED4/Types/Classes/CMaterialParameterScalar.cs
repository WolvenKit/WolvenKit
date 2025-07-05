using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterScalar : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("scalar")] 
		public CFloat Scalar
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CMaterialParameterScalar()
		{
			Min = float.MinValue;
			Max = float.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
