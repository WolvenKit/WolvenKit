using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHUDGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("showAnimDef")] 
		public CHandle<inkanimDefinition> ShowAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("hideAnimDef")] 
		public CHandle<inkanimDefinition> HideAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("moduleShown")] 
		public CBool ModuleShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("hideAnimProxy")] 
		public CHandle<inkanimProxy> HideAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiHUDGameController()
		{
			ShowAnimationName = "unfold";
			HideAnimationName = "fold";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
