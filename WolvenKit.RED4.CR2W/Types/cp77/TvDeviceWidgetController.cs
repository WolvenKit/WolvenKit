using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetController : DeviceWidgetControllerBase
	{
		private inkVideoWidgetReference _videoWidget;
		private inkBasePanelWidgetReference _globalTVChannelSlot;
		private inkTextWidgetReference _messegeWidget;
		private inkLeafWidgetReference _messageBackgroundWidget;
		private wCHandle<inkWidget> _globalTVChannel;
		private redResourceReferenceScriptToken _activeVideo;

		[Ordinal(10)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(11)] 
		[RED("globalTVChannelSlot")] 
		public inkBasePanelWidgetReference GlobalTVChannelSlot
		{
			get => GetProperty(ref _globalTVChannelSlot);
			set => SetProperty(ref _globalTVChannelSlot, value);
		}

		[Ordinal(12)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(13)] 
		[RED("messageBackgroundWidget")] 
		public inkLeafWidgetReference MessageBackgroundWidget
		{
			get => GetProperty(ref _messageBackgroundWidget);
			set => SetProperty(ref _messageBackgroundWidget, value);
		}

		[Ordinal(14)] 
		[RED("globalTVChannel")] 
		public wCHandle<inkWidget> GlobalTVChannel
		{
			get => GetProperty(ref _globalTVChannel);
			set => SetProperty(ref _globalTVChannel, value);
		}

		[Ordinal(15)] 
		[RED("activeVideo")] 
		public redResourceReferenceScriptToken ActiveVideo
		{
			get => GetProperty(ref _activeVideo);
			set => SetProperty(ref _activeVideo, value);
		}

		public TvDeviceWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
