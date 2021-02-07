using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshGroupBuildParams : CVariable
	{
		[Ordinal(0)]  [RED("overridePrefabBuildParams")] public CBool OverridePrefabBuildParams { get; set; }
		[Ordinal(1)]  [RED("buildParams")] public worldGroupProxyMeshBuildParams BuildParams { get; set; }

		public worldProxyMeshGroupBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
