using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackpackInventoryListenerCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<gameuiBackpackMainGameController> _backpackInstance;

		[Ordinal(1)] 
		[RED("backpackInstance")] 
		public CWeakHandle<gameuiBackpackMainGameController> BackpackInstance
		{
			get => GetProperty(ref _backpackInstance);
			set => SetProperty(ref _backpackInstance, value);
		}
	}
}
