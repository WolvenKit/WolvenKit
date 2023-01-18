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
			Min = -340282346638528859811704183484516925440.000000F;
			Max = 340282346638528859811704183484516925440.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
