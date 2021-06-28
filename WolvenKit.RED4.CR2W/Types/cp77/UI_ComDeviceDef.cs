using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ComDeviceDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _comDeviceSetStatusText;
		private gamebbScriptID_Uint32 _openMessageRequest;
		private gamebbScriptID_Int32 _closeMessageRequest;
		private gamebbScriptID_Int32 _showingMessage;
		private gamebbScriptID_Variant _phoneCallInformation;
		private gamebbScriptID_Bool _phoneStyle_PlacidePhone;
		private gamebbScriptID_Bool _phoneStyle_VideoCallInterupt;
		private gamebbScriptID_Bool _phoneStyle_Minimized;
		private gamebbScriptID_Bool _isDisplayingMessage;
		private gamebbScriptID_Bool _contactsActive;

		[Ordinal(0)] 
		[RED("comDeviceSetStatusText")] 
		public gamebbScriptID_CName ComDeviceSetStatusText
		{
			get => GetProperty(ref _comDeviceSetStatusText);
			set => SetProperty(ref _comDeviceSetStatusText, value);
		}

		[Ordinal(1)] 
		[RED("openMessageRequest")] 
		public gamebbScriptID_Uint32 OpenMessageRequest
		{
			get => GetProperty(ref _openMessageRequest);
			set => SetProperty(ref _openMessageRequest, value);
		}

		[Ordinal(2)] 
		[RED("closeMessageRequest")] 
		public gamebbScriptID_Int32 CloseMessageRequest
		{
			get => GetProperty(ref _closeMessageRequest);
			set => SetProperty(ref _closeMessageRequest, value);
		}

		[Ordinal(3)] 
		[RED("showingMessage")] 
		public gamebbScriptID_Int32 ShowingMessage
		{
			get => GetProperty(ref _showingMessage);
			set => SetProperty(ref _showingMessage, value);
		}

		[Ordinal(4)] 
		[RED("PhoneCallInformation")] 
		public gamebbScriptID_Variant PhoneCallInformation
		{
			get => GetProperty(ref _phoneCallInformation);
			set => SetProperty(ref _phoneCallInformation, value);
		}

		[Ordinal(5)] 
		[RED("PhoneStyle_PlacidePhone")] 
		public gamebbScriptID_Bool PhoneStyle_PlacidePhone
		{
			get => GetProperty(ref _phoneStyle_PlacidePhone);
			set => SetProperty(ref _phoneStyle_PlacidePhone, value);
		}

		[Ordinal(6)] 
		[RED("PhoneStyle_VideoCallInterupt")] 
		public gamebbScriptID_Bool PhoneStyle_VideoCallInterupt
		{
			get => GetProperty(ref _phoneStyle_VideoCallInterupt);
			set => SetProperty(ref _phoneStyle_VideoCallInterupt, value);
		}

		[Ordinal(7)] 
		[RED("PhoneStyle_Minimized")] 
		public gamebbScriptID_Bool PhoneStyle_Minimized
		{
			get => GetProperty(ref _phoneStyle_Minimized);
			set => SetProperty(ref _phoneStyle_Minimized, value);
		}

		[Ordinal(8)] 
		[RED("isDisplayingMessage")] 
		public gamebbScriptID_Bool IsDisplayingMessage
		{
			get => GetProperty(ref _isDisplayingMessage);
			set => SetProperty(ref _isDisplayingMessage, value);
		}

		[Ordinal(9)] 
		[RED("ContactsActive")] 
		public gamebbScriptID_Bool ContactsActive
		{
			get => GetProperty(ref _contactsActive);
			set => SetProperty(ref _contactsActive, value);
		}

		public UI_ComDeviceDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
