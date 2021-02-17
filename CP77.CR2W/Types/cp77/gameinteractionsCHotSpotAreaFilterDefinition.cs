using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotAreaFilterDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("transform")] public Transform Transform { get; set; }
		[Ordinal(2)] [RED("functor")] public CHandle<gameinteractionsCFunctorDefinition> Functor { get; set; }
		[Ordinal(3)] [RED("shapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes { get; set; }
		[Ordinal(4)] [RED("negativeShapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes { get; set; }

		public gameinteractionsCHotSpotAreaFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
