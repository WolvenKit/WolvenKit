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
			get
			{
				if (_videoWidgetPath == null)
				{
					_videoWidgetPath = (CName) CR2WTypeManager.Create("CName", "videoWidgetPath", cr2w, this);
				}
				return _videoWidgetPath;
			}
			set
			{
				if (_videoWidgetPath == value)
				{
					return;
				}
				_videoWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("counterWidgetPath")] 
		public CName CounterWidgetPath
		{
			get
			{
				if (_counterWidgetPath == null)
				{
					_counterWidgetPath = (CName) CR2WTypeManager.Create("CName", "counterWidgetPath", cr2w, this);
				}
				return _counterWidgetPath;
			}
			set
			{
				if (_counterWidgetPath == value)
				{
					return;
				}
				_counterWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastFramePath")] 
		public CName LastFramePath
		{
			get
			{
				if (_lastFramePath == null)
				{
					_lastFramePath = (CName) CR2WTypeManager.Create("CName", "lastFramePath", cr2w, this);
				}
				return _lastFramePath;
			}
			set
			{
				if (_lastFramePath == value)
				{
					return;
				}
				_lastFramePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentFramePath")] 
		public CName CurrentFramePath
		{
			get
			{
				if (_currentFramePath == null)
				{
					_currentFramePath = (CName) CR2WTypeManager.Create("CName", "currentFramePath", cr2w, this);
				}
				return _currentFramePath;
			}
			set
			{
				if (_currentFramePath == value)
				{
					return;
				}
				_currentFramePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public wCHandle<inkVideoWidget> VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("framesToSkipCounterWidget")] 
		public wCHandle<inkTextWidget> FramesToSkipCounterWidget
		{
			get
			{
				if (_framesToSkipCounterWidget == null)
				{
					_framesToSkipCounterWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "framesToSkipCounterWidget", cr2w, this);
				}
				return _framesToSkipCounterWidget;
			}
			set
			{
				if (_framesToSkipCounterWidget == value)
				{
					return;
				}
				_framesToSkipCounterWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lastFrameWidget")] 
		public wCHandle<inkTextWidget> LastFrameWidget
		{
			get
			{
				if (_lastFrameWidget == null)
				{
					_lastFrameWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "lastFrameWidget", cr2w, this);
				}
				return _lastFrameWidget;
			}
			set
			{
				if (_lastFrameWidget == value)
				{
					return;
				}
				_lastFrameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentFrameWidget")] 
		public wCHandle<inkTextWidget> CurrentFrameWidget
		{
			get
			{
				if (_currentFrameWidget == null)
				{
					_currentFrameWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "currentFrameWidget", cr2w, this);
				}
				return _currentFrameWidget;
			}
			set
			{
				if (_currentFrameWidget == value)
				{
					return;
				}
				_currentFrameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numberOfFrames")] 
		public CUInt32 NumberOfFrames
		{
			get
			{
				if (_numberOfFrames == null)
				{
					_numberOfFrames = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfFrames", cr2w, this);
				}
				return _numberOfFrames;
			}
			set
			{
				if (_numberOfFrames == value)
				{
					return;
				}
				_numberOfFrames = value;
				PropertySet(this);
			}
		}

		public sampleUIVideoPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
