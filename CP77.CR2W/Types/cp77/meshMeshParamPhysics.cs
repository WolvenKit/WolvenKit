using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamPhysics : meshMeshParameter
	{
		[Ordinal(0)] [RED("physicsData")] public CHandle<physicsSystemResource> PhysicsData { get; set; }

		public meshMeshParamPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
