using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorComparisonExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)]  [RED("leftHandSide")] public CHandle<AIbehaviorExpressionSocket> LeftHandSide { get; set; }
		[Ordinal(1)]  [RED("operator")] public CEnum<EComparisonType> Operator { get; set; }
		[Ordinal(2)]  [RED("rightHandSide")] public CHandle<AIbehaviorExpressionSocket> RightHandSide { get; set; }

		public AIbehaviorComparisonExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
