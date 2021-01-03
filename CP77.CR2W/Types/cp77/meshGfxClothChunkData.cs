using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshGfxClothChunkData : CVariable
	{
		[Ordinal(0)]  [RED("indices")] public DataBuffer Indices { get; set; }
		[Ordinal(1)]  [RED("positions")] public DataBuffer Positions { get; set; }
		[Ordinal(2)]  [RED("simulation")] public CArray<CUInt16> Simulation { get; set; }
		[Ordinal(3)]  [RED("skinIndices")] public DataBuffer SkinIndices { get; set; }
		[Ordinal(4)]  [RED("skinIndicesExt")] public DataBuffer SkinIndicesExt { get; set; }
		[Ordinal(5)]  [RED("skinWeights")] public DataBuffer SkinWeights { get; set; }
		[Ordinal(6)]  [RED("skinWeightsExt")] public DataBuffer SkinWeightsExt { get; set; }

		public meshGfxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
