using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialOverlayLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("showAnimation")] 
		public CName ShowAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("hideAnimation")] 
		public CName HideAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("tutorialManager")] 
		public CWeakHandle<questTutorialManager> TutorialManager
		{
			get => GetPropertyValue<CWeakHandle<questTutorialManager>>();
			set => SetPropertyValue<CWeakHandle<questTutorialManager>>(value);
		}

		public gameuiTutorialOverlayLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
