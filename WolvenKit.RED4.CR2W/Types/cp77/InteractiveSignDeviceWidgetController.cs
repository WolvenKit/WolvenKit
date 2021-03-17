using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		private CName _messageWidgetPath;
		private CName _backgroundWidgetPath;
		private wCHandle<inkTextWidget> _messageWidget;
		private wCHandle<inkWidget> _backgroundWidget;

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
		public wCHandle<inkTextWidget> MessageWidget
		{
			get => GetProperty(ref _messageWidget);
			set => SetProperty(ref _messageWidget, value);
		}

		[Ordinal(13)] 
		[RED("backgroundWidget")] 
		public wCHandle<inkWidget> BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}

		public InteractiveSignDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
