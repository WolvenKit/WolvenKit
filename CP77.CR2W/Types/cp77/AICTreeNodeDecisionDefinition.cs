using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecisionDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)]  [RED("child")] public CHandle<LibTreeINodeDefinition> Child { get; set; }
		[Ordinal(1)]  [RED("expressions")] public CArray<CHandle<LibTreeINodeDefinition>> Expressions { get; set; }
		[Ordinal(2)]  [RED("interruption")] public AIInterruptionSignal Interruption { get; set; }

		public AICTreeNodeDecisionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
