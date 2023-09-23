using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTrackingSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("achievementEnumKeyMap")] 
		public CArray<CInt32> AchievementEnumKeyMap
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("achievementsMask")] 
		public CArray<CBool> AchievementsMask
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(2)] 
		[RED("rangedAttacksMade")] 
		public CInt32 RangedAttacksMade
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("meleeAttacksMade")] 
		public CInt32 MeleeAttacksMade
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("meleeKills")] 
		public CInt32 MeleeKills
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("rangedKills")] 
		public CInt32 RangedKills
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("quickhacksMade")] 
		public CInt32 QuickhacksMade
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("distractionsMade")] 
		public CInt32 DistractionsMade
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("legendaryItemsCrafted")] 
		public CInt32 LegendaryItemsCrafted
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("npcMeleeLightAttackReceived")] 
		public CInt32 NpcMeleeLightAttackReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("npcMeleeStrongAttackReceived")] 
		public CInt32 NpcMeleeStrongAttackReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("npcMeleeBlockAttackReceived")] 
		public CInt32 NpcMeleeBlockAttackReceived
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("npcMeleeBlockedAttacks")] 
		public CInt32 NpcMeleeBlockedAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("npcMeleeDeflectedAttacks")] 
		public CInt32 NpcMeleeDeflectedAttacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("downedEnemies")] 
		public CInt32 DownedEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("killedEnemies")] 
		public CInt32 KilledEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("defeatedEnemies")] 
		public CInt32 DefeatedEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("incapacitatedEnemies")] 
		public CInt32 IncapacitatedEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("finishedEnemies")] 
		public CInt32 FinishedEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("downedWithRanged")] 
		public CInt32 DownedWithRanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("downedWithMelee")] 
		public CInt32 DownedWithMelee
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("downedInTimeDilatation")] 
		public CInt32 DownedInTimeDilatation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("rangedProgress")] 
		public CInt32 RangedProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("meleeProgress")] 
		public CInt32 MeleeProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("dilationProgress")] 
		public CInt32 DilationProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("failedShardDrops")] 
		public CFloat FailedShardDrops
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("LegPlusPlusHackDropped")] 
		public CBool LegPlusPlusHackDropped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("bluelinesUseCount")] 
		public CInt32 BluelinesUseCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("twoHeadssourceID")] 
		public entEntityID TwoHeadssourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(29)] 
		[RED("twoHeadsValidTimestamp")] 
		public CFloat TwoHeadsValidTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("lastKillTimestamp")] 
		public CFloat LastKillTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("enemiesKilledInTimeInterval")] 
		public CArray<CWeakHandle<gameObject>> EnemiesKilledInTimeInterval
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(32)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("numerOfKillsRequired")] 
		public CInt32 NumerOfKillsRequired
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(34)] 
		[RED("gunKataKilledEnemies")] 
		public CInt32 GunKataKilledEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("gunKataValidTimestamp")] 
		public CFloat GunKataValidTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("hardKneesInProgress")] 
		public CBool HardKneesInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("hardKneesKilledEnemies")] 
		public CInt32 HardKneesKilledEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(38)] 
		[RED("harKneesValidTimestamp")] 
		public CFloat HarKneesValidTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("resetKilledReqDelayID")] 
		public gameDelayID ResetKilledReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(40)] 
		[RED("resetFinishedReqDelayID")] 
		public gameDelayID ResetFinishedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(41)] 
		[RED("resetDefeatedReqDelayID")] 
		public gameDelayID ResetDefeatedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(42)] 
		[RED("resetIncapacitatedReqDelayID")] 
		public gameDelayID ResetIncapacitatedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(43)] 
		[RED("resetDownedReqDelayID")] 
		public gameDelayID ResetDownedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(44)] 
		[RED("resetMeleeAttackReqDelayID")] 
		public gameDelayID ResetMeleeAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(45)] 
		[RED("resetRangedAttackReqDelayID")] 
		public gameDelayID ResetRangedAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(46)] 
		[RED("resetAttackReqDelayID")] 
		public gameDelayID ResetAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(47)] 
		[RED("resetNpcMeleeLightAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeLightAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(48)] 
		[RED("resetNpcMeleeStrongAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeStrongAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(49)] 
		[RED("resetNpcMeleeFinalAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeFinalAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(50)] 
		[RED("resetNpcMeleeBlockAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeBlockAttackReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(51)] 
		[RED("resetNpcBlockedReqDelayID")] 
		public gameDelayID ResetNpcBlockedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(52)] 
		[RED("resetNpcDeflectedReqDelayID")] 
		public gameDelayID ResetNpcDeflectedReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(53)] 
		[RED("resetNpcGuardbreakReqDelayID")] 
		public gameDelayID ResetNpcGuardbreakReqDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public DataTrackingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
