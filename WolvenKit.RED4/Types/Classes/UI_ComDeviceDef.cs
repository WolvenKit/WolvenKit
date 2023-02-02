using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ComDeviceDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("comDeviceSetStatusText")] 
		public gamebbScriptID_CName ComDeviceSetStatusText
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(1)] 
		[RED("openMessageRequest")] 
		public gamebbScriptID_Uint32 OpenMessageRequest
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(2)] 
		[RED("closeMessageRequest")] 
		public gamebbScriptID_Int32 CloseMessageRequest
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("showingMessage")] 
		public gamebbScriptID_Int32 ShowingMessage
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("PhoneCallInformation")] 
		public gamebbScriptID_Variant PhoneCallInformation
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("PhoneStyle_PlacidePhone")] 
		public gamebbScriptID_Bool PhoneStyle_PlacidePhone
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("PhoneStyle_VideoCallInterupt")] 
		public gamebbScriptID_Bool PhoneStyle_VideoCallInterupt
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("PhoneStyle_Minimized")] 
		public gamebbScriptID_Bool PhoneStyle_Minimized
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("isDisplayingMessage")] 
		public gamebbScriptID_Bool IsDisplayingMessage
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("ContactsActive")] 
		public gamebbScriptID_Bool ContactsActive
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_ComDeviceDef()
		{
			ComDeviceSetStatusText = new();
			OpenMessageRequest = new();
			CloseMessageRequest = new();
			ShowingMessage = new();
			PhoneCallInformation = new();
			PhoneStyle_PlacidePhone = new();
			PhoneStyle_VideoCallInterupt = new();
			PhoneStyle_Minimized = new();
			IsDisplayingMessage = new();
			ContactsActive = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
