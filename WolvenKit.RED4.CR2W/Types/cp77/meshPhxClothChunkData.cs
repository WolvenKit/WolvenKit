using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshPhxClothChunkData : CVariable
	{
		private DataBuffer _positions;
		private DataBuffer _indices;
		private DataBuffer _skinWeights;
		private DataBuffer _skinIndices;
		private DataBuffer _skinWeightsExt;
		private DataBuffer _skinIndicesExt;
		private DataBuffer _cookedData;
		private DataBuffer _normals;

		[Ordinal(0)] 
		[RED("positions")] 
		public DataBuffer Positions
		{
			get
			{
				if (_positions == null)
				{
					_positions = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "positions", cr2w, this);
				}
				return _positions;
			}
			set
			{
				if (_positions == value)
				{
					return;
				}
				_positions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public DataBuffer Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "indices", cr2w, this);
				}
				return _indices;
			}
			set
			{
				if (_indices == value)
				{
					return;
				}
				_indices = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skinWeights")] 
		public DataBuffer SkinWeights
		{
			get
			{
				if (_skinWeights == null)
				{
					_skinWeights = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "skinWeights", cr2w, this);
				}
				return _skinWeights;
			}
			set
			{
				if (_skinWeights == value)
				{
					return;
				}
				_skinWeights = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skinIndices")] 
		public DataBuffer SkinIndices
		{
			get
			{
				if (_skinIndices == null)
				{
					_skinIndices = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "skinIndices", cr2w, this);
				}
				return _skinIndices;
			}
			set
			{
				if (_skinIndices == value)
				{
					return;
				}
				_skinIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("skinWeightsExt")] 
		public DataBuffer SkinWeightsExt
		{
			get
			{
				if (_skinWeightsExt == null)
				{
					_skinWeightsExt = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "skinWeightsExt", cr2w, this);
				}
				return _skinWeightsExt;
			}
			set
			{
				if (_skinWeightsExt == value)
				{
					return;
				}
				_skinWeightsExt = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("skinIndicesExt")] 
		public DataBuffer SkinIndicesExt
		{
			get
			{
				if (_skinIndicesExt == null)
				{
					_skinIndicesExt = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "skinIndicesExt", cr2w, this);
				}
				return _skinIndicesExt;
			}
			set
			{
				if (_skinIndicesExt == value)
				{
					return;
				}
				_skinIndicesExt = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get
			{
				if (_cookedData == null)
				{
					_cookedData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "cookedData", cr2w, this);
				}
				return _cookedData;
			}
			set
			{
				if (_cookedData == value)
				{
					return;
				}
				_cookedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("normals")] 
		public DataBuffer Normals
		{
			get
			{
				if (_normals == null)
				{
					_normals = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "normals", cr2w, this);
				}
				return _normals;
			}
			set
			{
				if (_normals == value)
				{
					return;
				}
				_normals = value;
				PropertySet(this);
			}
		}

		public meshPhxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
