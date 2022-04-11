using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("outlineWidget")] 
		public inkShapeWidgetReference OutlineWidget
		{
			get => GetPropertyValue<inkShapeWidgetReference>();
			set => SetPropertyValue<inkShapeWidgetReference>(value);
		}

		public gameuiWorldMapDebugOutlineLogicController()
		{
			OutlineWidget = new();
		}
	}
}
