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
			get
			{
				if (_storyTier == null)
				{
					_storyTier = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "storyTier", cr2w, this);
				}
				return _storyTier;
			}
			set
			{
				if (_storyTier == value)
				{
					return;
				}
				_storyTier = value;
				PropertySet(this);
			}
		}

		public AIbehaviorStoryEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
