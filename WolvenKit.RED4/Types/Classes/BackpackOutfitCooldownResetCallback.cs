using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackpackOutfitCooldownResetCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<gameuiBackpackMainGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBackpackMainGameController>>(value);
		}

		public BackpackOutfitCooldownResetCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
