using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleOnTurnOnPlayEffectDevice : Device
	{
		[Ordinal(88)] 
		[RED("OnTurnOnEffectName")] 
		public CName OnTurnOnEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(89)] 
		[RED("OnTurnOffEffectName")] 
		public CName OnTurnOffEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SimpleOnTurnOnPlayEffectDevice()
		{
			ControllerTypeName = "SimpleOnTurnOnPlayEffectDeviceController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
