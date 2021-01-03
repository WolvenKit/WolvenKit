using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationComponent : entSlotComponent
	{
		[Ordinal(0)]  [RED("appearanceOverrides")] public CArray<gameHitRepresentationOverride> AppearanceOverrides { get; set; }
		[Ordinal(1)]  [RED("bvhRoot")] public gameHitShapeBVH BvhRoot { get; set; }
		[Ordinal(2)]  [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(3)]  [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }
		[Ordinal(4)]  [RED("resource")] public raRef<gameHitRepresentationResource> Resource { get; set; }
		[Ordinal(5)]  [RED("useResourceData")] public CBool UseResourceData { get; set; }

		public gameHitRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
