using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHUDVideo_NodeType : questIUIManagerNodeType
	{
		private CResourceAsyncReference<Bink> _video;
		private CBool _skippable;
		private CName _audioEvent;
		private CBool _syncToAudio;
		private CBool _retriggerAudioOnLoop;
		private CBool _looped;
		private CBool _forceVideoFrameRate;
		private CBool _playOnHud;
		private CBool _fullScreen;
		private Vector2 _position;
		private Vector2 _size;

		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(1)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetProperty(ref _skippable);
			set => SetProperty(ref _skippable, value);
		}

		[Ordinal(2)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(3)] 
		[RED("syncToAudio")] 
		public CBool SyncToAudio
		{
			get => GetProperty(ref _syncToAudio);
			set => SetProperty(ref _syncToAudio, value);
		}

		[Ordinal(4)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get => GetProperty(ref _retriggerAudioOnLoop);
			set => SetProperty(ref _retriggerAudioOnLoop, value);
		}

		[Ordinal(5)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetProperty(ref _looped);
			set => SetProperty(ref _looped, value);
		}

		[Ordinal(6)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get => GetProperty(ref _forceVideoFrameRate);
			set => SetProperty(ref _forceVideoFrameRate, value);
		}

		[Ordinal(7)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get => GetProperty(ref _playOnHud);
			set => SetProperty(ref _playOnHud, value);
		}

		[Ordinal(8)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get => GetProperty(ref _fullScreen);
			set => SetProperty(ref _fullScreen, value);
		}

		[Ordinal(9)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(10)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		public questHUDVideo_NodeType()
		{
			_playOnHud = true;
		}
	}
}
