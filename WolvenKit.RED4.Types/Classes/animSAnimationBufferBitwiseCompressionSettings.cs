using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSAnimationBufferBitwiseCompressionSettings : RedBaseClass
	{
		private CFloat _translationTolerance;
		private CFloat _translationSkipFrameTolerance;
		private CFloat _orientationTolerance;
		private CEnum<SAnimationBufferOrientationCompressionMethod> _orientationCompressionMethod;
		private CFloat _orientationSkipFrameTolerance;
		private CFloat _scaleTolerance;
		private CFloat _scaleSkipFrameTolerance;
		private CFloat _trackTolerance;
		private CFloat _trackSkipFrameTolerance;

		[Ordinal(0)] 
		[RED("translationTolerance")] 
		public CFloat TranslationTolerance
		{
			get => GetProperty(ref _translationTolerance);
			set => SetProperty(ref _translationTolerance, value);
		}

		[Ordinal(1)] 
		[RED("translationSkipFrameTolerance")] 
		public CFloat TranslationSkipFrameTolerance
		{
			get => GetProperty(ref _translationSkipFrameTolerance);
			set => SetProperty(ref _translationSkipFrameTolerance, value);
		}

		[Ordinal(2)] 
		[RED("orientationTolerance")] 
		public CFloat OrientationTolerance
		{
			get => GetProperty(ref _orientationTolerance);
			set => SetProperty(ref _orientationTolerance, value);
		}

		[Ordinal(3)] 
		[RED("orientationCompressionMethod")] 
		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod
		{
			get => GetProperty(ref _orientationCompressionMethod);
			set => SetProperty(ref _orientationCompressionMethod, value);
		}

		[Ordinal(4)] 
		[RED("orientationSkipFrameTolerance")] 
		public CFloat OrientationSkipFrameTolerance
		{
			get => GetProperty(ref _orientationSkipFrameTolerance);
			set => SetProperty(ref _orientationSkipFrameTolerance, value);
		}

		[Ordinal(5)] 
		[RED("scaleTolerance")] 
		public CFloat ScaleTolerance
		{
			get => GetProperty(ref _scaleTolerance);
			set => SetProperty(ref _scaleTolerance, value);
		}

		[Ordinal(6)] 
		[RED("scaleSkipFrameTolerance")] 
		public CFloat ScaleSkipFrameTolerance
		{
			get => GetProperty(ref _scaleSkipFrameTolerance);
			set => SetProperty(ref _scaleSkipFrameTolerance, value);
		}

		[Ordinal(7)] 
		[RED("trackTolerance")] 
		public CFloat TrackTolerance
		{
			get => GetProperty(ref _trackTolerance);
			set => SetProperty(ref _trackTolerance, value);
		}

		[Ordinal(8)] 
		[RED("trackSkipFrameTolerance")] 
		public CFloat TrackSkipFrameTolerance
		{
			get => GetProperty(ref _trackSkipFrameTolerance);
			set => SetProperty(ref _trackSkipFrameTolerance, value);
		}

		public animSAnimationBufferBitwiseCompressionSettings()
		{
			_translationTolerance = 0.010000F;
			_translationSkipFrameTolerance = 0.010000F;
			_orientationTolerance = 0.002000F;
			_orientationCompressionMethod = new() { Value = Enums.SAnimationBufferOrientationCompressionMethod.ABOCM_PackIn48bitsW };
			_orientationSkipFrameTolerance = 0.010000F;
			_scaleTolerance = 0.010000F;
			_scaleSkipFrameTolerance = 0.010000F;
			_trackTolerance = 0.001000F;
			_trackSkipFrameTolerance = 0.001000F;
		}
	}
}
