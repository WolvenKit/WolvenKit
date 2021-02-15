using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtApplyVehicleRestrictions : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("group")] public CName Group { get; set; }
		[Ordinal(3)] [RED("name")] public CName Name { get; set; }
		[Ordinal(4)] [RED("referenceBone")] public animTransformIndex ReferenceBone { get; set; }

		public animAnimNode_LookAtApplyVehicleRestrictions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
