using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeFSMDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)]  [RED("defaultState")] public CUInt16 DefaultState { get; set; }
		[Ordinal(1)]  [RED("onEventTransitions")] public CArray<AIFSMEventTransitionsListDefinition> OnEventTransitions { get; set; }
		[Ordinal(2)]  [RED("sharedVars")] public AISharedVarTableDefinition SharedVars { get; set; }
		[Ordinal(3)]  [RED("states")] public CArray<AIFSMStateDefinition> States { get; set; }
		[Ordinal(4)]  [RED("transitions")] public CArray<AIFSMTransitionDefinition> Transitions { get; set; }

		public AICTreeNodeFSMDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
