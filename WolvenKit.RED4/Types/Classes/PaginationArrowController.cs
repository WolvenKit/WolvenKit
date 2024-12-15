using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaginationArrowController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("arrowFilled")] 
		public inkWidgetReference ArrowFilled
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PaginationArrowController()
		{
			ArrowFilled = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
