using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodesGroup : ISerializable
	{
		private CName _name;
		private CUInt64 _id;
		private CRUID _groupUniqueId;
		private CArray<CHandle<worldNode>> _nodes;
		private CArray<CHandle<worldNodesGroup>> _subGroups;
		private CEnum<worldNodeGroupType> _type;
		private CBool _keepPosition;
		private Transform _transform;
		private CBool _transformCalculated;
		private Transform _customPivotOffset;
		private worldProxyMeshGroupBuildParams _proxyMeshGroupBuildParams;
		private raRef<CMesh> _proxyMesh;
		private CFloat _proxyDistanceFactor;
		private CArray<CHandle<worldPrefabMetadata>> _metadataArray;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt64) CR2WTypeManager.Create("Uint64", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("groupUniqueId")] 
		public CRUID GroupUniqueId
		{
			get
			{
				if (_groupUniqueId == null)
				{
					_groupUniqueId = (CRUID) CR2WTypeManager.Create("CRUID", "groupUniqueId", cr2w, this);
				}
				return _groupUniqueId;
			}
			set
			{
				if (_groupUniqueId == value)
				{
					return;
				}
				_groupUniqueId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nodes")] 
		public CArray<CHandle<worldNode>> Nodes
		{
			get
			{
				if (_nodes == null)
				{
					_nodes = (CArray<CHandle<worldNode>>) CR2WTypeManager.Create("array:handle:worldNode", "nodes", cr2w, this);
				}
				return _nodes;
			}
			set
			{
				if (_nodes == value)
				{
					return;
				}
				_nodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("subGroups")] 
		public CArray<CHandle<worldNodesGroup>> SubGroups
		{
			get
			{
				if (_subGroups == null)
				{
					_subGroups = (CArray<CHandle<worldNodesGroup>>) CR2WTypeManager.Create("array:handle:worldNodesGroup", "subGroups", cr2w, this);
				}
				return _subGroups;
			}
			set
			{
				if (_subGroups == value)
				{
					return;
				}
				_subGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeGroupType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldNodeGroupType>) CR2WTypeManager.Create("worldNodeGroupType", "type", cr2w, this);
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

		[Ordinal(6)] 
		[RED("keepPosition")] 
		public CBool KeepPosition
		{
			get
			{
				if (_keepPosition == null)
				{
					_keepPosition = (CBool) CR2WTypeManager.Create("Bool", "keepPosition", cr2w, this);
				}
				return _keepPosition;
			}
			set
			{
				if (_keepPosition == value)
				{
					return;
				}
				_keepPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("transformCalculated")] 
		public CBool TransformCalculated
		{
			get
			{
				if (_transformCalculated == null)
				{
					_transformCalculated = (CBool) CR2WTypeManager.Create("Bool", "transformCalculated", cr2w, this);
				}
				return _transformCalculated;
			}
			set
			{
				if (_transformCalculated == value)
				{
					return;
				}
				_transformCalculated = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("customPivotOffset")] 
		public Transform CustomPivotOffset
		{
			get
			{
				if (_customPivotOffset == null)
				{
					_customPivotOffset = (Transform) CR2WTypeManager.Create("Transform", "customPivotOffset", cr2w, this);
				}
				return _customPivotOffset;
			}
			set
			{
				if (_customPivotOffset == value)
				{
					return;
				}
				_customPivotOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("proxyMeshGroupBuildParams")] 
		public worldProxyMeshGroupBuildParams ProxyMeshGroupBuildParams
		{
			get
			{
				if (_proxyMeshGroupBuildParams == null)
				{
					_proxyMeshGroupBuildParams = (worldProxyMeshGroupBuildParams) CR2WTypeManager.Create("worldProxyMeshGroupBuildParams", "proxyMeshGroupBuildParams", cr2w, this);
				}
				return _proxyMeshGroupBuildParams;
			}
			set
			{
				if (_proxyMeshGroupBuildParams == value)
				{
					return;
				}
				_proxyMeshGroupBuildParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		public worldNodesGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
