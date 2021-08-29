using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyMeshAdvancedBuildParams : RedBaseClass
	{
		private worldProxyBoundingBoxSyncParams _boundingBoxSyncParams;
		private worldProxySurfaceFlattenParams _surfaceFlattenParams;
		private worldProxyMiscAdvancedParams _misc;
		private CFloat _rayBias;
		private CFloat _rayMaxDistance;

		[Ordinal(0)] 
		[RED("boundingBoxSyncParams")] 
		public worldProxyBoundingBoxSyncParams BoundingBoxSyncParams
		{
			get => GetProperty(ref _boundingBoxSyncParams);
			set => SetProperty(ref _boundingBoxSyncParams, value);
		}

		[Ordinal(1)] 
		[RED("surfaceFlattenParams")] 
		public worldProxySurfaceFlattenParams SurfaceFlattenParams
		{
			get => GetProperty(ref _surfaceFlattenParams);
			set => SetProperty(ref _surfaceFlattenParams, value);
		}

		[Ordinal(2)] 
		[RED("misc")] 
		public worldProxyMiscAdvancedParams Misc
		{
			get => GetProperty(ref _misc);
			set => SetProperty(ref _misc, value);
		}

		[Ordinal(3)] 
		[RED("rayBias")] 
		public CFloat RayBias
		{
			get => GetProperty(ref _rayBias);
			set => SetProperty(ref _rayBias, value);
		}

		[Ordinal(4)] 
		[RED("rayMaxDistance")] 
		public CFloat RayMaxDistance
		{
			get => GetProperty(ref _rayMaxDistance);
			set => SetProperty(ref _rayMaxDistance, value);
		}
	}
}
