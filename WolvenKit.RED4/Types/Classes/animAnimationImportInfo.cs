using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimationImportInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("AnimationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<animAnimationType>>();
			set => SetPropertyValue<CEnum<animAnimationType>>(value);
		}

		[Ordinal(1)] 
		[RED("BufferType")] 
		public CEnum<animcompressionBufferTypePreset> BufferType
		{
			get => GetPropertyValue<CEnum<animcompressionBufferTypePreset>>();
			set => SetPropertyValue<CEnum<animcompressionBufferTypePreset>>(value);
		}

		[Ordinal(2)] 
		[RED("CompressionPreset")] 
		public CEnum<animcompressionQualityPreset> CompressionPreset
		{
			get => GetPropertyValue<CEnum<animcompressionQualityPreset>>();
			set => SetPropertyValue<CEnum<animcompressionQualityPreset>>(value);
		}

		[Ordinal(3)] 
		[RED("FrameratePreset")] 
		public CEnum<animcompressionFrameratePreset> FrameratePreset
		{
			get => GetPropertyValue<CEnum<animcompressionFrameratePreset>>();
			set => SetPropertyValue<CEnum<animcompressionFrameratePreset>>(value);
		}

		[Ordinal(4)] 
		[RED("MotionExtractionCompression")] 
		public CEnum<animEMotionExtractionCompressionType> MotionExtractionCompression
		{
			get => GetPropertyValue<CEnum<animEMotionExtractionCompressionType>>();
			set => SetPropertyValue<CEnum<animEMotionExtractionCompressionType>>(value);
		}

		public animAnimationImportInfo()
		{
			CompressionPreset = Enums.animcompressionQualityPreset.MID;
			MotionExtractionCompression = Enums.animEMotionExtractionCompressionType.EMECT_SPLINE_MID;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
