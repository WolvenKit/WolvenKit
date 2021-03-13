using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtApplyVehicleRestrictions : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("group")] public CName Group { get; set; }
		[Ordinal(13)] [RED("name")] public CName Name { get; set; }
		[Ordinal(14)] [RED("referenceBone")] public animTransformIndex ReferenceBone { get; set; }

		public animAnimNode_LookAtApplyVehicleRestrictions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
