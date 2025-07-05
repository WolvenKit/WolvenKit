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
		[RED("hudScalingSensitiveWidgets")] 
		public CArray<gameuiHudScalingSensitiveWidget> HudScalingSensitiveWidgets
		{
			get => GetPropertyValue<CArray<gameuiHudScalingSensitiveWidget>>();
			set => SetPropertyValue<CArray<gameuiHudScalingSensitiveWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("phoneIconMarker")] 
		public inkWidgetReference PhoneIconMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("phoneIconVehicleMarker")] 
		public inkWidgetReference PhoneIconVehicleMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("callMarker")] 
		public inkWidgetReference CallMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("contactsMarker")] 
		public inkWidgetReference ContactsMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("notificationMarker")] 
		public inkWidgetReference NotificationMarker
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
			HudScalingSensitiveWidgets = new();
			PhoneIconMarker = new inkWidgetReference();
			PhoneIconVehicleMarker = new inkWidgetReference();
			CallMarker = new inkWidgetReference();
			ContactsMarker = new inkWidgetReference();
			NotificationMarker = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
