using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("uiInventoryScriptableSystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventoryScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		public UIInventoryScriptableInventoryListenerCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
