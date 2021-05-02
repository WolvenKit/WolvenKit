using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationImportInfo : CVariable
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

		public animAnimationImportInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
