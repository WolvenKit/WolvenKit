using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioTrack : CVariable
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

		public audioRadioTrack(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
