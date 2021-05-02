using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalMainLayoutWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _thumbnailsListSlot;
		private inkWidgetReference _deviceSlot;
		private inkWidgetReference _returnButton;
		private inkTextWidgetReference _titleWidget;
		private inkImageWidgetReference _backgroundImage;
		private inkImageWidgetReference _backgroundImageTrace;
		private CBool _isInitialized;
		private wCHandle<inkWidget> _main_canvas;

		[Ordinal(1)] 
		[RED("thumbnailsListSlot")] 
		public inkWidgetReference ThumbnailsListSlot
		{
			get => GetProperty(ref _thumbnailsListSlot);
			set => SetProperty(ref _thumbnailsListSlot, value);
		}

		[Ordinal(2)] 
		[RED("deviceSlot")] 
		public inkWidgetReference DeviceSlot
		{
			get => GetProperty(ref _deviceSlot);
			set => SetProperty(ref _deviceSlot, value);
		}

		[Ordinal(3)] 
		[RED("returnButton")] 
		public inkWidgetReference ReturnButton
		{
			get => GetProperty(ref _returnButton);
			set => SetProperty(ref _returnButton, value);
		}

		[Ordinal(4)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get => GetProperty(ref _titleWidget);
			set => SetProperty(ref _titleWidget, value);
		}

		[Ordinal(5)] 
		[RED("backgroundImage")] 
		public inkImageWidgetReference BackgroundImage
		{
			get => GetProperty(ref _backgroundImage);
			set => SetProperty(ref _backgroundImage, value);
		}

		[Ordinal(6)] 
		[RED("backgroundImageTrace")] 
		public inkImageWidgetReference BackgroundImageTrace
		{
			get => GetProperty(ref _backgroundImageTrace);
			set => SetProperty(ref _backgroundImageTrace, value);
		}

		[Ordinal(7)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(8)] 
		[RED("main_canvas")] 
		public wCHandle<inkWidget> Main_canvas
		{
			get => GetProperty(ref _main_canvas);
			set => SetProperty(ref _main_canvas, value);
		}

		public TerminalMainLayoutWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
