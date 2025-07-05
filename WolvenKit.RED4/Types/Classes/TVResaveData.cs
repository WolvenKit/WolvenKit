using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TVResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get => GetPropertyValue<MediaResaveData>();
			set => SetPropertyValue<MediaResaveData>(value);
		}

		[Ordinal(1)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get => GetPropertyValue<CArray<STvChannel>>();
			set => SetPropertyValue<CArray<STvChannel>>(value);
		}

		[Ordinal(2)] 
		[RED("securedText")] 
		public CName SecuredText
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("useWhiteNoiseFX")] 
		public CBool UseWhiteNoiseFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TVResaveData()
		{
			MediaResaveData = new MediaResaveData { MediaDeviceData = new MediaDeviceData() };
			Channels = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
