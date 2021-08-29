using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMesh : resStreamedResource
	{
		private CArray<CHandle<meshMeshParameter>> _parameters;
		private Box _boundingBox;
		private Vector3 _surfaceAreaPerAxis;
		private CArray<CMeshMaterialEntry> _materialEntries;
		private CArray<CResourceAsyncReference<IMaterial>> _externalMaterials;
		private CArray<CHandle<CMaterialInstance>> _localMaterialInstances;
		private meshMeshMaterialBuffer _localMaterialBuffer;
		private CArray<CResourceReference<IMaterial>> _preloadExternalMaterials;
		private CArray<CHandle<IMaterial>> _preloadLocalMaterialInstances;
		private CArray<CResourceReference<CResource>> _inplaceResources;
		private CArray<CHandle<meshMeshAppearance>> _appearances;
		private CEnum<ERenderObjectType> _objectType;
		private CHandle<IRenderResourceBlob> _renderResourceBlob;
		private CArray<CFloat> _lodLevelInfo;
		private CArray<CName> _floatTrackNames;
		private CArray<CName> _boneNames;
		private CArray<CMatrix> _boneRigMatrices;
		private CArray<CFloat> _boneVertexEpsilons;
		private CArray<CUInt8> _lodBoneMask;
		private CBool _constrainAutoHideDistanceToTerrainHeightMap;
		private CBool _forceLoadAllAppearances;
		private CBool _castGlobalShadowsCachedInCook;
		private CBool _castLocalShadowsCachedInCook;

		[Ordinal(2)] 
		[RED("parameters")] 
		public CArray<CHandle<meshMeshParameter>> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetProperty(ref _boundingBox);
			set => SetProperty(ref _boundingBox, value);
		}

		[Ordinal(4)] 
		[RED("surfaceAreaPerAxis")] 
		public Vector3 SurfaceAreaPerAxis
		{
			get => GetProperty(ref _surfaceAreaPerAxis);
			set => SetProperty(ref _surfaceAreaPerAxis, value);
		}

		[Ordinal(6)] 
		[RED("materialEntries")] 
		public CArray<CMeshMaterialEntry> MaterialEntries
		{
			get => GetProperty(ref _materialEntries);
			set => SetProperty(ref _materialEntries, value);
		}

		[Ordinal(7)] 
		[RED("externalMaterials")] 
		public CArray<CResourceAsyncReference<IMaterial>> ExternalMaterials
		{
			get => GetProperty(ref _externalMaterials);
			set => SetProperty(ref _externalMaterials, value);
		}

		[Ordinal(8)] 
		[RED("localMaterialInstances")] 
		public CArray<CHandle<CMaterialInstance>> LocalMaterialInstances
		{
			get => GetProperty(ref _localMaterialInstances);
			set => SetProperty(ref _localMaterialInstances, value);
		}

		[Ordinal(9)] 
		[RED("localMaterialBuffer")] 
		public meshMeshMaterialBuffer LocalMaterialBuffer
		{
			get => GetProperty(ref _localMaterialBuffer);
			set => SetProperty(ref _localMaterialBuffer, value);
		}

		[Ordinal(10)] 
		[RED("preloadExternalMaterials")] 
		public CArray<CResourceReference<IMaterial>> PreloadExternalMaterials
		{
			get => GetProperty(ref _preloadExternalMaterials);
			set => SetProperty(ref _preloadExternalMaterials, value);
		}

		[Ordinal(11)] 
		[RED("preloadLocalMaterialInstances")] 
		public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances
		{
			get => GetProperty(ref _preloadLocalMaterialInstances);
			set => SetProperty(ref _preloadLocalMaterialInstances, value);
		}

		[Ordinal(12)] 
		[RED("inplaceResources")] 
		public CArray<CResourceReference<CResource>> InplaceResources
		{
			get => GetProperty(ref _inplaceResources);
			set => SetProperty(ref _inplaceResources, value);
		}

		[Ordinal(13)] 
		[RED("appearances")] 
		public CArray<CHandle<meshMeshAppearance>> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(14)] 
		[RED("objectType")] 
		public CEnum<ERenderObjectType> ObjectType
		{
			get => GetProperty(ref _objectType);
			set => SetProperty(ref _objectType, value);
		}

		[Ordinal(15)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetProperty(ref _renderResourceBlob);
			set => SetProperty(ref _renderResourceBlob, value);
		}

		[Ordinal(16)] 
		[RED("lodLevelInfo")] 
		public CArray<CFloat> LodLevelInfo
		{
			get => GetProperty(ref _lodLevelInfo);
			set => SetProperty(ref _lodLevelInfo, value);
		}

		[Ordinal(17)] 
		[RED("floatTrackNames")] 
		public CArray<CName> FloatTrackNames
		{
			get => GetProperty(ref _floatTrackNames);
			set => SetProperty(ref _floatTrackNames, value);
		}

		[Ordinal(18)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get => GetProperty(ref _boneNames);
			set => SetProperty(ref _boneNames, value);
		}

		[Ordinal(19)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get => GetProperty(ref _boneRigMatrices);
			set => SetProperty(ref _boneRigMatrices, value);
		}

		[Ordinal(20)] 
		[RED("boneVertexEpsilons")] 
		public CArray<CFloat> BoneVertexEpsilons
		{
			get => GetProperty(ref _boneVertexEpsilons);
			set => SetProperty(ref _boneVertexEpsilons, value);
		}

		[Ordinal(21)] 
		[RED("lodBoneMask")] 
		public CArray<CUInt8> LodBoneMask
		{
			get => GetProperty(ref _lodBoneMask);
			set => SetProperty(ref _lodBoneMask, value);
		}

		[Ordinal(23)] 
		[RED("constrainAutoHideDistanceToTerrainHeightMap")] 
		public CBool ConstrainAutoHideDistanceToTerrainHeightMap
		{
			get => GetProperty(ref _constrainAutoHideDistanceToTerrainHeightMap);
			set => SetProperty(ref _constrainAutoHideDistanceToTerrainHeightMap, value);
		}

		[Ordinal(24)] 
		[RED("forceLoadAllAppearances")] 
		public CBool ForceLoadAllAppearances
		{
			get => GetProperty(ref _forceLoadAllAppearances);
			set => SetProperty(ref _forceLoadAllAppearances, value);
		}

		[Ordinal(25)] 
		[RED("castGlobalShadowsCachedInCook")] 
		public CBool CastGlobalShadowsCachedInCook
		{
			get => GetProperty(ref _castGlobalShadowsCachedInCook);
			set => SetProperty(ref _castGlobalShadowsCachedInCook, value);
		}

		[Ordinal(26)] 
		[RED("castLocalShadowsCachedInCook")] 
		public CBool CastLocalShadowsCachedInCook
		{
			get => GetProperty(ref _castLocalShadowsCachedInCook);
			set => SetProperty(ref _castLocalShadowsCachedInCook, value);
		}
	}
}
