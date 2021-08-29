using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimVideoInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CBool _synchronizeToAudio;
		private CBool _allowSkipBackward;
		private CName _audioEvent;
		private CBool _retriggerAudioOnLoop;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		[Ordinal(9)] 
		[RED("synchronizeToAudio")] 
		public CBool SynchronizeToAudio
		{
			get => GetProperty(ref _synchronizeToAudio);
			set => SetProperty(ref _synchronizeToAudio, value);
		}

		[Ordinal(10)] 
		[RED("allowSkipBackward")] 
		public CBool AllowSkipBackward
		{
			get => GetProperty(ref _allowSkipBackward);
			set => SetProperty(ref _allowSkipBackward, value);
		}

		[Ordinal(11)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(12)] 
		[RED("retriggerAudioOnLoop")] 
		public CBool RetriggerAudioOnLoop
		{
			get => GetProperty(ref _retriggerAudioOnLoop);
			set => SetProperty(ref _retriggerAudioOnLoop, value);
		}
	}
}
