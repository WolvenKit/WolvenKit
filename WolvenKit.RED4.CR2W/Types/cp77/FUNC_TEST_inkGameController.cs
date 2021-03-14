using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_inkGameController : gameuiWidgetGameController
	{
		private inkCanvasWidgetReference _canvas;
		private inkHorizontalPanelWidgetReference _horizontalPanel;
		private inkVerticalPanelWidgetReference _verticalPanel;
		private inkFlexWidgetReference _flex;
		private inkUniformGridWidgetReference _uniformGrid;
		private inkTextWidgetReference _text;
		private inkTextInputWidgetReference _textInput;
		private inkImageWidgetReference _image;
		private inkVideoWidgetReference _video;
		private inkBorderWidgetReference _border;
		private inkRectangleWidgetReference _rectangle;
		private inkCircleWidgetReference _circle;
		private inkShapeWidgetReference _shape;
		private FUNC_TEST_Container_2 _basicInputFields;
		private FUNC_TEST_Container _additionalFields;

		[Ordinal(2)] 
		[RED("Canvas")] 
		public inkCanvasWidgetReference Canvas
		{
			get
			{
				if (_canvas == null)
				{
					_canvas = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "Canvas", cr2w, this);
				}
				return _canvas;
			}
			set
			{
				if (_canvas == value)
				{
					return;
				}
				_canvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("HorizontalPanel")] 
		public inkHorizontalPanelWidgetReference HorizontalPanel
		{
			get
			{
				if (_horizontalPanel == null)
				{
					_horizontalPanel = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "HorizontalPanel", cr2w, this);
				}
				return _horizontalPanel;
			}
			set
			{
				if (_horizontalPanel == value)
				{
					return;
				}
				_horizontalPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("VerticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get
			{
				if (_verticalPanel == null)
				{
					_verticalPanel = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "VerticalPanel", cr2w, this);
				}
				return _verticalPanel;
			}
			set
			{
				if (_verticalPanel == value)
				{
					return;
				}
				_verticalPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Flex")] 
		public inkFlexWidgetReference Flex
		{
			get
			{
				if (_flex == null)
				{
					_flex = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "Flex", cr2w, this);
				}
				return _flex;
			}
			set
			{
				if (_flex == value)
				{
					return;
				}
				_flex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("UniformGrid")] 
		public inkUniformGridWidgetReference UniformGrid
		{
			get
			{
				if (_uniformGrid == null)
				{
					_uniformGrid = (inkUniformGridWidgetReference) CR2WTypeManager.Create("inkUniformGridWidgetReference", "UniformGrid", cr2w, this);
				}
				return _uniformGrid;
			}
			set
			{
				if (_uniformGrid == value)
				{
					return;
				}
				_uniformGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Text", cr2w, this);
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

		[Ordinal(8)] 
		[RED("TextInput")] 
		public inkTextInputWidgetReference TextInput
		{
			get
			{
				if (_textInput == null)
				{
					_textInput = (inkTextInputWidgetReference) CR2WTypeManager.Create("inkTextInputWidgetReference", "TextInput", cr2w, this);
				}
				return _textInput;
			}
			set
			{
				if (_textInput == value)
				{
					return;
				}
				_textInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "Image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Video")] 
		public inkVideoWidgetReference Video
		{
			get
			{
				if (_video == null)
				{
					_video = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "Video", cr2w, this);
				}
				return _video;
			}
			set
			{
				if (_video == value)
				{
					return;
				}
				_video = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Border")] 
		public inkBorderWidgetReference Border
		{
			get
			{
				if (_border == null)
				{
					_border = (inkBorderWidgetReference) CR2WTypeManager.Create("inkBorderWidgetReference", "Border", cr2w, this);
				}
				return _border;
			}
			set
			{
				if (_border == value)
				{
					return;
				}
				_border = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Rectangle")] 
		public inkRectangleWidgetReference Rectangle
		{
			get
			{
				if (_rectangle == null)
				{
					_rectangle = (inkRectangleWidgetReference) CR2WTypeManager.Create("inkRectangleWidgetReference", "Rectangle", cr2w, this);
				}
				return _rectangle;
			}
			set
			{
				if (_rectangle == value)
				{
					return;
				}
				_rectangle = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Circle")] 
		public inkCircleWidgetReference Circle
		{
			get
			{
				if (_circle == null)
				{
					_circle = (inkCircleWidgetReference) CR2WTypeManager.Create("inkCircleWidgetReference", "Circle", cr2w, this);
				}
				return _circle;
			}
			set
			{
				if (_circle == value)
				{
					return;
				}
				_circle = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("Shape")] 
		public inkShapeWidgetReference Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (inkShapeWidgetReference) CR2WTypeManager.Create("inkShapeWidgetReference", "Shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("BasicInputFields")] 
		public FUNC_TEST_Container_2 BasicInputFields
		{
			get
			{
				if (_basicInputFields == null)
				{
					_basicInputFields = (FUNC_TEST_Container_2) CR2WTypeManager.Create("FUNC_TEST_Container_2", "BasicInputFields", cr2w, this);
				}
				return _basicInputFields;
			}
			set
			{
				if (_basicInputFields == value)
				{
					return;
				}
				_basicInputFields = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("AdditionalFields")] 
		public FUNC_TEST_Container AdditionalFields
		{
			get
			{
				if (_additionalFields == null)
				{
					_additionalFields = (FUNC_TEST_Container) CR2WTypeManager.Create("FUNC_TEST_Container", "AdditionalFields", cr2w, this);
				}
				return _additionalFields;
			}
			set
			{
				if (_additionalFields == value)
				{
					return;
				}
				_additionalFields = value;
				PropertySet(this);
			}
		}

		public FUNC_TEST_inkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
