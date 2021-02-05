using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationComponent : entSlotComponent
	{
		[Ordinal(0)]  [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }
		[Ordinal(1)]  [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(2)]  [RED("bvhRoot")] public gameHitShapeBVH BvhRoot { get; set; }
		[Ordinal(3)]  [RED("useResourceData")] public CBool UseResourceData { get; set; }
		[Ordinal(4)]  [RED("resource")] public raRef<gameHitRepresentationResource> Resource { get; set; }
		[Ordinal(5)]  [RED("appearanceOverrides")] public CArray<gameHitRepresentationOverride> AppearanceOverrides { get; set; }

		public gameHitRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
