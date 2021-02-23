using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamWorkspotOffsets : meshMeshParameter
	{
		[Ordinal(0)] [RED("names")] public CArray<CName> Names { get; set; }
		[Ordinal(1)] [RED("offsets")] public CArray<CMatrix> Offsets { get; set; }

		public meshMeshParamWorkspotOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
