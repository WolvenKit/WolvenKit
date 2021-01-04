using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(0)]  [RED("useMovePlanner")] public CBool UseMovePlanner { get; set; }
		[Ordinal(1)]  [RED("worldPosition")] public CHandle<AIArgumentMapping> WorldPosition { get; set; }

		public AIbehaviorActionSlideToWorldPositionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
