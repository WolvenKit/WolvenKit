using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class appearanceChunkMaskSettings : CVariable
	{
		[Ordinal(0)] [RED("chunksIds")] public CArray<CUInt64> ChunksIds { get; set; }
		[Ordinal(1)] [RED("meshLayout")] public CArray<CUInt32> MeshLayout { get; set; }
		[Ordinal(2)] [RED("meshGeometryHash")] public CUInt64 MeshGeometryHash { get; set; }

		public appearanceChunkMaskSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
