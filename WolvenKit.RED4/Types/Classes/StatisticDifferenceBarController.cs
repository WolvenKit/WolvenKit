using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatisticDifferenceBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("filled")] 
		public inkWidgetReference Filled
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("difference")] 
		public inkWidgetReference Difference
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public StatisticDifferenceBarController()
		{
			Filled = new inkWidgetReference();
			Difference = new inkWidgetReference();
			Empty = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
