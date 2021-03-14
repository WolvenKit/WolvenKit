using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCollisionNode : worldNode
	{
		private DataBuffer _compiledData;
		private CUInt16 _numActors;
		private CUInt16 _numShapeInfos;
		private CUInt16 _numShapePositions;
		private CUInt16 _numShapeRotations;
		private CUInt16 _numScales;
		private CUInt16 _numMaterials;
		private CUInt16 _numPresets;
		private CUInt16 _numMaterialIndices;
		private CUInt16 _numShapeIndices;
		private CUInt64 _sectorHash;
		private Vector4 _extents;
		private CUInt8 _lod;
		private CUInt8 _resourceVersion;

		[Ordinal(4)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get
			{
				if (_compiledData == null)
				{
					_compiledData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledData", cr2w, this);
				}
				return _compiledData;
			}
			set
			{
				if (_compiledData == value)
				{
					return;
				}
				_compiledData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numActors")] 
		public CUInt16 NumActors
		{
			get
			{
				if (_numActors == null)
				{
					_numActors = (CUInt16) CR2WTypeManager.Create("Uint16", "numActors", cr2w, this);
				}
				return _numActors;
			}
			set
			{
				if (_numActors == value)
				{
					return;
				}
				_numActors = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numShapeInfos")] 
		public CUInt16 NumShapeInfos
		{
			get
			{
				if (_numShapeInfos == null)
				{
					_numShapeInfos = (CUInt16) CR2WTypeManager.Create("Uint16", "numShapeInfos", cr2w, this);
				}
				return _numShapeInfos;
			}
			set
			{
				if (_numShapeInfos == value)
				{
					return;
				}
				_numShapeInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numShapePositions")] 
		public CUInt16 NumShapePositions
		{
			get
			{
				if (_numShapePositions == null)
				{
					_numShapePositions = (CUInt16) CR2WTypeManager.Create("Uint16", "numShapePositions", cr2w, this);
				}
				return _numShapePositions;
			}
			set
			{
				if (_numShapePositions == value)
				{
					return;
				}
				_numShapePositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("numShapeRotations")] 
		public CUInt16 NumShapeRotations
		{
			get
			{
				if (_numShapeRotations == null)
				{
					_numShapeRotations = (CUInt16) CR2WTypeManager.Create("Uint16", "numShapeRotations", cr2w, this);
				}
				return _numShapeRotations;
			}
			set
			{
				if (_numShapeRotations == value)
				{
					return;
				}
				_numShapeRotations = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numScales")] 
		public CUInt16 NumScales
		{
			get
			{
				if (_numScales == null)
				{
					_numScales = (CUInt16) CR2WTypeManager.Create("Uint16", "numScales", cr2w, this);
				}
				return _numScales;
			}
			set
			{
				if (_numScales == value)
				{
					return;
				}
				_numScales = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("numMaterials")] 
		public CUInt16 NumMaterials
		{
			get
			{
				if (_numMaterials == null)
				{
					_numMaterials = (CUInt16) CR2WTypeManager.Create("Uint16", "numMaterials", cr2w, this);
				}
				return _numMaterials;
			}
			set
			{
				if (_numMaterials == value)
				{
					return;
				}
				_numMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("numPresets")] 
		public CUInt16 NumPresets
		{
			get
			{
				if (_numPresets == null)
				{
					_numPresets = (CUInt16) CR2WTypeManager.Create("Uint16", "numPresets", cr2w, this);
				}
				return _numPresets;
			}
			set
			{
				if (_numPresets == value)
				{
					return;
				}
				_numPresets = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("numMaterialIndices")] 
		public CUInt16 NumMaterialIndices
		{
			get
			{
				if (_numMaterialIndices == null)
				{
					_numMaterialIndices = (CUInt16) CR2WTypeManager.Create("Uint16", "numMaterialIndices", cr2w, this);
				}
				return _numMaterialIndices;
			}
			set
			{
				if (_numMaterialIndices == value)
				{
					return;
				}
				_numMaterialIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("numShapeIndices")] 
		public CUInt16 NumShapeIndices
		{
			get
			{
				if (_numShapeIndices == null)
				{
					_numShapeIndices = (CUInt16) CR2WTypeManager.Create("Uint16", "numShapeIndices", cr2w, this);
				}
				return _numShapeIndices;
			}
			set
			{
				if (_numShapeIndices == value)
				{
					return;
				}
				_numShapeIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get
			{
				if (_sectorHash == null)
				{
					_sectorHash = (CUInt64) CR2WTypeManager.Create("Uint64", "sectorHash", cr2w, this);
				}
				return _sectorHash;
			}
			set
			{
				if (_sectorHash == value)
				{
					return;
				}
				_sectorHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get
			{
				if (_extents == null)
				{
					_extents = (Vector4) CR2WTypeManager.Create("Vector4", "extents", cr2w, this);
				}
				return _extents;
			}
			set
			{
				if (_extents == value)
				{
					return;
				}
				_extents = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lod")] 
		public CUInt8 Lod
		{
			get
			{
				if (_lod == null)
				{
					_lod = (CUInt8) CR2WTypeManager.Create("Uint8", "lod", cr2w, this);
				}
				return _lod;
			}
			set
			{
				if (_lod == value)
				{
					return;
				}
				_lod = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get
			{
				if (_resourceVersion == null)
				{
					_resourceVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "resourceVersion", cr2w, this);
				}
				return _resourceVersion;
			}
			set
			{
				if (_resourceVersion == value)
				{
					return;
				}
				_resourceVersion = value;
				PropertySet(this);
			}
		}

		public worldCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
