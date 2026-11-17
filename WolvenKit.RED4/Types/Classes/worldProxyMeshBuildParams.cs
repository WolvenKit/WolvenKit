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
			Windows = new worldProxyWindowsParams();
			Textures = new worldProxyTextureParams();
			CustomGeometry = new worldProxyCustomGeometryParams();
			AdvancedParams = new worldProxyMeshAdvancedBuildParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
