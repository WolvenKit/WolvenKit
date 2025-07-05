using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SignInPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<SignInPopupData> Data
		{
			get => GetPropertyValue<CHandle<SignInPopupData>>();
			set => SetPropertyValue<CHandle<SignInPopupData>>(value);
		}

		[Ordinal(7)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(8)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public SignInPopupController()
		{
			QrCodeContainerRef = new inkWidgetReference();
			HyperlinkButtonRef = new inkWidgetReference();
			CloseButtonRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
