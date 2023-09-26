using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InnerAdminPanelScreenGameController : BaseInnerBunkerComputerGameController
	{
		[Ordinal(2)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("buttonAnimName", 3)] 
		public CArrayFixedSize<CName> ButtonAnimName
		{
			get => GetPropertyValue<CArrayFixedSize<CName>>();
			set => SetPropertyValue<CArrayFixedSize<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("commandAnimName", 3)] 
		public CArrayFixedSize<CName> CommandAnimName
		{
			get => GetPropertyValue<CArrayFixedSize<CName>>();
			set => SetPropertyValue<CArrayFixedSize<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("successAnimName", 3)] 
		public CArrayFixedSize<CName> SuccessAnimName
		{
			get => GetPropertyValue<CArrayFixedSize<CName>>();
			set => SetPropertyValue<CArrayFixedSize<CName>>(value);
		}

		[Ordinal(7)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("attemptAnimName")] 
		public CName AttemptAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("instantAttemptAnimName")] 
		public CName InstantAttemptAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("instantAttemptPopupAnimName")] 
		public CName InstantAttemptPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("subsystemIndex")] 
		public CInt32 SubsystemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("animProxyFull1")] 
		public CHandle<inkanimProxy> AnimProxyFull1
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("animProxyFull2")] 
		public CHandle<inkanimProxy> AnimProxyFull2
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("animProxySuccess")] 
		public CHandle<inkanimProxy> AnimProxySuccess
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("animProxySuccessPopup")] 
		public CHandle<inkanimProxy> AnimProxySuccessPopup
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("animProxyAttempt")] 
		public CHandle<inkanimProxy> AnimProxyAttempt
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("animProxyAttemptPopup")] 
		public CHandle<inkanimProxy> AnimProxyAttemptPopup
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("zoomUICallbackHandle")] 
		public CHandle<redCallbackObject> ZoomUICallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("isUIZoomDevice")] 
		public CBool IsUIZoomDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InnerAdminPanelScreenGameController()
		{
			IntroAnimName = "intro";
			LoopAnimName = "code_loop";
			ButtonAnimName = new(3);
			CommandAnimName = new(3);
			SuccessAnimName = new(3);
			SuccessPopupAnimName = "popup_01_success";
			AttemptAnimName = "datafort_command_animation_loop";
			InstantAttemptAnimName = "datafort_command_instant_loop";
			InstantAttemptPopupAnimName = "popup_03_datafort_instant_loop";
			ShutdownButton = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
