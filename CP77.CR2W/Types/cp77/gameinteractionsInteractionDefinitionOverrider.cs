using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionDefinitionOverrider : CVariable
	{
		[Ordinal(0)]  [RED("negativeShapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes { get; set; }
		[Ordinal(1)]  [RED("priorityMultiplier")] public CFloat PriorityMultiplier { get; set; }
		[Ordinal(2)]  [RED("shapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes { get; set; }
		[Ordinal(3)]  [RED("tag")] public CName Tag { get; set; }

		public gameinteractionsInteractionDefinitionOverrider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
