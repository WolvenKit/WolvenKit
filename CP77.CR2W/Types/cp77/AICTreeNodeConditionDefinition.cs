using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeConditionDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)]  [RED("expressions")] public CArray<CHandle<LibTreeINodeDefinition>> Expressions { get; set; }
		[Ordinal(1)]  [RED("falseBranch")] public CHandle<LibTreeINodeDefinition> FalseBranch { get; set; }
		[Ordinal(2)]  [RED("reevaluateOnExecution")] public CBool ReevaluateOnExecution { get; set; }
		[Ordinal(3)]  [RED("trueBranch")] public CHandle<LibTreeINodeDefinition> TrueBranch { get; set; }

		public AICTreeNodeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
