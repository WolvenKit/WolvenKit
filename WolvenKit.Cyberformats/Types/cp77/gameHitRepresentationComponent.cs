using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationComponent : entSlotComponent
	{
		[Ordinal(7)] [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }
		[Ordinal(8)] [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(9)] [RED("bvhRoot")] public gameHitShapeBVH BvhRoot { get; set; }
		[Ordinal(10)] [RED("useResourceData")] public CBool UseResourceData { get; set; }
		[Ordinal(11)] [RED("resource")] public raRef<gameHitRepresentationResource> Resource { get; set; }
		[Ordinal(12)] [RED("appearanceOverrides")] public CArray<gameHitRepresentationOverride> AppearanceOverrides { get; set; }

		public gameHitRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
