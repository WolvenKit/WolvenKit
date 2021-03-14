using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCPuppet : ScriptedPuppet
	{
		private CHandle<gameeventsHitEvent> _lastHitEvent;
		private CFloat _totalFrameReactionDamageReceived;
		private CFloat _totalFrameWoundsDamageReceived;
		private CFloat _totalFrameDismembermentDamageReceived;
		private ScriptReentrantRWLock _hitEventLock;
		private CHandle<NPCManager> _nPCManager;
		private CInt32 _customDeathDirection;
		private CBool _deathOverrideState;
		private CBool _agonyState;
		private CBool _defensiveState;
		private CHandle<gameSetupWorkspotActionEvent> _lastSetupWorkspotActionEvent;
		private CBool _wasJustKilledOrDefeated;
		private CBool _shouldDie;
		private CBool _shouldBeDefeated;
		private CBool _sentDownedEvent;
		private CBool _isRagdolling;
		private CBool _hasAnimatedRagdoll;
		private CBool _disableCollisionRequested;
		private wCHandle<gameObject> _ragdollInstigator;
		private CInt32 _ragdollSplattersSpawned;
		private CBool _ragdollFloorSplashSpawned;
		private entRagdollImpactPointData _ragdollImpactData;
		private RagdollDamagePollData _ragdollDamageData;
		private Vector4 _ragdollInitialPosition;
		private CFloat _ragdollActivationTimestamp;
		private CArray<wCHandle<entEntity>> _ragdolledEntities;
		private CBool _isNotVisible;
		private CHandle<NPCDeathListener> _deathListener;
		private CHandle<NPCGodModeListener> _godModeStatListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entIComponent> _npcRagdollComponent;
		private CArray<CHandle<entIComponent>> _npcMountedToPlayerComponents;
		private CHandle<ScavengeComponent> _scavengeComponent;
		private CHandle<gameinfluenceComponent> _influenceComponent;
		private CHandle<entIComponent> _comfortZoneComponent;
		private CBool _isTargetingPlayer;
		private CHandle<gameScriptStatsListener> _playerStatsListener;
		private CUInt32 _upperBodyStateCallbackID;
		private CUInt32 _leftCyberwareStateCallbackID;
		private CUInt32 _meleeStateCallbackID;
		private CUInt32 _combatGadgetStateCallbackID;
		private CBool _wasAimedAtLast;
		private CBool _wasCWChargedAtLast;
		private CBool _wasMeleeChargedAtLast;
		private CBool _wasChargingGadgetAtLast;
		private CBool _isLookedAt;
		private entEntityID _cachedPlayerID;
		private CBool _canGoThroughDoors;
		private wCHandle<gamedataStatusEffect_Record> _lastStatusEffectSignalSent;
		private wCHandle<gamedataStatusEffect_Record> _cachedStatusEffectAnim;
		private gameDelayID _resendStatusEffectSignalDelayID;
		private CHandle<gameStatusEffect> _lastSEAppliedByPlayer;
		private CHandle<gameeventsApplyStatusEffectEvent> _pendingSEEvent;
		private Bounty _bounty;
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _cachedVFXList;
		private CArray<wCHandle<gamedataStatusEffectFX_Record>> _cachedSFXList;
		private CBool _isThrowingGrenadeToPlayer;
		private gameDelayID _throwingGrenadeDelayEventID;
		private wCHandle<gameObject> _myKiller;
		private CEnum<EAIThreatCalculationType> _primaryThreatCalculationType;
		private CEnum<EAIThreatCalculationType> _temporaryThreatCalculationType;
		private CBool _isPlayerCompanionCached;
		private CFloat _isPlayerCompanionCachedTimeStamp;
		private CUInt32 _quickHackEffectsApplied;
		private CHandle<gameConstantStatModifierData> _hackingResistanceMod;
		private gameDelayID _delayNonStealthQuickHackVictimEventID;
		private CInt32 _cachedIsPaperdoll;
		private gameDelayID _smartDespawnDelayID;
		private CUInt32 _despawnTicks;

		[Ordinal(96)] 
		[RED("lastHitEvent")] 
		public CHandle<gameeventsHitEvent> LastHitEvent
		{
			get
			{
				if (_lastHitEvent == null)
				{
					_lastHitEvent = (CHandle<gameeventsHitEvent>) CR2WTypeManager.Create("handle:gameeventsHitEvent", "lastHitEvent", cr2w, this);
				}
				return _lastHitEvent;
			}
			set
			{
				if (_lastHitEvent == value)
				{
					return;
				}
				_lastHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("totalFrameReactionDamageReceived")] 
		public CFloat TotalFrameReactionDamageReceived
		{
			get
			{
				if (_totalFrameReactionDamageReceived == null)
				{
					_totalFrameReactionDamageReceived = (CFloat) CR2WTypeManager.Create("Float", "totalFrameReactionDamageReceived", cr2w, this);
				}
				return _totalFrameReactionDamageReceived;
			}
			set
			{
				if (_totalFrameReactionDamageReceived == value)
				{
					return;
				}
				_totalFrameReactionDamageReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("totalFrameWoundsDamageReceived")] 
		public CFloat TotalFrameWoundsDamageReceived
		{
			get
			{
				if (_totalFrameWoundsDamageReceived == null)
				{
					_totalFrameWoundsDamageReceived = (CFloat) CR2WTypeManager.Create("Float", "totalFrameWoundsDamageReceived", cr2w, this);
				}
				return _totalFrameWoundsDamageReceived;
			}
			set
			{
				if (_totalFrameWoundsDamageReceived == value)
				{
					return;
				}
				_totalFrameWoundsDamageReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("totalFrameDismembermentDamageReceived")] 
		public CFloat TotalFrameDismembermentDamageReceived
		{
			get
			{
				if (_totalFrameDismembermentDamageReceived == null)
				{
					_totalFrameDismembermentDamageReceived = (CFloat) CR2WTypeManager.Create("Float", "totalFrameDismembermentDamageReceived", cr2w, this);
				}
				return _totalFrameDismembermentDamageReceived;
			}
			set
			{
				if (_totalFrameDismembermentDamageReceived == value)
				{
					return;
				}
				_totalFrameDismembermentDamageReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("hitEventLock")] 
		public ScriptReentrantRWLock HitEventLock
		{
			get
			{
				if (_hitEventLock == null)
				{
					_hitEventLock = (ScriptReentrantRWLock) CR2WTypeManager.Create("ScriptReentrantRWLock", "hitEventLock", cr2w, this);
				}
				return _hitEventLock;
			}
			set
			{
				if (_hitEventLock == value)
				{
					return;
				}
				_hitEventLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("NPCManager")] 
		public CHandle<NPCManager> NPCManager
		{
			get
			{
				if (_nPCManager == null)
				{
					_nPCManager = (CHandle<NPCManager>) CR2WTypeManager.Create("handle:NPCManager", "NPCManager", cr2w, this);
				}
				return _nPCManager;
			}
			set
			{
				if (_nPCManager == value)
				{
					return;
				}
				_nPCManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("customDeathDirection")] 
		public CInt32 CustomDeathDirection
		{
			get
			{
				if (_customDeathDirection == null)
				{
					_customDeathDirection = (CInt32) CR2WTypeManager.Create("Int32", "customDeathDirection", cr2w, this);
				}
				return _customDeathDirection;
			}
			set
			{
				if (_customDeathDirection == value)
				{
					return;
				}
				_customDeathDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("deathOverrideState")] 
		public CBool DeathOverrideState
		{
			get
			{
				if (_deathOverrideState == null)
				{
					_deathOverrideState = (CBool) CR2WTypeManager.Create("Bool", "deathOverrideState", cr2w, this);
				}
				return _deathOverrideState;
			}
			set
			{
				if (_deathOverrideState == value)
				{
					return;
				}
				_deathOverrideState = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("agonyState")] 
		public CBool AgonyState
		{
			get
			{
				if (_agonyState == null)
				{
					_agonyState = (CBool) CR2WTypeManager.Create("Bool", "agonyState", cr2w, this);
				}
				return _agonyState;
			}
			set
			{
				if (_agonyState == value)
				{
					return;
				}
				_agonyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("defensiveState")] 
		public CBool DefensiveState
		{
			get
			{
				if (_defensiveState == null)
				{
					_defensiveState = (CBool) CR2WTypeManager.Create("Bool", "defensiveState", cr2w, this);
				}
				return _defensiveState;
			}
			set
			{
				if (_defensiveState == value)
				{
					return;
				}
				_defensiveState = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("lastSetupWorkspotActionEvent")] 
		public CHandle<gameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent
		{
			get
			{
				if (_lastSetupWorkspotActionEvent == null)
				{
					_lastSetupWorkspotActionEvent = (CHandle<gameSetupWorkspotActionEvent>) CR2WTypeManager.Create("handle:gameSetupWorkspotActionEvent", "lastSetupWorkspotActionEvent", cr2w, this);
				}
				return _lastSetupWorkspotActionEvent;
			}
			set
			{
				if (_lastSetupWorkspotActionEvent == value)
				{
					return;
				}
				_lastSetupWorkspotActionEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("wasJustKilledOrDefeated")] 
		public CBool WasJustKilledOrDefeated
		{
			get
			{
				if (_wasJustKilledOrDefeated == null)
				{
					_wasJustKilledOrDefeated = (CBool) CR2WTypeManager.Create("Bool", "wasJustKilledOrDefeated", cr2w, this);
				}
				return _wasJustKilledOrDefeated;
			}
			set
			{
				if (_wasJustKilledOrDefeated == value)
				{
					return;
				}
				_wasJustKilledOrDefeated = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("shouldDie")] 
		public CBool ShouldDie
		{
			get
			{
				if (_shouldDie == null)
				{
					_shouldDie = (CBool) CR2WTypeManager.Create("Bool", "shouldDie", cr2w, this);
				}
				return _shouldDie;
			}
			set
			{
				if (_shouldDie == value)
				{
					return;
				}
				_shouldDie = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("shouldBeDefeated")] 
		public CBool ShouldBeDefeated
		{
			get
			{
				if (_shouldBeDefeated == null)
				{
					_shouldBeDefeated = (CBool) CR2WTypeManager.Create("Bool", "shouldBeDefeated", cr2w, this);
				}
				return _shouldBeDefeated;
			}
			set
			{
				if (_shouldBeDefeated == value)
				{
					return;
				}
				_shouldBeDefeated = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("sentDownedEvent")] 
		public CBool SentDownedEvent
		{
			get
			{
				if (_sentDownedEvent == null)
				{
					_sentDownedEvent = (CBool) CR2WTypeManager.Create("Bool", "sentDownedEvent", cr2w, this);
				}
				return _sentDownedEvent;
			}
			set
			{
				if (_sentDownedEvent == value)
				{
					return;
				}
				_sentDownedEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("isRagdolling")] 
		public CBool IsRagdolling
		{
			get
			{
				if (_isRagdolling == null)
				{
					_isRagdolling = (CBool) CR2WTypeManager.Create("Bool", "isRagdolling", cr2w, this);
				}
				return _isRagdolling;
			}
			set
			{
				if (_isRagdolling == value)
				{
					return;
				}
				_isRagdolling = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("hasAnimatedRagdoll")] 
		public CBool HasAnimatedRagdoll
		{
			get
			{
				if (_hasAnimatedRagdoll == null)
				{
					_hasAnimatedRagdoll = (CBool) CR2WTypeManager.Create("Bool", "hasAnimatedRagdoll", cr2w, this);
				}
				return _hasAnimatedRagdoll;
			}
			set
			{
				if (_hasAnimatedRagdoll == value)
				{
					return;
				}
				_hasAnimatedRagdoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("disableCollisionRequested")] 
		public CBool DisableCollisionRequested
		{
			get
			{
				if (_disableCollisionRequested == null)
				{
					_disableCollisionRequested = (CBool) CR2WTypeManager.Create("Bool", "disableCollisionRequested", cr2w, this);
				}
				return _disableCollisionRequested;
			}
			set
			{
				if (_disableCollisionRequested == value)
				{
					return;
				}
				_disableCollisionRequested = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("ragdollInstigator")] 
		public wCHandle<gameObject> RagdollInstigator
		{
			get
			{
				if (_ragdollInstigator == null)
				{
					_ragdollInstigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "ragdollInstigator", cr2w, this);
				}
				return _ragdollInstigator;
			}
			set
			{
				if (_ragdollInstigator == value)
				{
					return;
				}
				_ragdollInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("ragdollSplattersSpawned")] 
		public CInt32 RagdollSplattersSpawned
		{
			get
			{
				if (_ragdollSplattersSpawned == null)
				{
					_ragdollSplattersSpawned = (CInt32) CR2WTypeManager.Create("Int32", "ragdollSplattersSpawned", cr2w, this);
				}
				return _ragdollSplattersSpawned;
			}
			set
			{
				if (_ragdollSplattersSpawned == value)
				{
					return;
				}
				_ragdollSplattersSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("ragdollFloorSplashSpawned")] 
		public CBool RagdollFloorSplashSpawned
		{
			get
			{
				if (_ragdollFloorSplashSpawned == null)
				{
					_ragdollFloorSplashSpawned = (CBool) CR2WTypeManager.Create("Bool", "ragdollFloorSplashSpawned", cr2w, this);
				}
				return _ragdollFloorSplashSpawned;
			}
			set
			{
				if (_ragdollFloorSplashSpawned == value)
				{
					return;
				}
				_ragdollFloorSplashSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("ragdollImpactData")] 
		public entRagdollImpactPointData RagdollImpactData
		{
			get
			{
				if (_ragdollImpactData == null)
				{
					_ragdollImpactData = (entRagdollImpactPointData) CR2WTypeManager.Create("entRagdollImpactPointData", "ragdollImpactData", cr2w, this);
				}
				return _ragdollImpactData;
			}
			set
			{
				if (_ragdollImpactData == value)
				{
					return;
				}
				_ragdollImpactData = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("ragdollDamageData")] 
		public RagdollDamagePollData RagdollDamageData
		{
			get
			{
				if (_ragdollDamageData == null)
				{
					_ragdollDamageData = (RagdollDamagePollData) CR2WTypeManager.Create("RagdollDamagePollData", "ragdollDamageData", cr2w, this);
				}
				return _ragdollDamageData;
			}
			set
			{
				if (_ragdollDamageData == value)
				{
					return;
				}
				_ragdollDamageData = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("ragdollInitialPosition")] 
		public Vector4 RagdollInitialPosition
		{
			get
			{
				if (_ragdollInitialPosition == null)
				{
					_ragdollInitialPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ragdollInitialPosition", cr2w, this);
				}
				return _ragdollInitialPosition;
			}
			set
			{
				if (_ragdollInitialPosition == value)
				{
					return;
				}
				_ragdollInitialPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("ragdollActivationTimestamp")] 
		public CFloat RagdollActivationTimestamp
		{
			get
			{
				if (_ragdollActivationTimestamp == null)
				{
					_ragdollActivationTimestamp = (CFloat) CR2WTypeManager.Create("Float", "ragdollActivationTimestamp", cr2w, this);
				}
				return _ragdollActivationTimestamp;
			}
			set
			{
				if (_ragdollActivationTimestamp == value)
				{
					return;
				}
				_ragdollActivationTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("ragdolledEntities")] 
		public CArray<wCHandle<entEntity>> RagdolledEntities
		{
			get
			{
				if (_ragdolledEntities == null)
				{
					_ragdolledEntities = (CArray<wCHandle<entEntity>>) CR2WTypeManager.Create("array:whandle:entEntity", "ragdolledEntities", cr2w, this);
				}
				return _ragdolledEntities;
			}
			set
			{
				if (_ragdolledEntities == value)
				{
					return;
				}
				_ragdolledEntities = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("isNotVisible")] 
		public CBool IsNotVisible
		{
			get
			{
				if (_isNotVisible == null)
				{
					_isNotVisible = (CBool) CR2WTypeManager.Create("Bool", "isNotVisible", cr2w, this);
				}
				return _isNotVisible;
			}
			set
			{
				if (_isNotVisible == value)
				{
					return;
				}
				_isNotVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("deathListener")] 
		public CHandle<NPCDeathListener> DeathListener
		{
			get
			{
				if (_deathListener == null)
				{
					_deathListener = (CHandle<NPCDeathListener>) CR2WTypeManager.Create("handle:NPCDeathListener", "deathListener", cr2w, this);
				}
				return _deathListener;
			}
			set
			{
				if (_deathListener == value)
				{
					return;
				}
				_deathListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("godModeStatListener")] 
		public CHandle<NPCGodModeListener> GodModeStatListener
		{
			get
			{
				if (_godModeStatListener == null)
				{
					_godModeStatListener = (CHandle<NPCGodModeListener>) CR2WTypeManager.Create("handle:NPCGodModeListener", "godModeStatListener", cr2w, this);
				}
				return _godModeStatListener;
			}
			set
			{
				if (_godModeStatListener == value)
				{
					return;
				}
				_godModeStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get
			{
				if (_npcCollisionComponent == null)
				{
					_npcCollisionComponent = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "npcCollisionComponent", cr2w, this);
				}
				return _npcCollisionComponent;
			}
			set
			{
				if (_npcCollisionComponent == value)
				{
					return;
				}
				_npcCollisionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("npcRagdollComponent")] 
		public CHandle<entIComponent> NpcRagdollComponent
		{
			get
			{
				if (_npcRagdollComponent == null)
				{
					_npcRagdollComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "npcRagdollComponent", cr2w, this);
				}
				return _npcRagdollComponent;
			}
			set
			{
				if (_npcRagdollComponent == value)
				{
					return;
				}
				_npcRagdollComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("npcMountedToPlayerComponents")] 
		public CArray<CHandle<entIComponent>> NpcMountedToPlayerComponents
		{
			get
			{
				if (_npcMountedToPlayerComponents == null)
				{
					_npcMountedToPlayerComponents = (CArray<CHandle<entIComponent>>) CR2WTypeManager.Create("array:handle:entIComponent", "npcMountedToPlayerComponents", cr2w, this);
				}
				return _npcMountedToPlayerComponents;
			}
			set
			{
				if (_npcMountedToPlayerComponents == value)
				{
					return;
				}
				_npcMountedToPlayerComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("scavengeComponent")] 
		public CHandle<ScavengeComponent> ScavengeComponent
		{
			get
			{
				if (_scavengeComponent == null)
				{
					_scavengeComponent = (CHandle<ScavengeComponent>) CR2WTypeManager.Create("handle:ScavengeComponent", "scavengeComponent", cr2w, this);
				}
				return _scavengeComponent;
			}
			set
			{
				if (_scavengeComponent == value)
				{
					return;
				}
				_scavengeComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("influenceComponent")] 
		public CHandle<gameinfluenceComponent> InfluenceComponent
		{
			get
			{
				if (_influenceComponent == null)
				{
					_influenceComponent = (CHandle<gameinfluenceComponent>) CR2WTypeManager.Create("handle:gameinfluenceComponent", "influenceComponent", cr2w, this);
				}
				return _influenceComponent;
			}
			set
			{
				if (_influenceComponent == value)
				{
					return;
				}
				_influenceComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("comfortZoneComponent")] 
		public CHandle<entIComponent> ComfortZoneComponent
		{
			get
			{
				if (_comfortZoneComponent == null)
				{
					_comfortZoneComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "comfortZoneComponent", cr2w, this);
				}
				return _comfortZoneComponent;
			}
			set
			{
				if (_comfortZoneComponent == value)
				{
					return;
				}
				_comfortZoneComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("isTargetingPlayer")] 
		public CBool IsTargetingPlayer
		{
			get
			{
				if (_isTargetingPlayer == null)
				{
					_isTargetingPlayer = (CBool) CR2WTypeManager.Create("Bool", "isTargetingPlayer", cr2w, this);
				}
				return _isTargetingPlayer;
			}
			set
			{
				if (_isTargetingPlayer == value)
				{
					return;
				}
				_isTargetingPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("playerStatsListener")] 
		public CHandle<gameScriptStatsListener> PlayerStatsListener
		{
			get
			{
				if (_playerStatsListener == null)
				{
					_playerStatsListener = (CHandle<gameScriptStatsListener>) CR2WTypeManager.Create("handle:gameScriptStatsListener", "playerStatsListener", cr2w, this);
				}
				return _playerStatsListener;
			}
			set
			{
				if (_playerStatsListener == value)
				{
					return;
				}
				_playerStatsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("upperBodyStateCallbackID")] 
		public CUInt32 UpperBodyStateCallbackID
		{
			get
			{
				if (_upperBodyStateCallbackID == null)
				{
					_upperBodyStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "upperBodyStateCallbackID", cr2w, this);
				}
				return _upperBodyStateCallbackID;
			}
			set
			{
				if (_upperBodyStateCallbackID == value)
				{
					return;
				}
				_upperBodyStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("leftCyberwareStateCallbackID")] 
		public CUInt32 LeftCyberwareStateCallbackID
		{
			get
			{
				if (_leftCyberwareStateCallbackID == null)
				{
					_leftCyberwareStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "leftCyberwareStateCallbackID", cr2w, this);
				}
				return _leftCyberwareStateCallbackID;
			}
			set
			{
				if (_leftCyberwareStateCallbackID == value)
				{
					return;
				}
				_leftCyberwareStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(135)] 
		[RED("meleeStateCallbackID")] 
		public CUInt32 MeleeStateCallbackID
		{
			get
			{
				if (_meleeStateCallbackID == null)
				{
					_meleeStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "meleeStateCallbackID", cr2w, this);
				}
				return _meleeStateCallbackID;
			}
			set
			{
				if (_meleeStateCallbackID == value)
				{
					return;
				}
				_meleeStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("combatGadgetStateCallbackID")] 
		public CUInt32 CombatGadgetStateCallbackID
		{
			get
			{
				if (_combatGadgetStateCallbackID == null)
				{
					_combatGadgetStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "combatGadgetStateCallbackID", cr2w, this);
				}
				return _combatGadgetStateCallbackID;
			}
			set
			{
				if (_combatGadgetStateCallbackID == value)
				{
					return;
				}
				_combatGadgetStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("wasAimedAtLast")] 
		public CBool WasAimedAtLast
		{
			get
			{
				if (_wasAimedAtLast == null)
				{
					_wasAimedAtLast = (CBool) CR2WTypeManager.Create("Bool", "wasAimedAtLast", cr2w, this);
				}
				return _wasAimedAtLast;
			}
			set
			{
				if (_wasAimedAtLast == value)
				{
					return;
				}
				_wasAimedAtLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(138)] 
		[RED("wasCWChargedAtLast")] 
		public CBool WasCWChargedAtLast
		{
			get
			{
				if (_wasCWChargedAtLast == null)
				{
					_wasCWChargedAtLast = (CBool) CR2WTypeManager.Create("Bool", "wasCWChargedAtLast", cr2w, this);
				}
				return _wasCWChargedAtLast;
			}
			set
			{
				if (_wasCWChargedAtLast == value)
				{
					return;
				}
				_wasCWChargedAtLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(139)] 
		[RED("wasMeleeChargedAtLast")] 
		public CBool WasMeleeChargedAtLast
		{
			get
			{
				if (_wasMeleeChargedAtLast == null)
				{
					_wasMeleeChargedAtLast = (CBool) CR2WTypeManager.Create("Bool", "wasMeleeChargedAtLast", cr2w, this);
				}
				return _wasMeleeChargedAtLast;
			}
			set
			{
				if (_wasMeleeChargedAtLast == value)
				{
					return;
				}
				_wasMeleeChargedAtLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(140)] 
		[RED("wasChargingGadgetAtLast")] 
		public CBool WasChargingGadgetAtLast
		{
			get
			{
				if (_wasChargingGadgetAtLast == null)
				{
					_wasChargingGadgetAtLast = (CBool) CR2WTypeManager.Create("Bool", "wasChargingGadgetAtLast", cr2w, this);
				}
				return _wasChargingGadgetAtLast;
			}
			set
			{
				if (_wasChargingGadgetAtLast == value)
				{
					return;
				}
				_wasChargingGadgetAtLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(141)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get
			{
				if (_isLookedAt == null)
				{
					_isLookedAt = (CBool) CR2WTypeManager.Create("Bool", "isLookedAt", cr2w, this);
				}
				return _isLookedAt;
			}
			set
			{
				if (_isLookedAt == value)
				{
					return;
				}
				_isLookedAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(142)] 
		[RED("cachedPlayerID")] 
		public entEntityID CachedPlayerID
		{
			get
			{
				if (_cachedPlayerID == null)
				{
					_cachedPlayerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "cachedPlayerID", cr2w, this);
				}
				return _cachedPlayerID;
			}
			set
			{
				if (_cachedPlayerID == value)
				{
					return;
				}
				_cachedPlayerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(143)] 
		[RED("canGoThroughDoors")] 
		public CBool CanGoThroughDoors
		{
			get
			{
				if (_canGoThroughDoors == null)
				{
					_canGoThroughDoors = (CBool) CR2WTypeManager.Create("Bool", "canGoThroughDoors", cr2w, this);
				}
				return _canGoThroughDoors;
			}
			set
			{
				if (_canGoThroughDoors == value)
				{
					return;
				}
				_canGoThroughDoors = value;
				PropertySet(this);
			}
		}

		[Ordinal(144)] 
		[RED("lastStatusEffectSignalSent")] 
		public wCHandle<gamedataStatusEffect_Record> LastStatusEffectSignalSent
		{
			get
			{
				if (_lastStatusEffectSignalSent == null)
				{
					_lastStatusEffectSignalSent = (wCHandle<gamedataStatusEffect_Record>) CR2WTypeManager.Create("whandle:gamedataStatusEffect_Record", "lastStatusEffectSignalSent", cr2w, this);
				}
				return _lastStatusEffectSignalSent;
			}
			set
			{
				if (_lastStatusEffectSignalSent == value)
				{
					return;
				}
				_lastStatusEffectSignalSent = value;
				PropertySet(this);
			}
		}

		[Ordinal(145)] 
		[RED("cachedStatusEffectAnim")] 
		public wCHandle<gamedataStatusEffect_Record> CachedStatusEffectAnim
		{
			get
			{
				if (_cachedStatusEffectAnim == null)
				{
					_cachedStatusEffectAnim = (wCHandle<gamedataStatusEffect_Record>) CR2WTypeManager.Create("whandle:gamedataStatusEffect_Record", "cachedStatusEffectAnim", cr2w, this);
				}
				return _cachedStatusEffectAnim;
			}
			set
			{
				if (_cachedStatusEffectAnim == value)
				{
					return;
				}
				_cachedStatusEffectAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(146)] 
		[RED("resendStatusEffectSignalDelayID")] 
		public gameDelayID ResendStatusEffectSignalDelayID
		{
			get
			{
				if (_resendStatusEffectSignalDelayID == null)
				{
					_resendStatusEffectSignalDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "resendStatusEffectSignalDelayID", cr2w, this);
				}
				return _resendStatusEffectSignalDelayID;
			}
			set
			{
				if (_resendStatusEffectSignalDelayID == value)
				{
					return;
				}
				_resendStatusEffectSignalDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(147)] 
		[RED("lastSEAppliedByPlayer")] 
		public CHandle<gameStatusEffect> LastSEAppliedByPlayer
		{
			get
			{
				if (_lastSEAppliedByPlayer == null)
				{
					_lastSEAppliedByPlayer = (CHandle<gameStatusEffect>) CR2WTypeManager.Create("handle:gameStatusEffect", "lastSEAppliedByPlayer", cr2w, this);
				}
				return _lastSEAppliedByPlayer;
			}
			set
			{
				if (_lastSEAppliedByPlayer == value)
				{
					return;
				}
				_lastSEAppliedByPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(148)] 
		[RED("pendingSEEvent")] 
		public CHandle<gameeventsApplyStatusEffectEvent> PendingSEEvent
		{
			get
			{
				if (_pendingSEEvent == null)
				{
					_pendingSEEvent = (CHandle<gameeventsApplyStatusEffectEvent>) CR2WTypeManager.Create("handle:gameeventsApplyStatusEffectEvent", "pendingSEEvent", cr2w, this);
				}
				return _pendingSEEvent;
			}
			set
			{
				if (_pendingSEEvent == value)
				{
					return;
				}
				_pendingSEEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(149)] 
		[RED("bounty")] 
		public Bounty Bounty
		{
			get
			{
				if (_bounty == null)
				{
					_bounty = (Bounty) CR2WTypeManager.Create("Bounty", "bounty", cr2w, this);
				}
				return _bounty;
			}
			set
			{
				if (_bounty == value)
				{
					return;
				}
				_bounty = value;
				PropertySet(this);
			}
		}

		[Ordinal(150)] 
		[RED("cachedVFXList")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedVFXList
		{
			get
			{
				if (_cachedVFXList == null)
				{
					_cachedVFXList = (CArray<wCHandle<gamedataStatusEffectFX_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatusEffectFX_Record", "cachedVFXList", cr2w, this);
				}
				return _cachedVFXList;
			}
			set
			{
				if (_cachedVFXList == value)
				{
					return;
				}
				_cachedVFXList = value;
				PropertySet(this);
			}
		}

		[Ordinal(151)] 
		[RED("cachedSFXList")] 
		public CArray<wCHandle<gamedataStatusEffectFX_Record>> CachedSFXList
		{
			get
			{
				if (_cachedSFXList == null)
				{
					_cachedSFXList = (CArray<wCHandle<gamedataStatusEffectFX_Record>>) CR2WTypeManager.Create("array:whandle:gamedataStatusEffectFX_Record", "cachedSFXList", cr2w, this);
				}
				return _cachedSFXList;
			}
			set
			{
				if (_cachedSFXList == value)
				{
					return;
				}
				_cachedSFXList = value;
				PropertySet(this);
			}
		}

		[Ordinal(152)] 
		[RED("isThrowingGrenadeToPlayer")] 
		public CBool IsThrowingGrenadeToPlayer
		{
			get
			{
				if (_isThrowingGrenadeToPlayer == null)
				{
					_isThrowingGrenadeToPlayer = (CBool) CR2WTypeManager.Create("Bool", "isThrowingGrenadeToPlayer", cr2w, this);
				}
				return _isThrowingGrenadeToPlayer;
			}
			set
			{
				if (_isThrowingGrenadeToPlayer == value)
				{
					return;
				}
				_isThrowingGrenadeToPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(153)] 
		[RED("throwingGrenadeDelayEventID")] 
		public gameDelayID ThrowingGrenadeDelayEventID
		{
			get
			{
				if (_throwingGrenadeDelayEventID == null)
				{
					_throwingGrenadeDelayEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "throwingGrenadeDelayEventID", cr2w, this);
				}
				return _throwingGrenadeDelayEventID;
			}
			set
			{
				if (_throwingGrenadeDelayEventID == value)
				{
					return;
				}
				_throwingGrenadeDelayEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(154)] 
		[RED("myKiller")] 
		public wCHandle<gameObject> MyKiller
		{
			get
			{
				if (_myKiller == null)
				{
					_myKiller = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "myKiller", cr2w, this);
				}
				return _myKiller;
			}
			set
			{
				if (_myKiller == value)
				{
					return;
				}
				_myKiller = value;
				PropertySet(this);
			}
		}

		[Ordinal(155)] 
		[RED("primaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> PrimaryThreatCalculationType
		{
			get
			{
				if (_primaryThreatCalculationType == null)
				{
					_primaryThreatCalculationType = (CEnum<EAIThreatCalculationType>) CR2WTypeManager.Create("EAIThreatCalculationType", "primaryThreatCalculationType", cr2w, this);
				}
				return _primaryThreatCalculationType;
			}
			set
			{
				if (_primaryThreatCalculationType == value)
				{
					return;
				}
				_primaryThreatCalculationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(156)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get
			{
				if (_temporaryThreatCalculationType == null)
				{
					_temporaryThreatCalculationType = (CEnum<EAIThreatCalculationType>) CR2WTypeManager.Create("EAIThreatCalculationType", "temporaryThreatCalculationType", cr2w, this);
				}
				return _temporaryThreatCalculationType;
			}
			set
			{
				if (_temporaryThreatCalculationType == value)
				{
					return;
				}
				_temporaryThreatCalculationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(157)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get
			{
				if (_isPlayerCompanionCached == null)
				{
					_isPlayerCompanionCached = (CBool) CR2WTypeManager.Create("Bool", "isPlayerCompanionCached", cr2w, this);
				}
				return _isPlayerCompanionCached;
			}
			set
			{
				if (_isPlayerCompanionCached == value)
				{
					return;
				}
				_isPlayerCompanionCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(158)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get
			{
				if (_isPlayerCompanionCachedTimeStamp == null)
				{
					_isPlayerCompanionCachedTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "isPlayerCompanionCachedTimeStamp", cr2w, this);
				}
				return _isPlayerCompanionCachedTimeStamp;
			}
			set
			{
				if (_isPlayerCompanionCachedTimeStamp == value)
				{
					return;
				}
				_isPlayerCompanionCachedTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(159)] 
		[RED("quickHackEffectsApplied")] 
		public CUInt32 QuickHackEffectsApplied
		{
			get
			{
				if (_quickHackEffectsApplied == null)
				{
					_quickHackEffectsApplied = (CUInt32) CR2WTypeManager.Create("Uint32", "quickHackEffectsApplied", cr2w, this);
				}
				return _quickHackEffectsApplied;
			}
			set
			{
				if (_quickHackEffectsApplied == value)
				{
					return;
				}
				_quickHackEffectsApplied = value;
				PropertySet(this);
			}
		}

		[Ordinal(160)] 
		[RED("hackingResistanceMod")] 
		public CHandle<gameConstantStatModifierData> HackingResistanceMod
		{
			get
			{
				if (_hackingResistanceMod == null)
				{
					_hackingResistanceMod = (CHandle<gameConstantStatModifierData>) CR2WTypeManager.Create("handle:gameConstantStatModifierData", "hackingResistanceMod", cr2w, this);
				}
				return _hackingResistanceMod;
			}
			set
			{
				if (_hackingResistanceMod == value)
				{
					return;
				}
				_hackingResistanceMod = value;
				PropertySet(this);
			}
		}

		[Ordinal(161)] 
		[RED("delayNonStealthQuickHackVictimEventID")] 
		public gameDelayID DelayNonStealthQuickHackVictimEventID
		{
			get
			{
				if (_delayNonStealthQuickHackVictimEventID == null)
				{
					_delayNonStealthQuickHackVictimEventID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayNonStealthQuickHackVictimEventID", cr2w, this);
				}
				return _delayNonStealthQuickHackVictimEventID;
			}
			set
			{
				if (_delayNonStealthQuickHackVictimEventID == value)
				{
					return;
				}
				_delayNonStealthQuickHackVictimEventID = value;
				PropertySet(this);
			}
		}

		[Ordinal(162)] 
		[RED("cachedIsPaperdoll")] 
		public CInt32 CachedIsPaperdoll
		{
			get
			{
				if (_cachedIsPaperdoll == null)
				{
					_cachedIsPaperdoll = (CInt32) CR2WTypeManager.Create("Int32", "cachedIsPaperdoll", cr2w, this);
				}
				return _cachedIsPaperdoll;
			}
			set
			{
				if (_cachedIsPaperdoll == value)
				{
					return;
				}
				_cachedIsPaperdoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(163)] 
		[RED("smartDespawnDelayID")] 
		public gameDelayID SmartDespawnDelayID
		{
			get
			{
				if (_smartDespawnDelayID == null)
				{
					_smartDespawnDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "smartDespawnDelayID", cr2w, this);
				}
				return _smartDespawnDelayID;
			}
			set
			{
				if (_smartDespawnDelayID == value)
				{
					return;
				}
				_smartDespawnDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(164)] 
		[RED("despawnTicks")] 
		public CUInt32 DespawnTicks
		{
			get
			{
				if (_despawnTicks == null)
				{
					_despawnTicks = (CUInt32) CR2WTypeManager.Create("Uint32", "despawnTicks", cr2w, this);
				}
				return _despawnTicks;
			}
			set
			{
				if (_despawnTicks == value)
				{
					return;
				}
				_despawnTicks = value;
				PropertySet(this);
			}
		}

		public NPCPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
