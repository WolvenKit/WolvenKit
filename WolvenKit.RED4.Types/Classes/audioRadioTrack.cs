using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioTrack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("trackEventName")] 
		public CName TrackEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("localizationKey")] 
		public CName LocalizationKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("primaryLocKey")] 
		public CUInt64 PrimaryLocKey
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("isStreamingFriendly")] 
		public CBool IsStreamingFriendly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioRadioTrack()
		{
			IsStreamingFriendly = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
