using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyMeshAdvancedBuildParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("boundingBoxSyncParams")] 
		public worldProxyBoundingBoxSyncParams BoundingBoxSyncParams
		{
			get => GetPropertyValue<worldProxyBoundingBoxSyncParams>();
			set => SetPropertyValue<worldProxyBoundingBoxSyncParams>(value);
		}

		[Ordinal(1)] 
		[RED("surfaceFlattenParams")] 
		public worldProxySurfaceFlattenParams SurfaceFlattenParams
		{
			get => GetPropertyValue<worldProxySurfaceFlattenParams>();
			set => SetPropertyValue<worldProxySurfaceFlattenParams>(value);
		}

		[Ordinal(2)] 
		[RED("misc")] 
		public worldProxyMiscAdvancedParams Misc
		{
			get => GetPropertyValue<worldProxyMiscAdvancedParams>();
			set => SetPropertyValue<worldProxyMiscAdvancedParams>(value);
		}

		[Ordinal(3)] 
		[RED("rayBias")] 
		public CFloat RayBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rayMaxDistance")] 
		public CFloat RayMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldProxyMeshAdvancedBuildParams()
		{
			BoundingBoxSyncParams = new worldProxyBoundingBoxSyncParams();
			SurfaceFlattenParams = new worldProxySurfaceFlattenParams();
			Misc = new worldProxyMiscAdvancedParams();
			RayBias = 2.100000F;
			RayMaxDistance = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
