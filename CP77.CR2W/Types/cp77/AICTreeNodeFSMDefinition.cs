using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeFSMDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)]  [RED("defaultState")] public CUInt16 DefaultState { get; set; }
		[Ordinal(1)]  [RED("transitions")] public CArray<AIFSMTransitionDefinition> Transitions { get; set; }
		[Ordinal(2)]  [RED("onEventTransitions")] public CArray<AIFSMEventTransitionsListDefinition> OnEventTransitions { get; set; }
		[Ordinal(3)]  [RED("states")] public CArray<AIFSMStateDefinition> States { get; set; }
		[Ordinal(4)]  [RED("sharedVars")] public AISharedVarTableDefinition SharedVars { get; set; }

		public AICTreeNodeFSMDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
