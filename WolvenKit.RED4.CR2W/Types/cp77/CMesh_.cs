using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMesh_ : resStreamedResource
	{
		private CArray<CHandle<meshMeshParameter>> _parameters;
		private Box _boundingBox;
		private Vector3 _surfaceAreaPerAxis;
		private CArray<CMeshMaterialEntry> _materialEntries;
		private CArray<raRef<IMaterial>> _externalMaterials;
		private CArray<CHandle<CMaterialInstance>> _localMaterialInstances;
		private meshMeshMaterialBuffer _localMaterialBuffer;
		private CArray<rRef<IMaterial>> _preloadExternalMaterials;
		private CArray<CHandle<IMaterial>> _preloadLocalMaterialInstances;
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
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<CHandle<meshMeshParameter>>) CR2WTypeManager.Create("array:handle:meshMeshParameter", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get
			{
				if (_boundingBox == null)
				{
					_boundingBox = (Box) CR2WTypeManager.Create("Box", "boundingBox", cr2w, this);
				}
				return _boundingBox;
			}
			set
			{
				if (_boundingBox == value)
				{
					return;
				}
				_boundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("surfaceAreaPerAxis")] 
		public Vector3 SurfaceAreaPerAxis
		{
			get
			{
				if (_surfaceAreaPerAxis == null)
				{
					_surfaceAreaPerAxis = (Vector3) CR2WTypeManager.Create("Vector3", "surfaceAreaPerAxis", cr2w, this);
				}
				return _surfaceAreaPerAxis;
			}
			set
			{
				if (_surfaceAreaPerAxis == value)
				{
					return;
				}
				_surfaceAreaPerAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("materialEntries")] 
		public CArray<CMeshMaterialEntry> MaterialEntries
		{
			get
			{
				if (_materialEntries == null)
				{
					_materialEntries = (CArray<CMeshMaterialEntry>) CR2WTypeManager.Create("array:CMeshMaterialEntry", "materialEntries", cr2w, this);
				}
				return _materialEntries;
			}
			set
			{
				if (_materialEntries == value)
				{
					return;
				}
				_materialEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("externalMaterials")] 
		public CArray<raRef<IMaterial>> ExternalMaterials
		{
			get
			{
				if (_externalMaterials == null)
				{
					_externalMaterials = (CArray<raRef<IMaterial>>) CR2WTypeManager.Create("array:raRef:IMaterial", "externalMaterials", cr2w, this);
				}
				return _externalMaterials;
			}
			set
			{
				if (_externalMaterials == value)
				{
					return;
				}
				_externalMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("localMaterialInstances")] 
		public CArray<CHandle<CMaterialInstance>> LocalMaterialInstances
		{
			get
			{
				if (_localMaterialInstances == null)
				{
					_localMaterialInstances = (CArray<CHandle<CMaterialInstance>>) CR2WTypeManager.Create("array:handle:CMaterialInstance", "localMaterialInstances", cr2w, this);
				}
				return _localMaterialInstances;
			}
			set
			{
				if (_localMaterialInstances == value)
				{
					return;
				}
				_localMaterialInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("localMaterialBuffer")] 
		public meshMeshMaterialBuffer LocalMaterialBuffer
		{
			get
			{
				if (_localMaterialBuffer == null)
				{
					_localMaterialBuffer = (meshMeshMaterialBuffer) CR2WTypeManager.Create("meshMeshMaterialBuffer", "localMaterialBuffer", cr2w, this);
				}
				return _localMaterialBuffer;
			}
			set
			{
				if (_localMaterialBuffer == value)
				{
					return;
				}
				_localMaterialBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("preloadExternalMaterials")] 
		public CArray<rRef<IMaterial>> PreloadExternalMaterials
		{
			get
			{
				if (_preloadExternalMaterials == null)
				{
					_preloadExternalMaterials = (CArray<rRef<IMaterial>>) CR2WTypeManager.Create("array:rRef:IMaterial", "preloadExternalMaterials", cr2w, this);
				}
				return _preloadExternalMaterials;
			}
			set
			{
				if (_preloadExternalMaterials == value)
				{
					return;
				}
				_preloadExternalMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("preloadLocalMaterialInstances")] 
		public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances
		{
			get
			{
				if (_preloadLocalMaterialInstances == null)
				{
					_preloadLocalMaterialInstances = (CArray<CHandle<IMaterial>>) CR2WTypeManager.Create("array:handle:IMaterial", "preloadLocalMaterialInstances", cr2w, this);
				}
				return _preloadLocalMaterialInstances;
			}
			set
			{
				if (_preloadLocalMaterialInstances == value)
				{
					return;
				}
				_preloadLocalMaterialInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("appearances")] 
		public CArray<CHandle<meshMeshAppearance>> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CHandle<meshMeshAppearance>>) CR2WTypeManager.Create("array:handle:meshMeshAppearance", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("objectType")] 
		public CEnum<ERenderObjectType> ObjectType
		{
			get
			{
				if (_objectType == null)
				{
					_objectType = (CEnum<ERenderObjectType>) CR2WTypeManager.Create("ERenderObjectType", "objectType", cr2w, this);
				}
				return _objectType;
			}
			set
			{
				if (_objectType == value)
				{
					return;
				}
				_objectType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get
			{
				if (_renderResourceBlob == null)
				{
					_renderResourceBlob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "renderResourceBlob", cr2w, this);
				}
				return _renderResourceBlob;
			}
			set
			{
				if (_renderResourceBlob == value)
				{
					return;
				}
				_renderResourceBlob = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lodLevelInfo")] 
		public CArray<CFloat> LodLevelInfo
		{
			get
			{
				if (_lodLevelInfo == null)
				{
					_lodLevelInfo = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "lodLevelInfo", cr2w, this);
				}
				return _lodLevelInfo;
			}
			set
			{
				if (_lodLevelInfo == value)
				{
					return;
				}
				_lodLevelInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("floatTrackNames")] 
		public CArray<CName> FloatTrackNames
		{
			get
			{
				if (_floatTrackNames == null)
				{
					_floatTrackNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "floatTrackNames", cr2w, this);
				}
				return _floatTrackNames;
			}
			set
			{
				if (_floatTrackNames == value)
				{
					return;
				}
				_floatTrackNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get
			{
				if (_boneNames == null)
				{
					_boneNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "boneNames", cr2w, this);
				}
				return _boneNames;
			}
			set
			{
				if (_boneNames == value)
				{
					return;
				}
				_boneNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get
			{
				if (_boneRigMatrices == null)
				{
					_boneRigMatrices = (CArray<CMatrix>) CR2WTypeManager.Create("array:Matrix", "boneRigMatrices", cr2w, this);
				}
				return _boneRigMatrices;
			}
			set
			{
				if (_boneRigMatrices == value)
				{
					return;
				}
				_boneRigMatrices = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("boneVertexEpsilons")] 
		public CArray<CFloat> BoneVertexEpsilons
		{
			get
			{
				if (_boneVertexEpsilons == null)
				{
					_boneVertexEpsilons = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "boneVertexEpsilons", cr2w, this);
				}
				return _boneVertexEpsilons;
			}
			set
			{
				if (_boneVertexEpsilons == value)
				{
					return;
				}
				_boneVertexEpsilons = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("lodBoneMask")] 
		public CArray<CUInt8> LodBoneMask
		{
			get
			{
				if (_lodBoneMask == null)
				{
					_lodBoneMask = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "lodBoneMask", cr2w, this);
				}
				return _lodBoneMask;
			}
			set
			{
				if (_lodBoneMask == value)
				{
					return;
				}
				_lodBoneMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("constrainAutoHideDistanceToTerrainHeightMap")] 
		public CBool ConstrainAutoHideDistanceToTerrainHeightMap
		{
			get
			{
				if (_constrainAutoHideDistanceToTerrainHeightMap == null)
				{
					_constrainAutoHideDistanceToTerrainHeightMap = (CBool) CR2WTypeManager.Create("Bool", "constrainAutoHideDistanceToTerrainHeightMap", cr2w, this);
				}
				return _constrainAutoHideDistanceToTerrainHeightMap;
			}
			set
			{
				if (_constrainAutoHideDistanceToTerrainHeightMap == value)
				{
					return;
				}
				_constrainAutoHideDistanceToTerrainHeightMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("forceLoadAllAppearances")] 
		public CBool ForceLoadAllAppearances
		{
			get
			{
				if (_forceLoadAllAppearances == null)
				{
					_forceLoadAllAppearances = (CBool) CR2WTypeManager.Create("Bool", "forceLoadAllAppearances", cr2w, this);
				}
				return _forceLoadAllAppearances;
			}
			set
			{
				if (_forceLoadAllAppearances == value)
				{
					return;
				}
				_forceLoadAllAppearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("castGlobalShadowsCachedInCook")] 
		public CBool CastGlobalShadowsCachedInCook
		{
			get
			{
				if (_castGlobalShadowsCachedInCook == null)
				{
					_castGlobalShadowsCachedInCook = (CBool) CR2WTypeManager.Create("Bool", "castGlobalShadowsCachedInCook", cr2w, this);
				}
				return _castGlobalShadowsCachedInCook;
			}
			set
			{
				if (_castGlobalShadowsCachedInCook == value)
				{
					return;
				}
				_castGlobalShadowsCachedInCook = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("castLocalShadowsCachedInCook")] 
		public CBool CastLocalShadowsCachedInCook
		{
			get
			{
				if (_castLocalShadowsCachedInCook == null)
				{
					_castLocalShadowsCachedInCook = (CBool) CR2WTypeManager.Create("Bool", "castLocalShadowsCachedInCook", cr2w, this);
				}
				return _castLocalShadowsCachedInCook;
			}
			set
			{
				if (_castLocalShadowsCachedInCook == value)
				{
					return;
				}
				_castLocalShadowsCachedInCook = value;
				PropertySet(this);
			}
		}

		public CMesh_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
