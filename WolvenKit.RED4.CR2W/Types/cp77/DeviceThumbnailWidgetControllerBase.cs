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
			get => GetProperty(ref _deviceIconRef);
			set => SetProperty(ref _deviceIconRef, value);
		}

		[Ordinal(27)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get => GetProperty(ref _statusNameWidget);
			set => SetProperty(ref _statusNameWidget, value);
		}

		[Ordinal(28)] 
		[RED("thumbnailAction")] 
		public wCHandle<ThumbnailUI> ThumbnailAction
		{
			get => GetProperty(ref _thumbnailAction);
			set => SetProperty(ref _thumbnailAction, value);
		}

		public DeviceThumbnailWidgetControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
