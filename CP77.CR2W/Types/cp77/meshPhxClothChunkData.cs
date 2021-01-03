using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshPhxClothChunkData : CVariable
	{
		[Ordinal(0)]  [RED("cookedData")] public DataBuffer CookedData { get; set; }
		[Ordinal(1)]  [RED("indices")] public DataBuffer Indices { get; set; }
		[Ordinal(2)]  [RED("normals")] public DataBuffer Normals { get; set; }
		[Ordinal(3)]  [RED("positions")] public DataBuffer Positions { get; set; }
		[Ordinal(4)]  [RED("skinIndices")] public DataBuffer SkinIndices { get; set; }
		[Ordinal(5)]  [RED("skinIndicesExt")] public DataBuffer SkinIndicesExt { get; set; }
		[Ordinal(6)]  [RED("skinWeights")] public DataBuffer SkinWeights { get; set; }
		[Ordinal(7)]  [RED("skinWeightsExt")] public DataBuffer SkinWeightsExt { get; set; }

		public meshPhxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
