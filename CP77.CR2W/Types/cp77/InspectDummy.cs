using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InspectDummy : gameObject
	{
		[Ordinal(31)]  [RED("mesh")] public CHandle<entPhysicalMeshComponent> Mesh { get; set; }
		[Ordinal(32)]  [RED("choice")] public CHandle<gameinteractionsComponent> Choice { get; set; }
		[Ordinal(33)]  [RED("inspectComp")] public CHandle<InspectableObjectComponent> InspectComp { get; set; }

		public InspectDummy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
