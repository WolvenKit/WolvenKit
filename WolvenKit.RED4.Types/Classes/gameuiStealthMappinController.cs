using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStealthMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("animImage")] 
		public inkImageWidgetReference AnimImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("eyeFillWhite")] 
		public inkWidgetReference EyeFillWhite
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("eyeFillBlack")] 
		public inkWidgetReference EyeFillBlack
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("markExclamation")] 
		public inkTextWidgetReference MarkExclamation
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("mainArt")] 
		public inkWidgetReference MainArt
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("eliteFrameName")] 
		public CName EliteFrameName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("eliteFrameSize")] 
		public Vector2 EliteFrameSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("objectMarker")] 
		public inkWidgetReference ObjectMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("levelIcon")] 
		public inkImageWidgetReference LevelIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("statusEffectHolder")] 
		public inkWidgetReference StatusEffectHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("statusEffectIcon")] 
		public inkImageWidgetReference StatusEffectIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("statusEffectTimer")] 
		public inkTextWidgetReference StatusEffectTimer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("taggedContainer")] 
		public inkWidgetReference TaggedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("ownerObject")] 
		public CWeakHandle<gameObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(29)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(30)] 
		[RED("ownerDevice")] 
		public CWeakHandle<Device> OwnerDevice
		{
			get => GetPropertyValue<CWeakHandle<Device>>();
			set => SetPropertyValue<CWeakHandle<Device>>(value);
		}

		[Ordinal(31)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsStealthMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsStealthMappin>>(value);
		}

		[Ordinal(32)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(33)] 
		[RED("canvas")] 
		public CWeakHandle<inkWidget> Canvas
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(34)] 
		[RED("nameplateController")] 
		public CWeakHandle<gameuiNpcNameplateGameController> NameplateController
		{
			get => GetPropertyValue<CWeakHandle<gameuiNpcNameplateGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiNpcNameplateGameController>>(value);
		}

		[Ordinal(35)] 
		[RED("isFriendly")] 
		public CBool IsFriendly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("isFriendlyFromHack")] 
		public CBool IsFriendlyFromHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("isDrone")] 
		public CBool IsDrone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("isMech")] 
		public CBool IsMech
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("isHiddenByQuest")] 
		public CBool IsHiddenByQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("NPCRarity")] 
		public CEnum<gamedataNPCRarity> NPCRarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}

		[Ordinal(46)] 
		[RED("puppetStateBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(47)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(48)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(49)] 
		[RED("waitingToExitCombat")] 
		public CBool WaitingToExitCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("reaction")] 
		public CEnum<gamedataOutput> Reaction
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(51)] 
		[RED("lastState")] 
		public CEnum<gamedataNPCHighLevelState> LastState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(52)] 
		[RED("lastReaction")] 
		public CEnum<gamedataOutput> LastReaction
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		[Ordinal(53)] 
		[RED("lastPercent")] 
		public CFloat LastPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("archetypeTextureName")] 
		public CName ArchetypeTextureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(57)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(58)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("canShowObjectMarker")] 
		public CBool CanShowObjectMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(60)] 
		[RED("objectMarkerVisible")] 
		public CBool ObjectMarkerVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("detectionVisible")] 
		public CBool DetectionVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("inNameplateMode")] 
		public CBool InNameplateMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("objectMarkerFirstShowing")] 
		public CBool ObjectMarkerFirstShowing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("statusEffectShowing")] 
		public CBool StatusEffectShowing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("statusEffectCurrentPriority")] 
		public CFloat StatusEffectCurrentPriority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("animationIsPlaying")] 
		public CBool AnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(69)] 
		[RED("nameplateAnimationProxy")] 
		public CHandle<inkanimProxy> NameplateAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(70)] 
		[RED("nameplateAnimationIsPlaying")] 
		public CBool NameplateAnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("reprimandAnimationProxy")] 
		public CHandle<inkanimProxy> ReprimandAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(72)] 
		[RED("reprimandAnimationIsPlaying")] 
		public CBool ReprimandAnimationIsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("reprimandAnimationState")] 
		public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState
		{
			get => GetPropertyValue<CEnum<gameReprimandMappinAnimationState>>();
			set => SetPropertyValue<CEnum<gameReprimandMappinAnimationState>>(value);
		}

		[Ordinal(74)] 
		[RED("currentAnimState")] 
		public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState
		{
			get => GetPropertyValue<CEnum<gameEnemyStealthAwarenessState>>();
			set => SetPropertyValue<CEnum<gameEnemyStealthAwarenessState>>(value);
		}

		[Ordinal(75)] 
		[RED("c_emptyThreshold")] 
		public CFloat C_emptyThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(76)] 
		[RED("c_awareToCombatThreshold")] 
		public CFloat C_awareToCombatThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("c_combatToAwareThreshold")] 
		public CFloat C_combatToAwareThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(78)] 
		[RED("c_deviceCombatToAwareThreshold")] 
		public CFloat C_deviceCombatToAwareThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(79)] 
		[RED("c_objectMarkerMaxDistance")] 
		public CFloat C_objectMarkerMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(80)] 
		[RED("c_objectMarkerMaxCameraDistance")] 
		public CFloat C_objectMarkerMaxCameraDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiStealthMappinController()
		{
			AnimImage = new();
			Arrow = new();
			Fill = new();
			EyeFillWhite = new();
			EyeFillBlack = new();
			MarkExclamation = new();
			Distance = new();
			MainArt = new();
			Frame = new();
			EliteFrameSize = new();
			ObjectMarker = new();
			LevelIcon = new();
			StatusEffectHolder = new();
			StatusEffectIcon = new();
			StatusEffectTimer = new();
			TaggedContainer = new();
			ObjectMarkerFirstShowing = true;
			C_awareToCombatThreshold = 1.000000F;
			C_combatToAwareThreshold = 99.900002F;
			C_deviceCombatToAwareThreshold = 35.000000F;
			C_objectMarkerMaxDistance = 50.000000F;
			C_objectMarkerMaxCameraDistance = 30.000000F;
		}
	}
}
