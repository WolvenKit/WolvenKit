using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CReflectionProbeDataResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("textureData")] 
		public rendRenderTextureResource TextureData
		{
			get => GetPropertyValue<rendRenderTextureResource>();
			set => SetPropertyValue<rendRenderTextureResource>(value);
		}

		[Ordinal(3)] 
		[RED("dataHash")] 
		public CUInt64 DataHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("haveSkyData")] 
		public CBool HaveSkyData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("faceDepth", 6)] 
		public CArrayFixedSize<CFloat> FaceDepth
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		public CReflectionProbeDataResource()
		{
			TextureData = new();
			HaveSkyData = true;
			FaceDepth = new(6);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
