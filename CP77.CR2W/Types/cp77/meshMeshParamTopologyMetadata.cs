using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTopologyMetadata : meshMeshParameter
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("offsets")] public CArray<CUInt32> Offsets { get; set; }
		[Ordinal(2)]  [RED("sizes")] public CArray<CUInt32> Sizes { get; set; }

		public meshMeshParamTopologyMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
