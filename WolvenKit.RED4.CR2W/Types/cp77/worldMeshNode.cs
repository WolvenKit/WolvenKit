using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldMeshNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CFloat _forceAutoHideDistance;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt8 _occluderAutohideDistanceScale;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CBool _windImpulseEnabled;
		private CBool _removeFromRainMap;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CUInt32 _lodLevelScales;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "meshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get
			{
				if (_forceAutoHideDistance == null)
				{
					_forceAutoHideDistance = (CFloat) CR2WTypeManager.Create("Float", "forceAutoHideDistance", cr2w, this);
				}
				return _forceAutoHideDistance;
			}
			set
			{
				if (_forceAutoHideDistance == value)
				{
					return;
				}
				_forceAutoHideDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get
			{
				if (_occluderType == null)
				{
					_occluderType = (CEnum<visWorldOccluderType>) CR2WTypeManager.Create("visWorldOccluderType", "occluderType", cr2w, this);
				}
				return _occluderType;
			}
			set
			{
				if (_occluderType == value)
				{
					return;
				}
				_occluderType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get
			{
				if (_occluderAutohideDistanceScale == null)
				{
					_occluderAutohideDistanceScale = (CUInt8) CR2WTypeManager.Create("Uint8", "occluderAutohideDistanceScale", cr2w, this);
				}
				return _occluderAutohideDistanceScale;
			}
			set
			{
				if (_occluderAutohideDistanceScale == value)
				{
					return;
				}
				_occluderAutohideDistanceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get
			{
				if (_castShadows == null)
				{
					_castShadows = (CBool) CR2WTypeManager.Create("Bool", "castShadows", cr2w, this);
				}
				return _castShadows;
			}
			set
			{
				if (_castShadows == value)
				{
					return;
				}
				_castShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get
			{
				if (_castLocalShadows == null)
				{
					_castLocalShadows = (CBool) CR2WTypeManager.Create("Bool", "castLocalShadows", cr2w, this);
				}
				return _castLocalShadows;
			}
			set
			{
				if (_castLocalShadows == value)
				{
					return;
				}
				_castLocalShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("windImpulseEnabled")] 
		public CBool WindImpulseEnabled
		{
			get
			{
				if (_windImpulseEnabled == null)
				{
					_windImpulseEnabled = (CBool) CR2WTypeManager.Create("Bool", "windImpulseEnabled", cr2w, this);
				}
				return _windImpulseEnabled;
			}
			set
			{
				if (_windImpulseEnabled == value)
				{
					return;
				}
				_windImpulseEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get
			{
				if (_removeFromRainMap == null)
				{
					_removeFromRainMap = (CBool) CR2WTypeManager.Create("Bool", "removeFromRainMap", cr2w, this);
				}
				return _removeFromRainMap;
			}
			set
			{
				if (_removeFromRainMap == value)
				{
					return;
				}
				_removeFromRainMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("lodLevelScales")] 
		public CUInt32 LodLevelScales
		{
			get
			{
				if (_lodLevelScales == null)
				{
					_lodLevelScales = (CUInt32) CR2WTypeManager.Create("Uint32", "lodLevelScales", cr2w, this);
				}
				return _lodLevelScales;
			}
			set
			{
				if (_lodLevelScales == value)
				{
					return;
				}
				_lodLevelScales = value;
				PropertySet(this);
			}
		}

		public worldMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
