using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceThumbnailWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		private inkImageWidgetReference _deviceIconRef;
		private inkTextWidgetReference _statusNameWidget;
		private CWeakHandle<ThumbnailUI> _thumbnailAction;

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
		public CWeakHandle<ThumbnailUI> ThumbnailAction
		{
			get => GetProperty(ref _thumbnailAction);
			set => SetProperty(ref _thumbnailAction, value);
		}
	}
}
