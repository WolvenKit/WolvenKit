using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryScriptableStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("uiInventoryScriptableSystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventoryScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		public UIInventoryScriptableStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
