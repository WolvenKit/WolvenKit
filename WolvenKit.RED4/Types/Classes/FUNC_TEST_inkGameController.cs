using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FUNC_TEST_inkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("Canvas")] 
		public inkCanvasWidgetReference Canvas
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("HorizontalPanel")] 
		public inkHorizontalPanelWidgetReference HorizontalPanel
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("VerticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("Flex")] 
		public inkFlexWidgetReference Flex
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("UniformGrid")] 
		public inkUniformGridWidgetReference UniformGrid
		{
			get => GetPropertyValue<inkUniformGridWidgetReference>();
			set => SetPropertyValue<inkUniformGridWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("TextInput")] 
		public inkTextInputWidgetReference TextInput
		{
			get => GetPropertyValue<inkTextInputWidgetReference>();
			set => SetPropertyValue<inkTextInputWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("Image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("Video")] 
		public inkVideoWidgetReference Video
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("Border")] 
		public inkBorderWidgetReference Border
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("Rectangle")] 
		public inkRectangleWidgetReference Rectangle
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("Circle")] 
		public inkCircleWidgetReference Circle
		{
			get => GetPropertyValue<inkCircleWidgetReference>();
			set => SetPropertyValue<inkCircleWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("Shape")] 
		public inkShapeWidgetReference Shape
		{
			get => GetPropertyValue<inkShapeWidgetReference>();
			set => SetPropertyValue<inkShapeWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("BasicInputFields")] 
		public FUNC_TEST_Container_2 BasicInputFields
		{
			get => GetPropertyValue<FUNC_TEST_Container_2>();
			set => SetPropertyValue<FUNC_TEST_Container_2>(value);
		}

		[Ordinal(16)] 
		[RED("AdditionalFields")] 
		public FUNC_TEST_Container AdditionalFields
		{
			get => GetPropertyValue<FUNC_TEST_Container>();
			set => SetPropertyValue<FUNC_TEST_Container>(value);
		}

		public FUNC_TEST_inkGameController()
		{
			Canvas = new inkCanvasWidgetReference();
			HorizontalPanel = new inkHorizontalPanelWidgetReference();
			VerticalPanel = new inkVerticalPanelWidgetReference();
			Flex = new inkFlexWidgetReference();
			UniformGrid = new inkUniformGridWidgetReference();
			Text = new inkTextWidgetReference();
			TextInput = new inkTextInputWidgetReference();
			Image = new inkImageWidgetReference();
			Video = new inkVideoWidgetReference();
			Border = new inkBorderWidgetReference();
			Rectangle = new inkRectangleWidgetReference();
			Circle = new inkCircleWidgetReference();
			Shape = new inkShapeWidgetReference();
			BasicInputFields = new FUNC_TEST_Container_2();
			AdditionalFields = new FUNC_TEST_Container { BasePanel = new inkBasePanelWidgetReference(), Compound = new inkCompoundWidgetReference(), Leaf = new inkLeafWidgetReference(), Widget = new inkWidgetReference() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
