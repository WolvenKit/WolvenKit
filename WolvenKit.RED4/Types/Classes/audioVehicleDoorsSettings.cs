using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleDoorsSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioVehicleDoorsSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
