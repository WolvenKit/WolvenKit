using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InspectDummy : gameObject
	{
		[Ordinal(40)] [RED("mesh")] public CHandle<entPhysicalMeshComponent> Mesh { get; set; }
		[Ordinal(41)] [RED("choice")] public CHandle<gameinteractionsComponent> Choice { get; set; }
		[Ordinal(42)] [RED("inspectComp")] public CHandle<InspectableObjectComponent> InspectComp { get; set; }

		public InspectDummy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
