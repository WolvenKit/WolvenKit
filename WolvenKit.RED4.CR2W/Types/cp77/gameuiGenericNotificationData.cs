using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationData : CVariable
	{
		private CFloat _time;
		private CName _widgetLibraryItemName;
		private CName _introAnimation;
		private redResourceReferenceScriptToken _widgetLibraryResource;
		private CHandle<gameuiGenericNotificationViewData> _notificationData;

		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetLibraryItemName")] 
		public CName WidgetLibraryItemName
		{
			get
			{
				if (_widgetLibraryItemName == null)
				{
					_widgetLibraryItemName = (CName) CR2WTypeManager.Create("CName", "widgetLibraryItemName", cr2w, this);
				}
				return _widgetLibraryItemName;
			}
			set
			{
				if (_widgetLibraryItemName == value)
				{
					return;
				}
				_widgetLibraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get
			{
				if (_introAnimation == null)
				{
					_introAnimation = (CName) CR2WTypeManager.Create("CName", "introAnimation", cr2w, this);
				}
				return _introAnimation;
			}
			set
			{
				if (_introAnimation == value)
				{
					return;
				}
				_introAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widgetLibraryResource")] 
		public redResourceReferenceScriptToken WidgetLibraryResource
		{
			get
			{
				if (_widgetLibraryResource == null)
				{
					_widgetLibraryResource = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "widgetLibraryResource", cr2w, this);
				}
				return _widgetLibraryResource;
			}
			set
			{
				if (_widgetLibraryResource == value)
				{
					return;
				}
				_widgetLibraryResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("notificationData")] 
		public CHandle<gameuiGenericNotificationViewData> NotificationData
		{
			get
			{
				if (_notificationData == null)
				{
					_notificationData = (CHandle<gameuiGenericNotificationViewData>) CR2WTypeManager.Create("handle:gameuiGenericNotificationViewData", "notificationData", cr2w, this);
				}
				return _notificationData;
			}
			set
			{
				if (_notificationData == value)
				{
					return;
				}
				_notificationData = value;
				PropertySet(this);
			}
		}

		public gameuiGenericNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
