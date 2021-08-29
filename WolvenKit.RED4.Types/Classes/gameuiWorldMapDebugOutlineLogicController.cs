using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		private inkShapeWidgetReference _outlineWidget;

		[Ordinal(1)] 
		[RED("outlineWidget")] 
		public inkShapeWidgetReference OutlineWidget
		{
			get => GetProperty(ref _outlineWidget);
			set => SetProperty(ref _outlineWidget, value);
		}
	}
}
