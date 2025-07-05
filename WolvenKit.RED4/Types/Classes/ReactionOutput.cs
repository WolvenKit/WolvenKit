using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReactionOutput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reactionBehavior")] 
		public CEnum<gamedataOutput> ReactionBehavior
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(1)] 
		[RED("reactionPriority")] 
		public CInt32 ReactionPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("AIbehaviorPriority")] 
		public CFloat AIbehaviorPriority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("reactionCooldown")] 
		public CFloat ReactionCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("startedInWorkspot")] 
		public CBool StartedInWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("workspotReaction")] 
		public CBool WorkspotReaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("workspotReactionType")] 
		public CName WorkspotReactionType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ReactionOutput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
