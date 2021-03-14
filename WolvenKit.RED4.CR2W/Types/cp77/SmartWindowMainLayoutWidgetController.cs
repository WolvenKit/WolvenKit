using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		private inkWidgetReference _menuMailsSlot;
		private inkWidgetReference _menuFilesSlot;
		private inkWidgetReference _menuNewsFeedSlot;
		private inkWidgetReference _menuDevicesSlot;

		[Ordinal(35)] 
		[RED("menuMailsSlot")] 
		public inkWidgetReference MenuMailsSlot
		{
			get
			{
				if (_menuMailsSlot == null)
				{
					_menuMailsSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuMailsSlot", cr2w, this);
				}
				return _menuMailsSlot;
			}
			set
			{
				if (_menuMailsSlot == value)
				{
					return;
				}
				_menuMailsSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("menuFilesSlot")] 
		public inkWidgetReference MenuFilesSlot
		{
			get
			{
				if (_menuFilesSlot == null)
				{
					_menuFilesSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuFilesSlot", cr2w, this);
				}
				return _menuFilesSlot;
			}
			set
			{
				if (_menuFilesSlot == value)
				{
					return;
				}
				_menuFilesSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("menuNewsFeedSlot")] 
		public inkWidgetReference MenuNewsFeedSlot
		{
			get
			{
				if (_menuNewsFeedSlot == null)
				{
					_menuNewsFeedSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuNewsFeedSlot", cr2w, this);
				}
				return _menuNewsFeedSlot;
			}
			set
			{
				if (_menuNewsFeedSlot == value)
				{
					return;
				}
				_menuNewsFeedSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("menuDevicesSlot")] 
		public inkWidgetReference MenuDevicesSlot
		{
			get
			{
				if (_menuDevicesSlot == null)
				{
					_menuDevicesSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuDevicesSlot", cr2w, this);
				}
				return _menuDevicesSlot;
			}
			set
			{
				if (_menuDevicesSlot == value)
				{
					return;
				}
				_menuDevicesSlot = value;
				PropertySet(this);
			}
		}

		public SmartWindowMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
