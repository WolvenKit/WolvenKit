using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleClearCoatOverrides : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("coatTintFwd")] 
		public CColor CoatTintFwd
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("coatTintSide")] 
		public CColor CoatTintSide
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("coatTintFresnelBias")] 
		public CFloat CoatTintFresnelBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("coatSpecularColor")] 
		public CColor CoatSpecularColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("coatFresnelBias")] 
		public CFloat CoatFresnelBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleVehicleClearCoatOverrides()
		{
			Opacity = -1.000000F;
			CoatTintFwd = new CColor();
			CoatTintSide = new CColor();
			CoatTintFresnelBias = -1.000000F;
			CoatSpecularColor = new CColor();
			CoatFresnelBias = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
