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
			get
			{
				if (_comDeviceSetStatusText == null)
				{
					_comDeviceSetStatusText = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "comDeviceSetStatusText", cr2w, this);
				}
				return _comDeviceSetStatusText;
			}
			set
			{
				if (_comDeviceSetStatusText == value)
				{
					return;
				}
				_comDeviceSetStatusText = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("openMessageRequest")] 
		public gamebbScriptID_Uint32 OpenMessageRequest
		{
			get
			{
				if (_openMessageRequest == null)
				{
					_openMessageRequest = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "openMessageRequest", cr2w, this);
				}
				return _openMessageRequest;
			}
			set
			{
				if (_openMessageRequest == value)
				{
					return;
				}
				_openMessageRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("closeMessageRequest")] 
		public gamebbScriptID_Int32 CloseMessageRequest
		{
			get
			{
				if (_closeMessageRequest == null)
				{
					_closeMessageRequest = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "closeMessageRequest", cr2w, this);
				}
				return _closeMessageRequest;
			}
			set
			{
				if (_closeMessageRequest == value)
				{
					return;
				}
				_closeMessageRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("showingMessage")] 
		public gamebbScriptID_Int32 ShowingMessage
		{
			get
			{
				if (_showingMessage == null)
				{
					_showingMessage = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "showingMessage", cr2w, this);
				}
				return _showingMessage;
			}
			set
			{
				if (_showingMessage == value)
				{
					return;
				}
				_showingMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("PhoneCallInformation")] 
		public gamebbScriptID_Variant PhoneCallInformation
		{
			get
			{
				if (_phoneCallInformation == null)
				{
					_phoneCallInformation = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PhoneCallInformation", cr2w, this);
				}
				return _phoneCallInformation;
			}
			set
			{
				if (_phoneCallInformation == value)
				{
					return;
				}
				_phoneCallInformation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("PhoneStyle_PlacidePhone")] 
		public gamebbScriptID_Bool PhoneStyle_PlacidePhone
		{
			get
			{
				if (_phoneStyle_PlacidePhone == null)
				{
					_phoneStyle_PlacidePhone = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "PhoneStyle_PlacidePhone", cr2w, this);
				}
				return _phoneStyle_PlacidePhone;
			}
			set
			{
				if (_phoneStyle_PlacidePhone == value)
				{
					return;
				}
				_phoneStyle_PlacidePhone = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("PhoneStyle_VideoCallInterupt")] 
		public gamebbScriptID_Bool PhoneStyle_VideoCallInterupt
		{
			get
			{
				if (_phoneStyle_VideoCallInterupt == null)
				{
					_phoneStyle_VideoCallInterupt = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "PhoneStyle_VideoCallInterupt", cr2w, this);
				}
				return _phoneStyle_VideoCallInterupt;
			}
			set
			{
				if (_phoneStyle_VideoCallInterupt == value)
				{
					return;
				}
				_phoneStyle_VideoCallInterupt = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("PhoneStyle_Minimized")] 
		public gamebbScriptID_Bool PhoneStyle_Minimized
		{
			get
			{
				if (_phoneStyle_Minimized == null)
				{
					_phoneStyle_Minimized = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "PhoneStyle_Minimized", cr2w, this);
				}
				return _phoneStyle_Minimized;
			}
			set
			{
				if (_phoneStyle_Minimized == value)
				{
					return;
				}
				_phoneStyle_Minimized = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isDisplayingMessage")] 
		public gamebbScriptID_Bool IsDisplayingMessage
		{
			get
			{
				if (_isDisplayingMessage == null)
				{
					_isDisplayingMessage = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isDisplayingMessage", cr2w, this);
				}
				return _isDisplayingMessage;
			}
			set
			{
				if (_isDisplayingMessage == value)
				{
					return;
				}
				_isDisplayingMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ContactsActive")] 
		public gamebbScriptID_Bool ContactsActive
		{
			get
			{
				if (_contactsActive == null)
				{
					_contactsActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ContactsActive", cr2w, this);
				}
				return _contactsActive;
			}
			set
			{
				if (_contactsActive == value)
				{
					return;
				}
				_contactsActive = value;
				PropertySet(this);
			}
		}

		public UI_ComDeviceDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
