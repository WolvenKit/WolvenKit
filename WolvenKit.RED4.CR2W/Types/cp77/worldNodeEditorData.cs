using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodeEditorData : ISerializable
	{
		private CUInt64 _id;
		private CName _name;
		private CString _globalName;
		private CString _alternativeGlobalName;
		private CBool _isGlobalNameLocked;
		private CBool _isAlternativeGlobalNameLocked;
		private CBool _isDestructibleNode;
		private CBool _excludeOnConsole;
		private CEnum<worldProxyMeshDependencyMode> _proxyMeshDependency;
		private worldNodeTransform _transform;
		private Transform _pivotTransform;
		private CUInt32 _variantId;
		private CUInt64 _questPrefabRefHash;
		private CBool _isInterior;
		private CBool _isDiscarded;
		private CBool _isSnapTarget;
		private CBool _isSnapSource;
		private CFloat _maxStreamingDistance;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("globalName")] 
		public CString GlobalName
		{
			get
			{
				if (_globalName == null)
				{
					_globalName = (CString) CR2WTypeManager.Create("String", "globalName", cr2w, this);
				}
				return _globalName;
			}
			set
			{
				if (_globalName == value)
				{
					return;
				}
				_globalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("alternativeGlobalName")] 
		public CString AlternativeGlobalName
		{
			get
			{
				if (_alternativeGlobalName == null)
				{
					_alternativeGlobalName = (CString) CR2WTypeManager.Create("String", "alternativeGlobalName", cr2w, this);
				}
				return _alternativeGlobalName;
			}
			set
			{
				if (_alternativeGlobalName == value)
				{
					return;
				}
				_alternativeGlobalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isGlobalNameLocked")] 
		public CBool IsGlobalNameLocked
		{
			get
			{
				if (_isGlobalNameLocked == null)
				{
					_isGlobalNameLocked = (CBool) CR2WTypeManager.Create("Bool", "isGlobalNameLocked", cr2w, this);
				}
				return _isGlobalNameLocked;
			}
			set
			{
				if (_isGlobalNameLocked == value)
				{
					return;
				}
				_isGlobalNameLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isAlternativeGlobalNameLocked")] 
		public CBool IsAlternativeGlobalNameLocked
		{
			get
			{
				if (_isAlternativeGlobalNameLocked == null)
				{
					_isAlternativeGlobalNameLocked = (CBool) CR2WTypeManager.Create("Bool", "isAlternativeGlobalNameLocked", cr2w, this);
				}
				return _isAlternativeGlobalNameLocked;
			}
			set
			{
				if (_isAlternativeGlobalNameLocked == value)
				{
					return;
				}
				_isAlternativeGlobalNameLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isDestructibleNode")] 
		public CBool IsDestructibleNode
		{
			get
			{
				if (_isDestructibleNode == null)
				{
					_isDestructibleNode = (CBool) CR2WTypeManager.Create("Bool", "isDestructibleNode", cr2w, this);
				}
				return _isDestructibleNode;
			}
			set
			{
				if (_isDestructibleNode == value)
				{
					return;
				}
				_isDestructibleNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("proxyMeshDependency")] 
		public CEnum<worldProxyMeshDependencyMode> ProxyMeshDependency
		{
			get
			{
				if (_proxyMeshDependency == null)
				{
					_proxyMeshDependency = (CEnum<worldProxyMeshDependencyMode>) CR2WTypeManager.Create("worldProxyMeshDependencyMode", "proxyMeshDependency", cr2w, this);
				}
				return _proxyMeshDependency;
			}
			set
			{
				if (_proxyMeshDependency == value)
				{
					return;
				}
				_proxyMeshDependency = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("transform")] 
		public worldNodeTransform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (worldNodeTransform) CR2WTypeManager.Create("worldNodeTransform", "transform", cr2w, this);
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

		[Ordinal(10)] 
		[RED("pivotTransform")] 
		public Transform PivotTransform
		{
			get
			{
				if (_pivotTransform == null)
				{
					_pivotTransform = (Transform) CR2WTypeManager.Create("Transform", "pivotTransform", cr2w, this);
				}
				return _pivotTransform;
			}
			set
			{
				if (_pivotTransform == value)
				{
					return;
				}
				_pivotTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("variantId")] 
		public CUInt32 VariantId
		{
			get
			{
				if (_variantId == null)
				{
					_variantId = (CUInt32) CR2WTypeManager.Create("Uint32", "variantId", cr2w, this);
				}
				return _variantId;
			}
			set
			{
				if (_variantId == value)
				{
					return;
				}
				_variantId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("questPrefabRefHash")] 
		public CUInt64 QuestPrefabRefHash
		{
			get
			{
				if (_questPrefabRefHash == null)
				{
					_questPrefabRefHash = (CUInt64) CR2WTypeManager.Create("Uint64", "questPrefabRefHash", cr2w, this);
				}
				return _questPrefabRefHash;
			}
			set
			{
				if (_questPrefabRefHash == value)
				{
					return;
				}
				_questPrefabRefHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get
			{
				if (_isInterior == null)
				{
					_isInterior = (CBool) CR2WTypeManager.Create("Bool", "isInterior", cr2w, this);
				}
				return _isInterior;
			}
			set
			{
				if (_isInterior == value)
				{
					return;
				}
				_isInterior = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get
			{
				if (_isDiscarded == null)
				{
					_isDiscarded = (CBool) CR2WTypeManager.Create("Bool", "isDiscarded", cr2w, this);
				}
				return _isDiscarded;
			}
			set
			{
				if (_isDiscarded == value)
				{
					return;
				}
				_isDiscarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isSnapTarget")] 
		public CBool IsSnapTarget
		{
			get
			{
				if (_isSnapTarget == null)
				{
					_isSnapTarget = (CBool) CR2WTypeManager.Create("Bool", "isSnapTarget", cr2w, this);
				}
				return _isSnapTarget;
			}
			set
			{
				if (_isSnapTarget == value)
				{
					return;
				}
				_isSnapTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isSnapSource")] 
		public CBool IsSnapSource
		{
			get
			{
				if (_isSnapSource == null)
				{
					_isSnapSource = (CBool) CR2WTypeManager.Create("Bool", "isSnapSource", cr2w, this);
				}
				return _isSnapSource;
			}
			set
			{
				if (_isSnapSource == value)
				{
					return;
				}
				_isSnapSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("maxStreamingDistance")] 
		public CFloat MaxStreamingDistance
		{
			get
			{
				if (_maxStreamingDistance == null)
				{
					_maxStreamingDistance = (CFloat) CR2WTypeManager.Create("Float", "maxStreamingDistance", cr2w, this);
				}
				return _maxStreamingDistance;
			}
			set
			{
				if (_maxStreamingDistance == value)
				{
					return;
				}
				_maxStreamingDistance = value;
				PropertySet(this);
			}
		}

		public worldNodeEditorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
