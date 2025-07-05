using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("backpackInstance")] 
		public CWeakHandle<gameuiBackpackMainGameController> BackpackInstance
		{
			get => GetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>(value);
		}

		public BackpackInventoryListenerCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
