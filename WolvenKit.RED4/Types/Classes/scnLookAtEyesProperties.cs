using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtEyesProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enableFactor")] 
		public CFloat EnableFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CFloat Override
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public scnLookAtEyesProperties()
		{
			EnableFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
