using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipModController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("dotIndicator")] 
		public inkWidgetReference DotIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("modAbilitiesContainer")] 
		public inkCompoundWidgetReference ModAbilitiesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("partIndicatorController")] 
		public CWeakHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemPartDisplay>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemPartDisplay>>(value);
		}

		public ItemTooltipModController()
		{
			DotIndicator = new();
			ModAbilitiesContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
