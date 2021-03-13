using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressionWidgetGameController : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(4)] [RED("playerDevelopmentSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem { get; set; }
		[Ordinal(5)] [RED("combatModePSM")] public CEnum<gamePSMCombat> CombatModePSM { get; set; }
		[Ordinal(6)] [RED("combatModeListener")] public CUInt32 CombatModeListener { get; set; }
		[Ordinal(7)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(8)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public ProgressionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
