using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAccumulatedSoundDecoratorMetadata : audioEmitterMetadata
	{
		private CArray<CName> _accumulatedSounds;
		private CBool _inSpammingMode;
		private CName _fadeParam;
		private CFloat _soundTimeout;
		private CName _loopStart;
		private CName _loopEnd;
		private CName _spammingSound;
		private CFloat _spammingSoundInterval;

		[Ordinal(1)] 
		[RED("accumulatedSounds")] 
		public CArray<CName> AccumulatedSounds
		{
			get => GetProperty(ref _accumulatedSounds);
			set => SetProperty(ref _accumulatedSounds, value);
		}

		[Ordinal(2)] 
		[RED("inSpammingMode")] 
		public CBool InSpammingMode
		{
			get => GetProperty(ref _inSpammingMode);
			set => SetProperty(ref _inSpammingMode, value);
		}

		[Ordinal(3)] 
		[RED("fadeParam")] 
		public CName FadeParam
		{
			get => GetProperty(ref _fadeParam);
			set => SetProperty(ref _fadeParam, value);
		}

		[Ordinal(4)] 
		[RED("soundTimeout")] 
		public CFloat SoundTimeout
		{
			get => GetProperty(ref _soundTimeout);
			set => SetProperty(ref _soundTimeout, value);
		}

		[Ordinal(5)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get => GetProperty(ref _loopStart);
			set => SetProperty(ref _loopStart, value);
		}

		[Ordinal(6)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get => GetProperty(ref _loopEnd);
			set => SetProperty(ref _loopEnd, value);
		}

		[Ordinal(7)] 
		[RED("spammingSound")] 
		public CName SpammingSound
		{
			get => GetProperty(ref _spammingSound);
			set => SetProperty(ref _spammingSound, value);
		}

		[Ordinal(8)] 
		[RED("spammingSoundInterval")] 
		public CFloat SpammingSoundInterval
		{
			get => GetProperty(ref _spammingSoundInterval);
			set => SetProperty(ref _spammingSoundInterval, value);
		}

		public audioAccumulatedSoundDecoratorMetadata()
		{
			_soundTimeout = 1.000000F;
			_spammingSoundInterval = 1.000000F;
		}
	}
}
