using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInstancedMeshNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _castLocalShadows;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt32 _meshLODScales;
		private CUInt8 _occluderAutohideDistanceScale;
		private worldRenderProxyTransformBuffer _worldTransformsBuffer;

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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("meshLODScales")] 
		public CUInt32 MeshLODScales
		{
			get
			{
				if (_meshLODScales == null)
				{
					_meshLODScales = (CUInt32) CR2WTypeManager.Create("Uint32", "meshLODScales", cr2w, this);
				}
				return _meshLODScales;
			}
			set
			{
				if (_meshLODScales == value)
				{
					return;
				}
				_meshLODScales = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("worldTransformsBuffer")] 
		public worldRenderProxyTransformBuffer WorldTransformsBuffer
		{
			get
			{
				if (_worldTransformsBuffer == null)
				{
					_worldTransformsBuffer = (worldRenderProxyTransformBuffer) CR2WTypeManager.Create("worldRenderProxyTransformBuffer", "worldTransformsBuffer", cr2w, this);
				}
				return _worldTransformsBuffer;
			}
			set
			{
				if (_worldTransformsBuffer == value)
				{
					return;
				}
				_worldTransformsBuffer = value;
				PropertySet(this);
			}
		}

		public worldInstancedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
