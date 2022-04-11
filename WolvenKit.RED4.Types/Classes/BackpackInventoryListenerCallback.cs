using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackpackInventoryListenerCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("backpackInstance")] 
		public CWeakHandle<gameuiBackpackMainGameController> BackpackInstance
		{
			get => GetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>(value);
		}
	}
}
