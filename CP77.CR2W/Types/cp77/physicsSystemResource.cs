using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSystemResource : CResource
	{
		[Ordinal(1)] [RED("bodies")] public CArray<CHandle<physicsSystemBody>> Bodies { get; set; }
		[Ordinal(2)] [RED("joints")] public CArray<CHandle<physicsSystemJoint>> Joints { get; set; }

		public physicsSystemResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
