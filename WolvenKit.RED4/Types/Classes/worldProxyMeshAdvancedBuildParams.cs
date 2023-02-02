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
			BoundingBoxSyncParams = new() { PullRange = 0.050000F, StackOffset = new() };
			SurfaceFlattenParams = new() { GroupingStepAngle = Enums.worldProxyNormalAngleStepSize.STEP_45 };
			Misc = new() { UseLod1 = true, BlurCutout = 20, OcclusionRatio = 40, FillHolesBeforeReduceRatio = 1.500000F, FillHolesAfterReduceRatio = 0.400000F, RsAxisPrecision = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, RsAxisExpand = new(), RsAliasingReduction = 1.000000F, BcMergeRange = 0.800000F, BcSizeCutoff = 120.000000F, BcIterations = 0.500000F, BcMaxSize = 120.000000F, BcMinSize = 2.000000F, BcMergeSensitivity = 50.000000F, BcMinScale = 1.000000F, BcGridSize = 120.000000F, BcFilterSensitivity = 0.250000F, BcBoundsRatioLimit = 0.250000F, RemoveIslands = true, BackgroundColor = new() };
			RayBias = 2.100000F;
			RayMaxDistance = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
