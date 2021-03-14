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
			get
			{
				if (_mainCursor == null)
				{
					_mainCursor = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "mainCursor", cr2w, this);
				}
				return _mainCursor;
			}
			set
			{
				if (_mainCursor == value)
				{
					return;
				}
				_mainCursor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentContext")] 
		public CName CurrentContext
		{
			get
			{
				if (_currentContext == null)
				{
					_currentContext = (CName) CR2WTypeManager.Create("CName", "currentContext", cr2w, this);
				}
				return _currentContext;
			}
			set
			{
				if (_currentContext == value)
				{
					return;
				}
				_currentContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get
			{
				if (_margin == null)
				{
					_margin = (inkMargin) CR2WTypeManager.Create("inkMargin", "margin", cr2w, this);
				}
				return _margin;
			}
			set
			{
				if (_margin == value)
				{
					return;
				}
				_margin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
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

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<MenuCursorUserData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<MenuCursorUserData>) CR2WTypeManager.Create("handle:MenuCursorUserData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isCursorVisible")] 
		public CBool IsCursorVisible
		{
			get
			{
				if (_isCursorVisible == null)
				{
					_isCursorVisible = (CBool) CR2WTypeManager.Create("Bool", "isCursorVisible", cr2w, this);
				}
				return _isCursorVisible;
			}
			set
			{
				if (_isCursorVisible == value)
				{
					return;
				}
				_isCursorVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("postponedContexts")] 
		public CArray<PostponedCursorContext> PostponedContexts
		{
			get
			{
				if (_postponedContexts == null)
				{
					_postponedContexts = (CArray<PostponedCursorContext>) CR2WTypeManager.Create("array:PostponedCursorContext", "postponedContexts", cr2w, this);
				}
				return _postponedContexts;
			}
			set
			{
				if (_postponedContexts == value)
				{
					return;
				}
				_postponedContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("readIndex")] 
		public CInt32 ReadIndex
		{
			get
			{
				if (_readIndex == null)
				{
					_readIndex = (CInt32) CR2WTypeManager.Create("Int32", "readIndex", cr2w, this);
				}
				return _readIndex;
			}
			set
			{
				if (_readIndex == value)
				{
					return;
				}
				_readIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("writeIndex")] 
		public CInt32 WriteIndex
		{
			get
			{
				if (_writeIndex == null)
				{
					_writeIndex = (CInt32) CR2WTypeManager.Create("Int32", "writeIndex", cr2w, this);
				}
				return _writeIndex;
			}
			set
			{
				if (_writeIndex == value)
				{
					return;
				}
				_writeIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bufferSize")] 
		public CInt32 BufferSize
		{
			get
			{
				if (_bufferSize == null)
				{
					_bufferSize = (CInt32) CR2WTypeManager.Create("Int32", "bufferSize", cr2w, this);
				}
				return _bufferSize;
			}
			set
			{
				if (_bufferSize == value)
				{
					return;
				}
				_bufferSize = value;
				PropertySet(this);
			}
		}

		public CursorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
