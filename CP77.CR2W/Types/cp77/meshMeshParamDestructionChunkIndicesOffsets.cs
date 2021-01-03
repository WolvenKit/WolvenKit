using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamDestructionChunkIndicesOffsets : meshMeshParameter
	{
		[Ordinal(0)]  [RED("chunkOffsets")] public CArray<CUInt32> ChunkOffsets { get; set; }
		[Ordinal(1)]  [RED("indices")] public CArray<DataBuffer> Indices { get; set; }
		[Ordinal(2)]  [RED("offsets")] public CArray<meshChunkIndicesOffset> Offsets { get; set; }

		public meshMeshParamDestructionChunkIndicesOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
