using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimationImportInfo : RedBaseClass
	{
		private CEnum<animAnimationType> _animationType;
		private CEnum<animcompressionBufferTypePreset> _bufferType;
		private CEnum<animcompressionQualityPreset> _compressionPreset;
		private CEnum<animcompressionFrameratePreset> _frameratePreset;
		private CEnum<animEMotionExtractionCompressionType> _motionExtractionCompression;

		[Ordinal(0)] 
		[RED("AnimationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(1)] 
		[RED("BufferType")] 
		public CEnum<animcompressionBufferTypePreset> BufferType
		{
			get => GetProperty(ref _bufferType);
			set => SetProperty(ref _bufferType, value);
		}

		[Ordinal(2)] 
		[RED("CompressionPreset")] 
		public CEnum<animcompressionQualityPreset> CompressionPreset
		{
			get => GetProperty(ref _compressionPreset);
			set => SetProperty(ref _compressionPreset, value);
		}

		[Ordinal(3)] 
		[RED("FrameratePreset")] 
		public CEnum<animcompressionFrameratePreset> FrameratePreset
		{
			get => GetProperty(ref _frameratePreset);
			set => SetProperty(ref _frameratePreset, value);
		}

		[Ordinal(4)] 
		[RED("MotionExtractionCompression")] 
		public CEnum<animEMotionExtractionCompressionType> MotionExtractionCompression
		{
			get => GetProperty(ref _motionExtractionCompression);
			set => SetProperty(ref _motionExtractionCompression, value);
		}

		public animAnimationImportInfo()
		{
			_compressionPreset = new() { Value = Enums.animcompressionQualityPreset.MID };
			_motionExtractionCompression = new() { Value = Enums.animEMotionExtractionCompressionType.EMECT_SPLINE_MID };
		}
	}
}
