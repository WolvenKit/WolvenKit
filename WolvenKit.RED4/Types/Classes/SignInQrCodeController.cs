using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SignInQrCodeController : gameuiBaseGOGRegisterController
	{
		[Ordinal(1)] 
		[RED("qrImageWidgetRef")] 
		public inkImageWidgetReference QrImageWidgetRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public CWeakHandle<inkImageWidget> QrImageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		public SignInQrCodeController()
		{
			QrImageWidgetRef = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
