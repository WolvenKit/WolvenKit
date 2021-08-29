using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicAnimationController : inkWidgetLogicController
	{
		private CName _showAnimation;
		private CName _idleAnimation;
		private CName _hideAnimation;
		private CHandle<AnimationChainPlayer> _animationPlayer;
		private CName _currentAnimation;

		[Ordinal(1)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get => GetProperty(ref _showAnimation);
			set => SetProperty(ref _showAnimation, value);
		}

		[Ordinal(2)] 
		[RED("idleAnimation")] 
		public CName IdleAnimation
		{
			get => GetProperty(ref _idleAnimation);
			set => SetProperty(ref _idleAnimation, value);
		}

		[Ordinal(3)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get => GetProperty(ref _hideAnimation);
			set => SetProperty(ref _hideAnimation, value);
		}

		[Ordinal(4)] 
		[RED("animationPlayer")] 
		public CHandle<AnimationChainPlayer> AnimationPlayer
		{
			get => GetProperty(ref _animationPlayer);
			set => SetProperty(ref _animationPlayer, value);
		}

		[Ordinal(5)] 
		[RED("currentAnimation")] 
		public CName CurrentAnimation
		{
			get => GetProperty(ref _currentAnimation);
			set => SetProperty(ref _currentAnimation, value);
		}
	}
}
