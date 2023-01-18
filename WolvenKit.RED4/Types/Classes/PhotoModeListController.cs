using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeListController : inkListController
	{
		[Ordinal(6)] 
		[RED("LogoWidget")] 
		public inkWidgetReference LogoWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("Panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(9)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("animationTarget")] 
		public CFloat AnimationTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("elementsAnimationTime")] 
		public CFloat ElementsAnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("elementsAnimationDelay")] 
		public CFloat ElementsAnimationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("currentElementAnimation")] 
		public CInt32 CurrentElementAnimation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PhotoModeListController()
		{
			LogoWidget = new();
			Panel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
