using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTrackingSystem : gameScriptableSystem
	{
		private CArray<CBool> _achievementsMask;
		private CInt32 _rangedAttacksMade;
		private CInt32 _meleeAttacksMade;
		private CInt32 _meleeKills;
		private CInt32 _rangedKills;
		private CInt32 _quickhacksMade;
		private CInt32 _distractionsMade;
		private CInt32 _legendaryItemsCrafted;
		private CInt32 _npcMeleeLightAttackReceived;
		private CInt32 _npcMeleeStrongAttackReceived;
		private CInt32 _npcMeleeBlockAttackReceived;
		private CInt32 _npcMeleeBlockedAttacks;
		private CInt32 _npcMeleeDeflectedAttacks;
		private CInt32 _downedEnemies;
		private CInt32 _killedEnemies;
		private CInt32 _defeatedEnemies;
		private CInt32 _incapacitatedEnemies;
		private CInt32 _finishedEnemies;
		private CInt32 _downedWithRanged;
		private CInt32 _downedWithMelee;
		private CInt32 _downedInTimeDilatation;
		private CInt32 _rangedProgress;
		private CInt32 _meleeProgress;
		private CInt32 _dilationProgress;
		private CFloat _failedShardDrops;
		private CInt32 _bluelinesUseCount;
		private entEntityID _twoHeadssourceID;
		private CFloat _twoHeadsValidTimestamp;
		private CFloat _lastKillTimestamp;
		private CArray<wCHandle<gameObject>> _enemiesKilledInTimeInterval;
		private CFloat _timeInterval;
		private CInt32 _numerOfKillsRequired;
		private CBool _gunKataInProgress;
		private CInt32 _gunKataKilledEnemies;
		private CFloat _gunKataValidTimestamp;
		private CBool _hardKneesInProgress;
		private CInt32 _hardKneesKilledEnemies;
		private CFloat _harKneesValidTimestamp;
		private gameDelayID _resetKilledReqDelayID;
		private gameDelayID _resetFinishedReqDelayID;
		private gameDelayID _resetDefeatedReqDelayID;
		private gameDelayID _resetIncapacitatedReqDelayID;
		private gameDelayID _resetDownedReqDelayID;
		private gameDelayID _resetMeleeAttackReqDelayID;
		private gameDelayID _resetRangedAttackReqDelayID;
		private gameDelayID _resetAttackReqDelayID;
		private gameDelayID _resetNpcMeleeLightAttackReqDelayID;
		private gameDelayID _resetNpcMeleeStrongAttackReqDelayID;
		private gameDelayID _resetNpcMeleeFinalAttackReqDelayID;
		private gameDelayID _resetNpcMeleeBlockAttackReqDelayID;
		private gameDelayID _resetNpcBlockedReqDelayID;
		private gameDelayID _resetNpcDeflectedReqDelayID;
		private gameDelayID _resetNpcGuardbreakReqDelayID;

		[Ordinal(0)] 
		[RED("achievementsMask")] 
		public CArray<CBool> AchievementsMask
		{
			get => GetProperty(ref _achievementsMask);
			set => SetProperty(ref _achievementsMask, value);
		}

		[Ordinal(1)] 
		[RED("rangedAttacksMade")] 
		public CInt32 RangedAttacksMade
		{
			get => GetProperty(ref _rangedAttacksMade);
			set => SetProperty(ref _rangedAttacksMade, value);
		}

		[Ordinal(2)] 
		[RED("meleeAttacksMade")] 
		public CInt32 MeleeAttacksMade
		{
			get => GetProperty(ref _meleeAttacksMade);
			set => SetProperty(ref _meleeAttacksMade, value);
		}

		[Ordinal(3)] 
		[RED("meleeKills")] 
		public CInt32 MeleeKills
		{
			get => GetProperty(ref _meleeKills);
			set => SetProperty(ref _meleeKills, value);
		}

		[Ordinal(4)] 
		[RED("rangedKills")] 
		public CInt32 RangedKills
		{
			get => GetProperty(ref _rangedKills);
			set => SetProperty(ref _rangedKills, value);
		}

		[Ordinal(5)] 
		[RED("quickhacksMade")] 
		public CInt32 QuickhacksMade
		{
			get => GetProperty(ref _quickhacksMade);
			set => SetProperty(ref _quickhacksMade, value);
		}

		[Ordinal(6)] 
		[RED("distractionsMade")] 
		public CInt32 DistractionsMade
		{
			get => GetProperty(ref _distractionsMade);
			set => SetProperty(ref _distractionsMade, value);
		}

		[Ordinal(7)] 
		[RED("legendaryItemsCrafted")] 
		public CInt32 LegendaryItemsCrafted
		{
			get => GetProperty(ref _legendaryItemsCrafted);
			set => SetProperty(ref _legendaryItemsCrafted, value);
		}

		[Ordinal(8)] 
		[RED("npcMeleeLightAttackReceived")] 
		public CInt32 NpcMeleeLightAttackReceived
		{
			get => GetProperty(ref _npcMeleeLightAttackReceived);
			set => SetProperty(ref _npcMeleeLightAttackReceived, value);
		}

		[Ordinal(9)] 
		[RED("npcMeleeStrongAttackReceived")] 
		public CInt32 NpcMeleeStrongAttackReceived
		{
			get => GetProperty(ref _npcMeleeStrongAttackReceived);
			set => SetProperty(ref _npcMeleeStrongAttackReceived, value);
		}

		[Ordinal(10)] 
		[RED("npcMeleeBlockAttackReceived")] 
		public CInt32 NpcMeleeBlockAttackReceived
		{
			get => GetProperty(ref _npcMeleeBlockAttackReceived);
			set => SetProperty(ref _npcMeleeBlockAttackReceived, value);
		}

		[Ordinal(11)] 
		[RED("npcMeleeBlockedAttacks")] 
		public CInt32 NpcMeleeBlockedAttacks
		{
			get => GetProperty(ref _npcMeleeBlockedAttacks);
			set => SetProperty(ref _npcMeleeBlockedAttacks, value);
		}

		[Ordinal(12)] 
		[RED("npcMeleeDeflectedAttacks")] 
		public CInt32 NpcMeleeDeflectedAttacks
		{
			get => GetProperty(ref _npcMeleeDeflectedAttacks);
			set => SetProperty(ref _npcMeleeDeflectedAttacks, value);
		}

		[Ordinal(13)] 
		[RED("downedEnemies")] 
		public CInt32 DownedEnemies
		{
			get => GetProperty(ref _downedEnemies);
			set => SetProperty(ref _downedEnemies, value);
		}

		[Ordinal(14)] 
		[RED("killedEnemies")] 
		public CInt32 KilledEnemies
		{
			get => GetProperty(ref _killedEnemies);
			set => SetProperty(ref _killedEnemies, value);
		}

		[Ordinal(15)] 
		[RED("defeatedEnemies")] 
		public CInt32 DefeatedEnemies
		{
			get => GetProperty(ref _defeatedEnemies);
			set => SetProperty(ref _defeatedEnemies, value);
		}

		[Ordinal(16)] 
		[RED("incapacitatedEnemies")] 
		public CInt32 IncapacitatedEnemies
		{
			get => GetProperty(ref _incapacitatedEnemies);
			set => SetProperty(ref _incapacitatedEnemies, value);
		}

		[Ordinal(17)] 
		[RED("finishedEnemies")] 
		public CInt32 FinishedEnemies
		{
			get => GetProperty(ref _finishedEnemies);
			set => SetProperty(ref _finishedEnemies, value);
		}

		[Ordinal(18)] 
		[RED("downedWithRanged")] 
		public CInt32 DownedWithRanged
		{
			get => GetProperty(ref _downedWithRanged);
			set => SetProperty(ref _downedWithRanged, value);
		}

		[Ordinal(19)] 
		[RED("downedWithMelee")] 
		public CInt32 DownedWithMelee
		{
			get => GetProperty(ref _downedWithMelee);
			set => SetProperty(ref _downedWithMelee, value);
		}

		[Ordinal(20)] 
		[RED("downedInTimeDilatation")] 
		public CInt32 DownedInTimeDilatation
		{
			get => GetProperty(ref _downedInTimeDilatation);
			set => SetProperty(ref _downedInTimeDilatation, value);
		}

		[Ordinal(21)] 
		[RED("rangedProgress")] 
		public CInt32 RangedProgress
		{
			get => GetProperty(ref _rangedProgress);
			set => SetProperty(ref _rangedProgress, value);
		}

		[Ordinal(22)] 
		[RED("meleeProgress")] 
		public CInt32 MeleeProgress
		{
			get => GetProperty(ref _meleeProgress);
			set => SetProperty(ref _meleeProgress, value);
		}

		[Ordinal(23)] 
		[RED("dilationProgress")] 
		public CInt32 DilationProgress
		{
			get => GetProperty(ref _dilationProgress);
			set => SetProperty(ref _dilationProgress, value);
		}

		[Ordinal(24)] 
		[RED("failedShardDrops")] 
		public CFloat FailedShardDrops
		{
			get => GetProperty(ref _failedShardDrops);
			set => SetProperty(ref _failedShardDrops, value);
		}

		[Ordinal(25)] 
		[RED("bluelinesUseCount")] 
		public CInt32 BluelinesUseCount
		{
			get => GetProperty(ref _bluelinesUseCount);
			set => SetProperty(ref _bluelinesUseCount, value);
		}

		[Ordinal(26)] 
		[RED("twoHeadssourceID")] 
		public entEntityID TwoHeadssourceID
		{
			get => GetProperty(ref _twoHeadssourceID);
			set => SetProperty(ref _twoHeadssourceID, value);
		}

		[Ordinal(27)] 
		[RED("twoHeadsValidTimestamp")] 
		public CFloat TwoHeadsValidTimestamp
		{
			get => GetProperty(ref _twoHeadsValidTimestamp);
			set => SetProperty(ref _twoHeadsValidTimestamp, value);
		}

		[Ordinal(28)] 
		[RED("lastKillTimestamp")] 
		public CFloat LastKillTimestamp
		{
			get => GetProperty(ref _lastKillTimestamp);
			set => SetProperty(ref _lastKillTimestamp, value);
		}

		[Ordinal(29)] 
		[RED("enemiesKilledInTimeInterval")] 
		public CArray<wCHandle<gameObject>> EnemiesKilledInTimeInterval
		{
			get => GetProperty(ref _enemiesKilledInTimeInterval);
			set => SetProperty(ref _enemiesKilledInTimeInterval, value);
		}

		[Ordinal(30)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(31)] 
		[RED("numerOfKillsRequired")] 
		public CInt32 NumerOfKillsRequired
		{
			get => GetProperty(ref _numerOfKillsRequired);
			set => SetProperty(ref _numerOfKillsRequired, value);
		}

		[Ordinal(32)] 
		[RED("gunKataInProgress")] 
		public CBool GunKataInProgress
		{
			get => GetProperty(ref _gunKataInProgress);
			set => SetProperty(ref _gunKataInProgress, value);
		}

		[Ordinal(33)] 
		[RED("gunKataKilledEnemies")] 
		public CInt32 GunKataKilledEnemies
		{
			get => GetProperty(ref _gunKataKilledEnemies);
			set => SetProperty(ref _gunKataKilledEnemies, value);
		}

		[Ordinal(34)] 
		[RED("gunKataValidTimestamp")] 
		public CFloat GunKataValidTimestamp
		{
			get => GetProperty(ref _gunKataValidTimestamp);
			set => SetProperty(ref _gunKataValidTimestamp, value);
		}

		[Ordinal(35)] 
		[RED("hardKneesInProgress")] 
		public CBool HardKneesInProgress
		{
			get => GetProperty(ref _hardKneesInProgress);
			set => SetProperty(ref _hardKneesInProgress, value);
		}

		[Ordinal(36)] 
		[RED("hardKneesKilledEnemies")] 
		public CInt32 HardKneesKilledEnemies
		{
			get => GetProperty(ref _hardKneesKilledEnemies);
			set => SetProperty(ref _hardKneesKilledEnemies, value);
		}

		[Ordinal(37)] 
		[RED("harKneesValidTimestamp")] 
		public CFloat HarKneesValidTimestamp
		{
			get => GetProperty(ref _harKneesValidTimestamp);
			set => SetProperty(ref _harKneesValidTimestamp, value);
		}

		[Ordinal(38)] 
		[RED("resetKilledReqDelayID")] 
		public gameDelayID ResetKilledReqDelayID
		{
			get => GetProperty(ref _resetKilledReqDelayID);
			set => SetProperty(ref _resetKilledReqDelayID, value);
		}

		[Ordinal(39)] 
		[RED("resetFinishedReqDelayID")] 
		public gameDelayID ResetFinishedReqDelayID
		{
			get => GetProperty(ref _resetFinishedReqDelayID);
			set => SetProperty(ref _resetFinishedReqDelayID, value);
		}

		[Ordinal(40)] 
		[RED("resetDefeatedReqDelayID")] 
		public gameDelayID ResetDefeatedReqDelayID
		{
			get => GetProperty(ref _resetDefeatedReqDelayID);
			set => SetProperty(ref _resetDefeatedReqDelayID, value);
		}

		[Ordinal(41)] 
		[RED("resetIncapacitatedReqDelayID")] 
		public gameDelayID ResetIncapacitatedReqDelayID
		{
			get => GetProperty(ref _resetIncapacitatedReqDelayID);
			set => SetProperty(ref _resetIncapacitatedReqDelayID, value);
		}

		[Ordinal(42)] 
		[RED("resetDownedReqDelayID")] 
		public gameDelayID ResetDownedReqDelayID
		{
			get => GetProperty(ref _resetDownedReqDelayID);
			set => SetProperty(ref _resetDownedReqDelayID, value);
		}

		[Ordinal(43)] 
		[RED("resetMeleeAttackReqDelayID")] 
		public gameDelayID ResetMeleeAttackReqDelayID
		{
			get => GetProperty(ref _resetMeleeAttackReqDelayID);
			set => SetProperty(ref _resetMeleeAttackReqDelayID, value);
		}

		[Ordinal(44)] 
		[RED("resetRangedAttackReqDelayID")] 
		public gameDelayID ResetRangedAttackReqDelayID
		{
			get => GetProperty(ref _resetRangedAttackReqDelayID);
			set => SetProperty(ref _resetRangedAttackReqDelayID, value);
		}

		[Ordinal(45)] 
		[RED("resetAttackReqDelayID")] 
		public gameDelayID ResetAttackReqDelayID
		{
			get => GetProperty(ref _resetAttackReqDelayID);
			set => SetProperty(ref _resetAttackReqDelayID, value);
		}

		[Ordinal(46)] 
		[RED("resetNpcMeleeLightAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeLightAttackReqDelayID
		{
			get => GetProperty(ref _resetNpcMeleeLightAttackReqDelayID);
			set => SetProperty(ref _resetNpcMeleeLightAttackReqDelayID, value);
		}

		[Ordinal(47)] 
		[RED("resetNpcMeleeStrongAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeStrongAttackReqDelayID
		{
			get => GetProperty(ref _resetNpcMeleeStrongAttackReqDelayID);
			set => SetProperty(ref _resetNpcMeleeStrongAttackReqDelayID, value);
		}

		[Ordinal(48)] 
		[RED("resetNpcMeleeFinalAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeFinalAttackReqDelayID
		{
			get => GetProperty(ref _resetNpcMeleeFinalAttackReqDelayID);
			set => SetProperty(ref _resetNpcMeleeFinalAttackReqDelayID, value);
		}

		[Ordinal(49)] 
		[RED("resetNpcMeleeBlockAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeBlockAttackReqDelayID
		{
			get => GetProperty(ref _resetNpcMeleeBlockAttackReqDelayID);
			set => SetProperty(ref _resetNpcMeleeBlockAttackReqDelayID, value);
		}

		[Ordinal(50)] 
		[RED("resetNpcBlockedReqDelayID")] 
		public gameDelayID ResetNpcBlockedReqDelayID
		{
			get => GetProperty(ref _resetNpcBlockedReqDelayID);
			set => SetProperty(ref _resetNpcBlockedReqDelayID, value);
		}

		[Ordinal(51)] 
		[RED("resetNpcDeflectedReqDelayID")] 
		public gameDelayID ResetNpcDeflectedReqDelayID
		{
			get => GetProperty(ref _resetNpcDeflectedReqDelayID);
			set => SetProperty(ref _resetNpcDeflectedReqDelayID, value);
		}

		[Ordinal(52)] 
		[RED("resetNpcGuardbreakReqDelayID")] 
		public gameDelayID ResetNpcGuardbreakReqDelayID
		{
			get => GetProperty(ref _resetNpcGuardbreakReqDelayID);
			set => SetProperty(ref _resetNpcGuardbreakReqDelayID, value);
		}

		public DataTrackingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
