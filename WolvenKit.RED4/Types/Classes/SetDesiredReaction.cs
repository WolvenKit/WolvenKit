using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDesiredReaction : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("behaviorArgumentNameTag")] 
		public CName BehaviorArgumentNameTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("behaviorArgumentFloatPriority")] 
		public CName BehaviorArgumentFloatPriority
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("behaviorArgumentNameFlag")] 
		public CName BehaviorArgumentNameFlag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		public SetDesiredReaction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
