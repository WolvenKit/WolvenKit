using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatsController : inkWidgetLogicController
	{
		private inkWidgetReference _detailsButton;
		private inkCompoundWidgetReference _entryContainer;
		private CWeakHandle<InventoryStatsEntryController> _healthEntryController;
		private CWeakHandle<InventoryStatsEntryController> _armorEntryController;
		private CWeakHandle<InventoryStatsEntryController> _staminaEntryController;

		[Ordinal(1)] 
		[RED("detailsButton")] 
		public inkWidgetReference DetailsButton
		{
			get => GetProperty(ref _detailsButton);
			set => SetProperty(ref _detailsButton, value);
		}

		[Ordinal(2)] 
		[RED("entryContainer")] 
		public inkCompoundWidgetReference EntryContainer
		{
			get => GetProperty(ref _entryContainer);
			set => SetProperty(ref _entryContainer, value);
		}

		[Ordinal(3)] 
		[RED("healthEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> HealthEntryController
		{
			get => GetProperty(ref _healthEntryController);
			set => SetProperty(ref _healthEntryController, value);
		}

		[Ordinal(4)] 
		[RED("armorEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> ArmorEntryController
		{
			get => GetProperty(ref _armorEntryController);
			set => SetProperty(ref _armorEntryController, value);
		}

		[Ordinal(5)] 
		[RED("staminaEntryController")] 
		public CWeakHandle<InventoryStatsEntryController> StaminaEntryController
		{
			get => GetProperty(ref _staminaEntryController);
			set => SetProperty(ref _staminaEntryController, value);
		}
	}
}
