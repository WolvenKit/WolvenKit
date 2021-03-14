using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStoryTierConditionDefinition : AIbehaviorConditionDefinition
	{
		private CEnum<gameStoryTier> _tier;
		private CHandle<AIArgumentMapping> _storyTier;

		[Ordinal(1)] 
		[RED("tier")] 
		public CEnum<gameStoryTier> Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (CEnum<gameStoryTier>) CR2WTypeManager.Create("gameStoryTier", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public AIbehaviorStoryTierConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
