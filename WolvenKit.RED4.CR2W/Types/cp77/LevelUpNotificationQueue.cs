using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("levelUpBlackboard")] public CHandle<gameIBlackboard> LevelUpBlackboard { get; set; }
		[Ordinal(4)] [RED("playerLevelUpListener")] public CUInt32 PlayerLevelUpListener { get; set; }
		[Ordinal(5)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(6)] [RED("combatModePSM")] public CEnum<gamePSMCombat> CombatModePSM { get; set; }
		[Ordinal(7)] [RED("combatModeListener")] public CUInt32 CombatModeListener { get; set; }

		public LevelUpNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
