using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobTextureInfo : CVariable
	{
		private CEnum<GpuWrapApieTextureType> _type;
		private CUInt32 _textureDataSize;
		private CUInt32 _sliceSize;
		private CUInt32 _dataAlignment;
		private CUInt16 _sliceCount;
		private CUInt8 _mipCount;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GpuWrapApieTextureType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("textureDataSize")] 
		public CUInt32 TextureDataSize
		{
			get => GetProperty(ref _textureDataSize);
			set => SetProperty(ref _textureDataSize, value);
		}

		[Ordinal(2)] 
		[RED("sliceSize")] 
		public CUInt32 SliceSize
		{
			get => GetProperty(ref _sliceSize);
			set => SetProperty(ref _sliceSize, value);
		}

		[Ordinal(3)] 
		[RED("dataAlignment")] 
		public CUInt32 DataAlignment
		{
			get => GetProperty(ref _dataAlignment);
			set => SetProperty(ref _dataAlignment, value);
		}

		[Ordinal(4)] 
		[RED("sliceCount")] 
		public CUInt16 SliceCount
		{
			get => GetProperty(ref _sliceCount);
			set => SetProperty(ref _sliceCount, value);
		}

		[Ordinal(5)] 
		[RED("mipCount")] 
		public CUInt8 MipCount
		{
			get => GetProperty(ref _mipCount);
			set => SetProperty(ref _mipCount, value);
		}

		public rendRenderTextureBlobTextureInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
