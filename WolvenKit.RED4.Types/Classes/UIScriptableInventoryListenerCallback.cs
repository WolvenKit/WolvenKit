using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}
	}
}
