using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamOccluderData : meshMeshParameter
	{
		private CHandle<visIOccluderResource> _occluderResource;
		private CEnum<visWorldOccluderType> _defaultOccluderType;
		private CUInt8 _autoHideDistanceScale;

		[Ordinal(0)] 
		[RED("occluderResource")] 
		public CHandle<visIOccluderResource> OccluderResource
		{
			get => GetProperty(ref _occluderResource);
			set => SetProperty(ref _occluderResource, value);
		}

		[Ordinal(1)] 
		[RED("defaultOccluderType")] 
		public CEnum<visWorldOccluderType> DefaultOccluderType
		{
			get => GetProperty(ref _defaultOccluderType);
			set => SetProperty(ref _defaultOccluderType, value);
		}

		[Ordinal(2)] 
		[RED("autoHideDistanceScale")] 
		public CUInt8 AutoHideDistanceScale
		{
			get => GetProperty(ref _autoHideDistanceScale);
			set => SetProperty(ref _autoHideDistanceScale, value);
		}

		public meshMeshParamOccluderData()
		{
			_defaultOccluderType = new() { Value = Enums.visWorldOccluderType.None };
			_autoHideDistanceScale = 255;
		}
	}
}
