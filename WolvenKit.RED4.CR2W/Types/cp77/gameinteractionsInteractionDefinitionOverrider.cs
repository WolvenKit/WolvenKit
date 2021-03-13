using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionDefinitionOverrider : CVariable
	{
		[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(1)] [RED("shapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes { get; set; }
		[Ordinal(2)] [RED("negativeShapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes { get; set; }
		[Ordinal(3)] [RED("priorityMultiplier")] public CFloat PriorityMultiplier { get; set; }

		public gameinteractionsInteractionDefinitionOverrider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
