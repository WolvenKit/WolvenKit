using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipModController : inkWidgetLogicController
	{
		private inkWidgetReference _dotIndicator;
		private inkCompoundWidgetReference _modAbilitiesContainer;
		private CWeakHandle<InventoryItemPartDisplay> _partIndicatorController;

		[Ordinal(1)] 
		[RED("dotIndicator")] 
		public inkWidgetReference DotIndicator
		{
			get => GetProperty(ref _dotIndicator);
			set => SetProperty(ref _dotIndicator, value);
		}

		[Ordinal(2)] 
		[RED("modAbilitiesContainer")] 
		public inkCompoundWidgetReference ModAbilitiesContainer
		{
			get => GetProperty(ref _modAbilitiesContainer);
			set => SetProperty(ref _modAbilitiesContainer, value);
		}

		[Ordinal(3)] 
		[RED("partIndicatorController")] 
		public CWeakHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get => GetProperty(ref _partIndicatorController);
			set => SetProperty(ref _partIndicatorController, value);
		}
	}
}
