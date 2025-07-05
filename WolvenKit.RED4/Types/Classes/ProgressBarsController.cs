using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			Mask = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
