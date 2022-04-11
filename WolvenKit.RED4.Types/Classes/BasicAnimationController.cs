using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasicAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("idleAnimation")] 
		public CName IdleAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("animationPlayer")] 
		public CHandle<AnimationChainPlayer> AnimationPlayer
		{
			get => GetPropertyValue<CHandle<AnimationChainPlayer>>();
			set => SetPropertyValue<CHandle<AnimationChainPlayer>>(value);
		}

		[Ordinal(5)] 
		[RED("currentAnimation")] 
		public CName CurrentAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BasicAnimationController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
