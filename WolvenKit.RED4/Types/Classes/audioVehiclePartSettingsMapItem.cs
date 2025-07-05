using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehiclePartSettingsMapItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("onDetachAcousticsIsolationFactorReduction")] 
		public CFloat OnDetachAcousticsIsolationFactorReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioVehiclePartSettingsMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
