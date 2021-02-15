using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("delegateAttribute")] public AIbehaviorDelegateAttrRef DelegateAttribute { get; set; }
		[Ordinal(1)] [RED("behaviorCallbackNames")] public CArray<CName> BehaviorCallbackNames { get; set; }

		public AIbehaviorDelegateExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
