using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipDetailsStatsModule : NewItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public NewItemTooltipDetailsStatsModule()
		{
			StatsContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
