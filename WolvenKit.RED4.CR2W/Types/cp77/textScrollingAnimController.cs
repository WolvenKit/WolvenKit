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
			get
			{
				if (_scannerDetailsHackLog == null)
				{
					_scannerDetailsHackLog = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "scannerDetailsHackLog", cr2w, this);
				}
				return _scannerDetailsHackLog;
			}
			set
			{
				if (_scannerDetailsHackLog == value)
				{
					return;
				}
				_scannerDetailsHackLog = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultScrollSpeed")] 
		public CFloat DefaultScrollSpeed
		{
			get
			{
				if (_defaultScrollSpeed == null)
				{
					_defaultScrollSpeed = (CFloat) CR2WTypeManager.Create("Float", "defaultScrollSpeed", cr2w, this);
				}
				return _defaultScrollSpeed;
			}
			set
			{
				if (_defaultScrollSpeed == value)
				{
					return;
				}
				_defaultScrollSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playOnInit")] 
		public CBool PlayOnInit
		{
			get
			{
				if (_playOnInit == null)
				{
					_playOnInit = (CBool) CR2WTypeManager.Create("Bool", "playOnInit", cr2w, this);
				}
				return _playOnInit;
			}
			set
			{
				if (_playOnInit == value)
				{
					return;
				}
				_playOnInit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numOfLines")] 
		public CInt32 NumOfLines
		{
			get
			{
				if (_numOfLines == null)
				{
					_numOfLines = (CInt32) CR2WTypeManager.Create("Int32", "numOfLines", cr2w, this);
				}
				return _numOfLines;
			}
			set
			{
				if (_numOfLines == value)
				{
					return;
				}
				_numOfLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numOfStartingLines")] 
		public CInt32 NumOfStartingLines
		{
			get
			{
				if (_numOfStartingLines == null)
				{
					_numOfStartingLines = (CInt32) CR2WTypeManager.Create("Int32", "numOfStartingLines", cr2w, this);
				}
				return _numOfStartingLines;
			}
			set
			{
				if (_numOfStartingLines == value)
				{
					return;
				}
				_numOfStartingLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("transparency")] 
		public CFloat Transparency
		{
			get
			{
				if (_transparency == null)
				{
					_transparency = (CFloat) CR2WTypeManager.Create("Float", "transparency", cr2w, this);
				}
				return _transparency;
			}
			set
			{
				if (_transparency == value)
				{
					return;
				}
				_transparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gapIndex")] 
		public CInt32 GapIndex
		{
			get
			{
				if (_gapIndex == null)
				{
					_gapIndex = (CInt32) CR2WTypeManager.Create("Int32", "gapIndex", cr2w, this);
				}
				return _gapIndex;
			}
			set
			{
				if (_gapIndex == value)
				{
					return;
				}
				_gapIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("binaryOnly")] 
		public CBool BinaryOnly
		{
			get
			{
				if (_binaryOnly == null)
				{
					_binaryOnly = (CBool) CR2WTypeManager.Create("Bool", "binaryOnly", cr2w, this);
				}
				return _binaryOnly;
			}
			set
			{
				if (_binaryOnly == value)
				{
					return;
				}
				_binaryOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("binaryClusterCount")] 
		public CInt32 BinaryClusterCount
		{
			get
			{
				if (_binaryClusterCount == null)
				{
					_binaryClusterCount = (CInt32) CR2WTypeManager.Create("Int32", "binaryClusterCount", cr2w, this);
				}
				return _binaryClusterCount;
			}
			set
			{
				if (_binaryClusterCount == value)
				{
					return;
				}
				_binaryClusterCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("scrollingText")] 
		public ScrollingText ScrollingText
		{
			get
			{
				if (_scrollingText == null)
				{
					_scrollingText = (ScrollingText) CR2WTypeManager.Create("ScrollingText", "scrollingText", cr2w, this);
				}
				return _scrollingText;
			}
			set
			{
				if (_scrollingText == value)
				{
					return;
				}
				_scrollingText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("logArray")] 
		public CArray<CString> LogArray
		{
			get
			{
				if (_logArray == null)
				{
					_logArray = (CArray<CString>) CR2WTypeManager.Create("array:String", "logArray", cr2w, this);
				}
				return _logArray;
			}
			set
			{
				if (_logArray == value)
				{
					return;
				}
				_logArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("upload_counter")] 
		public CFloat Upload_counter
		{
			get
			{
				if (_upload_counter == null)
				{
					_upload_counter = (CFloat) CR2WTypeManager.Create("Float", "upload_counter", cr2w, this);
				}
				return _upload_counter;
			}
			set
			{
				if (_upload_counter == value)
				{
					return;
				}
				_upload_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("scrollSpeed")] 
		public CFloat ScrollSpeed
		{
			get
			{
				if (_scrollSpeed == null)
				{
					_scrollSpeed = (CFloat) CR2WTypeManager.Create("Float", "scrollSpeed", cr2w, this);
				}
				return _scrollSpeed;
			}
			set
			{
				if (_scrollSpeed == value)
				{
					return;
				}
				_scrollSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fastScrollSpeed")] 
		public CFloat FastScrollSpeed
		{
			get
			{
				if (_fastScrollSpeed == null)
				{
					_fastScrollSpeed = (CFloat) CR2WTypeManager.Create("Float", "fastScrollSpeed", cr2w, this);
				}
				return _fastScrollSpeed;
			}
			set
			{
				if (_fastScrollSpeed == value)
				{
					return;
				}
				_fastScrollSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("panel")] 
		public wCHandle<inkCompoundWidget> Panel
		{
			get
			{
				if (_panel == null)
				{
					_panel = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "panel", cr2w, this);
				}
				return _panel;
			}
			set
			{
				if (_panel == value)
				{
					return;
				}
				_panel = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lineCount")] 
		public CInt32 LineCount
		{
			get
			{
				if (_lineCount == null)
				{
					_lineCount = (CInt32) CR2WTypeManager.Create("Int32", "lineCount", cr2w, this);
				}
				return _lineCount;
			}
			set
			{
				if (_lineCount == value)
				{
					return;
				}
				_lineCount = value;
				PropertySet(this);
			}
		}

		public textScrollingAnimController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
