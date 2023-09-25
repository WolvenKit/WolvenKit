using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHUDCyberwareInfoGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("activatePopupAnimName")] 
		public CName ActivatePopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("deactivatePopupAnimName")] 
		public CName DeactivatePopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("activateAnimName")] 
		public CName ActivateAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("deactivateAnimName")] 
		public CName DeactivateAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("hudElement")] 
		public inkWidgetReference HudElement
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("isCyberwareDeactivated")] 
		public CBool IsCyberwareDeactivated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("popupAnimProxy")] 
		public CHandle<inkanimProxy> PopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiHUDCyberwareInfoGameController()
		{
			ActivatePopupAnimName = "cw_reactivated_popup";
			DeactivatePopupAnimName = "cw_deactivated_popup";
			ActivateAnimName = "hud_addon_outro";
			DeactivateAnimName = "hud_addon_intro";
			Fact = "q306_cyberware_deactivated";
			HudElement = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
