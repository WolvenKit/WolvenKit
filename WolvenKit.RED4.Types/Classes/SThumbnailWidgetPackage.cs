using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SThumbnailWidgetPackage : SWidgetPackage
	{
		private CHandle<ThumbnailUI> _thumbnailAction;
		private CString _deviceStatus;

		[Ordinal(17)] 
		[RED("thumbnailAction")] 
		public CHandle<ThumbnailUI> ThumbnailAction
		{
			get => GetProperty(ref _thumbnailAction);
			set => SetProperty(ref _thumbnailAction, value);
		}

		[Ordinal(18)] 
		[RED("deviceStatus")] 
		public CString DeviceStatus
		{
			get => GetProperty(ref _deviceStatus);
			set => SetProperty(ref _deviceStatus, value);
		}
	}
}
