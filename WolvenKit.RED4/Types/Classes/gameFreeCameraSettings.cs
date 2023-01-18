using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFreeCameraSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("movPrecision")] 
		public CFloat MovPrecision
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rotPrecision")] 
		public CFloat RotPrecision
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("fov")] 
		public CFloat Fov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("iso")] 
		public CInt32 Iso
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("shutter")] 
		public CFloat Shutter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("aperture")] 
		public CFloat Aperture
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("lights")] 
		public CArray<gameFreeCameraLightSettings> Lights
		{
			get => GetPropertyValue<CArray<gameFreeCameraLightSettings>>();
			set => SetPropertyValue<CArray<gameFreeCameraLightSettings>>(value);
		}

		public gameFreeCameraSettings()
		{
			MovPrecision = 1.000000F;
			RotPrecision = 1.000000F;
			Fov = 60.000000F;
			Iso = 100;
			Shutter = 125.000000F;
			Aperture = 8.000000F;
			Lights = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
