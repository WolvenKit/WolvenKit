using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
		[Ordinal(1)]  [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(2)]  [RED("rotateTowardsMovementDirection")] public CHandle<AIArgumentMapping> RotateTowardsMovementDirection { get; set; }

		public AIbehaviorActionSlideNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
