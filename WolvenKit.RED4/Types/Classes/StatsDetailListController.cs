using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsDetailListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public StatsDetailListController()
		{
			StatLabelRef = new();
			StatsList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
