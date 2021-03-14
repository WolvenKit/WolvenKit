using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobHeader : CVariable
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
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sizeInfo")] 
		public rendRenderTextureBlobSizeInfo SizeInfo
		{
			get
			{
				if (_sizeInfo == null)
				{
					_sizeInfo = (rendRenderTextureBlobSizeInfo) CR2WTypeManager.Create("rendRenderTextureBlobSizeInfo", "sizeInfo", cr2w, this);
				}
				return _sizeInfo;
			}
			set
			{
				if (_sizeInfo == value)
				{
					return;
				}
				_sizeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textureInfo")] 
		public rendRenderTextureBlobTextureInfo TextureInfo
		{
			get
			{
				if (_textureInfo == null)
				{
					_textureInfo = (rendRenderTextureBlobTextureInfo) CR2WTypeManager.Create("rendRenderTextureBlobTextureInfo", "textureInfo", cr2w, this);
				}
				return _textureInfo;
			}
			set
			{
				if (_textureInfo == value)
				{
					return;
				}
				_textureInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mipMapInfo")] 
		public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo
		{
			get
			{
				if (_mipMapInfo == null)
				{
					_mipMapInfo = (CArray<rendRenderTextureBlobMipMapInfo>) CR2WTypeManager.Create("array:rendRenderTextureBlobMipMapInfo", "mipMapInfo", cr2w, this);
				}
				return _mipMapInfo;
			}
			set
			{
				if (_mipMapInfo == value)
				{
					return;
				}
				_mipMapInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("histogramData")] 
		public CArray<rendHistogramBias> HistogramData
		{
			get
			{
				if (_histogramData == null)
				{
					_histogramData = (CArray<rendHistogramBias>) CR2WTypeManager.Create("array:rendHistogramBias", "histogramData", cr2w, this);
				}
				return _histogramData;
			}
			set
			{
				if (_histogramData == value)
				{
					return;
				}
				_histogramData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt32) CR2WTypeManager.Create("Uint32", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
