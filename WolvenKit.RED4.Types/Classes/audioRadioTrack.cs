using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRadioTrack : RedBaseClass
	{
		private CName _trackEventName;
		private CName _localizationKey;
		private CUInt64 _primaryLocKey;
		private CBool _isStreamingFriendly;

		[Ordinal(0)] 
		[RED("trackEventName")] 
		public CName TrackEventName
		{
			get => GetProperty(ref _trackEventName);
			set => SetProperty(ref _trackEventName, value);
		}

		[Ordinal(1)] 
		[RED("localizationKey")] 
		public CName LocalizationKey
		{
			get => GetProperty(ref _localizationKey);
			set => SetProperty(ref _localizationKey, value);
		}

		[Ordinal(2)] 
		[RED("primaryLocKey")] 
		public CUInt64 PrimaryLocKey
		{
			get => GetProperty(ref _primaryLocKey);
			set => SetProperty(ref _primaryLocKey, value);
		}

		[Ordinal(3)] 
		[RED("isStreamingFriendly")] 
		public CBool IsStreamingFriendly
		{
			get => GetProperty(ref _isStreamingFriendly);
			set => SetProperty(ref _isStreamingFriendly, value);
		}
	}
}
