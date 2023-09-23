using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayBinkDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("bink")] 
		public SBinkperationData Bink
		{
			get => GetPropertyValue<SBinkperationData>();
			set => SetPropertyValue<SBinkperationData>(value);
		}

		public PlayBinkDeviceOperation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
