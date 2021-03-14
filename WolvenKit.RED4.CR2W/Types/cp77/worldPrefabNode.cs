using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefabNode : worldNode
	{
		private raRef<worldPrefab> _prefab;
		private CHandle<worldPrefabInstanceData> _instanceData;
		private CHandle<worldPrefabVariantsList> _enabledVariants;
		private CBool _canBeToggledInGame;
		private CBool _noCollision;
		private CBool _enableRenderSceneLayerOverride;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CBool _ignoreMeshEmbeddedOccluders;
		private CBool _ignoreAllOccluders;
		private CUInt8 _occluderAutoHideDistanceScale;
		private CEnum<worldPrefabProxyMeshOnly> _proxyMeshOnly;
		private CBool _proxyScaleOverride;
		private Vector3 _proxyScale;

		[Ordinal(4)] 
		[RED("prefab")] 
		public raRef<worldPrefab> Prefab
		{
			get
			{
				if (_prefab == null)
				{
					_prefab = (raRef<worldPrefab>) CR2WTypeManager.Create("raRef:worldPrefab", "prefab", cr2w, this);
				}
				return _prefab;
			}
			set
			{
				if (_prefab == value)
				{
					return;
				}
				_prefab = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instanceData")] 
		public CHandle<worldPrefabInstanceData> InstanceData
		{
			get
			{
				if (_instanceData == null)
				{
					_instanceData = (CHandle<worldPrefabInstanceData>) CR2WTypeManager.Create("handle:worldPrefabInstanceData", "instanceData", cr2w, this);
				}
				return _instanceData;
			}
			set
			{
				if (_instanceData == value)
				{
					return;
				}
				_instanceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("enabledVariants")] 
		public CHandle<worldPrefabVariantsList> EnabledVariants
		{
			get
			{
				if (_enabledVariants == null)
				{
					_enabledVariants = (CHandle<worldPrefabVariantsList>) CR2WTypeManager.Create("handle:worldPrefabVariantsList", "enabledVariants", cr2w, this);
				}
				return _enabledVariants;
			}
			set
			{
				if (_enabledVariants == value)
				{
					return;
				}
				_enabledVariants = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("canBeToggledInGame")] 
		public CBool CanBeToggledInGame
		{
			get
			{
				if (_canBeToggledInGame == null)
				{
					_canBeToggledInGame = (CBool) CR2WTypeManager.Create("Bool", "canBeToggledInGame", cr2w, this);
				}
				return _canBeToggledInGame;
			}
			set
			{
				if (_canBeToggledInGame == value)
				{
					return;
				}
				_canBeToggledInGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("noCollision")] 
		public CBool NoCollision
		{
			get
			{
				if (_noCollision == null)
				{
					_noCollision = (CBool) CR2WTypeManager.Create("Bool", "noCollision", cr2w, this);
				}
				return _noCollision;
			}
			set
			{
				if (_noCollision == value)
				{
					return;
				}
				_noCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("enableRenderSceneLayerOverride")] 
		public CBool EnableRenderSceneLayerOverride
		{
			get
			{
				if (_enableRenderSceneLayerOverride == null)
				{
					_enableRenderSceneLayerOverride = (CBool) CR2WTypeManager.Create("Bool", "enableRenderSceneLayerOverride", cr2w, this);
				}
				return _enableRenderSceneLayerOverride;
			}
			set
			{
				if (_enableRenderSceneLayerOverride == value)
				{
					return;
				}
				_enableRenderSceneLayerOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get
			{
				if (_renderSceneLayerMask == null)
				{
					_renderSceneLayerMask = (CEnum<RenderSceneLayerMask>) CR2WTypeManager.Create("RenderSceneLayerMask", "renderSceneLayerMask", cr2w, this);
				}
				return _renderSceneLayerMask;
			}
			set
			{
				if (_renderSceneLayerMask == value)
				{
					return;
				}
				_renderSceneLayerMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("occluderAutoHideDistanceScale")] 
		public CUInt8 OccluderAutoHideDistanceScale
		{
			get
			{
				if (_occluderAutoHideDistanceScale == null)
				{
					_occluderAutoHideDistanceScale = (CUInt8) CR2WTypeManager.Create("Uint8", "occluderAutoHideDistanceScale", cr2w, this);
				}
				return _occluderAutoHideDistanceScale;
			}
			set
			{
				if (_occluderAutoHideDistanceScale == value)
				{
					return;
				}
				_occluderAutoHideDistanceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("proxyMeshOnly")] 
		public CEnum<worldPrefabProxyMeshOnly> ProxyMeshOnly
		{
			get
			{
				if (_proxyMeshOnly == null)
				{
					_proxyMeshOnly = (CEnum<worldPrefabProxyMeshOnly>) CR2WTypeManager.Create("worldPrefabProxyMeshOnly", "proxyMeshOnly", cr2w, this);
				}
				return _proxyMeshOnly;
			}
			set
			{
				if (_proxyMeshOnly == value)
				{
					return;
				}
				_proxyMeshOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("proxyScaleOverride")] 
		public CBool ProxyScaleOverride
		{
			get
			{
				if (_proxyScaleOverride == null)
				{
					_proxyScaleOverride = (CBool) CR2WTypeManager.Create("Bool", "proxyScaleOverride", cr2w, this);
				}
				return _proxyScaleOverride;
			}
			set
			{
				if (_proxyScaleOverride == value)
				{
					return;
				}
				_proxyScaleOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		public worldPrefabNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
