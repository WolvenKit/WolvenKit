using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyMeshBuildParams : RedBaseClass
	{
		private CBool _buildProxy;
		private CEnum<worldProxyMeshBuildType> _type;
		private CEnum<worldProxyMeshOutputType> _usedMesh;
		private CUInt32 _resolution;
		private CUInt32 _polycount;
		private CFloat _polycountPercentage;
		private CEnum<worldProxyCoreAxis> _coreAxis;
		private CEnum<worldProxyGroupingNormals> _groupingNormals;
		private CBool _forceSurfaceFlattening;
		private CBool _forceSeamlessModule;
		private CBool _enableAlphaMask;
		private worldProxyWindowsParams _windows;
		private worldProxyTextureParams _textures;
		private worldProxyCustomGeometryParams _customGeometry;
		private worldProxyMeshAdvancedBuildParams _advancedParams;

		[Ordinal(0)] 
		[RED("buildProxy")] 
		public CBool BuildProxy
		{
			get => GetProperty(ref _buildProxy);
			set => SetProperty(ref _buildProxy, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldProxyMeshBuildType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("usedMesh")] 
		public CEnum<worldProxyMeshOutputType> UsedMesh
		{
			get => GetProperty(ref _usedMesh);
			set => SetProperty(ref _usedMesh, value);
		}

		[Ordinal(3)] 
		[RED("resolution")] 
		public CUInt32 Resolution
		{
			get => GetProperty(ref _resolution);
			set => SetProperty(ref _resolution, value);
		}

		[Ordinal(4)] 
		[RED("polycount")] 
		public CUInt32 Polycount
		{
			get => GetProperty(ref _polycount);
			set => SetProperty(ref _polycount, value);
		}

		[Ordinal(5)] 
		[RED("polycountPercentage")] 
		public CFloat PolycountPercentage
		{
			get => GetProperty(ref _polycountPercentage);
			set => SetProperty(ref _polycountPercentage, value);
		}

		[Ordinal(6)] 
		[RED("coreAxis")] 
		public CEnum<worldProxyCoreAxis> CoreAxis
		{
			get => GetProperty(ref _coreAxis);
			set => SetProperty(ref _coreAxis, value);
		}

		[Ordinal(7)] 
		[RED("groupingNormals")] 
		public CEnum<worldProxyGroupingNormals> GroupingNormals
		{
			get => GetProperty(ref _groupingNormals);
			set => SetProperty(ref _groupingNormals, value);
		}

		[Ordinal(8)] 
		[RED("forceSurfaceFlattening")] 
		public CBool ForceSurfaceFlattening
		{
			get => GetProperty(ref _forceSurfaceFlattening);
			set => SetProperty(ref _forceSurfaceFlattening, value);
		}

		[Ordinal(9)] 
		[RED("forceSeamlessModule")] 
		public CBool ForceSeamlessModule
		{
			get => GetProperty(ref _forceSeamlessModule);
			set => SetProperty(ref _forceSeamlessModule, value);
		}

		[Ordinal(10)] 
		[RED("enableAlphaMask")] 
		public CBool EnableAlphaMask
		{
			get => GetProperty(ref _enableAlphaMask);
			set => SetProperty(ref _enableAlphaMask, value);
		}

		[Ordinal(11)] 
		[RED("windows")] 
		public worldProxyWindowsParams Windows
		{
			get => GetProperty(ref _windows);
			set => SetProperty(ref _windows, value);
		}

		[Ordinal(12)] 
		[RED("textures")] 
		public worldProxyTextureParams Textures
		{
			get => GetProperty(ref _textures);
			set => SetProperty(ref _textures, value);
		}

		[Ordinal(13)] 
		[RED("customGeometry")] 
		public worldProxyCustomGeometryParams CustomGeometry
		{
			get => GetProperty(ref _customGeometry);
			set => SetProperty(ref _customGeometry, value);
		}

		[Ordinal(14)] 
		[RED("advancedParams")] 
		public worldProxyMeshAdvancedBuildParams AdvancedParams
		{
			get => GetProperty(ref _advancedParams);
			set => SetProperty(ref _advancedParams, value);
		}
	}
}
