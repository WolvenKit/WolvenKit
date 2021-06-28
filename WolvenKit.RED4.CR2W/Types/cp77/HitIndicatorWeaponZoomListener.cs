using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIndicatorWeaponZoomListener : gameScriptStatsListener
	{
		private wCHandle<TargetHitIndicatorGameController> _gameController;

		[Ordinal(0)] 
		[RED("gameController")] 
		public wCHandle<TargetHitIndicatorGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		public HitIndicatorWeaponZoomListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
