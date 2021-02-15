using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataTrackingSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("achievementsMask")] public CArray<CBool> AchievementsMask { get; set; }
		[Ordinal(1)] [RED("rangedAttacksMade")] public CInt32 RangedAttacksMade { get; set; }
		[Ordinal(2)] [RED("meleeAttacksMade")] public CInt32 MeleeAttacksMade { get; set; }
		[Ordinal(3)] [RED("meleeKills")] public CInt32 MeleeKills { get; set; }
		[Ordinal(4)] [RED("rangedKills")] public CInt32 RangedKills { get; set; }
		[Ordinal(5)] [RED("quickhacksMade")] public CInt32 QuickhacksMade { get; set; }
		[Ordinal(6)] [RED("distractionsMade")] public CInt32 DistractionsMade { get; set; }
		[Ordinal(7)] [RED("legendaryItemsCrafted")] public CInt32 LegendaryItemsCrafted { get; set; }
		[Ordinal(8)] [RED("npcMeleeLightAttackReceived")] public CInt32 NpcMeleeLightAttackReceived { get; set; }
		[Ordinal(9)] [RED("npcMeleeStrongAttackReceived")] public CInt32 NpcMeleeStrongAttackReceived { get; set; }
		[Ordinal(10)] [RED("npcMeleeBlockAttackReceived")] public CInt32 NpcMeleeBlockAttackReceived { get; set; }
		[Ordinal(11)] [RED("npcMeleeBlockedAttacks")] public CInt32 NpcMeleeBlockedAttacks { get; set; }
		[Ordinal(12)] [RED("npcMeleeDeflectedAttacks")] public CInt32 NpcMeleeDeflectedAttacks { get; set; }
		[Ordinal(13)] [RED("downedEnemies")] public CInt32 DownedEnemies { get; set; }
		[Ordinal(14)] [RED("killedEnemies")] public CInt32 KilledEnemies { get; set; }
		[Ordinal(15)] [RED("defeatedEnemies")] public CInt32 DefeatedEnemies { get; set; }
		[Ordinal(16)] [RED("incapacitatedEnemies")] public CInt32 IncapacitatedEnemies { get; set; }
		[Ordinal(17)] [RED("finishedEnemies")] public CInt32 FinishedEnemies { get; set; }
		[Ordinal(18)] [RED("downedWithRanged")] public CInt32 DownedWithRanged { get; set; }
		[Ordinal(19)] [RED("downedWithMelee")] public CInt32 DownedWithMelee { get; set; }
		[Ordinal(20)] [RED("downedInTimeDilatation")] public CInt32 DownedInTimeDilatation { get; set; }
		[Ordinal(21)] [RED("rangedProgress")] public CInt32 RangedProgress { get; set; }
		[Ordinal(22)] [RED("meleeProgress")] public CInt32 MeleeProgress { get; set; }
		[Ordinal(23)] [RED("dilationProgress")] public CInt32 DilationProgress { get; set; }
		[Ordinal(24)] [RED("failedShardDrops")] public CFloat FailedShardDrops { get; set; }
		[Ordinal(25)] [RED("bluelinesUseCount")] public CInt32 BluelinesUseCount { get; set; }
		[Ordinal(26)] [RED("twoHeadssourceID")] public entEntityID TwoHeadssourceID { get; set; }
		[Ordinal(27)] [RED("twoHeadsValidTimestamp")] public CFloat TwoHeadsValidTimestamp { get; set; }
		[Ordinal(28)] [RED("lastKillTimestamp")] public CFloat LastKillTimestamp { get; set; }
		[Ordinal(29)] [RED("enemiesKilledInTimeInterval")] public CArray<wCHandle<gameObject>> EnemiesKilledInTimeInterval { get; set; }
		[Ordinal(30)] [RED("timeInterval")] public CFloat TimeInterval { get; set; }
		[Ordinal(31)] [RED("numerOfKillsRequired")] public CInt32 NumerOfKillsRequired { get; set; }
		[Ordinal(32)] [RED("gunKataInProgress")] public CBool GunKataInProgress { get; set; }
		[Ordinal(33)] [RED("gunKataKilledEnemies")] public CInt32 GunKataKilledEnemies { get; set; }
		[Ordinal(34)] [RED("gunKataValidTimestamp")] public CFloat GunKataValidTimestamp { get; set; }
		[Ordinal(35)] [RED("hardKneesInProgress")] public CBool HardKneesInProgress { get; set; }
		[Ordinal(36)] [RED("hardKneesKilledEnemies")] public CInt32 HardKneesKilledEnemies { get; set; }
		[Ordinal(37)] [RED("harKneesValidTimestamp")] public CFloat HarKneesValidTimestamp { get; set; }
		[Ordinal(38)] [RED("resetKilledReqDelayID")] public gameDelayID ResetKilledReqDelayID { get; set; }
		[Ordinal(39)] [RED("resetFinishedReqDelayID")] public gameDelayID ResetFinishedReqDelayID { get; set; }
		[Ordinal(40)] [RED("resetDefeatedReqDelayID")] public gameDelayID ResetDefeatedReqDelayID { get; set; }
		[Ordinal(41)] [RED("resetIncapacitatedReqDelayID")] public gameDelayID ResetIncapacitatedReqDelayID { get; set; }
		[Ordinal(42)] [RED("resetDownedReqDelayID")] public gameDelayID ResetDownedReqDelayID { get; set; }
		[Ordinal(43)] [RED("resetMeleeAttackReqDelayID")] public gameDelayID ResetMeleeAttackReqDelayID { get; set; }
		[Ordinal(44)] [RED("resetRangedAttackReqDelayID")] public gameDelayID ResetRangedAttackReqDelayID { get; set; }
		[Ordinal(45)] [RED("resetAttackReqDelayID")] public gameDelayID ResetAttackReqDelayID { get; set; }
		[Ordinal(46)] [RED("resetNpcMeleeLightAttackReqDelayID")] public gameDelayID ResetNpcMeleeLightAttackReqDelayID { get; set; }
		[Ordinal(47)] [RED("resetNpcMeleeStrongAttackReqDelayID")] public gameDelayID ResetNpcMeleeStrongAttackReqDelayID { get; set; }
		[Ordinal(48)] [RED("resetNpcMeleeFinalAttackReqDelayID")] public gameDelayID ResetNpcMeleeFinalAttackReqDelayID { get; set; }
		[Ordinal(49)] [RED("resetNpcMeleeBlockAttackReqDelayID")] public gameDelayID ResetNpcMeleeBlockAttackReqDelayID { get; set; }
		[Ordinal(50)] [RED("resetNpcBlockedReqDelayID")] public gameDelayID ResetNpcBlockedReqDelayID { get; set; }
		[Ordinal(51)] [RED("resetNpcDeflectedReqDelayID")] public gameDelayID ResetNpcDeflectedReqDelayID { get; set; }
		[Ordinal(52)] [RED("resetNpcGuardbreakReqDelayID")] public gameDelayID ResetNpcGuardbreakReqDelayID { get; set; }

		public DataTrackingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
