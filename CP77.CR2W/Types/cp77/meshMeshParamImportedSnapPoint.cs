using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamImportedSnapPoint : meshMeshParameter
	{
		[Ordinal(0)] [RED("snapFeatureData")] public CArray<CHandle<meshMeshImportedSnapPoint>> SnapFeatureData { get; set; }

		public meshMeshParamImportedSnapPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
