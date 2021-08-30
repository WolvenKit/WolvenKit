using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAdvertSoundMetadata : audioAudioMetadata
	{
		private CName _audioEvent1;
		private CName _audioEvent2;
		private CName _audioEvent3;
		private CName _audioEvent4;
		private CBool _useCustomDelays;
		private CFloat _speedOfSound;
		private CFloat _soundDelay1;
		private CFloat _soundDelay2;
		private CFloat _soundDelay3;
		private CFloat _soundDelay4;

		[Ordinal(1)] 
		[RED("audioEvent1")] 
		public CName AudioEvent1
		{
			get => GetProperty(ref _audioEvent1);
			set => SetProperty(ref _audioEvent1, value);
		}

		[Ordinal(2)] 
		[RED("audioEvent2")] 
		public CName AudioEvent2
		{
			get => GetProperty(ref _audioEvent2);
			set => SetProperty(ref _audioEvent2, value);
		}

		[Ordinal(3)] 
		[RED("audioEvent3")] 
		public CName AudioEvent3
		{
			get => GetProperty(ref _audioEvent3);
			set => SetProperty(ref _audioEvent3, value);
		}

		[Ordinal(4)] 
		[RED("audioEvent4")] 
		public CName AudioEvent4
		{
			get => GetProperty(ref _audioEvent4);
			set => SetProperty(ref _audioEvent4, value);
		}

		[Ordinal(5)] 
		[RED("useCustomDelays")] 
		public CBool UseCustomDelays
		{
			get => GetProperty(ref _useCustomDelays);
			set => SetProperty(ref _useCustomDelays, value);
		}

		[Ordinal(6)] 
		[RED("speedOfSound")] 
		public CFloat SpeedOfSound
		{
			get => GetProperty(ref _speedOfSound);
			set => SetProperty(ref _speedOfSound, value);
		}

		[Ordinal(7)] 
		[RED("soundDelay1")] 
		public CFloat SoundDelay1
		{
			get => GetProperty(ref _soundDelay1);
			set => SetProperty(ref _soundDelay1, value);
		}

		[Ordinal(8)] 
		[RED("soundDelay2")] 
		public CFloat SoundDelay2
		{
			get => GetProperty(ref _soundDelay2);
			set => SetProperty(ref _soundDelay2, value);
		}

		[Ordinal(9)] 
		[RED("soundDelay3")] 
		public CFloat SoundDelay3
		{
			get => GetProperty(ref _soundDelay3);
			set => SetProperty(ref _soundDelay3, value);
		}

		[Ordinal(10)] 
		[RED("soundDelay4")] 
		public CFloat SoundDelay4
		{
			get => GetProperty(ref _soundDelay4);
			set => SetProperty(ref _soundDelay4, value);
		}

		public audioAdvertSoundMetadata()
		{
			_speedOfSound = 1.000000F;
		}
	}
}
