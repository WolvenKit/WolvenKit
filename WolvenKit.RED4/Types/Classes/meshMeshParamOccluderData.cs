using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamOccluderData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("occluderResource")] 
		public CHandle<visIOccluderResource> OccluderResource
		{
			get => GetPropertyValue<CHandle<visIOccluderResource>>();
			set => SetPropertyValue<CHandle<visIOccluderResource>>(value);
		}

		[Ordinal(1)] 
		[RED("defaultOccluderType")] 
		public CEnum<visWorldOccluderType> DefaultOccluderType
		{
			get => GetPropertyValue<CEnum<visWorldOccluderType>>();
			set => SetPropertyValue<CEnum<visWorldOccluderType>>(value);
		}

		[Ordinal(2)] 
		[RED("autoHideDistanceScale")] 
		public CUInt8 AutoHideDistanceScale
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public meshMeshParamOccluderData()
		{
			DefaultOccluderType = Enums.visWorldOccluderType.None;
			AutoHideDistanceScale = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
