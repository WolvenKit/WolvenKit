using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryItemName")] 
		public CName WidgetLibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("widgetLibraryResource")] 
		public redResourceReferenceScriptToken WidgetLibraryResource
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(4)] 
		[RED("notificationData")] 
		public CHandle<gameuiGenericNotificationViewData> NotificationData
		{
			get => GetPropertyValue<CHandle<gameuiGenericNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiGenericNotificationViewData>>(value);
		}

		public gameuiGenericNotificationData()
		{
			WidgetLibraryResource = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
