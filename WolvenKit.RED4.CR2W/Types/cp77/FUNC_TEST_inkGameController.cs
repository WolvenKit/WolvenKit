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
			get => GetProperty(ref _canvas);
			set => SetProperty(ref _canvas, value);
		}

		[Ordinal(3)] 
		[RED("HorizontalPanel")] 
		public inkHorizontalPanelWidgetReference HorizontalPanel
		{
			get => GetProperty(ref _horizontalPanel);
			set => SetProperty(ref _horizontalPanel, value);
		}

		[Ordinal(4)] 
		[RED("VerticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get => GetProperty(ref _verticalPanel);
			set => SetProperty(ref _verticalPanel, value);
		}

		[Ordinal(5)] 
		[RED("Flex")] 
		public inkFlexWidgetReference Flex
		{
			get => GetProperty(ref _flex);
			set => SetProperty(ref _flex, value);
		}

		[Ordinal(6)] 
		[RED("UniformGrid")] 
		public inkUniformGridWidgetReference UniformGrid
		{
			get => GetProperty(ref _uniformGrid);
			set => SetProperty(ref _uniformGrid, value);
		}

		[Ordinal(7)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(8)] 
		[RED("TextInput")] 
		public inkTextInputWidgetReference TextInput
		{
			get => GetProperty(ref _textInput);
			set => SetProperty(ref _textInput, value);
		}

		[Ordinal(9)] 
		[RED("Image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(10)] 
		[RED("Video")] 
		public inkVideoWidgetReference Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(11)] 
		[RED("Border")] 
		public inkBorderWidgetReference Border
		{
			get => GetProperty(ref _border);
			set => SetProperty(ref _border, value);
		}

		[Ordinal(12)] 
		[RED("Rectangle")] 
		public inkRectangleWidgetReference Rectangle
		{
			get => GetProperty(ref _rectangle);
			set => SetProperty(ref _rectangle, value);
		}

		[Ordinal(13)] 
		[RED("Circle")] 
		public inkCircleWidgetReference Circle
		{
			get => GetProperty(ref _circle);
			set => SetProperty(ref _circle, value);
		}

		[Ordinal(14)] 
		[RED("Shape")] 
		public inkShapeWidgetReference Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(15)] 
		[RED("BasicInputFields")] 
		public FUNC_TEST_Container_2 BasicInputFields
		{
			get => GetProperty(ref _basicInputFields);
			set => SetProperty(ref _basicInputFields, value);
		}

		[Ordinal(16)] 
		[RED("AdditionalFields")] 
		public FUNC_TEST_Container AdditionalFields
		{
			get => GetProperty(ref _additionalFields);
			set => SetProperty(ref _additionalFields, value);
		}

		public FUNC_TEST_inkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
