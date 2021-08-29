using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIVideoPlayer : inkWidgetLogicController
	{
		private CName _videoWidgetPath;
		private CName _counterWidgetPath;
		private CName _lastFramePath;
		private CName _currentFramePath;
		private CWeakHandle<inkVideoWidget> _videoWidget;
		private CWeakHandle<inkTextWidget> _framesToSkipCounterWidget;
		private CWeakHandle<inkTextWidget> _lastFrameWidget;
		private CWeakHandle<inkTextWidget> _currentFrameWidget;
		private CUInt32 _numberOfFrames;

		[Ordinal(1)] 
		[RED("videoWidgetPath")] 
		public CName VideoWidgetPath
		{
			get => GetProperty(ref _videoWidgetPath);
			set => SetProperty(ref _videoWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("counterWidgetPath")] 
		public CName CounterWidgetPath
		{
			get => GetProperty(ref _counterWidgetPath);
			set => SetProperty(ref _counterWidgetPath, value);
		}

		[Ordinal(3)] 
		[RED("lastFramePath")] 
		public CName LastFramePath
		{
			get => GetProperty(ref _lastFramePath);
			set => SetProperty(ref _lastFramePath, value);
		}

		[Ordinal(4)] 
		[RED("currentFramePath")] 
		public CName CurrentFramePath
		{
			get => GetProperty(ref _currentFramePath);
			set => SetProperty(ref _currentFramePath, value);
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public CWeakHandle<inkVideoWidget> VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(6)] 
		[RED("framesToSkipCounterWidget")] 
		public CWeakHandle<inkTextWidget> FramesToSkipCounterWidget
		{
			get => GetProperty(ref _framesToSkipCounterWidget);
			set => SetProperty(ref _framesToSkipCounterWidget, value);
		}

		[Ordinal(7)] 
		[RED("lastFrameWidget")] 
		public CWeakHandle<inkTextWidget> LastFrameWidget
		{
			get => GetProperty(ref _lastFrameWidget);
			set => SetProperty(ref _lastFrameWidget, value);
		}

		[Ordinal(8)] 
		[RED("currentFrameWidget")] 
		public CWeakHandle<inkTextWidget> CurrentFrameWidget
		{
			get => GetProperty(ref _currentFrameWidget);
			set => SetProperty(ref _currentFrameWidget, value);
		}

		[Ordinal(9)] 
		[RED("numberOfFrames")] 
		public CUInt32 NumberOfFrames
		{
			get => GetProperty(ref _numberOfFrames);
			set => SetProperty(ref _numberOfFrames, value);
		}
	}
}
