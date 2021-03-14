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
			get
			{
				if (_gameController == null)
				{
					_gameController = (wCHandle<TargetHitIndicatorGameController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorGameController", "gameController", cr2w, this);
				}
				return _gameController;
			}
			set
			{
				if (_gameController == value)
				{
					return;
				}
				_gameController = value;
				PropertySet(this);
			}
		}

		public HitIndicatorWeaponZoomListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
