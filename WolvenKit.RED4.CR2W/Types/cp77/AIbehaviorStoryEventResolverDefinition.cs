using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _storyTier;

		[Ordinal(0)] 
		[RED("storyTier")] 
		public CHandle<AIArgumentMapping> StoryTier
		{
			get => GetProperty(ref _storyTier);
			set => SetProperty(ref _storyTier, value);
		}

		public AIbehaviorStoryEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
