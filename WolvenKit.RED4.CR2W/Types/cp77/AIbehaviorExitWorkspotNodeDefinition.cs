using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExitWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("skipExitAnimation")] public CHandle<AIArgumentMapping> SkipExitAnimation { get; set; }
		[Ordinal(2)] [RED("useSlowExitAnimation")] public CHandle<AIArgumentMapping> UseSlowExitAnimation { get; set; }
		[Ordinal(3)] [RED("doSlowIfFastExitFails")] public CHandle<AIArgumentMapping> DoSlowIfFastExitFails { get; set; }
		[Ordinal(4)] [RED("stayInWorkspotIfExitFails")] public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails { get; set; }
		[Ordinal(5)] [RED("tryBlendFastExitToWalk")] public CHandle<AIArgumentMapping> TryBlendFastExitToWalk { get; set; }
		[Ordinal(6)] [RED("dontRequestExit")] public CHandle<AIArgumentMapping> DontRequestExit { get; set; }
		[Ordinal(7)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public AIbehaviorExitWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
