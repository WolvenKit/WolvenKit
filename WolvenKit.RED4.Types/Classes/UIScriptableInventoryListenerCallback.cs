using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		public UIScriptableInventoryListenerCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
