using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SGenericDeviceActionsData : RedBaseClass
	{
		private SDeviceActionBoolData _toggleON;
		private SDeviceActionBoolData _togglePower;

		[Ordinal(0)] 
		[RED("toggleON")] 
		public SDeviceActionBoolData ToggleON
		{
			get => GetProperty(ref _toggleON);
			set => SetProperty(ref _toggleON, value);
		}

		[Ordinal(1)] 
		[RED("togglePower")] 
		public SDeviceActionBoolData TogglePower
		{
			get => GetProperty(ref _togglePower);
			set => SetProperty(ref _togglePower, value);
		}
	}
}
