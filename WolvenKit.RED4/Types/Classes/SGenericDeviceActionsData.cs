using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SGenericDeviceActionsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("toggleON")] 
		public SDeviceActionBoolData ToggleON
		{
			get => GetPropertyValue<SDeviceActionBoolData>();
			set => SetPropertyValue<SDeviceActionBoolData>(value);
		}

		[Ordinal(1)] 
		[RED("togglePower")] 
		public SDeviceActionBoolData TogglePower
		{
			get => GetPropertyValue<SDeviceActionBoolData>();
			set => SetPropertyValue<SDeviceActionBoolData>(value);
		}

		public SGenericDeviceActionsData()
		{
			ToggleON = new SDeviceActionBoolData();
			TogglePower = new SDeviceActionBoolData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
