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
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(1)] 
		[RED("chunkOffsets")] 
		public CArray<CUInt32> ChunkOffsets
		{
			get => GetProperty(ref _chunkOffsets);
			set => SetProperty(ref _chunkOffsets, value);
		}

		[Ordinal(2)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		public meshMeshParamDestructionChunkIndicesOffsets(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
