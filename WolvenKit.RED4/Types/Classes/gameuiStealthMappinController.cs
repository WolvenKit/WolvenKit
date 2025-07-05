using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiStealthMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("eyeFillWhite")] 
		public inkWidgetReference EyeFillWhite
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("eyeFillBlack")] 
		public inkWidgetReference EyeFillBlack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("markExclamation")] 
		public inkTextWidgetReference MarkExclamation
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("mainArt")] 
		public inkWidgetReference MainArt
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("eliteFrameName")] 
		public CName EliteFrameName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("eliteFrameSize")] 
		public Vector2 EliteFrameSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(21)] 
		[RED("objectMarker")] 
		public inkWidgetReference ObjectMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("levelIcon")] 
		public inkImageWidgetReference LevelIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("taggedContainer")] 
		public inkWidgetReference TaggedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("background")] 
		public inkCompoundWidgetReference Background
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("contagiousQuickhackArrows")] 
		public inkCompoundWidgetReference ContagiousQuickhackArrows
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("statusEffectMain")] 
		public inkWidgetReference StatusEffectMain
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("statusEffectIcon")] 
		public inkImageWidgetReference StatusEffectIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("statusEffectFill")] 
		public inkWidgetReference StatusEffectFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("statusEffectBackground")] 
		public inkWidgetReference StatusEffectBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(31)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(32)] 
		[RED("ownerDevice")] 
		public CWeakHandle<Device> OwnerDevice
		{
			get => GetPropertyValue<CWeakHandle<Device>>();
			set => SetPropertyValue<CWeakHandle<Device>>(value);
		}

		[Ordinal(33)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsStealthMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>(value);
		}

		[Ordinal(34)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(35)] 
		[RED("canvas")] 
		public CWeakHandle<inkWidget> Canvas
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(36)] 
		[RED("nameplateController")] 
		public CWeakHandle<gameuiNpcNameplateGameController> NameplateController
		{
			get => GetPropertyValue<CWeakHandle<gameuiNpcNameplateGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiNpcNameplateGameController>>(value);
		}

		[Ordinal(37)] 
		[RED("isFriendly")] 
		public CBool IsFriendly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isFriendlyFromHack")] 
		public CBool IsFriendlyFromHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("isNCPD")] 
		public CBool IsNCPD
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isDrone")] 
		public CBool IsDrone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("isMech")] 
		public CBool IsMech
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("isHiddenByQuest")] 
		public CBool IsHiddenByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("hideUIElements")] 
		public CBool HideUIElements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("puppetStateBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(50)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(51)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("waitingToExitCombat")] 
		public CBool WaitingToExitCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("reaction")] 
		public CEnum<gamedataOutput> Reaction
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(54)] 
		[RED("lastState")] 
		public CEnum<gamedataNPCHighLevelState> LastState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(55)] 
		[RED("lastReaction")] 
		public CEnum<gamedataOutput> LastReaction
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(56)] 
		[RED("lastPercent")] 
		public CFloat LastPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("archetypeTextureName")] 
		public CName ArchetypeTextureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(60)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("canShowObjectMarker")] 
		public CBool CanShowObjectMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("objectMarkerVisible")] 
		public CBool ObjectMarkerVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("detectionVisible")] 
		public CBool DetectionVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("inNameplateMode")] 
		public CBool InNameplateMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("objectMarkerFirstShowing")] 
		public CBool ObjectMarkerFirstShowing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("statusEffectShowing")] 
		public CBool StatusEffectShowing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("statusEffectCurrentPriority")] 
		public CFloat StatusEffectCurrentPriority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("isInCombatWithPlayer")] 
		public CBool IsInCombatWithPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("animationIsPlaying")] 
		public CBool AnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(73)] 
		[RED("nameplateAnimationProxy")] 
		public CHandle<inkanimProxy> NameplateAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(74)] 
		[RED("nameplateAnimationIsPlaying")] 
		public CBool NameplateAnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("reprimandAnimationProxy")] 
		public CHandle<inkanimProxy> ReprimandAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(76)] 
		[RED("reprimandAnimationIsPlaying")] 
		public CBool ReprimandAnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(77)] 
		[RED("reprimandAnimationState")] 
		public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState
		{
			get => GetPropertyValue<CEnum<gameReprimandMappinAnimationState>>();
			set => SetPropertyValue<CEnum<gameReprimandMappinAnimationState>>(value);
		}

		[Ordinal(78)] 
		[RED("monowireHackAnimationProxy")] 
		public CHandle<inkanimProxy> MonowireHackAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(79)] 
		[RED("currentAnimState")] 
		public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState
		{
			get => GetPropertyValue<CEnum<gameEnemyStealthAwarenessState>>();
			set => SetPropertyValue<CEnum<gameEnemyStealthAwarenessState>>(value);
		}

		[Ordinal(80)] 
		[RED("c_emptyThreshold")] 
		public CFloat C_emptyThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(81)] 
		[RED("c_awareToCombatThreshold")] 
		public CFloat C_awareToCombatThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(82)] 
		[RED("c_combatToAwareThreshold")] 
		public CFloat C_combatToAwareThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(83)] 
		[RED("c_deviceCombatToAwareThreshold")] 
		public CFloat C_deviceCombatToAwareThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(84)] 
		[RED("c_objectMarkerMaxDistance")] 
		public CFloat C_objectMarkerMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(85)] 
		[RED("c_objectMarkerMaxCameraDistance")] 
		public CFloat C_objectMarkerMaxCameraDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(86)] 
		[RED("statusEffectStartTime")] 
		public CFloat StatusEffectStartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(87)] 
		[RED("statusEffectTextureName")] 
		public CString StatusEffectTextureName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiStealthMappinController()
		{
			Arrow = new inkImageWidgetReference();
			Fill = new inkWidgetReference();
			EyeFillWhite = new inkWidgetReference();
			EyeFillBlack = new inkWidgetReference();
			MarkExclamation = new inkTextWidgetReference();
			Distance = new inkTextWidgetReference();
			MainArt = new inkWidgetReference();
			Frame = new inkImageWidgetReference();
			EliteFrameSize = new Vector2();
			ObjectMarker = new inkWidgetReference();
			LevelIcon = new inkImageWidgetReference();
			TaggedContainer = new inkWidgetReference();
			Background = new inkCompoundWidgetReference();
			ContagiousQuickhackArrows = new inkCompoundWidgetReference();
			StatusEffectMain = new inkWidgetReference();
			StatusEffectIcon = new inkImageWidgetReference();
			StatusEffectFill = new inkWidgetReference();
			StatusEffectBackground = new inkWidgetReference();
			ObjectMarkerFirstShowing = true;
			C_combatToAwareThreshold = 99.900002F;
			C_deviceCombatToAwareThreshold = 35.000000F;
			C_objectMarkerMaxDistance = 50.000000F;
			C_objectMarkerMaxCameraDistance = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
