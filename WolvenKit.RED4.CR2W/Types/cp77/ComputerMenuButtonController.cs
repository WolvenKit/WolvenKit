using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMenuButtonController : DeviceButtonLogicControllerBase
	{
		private inkTextWidgetReference _counterWidget;
		private inkWidgetReference _notificationidget;
		private CString _menuID;

		[Ordinal(26)] 
		[RED("counterWidget")] 
		public inkTextWidgetReference CounterWidget
		{
			get
			{
				if (_counterWidget == null)
				{
					_counterWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "counterWidget", cr2w, this);
				}
				return _counterWidget;
			}
			set
			{
				if (_counterWidget == value)
				{
					return;
				}
				_counterWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("notificationidget")] 
		public inkWidgetReference Notificationidget
		{
			get
			{
				if (_notificationidget == null)
				{
					_notificationidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "notificationidget", cr2w, this);
				}
				return _notificationidget;
			}
			set
			{
				if (_notificationidget == value)
				{
					return;
				}
				_notificationidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("menuID")] 
		public CString MenuID
		{
			get
			{
				if (_menuID == null)
				{
					_menuID = (CString) CR2WTypeManager.Create("String", "menuID", cr2w, this);
				}
				return _menuID;
			}
			set
			{
				if (_menuID == value)
				{
					return;
				}
				_menuID = value;
				PropertySet(this);
			}
		}

		public ComputerMenuButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
