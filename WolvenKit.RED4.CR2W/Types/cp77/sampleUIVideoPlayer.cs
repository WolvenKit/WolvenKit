using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIVideoPlayer : inkWidgetLogicController
	{
		private CName _videoWidgetPath;
		private CName _counterWidgetPath;
		private CName _lastFramePath;
		private CName _currentFramePath;
		private wCHandle<inkVideoWidget> _videoWidget;
		private wCHandle<inkTextWidget> _framesToSkipCounterWidget;
		private wCHandle<inkTextWidget> _lastFrameWidget;
		private wCHandle<inkTextWidget> _currentFrameWidget;
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
		public wCHandle<inkVideoWidget> VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(6)] 
		[RED("framesToSkipCounterWidget")] 
		public wCHandle<inkTextWidget> FramesToSkipCounterWidget
		{
			get => GetProperty(ref _framesToSkipCounterWidget);
			set => SetProperty(ref _framesToSkipCounterWidget, value);
		}

		[Ordinal(7)] 
		[RED("lastFrameWidget")] 
		public wCHandle<inkTextWidget> LastFrameWidget
		{
			get => GetProperty(ref _lastFrameWidget);
			set => SetProperty(ref _lastFrameWidget, value);
		}

		[Ordinal(8)] 
		[RED("currentFrameWidget")] 
		public wCHandle<inkTextWidget> CurrentFrameWidget
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

		public sampleUIVideoPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
