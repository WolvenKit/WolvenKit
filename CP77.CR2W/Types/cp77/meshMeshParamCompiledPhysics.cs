using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCompiledPhysics : meshMeshParameter
	{
		[Ordinal(0)] [RED("collection")] public CHandle<physicsDeferredCollection> Collection { get; set; }

		public meshMeshParamCompiledPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
