using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgramTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("diffValue")] 
		public inkTextWidgetReference DiffValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ProgramTooltipStatController()
		{
			Arrow = new inkImageWidgetReference();
			Value = new inkTextWidgetReference();
			DiffValue = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
