using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameElementController : inkWidgetLogicController
	{
		private ElementData _data;
		private inkTextWidgetReference _text;
		private CColor _textNormalColor;
		private CColor _textHighlightColor;
		private inkRectangleWidgetReference _bg;
		private inkWidgetReference _colorAccent;
		private CFloat _dimmedOpacity;
		private CFloat _notDimmedOpacity;
		private CInt32 _defaultFontSize;
		private CBool _wasConsumed;
		private wCHandle<inkWidget> _root;

		[Ordinal(1)] 
		[RED("data")] 
		public ElementData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (ElementData) CR2WTypeManager.Create("ElementData", "data", cr2w, this);
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

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textNormalColor")] 
		public CColor TextNormalColor
		{
			get
			{
				if (_textNormalColor == null)
				{
					_textNormalColor = (CColor) CR2WTypeManager.Create("Color", "textNormalColor", cr2w, this);
				}
				return _textNormalColor;
			}
			set
			{
				if (_textNormalColor == value)
				{
					return;
				}
				_textNormalColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("textHighlightColor")] 
		public CColor TextHighlightColor
		{
			get
			{
				if (_textHighlightColor == null)
				{
					_textHighlightColor = (CColor) CR2WTypeManager.Create("Color", "textHighlightColor", cr2w, this);
				}
				return _textHighlightColor;
			}
			set
			{
				if (_textHighlightColor == value)
				{
					return;
				}
				_textHighlightColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bg")] 
		public inkRectangleWidgetReference Bg
		{
			get
			{
				if (_bg == null)
				{
					_bg = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "bg", cr2w, this);
				}
				return _bg;
			}
			set
			{
				if (_bg == value)
				{
					return;
				}
				_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("colorAccent")] 
		public inkWidgetReference ColorAccent
		{
			get
			{
				if (_colorAccent == null)
				{
					_colorAccent = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "colorAccent", cr2w, this);
				}
				return _colorAccent;
			}
			set
			{
				if (_colorAccent == value)
				{
					return;
				}
				_colorAccent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dimmedOpacity")] 
		public CFloat DimmedOpacity
		{
			get
			{
				if (_dimmedOpacity == null)
				{
					_dimmedOpacity = (CFloat) CR2WTypeManager.Create("Float", "dimmedOpacity", cr2w, this);
				}
				return _dimmedOpacity;
			}
			set
			{
				if (_dimmedOpacity == value)
				{
					return;
				}
				_dimmedOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("notDimmedOpacity")] 
		public CFloat NotDimmedOpacity
		{
			get
			{
				if (_notDimmedOpacity == null)
				{
					_notDimmedOpacity = (CFloat) CR2WTypeManager.Create("Float", "notDimmedOpacity", cr2w, this);
				}
				return _notDimmedOpacity;
			}
			set
			{
				if (_notDimmedOpacity == value)
				{
					return;
				}
				_notDimmedOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("defaultFontSize")] 
		public CInt32 DefaultFontSize
		{
			get
			{
				if (_defaultFontSize == null)
				{
					_defaultFontSize = (CInt32) CR2WTypeManager.Create("Int32", "defaultFontSize", cr2w, this);
				}
				return _defaultFontSize;
			}
			set
			{
				if (_defaultFontSize == value)
				{
					return;
				}
				_defaultFontSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("wasConsumed")] 
		public CBool WasConsumed
		{
			get
			{
				if (_wasConsumed == null)
				{
					_wasConsumed = (CBool) CR2WTypeManager.Create("Bool", "wasConsumed", cr2w, this);
				}
				return _wasConsumed;
			}
			set
			{
				if (_wasConsumed == value)
				{
					return;
				}
				_wasConsumed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameElementController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
