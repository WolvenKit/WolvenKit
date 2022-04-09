using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDoorsSettings : audioDeviceSettings
	{
		[Ordinal(7)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("openFailedEvent")] 
		public CName OpenFailedEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("lockEvent")] 
		public CName LockEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("unlockEvent")] 
		public CName UnlockEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("sealEvent")] 
		public CName SealEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioDoorsSettings()
		{
			CommonSettings = new() { StopAllSoundsOnDetach = true };
			ScanningSettings = new();
			AuxiliaryMetadata = new();
			DeviceSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
