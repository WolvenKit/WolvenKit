using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshGfxClothChunkData : CVariable
	{
		[Ordinal(0)] [RED("positions")] public DataBuffer Positions { get; set; }
		[Ordinal(1)] [RED("indices")] public DataBuffer Indices { get; set; }
		[Ordinal(2)] [RED("skinWeights")] public DataBuffer SkinWeights { get; set; }
		[Ordinal(3)] [RED("skinIndices")] public DataBuffer SkinIndices { get; set; }
		[Ordinal(4)] [RED("skinWeightsExt")] public DataBuffer SkinWeightsExt { get; set; }
		[Ordinal(5)] [RED("skinIndicesExt")] public DataBuffer SkinIndicesExt { get; set; }
		[Ordinal(6)] [RED("simulation")] public CArray<CUInt16> Simulation { get; set; }

		public meshGfxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
