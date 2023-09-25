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
		[RED("rarityContainer")] 
		public inkWidgetReference RarityContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("rarityWidget")] 
		public inkImageWidgetReference RarityWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("modAbilitiesContainer")] 
		public inkCompoundWidgetReference ModAbilitiesContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("partIndicatorController")] 
		public CWeakHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemPartDisplay>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemPartDisplay>>(value);
		}

		public ItemTooltipModController()
		{
			DotIndicator = new inkWidgetReference();
			RarityContainer = new inkWidgetReference();
			RarityWidget = new inkImageWidgetReference();
			ModAbilitiesContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
