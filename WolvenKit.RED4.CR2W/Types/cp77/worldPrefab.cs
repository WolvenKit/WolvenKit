using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefab : resStreamedResource
	{
		private CHandle<worldNodesGroup> _mainGroup;
		private CEnum<worldPrefabType> _type;
		private CEnum<worldPrefabOwnership> _teamOwnership;
		private CEnum<worldPrefabStreamingOcclusion> _streamingOcclusion;
		private CHandle<worldPrefabVariantsList> _defaultVariants;
		private CBool _isLocked;
		private Box _maxBounds;
		private raRef<worldEnvironmentDefinition> _environmentDefinition;
		private raRef<Multilayer_Setup> _terrainMultilayerSetup;
		private raRef<worldAutoFoliageMapping> _foliageBrushToTerrainLayerMapping;
		private CRUID _prefabUniqueId;
		private CArray<CHandle<worldPrefabMetadata>> _metadataArray;
		private CBool _isMerged;
		private worldProxyMeshBuildParams _proxyMeshBuildParams;
		private CBool _isProxyMeshOnly;
		private raRef<CMesh> _proxyMesh;
		private Vector3 _proxyScale;
		private CFloat _proxyDistanceFactor;
		private CBool _boostInnerNodesToProxyDistance;
		private CBool _ignoreMeshEmbeddedOccluders;
		private CBool _ignoreAllOccluders;
		private CBool _excludeOnConsole;
		private CBool _isTerrainPrefab;
		private CEnum<worldPrefabMinimapContribution> _minimapContribution;
		private raRef<worldPrefab> _booleanProxyHelper;
		private raRef<worldPrefab> _proxyLimiterHelper;
		private raRef<CMesh> _customProxyMeshHelper;

		[Ordinal(1)] 
		[RED("mainGroup")] 
		public CHandle<worldNodesGroup> MainGroup
		{
			get
			{
				if (_mainGroup == null)
				{
					_mainGroup = (CHandle<worldNodesGroup>) CR2WTypeManager.Create("handle:worldNodesGroup", "mainGroup", cr2w, this);
				}
				return _mainGroup;
			}
			set
			{
				if (_mainGroup == value)
				{
					return;
				}
				_mainGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<worldPrefabType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldPrefabType>) CR2WTypeManager.Create("worldPrefabType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("teamOwnership")] 
		public CEnum<worldPrefabOwnership> TeamOwnership
		{
			get
			{
				if (_teamOwnership == null)
				{
					_teamOwnership = (CEnum<worldPrefabOwnership>) CR2WTypeManager.Create("worldPrefabOwnership", "teamOwnership", cr2w, this);
				}
				return _teamOwnership;
			}
			set
			{
				if (_teamOwnership == value)
				{
					return;
				}
				_teamOwnership = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get
			{
				if (_streamingOcclusion == null)
				{
					_streamingOcclusion = (CEnum<worldPrefabStreamingOcclusion>) CR2WTypeManager.Create("worldPrefabStreamingOcclusion", "streamingOcclusion", cr2w, this);
				}
				return _streamingOcclusion;
			}
			set
			{
				if (_streamingOcclusion == value)
				{
					return;
				}
				_streamingOcclusion = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultVariants")] 
		public CHandle<worldPrefabVariantsList> DefaultVariants
		{
			get
			{
				if (_defaultVariants == null)
				{
					_defaultVariants = (CHandle<worldPrefabVariantsList>) CR2WTypeManager.Create("handle:worldPrefabVariantsList", "defaultVariants", cr2w, this);
				}
				return _defaultVariants;
			}
			set
			{
				if (_defaultVariants == value)
				{
					return;
				}
				_defaultVariants = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxBounds")] 
		public Box MaxBounds
		{
			get
			{
				if (_maxBounds == null)
				{
					_maxBounds = (Box) CR2WTypeManager.Create("Box", "maxBounds", cr2w, this);
				}
				return _maxBounds;
			}
			set
			{
				if (_maxBounds == value)
				{
					return;
				}
				_maxBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("environmentDefinition")] 
		public raRef<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get
			{
				if (_environmentDefinition == null)
				{
					_environmentDefinition = (raRef<worldEnvironmentDefinition>) CR2WTypeManager.Create("raRef:worldEnvironmentDefinition", "environmentDefinition", cr2w, this);
				}
				return _environmentDefinition;
			}
			set
			{
				if (_environmentDefinition == value)
				{
					return;
				}
				_environmentDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("terrainMultilayerSetup")] 
		public raRef<Multilayer_Setup> TerrainMultilayerSetup
		{
			get
			{
				if (_terrainMultilayerSetup == null)
				{
					_terrainMultilayerSetup = (raRef<Multilayer_Setup>) CR2WTypeManager.Create("raRef:Multilayer_Setup", "terrainMultilayerSetup", cr2w, this);
				}
				return _terrainMultilayerSetup;
			}
			set
			{
				if (_terrainMultilayerSetup == value)
				{
					return;
				}
				_terrainMultilayerSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("foliageBrushToTerrainLayerMapping")] 
		public raRef<worldAutoFoliageMapping> FoliageBrushToTerrainLayerMapping
		{
			get
			{
				if (_foliageBrushToTerrainLayerMapping == null)
				{
					_foliageBrushToTerrainLayerMapping = (raRef<worldAutoFoliageMapping>) CR2WTypeManager.Create("raRef:worldAutoFoliageMapping", "foliageBrushToTerrainLayerMapping", cr2w, this);
				}
				return _foliageBrushToTerrainLayerMapping;
			}
			set
			{
				if (_foliageBrushToTerrainLayerMapping == value)
				{
					return;
				}
				_foliageBrushToTerrainLayerMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("prefabUniqueId")] 
		public CRUID PrefabUniqueId
		{
			get
			{
				if (_prefabUniqueId == null)
				{
					_prefabUniqueId = (CRUID) CR2WTypeManager.Create("CRUID", "prefabUniqueId", cr2w, this);
				}
				return _prefabUniqueId;
			}
			set
			{
				if (_prefabUniqueId == value)
				{
					return;
				}
				_prefabUniqueId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("metadataArray")] 
		public CArray<CHandle<worldPrefabMetadata>> MetadataArray
		{
			get
			{
				if (_metadataArray == null)
				{
					_metadataArray = (CArray<CHandle<worldPrefabMetadata>>) CR2WTypeManager.Create("array:handle:worldPrefabMetadata", "metadataArray", cr2w, this);
				}
				return _metadataArray;
			}
			set
			{
				if (_metadataArray == value)
				{
					return;
				}
				_metadataArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isMerged")] 
		public CBool IsMerged
		{
			get
			{
				if (_isMerged == null)
				{
					_isMerged = (CBool) CR2WTypeManager.Create("Bool", "isMerged", cr2w, this);
				}
				return _isMerged;
			}
			set
			{
				if (_isMerged == value)
				{
					return;
				}
				_isMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("proxyMeshBuildParams")] 
		public worldProxyMeshBuildParams ProxyMeshBuildParams
		{
			get
			{
				if (_proxyMeshBuildParams == null)
				{
					_proxyMeshBuildParams = (worldProxyMeshBuildParams) CR2WTypeManager.Create("worldProxyMeshBuildParams", "proxyMeshBuildParams", cr2w, this);
				}
				return _proxyMeshBuildParams;
			}
			set
			{
				if (_proxyMeshBuildParams == value)
				{
					return;
				}
				_proxyMeshBuildParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isProxyMeshOnly")] 
		public CBool IsProxyMeshOnly
		{
			get
			{
				if (_isProxyMeshOnly == null)
				{
					_isProxyMeshOnly = (CBool) CR2WTypeManager.Create("Bool", "isProxyMeshOnly", cr2w, this);
				}
				return _isProxyMeshOnly;
			}
			set
			{
				if (_isProxyMeshOnly == value)
				{
					return;
				}
				_isProxyMeshOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("proxyMesh")] 
		public raRef<CMesh> ProxyMesh
		{
			get
			{
				if (_proxyMesh == null)
				{
					_proxyMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "proxyMesh", cr2w, this);
				}
				return _proxyMesh;
			}
			set
			{
				if (_proxyMesh == value)
				{
					return;
				}
				_proxyMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("proxyScale")] 
		public Vector3 ProxyScale
		{
			get
			{
				if (_proxyScale == null)
				{
					_proxyScale = (Vector3) CR2WTypeManager.Create("Vector3", "proxyScale", cr2w, this);
				}
				return _proxyScale;
			}
			set
			{
				if (_proxyScale == value)
				{
					return;
				}
				_proxyScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("proxyDistanceFactor")] 
		public CFloat ProxyDistanceFactor
		{
			get
			{
				if (_proxyDistanceFactor == null)
				{
					_proxyDistanceFactor = (CFloat) CR2WTypeManager.Create("Float", "proxyDistanceFactor", cr2w, this);
				}
				return _proxyDistanceFactor;
			}
			set
			{
				if (_proxyDistanceFactor == value)
				{
					return;
				}
				_proxyDistanceFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("boostInnerNodesToProxyDistance")] 
		public CBool BoostInnerNodesToProxyDistance
		{
			get
			{
				if (_boostInnerNodesToProxyDistance == null)
				{
					_boostInnerNodesToProxyDistance = (CBool) CR2WTypeManager.Create("Bool", "boostInnerNodesToProxyDistance", cr2w, this);
				}
				return _boostInnerNodesToProxyDistance;
			}
			set
			{
				if (_boostInnerNodesToProxyDistance == value)
				{
					return;
				}
				_boostInnerNodesToProxyDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get
			{
				if (_ignoreMeshEmbeddedOccluders == null)
				{
					_ignoreMeshEmbeddedOccluders = (CBool) CR2WTypeManager.Create("Bool", "ignoreMeshEmbeddedOccluders", cr2w, this);
				}
				return _ignoreMeshEmbeddedOccluders;
			}
			set
			{
				if (_ignoreMeshEmbeddedOccluders == value)
				{
					return;
				}
				_ignoreMeshEmbeddedOccluders = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get
			{
				if (_ignoreAllOccluders == null)
				{
					_ignoreAllOccluders = (CBool) CR2WTypeManager.Create("Bool", "ignoreAllOccluders", cr2w, this);
				}
				return _ignoreAllOccluders;
			}
			set
			{
				if (_ignoreAllOccluders == value)
				{
					return;
				}
				_ignoreAllOccluders = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("excludeOnConsole")] 
		public CBool ExcludeOnConsole
		{
			get
			{
				if (_excludeOnConsole == null)
				{
					_excludeOnConsole = (CBool) CR2WTypeManager.Create("Bool", "excludeOnConsole", cr2w, this);
				}
				return _excludeOnConsole;
			}
			set
			{
				if (_excludeOnConsole == value)
				{
					return;
				}
				_excludeOnConsole = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isTerrainPrefab")] 
		public CBool IsTerrainPrefab
		{
			get
			{
				if (_isTerrainPrefab == null)
				{
					_isTerrainPrefab = (CBool) CR2WTypeManager.Create("Bool", "isTerrainPrefab", cr2w, this);
				}
				return _isTerrainPrefab;
			}
			set
			{
				if (_isTerrainPrefab == value)
				{
					return;
				}
				_isTerrainPrefab = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("minimapContribution")] 
		public CEnum<worldPrefabMinimapContribution> MinimapContribution
		{
			get
			{
				if (_minimapContribution == null)
				{
					_minimapContribution = (CEnum<worldPrefabMinimapContribution>) CR2WTypeManager.Create("worldPrefabMinimapContribution", "minimapContribution", cr2w, this);
				}
				return _minimapContribution;
			}
			set
			{
				if (_minimapContribution == value)
				{
					return;
				}
				_minimapContribution = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("booleanProxyHelper")] 
		public raRef<worldPrefab> BooleanProxyHelper
		{
			get
			{
				if (_booleanProxyHelper == null)
				{
					_booleanProxyHelper = (raRef<worldPrefab>) CR2WTypeManager.Create("raRef:worldPrefab", "booleanProxyHelper", cr2w, this);
				}
				return _booleanProxyHelper;
			}
			set
			{
				if (_booleanProxyHelper == value)
				{
					return;
				}
				_booleanProxyHelper = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("proxyLimiterHelper")] 
		public raRef<worldPrefab> ProxyLimiterHelper
		{
			get
			{
				if (_proxyLimiterHelper == null)
				{
					_proxyLimiterHelper = (raRef<worldPrefab>) CR2WTypeManager.Create("raRef:worldPrefab", "proxyLimiterHelper", cr2w, this);
				}
				return _proxyLimiterHelper;
			}
			set
			{
				if (_proxyLimiterHelper == value)
				{
					return;
				}
				_proxyLimiterHelper = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("customProxyMeshHelper")] 
		public raRef<CMesh> CustomProxyMeshHelper
		{
			get
			{
				if (_customProxyMeshHelper == null)
				{
					_customProxyMeshHelper = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "customProxyMeshHelper", cr2w, this);
				}
				return _customProxyMeshHelper;
			}
			set
			{
				if (_customProxyMeshHelper == value)
				{
					return;
				}
				_customProxyMeshHelper = value;
				PropertySet(this);
			}
		}

		public worldPrefab(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
