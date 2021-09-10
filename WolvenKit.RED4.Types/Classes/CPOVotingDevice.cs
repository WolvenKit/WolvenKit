using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOVotingDevice : CPOMissionDevice
	{
		[Ordinal(45)] 
		[RED("deviceName")] 
		public CName DeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CPOVotingDevice()
		{
			BlockAfterOperation = false;
			FactToUnblock = "defaults to compatibleDeviceName_enabled";
		}
	}
}
