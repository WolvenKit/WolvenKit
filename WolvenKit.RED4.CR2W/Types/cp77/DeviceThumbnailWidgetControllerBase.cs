using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceThumbnailWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		private inkImageWidgetReference _deviceIconRef;
		private inkTextWidgetReference _statusNameWidget;
		private wCHandle<ThumbnailUI> _thumbnailAction;

		[Ordinal(26)] 
		[RED("deviceIconRef")] 
		public inkImageWidgetReference DeviceIconRef
		{
			get
			{
				if (_deviceIconRef == null)
				{
					_deviceIconRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "deviceIconRef", cr2w, this);
				}
				return _deviceIconRef;
			}
			set
			{
				if (_deviceIconRef == value)
				{
					return;
				}
				_deviceIconRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get
			{
				if (_statusNameWidget == null)
				{
					_statusNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statusNameWidget", cr2w, this);
				}
				return _statusNameWidget;
			}
			set
			{
				if (_statusNameWidget == value)
				{
					return;
				}
				_statusNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("thumbnailAction")] 
		public wCHandle<ThumbnailUI> ThumbnailAction
		{
			get
			{
				if (_thumbnailAction == null)
				{
					_thumbnailAction = (wCHandle<ThumbnailUI>) CR2WTypeManager.Create("whandle:ThumbnailUI", "thumbnailAction", cr2w, this);
				}
				return _thumbnailAction;
			}
			set
			{
				if (_thumbnailAction == value)
				{
					return;
				}
				_thumbnailAction = value;
				PropertySet(this);
			}
		}

		public DeviceThumbnailWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
