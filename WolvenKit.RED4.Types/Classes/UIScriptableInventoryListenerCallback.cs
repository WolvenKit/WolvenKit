using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableInventoryListenerCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(1)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}
	}
}
