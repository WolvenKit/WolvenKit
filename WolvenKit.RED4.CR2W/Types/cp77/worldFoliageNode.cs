using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private raRef<worldFoliageCompiledResource> _foliageResource;
		private Box _foliageLocalBounds;
		private CFloat _autoHideDistanceScale;
		private CFloat _lodDistanceScale;
		private CFloat _streamingDistance;
		private worldFoliagePopulationSpanInfo _populationSpanInfo;
		private CUInt64 _destructionHash;
		private CFloat _meshHeight;

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
		[RED("foliageResource")] 
		public raRef<worldFoliageCompiledResource> FoliageResource
		{
			get
			{
				if (_foliageResource == null)
				{
					_foliageResource = (raRef<worldFoliageCompiledResource>) CR2WTypeManager.Create("raRef:worldFoliageCompiledResource", "foliageResource", cr2w, this);
				}
				return _foliageResource;
			}
			set
			{
				if (_foliageResource == value)
				{
					return;
				}
				_foliageResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("foliageLocalBounds")] 
		public Box FoliageLocalBounds
		{
			get
			{
				if (_foliageLocalBounds == null)
				{
					_foliageLocalBounds = (Box) CR2WTypeManager.Create("Box", "foliageLocalBounds", cr2w, this);
				}
				return _foliageLocalBounds;
			}
			set
			{
				if (_foliageLocalBounds == value)
				{
					return;
				}
				_foliageLocalBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("autoHideDistanceScale")] 
		public CFloat AutoHideDistanceScale
		{
			get
			{
				if (_autoHideDistanceScale == null)
				{
					_autoHideDistanceScale = (CFloat) CR2WTypeManager.Create("Float", "autoHideDistanceScale", cr2w, this);
				}
				return _autoHideDistanceScale;
			}
			set
			{
				if (_autoHideDistanceScale == value)
				{
					return;
				}
				_autoHideDistanceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lodDistanceScale")] 
		public CFloat LodDistanceScale
		{
			get
			{
				if (_lodDistanceScale == null)
				{
					_lodDistanceScale = (CFloat) CR2WTypeManager.Create("Float", "lodDistanceScale", cr2w, this);
				}
				return _lodDistanceScale;
			}
			set
			{
				if (_lodDistanceScale == value)
				{
					return;
				}
				_lodDistanceScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get
			{
				if (_streamingDistance == null)
				{
					_streamingDistance = (CFloat) CR2WTypeManager.Create("Float", "streamingDistance", cr2w, this);
				}
				return _streamingDistance;
			}
			set
			{
				if (_streamingDistance == value)
				{
					return;
				}
				_streamingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("populationSpanInfo")] 
		public worldFoliagePopulationSpanInfo PopulationSpanInfo
		{
			get
			{
				if (_populationSpanInfo == null)
				{
					_populationSpanInfo = (worldFoliagePopulationSpanInfo) CR2WTypeManager.Create("worldFoliagePopulationSpanInfo", "populationSpanInfo", cr2w, this);
				}
				return _populationSpanInfo;
			}
			set
			{
				if (_populationSpanInfo == value)
				{
					return;
				}
				_populationSpanInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("destructionHash")] 
		public CUInt64 DestructionHash
		{
			get
			{
				if (_destructionHash == null)
				{
					_destructionHash = (CUInt64) CR2WTypeManager.Create("Uint64", "destructionHash", cr2w, this);
				}
				return _destructionHash;
			}
			set
			{
				if (_destructionHash == value)
				{
					return;
				}
				_destructionHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("meshHeight")] 
		public CFloat MeshHeight
		{
			get
			{
				if (_meshHeight == null)
				{
					_meshHeight = (CFloat) CR2WTypeManager.Create("Float", "meshHeight", cr2w, this);
				}
				return _meshHeight;
			}
			set
			{
				if (_meshHeight == value)
				{
					return;
				}
				_meshHeight = value;
				PropertySet(this);
			}
		}

		public worldFoliageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
