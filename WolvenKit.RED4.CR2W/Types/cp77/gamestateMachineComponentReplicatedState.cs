using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("stateContext")] public gamestateMachineStateContext StateContext { get; set; }
		[Ordinal(3)] [RED("enterLadderParameter")] public CHandle<gamestateMachineparameterTypeLadderDescription> EnterLadderParameter { get; set; }
		[Ordinal(4)] [RED("exitLadderParameter")] public CBool ExitLadderParameter { get; set; }

		public gamestateMachineComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
