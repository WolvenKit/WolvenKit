using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryStatsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("detailsButton")] 
		public inkWidgetReference DetailsButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("entryContainer")] 
		public inkCompoundWidgetReference EntryContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("healthEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> HealthEntryController
		{
			get => GetPropertyValue<CWeakHandle<InventoryStatsEntryController>>();
			set => SetPropertyValue<CWeakHandle<InventoryStatsEntryController>>(value);
		}

		[Ordinal(4)] 
		[RED("armorEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> ArmorEntryController
		{
			get => GetPropertyValue<CWeakHandle<InventoryStatsEntryController>>();
			set => SetPropertyValue<CWeakHandle<InventoryStatsEntryController>>(value);
		}

		[Ordinal(5)] 
		[RED("staminaEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> StaminaEntryController
		{
			get => GetPropertyValue<CWeakHandle<InventoryStatsEntryController>>();
			set => SetPropertyValue<CWeakHandle<InventoryStatsEntryController>>(value);
		}

		public InventoryStatsController()
		{
			DetailsButton = new();
			EntryContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
