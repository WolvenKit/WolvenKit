using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TonemappingModeLottes : ITonemappingMode
	{
		[Ordinal(1)] 
		[RED("maxInput")] 
		public CFloat MaxInput
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("midIn")] 
		public CFloat MidIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("midOut")] 
		public CFloat MidOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("crosstalk")] 
		public Vector3 Crosstalk
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("crosstalkSaturation")] 
		public Vector3 CrosstalkSaturation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public TonemappingModeLottes()
		{
			MaxInput = 50.000000F;
			Contrast = 1.500000F;
			MidIn = 0.180000F;
			MidOut = 0.180000F;
			Crosstalk = new Vector3 { X = 2.000000F, Y = 2.000000F, Z = 2.000000F };
			CrosstalkSaturation = new Vector3 { X = 1.000000F, Y = 2.000000F, Z = 20.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
