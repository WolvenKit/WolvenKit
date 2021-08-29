using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		private CName _messageWidgetPath;
		private CName _backgroundWidgetPath;
		private CWeakHandle<inkTextWidget> _messageWidget;
		private CWeakHandle<inkWidget> _backgroundWidget;

		[Ordinal(10)] 
		[RED("messageWidgetPath")] 
		public CName MessageWidgetPath
		{
			get => GetProperty(ref _messageWidgetPath);
			set => SetProperty(ref _messageWidgetPath, value);
		}

		[Ordinal(11)] 
		[RED("backgroundWidgetPath")] 
		public CName BackgroundWidgetPath
		{
			get => GetProperty(ref _backgroundWidgetPath);
			set => SetProperty(ref _backgroundWidgetPath, value);
		}

		[Ordinal(12)] 
		[RED("messageWidget")] 
		public CWeakHandle<inkTextWidget> MessageWidget
		{
			get => GetProperty(ref _messageWidget);
			set => SetProperty(ref _messageWidget, value);
		}

		[Ordinal(13)] 
		[RED("backgroundWidget")] 
		public CWeakHandle<inkWidget> BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}
	}
}
