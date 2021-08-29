using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIndicatorWeaponZoomListener : gameScriptStatsListener
	{
		private CWeakHandle<TargetHitIndicatorGameController> _gameController;

		[Ordinal(0)] 
		[RED("gameController")] 
		public CWeakHandle<TargetHitIndicatorGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}
	}
}
