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
			get
			{
				if (_achievementsMask == null)
				{
					_achievementsMask = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "achievementsMask", cr2w, this);
				}
				return _achievementsMask;
			}
			set
			{
				if (_achievementsMask == value)
				{
					return;
				}
				_achievementsMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rangedAttacksMade")] 
		public CInt32 RangedAttacksMade
		{
			get
			{
				if (_rangedAttacksMade == null)
				{
					_rangedAttacksMade = (CInt32) CR2WTypeManager.Create("Int32", "rangedAttacksMade", cr2w, this);
				}
				return _rangedAttacksMade;
			}
			set
			{
				if (_rangedAttacksMade == value)
				{
					return;
				}
				_rangedAttacksMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("meleeAttacksMade")] 
		public CInt32 MeleeAttacksMade
		{
			get
			{
				if (_meleeAttacksMade == null)
				{
					_meleeAttacksMade = (CInt32) CR2WTypeManager.Create("Int32", "meleeAttacksMade", cr2w, this);
				}
				return _meleeAttacksMade;
			}
			set
			{
				if (_meleeAttacksMade == value)
				{
					return;
				}
				_meleeAttacksMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("meleeKills")] 
		public CInt32 MeleeKills
		{
			get
			{
				if (_meleeKills == null)
				{
					_meleeKills = (CInt32) CR2WTypeManager.Create("Int32", "meleeKills", cr2w, this);
				}
				return _meleeKills;
			}
			set
			{
				if (_meleeKills == value)
				{
					return;
				}
				_meleeKills = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rangedKills")] 
		public CInt32 RangedKills
		{
			get
			{
				if (_rangedKills == null)
				{
					_rangedKills = (CInt32) CR2WTypeManager.Create("Int32", "rangedKills", cr2w, this);
				}
				return _rangedKills;
			}
			set
			{
				if (_rangedKills == value)
				{
					return;
				}
				_rangedKills = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("quickhacksMade")] 
		public CInt32 QuickhacksMade
		{
			get
			{
				if (_quickhacksMade == null)
				{
					_quickhacksMade = (CInt32) CR2WTypeManager.Create("Int32", "quickhacksMade", cr2w, this);
				}
				return _quickhacksMade;
			}
			set
			{
				if (_quickhacksMade == value)
				{
					return;
				}
				_quickhacksMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("distractionsMade")] 
		public CInt32 DistractionsMade
		{
			get
			{
				if (_distractionsMade == null)
				{
					_distractionsMade = (CInt32) CR2WTypeManager.Create("Int32", "distractionsMade", cr2w, this);
				}
				return _distractionsMade;
			}
			set
			{
				if (_distractionsMade == value)
				{
					return;
				}
				_distractionsMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("legendaryItemsCrafted")] 
		public CInt32 LegendaryItemsCrafted
		{
			get
			{
				if (_legendaryItemsCrafted == null)
				{
					_legendaryItemsCrafted = (CInt32) CR2WTypeManager.Create("Int32", "legendaryItemsCrafted", cr2w, this);
				}
				return _legendaryItemsCrafted;
			}
			set
			{
				if (_legendaryItemsCrafted == value)
				{
					return;
				}
				_legendaryItemsCrafted = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("npcMeleeLightAttackReceived")] 
		public CInt32 NpcMeleeLightAttackReceived
		{
			get
			{
				if (_npcMeleeLightAttackReceived == null)
				{
					_npcMeleeLightAttackReceived = (CInt32) CR2WTypeManager.Create("Int32", "npcMeleeLightAttackReceived", cr2w, this);
				}
				return _npcMeleeLightAttackReceived;
			}
			set
			{
				if (_npcMeleeLightAttackReceived == value)
				{
					return;
				}
				_npcMeleeLightAttackReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("npcMeleeStrongAttackReceived")] 
		public CInt32 NpcMeleeStrongAttackReceived
		{
			get
			{
				if (_npcMeleeStrongAttackReceived == null)
				{
					_npcMeleeStrongAttackReceived = (CInt32) CR2WTypeManager.Create("Int32", "npcMeleeStrongAttackReceived", cr2w, this);
				}
				return _npcMeleeStrongAttackReceived;
			}
			set
			{
				if (_npcMeleeStrongAttackReceived == value)
				{
					return;
				}
				_npcMeleeStrongAttackReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("npcMeleeBlockAttackReceived")] 
		public CInt32 NpcMeleeBlockAttackReceived
		{
			get
			{
				if (_npcMeleeBlockAttackReceived == null)
				{
					_npcMeleeBlockAttackReceived = (CInt32) CR2WTypeManager.Create("Int32", "npcMeleeBlockAttackReceived", cr2w, this);
				}
				return _npcMeleeBlockAttackReceived;
			}
			set
			{
				if (_npcMeleeBlockAttackReceived == value)
				{
					return;
				}
				_npcMeleeBlockAttackReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("npcMeleeBlockedAttacks")] 
		public CInt32 NpcMeleeBlockedAttacks
		{
			get
			{
				if (_npcMeleeBlockedAttacks == null)
				{
					_npcMeleeBlockedAttacks = (CInt32) CR2WTypeManager.Create("Int32", "npcMeleeBlockedAttacks", cr2w, this);
				}
				return _npcMeleeBlockedAttacks;
			}
			set
			{
				if (_npcMeleeBlockedAttacks == value)
				{
					return;
				}
				_npcMeleeBlockedAttacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("npcMeleeDeflectedAttacks")] 
		public CInt32 NpcMeleeDeflectedAttacks
		{
			get
			{
				if (_npcMeleeDeflectedAttacks == null)
				{
					_npcMeleeDeflectedAttacks = (CInt32) CR2WTypeManager.Create("Int32", "npcMeleeDeflectedAttacks", cr2w, this);
				}
				return _npcMeleeDeflectedAttacks;
			}
			set
			{
				if (_npcMeleeDeflectedAttacks == value)
				{
					return;
				}
				_npcMeleeDeflectedAttacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("downedEnemies")] 
		public CInt32 DownedEnemies
		{
			get
			{
				if (_downedEnemies == null)
				{
					_downedEnemies = (CInt32) CR2WTypeManager.Create("Int32", "downedEnemies", cr2w, this);
				}
				return _downedEnemies;
			}
			set
			{
				if (_downedEnemies == value)
				{
					return;
				}
				_downedEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("killedEnemies")] 
		public CInt32 KilledEnemies
		{
			get
			{
				if (_killedEnemies == null)
				{
					_killedEnemies = (CInt32) CR2WTypeManager.Create("Int32", "killedEnemies", cr2w, this);
				}
				return _killedEnemies;
			}
			set
			{
				if (_killedEnemies == value)
				{
					return;
				}
				_killedEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("defeatedEnemies")] 
		public CInt32 DefeatedEnemies
		{
			get
			{
				if (_defeatedEnemies == null)
				{
					_defeatedEnemies = (CInt32) CR2WTypeManager.Create("Int32", "defeatedEnemies", cr2w, this);
				}
				return _defeatedEnemies;
			}
			set
			{
				if (_defeatedEnemies == value)
				{
					return;
				}
				_defeatedEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("incapacitatedEnemies")] 
		public CInt32 IncapacitatedEnemies
		{
			get
			{
				if (_incapacitatedEnemies == null)
				{
					_incapacitatedEnemies = (CInt32) CR2WTypeManager.Create("Int32", "incapacitatedEnemies", cr2w, this);
				}
				return _incapacitatedEnemies;
			}
			set
			{
				if (_incapacitatedEnemies == value)
				{
					return;
				}
				_incapacitatedEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("finishedEnemies")] 
		public CInt32 FinishedEnemies
		{
			get
			{
				if (_finishedEnemies == null)
				{
					_finishedEnemies = (CInt32) CR2WTypeManager.Create("Int32", "finishedEnemies", cr2w, this);
				}
				return _finishedEnemies;
			}
			set
			{
				if (_finishedEnemies == value)
				{
					return;
				}
				_finishedEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("downedWithRanged")] 
		public CInt32 DownedWithRanged
		{
			get
			{
				if (_downedWithRanged == null)
				{
					_downedWithRanged = (CInt32) CR2WTypeManager.Create("Int32", "downedWithRanged", cr2w, this);
				}
				return _downedWithRanged;
			}
			set
			{
				if (_downedWithRanged == value)
				{
					return;
				}
				_downedWithRanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("downedWithMelee")] 
		public CInt32 DownedWithMelee
		{
			get
			{
				if (_downedWithMelee == null)
				{
					_downedWithMelee = (CInt32) CR2WTypeManager.Create("Int32", "downedWithMelee", cr2w, this);
				}
				return _downedWithMelee;
			}
			set
			{
				if (_downedWithMelee == value)
				{
					return;
				}
				_downedWithMelee = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("downedInTimeDilatation")] 
		public CInt32 DownedInTimeDilatation
		{
			get
			{
				if (_downedInTimeDilatation == null)
				{
					_downedInTimeDilatation = (CInt32) CR2WTypeManager.Create("Int32", "downedInTimeDilatation", cr2w, this);
				}
				return _downedInTimeDilatation;
			}
			set
			{
				if (_downedInTimeDilatation == value)
				{
					return;
				}
				_downedInTimeDilatation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rangedProgress")] 
		public CInt32 RangedProgress
		{
			get
			{
				if (_rangedProgress == null)
				{
					_rangedProgress = (CInt32) CR2WTypeManager.Create("Int32", "rangedProgress", cr2w, this);
				}
				return _rangedProgress;
			}
			set
			{
				if (_rangedProgress == value)
				{
					return;
				}
				_rangedProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("meleeProgress")] 
		public CInt32 MeleeProgress
		{
			get
			{
				if (_meleeProgress == null)
				{
					_meleeProgress = (CInt32) CR2WTypeManager.Create("Int32", "meleeProgress", cr2w, this);
				}
				return _meleeProgress;
			}
			set
			{
				if (_meleeProgress == value)
				{
					return;
				}
				_meleeProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("dilationProgress")] 
		public CInt32 DilationProgress
		{
			get
			{
				if (_dilationProgress == null)
				{
					_dilationProgress = (CInt32) CR2WTypeManager.Create("Int32", "dilationProgress", cr2w, this);
				}
				return _dilationProgress;
			}
			set
			{
				if (_dilationProgress == value)
				{
					return;
				}
				_dilationProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("failedShardDrops")] 
		public CFloat FailedShardDrops
		{
			get
			{
				if (_failedShardDrops == null)
				{
					_failedShardDrops = (CFloat) CR2WTypeManager.Create("Float", "failedShardDrops", cr2w, this);
				}
				return _failedShardDrops;
			}
			set
			{
				if (_failedShardDrops == value)
				{
					return;
				}
				_failedShardDrops = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("bluelinesUseCount")] 
		public CInt32 BluelinesUseCount
		{
			get
			{
				if (_bluelinesUseCount == null)
				{
					_bluelinesUseCount = (CInt32) CR2WTypeManager.Create("Int32", "bluelinesUseCount", cr2w, this);
				}
				return _bluelinesUseCount;
			}
			set
			{
				if (_bluelinesUseCount == value)
				{
					return;
				}
				_bluelinesUseCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("twoHeadssourceID")] 
		public entEntityID TwoHeadssourceID
		{
			get
			{
				if (_twoHeadssourceID == null)
				{
					_twoHeadssourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "twoHeadssourceID", cr2w, this);
				}
				return _twoHeadssourceID;
			}
			set
			{
				if (_twoHeadssourceID == value)
				{
					return;
				}
				_twoHeadssourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("twoHeadsValidTimestamp")] 
		public CFloat TwoHeadsValidTimestamp
		{
			get
			{
				if (_twoHeadsValidTimestamp == null)
				{
					_twoHeadsValidTimestamp = (CFloat) CR2WTypeManager.Create("Float", "twoHeadsValidTimestamp", cr2w, this);
				}
				return _twoHeadsValidTimestamp;
			}
			set
			{
				if (_twoHeadsValidTimestamp == value)
				{
					return;
				}
				_twoHeadsValidTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("lastKillTimestamp")] 
		public CFloat LastKillTimestamp
		{
			get
			{
				if (_lastKillTimestamp == null)
				{
					_lastKillTimestamp = (CFloat) CR2WTypeManager.Create("Float", "lastKillTimestamp", cr2w, this);
				}
				return _lastKillTimestamp;
			}
			set
			{
				if (_lastKillTimestamp == value)
				{
					return;
				}
				_lastKillTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("enemiesKilledInTimeInterval")] 
		public CArray<wCHandle<gameObject>> EnemiesKilledInTimeInterval
		{
			get
			{
				if (_enemiesKilledInTimeInterval == null)
				{
					_enemiesKilledInTimeInterval = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "enemiesKilledInTimeInterval", cr2w, this);
				}
				return _enemiesKilledInTimeInterval;
			}
			set
			{
				if (_enemiesKilledInTimeInterval == value)
				{
					return;
				}
				_enemiesKilledInTimeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get
			{
				if (_timeInterval == null)
				{
					_timeInterval = (CFloat) CR2WTypeManager.Create("Float", "timeInterval", cr2w, this);
				}
				return _timeInterval;
			}
			set
			{
				if (_timeInterval == value)
				{
					return;
				}
				_timeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("numerOfKillsRequired")] 
		public CInt32 NumerOfKillsRequired
		{
			get
			{
				if (_numerOfKillsRequired == null)
				{
					_numerOfKillsRequired = (CInt32) CR2WTypeManager.Create("Int32", "numerOfKillsRequired", cr2w, this);
				}
				return _numerOfKillsRequired;
			}
			set
			{
				if (_numerOfKillsRequired == value)
				{
					return;
				}
				_numerOfKillsRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("gunKataInProgress")] 
		public CBool GunKataInProgress
		{
			get
			{
				if (_gunKataInProgress == null)
				{
					_gunKataInProgress = (CBool) CR2WTypeManager.Create("Bool", "gunKataInProgress", cr2w, this);
				}
				return _gunKataInProgress;
			}
			set
			{
				if (_gunKataInProgress == value)
				{
					return;
				}
				_gunKataInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("gunKataKilledEnemies")] 
		public CInt32 GunKataKilledEnemies
		{
			get
			{
				if (_gunKataKilledEnemies == null)
				{
					_gunKataKilledEnemies = (CInt32) CR2WTypeManager.Create("Int32", "gunKataKilledEnemies", cr2w, this);
				}
				return _gunKataKilledEnemies;
			}
			set
			{
				if (_gunKataKilledEnemies == value)
				{
					return;
				}
				_gunKataKilledEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("gunKataValidTimestamp")] 
		public CFloat GunKataValidTimestamp
		{
			get
			{
				if (_gunKataValidTimestamp == null)
				{
					_gunKataValidTimestamp = (CFloat) CR2WTypeManager.Create("Float", "gunKataValidTimestamp", cr2w, this);
				}
				return _gunKataValidTimestamp;
			}
			set
			{
				if (_gunKataValidTimestamp == value)
				{
					return;
				}
				_gunKataValidTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("hardKneesInProgress")] 
		public CBool HardKneesInProgress
		{
			get
			{
				if (_hardKneesInProgress == null)
				{
					_hardKneesInProgress = (CBool) CR2WTypeManager.Create("Bool", "hardKneesInProgress", cr2w, this);
				}
				return _hardKneesInProgress;
			}
			set
			{
				if (_hardKneesInProgress == value)
				{
					return;
				}
				_hardKneesInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("hardKneesKilledEnemies")] 
		public CInt32 HardKneesKilledEnemies
		{
			get
			{
				if (_hardKneesKilledEnemies == null)
				{
					_hardKneesKilledEnemies = (CInt32) CR2WTypeManager.Create("Int32", "hardKneesKilledEnemies", cr2w, this);
				}
				return _hardKneesKilledEnemies;
			}
			set
			{
				if (_hardKneesKilledEnemies == value)
				{
					return;
				}
				_hardKneesKilledEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("harKneesValidTimestamp")] 
		public CFloat HarKneesValidTimestamp
		{
			get
			{
				if (_harKneesValidTimestamp == null)
				{
					_harKneesValidTimestamp = (CFloat) CR2WTypeManager.Create("Float", "harKneesValidTimestamp", cr2w, this);
				}
				return _harKneesValidTimestamp;
			}
			set
			{
				if (_harKneesValidTimestamp == value)
				{
					return;
				}
				_harKneesValidTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("resetKilledReqDelayID")] 
		public gameDelayID ResetKilledReqDelayID
		{
			get
			{
				if (_resetKilledReqDelayID == null)
				{
					_resetKilledReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetKilledReqDelayID", cr2w, this);
				}
				return _resetKilledReqDelayID;
			}
			set
			{
				if (_resetKilledReqDelayID == value)
				{
					return;
				}
				_resetKilledReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("resetFinishedReqDelayID")] 
		public gameDelayID ResetFinishedReqDelayID
		{
			get
			{
				if (_resetFinishedReqDelayID == null)
				{
					_resetFinishedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetFinishedReqDelayID", cr2w, this);
				}
				return _resetFinishedReqDelayID;
			}
			set
			{
				if (_resetFinishedReqDelayID == value)
				{
					return;
				}
				_resetFinishedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("resetDefeatedReqDelayID")] 
		public gameDelayID ResetDefeatedReqDelayID
		{
			get
			{
				if (_resetDefeatedReqDelayID == null)
				{
					_resetDefeatedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetDefeatedReqDelayID", cr2w, this);
				}
				return _resetDefeatedReqDelayID;
			}
			set
			{
				if (_resetDefeatedReqDelayID == value)
				{
					return;
				}
				_resetDefeatedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("resetIncapacitatedReqDelayID")] 
		public gameDelayID ResetIncapacitatedReqDelayID
		{
			get
			{
				if (_resetIncapacitatedReqDelayID == null)
				{
					_resetIncapacitatedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetIncapacitatedReqDelayID", cr2w, this);
				}
				return _resetIncapacitatedReqDelayID;
			}
			set
			{
				if (_resetIncapacitatedReqDelayID == value)
				{
					return;
				}
				_resetIncapacitatedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("resetDownedReqDelayID")] 
		public gameDelayID ResetDownedReqDelayID
		{
			get
			{
				if (_resetDownedReqDelayID == null)
				{
					_resetDownedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetDownedReqDelayID", cr2w, this);
				}
				return _resetDownedReqDelayID;
			}
			set
			{
				if (_resetDownedReqDelayID == value)
				{
					return;
				}
				_resetDownedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("resetMeleeAttackReqDelayID")] 
		public gameDelayID ResetMeleeAttackReqDelayID
		{
			get
			{
				if (_resetMeleeAttackReqDelayID == null)
				{
					_resetMeleeAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetMeleeAttackReqDelayID", cr2w, this);
				}
				return _resetMeleeAttackReqDelayID;
			}
			set
			{
				if (_resetMeleeAttackReqDelayID == value)
				{
					return;
				}
				_resetMeleeAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("resetRangedAttackReqDelayID")] 
		public gameDelayID ResetRangedAttackReqDelayID
		{
			get
			{
				if (_resetRangedAttackReqDelayID == null)
				{
					_resetRangedAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetRangedAttackReqDelayID", cr2w, this);
				}
				return _resetRangedAttackReqDelayID;
			}
			set
			{
				if (_resetRangedAttackReqDelayID == value)
				{
					return;
				}
				_resetRangedAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("resetAttackReqDelayID")] 
		public gameDelayID ResetAttackReqDelayID
		{
			get
			{
				if (_resetAttackReqDelayID == null)
				{
					_resetAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetAttackReqDelayID", cr2w, this);
				}
				return _resetAttackReqDelayID;
			}
			set
			{
				if (_resetAttackReqDelayID == value)
				{
					return;
				}
				_resetAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("resetNpcMeleeLightAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeLightAttackReqDelayID
		{
			get
			{
				if (_resetNpcMeleeLightAttackReqDelayID == null)
				{
					_resetNpcMeleeLightAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcMeleeLightAttackReqDelayID", cr2w, this);
				}
				return _resetNpcMeleeLightAttackReqDelayID;
			}
			set
			{
				if (_resetNpcMeleeLightAttackReqDelayID == value)
				{
					return;
				}
				_resetNpcMeleeLightAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("resetNpcMeleeStrongAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeStrongAttackReqDelayID
		{
			get
			{
				if (_resetNpcMeleeStrongAttackReqDelayID == null)
				{
					_resetNpcMeleeStrongAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcMeleeStrongAttackReqDelayID", cr2w, this);
				}
				return _resetNpcMeleeStrongAttackReqDelayID;
			}
			set
			{
				if (_resetNpcMeleeStrongAttackReqDelayID == value)
				{
					return;
				}
				_resetNpcMeleeStrongAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("resetNpcMeleeFinalAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeFinalAttackReqDelayID
		{
			get
			{
				if (_resetNpcMeleeFinalAttackReqDelayID == null)
				{
					_resetNpcMeleeFinalAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcMeleeFinalAttackReqDelayID", cr2w, this);
				}
				return _resetNpcMeleeFinalAttackReqDelayID;
			}
			set
			{
				if (_resetNpcMeleeFinalAttackReqDelayID == value)
				{
					return;
				}
				_resetNpcMeleeFinalAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("resetNpcMeleeBlockAttackReqDelayID")] 
		public gameDelayID ResetNpcMeleeBlockAttackReqDelayID
		{
			get
			{
				if (_resetNpcMeleeBlockAttackReqDelayID == null)
				{
					_resetNpcMeleeBlockAttackReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcMeleeBlockAttackReqDelayID", cr2w, this);
				}
				return _resetNpcMeleeBlockAttackReqDelayID;
			}
			set
			{
				if (_resetNpcMeleeBlockAttackReqDelayID == value)
				{
					return;
				}
				_resetNpcMeleeBlockAttackReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("resetNpcBlockedReqDelayID")] 
		public gameDelayID ResetNpcBlockedReqDelayID
		{
			get
			{
				if (_resetNpcBlockedReqDelayID == null)
				{
					_resetNpcBlockedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcBlockedReqDelayID", cr2w, this);
				}
				return _resetNpcBlockedReqDelayID;
			}
			set
			{
				if (_resetNpcBlockedReqDelayID == value)
				{
					return;
				}
				_resetNpcBlockedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("resetNpcDeflectedReqDelayID")] 
		public gameDelayID ResetNpcDeflectedReqDelayID
		{
			get
			{
				if (_resetNpcDeflectedReqDelayID == null)
				{
					_resetNpcDeflectedReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcDeflectedReqDelayID", cr2w, this);
				}
				return _resetNpcDeflectedReqDelayID;
			}
			set
			{
				if (_resetNpcDeflectedReqDelayID == value)
				{
					return;
				}
				_resetNpcDeflectedReqDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("resetNpcGuardbreakReqDelayID")] 
		public gameDelayID ResetNpcGuardbreakReqDelayID
		{
			get
			{
				if (_resetNpcGuardbreakReqDelayID == null)
				{
					_resetNpcGuardbreakReqDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resetNpcGuardbreakReqDelayID", cr2w, this);
				}
				return _resetNpcGuardbreakReqDelayID;
			}
			set
			{
				if (_resetNpcGuardbreakReqDelayID == value)
				{
					return;
				}
				_resetNpcGuardbreakReqDelayID = value;
				PropertySet(this);
			}
		}

		public DataTrackingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
