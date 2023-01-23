using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DynamicTexture : ITexture
	{
		[Ordinal(1)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("scaleToViewport")] 
		public CBool ScaleToViewport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("mipChain")] 
		public CBool MipChain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("samplesCount")] 
		public CUInt8 SamplesCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("dataFormat")] 
		public CEnum<DynamicTextureDataFormat> DataFormat
		{
			get => GetPropertyValue<CEnum<DynamicTextureDataFormat>>();
			set => SetPropertyValue<CEnum<DynamicTextureDataFormat>>(value);
		}

		[Ordinal(7)] 
		[RED("generator")] 
		public CHandle<IDynamicTextureGenerator> Generator
		{
			get => GetPropertyValue<CHandle<IDynamicTextureGenerator>>();
			set => SetPropertyValue<CHandle<IDynamicTextureGenerator>>(value);
		}

		public DynamicTexture()
		{
			Width = 256;
			Height = 256;
			SamplesCount = 1;
			DataFormat = Enums.DynamicTextureDataFormat.RGBA_Uint8_SRGB;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
