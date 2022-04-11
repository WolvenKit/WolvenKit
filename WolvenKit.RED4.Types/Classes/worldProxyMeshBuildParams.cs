using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyMeshBuildParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buildProxy")] 
		public CBool BuildProxy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldProxyMeshBuildType> Type
		{
			get => GetPropertyValue<CEnum<worldProxyMeshBuildType>>();
			set => SetPropertyValue<CEnum<worldProxyMeshBuildType>>(value);
		}

		[Ordinal(2)] 
		[RED("usedMesh")] 
		public CEnum<worldProxyMeshOutputType> UsedMesh
		{
			get => GetPropertyValue<CEnum<worldProxyMeshOutputType>>();
			set => SetPropertyValue<CEnum<worldProxyMeshOutputType>>(value);
		}

		[Ordinal(3)] 
		[RED("resolution")] 
		public CUInt32 Resolution
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("polycount")] 
		public CUInt32 Polycount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("polycountPercentage")] 
		public CFloat PolycountPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("coreAxis")] 
		public CEnum<worldProxyCoreAxis> CoreAxis
		{
			get => GetPropertyValue<CEnum<worldProxyCoreAxis>>();
			set => SetPropertyValue<CEnum<worldProxyCoreAxis>>(value);
		}

		[Ordinal(7)] 
		[RED("groupingNormals")] 
		public CEnum<worldProxyGroupingNormals> GroupingNormals
		{
			get => GetPropertyValue<CEnum<worldProxyGroupingNormals>>();
			set => SetPropertyValue<CEnum<worldProxyGroupingNormals>>(value);
		}

		[Ordinal(8)] 
		[RED("forceSurfaceFlattening")] 
		public CBool ForceSurfaceFlattening
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("forceSeamlessModule")] 
		public CBool ForceSeamlessModule
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("enableAlphaMask")] 
		public CBool EnableAlphaMask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("windows")] 
		public worldProxyWindowsParams Windows
		{
			get => GetPropertyValue<worldProxyWindowsParams>();
			set => SetPropertyValue<worldProxyWindowsParams>(value);
		}

		[Ordinal(12)] 
		[RED("textures")] 
		public worldProxyTextureParams Textures
		{
			get => GetPropertyValue<worldProxyTextureParams>();
			set => SetPropertyValue<worldProxyTextureParams>(value);
		}

		[Ordinal(13)] 
		[RED("customGeometry")] 
		public worldProxyCustomGeometryParams CustomGeometry
		{
			get => GetPropertyValue<worldProxyCustomGeometryParams>();
			set => SetPropertyValue<worldProxyCustomGeometryParams>(value);
		}

		[Ordinal(14)] 
		[RED("advancedParams")] 
		public worldProxyMeshAdvancedBuildParams AdvancedParams
		{
			get => GetPropertyValue<worldProxyMeshAdvancedBuildParams>();
			set => SetPropertyValue<worldProxyMeshAdvancedBuildParams>(value);
		}

		public worldProxyMeshBuildParams()
		{
			Resolution = 5;
			Polycount = 500;
			PolycountPercentage = 5.000000F;
			CoreAxis = Enums.worldProxyCoreAxis.Z;
			GroupingNormals = Enums.worldProxyGroupingNormals.Around_All_Axes;
			Windows = new() { WindowsType = Enums.worldProxWindowsType.PropagateWindows, Distance = 0.400000F, DistanceAboveProxy = 0.020000F, RemoveSmallerThan = 0.300000F, DistantWindowsEmissive = 1.000000F, DistantWindowsSize = 3.000000F, DistantWindowsSaturation = 0.750000F, DistantWindowsTurnedOf = 0.450000F };
			Textures = new() { AlbedoTextureResolution = Enums.worldProxyMeshTexRes.RES_256, GenerateAlbedo = true, NormalTextureResolution = Enums.worldProxyMeshTexRes.RES_128, RoughnessTextureResolution = Enums.worldProxyMeshTexRes.RES_128, GenerateRoughness = true, MetalnessTextureResolution = Enums.worldProxyMeshTexRes.RES_128, DiffuseAlphaAsEmissive = true };
			CustomGeometry = new() { UvType = Enums.worldProxyMeshUVType.UvGenerateNew };
			AdvancedParams = new() { BoundingBoxSyncParams = new() { PullRange = 0.050000F, StackOffset = new() }, SurfaceFlattenParams = new() { GroupingStepAngle = Enums.worldProxyNormalAngleStepSize.STEP_45 }, Misc = new() { UseLod1 = true, BlurCutout = 20, OcclusionRatio = 40, FillHolesBeforeReduceRatio = 1.500000F, FillHolesAfterReduceRatio = 0.400000F, RsAxisPrecision = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F }, RsAxisExpand = new(), RsAliasingReduction = 1.000000F, BcMergeRange = 0.800000F, BcSizeCutoff = 120.000000F, BcIterations = 0.500000F, BcMaxSize = 120.000000F, BcMinSize = 2.000000F, BcMergeSensitivity = 50.000000F, BcMinScale = 1.000000F, BcGridSize = 120.000000F, BcFilterSensitivity = 0.250000F, BcBoundsRatioLimit = 0.250000F, RemoveIslands = true, BackgroundColor = new() }, RayBias = 2.100000F, RayMaxDistance = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
