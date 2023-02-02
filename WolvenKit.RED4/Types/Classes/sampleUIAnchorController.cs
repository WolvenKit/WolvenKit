using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIAnchorController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("rectangleAnchor")] 
		public inkRectangleWidgetReference RectangleAnchor
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		public sampleUIAnchorController()
		{
			RectangleAnchor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
