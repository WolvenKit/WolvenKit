using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(4)] [RED("worldPosition")] public CHandle<AIArgumentMapping> WorldPosition { get; set; }
		[Ordinal(5)] [RED("useMovePlanner")] public CBool UseMovePlanner { get; set; }

		public AIbehaviorActionSlideToWorldPositionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
