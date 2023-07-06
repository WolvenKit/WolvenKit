using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAudioDurationEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("playbackDirectionSupport")] 
		public CEnum<scnAudioPlaybackDirectionSupportFlag> PlaybackDirectionSupport
		{
			get => GetPropertyValue<CEnum<scnAudioPlaybackDirectionSupportFlag>>();
			set => SetPropertyValue<CEnum<scnAudioPlaybackDirectionSupportFlag>>(value);
		}

		public scnAudioDurationEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Performer = new scnPerformerId { Id = 4294967040 };
			PlaybackDirectionSupport = Enums.scnAudioPlaybackDirectionSupportFlag.Forward;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
