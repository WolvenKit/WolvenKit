using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SignInPopupController : gameuiBaseGOGProfileController
	{
		[Ordinal(2)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("qrImageWidgetRef")] 
		public inkImageWidgetReference QrImageWidgetRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<SignInPopupData> Data
		{
			get => GetPropertyValue<CHandle<SignInPopupData>>();
			set => SetPropertyValue<CHandle<SignInPopupData>>(value);
		}

		[Ordinal(8)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(9)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("signinUrl")] 
		public CString SigninUrl
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("signInQrCodeController")] 
		public CWeakHandle<SignInQrCodeController> SignInQrCodeController
		{
			get => GetPropertyValue<CWeakHandle<SignInQrCodeController>>();
			set => SetPropertyValue<CWeakHandle<SignInQrCodeController>>(value);
		}

		public SignInPopupController()
		{
			QrCodeContainerRef = new inkWidgetReference();
			QrImageWidgetRef = new inkImageWidgetReference();
			HyperlinkButtonRef = new inkWidgetReference();
			CloseButtonRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
