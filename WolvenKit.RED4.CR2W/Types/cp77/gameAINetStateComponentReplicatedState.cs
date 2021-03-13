using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAINetStateComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("replHighLevelState")] public gameNetAIState ReplHighLevelState { get; set; }
		[Ordinal(3)] [RED("replUpperBodyState")] public gameNetAIState ReplUpperBodyState { get; set; }
		[Ordinal(4)] [RED("replStanceState")] public gameNetAIState ReplStanceState { get; set; }
		[Ordinal(5)] [RED("replHitReactionModeState")] public gameNetAIState ReplHitReactionModeState { get; set; }
		[Ordinal(6)] [RED("replBehaviorState")] public gameNetAIState ReplBehaviorState { get; set; }
		[Ordinal(7)] [RED("replPhaseState")] public gameNetAIState ReplPhaseState { get; set; }
		[Ordinal(8)] [RED("replDefenseMode")] public gameNetAIState ReplDefenseMode { get; set; }
		[Ordinal(9)] [RED("replLocomotionMode")] public gameNetAIState ReplLocomotionMode { get; set; }

		public gameAINetStateComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
