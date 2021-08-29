using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAudioDurationEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CName _audioEventName;
		private CEnum<scnAudioPlaybackDirectionSupportFlag> _playbackDirectionSupport;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetProperty(ref _audioEventName);
			set => SetProperty(ref _audioEventName, value);
		}

		[Ordinal(8)] 
		[RED("playbackDirectionSupport")] 
		public CEnum<scnAudioPlaybackDirectionSupportFlag> PlaybackDirectionSupport
		{
			get => GetProperty(ref _playbackDirectionSupport);
			set => SetProperty(ref _playbackDirectionSupport, value);
		}
	}
}
