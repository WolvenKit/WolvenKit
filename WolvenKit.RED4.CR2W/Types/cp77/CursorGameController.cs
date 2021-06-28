using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CursorGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _mainCursor;
		private inkWidgetReference _progressBar;
		private CName _currentContext;
		private inkMargin _margin;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<MenuCursorUserData> _data;
		private CBool _isCursorVisible;
		private CArray<PostponedCursorContext> _postponedContexts;
		private CInt32 _readIndex;
		private CInt32 _writeIndex;
		private CInt32 _bufferSize;

		[Ordinal(2)] 
		[RED("mainCursor")] 
		public inkWidgetReference MainCursor
		{
			get => GetProperty(ref _mainCursor);
			set => SetProperty(ref _mainCursor, value);
		}

		[Ordinal(3)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(4)] 
		[RED("currentContext")] 
		public CName CurrentContext
		{
			get => GetProperty(ref _currentContext);
			set => SetProperty(ref _currentContext, value);
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(6)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<MenuCursorUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("isCursorVisible")] 
		public CBool IsCursorVisible
		{
			get => GetProperty(ref _isCursorVisible);
			set => SetProperty(ref _isCursorVisible, value);
		}

		[Ordinal(9)] 
		[RED("postponedContexts")] 
		public CArray<PostponedCursorContext> PostponedContexts
		{
			get => GetProperty(ref _postponedContexts);
			set => SetProperty(ref _postponedContexts, value);
		}

		[Ordinal(10)] 
		[RED("readIndex")] 
		public CInt32 ReadIndex
		{
			get => GetProperty(ref _readIndex);
			set => SetProperty(ref _readIndex, value);
		}

		[Ordinal(11)] 
		[RED("writeIndex")] 
		public CInt32 WriteIndex
		{
			get => GetProperty(ref _writeIndex);
			set => SetProperty(ref _writeIndex, value);
		}

		[Ordinal(12)] 
		[RED("bufferSize")] 
		public CInt32 BufferSize
		{
			get => GetProperty(ref _bufferSize);
			set => SetProperty(ref _bufferSize, value);
		}

		public CursorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
