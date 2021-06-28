using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModController : inkWidgetLogicController
	{
		private inkWidgetReference _dotIndicator;
		private inkCompoundWidgetReference _modAbilitiesContainer;
		private CHandle<InventoryItemPartDisplay> _partIndicatorController;

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
		public CHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get => GetProperty(ref _partIndicatorController);
			set => SetProperty(ref _partIndicatorController, value);
		}

		public ItemTooltipModController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
