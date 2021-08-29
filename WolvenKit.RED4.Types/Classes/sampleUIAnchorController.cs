using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIAnchorController : inkWidgetLogicController
	{
		private inkRectangleWidgetReference _rectangleAnchor;

		[Ordinal(1)] 
		[RED("rectangleAnchor")] 
		public inkRectangleWidgetReference RectangleAnchor
		{
			get => GetProperty(ref _rectangleAnchor);
			set => SetProperty(ref _rectangleAnchor, value);
		}
	}
}
