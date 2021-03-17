using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textScrollingAnimController : inkWidgetLogicController
	{
		private inkTextWidgetReference _scannerDetailsHackLog;
		private CFloat _defaultScrollSpeed;
		private CBool _playOnInit;
		private CInt32 _numOfLines;
		private CInt32 _numOfStartingLines;
		private CFloat _transparency;
		private CInt32 _gapIndex;
		private CBool _binaryOnly;
		private CInt32 _binaryClusterCount;
		private ScrollingText _scrollingText;
		private CArray<CString> _logArray;
		private CFloat _upload_counter;
		private CFloat _scrollSpeed;
		private CFloat _fastScrollSpeed;
		private wCHandle<inkCompoundWidget> _panel;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private CInt32 _lineCount;

		[Ordinal(1)] 
		[RED("scannerDetailsHackLog")] 
		public inkTextWidgetReference ScannerDetailsHackLog
		{
			get => GetProperty(ref _scannerDetailsHackLog);
			set => SetProperty(ref _scannerDetailsHackLog, value);
		}

		[Ordinal(2)] 
		[RED("defaultScrollSpeed")] 
		public CFloat DefaultScrollSpeed
		{
			get => GetProperty(ref _defaultScrollSpeed);
			set => SetProperty(ref _defaultScrollSpeed, value);
		}

		[Ordinal(3)] 
		[RED("playOnInit")] 
		public CBool PlayOnInit
		{
			get => GetProperty(ref _playOnInit);
			set => SetProperty(ref _playOnInit, value);
		}

		[Ordinal(4)] 
		[RED("numOfLines")] 
		public CInt32 NumOfLines
		{
			get => GetProperty(ref _numOfLines);
			set => SetProperty(ref _numOfLines, value);
		}

		[Ordinal(5)] 
		[RED("numOfStartingLines")] 
		public CInt32 NumOfStartingLines
		{
			get => GetProperty(ref _numOfStartingLines);
			set => SetProperty(ref _numOfStartingLines, value);
		}

		[Ordinal(6)] 
		[RED("transparency")] 
		public CFloat Transparency
		{
			get => GetProperty(ref _transparency);
			set => SetProperty(ref _transparency, value);
		}

		[Ordinal(7)] 
		[RED("gapIndex")] 
		public CInt32 GapIndex
		{
			get => GetProperty(ref _gapIndex);
			set => SetProperty(ref _gapIndex, value);
		}

		[Ordinal(8)] 
		[RED("binaryOnly")] 
		public CBool BinaryOnly
		{
			get => GetProperty(ref _binaryOnly);
			set => SetProperty(ref _binaryOnly, value);
		}

		[Ordinal(9)] 
		[RED("binaryClusterCount")] 
		public CInt32 BinaryClusterCount
		{
			get => GetProperty(ref _binaryClusterCount);
			set => SetProperty(ref _binaryClusterCount, value);
		}

		[Ordinal(10)] 
		[RED("scrollingText")] 
		public ScrollingText ScrollingText
		{
			get => GetProperty(ref _scrollingText);
			set => SetProperty(ref _scrollingText, value);
		}

		[Ordinal(11)] 
		[RED("logArray")] 
		public CArray<CString> LogArray
		{
			get => GetProperty(ref _logArray);
			set => SetProperty(ref _logArray, value);
		}

		[Ordinal(12)] 
		[RED("upload_counter")] 
		public CFloat Upload_counter
		{
			get => GetProperty(ref _upload_counter);
			set => SetProperty(ref _upload_counter, value);
		}

		[Ordinal(13)] 
		[RED("scrollSpeed")] 
		public CFloat ScrollSpeed
		{
			get => GetProperty(ref _scrollSpeed);
			set => SetProperty(ref _scrollSpeed, value);
		}

		[Ordinal(14)] 
		[RED("fastScrollSpeed")] 
		public CFloat FastScrollSpeed
		{
			get => GetProperty(ref _fastScrollSpeed);
			set => SetProperty(ref _fastScrollSpeed, value);
		}

		[Ordinal(15)] 
		[RED("panel")] 
		public wCHandle<inkCompoundWidget> Panel
		{
			get => GetProperty(ref _panel);
			set => SetProperty(ref _panel, value);
		}

		[Ordinal(16)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(17)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(18)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(19)] 
		[RED("lineCount")] 
		public CInt32 LineCount
		{
			get => GetProperty(ref _lineCount);
			set => SetProperty(ref _lineCount, value);
		}

		public textScrollingAnimController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
