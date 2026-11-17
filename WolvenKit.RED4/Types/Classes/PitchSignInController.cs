using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PitchSignInController : gameuiBaseGOGProfileController
	{
		[Ordinal(2)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hyperlinkRef")] 
		public inkTextWidgetReference HyperlinkRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<PitchSignInPopupData> Data
		{
			get => GetPropertyValue<CHandle<PitchSignInPopupData>>();
			set => SetPropertyValue<CHandle<PitchSignInPopupData>>(value);
		}

		[Ordinal(6)] 
		[RED("signInQrCodeController")] 
		public CWeakHandle<SignInQrCodeController> SignInQrCodeController
		{
			get => GetPropertyValue<CWeakHandle<SignInQrCodeController>>();
			set => SetPropertyValue<CWeakHandle<SignInQrCodeController>>(value);
		}

		[Ordinal(7)] 
		[RED("signinUrl")] 
		public CString SigninUrl
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PitchSignInController()
		{
			QrCodeContainerRef = new inkWidgetReference();
			HyperlinkRef = new inkTextWidgetReference();
			HyperlinkButtonRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
