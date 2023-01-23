using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobTextureInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GpuWrapApieTextureType> Type
		{
			get => GetPropertyValue<CEnum<GpuWrapApieTextureType>>();
			set => SetPropertyValue<CEnum<GpuWrapApieTextureType>>(value);
		}

		[Ordinal(1)] 
		[RED("textureDataSize")] 
		public CUInt32 TextureDataSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("sliceSize")] 
		public CUInt32 SliceSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("dataAlignment")] 
		public CUInt32 DataAlignment
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("sliceCount")] 
		public CUInt16 SliceCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("mipCount")] 
		public CUInt8 MipCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public rendRenderTextureBlobTextureInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
