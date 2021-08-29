using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactionOutput : RedBaseClass
	{
		private CEnum<gamedataOutput> _reactionBehavior;
		private CInt32 _reactionPriority;
		private CFloat _aIbehaviorPriority;
		private CFloat _reactionCooldown;
		private CBool _startedInWorkspot;
		private CBool _workspotReaction;
		private CName _workspotReactionType;

		[Ordinal(0)] 
		[RED("reactionBehavior")] 
		public CEnum<gamedataOutput> ReactionBehavior
		{
			get => GetProperty(ref _reactionBehavior);
			set => SetProperty(ref _reactionBehavior, value);
		}

		[Ordinal(1)] 
		[RED("reactionPriority")] 
		public CInt32 ReactionPriority
		{
			get => GetProperty(ref _reactionPriority);
			set => SetProperty(ref _reactionPriority, value);
		}

		[Ordinal(2)] 
		[RED("AIbehaviorPriority")] 
		public CFloat AIbehaviorPriority
		{
			get => GetProperty(ref _aIbehaviorPriority);
			set => SetProperty(ref _aIbehaviorPriority, value);
		}

		[Ordinal(3)] 
		[RED("reactionCooldown")] 
		public CFloat ReactionCooldown
		{
			get => GetProperty(ref _reactionCooldown);
			set => SetProperty(ref _reactionCooldown, value);
		}

		[Ordinal(4)] 
		[RED("startedInWorkspot")] 
		public CBool StartedInWorkspot
		{
			get => GetProperty(ref _startedInWorkspot);
			set => SetProperty(ref _startedInWorkspot, value);
		}

		[Ordinal(5)] 
		[RED("workspotReaction")] 
		public CBool WorkspotReaction
		{
			get => GetProperty(ref _workspotReaction);
			set => SetProperty(ref _workspotReaction, value);
		}

		[Ordinal(6)] 
		[RED("workspotReactionType")] 
		public CName WorkspotReactionType
		{
			get => GetProperty(ref _workspotReactionType);
			set => SetProperty(ref _workspotReactionType, value);
		}
	}
}
