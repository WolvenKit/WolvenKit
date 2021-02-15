using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] [RED("storyTier")] public CHandle<AIArgumentMapping> StoryTier { get; set; }

		public AIbehaviorStoryEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
