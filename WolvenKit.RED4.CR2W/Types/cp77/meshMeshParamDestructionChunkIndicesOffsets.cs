using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionChunkIndicesOffsets : meshMeshParameter
	{
		private CArray<meshChunkIndicesOffset> _offsets;
		private CArray<CUInt32> _chunkOffsets;
		private CArray<DataBuffer> _indices;

		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<meshChunkIndicesOffset> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<meshChunkIndicesOffset>) CR2WTypeManager.Create("array:meshChunkIndicesOffset", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("chunkOffsets")] 
		public CArray<CUInt32> ChunkOffsets
		{
			get
			{
				if (_chunkOffsets == null)
				{
					_chunkOffsets = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "chunkOffsets", cr2w, this);
				}
				return _chunkOffsets;
			}
			set
			{
				if (_chunkOffsets == value)
				{
					return;
				}
				_chunkOffsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "indices", cr2w, this);
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

		public meshMeshParamDestructionChunkIndicesOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
