using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMesh : resStreamedResource
	{
		[Ordinal(2)] 
		[RED("parameters")] 
		public CArray<CHandle<meshMeshParameter>> Parameters
		{
			get => GetPropertyValue<CArray<CHandle<meshMeshParameter>>>();
			set => SetPropertyValue<CArray<CHandle<meshMeshParameter>>>(value);
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(4)] 
		[RED("surfaceAreaPerAxis")] 
		public Vector3 SurfaceAreaPerAxis
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("materialEntries")] 
		public CArray<CMeshMaterialEntry> MaterialEntries
		{
			get => GetPropertyValue<CArray<CMeshMaterialEntry>>();
			set => SetPropertyValue<CArray<CMeshMaterialEntry>>(value);
		}

		[Ordinal(7)] 
		[RED("externalMaterials")] 
		public CArray<CResourceAsyncReference<IMaterial>> ExternalMaterials
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<IMaterial>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<IMaterial>>>(value);
		}

		[Ordinal(8)] 
		[RED("localMaterialInstances")] 
		public CArray<CHandle<CMaterialInstance>> LocalMaterialInstances
		{
			get => GetPropertyValue<CArray<CHandle<CMaterialInstance>>>();
			set => SetPropertyValue<CArray<CHandle<CMaterialInstance>>>(value);
		}

		[Ordinal(9)] 
		[RED("localMaterialBuffer")] 
		public meshMeshMaterialBuffer LocalMaterialBuffer
		{
			get => GetPropertyValue<meshMeshMaterialBuffer>();
			set => SetPropertyValue<meshMeshMaterialBuffer>(value);
		}

		[Ordinal(10)] 
		[RED("preloadExternalMaterials")] 
		public CArray<CResourceReference<IMaterial>> PreloadExternalMaterials
		{
			get => GetPropertyValue<CArray<CResourceReference<IMaterial>>>();
			set => SetPropertyValue<CArray<CResourceReference<IMaterial>>>(value);
		}

		[Ordinal(11)] 
		[RED("preloadLocalMaterialInstances")] 
		public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances
		{
			get => GetPropertyValue<CArray<CHandle<IMaterial>>>();
			set => SetPropertyValue<CArray<CHandle<IMaterial>>>(value);
		}

		[Ordinal(12)] 
		[RED("inplaceResources")] 
		public CArray<CResourceReference<CResource>> InplaceResources
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		[Ordinal(13)] 
		[RED("appearances")] 
		public CArray<CHandle<meshMeshAppearance>> Appearances
		{
			get => GetPropertyValue<CArray<CHandle<meshMeshAppearance>>>();
			set => SetPropertyValue<CArray<CHandle<meshMeshAppearance>>>(value);
		}

		[Ordinal(14)] 
		[RED("objectType")] 
		public CEnum<ERenderObjectType> ObjectType
		{
			get => GetPropertyValue<CEnum<ERenderObjectType>>();
			set => SetPropertyValue<CEnum<ERenderObjectType>>(value);
		}

		[Ordinal(15)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		[Ordinal(16)] 
		[RED("lodLevelInfo")] 
		public CArray<CFloat> LodLevelInfo
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(17)] 
		[RED("floatTrackNames")] 
		public CArray<CName> FloatTrackNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(18)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(19)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get => GetPropertyValue<CArray<CMatrix>>();
			set => SetPropertyValue<CArray<CMatrix>>(value);
		}

		[Ordinal(20)] 
		[RED("boneVertexEpsilons")] 
		public CArray<CFloat> BoneVertexEpsilons
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(21)] 
		[RED("lodBoneMask")] 
		public CArray<CUInt8> LodBoneMask
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(23)] 
		[RED("constrainAutoHideDistanceToTerrainHeightMap")] 
		public CBool ConstrainAutoHideDistanceToTerrainHeightMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("forceLoadAllAppearances")] 
		public CBool ForceLoadAllAppearances
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("castGlobalShadowsCachedInCook")] 
		public CBool CastGlobalShadowsCachedInCook
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("castLocalShadowsCachedInCook")] 
		public CBool CastLocalShadowsCachedInCook
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CMesh()
		{
			Parameters = new();
			BoundingBox = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };
			SurfaceAreaPerAxis = new Vector3 { X = -1.000000F, Y = -1.000000F, Z = -1.000000F };
			MaterialEntries = new();
			ExternalMaterials = new();
			LocalMaterialInstances = new();
			LocalMaterialBuffer = new meshMeshMaterialBuffer { RawDataHeaders = new() };
			PreloadExternalMaterials = new();
			PreloadLocalMaterialInstances = new();
			InplaceResources = new();
			Appearances = new();
			LodLevelInfo = new();
			FloatTrackNames = new();
			BoneNames = new();
			BoneRigMatrices = new();
			BoneVertexEpsilons = new();
			LodBoneMask = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
