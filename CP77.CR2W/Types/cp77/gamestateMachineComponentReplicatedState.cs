using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("enterLadderParameter")] public CHandle<gamestateMachineparameterTypeLadderDescription> EnterLadderParameter { get; set; }
		[Ordinal(1)]  [RED("exitLadderParameter")] public CBool ExitLadderParameter { get; set; }
		[Ordinal(2)]  [RED("stateContext")] public gamestateMachineStateContext StateContext { get; set; }

		public gamestateMachineComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
