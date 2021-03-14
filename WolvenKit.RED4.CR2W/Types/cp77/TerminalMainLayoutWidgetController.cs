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
			get
			{
				if (_thumbnailsListSlot == null)
				{
					_thumbnailsListSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "thumbnailsListSlot", cr2w, this);
				}
				return _thumbnailsListSlot;
			}
			set
			{
				if (_thumbnailsListSlot == value)
				{
					return;
				}
				_thumbnailsListSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("deviceSlot")] 
		public inkWidgetReference DeviceSlot
		{
			get
			{
				if (_deviceSlot == null)
				{
					_deviceSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "deviceSlot", cr2w, this);
				}
				return _deviceSlot;
			}
			set
			{
				if (_deviceSlot == value)
				{
					return;
				}
				_deviceSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("returnButton")] 
		public inkWidgetReference ReturnButton
		{
			get
			{
				if (_returnButton == null)
				{
					_returnButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "returnButton", cr2w, this);
				}
				return _returnButton;
			}
			set
			{
				if (_returnButton == value)
				{
					return;
				}
				_returnButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get
			{
				if (_titleWidget == null)
				{
					_titleWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleWidget", cr2w, this);
				}
				return _titleWidget;
			}
			set
			{
				if (_titleWidget == value)
				{
					return;
				}
				_titleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("backgroundImage")] 
		public inkImageWidgetReference BackgroundImage
		{
			get
			{
				if (_backgroundImage == null)
				{
					_backgroundImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "backgroundImage", cr2w, this);
				}
				return _backgroundImage;
			}
			set
			{
				if (_backgroundImage == value)
				{
					return;
				}
				_backgroundImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("backgroundImageTrace")] 
		public inkImageWidgetReference BackgroundImageTrace
		{
			get
			{
				if (_backgroundImageTrace == null)
				{
					_backgroundImageTrace = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "backgroundImageTrace", cr2w, this);
				}
				return _backgroundImageTrace;
			}
			set
			{
				if (_backgroundImageTrace == value)
				{
					return;
				}
				_backgroundImageTrace = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("main_canvas")] 
		public wCHandle<inkWidget> Main_canvas
		{
			get
			{
				if (_main_canvas == null)
				{
					_main_canvas = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "main_canvas", cr2w, this);
				}
				return _main_canvas;
			}
			set
			{
				if (_main_canvas == value)
				{
					return;
				}
				_main_canvas = value;
				PropertySet(this);
			}
		}

		public TerminalMainLayoutWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
