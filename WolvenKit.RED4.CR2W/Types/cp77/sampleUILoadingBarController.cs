using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUILoadingBarController : inkWidgetLogicController
	{
		private Vector2 _minSize;
		private Vector2 _maxSize;
		private CName _imageWidgetPath;
		private CName _textWidgetPath;
		private Vector2 _currentSize;
		private wCHandle<inkImageWidget> _imageWidget;
		private wCHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("minSize")] 
		public Vector2 MinSize
		{
			get
			{
				if (_minSize == null)
				{
					_minSize = (Vector2) CR2WTypeManager.Create("Vector2", "minSize", cr2w, this);
				}
				return _minSize;
			}
			set
			{
				if (_minSize == value)
				{
					return;
				}
				_minSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get
			{
				if (_maxSize == null)
				{
					_maxSize = (Vector2) CR2WTypeManager.Create("Vector2", "maxSize", cr2w, this);
				}
				return _maxSize;
			}
			set
			{
				if (_maxSize == value)
				{
					return;
				}
				_maxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public CName ImageWidgetPath
		{
			get
			{
				if (_imageWidgetPath == null)
				{
					_imageWidgetPath = (CName) CR2WTypeManager.Create("CName", "imageWidgetPath", cr2w, this);
				}
				return _imageWidgetPath;
			}
			set
			{
				if (_imageWidgetPath == value)
				{
					return;
				}
				_imageWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get
			{
				if (_textWidgetPath == null)
				{
					_textWidgetPath = (CName) CR2WTypeManager.Create("CName", "textWidgetPath", cr2w, this);
				}
				return _textWidgetPath;
			}
			set
			{
				if (_textWidgetPath == value)
				{
					return;
				}
				_textWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentSize")] 
		public Vector2 CurrentSize
		{
			get
			{
				if (_currentSize == null)
				{
					_currentSize = (Vector2) CR2WTypeManager.Create("Vector2", "currentSize", cr2w, this);
				}
				return _currentSize;
			}
			set
			{
				if (_currentSize == value)
				{
					return;
				}
				_currentSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("imageWidget")] 
		public wCHandle<inkImageWidget> ImageWidget
		{
			get
			{
				if (_imageWidget == null)
				{
					_imageWidget = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "imageWidget", cr2w, this);
				}
				return _imageWidget;
			}
			set
			{
				if (_imageWidget == value)
				{
					return;
				}
				_imageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		public sampleUILoadingBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
