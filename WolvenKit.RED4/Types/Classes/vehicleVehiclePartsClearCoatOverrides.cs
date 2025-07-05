using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehiclePartsClearCoatOverrides : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partsName")] 
		public CArray<CName> PartsName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("overrides")] 
		public vehicleVehicleClearCoatOverrides Overrides
		{
			get => GetPropertyValue<vehicleVehicleClearCoatOverrides>();
			set => SetPropertyValue<vehicleVehicleClearCoatOverrides>(value);
		}

		public vehicleVehiclePartsClearCoatOverrides()
		{
			PartsName = new();
			Overrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
