using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponChangedListener : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("gameController")] 
		public CWeakHandle<TargetHitIndicatorGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorGameController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorGameController>>(value);
		}

		public WeaponChangedListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
