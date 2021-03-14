using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshRegionData : CVariable
	{
		[Ordinal(0)] [RED("chunkDataIntact")] public CArray<meshChunkOffset> ChunkDataIntact { get; set; }
		[Ordinal(1)] [RED("chunkDataFractured")] public CArray<meshChunkOffset> ChunkDataFractured { get; set; }
		[Ordinal(2)] [RED("chunkMaskIntact")] public CUInt64 ChunkMaskIntact { get; set; }
		[Ordinal(3)] [RED("chunkMaskFractured")] public CUInt64 ChunkMaskFractured { get; set; }
		[Ordinal(4)] [RED("isStaticRemains")] public CBool IsStaticRemains { get; set; }

		public meshRegionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
