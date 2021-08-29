using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CursorRootController : inkWidgetLogicController
	{
		private inkWidgetReference _mainCursor;
		private inkWidgetReference _progressBar;
		private inkWidgetReference _progressBarFrame;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("mainCursor")] 
		public inkWidgetReference MainCursor
		{
			get => GetProperty(ref _mainCursor);
			set => SetProperty(ref _mainCursor, value);
		}

		[Ordinal(2)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(3)] 
		[RED("progressBarFrame")] 
		public inkWidgetReference ProgressBarFrame
		{
			get => GetProperty(ref _progressBarFrame);
			set => SetProperty(ref _progressBarFrame, value);
		}

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}
	}
}
