using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIndicatorWeaponZoomListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("gameController")] public wCHandle<TargetHitIndicatorGameController> GameController { get; set; }

		public HitIndicatorWeaponZoomListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
