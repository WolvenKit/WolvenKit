using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryScriptableEquipmentListener : IScriptable
	{
		[Ordinal(0)] 
		[RED("uiInventoryScriptableSystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventoryScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("EquipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(2)] 
		[RED("itemEquippedListener")] 
		public CHandle<redCallbackObject> ItemEquippedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public UIInventoryScriptableEquipmentListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
