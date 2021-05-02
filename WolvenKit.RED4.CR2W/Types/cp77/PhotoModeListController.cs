using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeListController : inkListController
	{
		private inkWidgetReference _logoWidget;
		private inkVerticalPanelWidgetReference _panel;
		private CHandle<inkanimProxy> _fadeAnim;
		private CBool _isAnimating;
		private CFloat _animationTime;
		private CFloat _animationTarget;
		private CFloat _elementsAnimationTime;
		private CFloat _elementsAnimationDelay;
		private CInt32 _currentElementAnimation;

		[Ordinal(6)] 
		[RED("LogoWidget")] 
		public inkWidgetReference LogoWidget
		{
			get => GetProperty(ref _logoWidget);
			set => SetProperty(ref _logoWidget, value);
		}

		[Ordinal(7)] 
		[RED("Panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetProperty(ref _panel);
			set => SetProperty(ref _panel, value);
		}

		[Ordinal(8)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetProperty(ref _fadeAnim);
			set => SetProperty(ref _fadeAnim, value);
		}

		[Ordinal(9)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetProperty(ref _isAnimating);
			set => SetProperty(ref _isAnimating, value);
		}

		[Ordinal(10)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		[Ordinal(11)] 
		[RED("animationTarget")] 
		public CFloat AnimationTarget
		{
			get => GetProperty(ref _animationTarget);
			set => SetProperty(ref _animationTarget, value);
		}

		[Ordinal(12)] 
		[RED("elementsAnimationTime")] 
		public CFloat ElementsAnimationTime
		{
			get => GetProperty(ref _elementsAnimationTime);
			set => SetProperty(ref _elementsAnimationTime, value);
		}

		[Ordinal(13)] 
		[RED("elementsAnimationDelay")] 
		public CFloat ElementsAnimationDelay
		{
			get => GetProperty(ref _elementsAnimationDelay);
			set => SetProperty(ref _elementsAnimationDelay, value);
		}

		[Ordinal(14)] 
		[RED("currentElementAnimation")] 
		public CInt32 CurrentElementAnimation
		{
			get => GetProperty(ref _currentElementAnimation);
			set => SetProperty(ref _currentElementAnimation, value);
		}

		public PhotoModeListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
