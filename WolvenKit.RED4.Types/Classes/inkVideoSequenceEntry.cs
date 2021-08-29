using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVideoSequenceEntry : RedBaseClass
	{
		private CResourceAsyncReference<Bink> _videoResource;
		private CName _audioEvent;
		private CBool _syncToAudio;
		private CBool _retriggerAudioOnLoop;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(1)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(2)] 
		[RED("syncToAudio")] 
		public CBool SyncToAudio
		{
			get => GetProperty(ref _syncToAudio);
			set => SetProperty(ref _syncToAudio, value);
		}

		[Ordinal(3)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get => GetProperty(ref _retriggerAudioOnLoop);
			set => SetProperty(ref _retriggerAudioOnLoop, value);
		}

		[Ordinal(4)] 
		[RED("loop")] 
		public CBool Loop
		{
			get => GetProperty(ref _loop);
			set => SetProperty(ref _loop, value);
		}
	}
}
