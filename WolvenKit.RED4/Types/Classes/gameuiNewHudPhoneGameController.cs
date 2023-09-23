using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiNewHudPhoneGameController : gameuiGenericNotificationGameController
	{
		[Ordinal(4)] 
		[RED("holoAudioCallElement")] 
		public gameuiLocalPhoneElement HoloAudioCallElement
		{
			get => GetPropertyValue<gameuiLocalPhoneElement>();
			set => SetPropertyValue<gameuiLocalPhoneElement>(value);
		}

		[Ordinal(5)] 
		[RED("incomingCallElement")] 
		public gameuiLocalPhoneElement IncomingCallElement
		{
			get => GetPropertyValue<gameuiLocalPhoneElement>();
			set => SetPropertyValue<gameuiLocalPhoneElement>(value);
		}

		[Ordinal(6)] 
		[RED("contactsElement")] 
		public gameuiLocalPhoneElement ContactsElement
		{
			get => GetPropertyValue<gameuiLocalPhoneElement>();
			set => SetPropertyValue<gameuiLocalPhoneElement>(value);
		}

		[Ordinal(7)] 
		[RED("smsMessengerElement")] 
		public gameuiExternalPhoneElement SmsMessengerElement
		{
			get => GetPropertyValue<gameuiExternalPhoneElement>();
			set => SetPropertyValue<gameuiExternalPhoneElement>(value);
		}

		[Ordinal(8)] 
		[RED("notificationsElement")] 
		public gameuiPhoneElementVisibility NotificationsElement
		{
			get => GetPropertyValue<gameuiPhoneElementVisibility>();
			set => SetPropertyValue<gameuiPhoneElementVisibility>(value);
		}

		[Ordinal(9)] 
		[RED("phoneIconElement")] 
		public gameuiLocalPhoneElement PhoneIconElement
		{
			get => GetPropertyValue<gameuiLocalPhoneElement>();
			set => SetPropertyValue<gameuiLocalPhoneElement>(value);
		}

		[Ordinal(10)] 
		[RED("resolutionSensitiveWidgets")] 
		public CArray<gameuiResolutionSensitiveWidget> ResolutionSensitiveWidgets
		{
			get => GetPropertyValue<CArray<gameuiResolutionSensitiveWidget>>();
			set => SetPropertyValue<CArray<gameuiResolutionSensitiveWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("phoneIconMarker")] 
		public inkWidgetReference PhoneIconMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiNewHudPhoneGameController()
		{
			HoloAudioCallElement = new gameuiLocalPhoneElement();
			IncomingCallElement = new gameuiLocalPhoneElement();
			ContactsElement = new gameuiLocalPhoneElement();
			SmsMessengerElement = new gameuiExternalPhoneElement();
			NotificationsElement = new gameuiPhoneElementVisibility { Slot = new inkCompoundWidgetReference() };
			PhoneIconElement = new gameuiLocalPhoneElement();
			ResolutionSensitiveWidgets = new();
			PhoneIconMarker = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
