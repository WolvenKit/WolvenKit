using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InnerSubsystemScreenGameController : BaseInnerBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("loopAnimName", 3)] 
		public CArrayFixedSize<CName> LoopAnimName
		{
			get => GetPropertyValue<CArrayFixedSize<CName>>();
			set => SetPropertyValue<CArrayFixedSize<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("adminAccessPopupAnimName")] 
		public CName AdminAccessPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("unrecognizedPopupAnimName")] 
		public CName UnrecognizedPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("preAuthorizingPopupAnimName")] 
		public CName PreAuthorizingPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("postAuthorizingPopupAnimName")] 
		public CName PostAuthorizingPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("deniedPopupAnimName")] 
		public CName DeniedPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("errorPopupAnimName")] 
		public CName ErrorPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("icePopupAnimName")] 
		public CName IcePopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("shutdownButton", 3)] 
		public CArrayFixedSize<inkWidgetReference> ShutdownButton
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("adminPanelButton", 3)] 
		public CArrayFixedSize<inkWidgetReference> AdminPanelButton
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(13)] 
		[RED("adminPanelPopupButton")] 
		public inkWidgetReference AdminPanelPopupButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("transitionToAuthorization")] 
		public inkWidgetReference TransitionToAuthorization
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("transitionToMinigame")] 
		public inkWidgetReference TransitionToMinigame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("transitionToAdminPanel")] 
		public inkWidgetReference TransitionToAdminPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("subsystemIndex")] 
		public CInt32 SubsystemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("adminAccessPopupAnimProxy")] 
		public CHandle<inkanimProxy> AdminAccessPopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("successPopupAnimProxy")] 
		public CHandle<inkanimProxy> SuccessPopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("errorPopupAnimProxy")] 
		public CHandle<inkanimProxy> ErrorPopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public InnerSubsystemScreenGameController()
		{
			LoopAnimName = new(3);
			AdminAccessPopupAnimName = "popup_00_admin_access";
			UnrecognizedPopupAnimName = "popup_01_unrecognized";
			PreAuthorizingPopupAnimName = "popup_02_authorizing_01";
			PostAuthorizingPopupAnimName = "popup_02_authorizing_02";
			DeniedPopupAnimName = "popup_03_denied";
			SuccessPopupAnimName = "popup_04_success";
			ErrorPopupAnimName = "popup_05_error";
			IcePopupAnimName = "popup_06_ice";
			ShutdownButton = new(3);
			AdminPanelButton = new(3);
			AdminPanelPopupButton = new inkWidgetReference();
			TransitionToAuthorization = new inkWidgetReference();
			TransitionToMinigame = new inkWidgetReference();
			TransitionToAdminPanel = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
