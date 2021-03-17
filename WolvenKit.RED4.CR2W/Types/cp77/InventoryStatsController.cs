using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsController : inkWidgetLogicController
	{
		private inkWidgetReference _detailsButton;
		private inkCompoundWidgetReference _entryContainer;
		private wCHandle<InventoryStatsEntryController> _healthEntryController;
		private wCHandle<InventoryStatsEntryController> _armorEntryController;
		private wCHandle<InventoryStatsEntryController> _staminaEntryController;

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
		public wCHandle<InventoryStatsEntryController> HealthEntryController
		{
			get => GetProperty(ref _healthEntryController);
			set => SetProperty(ref _healthEntryController, value);
		}

		[Ordinal(4)] 
		[RED("armorEntryController")] 
		public wCHandle<InventoryStatsEntryController> ArmorEntryController
		{
			get => GetProperty(ref _armorEntryController);
			set => SetProperty(ref _armorEntryController, value);
		}

		[Ordinal(5)] 
		[RED("staminaEntryController")] 
		public wCHandle<InventoryStatsEntryController> StaminaEntryController
		{
			get => GetProperty(ref _staminaEntryController);
			set => SetProperty(ref _staminaEntryController, value);
		}

		public InventoryStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
