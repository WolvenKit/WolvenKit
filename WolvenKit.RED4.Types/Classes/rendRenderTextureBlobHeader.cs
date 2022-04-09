using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobHeader : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("sizeInfo")] 
		public rendRenderTextureBlobSizeInfo SizeInfo
		{
			get => GetPropertyValue<rendRenderTextureBlobSizeInfo>();
			set => SetPropertyValue<rendRenderTextureBlobSizeInfo>(value);
		}

		[Ordinal(2)] 
		[RED("textureInfo")] 
		public rendRenderTextureBlobTextureInfo TextureInfo
		{
			get => GetPropertyValue<rendRenderTextureBlobTextureInfo>();
			set => SetPropertyValue<rendRenderTextureBlobTextureInfo>(value);
		}

		[Ordinal(3)] 
		[RED("mipMapInfo")] 
		public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo
		{
			get => GetPropertyValue<CArray<rendRenderTextureBlobMipMapInfo>>();
			set => SetPropertyValue<CArray<rendRenderTextureBlobMipMapInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("histogramData")] 
		public CArray<rendHistogramBias> HistogramData
		{
			get => GetPropertyValue<CArray<rendHistogramBias>>();
			set => SetPropertyValue<CArray<rendHistogramBias>>(value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendRenderTextureBlobHeader()
		{
			SizeInfo = new() { Depth = 1 };
			TextureInfo = new();
			MipMapInfo = new();
			HistogramData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
