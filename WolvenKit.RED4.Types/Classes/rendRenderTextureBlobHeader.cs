using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureBlobHeader : RedBaseClass
	{
		private CUInt32 _version;
		private rendRenderTextureBlobSizeInfo _sizeInfo;
		private rendRenderTextureBlobTextureInfo _textureInfo;
		private CArray<rendRenderTextureBlobMipMapInfo> _mipMapInfo;
		private CArray<rendHistogramBias> _histogramData;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("sizeInfo")] 
		public rendRenderTextureBlobSizeInfo SizeInfo
		{
			get => GetProperty(ref _sizeInfo);
			set => SetProperty(ref _sizeInfo, value);
		}

		[Ordinal(2)] 
		[RED("textureInfo")] 
		public rendRenderTextureBlobTextureInfo TextureInfo
		{
			get => GetProperty(ref _textureInfo);
			set => SetProperty(ref _textureInfo, value);
		}

		[Ordinal(3)] 
		[RED("mipMapInfo")] 
		public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo
		{
			get => GetProperty(ref _mipMapInfo);
			set => SetProperty(ref _mipMapInfo, value);
		}

		[Ordinal(4)] 
		[RED("histogramData")] 
		public CArray<rendHistogramBias> HistogramData
		{
			get => GetProperty(ref _histogramData);
			set => SetProperty(ref _histogramData, value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
