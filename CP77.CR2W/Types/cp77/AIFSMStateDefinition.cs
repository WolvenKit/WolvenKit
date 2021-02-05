using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFSMStateDefinition : CVariable
	{
		[Ordinal(0)]  [RED("onUpdateTransition")] public AIFSMTransitionListDefinition OnUpdateTransition { get; set; }
		[Ordinal(1)]  [RED("onCompleteTransition")] public AIFSMTransitionListDefinition OnCompleteTransition { get; set; }
		[Ordinal(2)]  [RED("onSuccessTransition")] public AIFSMTransitionListDefinition OnSuccessTransition { get; set; }
		[Ordinal(3)]  [RED("onFailureTransition")] public AIFSMTransitionListDefinition OnFailureTransition { get; set; }
		[Ordinal(4)]  [RED("onInterruptionTransition")] public AIFSMTransitionListDefinition OnInterruptionTransition { get; set; }
		[Ordinal(5)]  [RED("onEventTransitions")] public AIFSMTransitionListDefinition OnEventTransitions { get; set; }
		[Ordinal(6)]  [RED("childNode")] public CHandle<AICTreeNodeDefinition> ChildNode { get; set; }

		public AIFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
