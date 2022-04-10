using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TonemappingModeLottesACES : ITonemappingMode
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

		public TonemappingModeLottesACES()
		{
			MaxInput = 50.000000F;
			Contrast = 1.500000F;
			MidIn = 0.180000F;
			MidOut = 0.180000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
