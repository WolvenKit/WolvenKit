using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshGroupBuildParams : CVariable
	{
		[Ordinal(0)] [RED("overridePrefabBuildParams")] public CBool OverridePrefabBuildParams { get; set; }
		[Ordinal(1)] [RED("buildParams")] public worldGroupProxyMeshBuildParams BuildParams { get; set; }

		public worldProxyMeshGroupBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
