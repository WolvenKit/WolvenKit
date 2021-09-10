using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProgressBarsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("mask")] 
		public inkWidgetReference Mask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public ProgressBarsController()
		{
			Mask = new();
		}
	}
}
