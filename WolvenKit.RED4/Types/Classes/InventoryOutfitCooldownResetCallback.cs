using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryOutfitCooldownResetCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<InventoryItemModeLogicController> Controller
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemModeLogicController>>(value);
		}

		public InventoryOutfitCooldownResetCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
