using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendHistogramBias : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mulCoef")] 
		public Vector3 MulCoef
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("addCoef")] 
		public Vector3 AddCoef
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public rendHistogramBias()
		{
			MulCoef = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			AddCoef = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
