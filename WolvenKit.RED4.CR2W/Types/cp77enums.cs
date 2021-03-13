using System;
using System.Collections.Generic;
using System.Text;
using WolvenKit.RED4.CR2W.Reflection;
// ReSharper disable InconsistentNaming

namespace WolvenKit.RED4.CR2W.Types
{
    public static partial class Enums
    {
        // flags

        public enum EInterPolationType
        {
            Constant,
            Linear,
            BezierQuadratic,
            BezierCubic,
            Hermite
        }

        public enum EChannelLinkType
        {
            Normal,
            Smooth,
            SmoothSymmertric
        }

        public enum EGameplayRole
        {
            [RED("")]
            UnAssigned = 0,
            None = 1,
            Alarm = 2,
            ControlNetwork = 3,
            ControlOtherDevice = 4,
            ControlSelf = 5,
            CutPower = 6,
            Distract = 7,
            DropPoint = 8,
            ExplodeLethal = 9,
            ExplodeNoneLethal = 10,
            Fall = 11,
            FastTravel = 12,
            GrantInformation = 13,
            HazardWarning = 14,
            HideBody = 15,
            Loot = 16,
            OpenPath = 17,
            ClearPath = 18,
            Push = 19,
            ServicePoint = 20,
            Shoot = 21,
            SpreadGas = 22,
            StoreItems = 23,
            GenericRole = 24,
            ClearPathAd = 25,
            DistractVendingMachine = 26,
            NPC = 27,
            Clue = 28
        }
		[Flags]
        public enum TriggerChannel
        {
            TC_Default,
            TC_Player,
            TC_Camera,
            TC_Human,
            TC_SoundReverbArea,
            TC_SoundAmbientArea,
            TC_Quest,
            TC_Projectiles,
            TC_Vehicle,
            TC_Environment,
            TC_WaterNullArea,
            TC_Custom0,
            TC_Custom1,
            TC_Custom2,
            TC_Custom3,
            TC_Custom4,
            TC_Custom5,
            TC_Custom6,
            TC_Custom7,
            TC_Custom8,
            TC_Custom9,
            TC_Custom10,
            TC_Custom11,
            TC_Custom12,
            TC_Custom13,
            TC_Custom14
        }
		[Flags]
        public enum RenderSceneLayerMask
        {
            Default,
            Cyberspace,
            WorldMap
        }
		[Flags]
		public enum rendLightChannel
        {
            LC_Channel1,
            LC_Channel2,
            LC_Channel3,
            LC_Channel4,
            LC_Channel5,
            LC_Channel6,
            LC_Channel7,
            LC_Channel8,
            LC_ChannelWorld,
            LC_Character,
            LC_Player,
            LC_Automated
        }
		[Flags]
		public enum workWorkspotItemPolicy
        {
            ItemPolicy_SpawnItemOnIdleChange,
            ItemPolicy_DespawnItemOnIdleChange,
            ItemPolicy_DespawnItemOnReaction
        }
		[Flags]
		public enum entdismembermentWoundTypeE
        {
            CLEAN,
            COARSE
        }
        [Flags]
        public enum entdismembermentResourceSetMask
        {
            fleshPartMask,
            FleshBodyMask,
            cyberPartMask,
            CyberBodyMask
        }
		[Flags]
		public enum entdismembermentPlacementE
        {
            MAIN_MESH,
            DISM_MESH,
            RAGDOLL_CONTACT,
            RAGDOLL_CONTACT_SLIDE,
            RAGDOLL_SLEEP
        }
        [Flags]
		public enum scnChoiceNodeNsChoiceNodeBitFlags
        {
            IsFocusClue,
            IsValidInteractionFailsafeDisabled
        }
		[Flags]
		public enum worlduiContextVisibility
        {
            SceneDefault,
            SceneTier1,
            SceneTier2,
            SceneTier3,
            SceneTier4,
            SceneTier5
        }
        [Flags]
        public enum animMuteAnimEvents
        {
            STANDARD,
            FACE_ANIMS
        }
		[Flags]
		public enum gameuiContext
        {
            Default = 0,
            QuickHack = 1,
            Scanning = 2,
            DeviceZoom = 3,
            BraindanceEditor = 4,
            BraindancePlayback = 5,
            VehicleMounted = 6,
            ModalPopup = 7,
            RadialWheel = 8,
            VehicleRace = 9,
        }
        [Flags]
		public enum gameEItemDynamicTags
        {
            Quest,
            UnequipBlocked
        }
		[Flags]
		public enum EMeshChunkFlags
		{
			MCF_RenderInScene,
			MCF_RenderInShadows,
			MCF_IsTwoSided,
			MCF_IsRayTracedEmissive,
			MCF_IsPrefabProxy
		}
		[Flags]
        public enum physicsEClothCollisionMaskEnum
        {
            CONVEX,
            TRIMESH
        }
		[Flags]
		public enum CensorshipFlags
		{
			Censor_Nudity,
			Censor_OverSexualised,
			Censor_Suggestive,
			Censor_Homosexuality,
			Censor_Gore,
			Censor_Drugs,
			Censor_Religion,
			Censor_Chinese

		}

		[Flags]
		public enum worldEDeniedAreaFlags
		{
			EDAF_Togglable
		}

        [Flags]
		public enum physicsRagdollBodyPartE
		{
			HEAD,
            LARM_UPPER,
            LARM_LOWER,
            LARM_PALM,
            RARM_UPPER,
            RARM_LOWER,
            RARM_PALM,
            LLEG_UPPER,
            LLEG_LOWER,
            LLEG_FOOT,
            RLEG_UPPER,
            RLEG_LOWER,
            RLEG_FOOT,
            BODY
		}



        public enum toolsSocketDirection
		{
            Output,
		}
        public enum toolsSocketPlacement
		{
		    Bottom,
		    Right,
		}
        public enum toolsAudioPlaybackDirectionSupport
        {
            Forward,
            Backward
        }
        public enum toolsAudioFastForwardSupport
        {
            MuteDuringFastForward,
            DontMuteDuringFastForward
        }
        public enum scnbPerformerAcquisitionPlanType
		{
		    Community,
            SpawnSet
		}

        public enum ETextureRawFormat
	    {
		    TRF_Invalid,
		    TRF_AlphaGrayscale,
		    TRF_TrueColor,
		    TRF_DeepColor,
		    TRF_Grayscale,
		    TRF_HDRFloat,
		    TRF_HDRHalf,
		    TRF_HDRFloatGrayscale,
		    TRF_Grayscale_Font,
		    TRF_R8G8,
		    TRF_R32UI
	    }
	    public enum ETextureCompression
	    {
		    TCM_None,
		    TCM_DXTNoAlpha,
		    TCM_DXTAlpha,
		    TCM_RGBE,
		    TCM_Normalmap,
		    TCM_Normals_DEPRECATED,
		    TCM_Normals,
		    TCM_NormalsHigh_DEPRECATED,
		    TCM_NormalsHigh,
		    TCM_NormalsGloss_DEPRECATED,
		    TCM_NormalsGloss,
		    TCM_TileMap,
		    TCM_DXTAlphaLinear,
		    TCM_QualityR,
		    TCM_QualityRG,
		    TCM_QualityColor,
		    TCM_HalfHDR_Unsigned,
		    TCM_HalfHDR,
		    TCM_HalfHDR_Signed,
		    TCM_Max,
	    }

        public enum Sample_Enum_As_Bitfield_2_9
        {
            Sample_Bitfield_Option_2_9_0
		}

        public enum Sample_Enum_As_Bitfield_2_2
        {
            Sample_Bitfield_Option_2_2_0
		}



        public enum gameLootSlotState
        {
            Looted,
            Unavailable
		}












	    public enum EMeshChunkRenderMask
	    {
		    MCR_Scene,
		    MCR_Cascade1,
		    MCR_Cascade2,
		    MCR_Cascade3,
		    MCR_Cascade4,
		    MCR_DistantShadows,
		    MCR_LocalShadows,
		    MCR_IsTwoSided,
		    MCR_IsRayTracedEmissive,
		    MCR_PrefabProxy,
		    MCR_Cascades
	    }











	    public enum ActiveMode
		{
			UNINITIALIZED = 0,
			CLEAR = 1,
			SEMI = 2,
			COMBAT = 3,
			FOCUS = 4
		}
		public enum ActorVisibilityStatus
		{
			OUTSIDE_CAMERA = 0,
			IN_CAMERA = 1,
			VISIBLE = 2,
			LOOKEDAT = 3
		}
		public enum AdvertisementFormat
		{
			Format_0_7x1 = 0,
			Format_1x1 = 1,
			Format_1x0_7 = 2,
			Format_1x1_5 = 3,
			Format_1x2 = 4,
			Format_1x3_3 = 5,
			Format_1_5x1 = 6,
			Format_2x1 = 7,
			Format_3_3x1 = 8,
			Format_3x4 = 9,
			Format_4x3 = 10,
			Format_9x16 = 11,
			Format_9x21 = 12,
			Format_16x9 = 13,
			Format_21x9 = 14,
			Format_a = 15,
			Format_b = 16,
			Format_c = 17,
			Format_d = 18,
			Format_e = 19,
			Format_f = 20,
			Format_i = 21,
			Format_o = 22,
			Format_k = 23
		}
		public enum AdvertisementLoadMode
		{
			TweakDB = 0,
			Override = 1
		}
		public enum AIactionParamsPackageTypes
		{
			Default = 0,
			Reaction = 1,
			StatusEffect = 2,
			Undefined = 3
		}
		public enum AIArgumentType
		{
			Bool = 0,
			Int = 1,
			Uint64 = 2,
			Enum = 3,
			Float = 4,
			CName = 5,
			Vector = 6,
			Object = 7,
			TreeRef = 8,
			NodeRef = 9,
			GlobalNodeId = 10,
			PuppetRef = 11,
			Serializable = 12,
			TweakDBID = 13
		}
		public enum AIbehaviorActivationStatus
		{
			NOT_ACTIVATED = 0,
			ACTIVATING = 1,
			ACTIVATED = 2,
			DEACTIVATING = 3
		}
		public enum AIbehaviorCombatModes
		{
			Default = 0,
			LowFPS = 1,
			Background = 2
		}
		public enum AIbehaviorCompletionStatus
		{
			FAILURE = 0,
			SUCCESS = 1
		}
		public enum AIbehaviorConditionOutcomes
		{
			True = 0,
			False = 1,
			Failure = 2
		}
		public enum AIbehaviorDebugNodeStatus
		{
			Undefined = 0,
			NotRunning = 1,
			ForceStopped = 2,
			Running = 3,
			Success = 4,
			Failure = 5
		}
		public enum AIbehaviorEdgeConditionAction
		{
			None = 0,
			Toggle = 1,
			TurnOn = 2,
			TurnOff = 3
		}
		public enum AIbehaviorEntityLODConditions
		{
			Crowd = 0,
			Cinematic = 1,
			WorkspotStatic = 2
		}
		public enum AIbehaviorMaybeNodeAction
		{
			Succeed = 0,
			Fail = 1,
			RepeatChild = 2
		}
		public enum AIbehaviorMovementPolicyTaskFunctions
		{
			SetMovementType = 0,
			SetTargetObject = 1,
			UseFollowSlots = 2,
			SetLocalTargetOffset = 3,
			SetIgnoreNavigation = 4,
			SetStrafingTarget = 5
		}
		public enum AIbehaviorNaryExpressionOperators
		{
			LogicalAnd = 0,
			LogicalOr = 1
		}
		public enum AIbehaviorParallelNodeChildState
		{
			Inactive = 0,
			Active = 1,
			Completed = 2
		}
		public enum AIbehaviorParallelNodeWaitFor
		{
			LeftChild = 0,
			RightChild = 1,
			AllChildren = 2,
			BothChildren = 2,
			AnyChild = 3
		}
		public enum AIbehaviorSignalConditionModes
		{
			CurrentValue = 0,
			StartOfFrameValue = 1,
			RisingEdge = 2,
			FallingEdge = 3,
			AnyEdge = 4
		}
		public enum AIbehaviorStateCompletionStatus
		{
			ForwardBehaviorStatus = 0,
			Failure = 1,
			Success = 2
		}
		public enum AIbehaviorStoryActionType
		{
			Setup = 0,
			Stop = 1
		}
		public enum AIbehaviorSystemVariableExpressionTypes
		{
			IsFPSLow = 0
		}
		public enum AIbehaviorUpdateOutcome
		{
			IN_PROGRESS = 0,
			SUCCESS = 1,
			FAILURE = 2
		}
		public enum AICombatSectorType
		{
			ToBackLeft = 0,
			ToBackMid = 1,
			ToBackRight = 2,
			ToLeft = 3,
			ToMid = 4,
			ToRight = 5,
			FromLeft = 6,
			FromMid = 7,
			FromRight = 8,
			FromBackLeft = 9,
			FromBackMid = 10,
			FromBackRight = 11,
			BeyondToLeft = 12,
			BeyondToRight = 13,
			BeyondFromLeft = 14,
			BeyondFromRight = 15,
			Unknown = 16
		}
		public enum AICombatSpaceSize
		{
			Undefined = 0,
			Narrow = 1,
			Medium = 2,
			Huge = 3
		}
		public enum AICommandContextsType
		{
			Default = 0,
			Immediate = 1,
			Movement = 2,
			Workspot = 3,
			Aiming = 4
		}
		public enum AICommandState
		{
			NotExecuting = 0,
			Enqueued = 1,
			Executing = 2,
			Cancelled = 3,
			Interrupted = 4,
			Success = 5,
			Failure = 6
		}
		public enum AICoverExposureMethod
		{
			Standing_Step_Left = 0,
			Standing_Step_Right = 1,
			Standing_Lean_Left = 2,
			Standing_Lean_Right = 3,
			Crouching_Step_Left = 4,
			Crouching_Step_Right = 5,
			Crouching_Lean_Left = 6,
			Crouching_Lean_Right = 7,
			Lean_Over = 8,
			Stand_Up = 9,
			Standing_Blind_Left = 10,
			Standing_Blind_Right = 11,
			Crouching_Blind_Left = 12,
			Crouching_Blind_Right = 13,
			Crouching_Blind_Top = 14,
			Count = 15
		}
		public enum AIEExecutionOutcome
		{
			OUTCOME_FAILURE = 0,
			OUTCOME_SUCCESS = 1,
			OUTCOME_IN_PROGRESS = 2
		}
		public enum AIEExecutionStatus
		{
			STATUS_INVALID = 0,
			STATUS_SUCCESS = 1,
			STATUS_FAILURE = 2,
			STATUS_RUNNING = 3,
			STATUS_ABORTED = 4
		}
		public enum AIEInterruptionImportance
		{
			Undefined = 0,
			Casual = 1,
			Rush = 2,
			Immediate = 3,
			ForcedImmediate = 4
		}
		public enum AIEInterruptionOutcome
		{
			INTERRUPTION_SUCCESS = 0,
			INTERRUPTION_DELAYED = 1,
			INTERRUPTION_FAILED = 2
		}
		public enum AIESharedVarDefinitionType
		{
			SVInt = 0,
			SVFloat = 1,
			SVBool = 2,
			SVName = 3,
			SVTarget = 4,
			SVPosition = 5,
			SVNodeInstance = 6,
			SVGlobalNodeRef = 7
		}
		public enum AIForcedBehaviourPriority
		{
			AboveIdle = 0,
			AboveCombat = 1,
			AboveCriticalState = 2,
			AboveDeath = 3
		}
		public enum AIinfluenceEBumpPolicy
		{
			Static = 0,
			Lean = 1,
			Move = 2
		}
		public enum AIIWorkspotManagerSpotUsageState
		{
			Reserved = 0,
			Occupied = 1,
			None = 2
		}
		public enum aimTypeEnum
		{
			AimIn = 0,
			AimOut = 1,
			Invalid = 2
		}
		public enum AIParameterizationType
		{
			BehaviorArgument = 0,
			CustomValue = 1,
			CharacterRecord = 2,
			TweakDB = 3,
			ActionRecord = 4,
			Blackboard = 5,
			Delegate = 6
		}
		public enum AIReactionCountOutcome
		{
			Failed = 0,
			Succeded = 1,
			NotFound = 2
		}
		public enum AISignalFlags
		{
			Undefined = 0,
			OverridesSelf = 1,
			InterruptsSamePriorityTask = 2,
			InterruptsForcedBehavior = 4,
			AcceptsAdditives = 8
		}
		public enum AISocketsForRig
		{
			Undefined = 0,
			ManAverage = 1,
			ManBig = 2,
			ManFat = 3,
			WomanAverage = 4,
			WomanBig = 5,
			ChildMale = 6
		}
		public enum AISquadType
		{
			Community = 0,
			Global = 1,
			Security = 2,
			Attitude = 3,
			Combat = 4,
			Follower = 6,
			Unknown = 7
		}
		public enum AIThreatPersistenceStatus
		{
			ThreatNotFound = 0,
			Persistent = 1,
			NotPersistent = 2
		}
		public enum AITrackedStatusType
		{
			Unknown = 0,
			Friendly = 1,
			Neutral = 2,
			Hostile = 3
		}
		public enum AIUninterruptibleActionType
		{
			None = 0,
			Default = 1,
			EnteringCover = 2,
			LeavingCover = 3,
			Count = 4
		}
		public enum animAimState
		{
			Unaimed = 0,
			Aimed = 1
		}
		public enum animAnimationType
		{
			Normal = 0,
			AdditiveFromRefPose = 1,
			AdditiveFromFirstFrame = 2,
			Additive = 3,
			AdditiveWithoutFirstFrame = 4
		}
		public enum animAnimEventGenderAlt
		{
			None = 0,
			Female = 1,
			Male = 2
		}
		public enum animAnimNode_SetDrivenKey_InternalsEChannelType
		{
			FloatTrack = 0,
			TransX = 1,
			TransY = 2,
			TransZ = 3,
			RotEulZ_Pitch = 4,
			RotEulX_Roll = 5,
			RotEulY_Yaw = 6,
			ScaleX = 7,
			ScaleY = 8,
			ScaleZ = 9,
			RotQuatX = 10,
			RotQuatY = 11,
			RotQuatZ = 12,
			RotQuatW = 13
		}
		public enum animAnimStateInterpolationType
		{
			Linear = 0,
			EaseIn = 1,
			EaseOut = 2,
			EaseInOut = 3
		}
		public enum animAxis
		{
			X = 0,
			Y = 1,
			Z = 2,
			NegativeX = 3,
			NegativeY = 4,
			NegativeZ = 5
		}
		public enum animClampType
		{
			None = 0,
			Clamp = 1,
			WrappedClamp = 2
		}
		public enum animCompareFunc
		{
			Equal = 0,
			NotEqual = 1,
			Less = 2,
			LessEqual = 3,
			Greater = 4,
			GreaterEqual = 5
		}
		public enum animcompressionBufferTypePreset
		{
			Spline = 0,
			SIMD = 1,
			TestRaw = 2
		}
		public enum animcompressionFrameratePreset
		{
			USE_30_HZ = 0,
			USE_15_HZ = 1,
			USE_10_HZ = 2
		}
		public enum animcompressionQualityPreset
		{
			HIGH = 0,
			MID = 1,
			LOW = 2,
			CINEMATIC_HIGH = 3
		}
		public enum animConstraintWeightMode
		{
			Static = 0,
			FloatTrack = 1
		}
		public enum animCoverAction
		{
			NoAction = 0,
			LeanLeft = 1,
			LeanRight = 2,
			StepOutLeft = 3,
			StepOutRight = 4,
			LeanOver = 5,
			StepUp = 6,
			EnterCover = 7,
			SlideTo = 8,
			Vault = 9,
			LeaveCover = 10,
			BlindfireLeft = 11,
			BlindfireRight = 12,
			BlindfireOver = 13,
			OverheadStepOutLeft = 14,
			OverheadStepOutRight = 15,
			OverheadStepUp = 16
		}
		public enum animCoverBehavior
		{
			Idle = 0,
			PreAction = 1,
			DoAction = 2,
			PostAction = 3
		}
		public enum animCoverStance
		{
			None = 0,
			LowLeft = 1,
			HighLeft = 2,
			LowRight = 3,
			HighRight = 4
		}
		public enum animCoverState
		{
			LowCover = 1,
			HighCover = 2
		}
		public enum animDyngConstraintLinkType
		{
			KeepFixedDistance = 0,
			KeepVariableDistance = 1,
			Greater = 2,
			Closer = 3
		}
		public enum animDyngParticleProjectionType
		{
			Disabled = 0,
			ShortestPath = 1,
			Directed = 2
		}
		public enum animEAnimGraphAdditiveType
		{
			AGAT_Local = 0,
			AGAT_Ref = 1
		}
		public enum animEAnimGraphCompareFunc
		{
			AGCF_Equal = 0,
			AGCF_NotEqual = 1,
			AGCF_Less = 2,
			AGCF_LessEqual = 3,
			AGCF_Greater = 4,
			AGCF_GreaterEqual = 5
		}
		public enum animEAnimGraphLogicOp
		{
			AGLO_Or = 0,
			AGLO_And = 1
		}
		public enum animEAnimGraphMathInterpolation
		{
			AGMI_LINEAR = 0,
			AGMI_SIN = 1,
			AGMI_BEZIER = 2
		}
		public enum animEAnimGraphMathOp
		{
			AGMO_Add = 0,
			AGMO_Subtract = 1,
			AGMO_Multiply = 2,
			AGMO_Divide = 3,
			AGMO_SafeDivide = 4,
			AGMO_ATan = 5,
			AGMO_AngleDiff = 6,
			AGMO_Length = 7,
			AGMO_Abs = 8
		}
		public enum animEBlendFromPoseMode
		{
			BFPM_AlwaysOnActivation = 0,
			BFPM_RequestedByTag = 1
		}
		public enum animEBlendTracksMode
		{
			AGBT_BasePose = 0,
			AGBT_Interpolate = 1,
			AGBT_Add = 2
		}
		public enum animEBlendTypeLBC
		{
			Linear = 0,
			Smoothstep = 1,
			CustomCurve = 2
		}
		public enum animEDirectionToEuler
		{
			Pitch = 0,
			Yaw = 1,
			Roll = 2
		}
		public enum animEFootPhase
		{
			RightUp = 0,
			RightForward = 1,
			LeftUp = 2,
			LeftForward = 3,
			NotConsidered = 4
		}
		public enum animEInterpolationType
		{
			Lerp = 0,
			Slerp = 1
		}
		public enum animEMotionExtractionCompressionType
		{
			EMECT_UNCOMPRESSED = 0,
			EMECT_SPLINE_MID = 2,
			EMECT_UNCOMPRESSED_ALL_ANGLES = 3,
			EMECT_SPLINE_LOW = 4,
			EMECT_SPLINE_HIGH = 5,
			EMECT_LINEAR = 6,
			EMECT_UNCOMPRESSED_2D = 7,
			EMECT_UNCOMPRESSED_3D_FALLBACKING = 8,
			EMECT_UNCOMPRESSED_ALL_ANGLES_FALLBACKING = 9
		}
		public enum animEResetTypeNode
		{
			RT_Reference = 0,
			RT_Indentity = 1
		}
		public enum animESpace
		{
			Local = 0,
			Model = 1,
			World = 2
		}
		public enum animESpaceMW
		{
			Model = 0,
			World = 1
		}
		public enum animETransformAxis
		{
			X_Axis = 1,
			Y_Axis = 2,
			Z_Axis = 4
		}
		public enum animEVectorWsToMsType
		{
			Position = 0,
			Direction = 1
		}
		public enum animEventFilterType
		{
			Default = 0,
			AlwaysCollect = 1,
			Solo = 2,
			Mute = 3
		}
		public enum animEventSide
		{
			Left = 0,
			Right = 1
		}
		public enum animFacialEmotionTransitionType
		{
			Natural = 0,
			Fast = 1,
			Blend = 2,
			Instant = 3,
			Custom = 4
		}
		public enum animFloatTrackOperationType
		{
			Override = 0,
			Multiply = 1,
			Add = 2,
			Subtract = 3,
			SubtractSwapped = 4,
			WeightComplement = 5
		}
		public enum animHitReactionType
		{
			None = 0,
			Twitch = 1,
			Impact = 2,
			Stagger = 3,
			Pain = 4,
			Knockdown = 5,
			Ragdoll = 6,
			Death = 7,
			Block = 8,
			GuardBreak = 9,
			Parry = 10,
			Bump = 11
		}
		public enum animLeg
		{
			Left = 0,
			Right = 1
		}
		public enum animLocomotion_AnimType
		{
			None = 0,
			idle_stand = 1,
			idle_to_idle_0 = 2,
			idle_to_idle_090 = 3,
			idle_to_idle_270 = 4,
			idle_to_idle_180_l = 5,
			idle_to_idle_180_r = 6,
			walk_0 = 7,
			walk_left = 8,
			walk_right = 9,
			jog_0 = 10,
			jog_left = 11,
			jog_right = 12,
			sprint_0 = 13,
			sprint_left = 14,
			sprint_right = 15,
			idle_to_walk_0 = 16,
			idle_to_jog_0 = 17,
			idle_to_sprint_0 = 18,
			walk_to_idle_0 = 19,
			jog_to_idle_0 = 20,
			sprint_to_idle_0 = 21,
			walk_to_idle_0_l_hard = 22,
			walk_to_idle_0_r_hard = 23,
			jog_to_idle_0_l_hard = 24,
			jog_to_idle_0_r_hard = 25,
			sprint_to_idle_0_l_hard = 26,
			sprint_to_idle_0_r_hard = 27,
			walk_to_jog_0 = 28,
			walk_to_sprint_0 = 29,
			jog_to_walk_0 = 30,
			jog_to_sprint_0 = 31,
			sprint_to_walk_0 = 32,
			sprint_to_jog_0 = 33,
			idle_turn_to_walk_090 = 34,
			idle_turn_to_walk_180_l = 35,
			idle_turn_to_walk_180_r = 36,
			idle_turn_to_walk_270 = 37,
			idle_turn_to_jog_090 = 38,
			idle_turn_to_jog_180_l = 39,
			idle_turn_to_jog_180_r = 40,
			idle_turn_to_jog_270 = 41,
			idle_turn_to_sprint_090 = 42,
			idle_turn_to_sprint_180_l = 43,
			idle_turn_to_sprint_180_r = 44,
			idle_turn_to_sprint_270 = 45,
			walk_180 = 46,
			jog_180 = 47,
			walk_0_to_walk_180_l = 48,
			walk_0_to_walk_180_r = 49,
			walk_180_to_walk_0_l = 50,
			walk_180_to_walk_0_r = 51,
			idle_to_walk_180 = 52,
			idle_to_jog_180 = 53,
			walk_to_idle_180 = 54,
			jog_to_idle_180 = 55,
			jog_0_to_jog_180_l = 56,
			jog_0_to_jog_180_r = 57,
			jog_180_to_jog_0_l = 58,
			jog_180_to_jog_0_r = 59,
			jog_to_sprint_180 = 60,
			walk_to_jog_180 = 61,
			jog_to_walk_180 = 62,
			idle_to_walk_090 = 63,
			idle_to_walk_270 = 64,
			walk_090 = 65,
			walk_270 = 66,
			walk_to_idle_090 = 67,
			walk_to_idle_270 = 68,
			walk_0_to_walk_090 = 69,
			walk_0_to_walk_270 = 70,
			walk_180_to_walk_090 = 71,
			walk_180_to_walk_270 = 72,
			walk_090_to_walk_0 = 73,
			walk_270_to_walk_0 = 74,
			walk_090_to_walk_180 = 75,
			walk_270_to_walk_180 = 76,
			walk_090_to_walk_270_l = 77,
			walk_090_to_walk_270_r = 78,
			walk_270_to_walk_090_l = 79,
			walk_270_to_walk_090_r = 80,
			walk_0_down_stairs = 81,
			walk_0_up_stairs = 82,
			walk_0_down_slope = 83,
			walk_0_up_slope = 84,
			jog_0_down_stairs = 85,
			jog_0_up_stairs = 86,
			jog_0_down_slope = 87,
			jog_0_up_slope = 88,
			sprint_0_down_stairs = 89,
			sprint_0_up_stairs = 90,
			sprint_0_down_slope = 91,
			sprint_0_up_slope = 92,
			walk_090_up_stairs = 93,
			walk_090_down_stairs = 94,
			walk_270_up_stairs = 95,
			walk_270_down_stairs = 96,
			walk_180_up_stairs = 97,
			walk_180_down_stairs = 98,
			idle_step_single_0 = 99,
			idle_step_single_090 = 100,
			idle_step_single_180 = 101,
			idle_step_single_270 = 102
		}
		public enum animLocomotion_Style
		{
			LS_Idle = 0,
			LS_Rotation = 1,
			LS_Walk = 2,
			LS_Jog = 3,
			LS_Sprint = 4,
			LS_Any = 5
		}
		public enum animLocomotionDecision
		{
			LD_None = 0,
			LD_Stop = 1,
			LD_MoveTo = 2,
			LD_Move = 3
		}
		public enum animLocoStateType
		{
			LS_Pre = 0,
			LS_Loop = 1
		}
		public enum animLookAtChestMode
		{
			Default = 0,
			NoHips = 1,
			Horizontal = 2,
			HorizontalNoHips = 3,
			ENUM_SIZE = 4
		}
		public enum animLookAtEyesMode
		{
			Default = 0,
			Horizontal = 1,
			ENUM_SIZE = 2
		}
		public enum animLookAtHeadMode
		{
			Default = 0,
			Horizontal = 1,
			ENUM_SIZE = 2
		}
		public enum animLookAtLeftHandedMode
		{
			Default = 0,
			Horizontal = 1,
			ENUM_SIZE = 2
		}
		public enum animLookAtLimitDegreesType
		{
			Narrow = 0,
			Normal = 1,
			Wide = 2,
			None = 3
		}
		public enum animLookAtLimitDistanceType
		{
			Short = 0,
			Normal = 1,
			Long = 2,
			None = 3
		}
		public enum animLookAtRightHandedMode
		{
			Default = 0,
			Horizontal = 1,
			ENUM_SIZE = 2
		}
		public enum animLookAtStatus
		{
			Active = 2,
			LimitReached = 4,
			TransitionInProgress = 8
		}
		public enum animLookAtStyle
		{
			VerySlow = 0,
			Slow = 1,
			Normal = 2,
			Fast = 3,
			VeryFast = 4
		}
		public enum animLookAtTwoHandedMode
		{
			Default = 0,
			Horizontal = 1,
			ENUM_SIZE = 2
		}
		public enum animMotionTableAction
		{
			MTA_None = 0,
			MTA_Start = 1,
			MTA_Stop = 2,
			MTA_Move = 3,
			MTA_TurnInPlace = 4,
			MTA_TransitionToBackward = 5,
			MTA_BackwardMove = 6,
			MTA_TransitionFromBackward = 7,
			MTA_StrafeLeft = 8,
			MTA_StrafeRight = 9,
			MTA_ForwardToStrafeLeft = 10,
			MTA_ForwardToStrafeRight = 11,
			MTA_StrafeLeftToForward = 12,
			MTA_StrafeRightToForward = 13,
			MTA_BackwardToStrafeLeft = 14,
			MTA_BackwardToStrafeRight = 15,
			MTA_StrafeLeftToBackward = 16,
			MTA_StrafeRightToBackward = 17,
			MTA_BackwardStart = 18,
			MTA_BackwardStop = 19,
			MTA_StrafeLeftStart = 20,
			MTA_StrafeLeftStop = 21,
			MTA_StrafeRightStart = 22,
			MTA_StrafeRightStop = 23,
			MTA_ForwardToWalk = 24,
			MTA_ForwardToJog = 25,
			MTA_ForwardToSprint = 26,
			MTA_HardStopLeftLeg = 27,
			MTA_HardStopRightLeg = 28,
			MTA_RepositionForward = 29,
			MTA_RepositionLeft = 30,
			MTA_RepositionRight = 31,
			MTA_RepositionBackward = 32,
			MTA_Custom = 33,
			MTA_CrowdMove = 34,
			MTA_CrowdMoveSlopes = 35,
			MTA_CrowdMoveStairs = 36,
			MTA_StrafeLeftToStrafeRight = 37,
			MTA_StrafeRightToStrafeLeft = 38,
			MTA_CrowdRelaxedStop = 39,
			MTA_CrowdHardStop = 40,
			MTA_CrowdSprintStop = 41,
			MTA_CrowdFleeStopFront = 42,
			MTA_CrowdFleeStopBack = 43,
			MTA_CrowdRelaxedStart = 44,
			MTA_CrowdFleeStartIdle = 45,
			MTA_CrowdFleeStartMotion = 46,
			MTA_CrowdDirectionalStartFast = 47
		}
		public enum animMotionTableType
		{
			MTT_None = 0,
			MTT_Walk = 1,
			MTT_Jog = 2,
			MTT_Sprint = 3,
			MTT_Custom = 4
		}
		public enum animMotionTag
		{
			MT_Invalid = 0,
			Walk = 1,
			Jog = 2,
			Sprint = 3
		}
		public enum animNodeProfileTimerMode
		{
			Begin = 0,
			End = 1
		}
		public enum animNPCVehicleDeathType
		{
			Default = 0,
			Relaxed = 1,
			Combat = 2,
			Ragdoll = 3
		}
		public enum animParentStaticSwitchBranch
		{
			None = 0,
			TrueBranch = 1,
			FalseBranch = 2
		}
		public enum animPendulumConstraintType
		{
			Cone = 0,
			HingePlane = 1,
			HalfCone = 2
		}
		public enum animPendulumProjectionType
		{
			Disabled = 0,
			ShortestPathRotational = 1,
			DirectedRotational = 2
		}
		public enum animPositionProjectionType
		{
			Disabled = 0,
			ShortestPath = 1,
			Directional = 2
		}
		public enum animQuaternionInterpolationType
		{
			Linear = 0,
			Spherical = 1
		}
		public enum animSetBoneTransformEntry_SetMethod
		{
			NoSnapping = 0,
			WholeTransform = 1,
			TranslationOnly = 2,
			RotationOnly = 3
		}
		public enum animSpringProjectionType
		{
			Disabled = 0,
			ShortestPath = 1
		}
		public enum animStackTransformsExtender_SnapToBoneMethod
		{
			NoSnapping = 0,
			WholeTransform = 1,
			TranslationOnly = 2,
			RotationOnly = 3
		}
		public enum animStanceState
		{
			Stand = 0,
			Crouch = 1,
			Kneel = 2,
			Cover = 3,
			Swim = 4,
			Crawl = 5
		}
		public enum animStateTag
		{
			ST_Invalid = 0,
			Idle = 1,
			Cover = 2
		}
		public enum animTransformChannel
		{
			PosX = 0,
			PosY = 1,
			PosZ = 2,
			RotX = 3,
			RotY = 4,
			RotZ = 5,
			ScaleX = 6,
			ScaleY = 7,
			ScaleZ = 8
		}
		public enum animVectorCoordinateType
		{
			X = 0,
			Y = 1,
			Z = 2,
			W = 3
		}
		public enum animWeaponOwnerType
		{
			Player = 0,
			NPC = 1,
			None = 2
		}
		public enum AttitudeChange
		{
			DONT_CHANGE = 0,
			FRIENDLY = 1,
			NEUTRAL = 2,
			HOSTILE = 3
		}
		public enum AttributeButtonState
		{
			Default = 0,
			Hover = 1
		}
		public enum audioAdvertIndoorFilter
		{
			Always = 0,
			OnlyIndoor = 1,
			OnlyOutdoor = 2
		}
		public enum audioAmbientGroupingVariant
		{
			AllEntities = 0,
			IndoorEntities = 1,
			OutdoorEntities = 2,
			AllEntitiesAllDirections = 3,
			IndoorAllDirections = 4,
			OutdoorAllDirections = 5
		}
		public enum audioAudioEventFlags
		{
			NoEventFlags = 0,
			SloMoOnly = 1,
			Music = 2,
			Unique = 4,
			Metadata = 8
		}
		public enum audioAudioVehicleCurve
		{
			ThrottleInput = 0,
			RPM = 1,
			Gear = 2
		}
		public enum audiobreathingEventTag
		{
			Walk = 0,
			Jog = 1,
			Run = 2,
			Sneak = 3,
			Cloth = 4,
			FootStepRegular = 5,
			FootStepSprint = 6,
			LandingRegular = 7,
			LandingHard = 8,
			LandingVeryHard = 9,
			Climb = 10,
			Jump = 11,
			Player = 12,
			Stop = 13,
			Drop_Body = 14,
			Pick_Up_Body = 15,
			Standing_Event = 16
		}
		public enum audiobreathingLoopBehavior
		{
			TimedBreathing = 0,
			BreathEvery2ndStep = 1,
			BreathEveryStep = 2,
			HoldingBreath = 3
		}
		public enum audioBreathingTransitionComparator
		{
			Less = 0,
			Equal = 1,
			Greater = 2
		}
		public enum audioBreathingTransitionType
		{
			PlayerSpeed = 0,
			Event = 1,
			AllEventTags = 2,
			AnyEventTag = 3
		}
		public enum audioClassificationMethod
		{
			HasAnyTag = 0,
			HasAllTags = 1,
			NameEquals = 2,
			EventNameEquals = 3,
			HasAllEventTags = 4
		}
		public enum audioConversationSavingStrategy
		{
			Default = 0,
			Save = 1,
			DontSave = 2
		}
		public enum audioDynamicReverbType
		{
			Dynamic = 0,
			StaticSmall = 1,
			EnvironmentSmallStaticMedium = 2,
			DynamicSource = 3
		}
		public enum audioEchoPositionType
		{
			DynamicEnvironment = 0,
			Simple = 1
		}
		public enum audioEnemyState
		{
			InCombat = 0,
			Alerted = 1,
			Afraid = 2,
			Alive = 3,
			Dead = 4
		}
		public enum audioEntityEmitterContextType
		{
			[RED("Entity Emitter")] Entity_Emitter = 0,
			[RED("Radio Emitter")] Radio_Emitter = 2
		}
		public enum audioESoundCurveType
		{
			Log3 = 0,
			Sine = 1,
			InversedSCurve = 3,
			Linear = 4,
			SCurve = 5,
			Exp1 = 6,
			ReciprocalOfSineCurve = 7,
			Exp3 = 8
		}
		public enum audioEventActionType
		{
			Play = 0,
			PlayAnimation = 1,
			SetParameter = 2,
			StopSound = 3,
			SetSwitch = 4,
			StopTagged = 5,
			PlayExternal = 6,
			Tag = 7,
			Untag = 8,
			SetAppearanceName = 9,
			SetEntityName = 10,
			AddContainerStreamingPrefetch = 11,
			RemoveContainerStreamingPrefetch = 12
		}
		public enum audioFoleyActionType
		{
			FastHeavy = 0,
			FastMedium = 1,
			FastLight = 2,
			NormalHeavy = 3,
			NormalMedium = 4,
			NormalLight = 5,
			SlowHeavy = 6,
			SlowMedium = 7,
			SlowLight = 8,
			Walk = 9,
			Run = 10
		}
		public enum audioFoleyItemPriority
		{
			P0 = 0,
			P1 = 1,
			P2 = 2,
			P3 = 3,
			P4 = 4,
			P5 = 5,
			P6 = 6
		}
		public enum audioFoleyItemType
		{
			Jacket = 0,
			Top = 1,
			Bottom = 2,
			Jewelry = 3
		}
		public enum audioGameplayTier
		{
			Undefined = 0,
			Tier1_FullGameplay = 1,
			Tier2_StagedGameplay = 2,
			Tier3_LimitedGameplay = 3,
			Tier4_FPPCinematic = 4,
			Tier5_Cinematic = 5
		}
		public enum audioMaterialHardnessOverride
		{
			None = 0,
			SetAsSoft = 1,
			SetAsSolid = 2,
			SetAsHard = 3
		}
		public enum audioMeleeHitPerMaterialType
		{
			Light = 0,
			Light_Hard = 1,
			Light_Soft = 2,
			Light_Solid = 3,
			Light_Flesh = 4,
			Light_Robot = 5,
			Normal = 6,
			Normal_Hard = 7,
			Normal_Soft = 8,
			Normal_Solid = 9,
			Normal_Flesh = 10,
			Normal_Robot = 11,
			Heavy = 12,
			Heavy_Hard = 13,
			Heavy_Soft = 14,
			Heavy_Solid = 15,
			Heavy_Flesh = 16,
			Heavy_Robot = 17,
			Slash = 18,
			Slash_Hard = 19,
			Slash_Soft = 20,
			Slash_Solid = 21,
			Slash_Flesh = 22,
			Slash_Robot = 23,
			Cut = 24,
			Cut_Hard = 25,
			Cut_Soft = 26,
			Cut_Solid = 27,
			Cut_Flesh = 28,
			Cut_Robot = 29,
			Stab = 30,
			Stab_Hard = 31,
			Stab_Soft = 32,
			Stab_Solid = 33,
			Stab_Flesh = 34,
			Stab_Robot = 35,
			Finisher = 36,
			Finisher_Hard = 37,
			Finisher_Soft = 38,
			Finisher_Solid = 39,
			Finisher_Flesh = 40,
			Finisher_Robot = 41,
			Weak = 42,
			Weak_Hard = 43,
			Weak_Soft = 44,
			Weak_Solid = 45,
			Weak_Flesh = 46,
			Weak_Robot = 47
		}
		public enum audioMeleeHitType
		{
			Light = 0,
			Normal = 1,
			Heavy = 2,
			Slash = 3,
			Cut = 4,
			Stab = 5,
			Finisher = 6,
			Weak = 7
		}
		public enum audioMeleeMaterialType
		{
			Hard = 0,
			Soft = 1,
			Solid = 2,
			Flesh = 3,
			Robot = 4
		}
		public enum audioMixingActionType
		{
			VoContext = 0,
			EmitterTag = 1,
			SoundTag = 2,
			ActorName = 3,
			DisableCombatVo = 4,
			GlobalParameter = 5
		}
		public enum audioMixParamsAction
		{
			Mull = 0,
			MullPercent = 1,
			MullComplemtement = 2,
			MullComplemtementPercent = 3,
			Add = 4
		}
		public enum audioMusicSyncType
		{
			Bar = 0,
			Beat = 1,
			Grid = 2,
			User = 3,
			Transition = 4,
			EntryCue = 5,
			ExitCue = 6
		}
		public enum audioNumberComparer
		{
			Equal = 0,
			NotEqual = 1,
			Greater = 2,
			GreaterOrEqual = 3,
			Lower = 4,
			LowerOrEqual = 5
		}
		public enum audioNumberOperation
		{
			SetEqual = 0,
			Add = 1,
			Subtract = 2,
			MultiplyBy = 3,
			DivideBy = 4
		}
		public enum audioObstructionTestPattern
		{
			Direct = 0,
			Cone = 1
		}
		public enum audioObstructionTestType
		{
			SingleShot = 0,
			Continuous = 1
		}
		public enum audioRadioSoundType
		{
			Song = 0,
			AnnouncementScene = 1
		}
		public enum audioRadioSpeakerType
		{
			Stanley = 0,
			MaximumMike = 1,
			PoliceDispatch = 2
		}
		public enum audioReflectionVariant
		{
			WorldSpaceFixedDrections = 0,
			LocalSpaceFixedDirections = 1,
			FindingMaximumFaceAlignemnt = 2,
			LocalSpaceSideDirections = 3,
			FindingMaximumFaceAligment2Sides = 4
		}
		public enum audiottsvoicesFemale
		{
			Olivia = 7,
			Emily = 8,
			Jessica = 9,
			Sophie = 10,
			Elizabeth = 11,
			Carolina = 12,
			Sarah = 13
		}
		public enum audiottsvoicesMale
		{
			Andrew = 0,
			Oliver = 1,
			Jack = 2,
			Harry = 3,
			Simon = 4,
			Charlie = 5,
			Thomas = 6
		}
		public enum audiottsvoicesPolishFemale
		{
			Iwona = 16,
			Paulina = 17
		}
		public enum audiottsvoicesPolishMale
		{
			Mateusz = 14,
			Pawel = 15
		}
		public enum audioVoBarkType
		{
			None = 0,
			Curse = 1,
			Morale = 2,
			Combat_Aggro = 3,
			Combat_Despair = 4,
			Stealth_Curious = 5
		}
		public enum audioVoCpoCharacter
		{
			None = 0,
			Solo = 1,
			Assassin = 2,
			Techie = 3,
			Netrunner = 4
		}
		public enum audioVoGruntInterruptMode
		{
			DontInterrupt = 0,
			PlayOnlyOnInterrupt = 1,
			CanInterrupt = 2
		}
		public enum audioVoGruntType
		{
			None = -1,
			PainLong = 0,
			AgroShort = 1,
			AgroLong = 2,
			LongFall = 3,
			Death = 4,
			SilentDeath = 5,
			Grapple = 6,
			GrappleMovement = 7,
			EnvironmentalKnockdown = 8,
			Bump = 9,
			Curious = 10,
			Fear = 11,
			Jump = 12,
			EffortLong = 13,
			DeathShort = 14,
			Greet = 15,
			LaughHard = 16,
			LaughSoft = 17,
			Phone = 18,
			BraindanceExcited = 19,
			BraindanceFearful = 20,
			BraindanceNeutral = 21,
			BraindanceSexual = 22,
			PainShort = 23,
			Effort = 25
		}
		public enum audioWeaponBulletType
		{
			standard = 0,
			sniper = 1,
			shot = 2,
			rail = 3,
			automatic = 4,
			smart = 5,
			smart_sniper = 6,
			hmg = 7
		}
		public enum audioWeaponShellCasingDirection
		{
			rightFront = 0,
			rightBack = 1,
			leftFront = 2,
			leftBack = 3
		}
		public enum audioWeaponShellCasingMode
		{
			none = 0,
			onShoot = 1,
			onReload = 2
		}
		public enum audioWeaponShellCasingType
		{
			standard = 0,
			large = 1,
			cartridge = 2
		}
		public enum audioWeaponTailEnvironment
		{
			InteriorDefault = 0,
			InteriorWide = 1,
			ExteriorWide = 2,
			ExteriorUrbanNarrow = 3,
			ExteriorUrbanStreet = 4,
			ExteriorUrbanStreetWide = 5,
			ExteriorUrbanOpen = 6,
			ExteriorUrbanEnclosed = 7,
			ExteriorBadlandsOpen = 8,
			ExteriorBadlandsCanyon = 9
		}
		public enum BlacklistReason
		{
			UNINITIALIZED = 0,
			TRESPASSING = 1,
			REPRIMAND = 2,
			COMBAT = 3
		}
		public enum braindanceVisionMode
		{
			Default = 0,
			Audio = 1,
			Thermal = 2
		}
		public enum ButtonStatus
		{
			DEFAULT = 0,
			PROCESSING = 1,
			DISABLED = 2
		}
		public enum CharacterScreenType
		{
			Attributes = 0,
			Perks = 1
		}
		public enum ClueState
		{
			active = 0,
			complete = 1
		}
		public enum CodexCategoryType
		{
			Invalid = -1,
			All = 0,
			Database = 1,
			Characters = 2,
			Locations = 3,
			Tutorials = 4,
			Count = 5
		}
		public enum CodexDataSource
		{
			Undefined = 0,
			Codex = 1,
			Onscreen = 2
		}
		public enum CodexImageType
		{
			Default = 0,
			Character = 1
		}
		public enum communityECommunitySpawnTime
		{
			Morning = 0,
			Day = 1,
			Evening = 2,
			Night = 3,
			Midnight = 4,
			[RED("1:00")] _1_00 = 5,
			[RED("2:00")] _2_00 = 6,
			[RED("3:00")] _3_00 = 7,
			[RED("4:00")] _4_00 = 8,
			[RED("5:00")] _5_00 = 9,
			[RED("6:00")] _6_00 = 10,
			[RED("7:00")] _7_00 = 11,
			[RED("8:00")] _8_00 = 12,
			[RED("9:00")] _9_00 = 13,
			[RED("10:00")] _10_00 = 14,
			[RED("11:00")] _11_00 = 15,
			[RED("12:00 - Noon")] _12_00___Noon = 16,
			[RED("13:00")] _13_00 = 17,
			[RED("14:00")] _14_00 = 18,
			[RED("15:00")] _15_00 = 19,
			[RED("16:00")] _16_00 = 20,
			[RED("17:00")] _17_00 = 21,
			[RED("18:00")] _18_00 = 22,
			[RED("19:00")] _19_00 = 23,
			[RED("20:00")] _20_00 = 24,
			[RED("21:00")] _21_00 = 25,
			[RED("22:00")] _22_00 = 26,
			[RED("23:00")] _23_00 = 27
		}
		public enum communityESquadType
		{
			Global = 0,
			Community = 1,
			Security = 2,
			Unknown = 3
		}
		public enum ConfigGraphicsQualityLevel
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3,
			RTXMedium = 4,
			RTXUltra = 5,
			Cinematic = 6,
			Cinematic_RTX = 7,
			CinematicEXR = 8,
			CinematicEXR_RTX = 9,
			Console = 10,
			ConsolePro = 11,
			ConsoleEarlyNextGen = 12,
			ConsoleEarlyNextGenQuality = 13,
			GeForceNow = 14,
			IconsGeneration = 15,
			SafeMode = 16,
			Auto = 17
		}
		public enum ConfigTextureQualityLevel
		{
			Console = 0,
			ConsoleSafe = 1,
			Low = 2,
			Medium = 3,
			High = 4,
			SafeMode = 5,
			Auto = 6
		}
		public enum coverLeanDirection
		{
			Top = 0,
			Left = 1,
			Right = 2
		}
		public enum CrafringMaterialItemHighlight
		{
			None = 0,
			Hover = 1,
			Add = 2,
			Remove = 3
		}
		public enum CraftingCommands
		{
			CraftingFinished = 0,
			DisassemblingFinished = 1,
			UpgradingFinished = 2,
			Failed = 3
		}
		public enum CraftingInfoType
		{
			QuickHack = 0,
			Item = 1
		}
		public enum CraftingMode
		{
			craft = 0,
			upgrade = 1
		}
		public enum CraftingNotificationType
		{
			NoPerks = 0,
			NotEnoughMaterial = 1
		}
		public enum curveEInterpolationType
		{
			EIT_Constant = 0,
			EIT_Linear = 1,
			EIT_BezierQuadratic = 2,
			EIT_BezierCubic = 3,
			EIT_Hermite = 4
		}
		public enum curveESegmentsLinkType
		{
			ESLT_Normal = 0,
			ESLT_Smooth = 1,
			ESLT_SmoothSymmetric = 2
		}
		public enum CustomButtonType
		{
			UnlockAllVehicles = 0,
			ShowAllPoiMappins = 1,
			DiscoverAllPoiMappins = 2
		}
		public enum CustomWeaponWheelSlot
		{
			FreeHands = 0,
			Fists = 1
		}
		public enum CyberwareInfoType
		{
			Default = 0,
			Cyberdeck = 1
		}
		public enum CyberwareScreenType
		{
			Ripperdoc = 0,
			Inventory = 1
		}
		public enum DamageEffectDisplayType
		{
			Invalid = -1,
			Flat = 0,
			TargetHealth = 1
		}
		public enum damageSystemLogFlags
		{
			GENERAL = 1,
			ASSERT = 2,
			WEAKSPOTS = 4
		}
		public enum DerivedFilterResult
		{
			False = 0,
			True = 1,
			Pass = 2
		}
		public enum DeviceStimType
		{
			Distract = 0,
			VisualDistract = 1,
			Explosion = 2,
			VentilationAreaEffect = 3,
			None = 4
		}
		public enum DronePose
		{
			Relaxed = 0,
			Combat = 1
		}
		public enum DropdownDisplayContext
		{
			NotSet = 0,
			Default = 1,
			ItemChooserWeapon = 2
		}
		public enum DropdownItemDirection
		{
			None = 0,
			Down = 1,
			Up = 2
		}
		public enum DropPointPackageStatus
		{
			NOT_ACTIVE = 0,
			ACTIVE = 1,
			COLLECTED = 2
		}
		public enum DynamicTextureDataFormat
		{
			R_Uint8 = 0,
			R_Float16 = 1,
			R_Float32 = 2,
			RG_Float16 = 3,
			RG_Float32 = 4,
			RGBA_Uint8 = 5,
			RGBA_Uint8_SRGB = 6,
			RGBA_Float16 = 7,
			RGBA_Float32 = 8
		}
		public enum EActionContext
		{
			None = -1,
			Direct = 0,
			QHack = 1,
			Master = 2,
			Spiderbot = 3
		}
		public enum EActionInactivityReson
		{
			Ready = 0,
			Locked = 1,
			Recompilation = 2,
			OutOfMemory = 3,
			Invalid = 4
		}
		public enum EActionsSequencerMode
		{
			REGULAR_INTERVALS = 0,
			ACCELERATING_INTERVALS_TODO = 1,
			DECELERATING_INTEVALS_TODO = 2,
			RANDOM_INTERVALS_TODO = 3,
			AT_THE_SAME_TIME_TODO = 4
		}
		public enum EActionType
		{
			QuickAction = 0,
			ChargeAction = 1,
			None = 2
		}
		public enum EActivationState
		{
			NONE = 0,
			ACTIVATED = 1,
			DEACTIVATED = 2
		}
		public enum EAIActionPhase
		{
			Inactive = 0,
			Startup = 1,
			Loop = 2,
			Recovery = 3
		}
		public enum EAIActionState
		{
			Inactive = 0,
			Startup = 1,
			Loop = 2,
			Recover = 3
		}
		public enum EAIActionTarget
		{
			None = 0,
			CombatTarget = 1,
			FriendlyTarget = 2,
			CurrentCover = 3,
			StimTarget = 4,
			StimSource = 5,
			CustomWorldPosition = 6
		}
		public enum EAIAttitude
		{
			AIA_Friendly = 0,
			AIA_Neutral = 1,
			AIA_Hostile = 2
		}
		public enum EAIBackgroundCombatStep
		{
			ChangeCover = 0,
			ChangeTarget = 1
		}
		public enum EAICombatPreset
		{
			None = 0,
			IsReckless = 1,
			IsAggressive = 2,
			IsBalanced = 3,
			IsDefensive = 4,
			IsCautious = 5
		}
		public enum EAICoverAction
		{
			StepOut = 0,
			LeanOut = 1,
			StepUp = 2,
			LeanOver = 3,
			Undefined = 4
		}
		public enum EAICoverActionDirection
		{
			Front = 0,
			FrontRight = 1,
			Right = 2,
			BackRight = 3,
			Back = 4,
			BackLeft = 5,
			Left = 6,
			FrontLeft = 7
		}
		public enum EAIDismembermentBodyPart
		{
			NONE = -1,
			LEFT_ARM = 0,
			RIGHT_ARM = 1,
			LEFT_LEG = 2,
			RIGHT_LEG = 3,
			HEAD = 4,
			BODY = 5
		}
		public enum EAIGateEventFlags
		{
			AIGEF_Undefined = 0,
			AIGEF_OverridesSelf = 1,
			AIGEF_InterruptsSamePriorityTask = 2,
			AIGEF_InterruptsForcedBehavior = 3,
			AIGEF_AcceptsAdditives = 4
		}
		public enum EAIGateSignalFlags
		{
			AIGSF_Undefined = 0,
			AIGSF_OverridesSelf = 1,
			AIGSF_InterruptsSamePriorityTask = 2,
			AIGSF_InterruptsForcedBehavior = 3,
			AIGSF_AcceptsAdditives = 4
		}
		public enum EAIHitBodyPart
		{
			None = -1,
			Head = 1,
			LeftTorso = 2,
			RightTorso = 3,
			Belly = 4,
			LeftLeg = 5,
			RightLeg = 6
		}
		public enum EAIHitDirection
		{
			None = -1,
			Left = 0,
			Back = 1,
			Right = 2,
			Front = 3
		}
		public enum EAIHitIntensity
		{
			None = -1,
			Light = 0,
			Medium = 1,
			Heavy = 2,
			Explosion = 3
		}
		public enum EAIHitSource
		{
			None = -1,
			Ranged = 0,
			MeleeSharp = 1,
			MeleeBlunt = 2,
			QuickMelee = 3
		}
		public enum EAILastHitReactionPlayed
		{
			None = -1,
			Twitch = 0,
			Impact = 1,
			Stagger = 2,
			Knockdown = 3
		}
		public enum EAimAssistLevel
		{
			Off = 0,
			Light = 1,
			Standard = 2
		}
		public enum EAIPlayerSquadOrder
		{
			Takedown = 0,
			Invalid = 1
		}
		public enum EAIRole
		{
			None = 0,
			Patrol = 1,
			Follower = 2
		}
		public enum EAIShootingPatternRange
		{
			Close = 0,
			Medium = 1,
			Long = 2,
			Undefined = 3
		}
		public enum EAISquadAction
		{
			Invalid = 0,
			Shoot = 1,
			Charge = 2,
			TakeCover = 3,
			Search = 4,
			Reprimand = 5,
			Investigate = 6,
			Melee = 7,
			Taunt = 8,
			Defend = 9,
			Takedown = 10,
			Peek = 11,
			GrenadeThrow = 12,
			Dash = 13,
			Sync = 14,
			BattleCry = 15,
			CallOff = 16,
			BackUp = 17,
			RangedStrafe = 18,
			Quickhack = 19,
			GroupReaction = 20,
			Crouch = 21
		}
		public enum EAISquadChoiceAlgorithm
		{
			Invalid = 0,
			TargetDistance = 1,
			SectorDistance = 2,
			SquadmateDistance = 3,
			CoopDistance = 4,
			LineOfSight = 5,
			StimDistance = 6,
			StimDistancePerSource = 7,
			AvoidLastPuppetIfPossible = 8,
			Officer = 9,
			Group = 10,
			CallForBackUp = 11,
			CallOffAction = 12,
			ShareNewThreat = 13
		}
		public enum EAISquadRing
		{
			Invalid = 0,
			Melee = 1,
			Close = 2,
			Medium = 3,
			Far = 4,
			Extreme = 5
		}
		public enum EAISquadTactic
		{
			Invalid = 0,
			Flanking = 1,
			Assault = 2,
			Snipe = 3,
			Regroup = 4,
			Retreat = 5,
			Defend = 6,
			Suppress = 7,
			Medivac = 8,
			Panic = 9
		}
		public enum EAISquadVerb
		{
			Invalid = 0,
			JoinSquad = 1,
			LeaveSquad = 2,
			OpenSquadAction = 3,
			RevokeSquadAction = 4,
			RevokeOrder = 5,
			CommitToSquadAction = 6,
			ReportDoneOnSquadAction = 7,
			ReportFailureOnSquadAction = 8,
			EvaluateTicketActivation = 9,
			EvaluateTicketDeactivation = 10,
			AcknowledgeOrder = 11
		}
		public enum EAITargetType
		{
			AITT_Undefined = 0,
			AITT_Argument = 1,
			AITT_Owner = 2,
			AITT_CombatTarget = 3,
			AITT_FacingTarget = 4,
			AITT_Attacker = 5,
			AITT_Companion = 6,
			AITT_Cover = 7
		}
		public enum EAIThreatCalculationType
		{
			Regular = 0,
			Boss = 1,
			Madness = 2
		}
		public enum EAITicketStatus
		{
			Invalid = 0,
			Evaluate = 1,
			OrderFail = 2,
			OrderDone = 3,
			OrderRevoked = 4
		}
		public enum EAllowedTo
		{
			UNDEFINED = 0,
			TRESSPASSING = 1,
			ILLEGAL_ACTIONS = 2,
			COMBAT = 3
		}
		public enum EAnimationBufferDataAvailable
		{
			ABDA_None = 0,
			ABDA_Partial = 1,
			ABDA_All = 2
		}
		public enum EAnimationType
		{
			REGULAR = 0,
			TRANSFORM = 1,
			TRANSFORM_TWO_SIDES = 2,
			NONE = 3
		}
		public enum EApertureValue
		{
			[RED("f/1.0")] f_1_0 = 0,
			[RED("f/1.4")] f_1_4 = 1,
			[RED("f/2.0")] f_2_0 = 2,
			[RED("f/2.8")] f_2_8 = 3,
			[RED("f/4.0")] f_4_0 = 4,
			[RED("f/5.6")] f_5_6 = 5,
			[RED("f/8.0")] f_8_0 = 6,
			[RED("f/11.0")] f_11_0 = 7,
			[RED("f/16.0")] f_16_0 = 8,
			[RED("f/22.0")] f_22_0 = 9,
			[RED("f/32.0")] f_32_0 = 10
		}
		public enum EAreaLightShape
		{
			ALS_Sphere = 0,
			ALS_Capsule = 1
		}
		public enum EArgumentType
		{
			Object = 0,
			CoverID = 1,
			Vector4 = 2
		}
		public enum EAttackType
		{
			Invalid = 0,
			Ranged = 1,
			Melee = 2
		}
		public enum EAxisType
		{
			X = 0,
			Y = 1,
			Z = 2
		}
		public enum EBarkList
		{
			vo_enemy_reaction_surprised_combat_start = 0,
			vo_enemy_reaction_generic_cursing = 1,
			vo_enemy_reaction_jammed_weapon = 2,
			vo_enemy_reaction_impact_hit = 3,
			vo_enemy_reaction_stagger_hit = 4,
			vo_enemy_reaction_crippled_arm = 5,
			vo_enemy_reaction_crippled_leg = 6,
			vo_enemy_reaction_death = 7,
			vo_enemy_group_call_to_combat = 8,
			vo_enemy_group_call_for_help = 9,
			vo_enemy_group_order_go_to_cover = 10,
			vo_enemy_group_order_flank_target = 11,
			vo_enemy_group_order_suppressing_fire = 12,
			vo_enemy_answer_to_order_suppressing_fire = 13,
			vo_enemy_group_notification_reloading = 14,
			vo_enemy_group_notification_squad_member_died = 15,
			vo_enemy_group_notification_grenade_nearby = 16,
			vo_enemy_group_notification_target_using_sandevistan = 17,
			vo_enemy_group_notification_target_using_kerenzikov = 18,
			vo_enemy_answer_to_notification_target_using_sandevistan = 19,
			vo_enemy_answer_to_notification_target_using_kerenzikov = 20,
			vo_enemy_group_generic_combat_question = 21,
			vo_enemy_answer_to_generic_combat_question = 22,
			vo_enemy_group_boost_combat_morale = 23
		}
		public enum EBeamStyle
		{
			None = 0,
			Sweeping = 1,
			HeadSlicer = 2
		}
		public enum EBinkOperationType
		{
			PLAY = 0,
			STOP = 1,
			PAUSE = 2,
			RESUME = 3
		}
		public enum EBOOL
		{
			UNINITIALZED = 0,
			FALSE = 1,
			TRUE = 2
		}
		public enum EBreachOrigin
		{
			LOCAL = 0,
			EXTERNAL = 1,
			GLOBAL = 2
		}
		public enum EBroadcasteingType
		{
			Active = 0,
			SingleActive = 1,
			Direct = 2,
			Remove = 3,
			Single = 4
		}
		public enum ECallbackExpressionActions
		{
			SetTrue = 0,
			SetFalse = 1,
			Toggle = 2
		}
		public enum ECameraDirectionFunctionalTestsUtil
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}
		public enum ECarryState
		{
			None = 0,
			Pickup = 1,
			Carry = 2,
			Drop = 3,
			Release = 4,
			Dispose = 5,
			Jump = 6
		}
		public enum ECartOperationResult
		{
			Success = 0,
			NoItems = 1,
			AllItems = 2,
			WontSell = 3,
			WontBuy = 4,
			QuestItem = 5,
			NotInCart = 6
		}
		public enum ECentaurShieldState
		{
			Inactive = 0,
			Activating = 1,
			Active = 2,
			Destroyed = 3,
			Hacked = 4
		}
		public enum ECLSForcedState
		{
			DEFAULT = 0,
			ForcedON = 1,
			ForcedOFF = 2
		}
		public enum EColorChannel
		{
			COLCHANNEL_Red = 0,
			COLCHANNEL_Green = 1,
			COLCHANNEL_Blue = 2,
			COLCHANNEL_Alpha = 3
		}
		public enum EColorMappingFunction
		{
			CMF_Linear = 0,
			CMF_sRGB = 1,
			CMF_ArriLogC = 2
		}
		public enum EColorPrimary
		{
			PRIM_REC709 = 0,
			PRIM_DCIP3 = 1,
			PRIM_BT2020 = 2
		}
		public enum ECompanionDistancePreset
		{
			Medium = 0,
			Close = 1,
			Far = 2,
			VeryFar = 3
		}
		public enum ECompanionPositionPreset
		{
			Behind = 0,
			InFront = 1
		}
		public enum ECompareOp
		{
			CO_Lesser = 0,
			CO_LesserEq = 1,
			CO_Greater = 2,
			CO_GreaterEq = 3,
			CO_Equal = 4,
			CO_NotEqual = 5
		}
		public enum EComparisonOperator
		{
			Equal = 0,
			NotEqual = 1,
			More = 2,
			MoreOrEqual = 3,
			Less = 4,
			LessOrEqual = 5
		}
		public enum EComparisonType
		{
			Greater = 0,
			GreaterOrEqual = 1,
			Equal = 2,
			NotEqual = 3,
			Less = 4,
			LessOrEqual = 5
		}
		public enum EComponentOperation
		{
			Enable = 0,
			Disable = 1
		}
		public enum EComputerAnimationState
		{
			None = 0,
			Opened = 1,
			Closed = 2
		}
		public enum EComputerMenuType
		{
			MAIN = 0,
			SYSTEM = 1,
			FILES = 2,
			MAILS = 3,
			NEWSFEED = 4,
			INTERNET = 5,
			INVALID = 6
		}
		public enum EConclusionQuestState
		{
			Undefined = 0,
			Active = 1,
			Inactive = 2,
			Shown = 3
		}
		public enum ECookingPlatform
		{
			PLATFORM_None = 0,
			PLATFORM_PC = 1,
			PLATFORM_XboxOne = 2,
			PLATFORM_PS4 = 3,
			PLATFORM_WindowsServer = 4,
			PLATFORM_LinuxServer = 5
		}
		public enum ECooldownGameControllerMode
		{
			COOLDOWNS = 0,
			BUFFS_AND_DEBUFFS = 1
		}
		public enum ECooldownIndicatorState
		{
			Pooled = 0,
			Intro = 1,
			Filling = 2,
			Outro = 3
		}
		public enum ECoverSpecialAction
		{
			None = 0,
			Left = 1,
			Right = 2
		}
		public enum ECraftingIconPositioning
		{
			generic = 0,
			weaponBig = 1,
			weaponSmall = 2
		}
		public enum ECubeSourceTextureType
		{
			CST_CrossHorizontal = 0,
			CST_CrossVertical = 1,
			CST_Panorama = 2
		}
		public enum ECustomCameraTarget
		{
			ECCTV_All = 0,
			ECCTV_OnlyOffscreen = 1,
			ECCTV_OnlyOnscreen = 2
		}
		public enum ECustomMaterialParam
		{
			ECMP_CustomParam0 = 1,
			ECMP_CustomParam1 = 2,
			ECMP_CustomParam2 = 4,
			ECMP_CustomParam3 = 8,
			ECMP_CustomParam4 = 16,
			ECMP_CustomParam5 = 32,
			ECMP_CustomParam6 = 64
		}
		public enum EDeathType
		{
			Ground = 0,
			Air = 1,
			Swimming = 2
		}
		public enum EDebuggerColor
		{
			RED = 0,
			YELLOW = 1
		}
		public enum EDecalRenderMode
		{
			DRM_AllStatic = 0,
			DRM_ObjectType = 1,
			DRM_AllDynamic = 2
		}
		public enum EDepthCollisionEffect
		{
			DCE_Bounce = 1,
			DCE_Glide = 2,
			DCE_Kill = 4
		}
		public enum EDeviceChallengeAttribute
		{
			Invalid = 0,
			Strength = 1,
			Reflexes = 2,
			Intelligence = 3,
			TechnicalAbility = 4,
			Cool = 5
		}
		public enum EDeviceChallengeSkill
		{
			Invalid = 0,
			Hacking = 1,
			Engineering = 2,
			Athletics = 3
		}
		public enum EDeviceDurabilityState
		{
			NOMINAL = 0,
			MALFUNCTIONING = 1,
			BROKEN = 2,
			DESTROYED = 3
		}
		public enum EDeviceDurabilityType
		{
			INVULNERABLE = 0,
			INDESTRUCTIBLE = 1,
			DESTRUCTIBLE = 2
		}
		public enum EDeviceStatus
		{
			DISABLED = -2,
			UNPOWERED = -1,
			OFF = 0,
			ON = 1,
			INVALID = 2
		}
		public enum EDocumentType
		{
			FILE = 0,
			MAIL = 1,
			Invalid = 2
		}
		public enum EDodgeMovementInput
		{
			Invalid = 0,
			Forward = 1,
			Right = 2,
			Left = 3,
			Back = 4
		}
		public enum EDoorOpeningType
		{
			SLIDING_HORIZONTALLY = 0,
			SLIDING_VERTICALLY = 1,
			HINGED = 2,
			GATE = 3
		}
		public enum EDoorSkillcheckSide
		{
			BOTH = 0,
			ONE = 1,
			TWO = 2
		}
		public enum EDoorStatus
		{
			SEALED = -2,
			LOCKED = -1,
			CLOSED = 0,
			OPENED = 1
		}
		public enum EDoorTriggerSide
		{
			OUTSIDE = 0,
			ONE = 1,
			TWO = 2
		}
		public enum EDoorType
		{
			NONE = 0,
			INTERACTIVE = 1,
			AUTOMATIC = 2,
			PHYSICAL = 3,
			REMOTELY_CONTROLLED = 4
		}
		public enum EDownedType
		{
			Killed = 0,
			Finished = 1,
			Defeated = 2,
			Unconscious = 3
		}
		public enum EDPadSlot
		{
			Left = 0,
			Up = 1,
			Right = 2,
			Down = 3,
			LeftDouble = 4,
			UpDouble = 5,
			RightDouble = 6,
			DownDouble = 7,
			WeaponsWheel = 8,
			VehicleWheel = 9,
			GadgetWheel = 10,
			InteractionWheel = 11,
			Phone = 12,
			CallVehicle = 13,
			CycleObjective = 14,
			VehicleInsideWheel = 15,
			ConsumableWheel = 16
		}
		public enum EDrillMachineRewireState
		{
			InsideInteractionRange = 0,
			OutsideInteractionRange = 1,
			InteractionStarted = 2,
			InteractionFinished = 3,
			RewireStarted = 4,
			RewireFinished = 5
		}
		public enum EDynamicDecalSpawnPriority
		{
			RDDS_Normal = 0,
			RDDS_Highest = 1
		}
		public enum EEasingType
		{
			EET_In = 0,
			EET_Out = 1,
			EET_InOut = 2
		}
		public enum EEffectOperationType
		{
			START = 0,
			STOP = 1,
			BRAKE_LOOP = 2
		}
		public enum EEmitterGroup
		{
			EG_Default = 0,
			EG_Group0 = 1,
			EG_Group1 = 2,
			EG_Group2 = 3,
			EG_Group3 = 4,
			EG_Group4 = 5,
			EG_Group5 = 6,
			EG_Group6 = 7,
			EG_Group7 = 8,
			EG_Group8 = 9,
			EG_Group9 = 10,
			EG_Group10 = 11,
			EG_Group11 = 12,
			EG_Group12 = 13,
			EG_Group13 = 14,
			EG_Group14 = 15,
			EG_Group15 = 16
		}
		public enum EEntityHighlightType
		{
			EHE_None = 0,
			EHE_FillAndOutline = 1,
			EHE_FillOnly = 2,
			EHE_OutlineOnly = 3
		}
		public enum EEnvColorGroup
		{
			ECG_Default = 0,
			ECG_Sky = 1,
			ECG_Group0 = 2,
			ECG_Group1 = 3,
			ECG_Group2 = 4,
			ECG_Group3 = 5,
			ECG_Group4 = 6,
			ECG_Group5 = 7,
			ECG_Group6 = 8,
			ECG_Group7 = 9,
			ECG_Group8 = 10,
			ECG_Group9 = 11,
			ECG_Group10 = 12,
			ECG_Group11 = 13,
			ECG_Group12 = 14,
			ECG_Group13 = 15,
			ECG_Group14 = 16,
			ECG_Group15 = 17
		}
		public enum EEnvManagerModifier
		{
			EMM_None = 0,
			EMM_WireframeSolid = 1,
			EMM_WireframeSeethrough = 2,
			EMM_Overdraw = 3,
			EMM_OverdrawSeethrough = 4,
			EMM_ParticleOverdraw = 5,
			EMM_ParticleNumLights = 6,
			EMM_DecalOverdraw = 7,
			EMM_LightOverdraw = 8,
			EMM_SceneReferredColor = 9,
			EMM_DisplayReferredColor = 10,
			EMM_GlobalIllumination = 11,
			EMM_SurfaceMaterialID = 12,
			EMM_SurfaceObjectID = 13,
			EMM_SurfaceBaseColor = 14,
			EMM_SurfaceAlbedo = 15,
			EMM_SurfaceSpecularity = 16,
			EMM_SurfaceMetalness = 17,
			EMM_SurfaceRoughness = 18,
			EMM_SurfaceEmissive = 19,
			EMM_SurfaceTranslucency = 20,
			EMM_SurfaceNormalsWorldSpace = 21,
			EMM_SurfaceNormalsViewSpace = 22,
			EMM_SurfaceHairDirection = 23,
			EMM_SurfaceHairID = 24,
			EMM_SurfaceLightBlockerIntensity = 25,
			EMM_GBuffer1RGB = 26,
			EMM_GBuffer1A = 27,
			EMM_ConeAODir = 28,
			EMM_ConeAOAngle = 29,
			EMM_VelocityBuffer = 30,
			EMM_Depth = 31,
			EMM_UvDensity = 32,
			EMM_ToneMappingLuminance = 33,
			EMM_ToneMappingThresholds = 34,
			EMM_LuminanceSpotMeter = 35,
			EMM_IlluminanceMeter = 36,
			EMM_DiffuseLight = 37,
			EMM_SpecularLight = 38,
			EMM_ClayView = 39,
			EMM_PureGreyscaleView = 40,
			EMM_PureWhiteView = 41,
			EMM_PureReflectionView = 42,
			EMM_PureGreyReflectionView = 43,
			EMM_Cascades = 44,
			EMM_MaskShadow = 45,
			EMM_MaskSSAO = 46,
			EMM_MaskTXAA = 47,
			EMM_MaskDistortion = 48,
			EMM_SurfaceCacheID = 49,
			EMM_SurfaceCacheResolution = 50,
			EMM_LightChannels = 51,
			EMM_DebugHitProxies = 52,
			EMM_DebugShadowsMode = 53,
			EMM_RayTracingDebug = 54,
			EMM_SSRResults = 55,
			EMM_SSRFade = 56,
			EMM_DepthOfFieldCoC = 57,
			EMM_MultilayeredMode = 58,
			EMM_MultilayeredProxy = 59,
			EMM_MultilayeredUniqueMasks = 60,
			EMM_MultilayeredMaskWeight = 61,
			EMM_LocalShadowsVariance = 62,
			EMM_LocalShadowsRangesOverlapDynamicsOnly = 63,
			EMM_LocalShadowsRangesOverlapStaticsOnly = 64,
			EMM_LODColoring = 65,
			EMM_TodvisRuntimePreview = 66,
			EMM_TodvisBakePreview = 67,
			EMM_RainMask = 68,
			EMM_VolFogDensity = 69
		}
		public enum EEquipmentSide
		{
			Left = 0,
			Right = 1
		}
		public enum EEquipmentState
		{
			Unequipped = 0,
			Equipped = 1,
			Equipping = 2,
			Unequipping = 3,
			FirstEquip = 4
		}
		public enum EExplosiveAdditionalGameEffectType
		{
			none = 0,
			EMP = 1
		}
		public enum EFastTravelSystemInstruction
		{
			Forward = 0,
			Previous = 1
		}
		public enum EFastTravelTriggerType
		{
			Manual = 0,
			Auto = 1
		}
		public enum EFeatureFlag
		{
			FEATFLAG_Default = 0,
			FEATFLAG_Shadows = 1,
			FEATFLAG_HitProxies = 2,
			FEATFLAG_Selection = 3,
			FEATFLAG_Wireframe = 4,
			FEATFLAG_VelocityBuffer = 5,
			FEATFLAG_DebugDraw_BlendOff = 6,
			FEATFLAG_DebugDraw_BlendOn = 7,
			FEATFLAG_DynamicDecals = 8,
			FEATFLAG_Highlights = 9,
			FEATFLAG_Overdraw = 10,
			FEATFLAG_IndirectInstancedGrass = 11,
			FEATFLAG_DecalsOnStaticObjects = 12,
			FEATFLAG_DecalsOnDynamicObjects = 13,
			FEATFLAG_MaskParticlesInsideCar = 14,
			FEATFLAG_MaskParticlesInsideInterior = 15,
			FEATFLAG_MaskTXAA = 16,
			FEATFLAG_DistantShadows = 17,
			FEATFLAG_FloatTracks = 18,
			FEATFLAG_Rain = 19,
			FEATFLAG_NumLights = 20,
			FEATFLAG_DepthPrepass = 21
		}
		public enum EFilterType
		{
			ALLOW_NONE = 0,
			ALLOW_COMBAT_ONLY = 1,
			ALLOW_ALL = 2
		}
		public enum EFocusClueInvestigationState
		{
			NONE = 0,
			INSPECTED = 1,
			NOT_INSPECTED = 2
		}
		public enum EFocusForcedHighlightType
		{
			INTERACTION = 0,
			IMPORTANT_INTERACTION = 1,
			QUEST = 2,
			DISTRACTION = 3,
			CLUE = 4,
			NPC = 5,
			WEAKSPOT = 6,
			AOE = 7,
			ITEM = 8,
			HOSTILE = 9,
			FRIENDLY = 10,
			NEUTRAL = 11,
			HACKABLE = 12,
			ENEMY_NETRUNNER = 13,
			BACKDOOR = 14,
			INVALID = 15
		}
		public enum EFocusOutlineType
		{
			HOSTILE = 0,
			FRIENDLY = 1,
			NEUTRAL = 2,
			ITEM = 3,
			INTERACTION = 4,
			IMPORTANT_INTERACTION = 5,
			QUEST = 6,
			CLUE = 7,
			DISTRACTION = 8,
			AOE = 9,
			HACKABLE = 10,
			WEAKSPOT = 11,
			ENEMY_NETRUNNER = 12,
			BACKDOOR = 13,
			INVALID = 14
		}
		public enum EForcedElevatorArrowsState
		{
			Disabled = 0,
			ArrowsUp = 1,
			ArrowsDown = 2
		}
		public enum EFreeVectorAxes
		{
			FVA_One = 1,
			FVA_Two = 2,
			FVA_Three = 3,
			FVA_Four = 4
		}
		public enum EGameplayChallengeLevel
		{
			NONE = 0,
			EASY = 1,
			MEDIUM = 2,
			HARD = 3,
			IMPOSSIBLE = 4
		}

		public enum EGameSessionDataType
		{
			NONE = 0,
			CameraDeadBody = 1,
			CameraTagLimit = 2
		}
		public enum EGenericNotificationPriority
		{
			Default = 0,
			Low = 1,
			Medium = 2,
			Height = 3
		}
		public enum EGlitchState
		{
			NONE = 0,
			DEFAULT = 1,
			SUBLIMINAL_MESSAGE = 2
		}
		public enum EGravityType
		{
			LowGravity = 0,
			Regular = 1
		}
		public enum EGrenadeType
		{
			Frag = 0,
			Flash = 1,
			Piercing = 2,
			EMP = 3,
			Biohazard = 4,
			Incendiary = 5,
			Recon = 6,
			Cutting = 7,
			Sonic = 8
		}
		public enum EHandEquipSlot
		{
			None = 0,
			Left = 1,
			Right = 2
		}
		public enum EHitReactionMode
		{
			Regular = 0,
			ForceImpact = 1,
			ForceStagger = 2,
			ForceKnockdown = 3,
			Fragile = 4,
			Weak = 5,
			Tough = 6,
			Bulky = 7,
			Unstoppable = 8,
			UnstoppableTwitchMin = 9,
			UnstoppableTwitchNone = 10,
			StaggerMin = 11,
			BulkyStaggerMin = 12,
			Invalid = 13
		}
		public enum EHitReactionZone
		{
			Head = 0,
			ChestLeft = 1,
			ArmLeft = 2,
			HandLeft = 3,
			ChestRight = 4,
			ArmRight = 5,
			HandRight = 6,
			Abdomen = 7,
			LegLeft = 8,
			LegRight = 9,
			Special = 10
		}
		public enum EHitShapeType
		{
			None = -1,
			Flesh = 0,
			Metal = 1,
			Cyberware = 2,
			Armor = 3
		}
		public enum EHotkeyRequestType
		{
			Assign = 0,
			Cycle = 1,
			Restore = 2
		}
		public enum EHudAvatarMode
		{
			Connecting = 0,
			Disconnecting = 1,
			Holocall = 2,
			Audiocall = 3
		}
		public enum EHudPhoneFunction
		{
			Inactive = 0,
			DisplayingMessage = 1,
			IncomingCall = 2,
			Holocall = 3,
			Audiocall = 4
		}
		public enum EHudPhoneVisibility
		{
			Invisible = 0,
			Showing = 1,
			Visible = 2,
			Hiding = 3
		}
		public enum EIndustrialArmAnimations
		{
			Idle = 0,
			RepairLoop = 1,
			RepairLoop2 = 2,
			RepairLoopBroken = 3,
			RepairLoopBelow = 4,
			RepairLoopBelowBroken = 5,
			CarDestroy = 6,
			Repair_below_loop_high = 7,
			Repair_below_loop_low = 8,
			Repair_below_loop_medium = 9,
			Repair_loop_high = 10
		}
		public enum EInitReactionAnim
		{
			Shock = 0,
			Fear = 1,
			Curious = 2,
			Call = 3
		}
		public enum EInkAnimationPlaybackOption
		{
			PLAY = 0,
			STOP = 1,
			PAUSE = 2,
			RESUME = 3,
			CONTINUE = 4,
			GO_TO_START = 5,
			GO_TO_END = 6
		}
		public enum EInputAction
		{
			IACT_None = 0,
			IACT_Press = 1,
			IACT_Release = 2,
			IACT_Axis = 3
		}
		public enum EInputCustomKey
		{
			ICK_Pad_DigitLeftRight = 262,
			ICK_Pad_DigitUpDown = 263,
			ICK_Count = 264
		}
		public enum EInputKey
		{
			IK_None = 0,
			IK_LeftMouse = 1,
			IK_RightMouse = 2,
			IK_MiddleMouse = 3,
			IK_Unknown04 = 4,
			IK_Unknown05 = 5,
			IK_Unknown06 = 6,
			IK_Unknown07 = 7,
			IK_Backspace = 8,
			IK_Tab = 9,
			IK_Unknown0A = 10,
			IK_Unknown0B = 11,
			IK_Unknown0C = 12,
			IK_Enter = 13,
			IK_Unknown0E = 14,
			IK_Unknown0F = 15,
			IK_Shift = 16,
			IK_Ctrl = 17,
			IK_Alt = 18,
			IK_Pause = 19,
			IK_CapsLock = 20,
			IK_Unknown15 = 21,
			IK_Unknown16 = 22,
			IK_Unknown17 = 23,
			IK_Unknown18 = 24,
			IK_Unknown19 = 25,
			IK_Unknown1A = 26,
			IK_Escape = 27,
			IK_Unknown1C = 28,
			IK_Unknown1D = 29,
			IK_Unknown1E = 30,
			IK_Unknown1F = 31,
			IK_Space = 32,
			IK_PageUp = 33,
			IK_PageDown = 34,
			IK_End = 35,
			IK_Home = 36,
			IK_Left = 37,
			IK_Up = 38,
			IK_Right = 39,
			IK_Down = 40,
			IK_Select = 41,
			IK_Print = 42,
			IK_Execute = 43,
			IK_PrintScrn = 44,
			IK_Insert = 45,
			IK_Delete = 46,
			IK_Help = 47,
			IK_0 = 48,
			IK_1 = 49,
			IK_2 = 50,
			IK_3 = 51,
			IK_4 = 52,
			IK_5 = 53,
			IK_6 = 54,
			IK_7 = 55,
			IK_8 = 56,
			IK_9 = 57,
			IK_Unknown3A = 58,
			IK_Unknown3B = 59,
			IK_Unknown3C = 60,
			IK_Unknown3D = 61,
			IK_Unknown3E = 62,
			IK_Unknown3F = 63,
			IK_Unknown40 = 64,
			IK_A = 65,
			IK_B = 66,
			IK_C = 67,
			IK_D = 68,
			IK_E = 69,
			IK_F = 70,
			IK_G = 71,
			IK_H = 72,
			IK_I = 73,
			IK_J = 74,
			IK_K = 75,
			IK_L = 76,
			IK_M = 77,
			IK_N = 78,
			IK_O = 79,
			IK_P = 80,
			IK_Q = 81,
			IK_R = 82,
			IK_S = 83,
			IK_T = 84,
			IK_U = 85,
			IK_V = 86,
			IK_W = 87,
			IK_X = 88,
			IK_Y = 89,
			IK_Z = 90,
			IK_Unknown5B = 91,
			IK_Unknown5C = 92,
			IK_Unknown5D = 93,
			IK_Unknown5E = 94,
			IK_Unknown5F = 95,
			IK_NumPad0 = 96,
			IK_NumPad1 = 97,
			IK_NumPad2 = 98,
			IK_NumPad3 = 99,
			IK_NumPad4 = 100,
			IK_NumPad5 = 101,
			IK_NumPad6 = 102,
			IK_NumPad7 = 103,
			IK_NumPad8 = 104,
			IK_NumPad9 = 105,
			IK_NumStar = 106,
			IK_NumPlus = 107,
			IK_Separator = 108,
			IK_NumMinus = 109,
			IK_NumPeriod = 110,
			IK_NumSlash = 111,
			IK_F1 = 112,
			IK_F2 = 113,
			IK_F3 = 114,
			IK_F4 = 115,
			IK_F5 = 116,
			IK_F6 = 117,
			IK_F7 = 118,
			IK_F8 = 119,
			IK_F9 = 120,
			IK_F10 = 121,
			IK_F11 = 122,
			IK_F12 = 123,
			IK_F13 = 124,
			IK_F14 = 125,
			IK_F15 = 126,
			IK_F16 = 127,
			IK_F17 = 128,
			IK_F18 = 129,
			IK_F19 = 130,
			IK_F20 = 131,
			IK_F21 = 132,
			IK_F22 = 133,
			IK_F23 = 134,
			IK_F24 = 135,
			IK_Pad_A_CROSS = 136,
			IK_Pad_First = 136,
			IK_Pad_B_CIRCLE = 137,
			IK_Pad_X_SQUARE = 138,
			IK_Pad_Y_TRIANGLE = 139,
			IK_Pad_Start = 140,
			IK_Pad_Back_Select = 141,
			IK_Pad_DigitUp = 142,
			IK_Pad_DigitDown = 143,
			IK_Pad_DigitLeft = 144,
			IK_Pad_DigitRight = 145,
			IK_Pad_LeftThumb = 146,
			IK_Pad_RightThumb = 147,
			IK_Pad_LeftShoulder = 148,
			IK_Pad_RightShoulder = 149,
			IK_Pad_LeftTrigger = 150,
			IK_Pad_RightTrigger = 151,
			IK_Pad_LeftAxisX = 152,
			IK_Pad_LeftAxisY = 153,
			IK_Pad_RightAxisX = 154,
			IK_Pad_RightAxisY = 155,
			IK_Pad_Last = 155,
			IK_NumLock = 156,
			IK_ScrollLock = 157,
			IK_Unknown9E = 158,
			IK_Unknown9F = 159,
			IK_LShift = 160,
			IK_RShift = 161,
			IK_LControl = 162,
			IK_RControl = 163,
			IK_UnknownA4 = 164,
			IK_UnknownA5 = 165,
			IK_UnknownA6 = 166,
			IK_UnknownA7 = 167,
			IK_UnknownA8 = 168,
			IK_UnknownA9 = 169,
			IK_UnknownAA = 170,
			IK_UnknownAB = 171,
			IK_UnknownAC = 172,
			IK_UnknownAD = 173,
			IK_UnknownAE = 174,
			IK_UnknownAF = 175,
			IK_UnknownB0 = 176,
			IK_UnknownB1 = 177,
			IK_UnknownB2 = 178,
			IK_UnknownB3 = 179,
			IK_UnknownB4 = 180,
			IK_UnknownB5 = 181,
			IK_UnknownB6 = 182,
			IK_UnknownB7 = 183,
			IK_UnknownB8 = 184,
			IK_Unicode = 185,
			IK_Semicolon = 186,
			IK_Equals = 187,
			IK_Comma = 188,
			IK_Minus = 189,
			IK_Period = 190,
			IK_Slash = 191,
			IK_Tilde = 192,
			IK_Mouse4 = 193,
			IK_Mouse5 = 194,
			IK_Mouse6 = 195,
			IK_Mouse7 = 196,
			IK_Mouse8 = 197,
			IK_UnknownC6 = 198,
			IK_UnknownC7 = 199,
			IK_Joy1 = 200,
			IK_Joy2 = 201,
			IK_Joy3 = 202,
			IK_Joy4 = 203,
			IK_Joy5 = 204,
			IK_Joy6 = 205,
			IK_Joy7 = 206,
			IK_Joy8 = 207,
			IK_Joy9 = 208,
			IK_Joy10 = 209,
			IK_Joy11 = 210,
			IK_Joy12 = 211,
			IK_Joy13 = 212,
			IK_Joy14 = 213,
			IK_Joy15 = 214,
			IK_Joy16 = 215,
			IK_UnknownD8 = 216,
			IK_UnknownD9 = 217,
			IK_UnknownDA = 218,
			IK_LeftBracket = 219,
			IK_Backslash = 220,
			IK_RightBracket = 221,
			IK_SingleQuote = 222,
			IK_UnknownDF = 223,
			IK_UnknownE0 = 224,
			IK_UnknownE1 = 225,
			IK_UnknownE2 = 226,
			IK_MouseHover = 227,
			IK_MouseX = 228,
			IK_MouseY = 229,
			IK_MouseZ = 230,
			IK_MouseW = 231,
			IK_JoyU = 232,
			IK_JoyV = 233,
			IK_JoySlider1 = 234,
			IK_JoySlider2 = 235,
			IK_MouseWheelUp = 236,
			IK_MouseWheelDown = 237,
			IK_UnknownEE = 238,
			IK_UnknownEF = 239,
			IK_JoyX = 240,
			IK_JoyY = 241,
			IK_JoyZ = 242,
			IK_JoyR = 243,
			IK_UnknownF4 = 244,
			IK_UnknownF5 = 245,
			IK_Attn = 246,
			IK_ClearSel = 247,
			IK_ExSel = 248,
			IK_ErEof = 249,
			IK_Play = 250,
			IK_Zoom = 251,
			IK_NoName = 252,
			IK_UnknownFD = 253,
			IK_UnknownFE = 254,
			IK_PS4_OPTIONS = 255,
			IK_PS4_TOUCH_PRESS = 256,
			IK_Pad_Fake_LeftAxis = 257,
			IK_Pad_Fake_RightAxis = 258,
			IK_Pad_Fake_RelativeLeftAxis = 259,
			IK_Last = 260,
			IK_Count = 261
		}
		public enum EInventoryComboBoxMode
		{
			FromInventory = 0,
			FromEquipment = 1,
			CustomizeFromEquipment = 2,
			CustomizeFromInventory = 3,
			CustomizeCyberware = 4
		}
		public enum EInventoryDataStatDisplayType
		{
			CompareBar = 0,
			DisplayBar = 1,
			Value = 2
		}
		public enum EItemOperationType
		{
			ADD = 0,
			REMOVE = 1
		}
		public enum EItemSlotCheckType
		{
			NONE = -1,
			TAG = 0,
			TYPE = 1,
			CATEGORY = 2,
			EVOLUTION = 3,
			FULLY_MODDED = 4
		}
		public enum EJuryrigTrapState
		{
			UNARMED = 0,
			ARMED = 1,
			TRIGGERED = 2
		}
		public enum EKnockdownStates
		{
			Invalid = 0,
			Start = 1,
			FallLoop = 2,
			Land = 3,
			Recovery = 4,
			AirRecovery = 5
		}
		public enum ELastUsed
		{
			Weapon = 0,
			Melee = 1,
			Ranged = 2,
			Heavy = 3
		}
		public enum ELauncherActionType
		{
			QuickAction = 0,
			ChargeAction = 1,
			None = 2
		}
		public enum ELaunchMode
		{
			Primary = 0,
			Secondary = 1,
			None = 2
		}
		public enum ELayoutType
		{
			Generic = 0,
			Militech = 1,
			Arasaka = 2,
			Zetatech = 3
		}
		public enum ELightSequenceStage
		{
			NONE = 0,
			INPROGRESS = 1,
			COMPLETE = 2
		}
		public enum ELightShadowCastingMode
		{
			LSCM_None = 0,
			LSCM_Normal = 1,
			LSCM_OnlyDynamic = 2,
			LSCM_OnlyStatic = 3,
			LSCM_NormalAndContact = 4,
			LSCM_OnlyContact = 5
		}
		public enum ELightShadowSoftnessMode
		{
			LSSM_ExtraSoft = 0,
			LSSM_Soft = 1,
			LSSM_Default = 2,
			LSSM_Sharp = 3,
			LSSM_ExtraSharp = 4
		}
		public enum ELightSwitchRandomizerType
		{
			RANDOM = 0,
			RANDOM_PROGRESSIVE = 1,
			NONE = 2
		}
		public enum ELightType
		{
			LT_Point = 0,
			LT_Spot = 1,
			LT_Area = 2
		}
		public enum ELightUnit
		{
			LU_Lumen = 0,
			LU_Watt = 1,
			LU_Lux = 2,
			LU_Nit = 3,
			LU_EV100 = 4
		}
		public enum ELinkType
		{
			NETWORK = 0,
			GRID = 1,
			FREE = 2,
			INVALID = 3
		}
		public enum ELogicOperator
		{
			OR = 0,
			AND = 1
		}
		public enum ELogType
		{
			DEFAULT = 0,
			WARNING = 1,
			ERROR = 2
		}
		public enum EMagazineAmmoState
		{
			None = 0,
			FirstBullet = 1,
			LastBullet = 2
		}
		public enum EMappinDisplayMode
		{
			PLAYSTYLE = 0,
			ROLE = 1,
			MINIMALISTIC = 2
		}
		public enum EMappinVisualState
		{
			Default = 0,
			Available = 1,
			Unavailable = 2,
			Inactive = 3
		}
		public enum EMaterialModifier
		{
			EMATMOD_HitProxy = 0,
			EMATMOD_WindData = 1,
			EMATMOD_ParticleParams = 2,
			EMATMOD_RemoteCamera = 3,
			EMATMOD_Mirror = 4,
			EMATMOD_CustomStructBuffer = 5,
			EMATMOD_EffectParams = 6,
			EMATMOD_MotionMatrix = 7,
			EMATMOD_ColorAndTexture = 8,
			EMATMOD_MaterialParams = 9,
			EMATMOD_Eye = 10,
			EMATMOD_Skin = 11,
			EMATMOD_VehicleParams = 12,
			EMATMOD_Dismemberment = 13,
			EMATMOD_Garments = 14,
			EMATMOD_ShadowsDebugParams = 15,
			EMATMOD_MultilayeredDebug = 16,
			EMATMOD_ParallaxParams = 17,
			EMATMOD_HighlightsParams = 18,
			EMATMOD_DebugColoring = 19,
			EMATMOD_DrawBufferMask = 20,
			EMATMOD_AutoSpawnData = 21,
			EMATMOD_DestructionRegions = 22,
			EMATMOD_FloatTracks = 23,
			EMATMOD_AutoHideDistance = 24,
			EMATMOD_Rain = 25,
			EMATMOD_PlanarReflections = 26,
			EMATMOD_MAX = 27
		}
		public enum EMaterialPriority
		{
			EMP_Normal = 0,
			EMP_Front = 1
		}
		public enum EMaterialShaderTarget
		{
			MSH_Invalid = 0,
			MSH_VertexShader = 1,
			MSH_PixelShader = 2,
			MSH_MAX = 3
		}
		public enum EMaterialVertexFactory
		{
			MVF_Terrain = 1,
			MVF_MeshStatic = 2,
			MVF_MeshSkinned = 3,
			MVF_MeshExtSkinned = 4,
			MVF_GarmentMeshSkinned = 5,
			MVF_GarmentMeshExtSkinned = 6,
			MVF_MeshSpeedTree = 7,
			MVF_ParticleBilboard = 8,
			MVF_ParticleParallel = 9,
			MVF_ParticleMotionBlur = 10,
			MVF_ParticleSphereAligned = 11,
			MVF_ParticleVerticalFixed = 12,
			MVF_ParticleTrail = 13,
			MVF_ParticleFacingTrail = 14,
			MVF_ParticleScreen = 15,
			MVF_ParticleBeam = 16,
			MVF_ParticleFacingBeam = 17,
			MVF_Decal = 18,
			MVF_Debug = 19,
			MVF_DrawBuffer = 20,
			MVF_Fullscreen = 21,
			MVF_MeshSkinnedVehicle = 22,
			MVF_MeshStaticVehicle = 23,
			MVF_MeshProcedural = 24,
			MVF_MeshDestructible = 25,
			MVF_MeshDestructibleSkinned = 26,
			MVF_MeshSkinnedLightBlockers = 27,
			MVF_MeshExtSkinnedLightBlockers = 28,
			MVF_GarmentMeshSkinnedLightBlockers = 29,
			MVF_GarmentMeshExtSkinnedLightBlockers = 30,
			MVF_MeshSkinnedSingleBone = 31,
			MVF_MeshProxy = 32,
			MVF_MeshWindowProxy = 33
		}
		public enum EMathOperationType
		{
			Add = 0,
			Set = 1
		}
		public enum EMathOperator
		{
			None = 0,
			Add = 1,
			Subtract = 2,
			Multiply = 3,
			Divide = 4
		}
		public enum EMeasurementSystem
		{
			Metric = 0,
			Imperial = 1
		}
		public enum EMeasurementUnit
		{
			Millimeter = 0,
			Centimeter = 1,
			Meter = 2,
			Kilometer = 3,
			Inch = 4,
			Feet = 5,
			Yard = 6,
			Mile = 7,
			NauticalMile = 8,
			SquareMillimeter = 9,
			SquareCentimeter = 10,
			SquareMeter = 11,
			Hectare = 12,
			SquareKilometer = 13,
			SquareInch = 14,
			SquareFeet = 15,
			SquareYard = 16,
			Acre = 17,
			SquareMile = 18,
			CubicCentimer = 19,
			CubicDecimeter = 20,
			CubicMeter = 21,
			Liter = 22,
			Hectoliter = 23,
			CubicInch = 24,
			CubicFeet = 25,
			FluidOunce = 26,
			Pint = 27,
			Gallon = 28,
			Gram = 29,
			Kilogram = 30,
			Tonne = 31,
			Ounce = 32,
			Pound = 33,
			Stone = 34,
			Celcius = 35,
			Fahrenheit = 36,
			MAX = 37
		}
		public enum EMeleeAttacks
		{
			Invalid = 0,
			LightAtk_Left = 1,
			LightAtk_Right = 2,
			ComboAtk_3hits_Part1 = 3,
			ComboAtk_3hits_Part2 = 4,
			ComboAtk_3hits_Part3 = 5,
			ChargeAttack = 6
		}
		public enum EMeleeAttackType
		{
			Combo = 0,
			Strong = 1,
			Final = 2,
			Block = 3,
			Safe = 4,
			Slide = 5,
			Crouch = 6,
			Jump = 7,
			Sprint = 8,
			Fall = 9,
			Throw = 10,
			Dodge = 11,
			Equip = 12
		}
		public enum EMeshParticleOrientationMode
		{
			MPOM_Normal = 0,
			MPOM_MovementDirection = 1,
			MPOM_NoRotation = 2
		}
		public enum EMeshShadowImportanceBias
		{
			MSIB_EvenLessImportant = -2,
			MSIB_LessImportant = -1,
			MSIB_Default = 0,
			MSIB_MoreImportant = 1,
			MSIB_EvenMoreImportant = 2
		}
		public enum EMeshStreamType
		{
			MST_Position_3F = 1,
			MST_SkinningIndices_4U8 = 2,
			MST_SkinningWeights_4F = 4,
			MST_Color_U32 = 8,
			MST_TexCoord0_2F = 16,
			MST_TexCoord1_2F = 32,
			MST_Normal_3F = 64,
			MST_Tangent_3F = 128,
			MST_Binormal_3F = 256,
			MST_Index_U16 = 512,
			MST_WindBranchData_4F = 1024,
			MST_BranchData_7F = 16384,
			MST_SkinningIndicesExt_4U8 = 262144,
			MST_SkinningWeightsExt_4F = 524288,
			MST_DestructionIndices_2U16 = 1048576,
			MST_Multilayer_1F = 2097152,
			MST_GarmentFlags_U32 = 4194304,
			MST_MorphOffset_3F = 8388608,
			MST_VehicleDmgNormalFront_3F = 16777216,
			MST_VehicleDmgNormalSides_3F = 33554432,
			MST_VehicleDmgPosFront_3F = 67108864,
			MST_VehicleDmgPosSides_3F = 134217728,
			MST_MorphVertexData_3F = 268435456,
			MST_FoliageBoneId_I16 = 536870912,
			MST_LightBlockerIntensity_1F = 1073741824
		}
		public enum EMeshVertexType
		{
			MVT_StaticMesh = 0,
			MVT_ProceduralMesh = 1,
			MVT_SkinnedMesh = 2,
			MVT_ExtSkinnedMesh = 3,
			MVT_GarmentSkinnedMesh = 4,
			MVT_ExtGarmentSkinnedMesh = 5,
			MVT_SpeedTreeMesh = 6,
			MVT_StaticMeshVehicle = 7,
			MVT_SkinnedMeshVehicle = 8,
			MVT_Terrain = 9,
			MVT_DestructibleMesh = 10,
			MVT_DestructibleMeshSkinned = 11,
			MVT_SkinnedMeshLightBlocker = 12,
			MVT_ExtSkinnedMeshLightBlocker = 13,
			MVT_GarmentSkinnedMeshLightBlocker = 14,
			MVT_ExtGarmentSkinnedMeshLightBlocker = 15,
			MVT_SkinnedMeshSingleBone = 16,
			MVT_ProxyMesh = 17,
			MVT_ProxyWindowMesh = 18
		}
		public enum EMissileRainPhase
		{
			Init = 0,
			Phase1 = 1,
			Phase2 = 2
		}
		public enum EMoveAssistLevel
		{
			Off = 0,
			SpecialAttacks = 1,
			AllAttacks = 2
		}
		public enum EMovementDirection
		{
			left = 0,
			right = 1,
			up = 2,
			down = 3,
			front = 4,
			back = 5
		}
		public enum ENetworkRelation
		{
			MASTER = 0,
			SLAVE = 1,
			NONE = 2
		}
		public enum ENeutralizeType
		{
			None = 0,
			Killed = 1,
			Defeated = 2,
			Unconscious = 3
		}
		public enum ENoiseType
		{
			NT_Random = 0,
			NT_Simplex2D = 1,
			NT_Simplex3D = 2
		}
		public enum ENPCPhaseState
		{
			Phase1 = 0,
			Phase2 = 1,
			Phase3 = 2,
			Phase4 = 3,
			Phase5 = 4,
			Invalid = 5
		}
		public enum ENPCTelemetryData
		{
			HitByLightAttack = 0,
			HitByStrongAttack = 1,
			HitByFinalComboAttack = 2,
			HitByBlockAttack = 3,
			BlockedAttack = 4,
			DeflectedAttack = 5,
			WasGuardBreaked = 6
		}
		public enum entAnimParamSlotFunction
		{
			RenderingPlane = 0,
			Visibility = 1
		}
		public enum entAppearanceStatus
		{
			None = 0,
			Proxy = 1,
			Appearance = 2
		}
		public enum entAttachmentTarget
		{
			Transform = 0,
			TargetPosition = 1
		}
		public enum entAudioDismembermentPart
		{
			Head = 0,
			Leg = 1,
			Arm = 2
		}
		public enum entColliderComponentSimulationType
		{
			Kinematic = 0,
			Dynamic = 1
		}
		public enum entDebug_ShapeType
		{
			Sphere = 0,
			Box = 1,
			Capsule = 2,
			Cylinder = 3
		}
		public enum entdismembermentResourceSetE
		{
			BARE = 0,
			BARE1 = 1,
			BARE2 = 2,
			BARE3 = 3,
			GARMENT = 4,
			GARMENT1 = 5,
			GARMENT2 = 6,
			GARMENT3 = 7,
			CYBER = 8,
			CYBER1 = 9,
			CYBER2 = 10,
			CYBER3 = 11,
			MIXED = 12,
			MIXED1 = 13,
			MIXED2 = 14,
			MIXED3 = 15,
			NONE = 16
		}
		public enum entdismembermentSimulationTypeE
		{
			NONE = 0,
			DANGLE = 128
		}
		public enum entEBindingDirection
		{
			BindToSource = 0,
			BindToDestination = 1
		}
		public enum entEntitySpawnPriority
		{
			Background = 0,
			Normal = 1,
			Immediate = 2,
			Paramount = 3,
			Critical = 4
		}
		public enum entEntityUserComponentResolutionMode
		{
			Select = 0,
			Suppress = 1
		}
		public enum EntityNotificationType
		{
			DoNotNotifyEntity = 0,
			SendThisEventToEntity = 1,
			SendPSChangedEventToEntity = 2
		}
		public enum entMeshComponentLODMode
		{
			AlwaysVisible = 0,
			Appearance = 1,
			AppearanceProxy = 2
		}
		public enum entragdollActivationRequestType
		{
			Default = 0,
			Animated = 1,
			Forced = 2
		}
		public enum entRenderToTextureMode
		{
			Shaded = 0,
			GBufferOnly = 1
		}
		public enum entRepellingShape
		{
			Sphere = 0,
			Capsule = 1
		}
		public enum entRepellingType
		{
			Debris = 0,
			BigObjects = 1,
			WindImpulse = 2
		}
		public enum entTemplateComponentResolveMode
		{
			AutoSelect = 0,
			Select = 1,
			Suppress = 2
		}
		public enum entVertexAnimationMapperSourceType
		{
			FloatTrack = 0,
			TranslationX = 1,
			TranslationY = 2,
			TranslationZ = 3,
			RotationQuatX = 4,
			RotationQuatY = 5,
			RotationQuatZ = 6,
			RotationQuatW = 7
		}
		public enum entVisibilityParamSource
		{
			PhantomEntitySystem = 7
		}
		public enum entVisualControllerComponentForcedLodDistance
		{
			Default = 0,
			Background = 1,
			Regular = 2,
			Cinematic = 3,
			Vehicle = 4,
			CinematicVehicle = 5
		}
		public enum envUtilsNeighborMode
		{
			eCLOSEST = 0,
			eONLY_GLOBAL = 1,
			eONLY_SELF = 2,
			eFILL_SURROUNDING = 3
		}
		public enum envUtilsReflectionProbeAmbientContributionMode
		{
			eNO_AMBIENT_CONTRIBUTION = 0,
			eALLOW_AMBIENT_CONTRIBUTION = 1,
			eOVERRIDE_GI_AMBIENT = 2
		}
		public enum EOperationClassType
		{
			Local = 0,
			BaseState = 1,
			DoorState = 2,
			BaseAction = 3,
			CustomActions = 4,
			TriggerVolume = 5,
			Hit = 6,
			InteractionArea = 7,
			Senses = 8,
			FocusMode = 9
		}
		public enum EOutlineType
		{
			NONE = 0,
			GREEN = 1,
			RED = 2
		}
		public enum EParticleEventSpawnObject
		{
			PESO_Particle = 0,
			PESO_Decal = 1
		}
		public enum EParticleEventType
		{
			PET_Death = 0,
			PET_OverLife = 1,
			PET_OverDistance = 2,
			PET_Collision = 3,
			PET_Any = 4
		}
		public enum EPaymentSchedule
		{
			WEEKLY = 0,
			MONTHLY = 1
		}
		public enum EPermissionSource
		{
			GAMEPLAY = 0,
			PLAYER = 1,
			QUEST = 2
		}
		public enum EPersonalLinkConnectionStatus
		{
			NOT_CONNECTED = 0,
			CONNECTING = 1,
			CONNECTED = 2
		}
		public enum EPersonalLinkSlotSide
		{
			FRONT = 0,
			RIGHT = 1,
			BOTTOM = 2
		}
		public enum EPingType
		{
			DIRECT = 0,
			SPACE = 1
		}
		public enum EPlayerMovementDirection
		{
			Forward = 0,
			Right = 1,
			Back = 2,
			Left = 3
		}
		public enum EPlaystyle
		{
			NETRUNNER = 0,
			SOLO = 1,
			TECHIE = 2
		}
		public enum EPlaystyleType
		{
			NONE = -1,
			TECHIE = 0,
			NETRUNNER = 1,
			TECHIE_AND_NETRUNNER = 2
		}
		public enum EPowerDifferential
		{
			IMPOSSIBLE = -6,
			HARD = -3,
			NORMAL = 2,
			EASY = 4,
			TRASH = 5
		}
		public enum EPreventionDebugProcessReason
		{
			Redirected_IsPsycho = 0,
			Process_NewDamage = 1,
			Process_EntityCalls = 2,
			Abort_EntitySame = 3,
			Abort_DamageZero = 4,
			Abort_SystemLockedBySceneTier = 5
		}
		public enum EPreventionHeatStage
		{
			Heat_0 = 0,
			Heat_1 = 1,
			Heat_2 = 2,
			Heat_3 = 3,
			Heat_4 = 4,
			Size = 5
		}
		public enum EPreventionPsychoLogicType
		{
			Start = 0,
			PoliceKilled = 1,
			PoliceSpawn = 2,
			PoliceDespawn = 3,
			DeescalationZeroExecutionLocked = 4,
			DeescalationZeroExecute = 5
		}
		public enum EPreventionSystemInstruction
		{
			Safe = 0,
			Active = 1,
			Off = 2,
			On = 3
		}
		public enum EPriority
		{
			VeryLow = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			VeryHigh = 4,
			Absolute = 5
		}
		public enum EProgressBarContext
		{
			QuickHack = 0,
			PhoneCall = 1
		}
		public enum EProgressBarType
		{
			UPLOAD = 0,
			DURATION = 1
		}
		public enum EQuestFilterType
		{
			DONT_CHANGE = 0,
			ALLOW_NONE = 1,
			ALLOW_COMBAT_ONLY = 2,
			ALLOW_ALL = 3
		}
		public enum EquipmentManipulationAction
		{
			Undefined = 0,
			RequestActiveMeleeware = 1,
			RequestActiveWeapon = 2,
			RequestSlotActiveWeapon = 3,
			RequestLastUsedWeapon = 4,
			RequestFirstMeleeWeapon = 5,
			RequestLastUsedMeleeWeapon = 6,
			RequestLastUsedOrFirstAvailableWeapon = 7,
			RequestLastUsedOrFirstAvailableRangedWeapon = 8,
			RequestLastUsedOrFirstAvailableMeleeWeapon = 9,
			RequestLastUsedOrFirstAvailableOneHandedRangedWeapon = 10,
			RequestHeavyWeapon = 11,
			CycleWeaponWheelItem = 12,
			CycleNextWeaponWheelItem = 13,
			CyclePreviousWeaponWheelItem = 14,
			RequestConsumable = 15,
			RequestGadget = 16,
			RequestFists = 17,
			RequestLeftHandCyberware = 18,
			UnequipWeapon = 19,
			UnequipConsumable = 20,
			UnequipGadget = 21,
			UnequipLeftHandCyberware = 22,
			UnequipAll = 23,
			ReequipWeapon = 24,
			RequestWeaponSlot1 = 25,
			RequestWeaponSlot2 = 26,
			RequestWeaponSlot3 = 27,
			RequestWeaponSlot4 = 28
		}
		public enum EquipmentManipulationRequestSlot
		{
			Undefined = 0,
			Right = 1,
			Left = 2,
			Both = 3
		}
		public enum EquipmentManipulationRequestType
		{
			Undefined = 0,
			Equip = 1,
			Unequip = 2
		}
		public enum EquipmentPriority
		{
			Primary = 0,
			Secondary = 1,
			All = 2
		}
		public enum ERadialMode
		{
			ApplyOnlyActiveSlot = 0,
			ApplyActiveSlotAndConsumables = 1
		}
		public enum ERadioStationList
		{
			AGGRO_INDUSTRIAL = 0,
			ELECTRO_INDUSTRIAL = 1,
			HIP_HOP = 2,
			AGGRO_TECHNO = 3,
			DOWNTEMPO = 4,
			ATTITUDE_ROCK = 5,
			POP = 6,
			LATINO = 7,
			METAL = 8,
			NONE = 9
		}
		public enum EReactionValue
		{
			Fear = 0,
			Aggressive = 1
		}
		public enum ERenderDynamicDecalAtlas
		{
			RDDA_1x1 = 0,
			RDDA_2x1 = 1,
			RDDA_2x2 = 2,
			RDDA_4x2 = 3,
			RDDA_4x4 = 4,
			RDDA_8x4 = 5
		}
		public enum ERenderDynamicDecalProjection
		{
			RDDP_Ortho = 0,
			RDDP_Sphere = 1
		}
		public enum ERenderingMode
		{
			RM_Shaded = 0,
			RM_Shaded_NoAmbient = 1,
			RM_HitProxies = 2,
			RM_GBufferOnly = 3,
			RM_SafeMode = 4,
			RM_OverlayOnly = 5
		}
		public enum ERenderingPlane
		{
			RPl_Scene = 0,
			RPl_Background = 1,
			RPl_Weapon = 2
		}
		public enum ERenderMaterialType
		{
			RMT_Standard = 0,
			RMT_Subsurface = 1,
			RMT_Cloth = 2,
			RMT_Eye = 3,
			RMT_Hair = 4,
			RMT_Foliage = 5
		}
		public enum ERenderMeshStreams
		{
			RMS_PositionSkinning = 1,
			RMS_TexCoords = 2,
			RMS_TangentFrame = 4,
			RMS_Extended = 8,
			RMS_Custom0 = 16,
			RMS_BindAll = 255
		}
		public enum ERenderObjectType
		{
			ROT_Static = 0,
			ROT_Terrain = 1,
			ROT_Road = 2,
			ROT_CustomCharacter1 = 12,
			ROT_CustomCharacter2 = 13,
			ROT_CustomCharacter3 = 14,
			ROT_MainPlayer = 15,
			ROT_NoAO = 16,
			ROT_NoLighting = 17,
			ROT_NoTXAA = 18,
			ROT_Skinned = 20,
			ROT_Character = 21,
			ROT_Foliage = 22,
			ROT_Grass = 23,
			ROT_Vehicle = 24,
			ROT_Weapon = 25,
			ROT_Particle = 26,
			ROT_Enemy = 27
		}
		public enum ERentStatus
		{
			PAID = 0,
			OVERDUE = 1,
			EVICTED = 2
		}
		public enum EReprimandInstructions
		{
			INITIATE_FIRST = 0,
			INITIATE_SUCCESSIVE = 1,
			TAKEOVER = 2,
			CONCLUDE_SUCCESSFUL = 3,
			CONCLUDE_FAILED = 4,
			RELEASE_TO_ANOTHER_ENTITY = 5
		}
		public enum ERevealDurationType
		{
			TEMPORARY = 0,
			PERMANENT = 1
		}
		public enum ERevealPlayerType
		{
			DONT_REVEAL = 0,
			REVEAL_ONCE = 1
		}
		public enum ERevealState
		{
			STARTED = 0,
			CONTINUE = 1,
			STOPPED = 2
		}
		public enum ESaveFormat
		{
			SF_PNG = 2,
			SF_EXR = 32,
			SF_PNG_AND_EXR = 34
		}
		public enum EScreenRatio
		{
			Screen_21x9 = 0,
			Screen_9x21 = 1,
			Screen_9x16 = 2,
			Screen_3x4 = 3,
			Screen_4x3 = 4,
			Screen_1x1 = 5
		}
		public enum ESecurityAccessLevel
		{
			ESL_NONE = 0,
			ESL_LOCAL = 1,
			ESL_0 = 2,
			ESL_1 = 3,
			ESL_2 = 4,
			ESL_3 = 5,
			ESL_4 = 6
		}
		public enum ESecurityAreaType
		{
			DISABLED = 0,
			SAFE = 1,
			RESTRICTED = 2,
			DANGEROUS = 3
		}
		public enum ESecurityGateEntranceType
		{
			OnlySideA = 0,
			OnlySideB = 1,
			AnySide = 2
		}
		public enum ESecurityGateResponseType
		{
			AUDIOVISUAL_ONLY = 0,
			SEC_SYS_REPRIMAND = 1,
			SEC_SYS_COMBAT = 2
		}
		public enum ESecurityGateScannerIssueType
		{
			NoIssues = 0,
			ScannerEmpty = 1,
			Overcrowded = 2,
			TargetAlreadyScanned = 3
		}
		public enum ESecurityGateStatus
		{
			READY = 0,
			SCANNING = 1,
			THREAT_DETECTED = 2
		}
		public enum ESecurityNotificationType
		{
			REPRIMAND_SUCCESSFUL = -2,
			DEESCALATE = -1,
			DEFAULT = 0,
			ILLEGAL_ACTION = 1,
			REPRIMAND_ESCALATE = 2,
			DEVICE_DESTROYED = 3,
			ALARM = 4,
			SECURITY_GATE = 5,
			COMBAT = 6,
			QUEST = 7
		}
		public enum ESecuritySystemState
		{
			UNINITIALIZED = 0,
			SAFE = 1,
			ALERTED = 2,
			COMBAT = 3
		}
		public enum ESecurityTurretStatus
		{
			THREAT = -1,
			SHOOTING = 0,
			WORKING = 1,
			SCANING = 2,
			DAMAGED = 3
		}
		public enum ESecurityTurretType
		{
			SIMPLE = 0
		}
		public enum ESensorDeviceStates
		{
			NONE = 0,
			IDLE = 1,
			IDLEFORCED = 2,
			TARGETLOCK = 3,
			TARGETLOSE = 4,
			TARGETRECEIVED = 5,
			REPRIMAND = 6,
			JAMMER = 7
		}
		public enum ESensorDeviceWakeState
		{
			NONE = -1,
			CLOSED = 0,
			WAKEN = 1,
			OPEN = 2
		}
		public enum EShouldChangeAttitude
		{
			PERSISTENTLY = 0,
			TEMPORARLY = 1
		}
		public enum ESmartBulletPhase
		{
			Init = 0,
			Parabolic = 1,
			Follow = 2,
			Linear = 3,
			Miss = 4
		}
		public enum ESmartHousePreset
		{
			MorningPreset = 0,
			EveningPreset = 1,
			NightPreset = 2
		}
		public enum ESoundStatusEffects
		{
			NONE = 0,
			DEAFENED = 1,
			SUPRESS_NOISE = 2
		}
		public enum ESpaceFillMode
		{
			JustifyLeft = 0,
			JustifyRight = 1,
			JustifyCenter = 2
		}
		public enum ESSAOQualityLevel
		{
			SSAOQUALITY_VeryLow = 0,
			SSAOQUALITY_Low = 1,
			SSAOQUALITY_Medium = 2,
			SSAOQUALITY_High = 3,
			SSAOQUALITY_VeryHigh = 4
		}
		public enum EStatusEffectBehaviorType
		{
			Invalid = 0,
			Basic = 1,
			Stoppable = 2,
			Unstoppable = 3
		}
		public enum EStatusEffects
		{
			Invalid = 0,
			WeaponJammed = 1,
			Blind = 2,
			SmokeScreen = 3,
			Unconscious = 4,
			Burning = 5,
			Stun = 6,
			HeartAttack = 7,
			SuicideWithWeapon = 8,
			SuicideWithGrenade = 9,
			Wounded = 10,
			MonowireGrapple = 11,
			Exhausted = 12,
			Defeated = 13,
			Sleep = 14,
			Berserker = 15,
			Pain = 16,
			Sandevistan = 17,
			NetwatcherHackStage1 = 18,
			NetwatcherHackStage2 = 19,
			NetwatcherHackStage3 = 20,
			Count = 21
		}
		public enum EstatusEffectsState
		{
			Deactivated = 0,
			Activating = 1,
			Activated = 2
		}
		public enum ESurveillanceCameraState
		{
			Off = 0,
			Active = 1
		}
		public enum ESurveillanceCameraStatus
		{
			THREAT = -1,
			STREAMING = 0,
			WORKING = 1
		}
		public enum ESwitchAction
		{
			ToggleOn = 0,
			ToggleActivate = 1
		}
		public enum ESystemNotificationTypes
		{
			DiscOperationIndicator = 0,
			GenericNotModal = 1,
			GenericMenuInfo = 2,
			GenericYesNo = 3,
			Generic = 4,
			ExitGame = 5,
			StartNewGame = 6,
			NoDiscSpace = 7,
			OverwriteSaveFile = 8,
			LoadSaveFileInGame = 9,
			LoadSaveFile = 10,
			DeleteSaveFile = 11,
			CorruptedSaveFile = 12,
			NoPlayerProfile = 13,
			GameSaved = 14,
			SaveFailed = 15,
			UnavailableForGuest = 16,
			EnableTelemetry = 17,
			PointOfNoReturn = 18,
			PointOfNoReturnWithReward = 19,
			PointOfNoReturnLootAdded = 20,
			GenericMenuError = 21,
			ControllerReconnected = 22,
			FirstModalHighPriority = 22,
			ControllerDisconnected = 23,
			MAX = 24
		}
		public enum ESystems
		{
			NONE = 0,
			SecuritySystem = 1,
			AccessPoints = 2,
			MaintenanceSystem = 3,
			PersonnelSystem = 4,
			SurveillanceSystem = 5
		}
		public enum ETakedownActionType
		{
			GrappleFailed = 0,
			Grapple = 1,
			Takedown = 2,
			TakedownNonLethal = 3,
			TakedownNetrunner = 4,
			TakedownMassiveTarget = 5,
			AerialTakedown = 6,
			LeapToTarget = 7,
			Struggle = 8,
			BreakFree = 9,
			TargetDead = 10,
			KillTarget = 11,
			SpareTarget = 12,
			ForceShove = 13,
			BossTakedown = 14,
			DisposalTakedown = 15,
			DisposalTakedownNonLethal = 16,
			None = 17
		}
		public enum ETakedownBossName
		{
			Smasher = 0,
			Oda = 1,
			Royce = 2,
			Sasquatch = 3,
			None = 4
		}
		public enum ETargetManagerAnimGraphState
		{
			MODELOOKAT = 0,
			IDLE = 1,
			JAMMED = 2
		}
		public enum ETauntType
		{
			Normal = 0,
			Melee = 1,
			Ranged = 2
		}
		public enum ETelemetryData
		{
			MeleeAttacksMade = 0,
			RangedAttacksMade = 1,
			BluelinesSelected = 2,
			MeleeKills = 3,
			RangedKills = 4,
			QuickHacksMade = 5,
			LegendaryItemsCrafted = 6
		}
		public enum ETextureAddressing
		{
			TA_Wrap = 0,
			TA_Mirror = 1,
			TA_Clamp = 2,
			TA_MirrorOnce = 3,
			TA_Border = 4
		}
		public enum ETextureAnimationMode
		{
			TAM_Speed = 0,
			TAM_LifeTime = 1
		}
		public enum ETextureComparisonFunction
		{
			TCF_None = 0,
			TCF_Less = 1,
			TCF_Equal = 2,
			TCF_LessEqual = 3,
			TCF_Greater = 4,
			TCF_NotEqual = 5,
			TCF_GreaterEqual = 6,
			TCF_Always = 7
		}
		public enum ETextureFilteringMag
		{
			TFMag_Point = 0,
			TFMag_Linear = 1
		}
		public enum ETextureFilteringMin
		{
			TFMin_Point = 0,
			TFMin_Linear = 1,
			TFMin_Anisotropic = 2,
			TFMin_AnisotropicLow = 3
		}
		public enum ETextureFilteringMip
		{
			TFMip_None = 0,
			TFMip_Point = 1,
			TFMip_Linear = 2
		}
		public enum ETimeOfYearSeason
		{
			ETOYS_Spring = 0,
			ETOYS_Summer = 1,
			ETOYS_Autumn = 2,
			ETOYS_Winter = 3
		}
		public enum EToggleActivationTypeComputer
		{
			None = 0,
			Raise = 1
		}
		public enum EToggleOperationType
		{
			ADD = 0,
			REMOVE = 1
		}
		public enum ETooltipsStyle
		{
			Menus = 0,
			HUD = 1
		}
		public enum ETransformAnimationOperationType
		{
			PLAY = 0,
			PAUSE = 1,
			RESET = 2,
			SKIP = 3
		}
		public enum ETransitionMode
		{
			GENTLE = 0,
			FORCED = 1
		}
		public enum ETransitionType
		{
			EET_Linear = 0,
			EET_Sine = 1,
			EET_Cubic = 2,
			EET_Quad = 3,
			EET_Quart = 4,
			EET_Quint = 5,
			EET_Expo = 6,
			EET_Circ = 7,
			EET_Back = 8,
			EET_Bounce = 9,
			EET_Elastic = 10
		}
		public enum ETrap
		{
			Invalid = 0,
			GridRegen = 1,
			AppendStart = 2,
			Hidden = 3,
			Virus = 4
		}
		public enum ETrapEffects
		{
			Explosion = 0,
			Poisoned = 1,
			Bleeding = 2,
			Burning = 3,
			Blind = 4,
			SmokeScreen = 5,
			Stun = 6,
			Unconcious = 7
		}
		public enum ETriggerOperationType
		{
			ENTER = 0,
			EXIT = 1
		}
		public enum ETVChannel
		{
			CH1 = 0,
			CH2 = 1,
			CH3 = 2,
			CH4 = 3,
			CH5 = 4,
			INVALID = 5
		}
		public enum ETweakAINodeType
		{
			Action = 0,
			Selector = 1,
			Sequence = 2
		}
		public enum EUIActionState
		{
			Invalid = 0,
			DEFAULT = 1,
			STARTED = 2,
			COMPLETED = 3,
			ABORTED = 4
		}
		public enum EUIStealthIconType
		{
			Invalid = 0,
			HostileHuman = 1,
			Camera = 2,
			Turret = 3,
			Drone = 4
		}
		public enum EUploadProgramState
		{
			STARTED = 0,
			COMPLETED = 1
		}
		public enum EVarDBMode
		{
			Add = 0,
			Set = 1,
			Invalid = 2
		}
		public enum EVendorMode
		{
			BuyItems = 0,
			SellItems = 1,
			Train = 2,
			Ripperdoc = 3,
			RipperdocSummary = 4
		}
		public enum EViabilityDecision
		{
			INCONCLUSIVE = 0,
			VIABLE = 1,
			NONVIABLE = 2
		}
		public enum EVirtualSystem
		{
			None = 0,
			SurveillanceSystem = 1,
			DoorSystem = 2,
			MediaSystem = 3,
			SecuritySystem = 4
		}
		public enum EWeaponNamesList
		{
			EWNL_PowerStreetRifle = 0,
			EWNL_TechStreetShotgun = 1,
			EWNL_PowerCorpHandgun = 2,
			EWNL_SmartCorpRifle = 3,
			EWNL_PowerCorpHandgunJackie = 4
		}
		public enum EWidgetPlacementType
		{
			DOCKED = 0,
			FLOATING = 1
		}
		public enum EWidgetState
		{
			DEFAULT = 0,
			ON = 1,
			OFF = 2,
			INACTIVE = 3,
			ALLOWED = 4,
			LOCKED = 5,
			SEALED = 6
		}
		public enum EWindowBlindersStates
		{
			NonInteractive = 0,
			Open = 1,
			Closed = 2,
			Tilted = 3
		}
		public enum EWorkspotOperationType
		{
			ENTER = 0,
			LEAVE = 1
		}
		public enum EWorldMapView
		{
			Map = 0,
			FloorPlan = 1,
			TimeSkip = 2
		}
		public enum EWoundedBodyPart
		{
			Invalid = 0,
			WoundedLeftArm = 1,
			WoundedRightArm = 2,
			WoundedLeftLeg = 3,
			WoundedRightLeg = 4,
			DismemberedLeftArm = 5,
			DismemberedRightArm = 6,
			DismemberedLeftLeg = 7,
			DismemberedRightLeg = 8,
			DismemberedBothLegs = 9
		}
		public enum ExplosiveTriggerDeviceLaserState
		{
			GREEN = 0,
			RED = 1,
			DISABLED = 2
		}
		public enum ExtraEffect
		{
			AccuracyVirus = 0,
			PeernoidVirus = 1,
			None = 2
		}
		public enum Ft_Result
		{
			Success = 0,
			GettingPlayerGameObjectFailed = 1,
			GetPSMBlackboardFailed = 2,
			GetStatsPoolFailed = 3,
			NoEnemyFoundInSpawner = 4,
			NoEnemyFoundInPool = 5,
			NoEntitiesFoundInSpawner = 6,
			NoEnemyTargeted = 7,
			FailedToSelectGrapple = 8,
			FailedToSelectTakedown = 9,
			TakedownWithoutGrappleAttempt = 10,
			NoInteractionAvailable = 11,
			RequestedInteractionNotAvailable = 12,
			OutOfRange = 13,
			TargetNotInEnemyPool = 14,
			DescriptorFormatError = 15
		}
		public enum Ft_TakedownStage
		{
			Default = 0,
			Grappling = 1,
			Grappled = 2,
			Takedown = 3,
			Finished = 4
		}
		public enum Ft_TakedownType
		{
			Lethal = 0,
			Nonlethal = 1,
			Breach = 2
		}
		public enum FTEntityRequirementsFlag
		{
			None = 0,
			LookAtComponent = 1,
			ScanningComponent = 2,
			DestructionComponent = 4,
			GameObject = 8,
			ScriptedPuppet = 16,
			AttitudeAgent = 32,
			Device = 64,
			VehicleObject = 128,
			GamePuppet = 256
		}
		public enum FTNpcMountingState
		{
			Mounted = 0,
			Unmounted = 1
		}
		public enum FTScriptState
		{
			ERROR = 0
		}
		public enum FunctionalTestsResultCode
		{
			Valid = 0,
			MalformedEntityDescr = 1,
			EntityNotFound = 2,
			ComponentNotFound = 3,
			InvalidEntityType = 4,
			InvalidComponentType = 5,
			InvalidNodeRef = 6,
			SlotNotFound = 7,
			InventoryError = 8,
			InvalidInputAction = 9,
			InvalidInputActionCallback = 10,
			EmptyContainer = 12
		}
		public enum gameAggregationType
		{
			AND = 0,
			OR = 1
		}
		public enum gameAIDirectorTensionEventType
		{
			Time = 0,
			Progress = 1,
			DealingDamage = 2,
			TakingDamage = 3,
			Kill = 4
		}
		public enum gameAlwaysSpawnedState
		{
			[RED("default (false)")] default__false_ = 0,
			[RED("true")] _true = 1,
			[RED("false")] _false = 2
		}
		public enum gameAppearanceSource
		{
			EntityResource = 0,
			PopulationSpawner = 1,
			CommunityEntry = 2,
			CommunityAppearancePicker = 3,
			TweakDBRecord = 4,
			VisualTag = 5,
			Invalid = 7
		}
		public enum gameaudioeventsSurfaceDirection
		{
			Normal = 0,
			WallLeft = 1,
			WallRight = 2
		}
		public enum gameBinkVideoAction
		{
			Undefined = 0,
			Start = 1,
			Stop = 2
		}
		public enum gameBoolSignalAction
		{
			None = 0,
			TurnOn = 1,
			TurnOff = 2
		}
		public enum gameCameraCurve
		{
			CentricPitchOfSpeed = 0,
			CentricVerticalOffsetOfSpeed = 1,
			BoomLengthOfSpeed = 2,
			BoomLengthOfAcc = 3,
			BoomPitchOfSpeed = 4,
			BoomPitchOfGlobalVehiclePitch = 5,
			BoomYawOfTurnCoeff = 6,
			BoomYawRotateRateOfSpeed = 7,
			FOVOfSpeed = 8,
			PivotOffsetXOfTurnCoeff = 9,
			PivotOffsetZOfTurnCoeff = 10,
			COUNT = 11
		}
		public enum gamecheatsystemFlag
		{
			God_Immortal = 1,
			God_Invulnerable = 2,
			Resurrect = 4,
			IgnoreTimeDilation = 8,
			BypassMagazine = 16,
			InfiniteAmmo = 32,
			Kill = 64,
			Invisible = 128
		}
		public enum gameCityAreaType
		{
			Undefined = 0,
			PublicZone = 1,
			SafeZone = 2,
			RestrictedZone = 3,
			DangerousZone = 4
		}
		public enum gameCombinedStatOperation
		{
			Addition = 0,
			Subtraction = 1,
			Multiplication = 2,
			Division = 3,
			Modulo = 4,
			Invert = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gameComparisonType
		{
			EQUAL = 0,
			NOT_EQUAL = 1,
			LESS = 2,
			GREATER = 3,
			LESS_OR_EQUAL = 4,
			GREATER_OR_EQUAL = 5
		}
		public enum gameContactType
		{
			Caller = 0,
			Texter = 1
		}
		public enum gameCoverHeight
		{
			Invalid = 0,
			Low = 1,
			High = 2
		}
		public enum gameCrowdCreationDataMergeMode
		{
			Average = 0,
			Override = 1
		}
		public enum gameCrowdEntryType
		{
			Pedestrian = 0,
			Vehicle = 1,
			AV = 2
		}
		public enum gameDamageCallbackType
		{
			HitTriggered = 0,
			HitReceived = 1,
			PipelineProcessed = 2,
			COUNT = 3,
			INVALID = 4
		}
		public enum gameDamageListenerPipelineType
		{
			None = 0,
			Damage = 1,
			ProjectedDamage = 2,
			All = -1
		}
		public enum gameDamagePipelineStage
		{
			PreProcess = 0,
			Process = 1,
			PostProcess = 2,
			COUNT = 3,
			INVALID = 4
		}
		public enum gamedataAchievement
		{
			Bladerunner = 0,
			BornToBeWild = 1,
			Breathtaking = 2,
			BushidoAndChill = 3,
			Cyberjunkie = 4,
			Denied = 5,
			FollowingTheRiver = 6,
			Fortuneteller = 7,
			Gearhead = 8,
			GetMeThereScottie = 9,
			GunKata = 10,
			Gunslinger = 11,
			HandyMan = 12,
			IAmMaxTac = 13,
			LikeFatherLikeSon = 14,
			LittleTokyo = 15,
			MasterRunner = 16,
			MaxPain = 17,
			MustBeTheRats = 18,
			NeverFadeAway = 19,
			NoMansLand = 20,
			NotTheMobile = 21,
			QueenOfTheHighway = 22,
			Roleplayer = 23,
			Specialist = 24,
			Temperance = 25,
			ThatIsSoHardForTheKnees = 26,
			TheDevil = 27,
			TheFool = 28,
			TheHermit = 29,
			TheHightPriestess = 30,
			TheLovers = 31,
			TheStar = 32,
			TheSun = 33,
			TheWheelOfFortune = 34,
			TheWorld = 35,
			ThisIsPacifica = 36,
			TradeUnion = 37,
			TrueSoldier = 38,
			TrueWarrior = 39,
			TwoHeadsOneBullet = 40,
			UnderPressure = 41,
			VForVendetta = 42,
			YipMan = 43,
			YouKnowWhoIAm = 44,
			Count = 45,
			Invalid = 46
		}
		public enum gamedataAffiliation
		{
			AfterlifeMercs = 0,
			Aldecaldos = 1,
			Animals = 2,
			Arasaka = 3,
			Biotechnica = 4,
			CityCouncil = 5,
			Civilian = 6,
			KangTao = 7,
			Maelstrom = 8,
			Militech = 9,
			NCPD = 10,
			NetWatch = 11,
			News54 = 12,
			RecordingAgency = 13,
			SSI = 14,
			Scavengers = 15,
			SixthStreet = 16,
			SouthCalifornia = 17,
			TheMox = 18,
			TraumaTeam = 19,
			TygerClaws = 20,
			Unaffiliated = 21,
			UnaffiliatedCorpo = 22,
			Unknown = 23,
			Valentinos = 24,
			VoodooBoys = 25,
			Wraiths = 26,
			Count = 27,
			Invalid = 28
		}
		public enum gamedataAIActionSecurityAreaType
		{
			DANGEROUS = 0,
			DISABLED = 1,
			RESTRICTED = 2,
			SAFE = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataAIActionSecurityNotificationType
		{
			COMBAT = 0,
			DEESCALATE = 1,
			DEFAULT = 2,
			ILLEGAL_ACTION = 3,
			REPRIMAND_ESCALATE = 4,
			REPRIMAND_SUCCESSFUL = 5,
			SECURITY_GATE = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataAIActionTarget
		{
			AssignedVehicle = 0,
			CombatTarget = 1,
			CommandCover = 2,
			CommandMovementDestination = 3,
			ConsideredCover = 4,
			CurrentCover = 5,
			CurrentNetrunnerProxy = 6,
			CustomWorldPosition = 7,
			DesiredCover = 8,
			FriendlyTarget = 9,
			FurthestNavigableSquadmate = 10,
			FurthestSquadmate = 11,
			FurthestThreat = 12,
			HostileOfficer = 13,
			MountedVehicle = 14,
			MovementDestination = 15,
			NearestDefeatedSquadmate = 16,
			NearestNavigableSquadmate = 17,
			NearestSquadmate = 18,
			NearestThreat = 19,
			NetrunnerProxy = 20,
			ObjectOfInterest = 21,
			Owner = 22,
			Player = 23,
			PointOfInterest = 24,
			RingBackDestination = 25,
			RingBackLeftDestination = 26,
			RingBackRightDestination = 27,
			RingFrontDestination = 28,
			RingFrontLeftDestination = 29,
			RingFrontRightDestination = 30,
			RingLeftDestination = 31,
			RingRightDestination = 32,
			SelectedCover = 33,
			SpawnPosition = 34,
			SquadOfficer = 35,
			StimSource = 36,
			StimTarget = 37,
			TargetDevice = 38,
			TargetItem = 39,
			TopFriendly = 40,
			TopThreat = 41,
			VisibleFurthestThreat = 42,
			VisibleNearestThreat = 43,
			VisibleTopThreat = 44,
			Count = 45,
			Invalid = 46
		}
		public enum gamedataAIActionType
		{
			BackUp = 0,
			BattleCry = 1,
			Block = 2,
			CallOff = 3,
			Charge = 4,
			Crouch = 5,
			Dash = 6,
			GrenadeThrow = 7,
			GroupReaction = 8,
			Investigate = 9,
			Melee = 10,
			Peek = 11,
			Quickhack = 12,
			Reprimand = 13,
			Search = 14,
			Shoot = 15,
			Sync = 16,
			TakeCover = 17,
			Takedown = 18,
			Taunt = 19,
			Count = 20,
			Invalid = 21
		}
		public enum gamedataAIAdditionalTraceType
		{
			Chest = 0,
			Hip = 1,
			Knee = 2,
			Undefined = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataAIDirectorEntryStartType
		{
			Default = 0,
			DespawnAllEnemies = 1,
			DespawnExcessedEnemies = 2,
			WaitUntilNoEnemies = 3,
			WaitUntilSameOrLessAmountOfEnemies = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataAIExposureMethodType
		{
			BlindFire = 0,
			Lean = 1,
			StepOut = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataAimAssistType
		{
			HeadTarget = 0,
			LegTarget = 1,
			MechanicalTarget = 2,
			Melee = 3,
			None = 4,
			QuickHack = 5,
			Scanning = 6,
			Shooting = 7,
			ShootingLimbCyber = 8,
			Count = 9,
			Invalid = 10
		}
		public enum gamedataAIRingType
		{
			Approach = 0,
			Close = 1,
			Default = 2,
			Defend = 3,
			Extreme = 4,
			Far = 5,
			LatestActive = 6,
			Medium = 7,
			Melee = 8,
			Support = 9,
			Undefined = 10,
			Count = 11,
			Invalid = 12
		}
		public enum gamedataAIRole
		{
			Follower = 0,
			Patrol = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataAISmartCompositeType
		{
			Selector = 0,
			SelectorWithMemory = 1,
			SelectorWithSmartMemory = 2,
			Sequence = 3,
			SequenceWithMemory = 4,
			SequenceWithSmartMemory = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataAISquadType
		{
			Attitude = 0,
			Community = 1,
			Global = 2,
			Security = 3,
			Unknown = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataAITacticType
		{
			Assault = 0,
			Defend = 1,
			Flank = 2,
			Medivac = 3,
			Panic = 4,
			Regroup = 5,
			Retreat = 6,
			Snipe = 7,
			Suppress = 8,
			Count = 9,
			Invalid = 10
		}
		public enum gamedataAITicketType
		{
			BackUp = 0,
			BattleCry = 1,
			Block = 2,
			CallOff = 3,
			CatchUp = 4,
			Charge = 5,
			CloseRing = 6,
			CloseRing1stFilter = 7,
			CloseRing2ndFilter = 8,
			Crouch = 9,
			DefaultRing = 10,
			Equip = 11,
			EquipMelee = 12,
			ExtremeRing = 13,
			ExtremeRing1stFilter = 14,
			ExtremeRing2ndFilter = 15,
			FarRing = 16,
			FarRing1stFilter = 17,
			FarRing2ndFilter = 18,
			GoToCover = 19,
			GrenadeThrow = 20,
			GroupReaction = 21,
			Investigate = 22,
			MediumRing = 23,
			MediumRing1stFilter = 24,
			MediumRing2ndFilter = 25,
			Melee = 26,
			MeleeApproach = 27,
			MeleeRing = 28,
			MeleeRing1stFilter = 29,
			MeleeRing2ndFilter = 30,
			MeleeSupport = 31,
			Peek = 32,
			QuickMelee = 33,
			Quickhack = 34,
			Reload = 35,
			Reprimand = 36,
			Search = 37,
			Shoot = 38,
			SimpleCombat = 39,
			SimpleCombatMovement = 40,
			Strafe = 41,
			StrafeEvade = 42,
			Sync = 43,
			TakeCover = 44,
			Takedown = 45,
			Taunt = 46,
			TauntBackground = 47,
			Count = 48,
			Invalid = 49
		}
		public enum gamedataArchetypeType
		{
			AndroidMeleeT1 = 0,
			AndroidMeleeT2 = 1,
			AndroidRangedT2 = 2,
			FastMeleeT2 = 3,
			FastMeleeT3 = 4,
			FastRangedT2 = 5,
			FastRangedT3 = 6,
			FastShotgunnerT2 = 7,
			FastShotgunnerT3 = 8,
			FastSniperT3 = 9,
			FriendlyGenericRangedT3 = 10,
			GenericMeleeT1 = 11,
			GenericMeleeT2 = 12,
			GenericRangedT1 = 13,
			GenericRangedT2 = 14,
			GenericRangedT3 = 15,
			HeavyMeleeT2 = 16,
			HeavyMeleeT3 = 17,
			HeavyRangedT2 = 18,
			HeavyRangedT3 = 19,
			NetrunnerT1 = 20,
			NetrunnerT2 = 21,
			NetrunnerT3 = 22,
			ShotgunnerT2 = 23,
			ShotgunnerT3 = 24,
			SniperT2 = 25,
			TechieT2 = 26,
			TechieT3 = 27,
			Count = 28,
			Invalid = 29
		}
		public enum gamedataAttackSubtype
		{
			BlockAttack = 0,
			ComboAttack = 1,
			CrouchAttack = 2,
			DeflectAttack = 3,
			EquipAttack = 4,
			FinalAttack = 5,
			JumpAttack = 6,
			SafeAttack = 7,
			SprintAttack = 8,
			ThrowAttack = 9,
			Count = 10,
			Invalid = 11
		}
		public enum gamedataAttackType
		{
			ChargedWhipAttack = 0,
			Direct = 1,
			Effect = 2,
			Explosion = 3,
			GuardBreak = 4,
			Hack = 5,
			Melee = 6,
			PressureWave = 7,
			QuickMelee = 8,
			Ranged = 9,
			Reflect = 10,
			StrongMelee = 11,
			Thrown = 12,
			WhipAttack = 13,
			Count = 14,
			Invalid = 15
		}
		public enum gamedataBuildType
		{
			CombatNetrunner0 = 0,
			CombatNetrunner10 = 1,
			CombatNetrunner15 = 2,
			CombatNetrunner18 = 3,
			CombatNetrunner20 = 4,
			CombatNetrunner25 = 5,
			CombatNetrunner30 = 6,
			CombatNetrunner35 = 7,
			CombatNetrunner40 = 8,
			CombatNetrunner5 = 9,
			CombatNetrunner50 = 10,
			CorporateStarting = 11,
			E32019NetrunnerPhase1 = 12,
			E32019StrongSoloPhase1 = 13,
			FunctionalTestsProgressionBuildTest = 14,
			FunctionalTestsStartingBuild = 15,
			GYMcclBuild = 16,
			GymSmoketestMaxedBuild = 17,
			HandsOnStarting = 18,
			ItemPass_BaseBuild = 19,
			ItemPass_FactionMeleeMods = 20,
			ItemPass_FactionRangedMods = 21,
			ItemPass_IconicMods = 22,
			ItemPass_LegendaryMods = 23,
			ItemPass_PowerMods = 24,
			ItemPass_SmartMods = 25,
			ItemPass_StandardMods = 26,
			ItemPass_TechMods = 27,
			JohnnyQ101 = 28,
			JohnnyQ108 = 29,
			JohnnyQ204 = 30,
			MaxSkillsAllWeapons = 31,
			MeleeCombat0 = 32,
			MeleeCombat10 = 33,
			MeleeCombat15 = 34,
			MeleeCombat20 = 35,
			MeleeCombat25 = 36,
			MeleeCombat30 = 37,
			MeleeCombat35 = 38,
			MeleeCombat40 = 39,
			MeleeCombat45 = 40,
			MeleeCombat5 = 41,
			MeleeCombat50 = 42,
			NomadStarting = 43,
			RangedCombat0 = 44,
			RangedCombat10 = 45,
			RangedCombat15 = 46,
			RangedCombat20 = 47,
			RangedCombat25 = 48,
			RangedCombat30 = 49,
			RangedCombat35 = 50,
			RangedCombat40 = 51,
			RangedCombat45 = 52,
			RangedCombat5 = 53,
			RangedCombat50 = 54,
			StartingBuild = 55,
			StreetKidStarting = 56,
			UIStressTest = 57,
			mech_netrunner = 58,
			q003_royce_netrunner = 59,
			q003_royce_noBuild = 60,
			q003_royce_solo = 61,
			q110_sasquatch_netrunner = 62,
			q110_sasquatch_noBuild = 63,
			q110_sasquatch_solo = 64,
			q112_oda_netrunner = 65,
			q112_oda_noBuild = 66,
			q112_oda_solo = 67,
			q113_smasher_melee = 68,
			q113_smasher_netrunner = 69,
			q113_smasher_noBuild = 70,
			q113_smasher_solo = 71,
			CpoAssassinBuild = 72,
			CpoDefaultBuild = 73,
			CpoNetrunnerBuild = 74,
			CpoSoloBuild = 75,
			CpoTechieBuild = 76,
			Count = 77,
			Invalid = 78
		}
		public enum gamedataChargeStep
		{
			Idle = 0,
			Charging = 1,
			Charged = 2,
			Overcharging = 3,
			Discharging = 4
		}
		public enum gamedataChoiceCaptionPartType
		{
			Blueline = 0,
			Icon = 1,
			QuickhackCost = 2,
			Tag = 3,
			Text = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataCompanionDistancePreset
		{
			Close = 0,
			Far = 1,
			Medium = 2,
			VeryFar = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataConsumableBaseName
		{
			Alcohol = 0,
			BonesMcCoy70 = 1,
			CarryCapacityBooster = 2,
			Drinkable = 3,
			Edible = 4,
			FirstAidWhiff = 5,
			HealthBooster = 6,
			MemoryBooster = 7,
			OxyBooster = 8,
			StaminaBooster = 9,
			Count = 10,
			Invalid = 11
		}
		public enum gamedataConsumableType
		{
			Drug = 0,
			Medical = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataDamageType
		{
			Chemical = 0,
			Electric = 1,
			Physical = 2,
			Thermal = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataDataNodeType
		{
			File = 0,
			Group = 1,
			Variable = 2,
			Value = 3,
			SimpleValue = 4,
			ComplexValue = 5
		}
		public enum gamedataDefenseMode
		{
			DefendAll = 0,
			DefendMelee = 1,
			DefendRanged = 2,
			NoDefend = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataDevelopmentPointType
		{
			Attribute = 0,
			Primary = 1,
			Secondary = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataDistrict
		{
			ArasakaWaterfront = 0,
			ArasakaWaterfront_AbandonedWarehouse = 1,
			ArasakaWaterfront_KonpekiPlaza = 2,
			Arroyo = 3,
			Arroyo_Arasaka_Warehouse = 4,
			Arroyo_ClairesGarage = 5,
			Arroyo_CytechFactory = 6,
			Arroyo_Kendachi = 7,
			Arroyo_KenmoreCafe = 8,
			Arroyo_LasPalapas = 9,
			Arroyo_Red_Dirt = 10,
			Arroyo_TireEmpire = 11,
			Badlands = 12,
			Badlands_BiotechnicaFlats = 13,
			Badlands_DryCreek = 14,
			Badlands_JacksonPlains = 15,
			Badlands_LagunaBend = 16,
			Badlands_LasPalapas = 17,
			Badlands_RattlesnakeCreek = 18,
			Badlands_RedPeaks = 19,
			Badlands_RockyRidge = 20,
			Badlands_SantaClara = 21,
			Badlands_SierraSonora = 22,
			Badlands_SoCalBorderCrossing = 23,
			Badlands_VasquezPass = 24,
			Badlands_Yucca = 25,
			Badlands_YuccaGarage = 26,
			Badlands_YuccaRadioTower = 27,
			CharterHill = 28,
			CharterHill_PowerPlant = 29,
			CityCenter = 30,
			Coastview = 31,
			Coastview_BattysHotel = 32,
			Coastview_ButcherShop = 33,
			Coastview_GrandImperialMall = 34,
			Coastview_RundownApartment = 35,
			Coastview_VDBChapel = 36,
			Coastview_VDBMaglev = 37,
			Coastview_q110Cyberspace = 38,
			CorpoPlaza = 39,
			CorpoPlaza_ArasakaTowerAtrium = 40,
			CorpoPlaza_ArasakaTowerCEOFloor = 41,
			CorpoPlaza_ArasakaTowerJenkins = 42,
			CorpoPlaza_ArasakaTowerJungle = 43,
			CorpoPlaza_ArasakaTowerLobby = 44,
			CorpoPlaza_ArasakaTowerNest = 45,
			CorpoPlaza_ArasakaTowerSaburoOffice = 46,
			CorpoPlaza_ArasakaTowerUnlistedFloors = 47,
			CorpoPlaza_ArasakaTowerUpperAtrium = 48,
			CorpoPlaza_q201Cyberspace = 49,
			Downtown = 50,
			Downtown_Jinguji = 51,
			Downtown_TheHammer = 52,
			Glen = 53,
			Glen_Embers = 54,
			Glen_MusicStore = 55,
			Glen_NCPDLab = 56,
			Glen_WichedTires = 57,
			Heywood = 58,
			JapanTown = 59,
			JapanTown_Clouds = 60,
			JapanTown_DarkMatter = 61,
			JapanTown_Fingers = 62,
			JapanTown_FourthWallBdStudio = 63,
			JapanTown_HiromisApartment = 64,
			JapanTown_MegabuildingH8 = 65,
			JapanTown_VR_Tutorial = 66,
			JapanTown_Wakakos_Pachinko_Parlor = 67,
			Kabuki = 68,
			Kabuki_JudysApartment = 69,
			Kabuki_LizziesBar = 70,
			Kabuki_NoTellMotel = 71,
			LagunaBend_LakeHut = 72,
			LittleChina = 73,
			LittleChina_Afterlife = 74,
			LittleChina_MistysShop = 75,
			LittleChina_Q101Cyberspace = 76,
			LittleChina_RiotClub = 77,
			LittleChina_TomsDiner = 78,
			LittleChina_VApartment = 79,
			LittleChina_VictorsClinic = 80,
			NorthBadlands = 81,
			NorthOaks = 82,
			NorthOaks_Arasaka_Estate = 83,
			NorthOaks_Columbarium = 84,
			NorthOaks_Denny_Estate = 85,
			NorthOaks_Kerry_Estate = 86,
			Northside = 87,
			Northside_All_Foods = 88,
			Northside_CleanCut = 89,
			Northside_Totentaz = 90,
			Northside_WNS = 91,
			Pacifica = 92,
			RanchoCoronado = 93,
			RanchoCoronado_Caliente = 94,
			RanchoCoronado_GunORama = 95,
			RanchoCoronado_Piez = 96,
			RanchoCoronado_Softsys = 97,
			RanchoCoronado_Stylishly = 98,
			SantoDomingo = 99,
			SouthBadlands = 100,
			SouthBadlands_EdgewoodFarm = 101,
			SouthBadlands_PoppyFarm = 102,
			SouthBadlands_TrailerPark = 103,
			SouthBadlands_q201SpaceStation = 104,
			VistaDelRey = 105,
			Vista_del_Rey_Delamain = 106,
			Vista_del_Rey_LaCatrina = 107,
			Vista_del_rey_Abandoned_Apartment_Building = 108,
			Vista_del_rey_ElCoyoteCojo = 109,
			Watson = 110,
			Wellsprings = 111,
			WestWindEstate = 112,
			Westbrook = 113,
			Count = 114,
			Invalid = 115
		}
		public enum gamedataEquipmentArea
		{
			AbilityCW = 0,
			ArmsCW = 1,
			BaseFists = 2,
			BotCPU = 3,
			BotChassisModule = 4,
			BotMainModule = 5,
			BotSoftware = 6,
			CardiovascularSystemCW = 7,
			Consumable = 8,
			CyberwareWheel = 9,
			EyesCW = 10,
			Face = 11,
			Feet = 12,
			FrontalCortexCW = 13,
			Gadget = 14,
			HandsCW = 15,
			Head = 16,
			ImmuneSystemCW = 17,
			InnerChest = 18,
			IntegumentarySystemCW = 19,
			LeftArm = 20,
			Legs = 21,
			LegsCW = 22,
			MusculoskeletalSystemCW = 23,
			NervousSystemCW = 24,
			OuterChest = 25,
			Outfit = 26,
			PersonalLink = 27,
			PlayerTattoo = 28,
			Quest = 29,
			QuickSlot = 30,
			QuickWheel = 31,
			RightArm = 32,
			SilverhandArm = 33,
			Splinter = 34,
			SystemReplacementCW = 35,
			UnderwearBottom = 36,
			UnderwearTop = 37,
			VDefaultHandgun = 38,
			Weapon = 39,
			WeaponHeavy = 40,
			WeaponLeft = 41,
			WeaponWheel = 42,
			Count = 43,
			Invalid = 44
		}
		public enum gamedataEthnicity
		{
			African = 0,
			AfricanAmerican = 1,
			AmericanEnglish = 2,
			Arabic = 3,
			Brasilian = 4,
			BritishEnglish = 5,
			Caribbean = 6,
			Chinese = 7,
			Default = 8,
			Indian = 9,
			Japanese = 10,
			Mexican = 11,
			NativeAmerican = 12,
			Russian = 13,
			Count = 14,
			Invalid = 15
		}
		public enum gamedataFxAction
		{
			EnterCharge = 0,
			EnterDischarge = 1,
			EnterLowAmmo = 2,
			EnterNoAmmo = 3,
			EnterOverheat = 4,
			EnterReload = 5,
			ExitCharge = 6,
			ExitDischarge = 7,
			ExitLowAmmo = 8,
			ExitNoAmmo = 9,
			ExitOverheat = 10,
			ExitReload = 11,
			MeleeBlock = 12,
			MeleeHit = 13,
			Shoot = 14,
			SilencedShoot = 15,
			Count = 16,
			Invalid = 17
		}
		public enum gamedataFxActionType
		{
			BreakLoop = 0,
			Kill = 1,
			Start = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataGender
		{
			Default = 0,
			Female = 1,
			Male = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataGrenadeDeliveryMethodType
		{
			Homing = 0,
			Regular = 1,
			Sticky = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataGroupNodeGroupVariableDeriveInfo
		{
			FullyDerived = 0,
			TypeDerived = 1,
			ValueChanged = 2,
			NotDerived = 3
		}
		public enum gamedataGroupNodeInheritanceState
		{
			Unresolved = 0,
			Resolving = 1,
			Resolved = 2
		}
		public enum gamedataHitPrereqConditionType
		{
			AgentMoving = 0,
			AmmoState = 1,
			AttackSubType = 2,
			AttackType = 3,
			BodyPart = 4,
			DamageOverTimeType = 5,
			DamageType = 6,
			DistanceCovered = 7,
			HitFlag = 8,
			InstigatorType = 9,
			SameTarget = 10,
			SourceType = 11,
			StatPool = 12,
			StatPoolComparison = 13,
			StatusEffectPresent = 14,
			TargetKilled = 15,
			TargetNPCRarity = 16,
			TargetNPCType = 17,
			TargetType = 18,
			WeaponType = 19,
			WoundedTriggered = 20,
			Count = 21,
			Invalid = 22
		}
		public enum gamedataImprovementRelation
		{
			Direct = 0,
			Inverse = 1,
			None = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataItemCategory
		{
			Clothing = 0,
			Consumable = 1,
			Cyberware = 2,
			Gadget = 3,
			General = 4,
			Part = 5,
			Weapon = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataItemStructure
		{
			BlueprintStackable = 0,
			Stackable = 1,
			Unique = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataItemType
		{
			Clo_Face = 0,
			Clo_Feet = 1,
			Clo_Head = 2,
			Clo_InnerChest = 3,
			Clo_Legs = 4,
			Clo_OuterChest = 5,
			Clo_Outfit = 6,
			Con_Ammo = 7,
			Con_Edible = 8,
			Con_Inhaler = 9,
			Con_Injector = 10,
			Con_LongLasting = 11,
			Con_Skillbook = 12,
			Cyb_Ability = 13,
			Cyb_Launcher = 14,
			Cyb_MantisBlades = 15,
			Cyb_NanoWires = 16,
			Cyb_StrongArms = 17,
			Fla_Launcher = 18,
			Fla_Rifle = 19,
			Fla_Shock = 20,
			Fla_Support = 21,
			Gad_Grenade = 22,
			Gen_CraftingMaterial = 23,
			Gen_DataBank = 24,
			Gen_Junk = 25,
			Gen_Keycard = 26,
			Gen_Misc = 27,
			Gen_Readable = 28,
			GrenadeDelivery = 29,
			Grenade_Core = 30,
			Prt_Capacitor = 31,
			Prt_FabricEnhancer = 32,
			Prt_Fragment = 33,
			Prt_Magazine = 34,
			Prt_Mod = 35,
			Prt_Muzzle = 36,
			Prt_Program = 37,
			Prt_Receiver = 38,
			Prt_Scope = 39,
			Prt_ScopeRail = 40,
			Prt_Stock = 41,
			Prt_TargetingSystem = 42,
			Wea_AssaultRifle = 43,
			Wea_Fists = 44,
			Wea_Hammer = 45,
			Wea_Handgun = 46,
			Wea_HeavyMachineGun = 47,
			Wea_Katana = 48,
			Wea_Knife = 49,
			Wea_LightMachineGun = 50,
			Wea_LongBlade = 51,
			Wea_Melee = 52,
			Wea_OneHandedClub = 53,
			Wea_PrecisionRifle = 54,
			Wea_Revolver = 55,
			Wea_Rifle = 56,
			Wea_ShortBlade = 57,
			Wea_Shotgun = 58,
			Wea_ShotgunDual = 59,
			Wea_SniperRifle = 60,
			Wea_SubmachineGun = 61,
			Wea_TwoHandedClub = 62,
			Count = 63,
			Invalid = 64
		}
		public enum gamedataLifePath
		{
			Corporate = 0,
			Nomad = 1,
			StreetKid = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataLocomotionMode
		{
			Moving = 0,
			Static = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataMappinPhase
		{
			CompletedPhase = 0,
			DefaultPhase = 1,
			DiscoveredPhase = 2,
			UndiscoveredPhase = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataMappinVariant
		{
			ActionDealDamageVariant = 0,
			ActionFastSoloVariant = 1,
			ActionGenericInteractionVariant = 2,
			ActionNetrunnerAccessPointVariant = 3,
			ActionNetrunnerVariant = 4,
			ActionScanVariant = 5,
			ActionSoloVariant = 6,
			ActionTechieVariant = 7,
			AimVariant = 8,
			AllowVariant = 9,
			ApartmentVariant = 10,
			ArrowVariant = 11,
			BackOutVariant = 12,
			BountyHuntVariant = 13,
			CallVariant = 14,
			ChangeToFriendlyVariant = 15,
			ClientInDistressVariant = 16,
			ConversationVariant = 17,
			ConvoyVariant = 18,
			CoolVariant = 19,
			CourierVariant = 20,
			CustomPositionVariant = 21,
			CyberspaceNPC = 22,
			CyberspaceObject = 23,
			DefaultInteractionVariant = 24,
			DefaultQuestVariant = 25,
			DefaultVariant = 26,
			DistractVariant = 27,
			DropboxVariant = 28,
			DynamicEventVariant = 29,
			EffectAlarmVariant = 30,
			EffectControlNetworkVariant = 31,
			EffectControlOtherDeviceVariant = 32,
			EffectControlSelfVariant = 33,
			EffectCutPowerVariant = 34,
			EffectDistractVariant = 35,
			EffectDropPointVariant = 36,
			EffectExplodeLethalVariant = 37,
			EffectExplodeNonLethalVariant = 38,
			EffectFallVariant = 39,
			EffectGrantInformationVariant = 40,
			EffectHideBodyVariant = 41,
			EffectLootVariant = 42,
			EffectOpenPathVariant = 43,
			EffectPushVariant = 44,
			EffectServicePointVariant = 45,
			EffectShootVariant = 46,
			EffectSpreadGasVariant = 47,
			EffectStoreItemsVariant = 48,
			ExclamationMarkVariant = 49,
			FailedCrossingVariant = 50,
			FastTravelVariant = 51,
			FixerVariant = 52,
			FocusClueVariant = 53,
			GPSForcedPathVariant = 54,
			GPSPortalVariant = 55,
			GangWatchVariant = 56,
			GenericRoleVariant = 57,
			GetInVariant = 58,
			GetUpVariant = 59,
			GrenadeVariant = 60,
			GunSuicideVariant = 61,
			HandVariant = 62,
			HazardWarningVariant = 63,
			HiddenStashVariant = 64,
			HitVariant = 65,
			HuntForPsychoVariant = 66,
			ImportantInteractionVariant = 67,
			InvalidVariant = 68,
			JackInVariant = 69,
			JamWeaponVariant = 70,
			LifepathCorpoVariant = 71,
			LifepathNomadVariant = 72,
			LifepathStreetKidVariant = 73,
			LootVariant = 74,
			MinorActivityVariant = 75,
			NPCVariant = 76,
			NetrunnerAccessPointVariant = 77,
			NetrunnerSoloTechieVariant = 78,
			NetrunnerSoloVariant = 79,
			NetrunnerTechieVariant = 80,
			NetrunnerVariant = 81,
			NonLethalTakedownVariant = 82,
			OffVariant = 83,
			OpenVendorVariant = 84,
			OutpostVariant = 85,
			PhoneCallVariant = 86,
			QuestGiverVariant = 87,
			QuestionMarkVariant = 88,
			QuickHackVariant = 89,
			ReflexesVariant = 90,
			ResourceVariant = 91,
			RetrievingVariant = 92,
			SOSsignalVariant = 93,
			SabotageVariant = 94,
			ServicePointBarVariant = 95,
			ServicePointClothesVariant = 96,
			ServicePointCyberwareVariant = 97,
			ServicePointDropPointVariant = 98,
			ServicePointFoodVariant = 99,
			ServicePointGunsVariant = 100,
			ServicePointJunkVariant = 101,
			ServicePointMedsVariant = 102,
			ServicePointMeleeTrainerVariant = 103,
			ServicePointNetTrainerVariant = 104,
			ServicePointProstituteVariant = 105,
			ServicePointRipperdocVariant = 106,
			ServicePointTechVariant = 107,
			SitVariant = 108,
			SmugglersDenVariant = 109,
			SoloTechieVariant = 110,
			SoloVariant = 111,
			SpeechVariant = 112,
			TakeControlVariant = 113,
			TakeDownVariant = 114,
			TarotVariant = 115,
			TechieVariant = 116,
			ThieveryVariant = 117,
			UseVariant = 118,
			VehicleVariant = 119,
			WanderingMerchantVariant = 120,
			CPO_PingDoorVariant = 121,
			CPO_PingGoHereVariant = 122,
			CPO_PingLootVariant = 123,
			CPO_RemotePlayerVariant = 124,
			Count = 125,
			Invalid = 126
		}
		public enum gamedataMeleeAttackDirection
		{
			Center = 0,
			DownToUp = 1,
			LeftDownToRightUp = 2,
			LeftToRight = 3,
			LeftUpToRightDown = 4,
			RightDownToLeftUp = 5,
			RightToLeft = 6,
			RightUpToLeftDown = 7,
			UpToDown = 8,
			Count = 9,
			Invalid = 10
		}
		public enum gamedataMetaQuest
		{
			MetaQuest1 = 0,
			MetaQuest2 = 1,
			MetaQuest3 = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataMovementType
		{
			Run = 0,
			Sprint = 1,
			Strafe = 2,
			Walk = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataNPCBehaviorState
		{
			State1 = 0,
			State2 = 1,
			State3 = 2,
			State4 = 3,
			State5 = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataNPCHighLevelState
		{
			Alerted = 0,
			Any = 1,
			Combat = 2,
			Dead = 3,
			Fear = 4,
			Relaxed = 5,
			Stealth = 6,
			Unconscious = 7,
			Wounded = 8,
			Count = 9,
			Invalid = 10
		}
		public enum gamedataNPCQuestAffiliation
		{
			General = 0,
			MainQuest = 1,
			MinorActivity = 2,
			MinorQuest = 3,
			SideQuest = 4,
			StreetStory = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataNPCRarity
		{
			Boss = 0,
			Elite = 1,
			Normal = 2,
			Officer = 3,
			Rare = 4,
			Trash = 5,
			Weak = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataNPCStanceState
		{
			Any = 0,
			Cover = 1,
			Crouch = 2,
			Stand = 3,
			Swim = 4,
			Vehicle = 5,
			VehicleWindow = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataNPCType
		{
			Android = 0,
			Any = 1,
			Drone = 2,
			Human = 3,
			Mech = 4,
			Spiderbot = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataNPCUpperBodyState
		{
			Aim = 0,
			Any = 1,
			Attack = 2,
			ChargedAttack = 3,
			Defend = 4,
			Equip = 5,
			Normal = 6,
			Parry = 7,
			Reload = 8,
			Shoot = 9,
			Taunt = 10,
			Count = 11,
			Invalid = 12
		}
		public enum gamedataObjectActionReference
		{
			Instigator = 0,
			Source = 1,
			Target = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataObjectActionType
		{
			DeviceQuickHack = 0,
			Direct = 1,
			Item = 2,
			MinigameUpload = 3,
			Payment = 4,
			PuppetQuickHack = 5,
			Remote = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataOutput
		{
			AskToFollowOrder = 0,
			AskToHolster = 1,
			BackOff = 2,
			BodyInvestigate = 3,
			Bump = 4,
			CallGuard = 5,
			CallPolice = 6,
			DeviceInvestigate = 7,
			Dodge = 8,
			DodgeToSide = 9,
			FearInPlace = 10,
			Flee = 11,
			Ignore = 12,
			Intruder = 13,
			Investigate = 14,
			LookAt = 15,
			Panic = 16,
			PlayerCall = 17,
			Reprimand = 18,
			SquadCall = 19,
			Surrender = 20,
			TurnAt = 21,
			WalkAway = 22,
			Count = 23,
			Invalid = 24
		}
		public enum gamedataParentAttachmentType
		{
			Animated = 0,
			Skinned = 1,
			Slot = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataPerkArea
		{
			Assault_Area_01 = 0,
			Assault_Area_02 = 1,
			Assault_Area_03 = 2,
			Assault_Area_04 = 3,
			Assault_Area_05 = 4,
			Assault_Area_06 = 5,
			Assault_Area_07 = 6,
			Assault_Area_08 = 7,
			Assault_Area_09 = 8,
			Assault_Area_10 = 9,
			Athletics_Area_01 = 10,
			Athletics_Area_02 = 11,
			Athletics_Area_03 = 12,
			Athletics_Area_04 = 13,
			Athletics_Area_05 = 14,
			Athletics_Area_06 = 15,
			Athletics_Area_07 = 16,
			Athletics_Area_08 = 17,
			Athletics_Area_09 = 18,
			Athletics_Area_10 = 19,
			Brawling_Area_01 = 20,
			Brawling_Area_02 = 21,
			Brawling_Area_03 = 22,
			Brawling_Area_04 = 23,
			Brawling_Area_05 = 24,
			Brawling_Area_06 = 25,
			Brawling_Area_07 = 26,
			Brawling_Area_08 = 27,
			ColdBlood_Area_01 = 28,
			ColdBlood_Area_02 = 29,
			ColdBlood_Area_03 = 30,
			ColdBlood_Area_04 = 31,
			ColdBlood_Area_05 = 32,
			ColdBlood_Area_06 = 33,
			ColdBlood_Area_07 = 34,
			ColdBlood_Area_08 = 35,
			ColdBlood_Area_09 = 36,
			ColdBlood_Area_10 = 37,
			CombatHacking_Area_01 = 38,
			CombatHacking_Area_02 = 39,
			CombatHacking_Area_03 = 40,
			CombatHacking_Area_04 = 41,
			CombatHacking_Area_05 = 42,
			CombatHacking_Area_06 = 43,
			CombatHacking_Area_07 = 44,
			CombatHacking_Area_08 = 45,
			CombatHacking_Area_09 = 46,
			CombatHacking_Area_10 = 47,
			Crafting_Area_01 = 48,
			Crafting_Area_02 = 49,
			Crafting_Area_03 = 50,
			Crafting_Area_04 = 51,
			Crafting_Area_05 = 52,
			Crafting_Area_06 = 53,
			Crafting_Area_07 = 54,
			Crafting_Area_08 = 55,
			Crafting_Area_09 = 56,
			Crafting_Area_10 = 57,
			Demolition_Area_01 = 58,
			Demolition_Area_02 = 59,
			Demolition_Area_03 = 60,
			Demolition_Area_04 = 61,
			Demolition_Area_05 = 62,
			Demolition_Area_06 = 63,
			Demolition_Area_07 = 64,
			Demolition_Area_08 = 65,
			Demolition_Area_09 = 66,
			Demolition_Area_10 = 67,
			Engineering_Area_01 = 68,
			Engineering_Area_02 = 69,
			Engineering_Area_03 = 70,
			Engineering_Area_04 = 71,
			Engineering_Area_05 = 72,
			Engineering_Area_06 = 73,
			Engineering_Area_07 = 74,
			Engineering_Area_08 = 75,
			Engineering_Area_09 = 76,
			Engineering_Area_10 = 77,
			Gunslinger_Area_01 = 78,
			Gunslinger_Area_02 = 79,
			Gunslinger_Area_03 = 80,
			Gunslinger_Area_04 = 81,
			Gunslinger_Area_05 = 82,
			Gunslinger_Area_06 = 83,
			Gunslinger_Area_07 = 84,
			Gunslinger_Area_08 = 85,
			Gunslinger_Area_09 = 86,
			Gunslinger_Area_10 = 87,
			Hacking_Area_01 = 88,
			Hacking_Area_02 = 89,
			Hacking_Area_03 = 90,
			Hacking_Area_04 = 91,
			Hacking_Area_05 = 92,
			Hacking_Area_06 = 93,
			Hacking_Area_07 = 94,
			Hacking_Area_08 = 95,
			Hacking_Area_09 = 96,
			Hacking_Area_10 = 97,
			Kenjutsu_Area_01 = 98,
			Kenjutsu_Area_02 = 99,
			Kenjutsu_Area_03 = 100,
			Kenjutsu_Area_04 = 101,
			Kenjutsu_Area_05 = 102,
			Kenjutsu_Area_06 = 103,
			Kenjutsu_Area_07 = 104,
			Kenjutsu_Area_08 = 105,
			Stealth_Area_01 = 106,
			Stealth_Area_02 = 107,
			Stealth_Area_03 = 108,
			Stealth_Area_04 = 109,
			Stealth_Area_05 = 110,
			Stealth_Area_06 = 111,
			Stealth_Area_07 = 112,
			Stealth_Area_08 = 113,
			Stealth_Area_09 = 114,
			Stealth_Area_10 = 115,
			Count = 116,
			Invalid = 117
		}
		public enum gamedataPerkType
		{
			Assault_Area_01_Perk_1 = 0,
			Assault_Area_01_Perk_2 = 1,
			Assault_Area_02_Perk_1 = 2,
			Assault_Area_02_Perk_2 = 3,
			Assault_Area_03_Perk_1 = 4,
			Assault_Area_03_Perk_2 = 5,
			Assault_Area_04_Perk_1 = 6,
			Assault_Area_04_Perk_2 = 7,
			Assault_Area_05_Perk_1 = 8,
			Assault_Area_05_Perk_2 = 9,
			Assault_Area_06_Perk_1 = 10,
			Assault_Area_06_Perk_2 = 11,
			Assault_Area_07_Perk_1 = 12,
			Assault_Area_07_Perk_2 = 13,
			Assault_Area_08_Perk_1 = 14,
			Assault_Area_08_Perk_2 = 15,
			Assault_Area_09_Perk_1 = 16,
			Assault_Area_09_Perk_2 = 17,
			Assault_Area_10_Perk_1 = 18,
			Athletics_Area_01_Perk_1 = 19,
			Athletics_Area_01_Perk_2 = 20,
			Athletics_Area_02_Perk_1 = 21,
			Athletics_Area_02_Perk_2 = 22,
			Athletics_Area_03_Perk_1 = 23,
			Athletics_Area_03_Perk_2 = 24,
			Athletics_Area_04_Perk_1 = 25,
			Athletics_Area_04_Perk_2 = 26,
			Athletics_Area_05_Perk_1 = 27,
			Athletics_Area_05_Perk_2 = 28,
			Athletics_Area_05_Perk_3 = 29,
			Athletics_Area_06_Perk_1 = 30,
			Athletics_Area_06_Perk_2 = 31,
			Athletics_Area_06_Perk_3 = 32,
			Athletics_Area_07_Perk_1 = 33,
			Athletics_Area_07_Perk_2 = 34,
			Athletics_Area_08_Perk_1 = 35,
			Athletics_Area_08_Perk_2 = 36,
			Athletics_Area_09_Perk_1 = 37,
			Athletics_Area_10_Perk_1 = 38,
			Athletics_Area_10_Perk_2 = 39,
			Brawling_Area_01_Perk_1 = 40,
			Brawling_Area_01_Perk_2 = 41,
			Brawling_Area_02_Perk_1 = 42,
			Brawling_Area_02_Perk_2 = 43,
			Brawling_Area_03_Perk_1 = 44,
			Brawling_Area_03_Perk_2 = 45,
			Brawling_Area_04_Perk_1 = 46,
			Brawling_Area_04_Perk_2 = 47,
			Brawling_Area_05_Perk_1 = 48,
			Brawling_Area_05_Perk_2 = 49,
			Brawling_Area_06_Perk_1 = 50,
			Brawling_Area_06_Perk_2 = 51,
			Brawling_Area_07_Perk_1 = 52,
			Brawling_Area_07_Perk_2 = 53,
			Brawling_Area_08_Perk_1 = 54,
			Brawling_Area_08_Perk_2 = 55,
			ColdBlood_Area_01_Perk_1 = 56,
			ColdBlood_Area_02_Perk_1 = 57,
			ColdBlood_Area_02_Perk_2 = 58,
			ColdBlood_Area_03_Perk_1 = 59,
			ColdBlood_Area_03_Perk_2 = 60,
			ColdBlood_Area_04_Perk_1 = 61,
			ColdBlood_Area_04_Perk_2 = 62,
			ColdBlood_Area_05_Perk_1 = 63,
			ColdBlood_Area_05_Perk_2 = 64,
			ColdBlood_Area_06_Perk_1 = 65,
			ColdBlood_Area_06_Perk_2 = 66,
			ColdBlood_Area_06_Perk_3 = 67,
			ColdBlood_Area_07_Perk_1 = 68,
			ColdBlood_Area_07_Perk_2 = 69,
			ColdBlood_Area_08_Perk_1 = 70,
			ColdBlood_Area_08_Perk_2 = 71,
			ColdBlood_Area_09_Perk_1 = 72,
			ColdBlood_Area_10_Perk_1 = 73,
			CombatHacking_Area_01_Perk_1 = 74,
			CombatHacking_Area_01_Perk_2 = 75,
			CombatHacking_Area_02_Perk_1 = 76,
			CombatHacking_Area_02_Perk_2 = 77,
			CombatHacking_Area_02_Perk_3 = 78,
			CombatHacking_Area_03_Perk_1 = 79,
			CombatHacking_Area_03_Perk_2 = 80,
			CombatHacking_Area_04_Perk_1 = 81,
			CombatHacking_Area_05_Perk_1 = 82,
			CombatHacking_Area_06_Perk_1 = 83,
			CombatHacking_Area_06_Perk_2 = 84,
			CombatHacking_Area_06_Perk_3 = 85,
			CombatHacking_Area_07_Perk_1 = 86,
			CombatHacking_Area_08_Perk_1 = 87,
			CombatHacking_Area_08_Perk_2 = 88,
			CombatHacking_Area_09_Perk_1 = 89,
			CombatHacking_Area_10_Perk_1 = 90,
			CombatHacking_Area_10_Perk_2 = 91,
			Crafting_Area_01_Perk_1 = 92,
			Crafting_Area_01_Perk_2 = 93,
			Crafting_Area_02_Perk_1 = 94,
			Crafting_Area_02_Perk_2 = 95,
			Crafting_Area_03_Perk_1 = 96,
			Crafting_Area_04_Perk_1 = 97,
			Crafting_Area_04_Perk_2 = 98,
			Crafting_Area_05_Perk_1 = 99,
			Crafting_Area_05_Perk_2 = 100,
			Crafting_Area_06_Perk_1 = 101,
			Crafting_Area_06_Perk_2 = 102,
			Crafting_Area_06_Perk_3 = 103,
			Crafting_Area_07_Perk_1 = 104,
			Crafting_Area_07_Perk_2 = 105,
			Crafting_Area_08_Perk_1 = 106,
			Crafting_Area_08_Perk_2 = 107,
			Crafting_Area_09_Perk_1 = 108,
			Crafting_Area_10_Perk_1 = 109,
			Demolition_Area_01_Perk_1 = 110,
			Demolition_Area_02_Perk_1 = 111,
			Demolition_Area_02_Perk_2 = 112,
			Demolition_Area_03_Perk_1 = 113,
			Demolition_Area_03_Perk_2 = 114,
			Demolition_Area_04_Perk_1 = 115,
			Demolition_Area_04_Perk_2 = 116,
			Demolition_Area_05_Perk_1 = 117,
			Demolition_Area_05_Perk_2 = 118,
			Demolition_Area_06_Perk_1 = 119,
			Demolition_Area_06_Perk_2 = 120,
			Demolition_Area_07_Perk_1 = 121,
			Demolition_Area_07_Perk_2 = 122,
			Demolition_Area_08_Perk_1 = 123,
			Demolition_Area_08_Perk_2 = 124,
			Demolition_Area_09_Perk_1 = 125,
			Demolition_Area_09_Perk_2 = 126,
			Demolition_Area_10_Perk_1 = 127,
			Demolition_Area_10_Perk_2 = 128,
			Engineering_Area_01_Perk_1 = 129,
			Engineering_Area_01_Perk_2 = 130,
			Engineering_Area_02_Perk_1 = 131,
			Engineering_Area_02_Perk_2 = 132,
			Engineering_Area_03_Perk_1 = 133,
			Engineering_Area_04_Perk_1 = 134,
			Engineering_Area_04_Perk_2 = 135,
			Engineering_Area_04_Perk_3 = 136,
			Engineering_Area_05_Perk_1 = 137,
			Engineering_Area_05_Perk_2 = 138,
			Engineering_Area_06_Perk_1 = 139,
			Engineering_Area_06_Perk_2 = 140,
			Engineering_Area_07_Perk_1 = 141,
			Engineering_Area_07_Perk_2 = 142,
			Engineering_Area_07_Perk_3 = 143,
			Engineering_Area_08_Perk_1 = 144,
			Engineering_Area_08_Perk_2 = 145,
			Engineering_Area_09_Perk_1 = 146,
			Engineering_Area_10_Perk_1 = 147,
			Engineering_Area_10_Perk_2 = 148,
			Gunslinger_Area_01_Perk_1 = 149,
			Gunslinger_Area_01_Perk_2 = 150,
			Gunslinger_Area_02_Perk_1 = 151,
			Gunslinger_Area_02_Perk_2 = 152,
			Gunslinger_Area_03_Perk_1 = 153,
			Gunslinger_Area_03_Perk_2 = 154,
			Gunslinger_Area_04_Perk_1 = 155,
			Gunslinger_Area_04_Perk_2 = 156,
			Gunslinger_Area_04_Perk_3 = 157,
			Gunslinger_Area_05_Perk_1 = 158,
			Gunslinger_Area_05_Perk_2 = 159,
			Gunslinger_Area_06_Perk_1 = 160,
			Gunslinger_Area_06_Perk_2 = 161,
			Gunslinger_Area_07_Perk_1 = 162,
			Gunslinger_Area_07_Perk_2 = 163,
			Gunslinger_Area_08_Perk_1 = 164,
			Gunslinger_Area_08_Perk_2 = 165,
			Gunslinger_Area_09_Perk_1 = 166,
			Gunslinger_Area_10_Perk_1 = 167,
			Hacking_Area_01_Perk_1 = 168,
			Hacking_Area_01_Perk_2 = 169,
			Hacking_Area_02_Perk_1 = 170,
			Hacking_Area_02_Perk_2 = 171,
			Hacking_Area_03_Perk_1 = 172,
			Hacking_Area_03_Perk_2 = 173,
			Hacking_Area_04_Perk_1 = 174,
			Hacking_Area_04_Perk_2 = 175,
			Hacking_Area_05_Perk_1 = 176,
			Hacking_Area_06_Perk_1 = 177,
			Hacking_Area_06_Perk_2 = 178,
			Hacking_Area_07_Perk_1 = 179,
			Hacking_Area_07_Perk_2 = 180,
			Hacking_Area_08_Perk_1 = 181,
			Hacking_Area_08_Perk_2 = 182,
			Hacking_Area_09_Perk_1 = 183,
			Hacking_Area_09_Perk_2 = 184,
			Hacking_Area_10_Perk_1 = 185,
			Hacking_Area_10_Perk_2 = 186,
			Kenjutsu_Area_01_Perk_1 = 187,
			Kenjutsu_Area_01_Perk_2 = 188,
			Kenjutsu_Area_02_Perk_1 = 189,
			Kenjutsu_Area_02_Perk_2 = 190,
			Kenjutsu_Area_03_Perk_1 = 191,
			Kenjutsu_Area_03_Perk_2 = 192,
			Kenjutsu_Area_04_Perk_1 = 193,
			Kenjutsu_Area_04_Perk_2 = 194,
			Kenjutsu_Area_05_Perk_1 = 195,
			Kenjutsu_Area_05_Perk_2 = 196,
			Kenjutsu_Area_06_Perk_1 = 197,
			Kenjutsu_Area_06_Perk_2 = 198,
			Kenjutsu_Area_07_Perk_1 = 199,
			Kenjutsu_Area_07_Perk_2 = 200,
			Kenjutsu_Area_08_Perk_1 = 201,
			Kenjutsu_Area_08_Perk_2 = 202,
			Stealth_Area_01_Perk_1 = 203,
			Stealth_Area_01_Perk_2 = 204,
			Stealth_Area_02_Perk_1 = 205,
			Stealth_Area_02_Perk_2 = 206,
			Stealth_Area_02_Perk_3 = 207,
			Stealth_Area_03_Perk_1 = 208,
			Stealth_Area_03_Perk_2 = 209,
			Stealth_Area_03_Perk_3 = 210,
			Stealth_Area_04_Perk_1 = 211,
			Stealth_Area_04_Perk_2 = 212,
			Stealth_Area_05_Perk_1 = 213,
			Stealth_Area_05_Perk_2 = 214,
			Stealth_Area_05_Perk_3 = 215,
			Stealth_Area_06_Perk_1 = 216,
			Stealth_Area_06_Perk_2 = 217,
			Stealth_Area_07_Perk_1 = 218,
			Stealth_Area_07_Perk_2 = 219,
			Stealth_Area_07_Perk_3 = 220,
			Stealth_Area_08_Perk_1 = 221,
			Stealth_Area_08_Perk_2 = 222,
			Stealth_Area_08_Perk_3 = 223,
			Stealth_Area_09_Perk_1 = 224,
			Stealth_Area_09_Perk_2 = 225,
			Stealth_Area_09_Perk_3 = 226,
			Stealth_Area_10_Perk_1 = 227,
			Count = 228,
			Invalid = 229
		}
		public enum gamedataPerkUtility
		{
			ActiveUtility = 0,
			PassiveUtility = 1,
			TriggeredUtility = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataPingType
		{
			Device = 0,
			Door = 1,
			Elevator = 2,
			Junction = 3,
			Location = 4,
			Loot = 5,
			Trap = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataPlayerBuild
		{
			Cool = 0,
			Netrunner = 1,
			Reflexes = 2,
			Solo = 3,
			Techie = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataPlayerPossesion
		{
			Default = 0,
			Johnny = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataProficiencyType
		{
			Assault = 0,
			Athletics = 1,
			Brawling = 2,
			ColdBlood = 3,
			CombatHacking = 4,
			Crafting = 5,
			Demolition = 6,
			Engineering = 7,
			Gunslinger = 8,
			Hacking = 9,
			Kenjutsu = 10,
			Level = 11,
			Stealth = 12,
			StreetCred = 13,
			Count = 14,
			Invalid = 15
		}
		public enum gamedataProjectileLaunchMode
		{
			Regular = 0,
			Tracking = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataProjectileOnCollisionAction
		{
			Bounce = 0,
			Pierce = 1,
			Stop = 2,
			StopAndStick = 3,
			StopAndStickPerpendicular = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataQuality
		{
			Common = 0,
			Epic = 1,
			Iconic = 2,
			Legendary = 3,
			Random = 4,
			Rare = 5,
			Uncommon = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataReactionPresetType
		{
			Child = 0,
			Civilian_Guard = 1,
			Civilian_Neutral = 2,
			Civilian_Passive = 3,
			Corpo_Aggressive = 4,
			Corpo_Passive = 5,
			Follower = 6,
			Ganger_Aggressive = 7,
			Ganger_Passive = 8,
			InVehicle_Aggressive = 9,
			InVehicle_Civilian = 10,
			InVehicle_Passive = 11,
			Lore_Aggressive = 12,
			Lore_Civilian = 13,
			Lore_Passive = 14,
			Mechanical_Aggressive = 15,
			Mechanical_NonCombat = 16,
			Mechanical_Passive = 17,
			NoReaction = 18,
			Police_Aggressive = 19,
			Police_Passive = 20,
			Sleep_Aggressive = 21,
			Sleep_Civilian = 22,
			Sleep_Passive = 23,
			Count = 24,
			Invalid = 25
		}
		public enum gamedataSenseObjectType
		{
			Camera = 0,
			Deadbody = 1,
			Follower = 2,
			Npc = 3,
			Player = 4,
			Turret = 5,
			Undefined = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataSimpleValueNodeValueType
		{
			String = 0,
			Number = 1,
			Bool = 2,
			Ident = 3
		}
		public enum gamedataSpawnableObjectPriority
		{
			Crowd = 0,
			Quest = 1,
			Regular = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataStatPoolType
		{
			Adrenaline = 0,
			Aggressiveness = 1,
			BleedingTrigger = 2,
			BurningTrigger = 3,
			CPUPower = 4,
			CallReinforcementProgress = 5,
			Durability = 6,
			E3_BossWeakSpotHealth = 7,
			ElectrocutedTrigger = 8,
			Fear = 9,
			Health = 10,
			LeftArmHealth = 11,
			LeftLegHealth = 12,
			Memory = 13,
			Oxygen = 14,
			PhoneCallDuration = 15,
			PoisonTrigger = 16,
			QuickHackDuration = 17,
			QuickHackUpload = 18,
			ReprimandEscalation = 19,
			RightLegHealth = 20,
			Stamina = 21,
			StunTrigger = 22,
			UnlockProgress = 23,
			WeakspotHealth = 24,
			WeaponCharge = 25,
			WeaponOverheat = 26,
			CPOShockedTrigger = 27,
			CPO_Armor = 28,
			CPO_NPC_Importance = 29,
			Count = 30,
			Invalid = 31
		}
		public enum gamedataStatType
		{
			Acceleration = 0,
			Accuracy = 1,
			Adrenaline = 2,
			AimFOV = 3,
			AimInTime = 4,
			AimOffset = 5,
			AimOutTime = 6,
			AllowMovementInput = 7,
			AllowRotation = 8,
			Armor = 9,
			Assault = 10,
			AssaultMastery = 11,
			AssaultTrait01Stat = 12,
			Athletics = 13,
			AthleticsMastery = 14,
			AthleticsTrait01Stat = 15,
			AttackPenetration = 16,
			AttackSpeed = 17,
			AttackSpeedPercent = 18,
			AttacksNumber = 19,
			AttacksPerSecond = 20,
			AttacksPerSecondBase = 21,
			AudioLocomotionStimRangeMultiplier = 22,
			AudioStimRangeMultiplier = 23,
			AutoReveal = 24,
			AutocraftDuration = 25,
			AutomaticReplenishment = 26,
			AutomaticUploadPerk = 27,
			BaseChargeTime = 28,
			BaseDamage = 29,
			BaseDamageMax = 30,
			BaseDamageMin = 31,
			BerserkArmorBonus = 32,
			BerserkCooldownBase = 33,
			BerserkCooldownReduction = 34,
			BerserkDurationBase = 35,
			BerserkHealthRegenBonus = 36,
			BerserkMeleeDamageBonus = 37,
			BerserkRecoilReduction = 38,
			BerserkResistancesBonus = 39,
			BerserkShockwaveDamage = 40,
			BerserkShockwaveRangeBonus = 41,
			BerserkSwayReduction = 42,
			BleedingApplicationRate = 43,
			BleedingImmunity = 44,
			BlindImmunity = 45,
			BlindResistance = 46,
			BlockFactor = 47,
			BlockLocomotionWhenLeaningOutOfCover = 48,
			BlockReduction = 49,
			BonusChargeDamage = 50,
			BonusDPS = 51,
			BonusDamageAgainstElites = 52,
			BonusDamageAgainstMechanicals = 53,
			BonusDamageAgainstRares = 54,
			BonusQuickHackDamage = 55,
			BonusRicochetDamage = 56,
			Brake = 57,
			BrakeDot = 58,
			Brawling = 59,
			BrawlingMastery = 60,
			BrawlingTrait01Stat = 61,
			BufferSize = 62,
			BulletMagnetismDefaultAngle = 63,
			BulletMagnetismHighVelocityAngle = 64,
			BurningApplicationRate = 65,
			BurningImmunity = 66,
			BurningRegenStamina = 67,
			CPUPower = 68,
			CallReinforcement = 69,
			CameraShutdownExtension = 70,
			CanAerialTakedown = 71,
			CanAimWhileDodging = 72,
			CanAskToFollowOrder = 73,
			CanAskToHolsterWeapon = 74,
			CanAutomaticallyDisassembleJunk = 75,
			CanAutomaticallyRestoreKnives = 76,
			CanBleedingCriticallyHit = 77,
			CanBleedingSlowTarget = 78,
			CanBlindQuickHack = 79,
			CanBlock = 80,
			CanBreatheUnderwater = 81,
			CanBuffCamoQuickHack = 82,
			CanBuffMechanicalsOnTakeControl = 83,
			CanBuffSturdinessQuickHack = 84,
			CanBurningCriticallyHit = 85,
			CanCallDrones = 86,
			CanCallReinforcements = 87,
			CanCatchUp = 88,
			CanCatchUpDistance = 89,
			CanCharge = 90,
			CanChargedShoot = 91,
			CanCloseCombat = 92,
			CanCommsCallInQuickHack = 93,
			CanCommsCallOutQuickHack = 94,
			CanCommsNoiseQuickHack = 95,
			CanControlFullyChargedWeapon = 96,
			CanCraftEpicItems = 97,
			CanCraftFromInventory = 98,
			CanCraftLegendaryItems = 99,
			CanCraftRareItems = 100,
			CanCraftTechAmmunition = 101,
			CanCrouch = 102,
			CanCyberwareMalfunctionQuickHack = 103,
			CanDash = 104,
			CanDataMineQuickHack = 105,
			CanDealFullDamageToArmored = 106,
			CanDeathQuickHack = 107,
			CanDisassemble = 108,
			CanDisassembleConsumables = 109,
			CanDisassembleGadgets = 110,
			CanDropWeapon = 111,
			CanElectrocuteNullifyStats = 112,
			CanElectrocuteRoot = 113,
			CanExitWSOnSoundStimuli = 114,
			CanExplodeQuickHack = 115,
			CanFastTravelWhileEncumbered = 116,
			CanFullyChargeWeapon = 117,
			CanGrab = 118,
			CanGrappleAndroids = 119,
			CanGrappleSilently = 120,
			CanGrenadeLaunch = 121,
			CanGrenadeQuickHack = 122,
			CanGrenadesCriticallyHit = 123,
			CanGrenadesDealExternalDamage = 124,
			CanGuardBreak = 125,
			CanHeartattackQuickHack = 126,
			CanIgnoreArmorDamageReduction = 127,
			CanIgnoreStamina = 128,
			CanInstallTechMods = 129,
			CanJamWeaponQuickHack = 130,
			CanJump = 131,
			CanLandSilently = 132,
			CanLegendaryCraftedWeaponsBeBoosted = 133,
			CanLocomotionMalfunctionQuickHack = 134,
			CanMadnessQuickHack = 135,
			CanMalfunctionQuickHack = 136,
			CanMeleeBerserk = 137,
			CanMeleeDash = 138,
			CanMeleeInfinitelyCombo = 139,
			CanMeleeLeap = 140,
			CanMeleeLeapTakedown = 141,
			CanOverchargeWeapon = 142,
			CanOverheatQuickHack = 143,
			CanOverloadQuickHack = 144,
			CanOverrideAttitudeQuickHack = 145,
			CanOverrideAuthorizationQuickHack = 146,
			CanParry = 147,
			CanPickUpBodyAfterTakedown = 148,
			CanPickUpWeapon = 149,
			CanPingQuickHack = 150,
			CanPlayerBoostConsumables = 151,
			CanPlayerBoostGrenades = 152,
			CanPoisonLowerArmor = 153,
			CanPoisonSlow = 154,
			CanPreciseShoot = 155,
			CanPushBack = 156,
			CanPushFromGrapple = 157,
			CanQuickHackCriticallyHit = 158,
			CanQuickMeleeStagger = 159,
			CanQuickhack = 160,
			CanQuickhackHealPuppet = 161,
			CanQuickhackTransferBetweenEnemies = 162,
			CanRegenInCombat = 163,
			CanRemoveModsFromClothing = 164,
			CanRemoveModsFromWeapons = 165,
			CanResurrectAllies = 166,
			CanRetrieveModsFromDisassemble = 167,
			CanRunSilently = 168,
			CanSandevistanSprintHarass = 169,
			CanScrapPartsFromMechanicals = 170,
			CanSeeGrenadeRadius = 171,
			CanSeeRicochetVisuals = 172,
			CanSeeThroughWalls = 173,
			CanShareThreatsWithPlayer = 174,
			CanShootWhileCarryingBody = 175,
			CanShootWhileDodging = 176,
			CanShootWhileGrappling = 177,
			CanShootWhileMoving = 178,
			CanShootWhileVaulting = 179,
			CanSilentKill = 180,
			CanSmartShoot = 181,
			CanSprint = 182,
			CanSprintHarass = 183,
			CanSprintWhileCarryingBody = 184,
			CanSuicideQuickHack = 185,
			CanSwitchWeapon = 186,
			CanTakeControlQuickHack = 187,
			CanTakedownLethally = 188,
			CanTakedownSilently = 189,
			CanTaunt = 190,
			CanThrowWeapon = 191,
			CanUpgradeFromInventory = 192,
			CanUpgradeToLegendaryQuality = 193,
			CanUseAntiStun = 194,
			CanUseBiohazardGrenades = 195,
			CanUseCloseRing = 196,
			CanUseCombatStims = 197,
			CanUseConsumables = 198,
			CanUseCoolingSystem = 199,
			CanUseCovers = 200,
			CanUseCuttingGrenades = 201,
			CanUseEMPGrenades = 202,
			CanUseExtremeRing = 203,
			CanUseFarRing = 204,
			CanUseFlashbangGrenades = 205,
			CanUseFragGrenades = 206,
			CanUseGrenades = 207,
			CanUseHolographicCamo = 208,
			CanUseIncendiaryGrenades = 209,
			CanUseLeftHand = 210,
			CanUseLegs = 211,
			CanUseMantisBlades = 212,
			CanUseMediumRing = 213,
			CanUseMeleeRing = 214,
			CanUseOpticalCamo = 215,
			CanUsePainInhibitors = 216,
			CanUsePersonalSoundSilencer = 217,
			CanUseProjectileLauncher = 218,
			CanUseReconGrenades = 219,
			CanUseRetractableShield = 220,
			CanUseRightHand = 221,
			CanUseShootingSpots = 222,
			CanUseStaticCamo = 223,
			CanUseStrongArms = 224,
			CanUseTakedowns = 225,
			CanUseTerrainCamo = 226,
			CanUseZoom = 227,
			CanWalkSilently = 228,
			CanWallStick = 229,
			CanWeaponBlock = 230,
			CanWeaponBlockAttack = 231,
			CanWeaponComboAttack = 232,
			CanWeaponCriticallyHit = 233,
			CanWeaponCrouchAttack = 234,
			CanWeaponDash = 235,
			CanWeaponDeflect = 236,
			CanWeaponIgnoreArmor = 237,
			CanWeaponInfinitlyCombo = 238,
			CanWeaponJumpAttack = 239,
			CanWeaponLeap = 240,
			CanWeaponMalfunctionQuickHack = 241,
			CanWeaponReload = 242,
			CanWeaponReloadWhileInactive = 243,
			CanWeaponReloadWhileSliding = 244,
			CanWeaponReloadWhileSprinting = 245,
			CanWeaponReloadWhileVaulting = 246,
			CanWeaponSafeAttack = 247,
			CanWeaponShoot = 248,
			CanWeaponShootWhileSliding = 249,
			CanWeaponShootWhileSprinting = 250,
			CanWeaponShootWhileVaulting = 251,
			CanWeaponSnapToLimbs = 252,
			CanWeaponSprintAttack = 253,
			CanWeaponStrongAttack = 254,
			CanWeaponTriggerHeadshot = 255,
			CannotBeDetectedWhileSubmerged = 256,
			CannotBeHealed = 257,
			CannotSprintHarass = 258,
			CarryCapacity = 259,
			CausingPanicReducesUltimateHacksCost = 260,
			Charge = 261,
			ChargeDischargeTime = 262,
			ChargeFullMultiplier = 263,
			ChargeMaxTimeInChargedState = 264,
			ChargeMultiplier = 265,
			ChargeReadyPercentage = 266,
			ChargeShouldFireWhenReady = 267,
			ChargeTime = 268,
			ChemicalDamage = 269,
			ChemicalDamageMax = 270,
			ChemicalDamageMin = 271,
			ChemicalDamagePercent = 272,
			ChemicalResistance = 273,
			ClimbSpeedModifier = 274,
			ClipTimesCycle = 275,
			ClipTimesCycleBase = 276,
			ClipTimesCyclePlusReload = 277,
			ClipTimesCyclePlusReloadBase = 278,
			CloudComputingTraps = 279,
			ColdBlood = 280,
			ColdBloodBuffBonus = 281,
			ColdBloodMastery = 282,
			ColdBloodMaxDuration = 283,
			ColdBloodMaxStacks = 284,
			ColdBloodTrait01 = 285,
			CombatHacking = 286,
			CombatHackingMastery = 287,
			CommsNoiseJamOnQuickhack = 288,
			Cool = 289,
			Crafting = 290,
			CraftingBonusArmorValue = 291,
			CraftingBonusConsumableDuration = 292,
			CraftingBonusGrenadeDamage = 293,
			CraftingBonusWeaponDamage = 294,
			CraftingCostReduction = 295,
			CraftingItemLevelBoost = 296,
			CraftingMastery = 297,
			CraftingMaterialDropChance = 298,
			CraftingMaterialRandomGrantChance = 299,
			CraftingMaterialRetrieveChance = 300,
			CraftingTrait01 = 301,
			CritChance = 302,
			CritChanceTimeCritDamage = 303,
			CritDPSBonus = 304,
			CritDamage = 305,
			CyberwareCooldownReduction = 306,
			CycleTime = 307,
			CycleTimeAimBlockDuration = 308,
			CycleTimeAimBlockStart = 309,
			CycleTimeBase = 310,
			CycleTimeBonus = 311,
			CycleTimeShootingMult = 312,
			CycleTimeShootingMultPeriod = 313,
			CycleTime_Burst = 314,
			CycleTime_BurstMaxCharge = 315,
			CycleTime_BurstSecondary = 316,
			CycleTriggerModeTime = 317,
			DPS = 318,
			DamageFalloffDisabled = 319,
			DamageHackSpread = 320,
			DamagePerHit = 321,
			DamageReductionDamageOverTime = 322,
			DamageReductionExplosion = 323,
			DashAttackStaminaCostReduction = 324,
			DataLeakTraps = 325,
			DealsChemicalDamage = 326,
			DealsElectricDamage = 327,
			DealsPhysicalDamage = 328,
			DealsThermalDamage = 329,
			Deceleration = 330,
			DefeatedHeadDamageThreshold = 331,
			DefeatedLArmDamageThreshold = 332,
			DefeatedLLegDamageThreshold = 333,
			DefeatedRArmDamageThreshold = 334,
			DefeatedRLegDamageThreshold = 335,
			DefeatingEnemiesReduceHacksCost = 336,
			Demolition = 337,
			DemolitionMastery = 338,
			DemolitionTrait01Stat = 339,
			Detection = 340,
			DeviceMemoryCostReduction = 341,
			DisableCyberwareOnBurning = 342,
			DisassemblingIngredientsDoubleBonus = 343,
			DisassemblingMaterialQualityObtainChance = 344,
			DismHeadDamageThreshold = 345,
			DismLArmDamageThreshold = 346,
			DismLLegDamageThreshold = 347,
			DismRArmDamageThreshold = 348,
			DismRLegDamageThreshold = 349,
			DoNotCheckFriendlyFireMadnessPassive = 350,
			DummyResistanceStat = 351,
			Durability = 352,
			DurationBonusBleeding = 353,
			DurationBonusBurning = 354,
			DurationBonusElectrified = 355,
			DurationBonusPoisoned = 356,
			DurationBonusQuickhack = 357,
			DurationBonusStun = 358,
			EMPImmunity = 359,
			EffectiveDPS = 360,
			EffectiveDamagePerHit = 361,
			EffectiveDamagePerHitMax = 362,
			EffectiveDamagePerHitMin = 363,
			EffectiveDamagePerHitTimesAttacksPerSecond = 364,
			EffectiveRange = 365,
			ElectricDamage = 366,
			ElectricDamageMax = 367,
			ElectricDamageMin = 368,
			ElectricDamagePercent = 369,
			ElectricResistance = 370,
			ElectrocuteImmunity = 371,
			ElectrocutedApplicationRate = 372,
			ElementalDamagePerHit = 373,
			ElementalResistanceMultiplier = 374,
			EmptyReloadTime = 375,
			Engineering = 376,
			EngineeringMastery = 377,
			EngineeringTrait01 = 378,
			EquipActionDuration_Corpo = 379,
			EquipActionDuration_Gang = 380,
			EquipAnimationDuration_Corpo = 381,
			EquipAnimationDuration_Gang = 382,
			EquipDuration = 383,
			EquipDuration_First = 384,
			EquipItemTime_Corpo = 385,
			EquipItemTime_Gang = 386,
			Evasion = 387,
			ExplosionKillsRecudeUltimateHacksCost = 388,
			FFInputLock = 389,
			FallDamageReduction = 390,
			FearOnQuickHackKill = 391,
			FullAutoOnFullCharge = 392,
			Gunslinger = 393,
			GunslingerMastery = 394,
			GunslingerTrait01Stat = 395,
			HackedEnemiesGetDamagedByFriendlyFire = 396,
			HackedEnemyArmorReduction = 397,
			Hacking = 398,
			HackingMastery = 399,
			HackingPenetration = 400,
			HackingResistance = 401,
			HackingResistanceUltimate = 402,
			HasAdditionalSplinterSlot = 403,
			HasAheadTargeting = 404,
			HasAirHover = 405,
			HasAirThrusters = 406,
			HasAutoReloader = 407,
			HasAutomaticReplenishment = 408,
			HasAutomaticTagging = 409,
			HasBerserk = 410,
			HasBleedImmunity = 411,
			HasBlindImmunity = 412,
			HasBoostedCortex = 413,
			HasBurningBuffs = 414,
			HasCameraLinking = 415,
			HasChargeJump = 416,
			HasCritImmunity = 417,
			HasCyberdeck = 418,
			HasCybereye = 419,
			HasDodge = 420,
			HasDodgeAir = 421,
			HasDoubleJump = 422,
			HasElectricCoating = 423,
			HasElectroPlating = 424,
			HasExtendedHitReactionImmunity = 425,
			HasFireproofSkin = 426,
			HasGPS = 427,
			HasGlowingTattoos = 428,
			HasGraphiteTissue = 429,
			HasHackingInteractions = 430,
			HasHealingReapplication = 431,
			HasHealthMonitorBomb = 432,
			HasHostileHackImmunity = 433,
			HasICELevelBooster = 434,
			HasInfravision = 435,
			HasJuiceInjector = 436,
			HasKerenzikov = 437,
			HasKerenzikovSlide = 438,
			HasKers = 439,
			HasLinkToBountySystem = 440,
			HasLoweringPerception = 441,
			HasMadnessLvl4Passive = 442,
			HasMajorQuickhackResistance = 443,
			HasMechanicalControl = 444,
			HasMeleeImmunity = 445,
			HasMeleeTargeting = 446,
			HasMetabolicEnhancer = 447,
			HasPoisonHeal = 448,
			HasPoisonImmunity = 449,
			HasPowerGrip = 450,
			HasQuickhackResistance = 451,
			HasRemoteBotAccessPointBreach = 452,
			HasSandevistan = 453,
			HasSandevistanTier1 = 454,
			HasSandevistanTier2 = 455,
			HasSandevistanTier3 = 456,
			HasSecondHeart = 457,
			HasSelfHealingSkin = 458,
			HasSmartLink = 459,
			HasSpiderBotControl = 460,
			HasStunImmunity = 461,
			HasSubdermalArmor = 462,
			HasSuperheroFall = 463,
			HasThermovision = 464,
			HasTimedImmunity = 465,
			HasToxicCleanser = 466,
			HasWallRunSkill = 467,
			HeadshotDamageMultiplier = 468,
			HeadshotImmunity = 469,
			Health = 470,
			HealthInCombatRegenDelayOnChange = 471,
			HealthInCombatRegenEnabled = 472,
			HealthInCombatRegenEndThreshold = 473,
			HealthInCombatRegenRate = 474,
			HealthInCombatRegenRateAdd = 475,
			HealthInCombatRegenRateBase = 476,
			HealthInCombatRegenRateMult = 477,
			HealthInCombatRegenStartThreshold = 478,
			HealthInCombatStartDelay = 479,
			HealthMonitorCooldownDuration = 480,
			HealthOutOfCombatRegenDelayOnChange = 481,
			HealthOutOfCombatRegenEnabled = 482,
			HealthOutOfCombatRegenEndThreshold = 483,
			HealthOutOfCombatRegenRate = 484,
			HealthOutOfCombatRegenRateAdd = 485,
			HealthOutOfCombatRegenRateBase = 486,
			HealthOutOfCombatRegenRateMult = 487,
			HealthOutOfCombatRegenStartThreshold = 488,
			Hearing = 489,
			HeavyAttacksNumber = 490,
			HighlightAccessPoint = 491,
			HitDismembermentFactor = 492,
			HitReactionDamageHealthFactor = 493,
			HitReactionFactor = 494,
			HitTimerAfterDefeated = 495,
			HitTimerAfterImpact = 496,
			HitTimerAfterImpactMelee = 497,
			HitTimerAfterKnockdown = 498,
			HitTimerAfterPain = 499,
			HitTimerAfterStagger = 500,
			HitTimerAfterStaggerMelee = 501,
			HitWoundsFactor = 502,
			HoldDuration = 503,
			HoldEnterDuration = 504,
			HoldTimeoutDuration = 505,
			HolographicSkinCooldownDuration = 506,
			HolographicSkinDuration = 507,
			IconicItemUpgraded = 508,
			ImpactDamageThreshold = 509,
			ImpactDamageThresholdImpulse = 510,
			ImpactDamageThresholdInCover = 511,
			Intelligence = 512,
			IsAggressive = 513,
			IsBalanced = 514,
			IsBlocking = 515,
			IsCautious = 516,
			IsDefensive = 517,
			IsDeflecting = 518,
			IsDodgeStaminaFree = 519,
			IsDodging = 520,
			IsFastMeleeArchetype = 521,
			IsFastRangedArchetype = 522,
			IsGenericMeleeArchetype = 523,
			IsGenericRangedArchetype = 524,
			IsHeavyRangedArchetype = 525,
			IsInvulnerable = 526,
			IsItemBroken = 527,
			IsItemCracked = 528,
			IsItemCrafted = 529,
			IsItemIconic = 530,
			IsItemUpgraded = 531,
			IsManBig = 532,
			IsManMassive = 533,
			IsMechanical = 534,
			IsNetrunnerArchetype = 535,
			IsNotSlowedDuringADS = 536,
			IsNotSlowedDuringBlock = 537,
			IsNotSlowedDuringReload = 538,
			IsReckless = 539,
			IsShotgunnerArchetype = 540,
			IsSniperArchetype = 541,
			IsSprintStaminaFree = 542,
			IsStrongMeleeArchetype = 543,
			IsTechieArchetype = 544,
			IsTier1Archetype = 545,
			IsTier2Archetype = 546,
			IsTier3Archetype = 547,
			IsTier4Archetype = 548,
			IsWeakspot = 549,
			IsWeaponLethal = 550,
			ItemArmor = 551,
			ItemLevel = 552,
			ItemRequiresElectroPlating = 553,
			ItemRequiresPowerGrip = 554,
			ItemRequiresSmartLink = 555,
			JumpHeight = 556,
			Kenjutsu = 557,
			KenjutsuMastery = 558,
			KenjutsuTrait01Stat = 559,
			KnockdownDamageThreshold = 560,
			KnockdownDamageThresholdImpulse = 561,
			KnockdownDamageThresholdInCover = 562,
			KnockdownImmunity = 563,
			KnockdownImpulse = 564,
			Level = 565,
			LimbHealth = 566,
			LinearDirectionUpdateMax = 567,
			LinearDirectionUpdateMaxADS = 568,
			LinearDirectionUpdateMin = 569,
			LinearDirectionUpdateMinADS = 570,
			LowerActiveCooldownOnDefeat = 571,
			LowerHackingResistanceOnHack = 572,
			MagazineCapacity = 573,
			MagazineCapacityBase = 574,
			MagazineCapacityBonus = 575,
			MaxDuration = 576,
			MaxPercentDamageTakenPerHit = 577,
			MaxSpeed = 578,
			MaxStacks = 579,
			MaxStacksBonusBleeding = 580,
			MaxStacksBonusBurning = 581,
			MechanicalsBuffDPSBonus = 582,
			MeleeAttackDuration = 583,
			Memory = 584,
			MemoryCostModifier = 585,
			MemoryCostReduction = 586,
			MemoryInCombatRegenDelayOnChange = 587,
			MemoryInCombatRegenEnabled = 588,
			MemoryInCombatRegenEndThreshold = 589,
			MemoryInCombatRegenRate = 590,
			MemoryInCombatRegenRateAdd = 591,
			MemoryInCombatRegenRateBase = 592,
			MemoryInCombatRegenRateMult = 593,
			MemoryInCombatRegenStartThreshold = 594,
			MemoryInCombatStartDelay = 595,
			MemoryOutOfCombatRegenDelayOnChange = 596,
			MemoryOutOfCombatRegenEnabled = 597,
			MemoryOutOfCombatRegenEndThreshold = 598,
			MemoryOutOfCombatRegenRate = 599,
			MemoryOutOfCombatRegenRateAdd = 600,
			MemoryOutOfCombatRegenRateBase = 601,
			MemoryOutOfCombatRegenRateMult = 602,
			MemoryOutOfCombatRegenStartThreshold = 603,
			MemoryOutOfCombatStartDelay = 604,
			MemoryTrackerCooldownDuration = 605,
			MinSpeed = 606,
			MinigameBufferExtension = 607,
			MinigameMaterialsEarned = 608,
			MinigameMemoryRegenPerk = 609,
			MinigameMoneyMultiplier = 610,
			MinigameNextInstanceBufferExtensionPerk = 611,
			MinigameShardChanceMultiplier = 612,
			MinigameTimeLimitExtension = 613,
			MinigameTrapsPossibilityChance = 614,
			NPCAnimationTime = 615,
			NPCCorpoEquipItemDuration = 616,
			NPCCorpoUnequipItemDuration = 617,
			NPCDamage = 618,
			NPCEquipItemDuration = 619,
			NPCGangEquipItemDuration = 620,
			NPCGangUnequipItemDuration = 621,
			NPCLoopDuration = 622,
			NPCRecoverDuration = 623,
			NPCStartupDuration = 624,
			NPCUnequipItemDuration = 625,
			NPCUploadTime = 626,
			NoJam = 627,
			NumShotsInBurst = 628,
			NumShotsInBurstMaxCharge = 629,
			NumShotsInBurstSecondary = 630,
			NumShotsToFire = 631,
			NumberIgnoredTraps = 632,
			Overheat = 633,
			Oxygen = 634,
			PartArmor = 635,
			PenetrationHealth = 636,
			PersonalityAggressive = 637,
			PersonalityCuriosity = 638,
			PersonalityDisgust = 639,
			PersonalityFear = 640,
			PersonalityFunny = 641,
			PersonalityJoy = 642,
			PersonalitySad = 643,
			PersonalityShock = 644,
			PersonalitySurprise = 645,
			PhoneCallDuration = 646,
			PhysicalDamage = 647,
			PhysicalDamageMax = 648,
			PhysicalDamageMin = 649,
			PhysicalDamagePercent = 650,
			PhysicalImpulse = 651,
			PhysicalResistance = 652,
			PoisonImmunity = 653,
			PoisonRegenHealth = 654,
			PoisonedApplicationRate = 655,
			PowerLevel = 656,
			PreFireTime = 657,
			PrefersCovers = 658,
			PrefersShootingSpots = 659,
			Price = 660,
			ProjectilesPerShot = 661,
			ProjectilesPerShotBase = 662,
			ProjectilesPerShotBonus = 663,
			Quality = 664,
			Quantity = 665,
			QuickHackDuration = 666,
			QuickHackDurationExtension = 667,
			QuickHackImmunity = 668,
			QuickHackResistancesMod = 669,
			QuickHackSpreadDistance = 670,
			QuickHackSpreadNumber = 671,
			QuickHackSuddenDeathChance = 672,
			QuickHackUpload = 673,
			QuickhackExtraDamageMultiplier = 674,
			QuickhackShield = 675,
			QuickhacksCooldownReduction = 676,
			RandomCurveInput = 677,
			Range = 678,
			Recoil = 679,
			RecoilAllowSway = 680,
			RecoilAlternateDir = 681,
			RecoilAlternateDirADS = 682,
			RecoilAngle = 683,
			RecoilAngleADS = 684,
			RecoilAnimation = 685,
			RecoilChargeMult = 686,
			RecoilChargeMultADS = 687,
			RecoilCycleSize = 688,
			RecoilCycleSizeADS = 689,
			RecoilCycleTime = 690,
			RecoilCycleTimeADS = 691,
			RecoilDelay = 692,
			RecoilDir = 693,
			RecoilDirADS = 694,
			RecoilDirPlanCycleRandDir = 695,
			RecoilDirPlanCycleRandDirADS = 696,
			RecoilDirPlanCycleRandRangeDir = 697,
			RecoilDirPlanCycleRandRangeDirADS = 698,
			RecoilDirPlanSequence = 699,
			RecoilDirPlanSequenceADS = 700,
			RecoilDriftRandomRangeMax = 701,
			RecoilDriftRandomRangeMin = 702,
			RecoilEnableCycleX = 703,
			RecoilEnableCycleXADS = 704,
			RecoilEnableCycleY = 705,
			RecoilEnableCycleYADS = 706,
			RecoilEnableLinearX = 707,
			RecoilEnableLinearXADS = 708,
			RecoilEnableLinearY = 709,
			RecoilEnableLinearYADS = 710,
			RecoilEnableScaleX = 711,
			RecoilEnableScaleXADS = 712,
			RecoilEnableScaleY = 713,
			RecoilEnableScaleYADS = 714,
			RecoilFullChargeMult = 715,
			RecoilFullChargeMultADS = 716,
			RecoilHoldDuration = 717,
			RecoilHoldDurationADS = 718,
			RecoilKickMax = 719,
			RecoilKickMaxADS = 720,
			RecoilKickMin = 721,
			RecoilKickMinADS = 722,
			RecoilMagForFullDrift = 723,
			RecoilMaxLength = 724,
			RecoilMaxLengthADS = 725,
			RecoilRecoveryMinSpeed = 726,
			RecoilRecoveryMinSpeedADS = 727,
			RecoilRecoverySpeed = 728,
			RecoilRecoverySpeedADS = 729,
			RecoilRecoveryTime = 730,
			RecoilRecoveryTimeADS = 731,
			RecoilScaleMax = 732,
			RecoilScaleMaxADS = 733,
			RecoilScaleTime = 734,
			RecoilScaleTimeADS = 735,
			RecoilSpeed = 736,
			RecoilSpeedADS = 737,
			RecoilTime = 738,
			RecoilTimeADS = 739,
			RecoilUseDifferentStatsInADS = 740,
			Reflexes = 741,
			RefreshesPingOnQuickhack = 742,
			RegenerateHPMinigamePerk = 743,
			ReloadAmount = 744,
			ReloadEndTime = 745,
			ReloadTime = 746,
			ReloadTimeBase = 747,
			ReloadTimeBonus = 748,
			RemoveAllStacksWhenDurationEnds = 749,
			RemoveColdBloodStacksOneByOne = 750,
			RemoveSprintOnQuickhack = 751,
			ReprimandEscalation = 752,
			RestoreMemoryOnDefeat = 753,
			RevealNetrunnerWhenHacked = 754,
			RicochetChance = 755,
			RicochetCount = 756,
			RicochetMaxAngle = 757,
			RicochetMinAngle = 758,
			RicochetTargetSearchAngle = 759,
			SandevistanDashShoot = 760,
			ScanDepth = 761,
			ScanTimeReduction = 762,
			ScopeFOV = 763,
			ScopeOffset = 764,
			ScrapItemChance = 765,
			SharedCacheTraps = 766,
			ShootingOffsetAI = 767,
			ShortCircuitOnCriticalHit = 768,
			ShorterChains = 769,
			ShotDelay = 770,
			SlideWhenLeaningOutOfCover = 771,
			SmartGunAddSpiralTrajectory = 772,
			SmartGunAdsLockingAnglePitch = 773,
			SmartGunAdsLockingAngleYaw = 774,
			SmartGunAdsMaxLockedTargets = 775,
			SmartGunAdsTagLockAnglePitch = 776,
			SmartGunAdsTagLockAngleYaw = 777,
			SmartGunAdsTargetableAnglePitch = 778,
			SmartGunAdsTargetableAngleYaw = 779,
			SmartGunAdsTimeToLock = 780,
			SmartGunAdsTimeToUnlock = 781,
			SmartGunEvenDistributionPeriod = 782,
			SmartGunHipLockingAnglePitch = 783,
			SmartGunHipLockingAngleYaw = 784,
			SmartGunHipMaxLockedTargets = 785,
			SmartGunHipTagLockAnglePitch = 786,
			SmartGunHipTagLockAngleYaw = 787,
			SmartGunHipTargetableAnglePitch = 788,
			SmartGunHipTargetableAngleYaw = 789,
			SmartGunHipTimeToLock = 790,
			SmartGunHipTimeToUnlock = 791,
			SmartGunHitProbability = 792,
			SmartGunHitProbabilityMultiplier = 793,
			SmartGunMissDelay = 794,
			SmartGunMissRadius = 795,
			SmartGunNPCApplySpreadAtHitplane = 796,
			SmartGunNPCLockOnTime = 797,
			SmartGunNPCLockTimeout = 798,
			SmartGunNPCLockingAnglePitch = 799,
			SmartGunNPCLockingAngleYaw = 800,
			SmartGunNPCProjectileStartingOrientationAngleOffset = 801,
			SmartGunNPCProjectileVelocity = 802,
			SmartGunNPCShootProjectilesOnlyStraight = 803,
			SmartGunNPCSpreadMultiplier = 804,
			SmartGunNPCTrajectoryCurvatureMultiplier = 805,
			SmartGunPlayerProjectileVelocity = 806,
			SmartGunProjectileVelocityVariance = 807,
			SmartGunSpiralCycleTimeMax = 808,
			SmartGunSpiralCycleTimeMin = 809,
			SmartGunSpiralRadius = 810,
			SmartGunSpiralRampDistanceEnd = 811,
			SmartGunSpiralRampDistanceStart = 812,
			SmartGunSpiralRandomizeDirection = 813,
			SmartGunSpreadMultiplier = 814,
			SmartGunStartingAccuracy = 815,
			SmartGunTargetAcquisitionRange = 816,
			SmartGunTimeToMaxAccuracy = 817,
			SmartGunTimeToRemoveOccludedTarget = 818,
			SmartGunTrackAllBodyparts = 819,
			SmartGunTrackHeadComponents = 820,
			SmartGunTrackLegComponents = 821,
			SmartGunTrackMechanicalComponents = 822,
			SmartGunTrackMultipleEntitiesInADS = 823,
			SmartGunUseEvenDistributionTargeting = 824,
			SmartGunUseTagLockTargeting = 825,
			SmartGunUseTimeBasedAccuracy = 826,
			SmartTargetingDisruptionProbability = 827,
			SpecialDamage = 828,
			SpeedBoost = 829,
			SpeedBoostMaxSpeed = 830,
			Spread = 831,
			SpreadAdsChangePerShot = 832,
			SpreadAdsChargeMult = 833,
			SpreadAdsDefaultX = 834,
			SpreadAdsDefaultY = 835,
			SpreadAdsFastSpeedMax = 836,
			SpreadAdsFastSpeedMaxAdd = 837,
			SpreadAdsFastSpeedMin = 838,
			SpreadAdsFastSpeedMinAdd = 839,
			SpreadAdsFullChargeMult = 840,
			SpreadAdsMaxX = 841,
			SpreadAdsMaxY = 842,
			SpreadAdsMinX = 843,
			SpreadAdsMinY = 844,
			SpreadAnimation = 845,
			SpreadChangePerShot = 846,
			SpreadChargeMult = 847,
			SpreadCrouchDefaultMult = 848,
			SpreadCrouchMaxMult = 849,
			SpreadDefaultX = 850,
			SpreadDefaultY = 851,
			SpreadEvenDistributionJitterSize = 852,
			SpreadEvenDistributionRowCount = 853,
			SpreadFastSpeedMax = 854,
			SpreadFastSpeedMaxAdd = 855,
			SpreadFastSpeedMin = 856,
			SpreadFastSpeedMinAdd = 857,
			SpreadFullChargeMult = 858,
			SpreadMaxAI = 859,
			SpreadMaxX = 860,
			SpreadMaxY = 861,
			SpreadMinX = 862,
			SpreadMinY = 863,
			SpreadRandomizeOriginPoint = 864,
			SpreadResetSpeed = 865,
			SpreadResetTimeThreshold = 866,
			SpreadUseCircularSpread = 867,
			SpreadUseEvenDistribution = 868,
			SpreadUseInAds = 869,
			SpreadZeroOnFirstShot = 870,
			StaggerDamageThreshold = 871,
			StaggerDamageThresholdImpulse = 872,
			StaggerDamageThresholdInCover = 873,
			Stamina = 874,
			StaminaCostReduction = 875,
			StaminaCostToBlock = 876,
			StaminaDamage = 877,
			StaminaRegenDelayOnChange = 878,
			StaminaRegenEnabled = 879,
			StaminaRegenEndThrehold = 880,
			StaminaRegenRate = 881,
			StaminaRegenRateAdd = 882,
			StaminaRegenRateBase = 883,
			StaminaRegenRateMult = 884,
			StaminaRegenStartDelay = 885,
			StaminaRegenStartThreshold = 886,
			StaminaSprintDecayRate = 887,
			StatModifierGroupLimit = 888,
			Stealth = 889,
			StealthHacksCostReduction = 890,
			StealthHitDamageMultiplier = 891,
			StealthMastery = 892,
			StealthTrait01Stat = 893,
			StealthWeakspotDamageMultiplier = 894,
			StreetCred = 895,
			Strength = 896,
			StunImmunity = 897,
			Sway = 898,
			SwayCenterMaximumAngleOffset = 899,
			SwayCurvatureMaximumFactor = 900,
			SwayCurvatureMinimumFactor = 901,
			SwayInitialOffsetRandomFactor = 902,
			SwayResetOnAimStart = 903,
			SwaySideBottomAngleLimit = 904,
			SwaySideMaximumAngleDistance = 905,
			SwaySideMinimumAngleDistance = 906,
			SwaySideStepChangeMaximumFactor = 907,
			SwaySideStepChangeMinimumFactor = 908,
			SwaySideTopAngleLimit = 909,
			SwayStartBlendTime = 910,
			SwayStartDelay = 911,
			SwayTraversalTime = 912,
			TBHsBaseCoefficient = 913,
			TBHsBaseSourceMultiplierCoefficient = 914,
			TBHsCoverTraceLoSIncreaseSpeed = 915,
			TBHsMinimumLineOfSightTime = 916,
			TBHsSensesTraceLoSIncreaseSpeed = 917,
			TBHsVisibilityCooldown = 918,
			TechBaseChargeThreshold = 919,
			TechMaxChargeThreshold = 920,
			TechOverChargeThreshold = 921,
			TechPierceChargeLevel = 922,
			TechPierceEnabled = 923,
			TechnicalAbility = 924,
			ThermalDamage = 925,
			ThermalDamageMax = 926,
			ThermalDamageMin = 927,
			ThermalDamagePercent = 928,
			ThermalResistance = 929,
			ThreeOrMoreProgramsCooldownRedPerk = 930,
			ThreeOrMoreProgramsMemoryRegPerk = 931,
			TimeDilationGenericDuration = 932,
			TimeDilationGenericTimeScale = 933,
			TimeDilationKerenzikovDuration = 934,
			TimeDilationKerenzikovPlayerTimeScale = 935,
			TimeDilationKerenzikovTimeScale = 936,
			TimeDilationOnDodgesCooldownDuration = 937,
			TimeDilationOnDodgesDuration = 938,
			TimeDilationOnDodgesTimeScale = 939,
			TimeDilationOnHealthDropCooldownDuration = 940,
			TimeDilationOnHealthDropDuration = 941,
			TimeDilationOnHealthDropTimeScale = 942,
			TimeDilationSandevistanCooldownBase = 943,
			TimeDilationSandevistanCooldownReduction = 944,
			TimeDilationSandevistanDuration = 945,
			TimeDilationSandevistanTimeScale = 946,
			TimeDilationWhenEnteringCombatCooldownDuration = 947,
			TimeDilationWhenEnteringCombatDuration = 948,
			TimeDilationWhenEnteringCombatTimeScale = 949,
			TriggerDismembermentChance = 950,
			TriggerWoundedChance = 951,
			TurretFriendlyExtension = 952,
			TurretShutdownExtension = 953,
			UltimateHackSpread = 954,
			UltimateHacksCostReduction = 955,
			UltimateMemoryCostReduction = 956,
			UnconsciousImmunity = 957,
			UnequipAnimationDuration_Corpo = 958,
			UnequipAnimationDuration_Gang = 959,
			UnequipDuration = 960,
			UnequipDuration_Corpo = 961,
			UnequipDuration_Gang = 962,
			UnequipItemTime_Corpo = 963,
			UnequipItemTime_Gang = 964,
			UnlockProgress = 965,
			UpgradingCostReduction = 966,
			UpgradingMaterialDropChance = 967,
			UpgradingMaterialRandomGrantChance = 968,
			UpgradingMaterialRetrieveChance = 969,
			UploadQuickHackMod = 970,
			Visibility = 971,
			VisualStimRangeMultiplier = 972,
			VulnerabilityExtension = 973,
			WallRunHorSpeedToEnterMin = 974,
			WallRunStrafeAngleMax = 975,
			WallRunTimeMax = 976,
			WallRunVertSpeedToEnterMax = 977,
			WasItemUpgraded = 978,
			WasQuickHacked = 979,
			WeakspotDamageMultiplier = 980,
			WeaponHasAutoloader = 981,
			WeaponNoise = 982,
			WeaponPosAdsX = 983,
			WeaponPosAdsY = 984,
			WeaponPosAdsZ = 985,
			WeaponPosX = 986,
			WeaponPosY = 987,
			WeaponPosZ = 988,
			WeaponRotAdsX = 989,
			WeaponRotAdsY = 990,
			WeaponRotAdsZ = 991,
			WeaponRotX = 992,
			WeaponRotY = 993,
			WeaponRotZ = 994,
			Weight = 995,
			WoundHeadDamageThreshold = 996,
			WoundLArmDamageThreshold = 997,
			WoundLLegDamageThreshold = 998,
			WoundRArmDamageThreshold = 999,
			WoundRLegDamageThreshold = 1000,
			ZoomLevel = 1001,
			CPO_Armor = 1002,
			CPO_NPC_Importance = 1003,
			Count = 1004,
			Invalid = 1005
		}
		public enum gamedataStatusEffectAIBehaviorFlag
		{
			AcceptsAdditives = 0,
			InterruptsForcedBehavior = 1,
			InterruptsSamePriorityTask = 2,
			None = 3,
			OverridesSelf = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataStatusEffectAIBehaviorType
		{
			Basic = 0,
			None = 1,
			Stoppable = 2,
			Unstoppable = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataStatusEffectType
		{
			AndroidTurnOff = 0,
			AndroidTurnOn = 1,
			Berserk = 2,
			Berserker = 3,
			Bleeding = 4,
			Blind = 5,
			BlockCoverVisibilityReduction = 6,
			BrainMelt = 7,
			Burning = 8,
			Cloaked = 9,
			CommsCall = 10,
			CommsNoise = 11,
			Crippled = 12,
			DamageBurst = 13,
			Deafened = 14,
			Defeated = 15,
			DefeatedWithRecover = 16,
			EMP = 17,
			Electrocuted = 18,
			Exhausted = 19,
			ForceShoot = 20,
			Grapple = 21,
			Jam = 22,
			JamCommuniations = 23,
			Kill = 24,
			Knockdown = 25,
			Madness = 26,
			MeleeInvulnerability = 27,
			Misc = 28,
			MuteAudioStims = 29,
			NetwatcherHackStage1 = 30,
			NetwatcherHackStage2 = 31,
			NetwatcherHackStage3 = 32,
			Overheat = 33,
			Overload = 34,
			Pain = 35,
			PassiveBuff = 36,
			PassiveDebuff = 37,
			PlayerCooldown = 38,
			Poisoned = 39,
			QuickHackFreezeLocomotion = 40,
			QuickHackStaggerCyberware = 41,
			QuickHackStaggerLocomotion = 42,
			QuickHackStaggerWeapon = 43,
			Quickhack = 44,
			Regeneration = 45,
			Sandevistan = 46,
			SetFriendly = 47,
			Sleep = 48,
			Stagger = 49,
			StrongArmsActive = 50,
			Stunned = 51,
			SuicideHack = 52,
			SystemCollapse = 53,
			Unconscious = 54,
			UncontrolledMovement = 55,
			VehicleKnockdown = 56,
			WeakspotOverload = 57,
			Wounded = 58,
			CPOShocked = 59,
			Count = 60,
			Invalid = 61
		}
		public enum gamedataStatusEffectVariation
		{
			Bike = 0,
			Default = 1,
			Vehicle = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataStimPriority
		{
			High = 0,
			Low = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataStimPropagation
		{
			Audio = 0,
			Visual = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataStimType
		{
			AimingAt = 0,
			Alarm = 1,
			AreaEffect = 2,
			AskToFollowOrder = 3,
			Attention = 4,
			AudioEnemyPing = 5,
			Bullet = 6,
			Bump = 7,
			Call = 8,
			CarAlarm = 9,
			CarryBody = 10,
			Combat = 11,
			CombatCall = 12,
			CombatHit = 13,
			CombatWhistle = 14,
			CrimeWitness = 15,
			CrowdIllegalAction = 16,
			DeadBody = 17,
			DeviceExplosion = 18,
			Distract = 19,
			DodgeVehicle = 20,
			Driving = 21,
			Dying = 22,
			EnvironmentalHazard = 23,
			Explosion = 24,
			FootStepRegular = 25,
			FootStepSprint = 26,
			GrenadeLanded = 27,
			Gunshot = 28,
			Hacked = 29,
			HijackVehicle = 30,
			IllegalAction = 31,
			IllegalInteraction = 32,
			LandingHard = 33,
			LandingRegular = 34,
			LandingVeryHard = 35,
			MeleeAttack = 36,
			MeleeHit = 37,
			OpeningDoor = 38,
			ProjectileDistraction = 39,
			Provoke = 40,
			Reload = 41,
			Reprimand = 42,
			ReprimandFinalWarning = 43,
			Scream = 44,
			SecurityBreach = 45,
			SilencedGunshot = 46,
			SilentAlarm = 47,
			SoundDistraction = 48,
			SpreadFear = 49,
			StopedAiming = 50,
			Terror = 51,
			TooCloseDistance = 52,
			VehicleHit = 53,
			VehicleHorn = 54,
			VisualDistract = 55,
			WarningDistance = 56,
			WeaponDisplayed = 57,
			WeaponHolstered = 58,
			WeaponSafe = 59,
			Whistle = 60,
			Count = 61,
			Invalid = 62
		}
		public enum gamedataSubCharacter
		{
			Flathead = 0,
			Count = 1,
			Invalid = 2
		}
		public enum gamedataTrackingMode
		{
			BeliefPosition = 0,
			LastKnownPosition = 1,
			RealPosition = 2,
			SharedBeliefPosition = 3,
			SharedLastKnownPosition = 4,
			Count = 5,
			Invalid = 6
		}
		public enum gamedataTraitType
		{
			AssaultTrait01 = 0,
			AthleticsTrait01 = 1,
			BrawlingTrait01 = 2,
			ColdBloodTrait01 = 3,
			CombatHackingTrait01 = 4,
			CraftingTrait01 = 5,
			DemolitionTrait01 = 6,
			EngineeringTrait01 = 7,
			GunslingerTrait01 = 8,
			HackingTrait01 = 9,
			KenjutsuTrait01 = 10,
			StealthTrait01 = 11,
			Count = 12,
			Invalid = 13
		}
		public enum gamedataTriggerMode
		{
			Burst = 0,
			Charge = 1,
			FullAuto = 2,
			Lock = 3,
			SemiAuto = 4,
			Windup = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataTweakDBType
		{
			Invalid = 0,
			ForeignKey = 1,
			Int = 2,
			Float = 3,
			Bool = 4,
			String = 5,
			CName = 6,
			ResRef = 7,
			LocKey = 8,
			Color = 9,
			Vector2 = 10,
			Vector3 = 11,
			EulerAngles = 12,
			Quaternion = 13
		}
		public enum gamedataUICondition
		{
			InEyesSubMenu = 0,
			InHandsSubMenu = 1,
			InSubMenu = 2,
			Visible = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataUIIconCensorFlag
		{
			Drugs = 0,
			Gore = 1,
			Homosexuality = 2,
			None = 3,
			Nudity = 4,
			OverSexualised = 5,
			Religion = 6,
			Suggestive = 7,
			Count = 8,
			Invalid = 9
		}
		public enum gamedataUINameplateDisplayType
		{
			AfterScan = 0,
			Always = 1,
			Default = 2,
			Never = 3,
			Count = 4,
			Invalid = 5
		}
		public enum gamedataVariableNodeVariableValueDeriveInfo
		{
			NotDerived = 0,
			ArrayAddition = 1
		}
		public enum gamedataVehicleManufacturer
		{
			Arch = 0,
			Archer = 1,
			Aurochs = 2,
			Brennan = 3,
			Chevillon = 4,
			Delamain = 5,
			Herrera = 6,
			Kaukaz = 7,
			Makigai = 8,
			Militech = 9,
			Mizutani = 10,
			Porsche = 11,
			Quadra = 12,
			Rayfield = 13,
			Seamurai = 14,
			Thorton = 15,
			Villefort = 16,
			Yaiba = 17,
			Zetatech = 18,
			Count = 19,
			Invalid = 20
		}
		public enum gamedataVehicleModel
		{
			Aerondight = 0,
			Alvarado = 1,
			Basilisk = 2,
			Bratsk = 3,
			Colby = 4,
			Columbus = 5,
			Cortes = 6,
			Emperor = 7,
			Galena = 8,
			GalenaNomad = 9,
			Kusanagi = 10,
			Mackinaw = 11,
			Maimai = 12,
			Octant = 13,
			Shion = 14,
			Supron = 15,
			Thrax = 16,
			Turbo = 17,
			Type66 = 18,
			Zeya = 19,
			Count = 20,
			Invalid = 21
		}
		public enum gamedataVehicleType
		{
			Bike = 0,
			Car = 1,
			Panzer = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataVendorType
		{
			Armorsmith = 0,
			Clothes = 1,
			Clothing = 2,
			Cyberware = 3,
			Drinks = 4,
			DropPoint = 5,
			Food = 6,
			GrilledFood = 7,
			Gunsmith = 8,
			Junk = 9,
			Kiosk = 10,
			Market = 11,
			Medical = 12,
			PackedFood = 13,
			RipperDoc = 14,
			SkillTrainer = 15,
			Tech = 16,
			TechJunk = 17,
			VendingMachine = 18,
			Count = 19,
			Invalid = 20
		}
		public enum gamedataWeaponEvolution
		{
			Blade = 0,
			Blunt = 1,
			None = 2,
			Power = 3,
			Smart = 4,
			Tech = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataWeaponManufacturer
		{
			Corporation = 0,
			Street = 1,
			Count = 2,
			Invalid = 3
		}
		public enum gamedataWorkspotActionType
		{
			DeviceInvestigation = 0,
			FearHide = 1,
			LookAround = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gamedataWorkspotCategory
		{
			Any = 0,
			Eating = 1,
			Nervous = 2,
			Sitting = 3,
			Sleeping = 4,
			Smoking = 5,
			Count = 6,
			Invalid = 7
		}
		public enum gamedataWorkspotReactionType
		{
			Anger = 0,
			BumpLeftBack = 1,
			BumpLeftFront = 2,
			BumpRightBack = 3,
			BumpRightFront = 4,
			Curious = 5,
			Fear = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gamedataWorldMapFilter
		{
			All = 0,
			DropPoint = 1,
			FastTravel = 2,
			NoFilter = 3,
			Quest = 4,
			ServicePoint = 5,
			Story = 6,
			Count = 7,
			Invalid = 8
		}
		public enum gameDebugViewETextAlignment
		{
			Left = -1,
			Center = 0,
			Right = 1
		}
		public enum gameDelayContext
		{
			Standard_TD = 1,
			Standard_ND = 2,
			Quest_TD = 4,
			SpawnManager_ND = 8
		}
		public enum gamedeviceActionPropertyFlags
		{
			None = 0,
			IsUsedByQuest = 1
		}
		public enum gamedeviceRequestType
		{
			None = 0,
			External = 1,
			Remote = 2,
			Direct = 3,
			Internal = 4
		}
		public enum gameDifficulty
		{
			Easy = 0,
			Hard = 1,
			VeryHard = 2,
			Story = 3
		}
		public enum gameDismBodyPart
		{
			HEAD = 1,
			LEFT_ARM = 14,
			RIGHT_ARM = 112,
			LEFT_LEG = 896,
			RIGHT_LEG = 7168,
			BODY = 8192
		}
		public enum gameDismWoundType
		{
			CLEAN = 1,
			COARSE = 2,
			HOLE = 64
		}
		public enum gameEActionFlags
		{
			NONE = 0,
			USE_ANIMATION = 1,
			USE_MOVEMENT = 2
		}
		public enum gameEActionStatus
		{
			STATUS_INVALID = 0,
			STATUS_BOUND = 1,
			STATUS_READY = 2,
			STATUS_PROGRESS = 3,
			STATUS_COMPLETE = 4,
			STATUS_FAILURE = 5
		}
		public enum gameEAreaShape
		{
			NONE = 0,
			SPHERE = 1,
			CUBE = 2,
			COUNT = 3
		}
		public enum gameEAreaType
		{
			NONE = 0,
			LOCATION = 1,
			AFFILIATION = 2,
			COUNT = 3
		}
		public enum gameECharacterStance
		{
			Stance_Stand = 0,
			Stance_Crouch = 1,
			Stance_Kneel = 2,
			Stance_Cover = 3,
			Stance_Standing_Cover = 4,
			Stance_Crouching_Cover = 5
		}
		public enum gameEContinuousMode
		{
			None = 0,
			Start = 1,
			Stop = 2
		}
		public enum gameEEquipmentManagerState
		{
			InfiniteAmmo = 1
		}
		public enum gameEffectAction_KillFXAction
		{
			Stop = 0,
			BreakLoop = 1
		}
		public enum gameEffectExecutor_AnimFeatureApplyTo
		{
			Target = 0,
			Instigator = 1
		}
		public enum gameEffectHitDataType
		{
			Entity = 0,
			Node = 1,
			Static = 2
		}
		public enum gameEffectObjectFilter_AxisRangeAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}
		public enum gameEffectObjectFilter_HitTypeAction
		{
			Accept = 0,
			Reject = 1
		}
		public enum gameEffectTriggerPositioningType
		{
			PlayerRoot = 0,
			CameraRoot = 1,
			AtSpawn = 2,
			XYCameraZPlayer = 3,
			XYPlayerZCamera = 4,
			XYCameraZTerrain = 5,
			XYPlayerZTerrain = 6
		}
		public enum gameEffectTriggerRotationType
		{
			None = 0,
			AtSpawn = 1,
			Continuous = 2
		}
		public enum gameEHotkey
		{
			INVALID = -1,
			DPAD_UP = 0,
			DPAD_DOWN = 1,
			DPAD_RIGHT = 2,
			RB = 3
		}
		public enum gameEInventoryFlags
		{
			MustSave = 1
		}
		public enum gameELootGenerationType
		{
			DropChance = 0,
			NumberBased = 1,
			Weights = 2,
			Count = 3
		}
		public enum gameEMaterialZone
		{
			Zero = 0,
			One = 1,
			Two = 2,
			Three = 3
		}
		public enum gameEnemyStealthAwarenessState
		{
			Relaxed = 0,
			Aware = 1,
			Alerted = 2,
			Combat = 3
		}
		public enum gameEntityReferenceType
		{
			EntityRef = 0,
			Tag = 1,
			SlotID = 2,
			SceneActorContextName = 3
		}
		public enum gameEntitySpawnerEventType
		{
			Spawn = 2,
			Despawn = 3,
			Death = 4
		}
		public enum gameEPrerequisiteType
		{
			None = 0,
			NestedPrereq = 1,
			StatValue = 2,
			StatPoolValue = 3,
			HealthAbsolute = 4,
			HealthPercent = 5,
			ItemInInventory = 6,
			ItemEquipped = 7,
			ItemCount = 8,
			QuestAchieved = 9,
			WasScanned = 10,
			Attitude = 11,
			Count = 12
		}
		public enum gameEquipAnimationType
		{
			Default = 0,
			Instant = 1,
			FirstEquip = 2
		}
		public enum gameEquipmentSetType
		{
			Offensive = 0,
			Defensive = 1,
			Cyberware = 2
		}
		public enum gameESlotState
		{
			Taken = 0,
			Empty = 1,
			Available = 2
		}
		public enum gameEStatFlags
		{
			Bool = 1,
			EquipOnPlayer = 2,
			EquipOnNPC = 4,
			ExcludeRootCombination = 8
		}
		public enum gameEStatProviderDataSource
		{
			gameItemData = 0,
			InventoryItemData = 1,
			InnerItemData = 2,
			Invalid = 3
		}
		public enum gameeventsDeathDirection
		{
			Undefined = 0,
			Left = 1,
			Backward = 2,
			Right = 3,
			Forward = 4
		}
		public enum gameFearStage
		{
			Relaxed = 0,
			Stressed = 1,
			Alarmed = 2,
			Panic = 3
		}
		public enum gameGameplayEventFlag
		{
			Ai = 1,
			Trigger = 2,
			Component = 4,
			Script = 8
		}
		public enum gameGameVersion
		{
			CP77_Initial = 0,
			CP77_Development = 1,
			CP77_GoldMaster = 2,
			CP77_ActualGoldMaster = 3,
			CP77_AlmostPatchDay0 = 4,
			CP77_PatchDay0 = 5,
			CP77_PatchDay0_Hotfix1 = 6,
			CP77_PatchDay0_Hotfix2 = 7,
			CP77_PatchDay0_Hotfix2_V2 = 8,
			CP77_PatchDay0_Hotfix3 = 9,
			CP77_PatchDay0_Hotfix4 = 10,
			Current = 10,
			CP77_Patch1 = 11
		}
		public enum gameGlobalTierSubtype
		{
			Quest = 0,
			Supervisor = 1
		}
		public enum gameGodModeType
		{
			Invulnerable = 0,
			Immortal = 1,
			Mortal = 3
		}
		public enum gameGOGRewardsSystemErrors
		{
			None = 0,
			RequestFailed = 1,
			TemporaryFailure = 2,
			NoInternetConnection = 3,
			NotSignedInGalaxy = 4,
			NotSignedInLauncher = 5
		}
		public enum gameGOGRewardsSystemStatus
		{
			Uninitialized = 0,
			GeneratingCPID = 1,
			CheckingRegistrationStatus = 2,
			RegistrationPending = 3,
			Registered = 4,
			Error = 5
		}
		public enum gameGrenadeThrowStartType
		{
			Invalid = 0,
			LeftSide = 1,
			RightSide = 2,
			Top = 3,
			Count = 4
		}
		public enum gameinfluenceCollisionTestOutcome
		{
			NoCell = 0,
			Empty = 1,
			Full = 2
		}
		public enum gameinfluenceEBoundingBoxType
		{
			Colider = 0,
			Custom = 1
		}
		public enum gameinfluenceTestLineResult
		{
			Fail = 0,
			Success = 1,
			Unknown = 2
		}
		public enum gameInitalChoiceStage
		{
			None = 0,
			LifePath = 1,
			Gender = 2,
			Customizations = 3,
			Attributes = 4,
			Finished = 5
		}
		public enum gameinputActionType
		{
			BUTTON_PRESSED = 0,
			BUTTON_RELEASED = 1,
			BUTTON_HOLD_PROGRESS = 2,
			BUTTON_HOLD_COMPLETE = 3,
			BUTTON_MULTITAP_BEGIN_LAST = 4,
			BUTTON_MULTITAP_END_LAST = 5,
			AXIS_CHANGE = 6,
			RELATIVE_CHANGE = 7,
			TOGGLE_PRESSED = 8,
			TOGGLE_RELEASED = 9,
			REPEAT = 10
		}
		public enum gameinteractionsBumpIntensity
		{
			Invalid = 0,
			Light = 1,
			Medium = 2,
			Heavy = 3,
			Strafe = 4
		}
		public enum gameinteractionsBumpLocation
		{
			Invalid = 0,
			Front = 1,
			Back = 2
		}
		public enum gameinteractionsBumpSide
		{
			Invalid = 0,
			Left = 1,
			Right = 2
		}
		public enum gameinteractionsBumpType
		{
			Workspot = 0,
			Crowd = 1
		}
		public enum gameinteractionsChoiceLookAtType
		{
			Root = 0,
			Slot = 1,
			Orb = 2
		}
		public enum gameinteractionsChoiceType
		{
			QuestImportant = 1,
			AlreadyRead = 2,
			Inactive = 4,
			CheckSuccess = 8,
			CheckFailed = 16,
			InnerDialog = 32,
			PossessedDialog = 64,
			TimedDialog = 128,
			Blueline = 256,
			Pay = 512,
			Selected = 1024,
			Illegal = 2048
		}
		public enum gameinteractionsEBinaryOperator
		{
			EBinaryOperator_and = 0,
			EBinaryOperator_or = 1
		}
		public enum gameinteractionsEGroupType
		{
			EGT_default = 0,
			EGT_noInput = 1,
			EGT_hint = 2
		}
		public enum gameinteractionsEInteractionEventType
		{
			EIET_activate = 0,
			EIET_deactivate = 1
		}
		public enum gameinteractionsELookAtTarget
		{
			Entity = 0,
			Component = 1
		}
		public enum gameinteractionsELookAtTest
		{
			Targeting = 0,
			Interaction = 1
		}
		public enum gameinteractionsELootChoiceType
		{
			Available = 0,
			Unavailable = 1,
			Invisible = 2
		}
		public enum gameinteractionsELootVisualiserControlOperation
		{
			Locked = 1
		}
		public enum gameinteractionsEPredicateType
		{
			EPredicateFunction_true = 0,
			EPredicateFunction_distanceFromScreenCentre = 1,
			EPredicateFunction_containedInShapes = 2,
			EPredicateFunction_onScreenTest = 3,
			EPredicateFunction_visibleTarget = 4,
			EPredicateFunction_lineOfSight = 4,
			EPredicateFunction_lookAt = 5,
			EPredicateFunction_lookAtComponent = 6,
			EPredicateFunction_logicalLookAt = 7,
			EPredicateFunction_obstructedLookAt = 8
		}
		public enum gameinteractionsEUnaryOperator
		{
			EUnaryOperator_empty = 0,
			EUnaryOperator_not = 1
		}
		public enum gameinteractionsReactionState
		{
			Idle = 0,
			Starting = 1,
			InInteraction = 2,
			Finishing = 3,
			Canceling = 4
		}
		public enum gameinteractionsvisEVisualizerActivityState
		{
			None = 0,
			Visible = 1,
			Available = 2,
			Active = 3
		}
		public enum gameinteractionsvisEVisualizerDefinitionFlags
		{
			None = 0,
			Fading = 1,
			HeadlineSelection = 2,
			QuestImportant = 8,
			CPO_Mode = 16
		}
		public enum gameinteractionsvisEVisualizerRuntimeFlags
		{
			None = 0,
			Locked = 1,
			Failsafe = 2,
			Dbg_Active = 4
		}
		public enum gameinteractionsvisEVisualizerType
		{
			Device = 0,
			Dialog = 1,
			Loot = 2,
			Invalid = 3
		}
		public enum gameinteractionsvisInteractionType
		{
			LookAt = 0,
			Proximity = 1
		}
		public enum gameInventoryItemAttachmentType
		{
			Generic = 0,
			Dedicated = 1
		}
		public enum gameInventoryItemShape
		{
			SingleSlot = 0,
			DoubleSlot = 1
		}
		public enum gameItemComparisonState
		{
			Default = 0,
			NoChange = 1,
			Better = 2,
			Worse = 3
		}
		public enum gameItemDisplayContext
		{
			None = 0,
			Vendor = 1,
			Tooltip = 2,
			VendorPlayer = 3,
			GearPanel = 4,
			Backpack = 5,
			DPAD_RADIAL = 6,
			Attachment = 7,
			Ripperdoc = 8
		}
		public enum gameItemEquipContexts
		{
			LastWeaponEquipped = 0,
			LastUsedMeleeWeapon = 1,
			LastUsedRangedWeapon = 2,
			Gadget = 3,
			MeleeCyberware = 4,
			LauncherCyberware = 5,
			Fists = 6
		}
		public enum gameItemIconGender
		{
			Female = 0,
			Male = 1
		}
		public enum gameItemUnequipContexts
		{
			AllWeapons = 0,
			HeadClothing = 1,
			FaceClothing = 2,
			OuterChestClothing = 3,
			InnerChestClothing = 4,
			LegClothing = 5,
			FootClothing = 6,
			AllClothing = 7,
			RightHandWeapon = 8,
			LeftHandWeapon = 9,
			AllQuestItems = 10,
			AllItems = 11
		}
		public enum gameJournalBriefingContentType
		{
			MapLocation = 0,
			VideoContent = 1,
			Paperdoll = 2
		}
		public enum gameJournalCallbackOption
		{
			DoNotFire = 0,
			Fire = 1
		}
		public enum gameJournalChangeType
		{
			Undefined = 0,
			Direct = 1,
			Indirect = 2,
			IndirectDependent = 3
		}
		public enum gameJournalEntryState
		{
			Undefined = 0,
			Inactive = 1,
			Active = 2,
			Succeeded = 3,
			Failed = 4
		}
		public enum gameJournalEntryUserState
		{
			Undefined = 0,
			Inactive = 1,
			Active = 2,
			Succeeded = 3,
			Failed = 4,
			Read = 5,
			Open = 6
		}
		public enum gameJournalListenerType
		{
			State = 0,
			Visited = 1,
			Tracked = 2,
			Untracked = 3,
			Counter = 4
		}
		public enum gameJournalNotifyOption
		{
			Undefined = 0,
			DoNotNotify = 1,
			Notify = 2
		}
		public enum gameJournalQuestType
		{
			MainQuest = 0,
			SideQuest = 1,
			MinorQuest = 2,
			StreetStory = 3,
			Contract = 4,
			VehicleQuest = 5
		}
		public enum gameKillType
		{
			Normal = 0,
			Defeat = 1
		}
		public enum gameLootItemType
		{
			Default = 0,
			Quest = 1,
			Shard = 2
		}
		public enum gameLoSMode
		{
			Invalid = 0,
			Keep = 1,
			Avoid = 2
		}
		public enum gamemappinsMappinTargetType
		{
			World = 0,
			Minimap = 1,
			Map = 2
		}
		public enum gamemappinsVerticalPositioning
		{
			Above = 0,
			Same = 1,
			Below = 2
		}
		public enum gameMessageSender
		{
			NPC = 0,
			Player = 1
		}
		public enum gameMountDescriptorMountType
		{
			Unmounted = 0,
			KeepState = 1,
			Vehicle = 3,
			MovingPlatform = 4
		}
		public enum gameMountingObjectType
		{
			Invalid = -1,
			Object = 0,
			Vehicle = 1,
			Puppet = 2,
			Platform = 3
		}
		public enum gameMountingRelationshipType
		{
			Invalid = -1,
			Parent = 0,
			Child = 1
		}
		public enum gameMountingSlotRole
		{
			Invalid = -1,
			Driver = 0,
			Passenger = 1
		}
		public enum gameMovingPlatformLoopType
		{
			NoLooping = 0,
			Bounce = 1,
			Repeat = 2
		}
		public enum gameMovingPlatformMovementInitializationType
		{
			Time = 0,
			Speed = 1
		}
		public enum gameMuppetComparisonReportItemType
		{
			Different = 0,
			WithinTolerance = 1,
			Equal = 2
		}
		public enum gameMuppetDebugCommand
		{
			None = 0,
			Kill = 1,
			KillAll = 2
		}
		public enum gameMuppetInputActionType
		{
			Unknown = 0,
			Impulse = 1,
			Press = 2
		}
		public enum gameMuppetMoveStyle
		{
			Invalid = 0,
			Walk = 1,
			Sprint = 2,
			Crouch = 3,
			WalkAim = 4,
			GravityOnly = 5
		}
		public enum gamePlatformMovementState
		{
			Stopped = 0,
			Paused = 1,
			MovingUp = 2,
			MovingDown = 3
		}
		public enum gamePlayerCoverDirection
		{
			None = -1,
			Up = 0,
			Left = 1,
			Right = 2
		}
		public enum gamePlayerCoverMode
		{
			None = 0,
			Auto = 1,
			Manual = 2
		}
		public enum gamePlayerObstacleSystemQueryType
		{
			Climb_Vault = 0,
			Covers = 1,
			AverageNormal = 2
		}
		public enum gamePlayerStateMachine
		{
			Locomotion = 0,
			UpperBody = 1,
			Weapon = 2,
			HighLevel = 3,
			Projectile = 4,
			Vision = 5,
			TimeDilation = 6,
			CoverAction = 7,
			IconicItem = 8,
			Combat = 9,
			Vehicle = 10,
			Takedown = 11
		}
		public enum GameplayTier
		{
			Undefined = 0,
			Tier1_FullGameplay = 1,
			Tier2_StagedGameplay = 2,
			Tier3_LimitedGameplay = 3,
			Tier4_FPPCinematic = 4,
			Tier5_Cinematic = 5
		}
		public enum gamePopulationEntityPriority
		{
			Quest = 0,
			Community = 1,
			Crowd = 2
		}
		public enum gamePopupPosition
		{
			Undefined = 0,
			UpperRight = 1,
			UpperLeft = 2,
			LowerLeft = 3,
			LowerRight = 4,
			Center = 5
		}
		public enum gameprojectileELaunchMode
		{
			Default = 0,
			FromLogic = 1,
			FromVisuals = 2
		}
		public enum gameprojectileOnCollisionAction
		{
			None = 0,
			Stop = 1,
			Bounce = 2,
			StopAndStick = 3,
			StopAndStickPerpendicular = 4,
			Pierce = 5
		}
		public enum gameprojectileParabolicUnknownVariable
		{
			TargetPoint = 0,
			VelocityValue = 1,
			Accel = 2
		}
		public enum gamePSMBodyCarrying
		{
			Any = -1,
			Default = 0,
			PickUp = 1,
			Carry = 2,
			Dispose = 3,
			Drop = 4
		}
		public enum gamePSMBodyCarryingLocomotion
		{
			Default = 0,
			Jump = 1,
			Crouch = 2,
			Sprint = 3,
			Fall = 4,
			Land = 5,
			DropBody = 6
		}
		public enum gamePSMBodyCarryingStyle
		{
			Any = 0,
			Default = 1,
			Friendly = 2,
			Strong = 3
		}
		public enum gamePSMCombat
		{
			Any = -1,
			Default = 0,
			InCombat = 1,
			OutOfCombat = 2,
			Stealth = 3
		}
		public enum gamePSMCombatGadget
		{
			Default = 0,
			EquipRequest = 1,
			Equipped = 2,
			Charging = 3,
			Throwing = 4,
			WaitForUnequip = 5,
			QuickThrow = 6
		}
		public enum gamePSMCover
		{
			Any = -1,
			Default = 0,
			InCover = 1,
			Peek = 2,
			Lean = 3,
			OutOfCover = 4
		}
		public enum gamePSMCrosshairStates
		{
			Default = 0,
			Safe = 1,
			Scanning = 2,
			GrenadeCharging = 3,
			Aim = 4,
			Reload = 5,
			Sprint = 6,
			HipFire = 7,
			LeftHandCyberware = 8,
			QuickHack = 9
		}
		public enum gamePSMDetailedBodyDisposal
		{
			Default = 0,
			Dispose = 1,
			Lethal = 2,
			NonLethal = 3
		}
		public enum gamePSMDetailedLocomotionStates
		{
			NotInBaseLocomotion = 0,
			Stand = 1,
			AimWalk = 2,
			Crouch = 3,
			Sprint = 4,
			Slide = 5,
			SlideFall = 6,
			Dodge = 7,
			Climb = 8,
			Vault = 9,
			Ladder = 10,
			LadderSprint = 11,
			LadderSlide = 12,
			LadderJump = 13,
			Fall = 14,
			AirThrusters = 15,
			AirHover = 16,
			SuperheroFall = 17,
			Jump = 18,
			DoubleJump = 19,
			ChargeJump = 20,
			HoverJump = 21,
			DodgeAir = 22,
			RegularLand = 23,
			HardLand = 24,
			VeryHardLand = 25,
			DeathLand = 26,
			SuperheroLand = 27,
			SuperheroLandRecovery = 28,
			Knockdown = 29
		}
		public enum gamePSMFallStates
		{
			Default = 0,
			RegularFall = 1,
			SafeFall = 2,
			FastFall = 3,
			VeryFastFall = 4,
			DeathFall = 5
		}
		public enum gamePSMHighLevel
		{
			Any = -1,
			Default = 0,
			SceneTier1 = 1,
			SceneTier2 = 2,
			SceneTier3 = 3,
			SceneTier4 = 4,
			SceneTier5 = 5
		}
		public enum gamePSMLandingState
		{
			Default = 0,
			RegularLand = 1,
			HardLand = 2,
			VeryHardLand = 3,
			DeathLand = 4,
			SuperheroLand = 5,
			SuperheroLandRecovery = 6
		}
		public enum gamePSMLeftHandCyberware
		{
			Default = 0,
			Safe = 1,
			EquipRequest = 2,
			Idle = 3,
			Equipped = 4,
			Charge = 5,
			Loop = 6,
			Catch = 7,
			QuickAction = 8,
			ChargeAction = 9,
			CatchAction = 10,
			StartUnequip = 11,
			Unequip = 12
		}
		public enum gamePSMLocomotionStates
		{
			Any = -1,
			Default = 0,
			Crouch = 1,
			Sprint = 2,
			Kereznikov = 3,
			Jump = 5
		}
		public enum gamePSMMelee
		{
			Any = -1,
			Default = 0,
			Attack = 1,
			Block = 2
		}
		public enum gamePSMMeleeWeapon
		{
			NotReady = 0,
			Idle = 1,
			Safe = 2,
			PublicSafe = 3,
			Parried = 4,
			Hold = 5,
			ChargedHold = 6,
			Block = 7,
			Targeting = 8,
			Deflect = 9,
			ComboAttack = 10,
			FinalAttack = 11,
			StrongAttack = 12,
			SafeAttack = 13,
			BlockAttack = 14,
			SprintAttack = 15,
			CrouchAttack = 16,
			JumpAttack = 17,
			ThrowAttack = 18,
			DeflectAttack = 19,
			EquipAttack = 20,
			Default = 21
		}
		public enum gamePSMNanoWireLaunchMode
		{
			Default = 0,
			Primary = 1,
			Secondary = 2
		}
		public enum gamePSMRangedWeaponStates
		{
			Default = 0,
			Charging = 1,
			Reload = 2,
			QuickMelee = 3,
			NoAmmo = 4,
			Ready = 5,
			Safe = 6,
			Overheat = 7,
			Shoot = 8
		}
		public enum gamePSMReaction
		{
			Default = 0,
			Stagger = 1
		}
		public enum gamePSMStamina
		{
			Rested = 0,
			Exhausted = 1
		}
		public enum gamePSMSwimming
		{
			Any = -1,
			Default = 0,
			Surface = 1,
			Diving = 2
		}
		public enum gamePSMTakedown
		{
			Any = -1,
			Default = 0,
			EnteringGrapple = 1,
			Grapple = 2,
			Leap = 3,
			Takedown = 4
		}
		public enum gamePSMTimeDilation
		{
			Any = -1,
			Default = 0,
			Sandevistan = 1
		}
		public enum gamePSMUIState
		{
			None = 0,
			WeaponSelect = 1
		}
		public enum gamePSMUpperBodyStates
		{
			Any = -1,
			Default = 0,
			SwitchItems = 1,
			SwitchCyberware = 2,
			Reload = 3,
			Aim = 4
		}
		public enum gamePSMVehicle
		{
			Any = -1,
			Default = 0,
			Driving = 1,
			Combat = 2,
			Passenger = 3,
			Transition = 4,
			Turret = 5,
			DriverCombat = 6,
			Scene = 7
		}
		public enum gamePSMVision
		{
			Any = -1,
			Default = 0,
			Focus = 1
		}
		public enum gamePSMVisionDebug
		{
			Default = 0,
			VisionToggle = 1
		}
		public enum gamePSMVitals
		{
			Alive = 0,
			Dead = 1,
			Resurrecting = 2
		}
		public enum gamePSMWeaponStates
		{
			Any = -1,
			Default = 0,
			NoAmmo = 1,
			Ready = 2,
			Safe = 3
		}
		public enum gamePSMWhip
		{
			Default = 0,
			Charging = 1,
			Pulling = 2
		}
		public enum gamePSMWorkspotState
		{
			Default = 0,
			Workspot = 1
		}
		public enum gamePSMZones
		{
			Any = -1,
			Default = 0,
			Public = 1,
			Safe = 2,
			Restricted = 3,
			Dangerous = 4
		}
		public enum gamePuppetVehicleState
		{
			IdleMounted = 0,
			IdleStand = 1,
			CombatWindowed = 2,
			CombatSeated = 3,
			Turret = 4,
			GunnerSlot = 5
		}
		public enum gameQuestGuidanceMarkerPathfindingType
		{
			Auto = 0,
			Navmesh = 1,
			Traffic = 2
		}
		public enum gameRegular1v1FinisherScenarioPivotSetting
		{
			AttackerSlidesAndRotates_TargetStandsStill = 0,
			AttackerStandsStill_TargetSlidesAndRotates = 1
		}
		public enum gameReprimandMappinAnimationState
		{
			None = 0,
			Normal = 1,
			Fast = 2
		}
		public enum gameSaveLockReason
		{
			Nothing = 0,
			Combat = 1,
			Scene = 2,
			Quest = 3,
			Script = 4,
			Boundary = 5,
			MainMenu = 6,
			LoadingScreen = 7,
			PlayerStateMachine = 8,
			PlayerState = 9,
			Tier = 10,
			NotEnoughSlots = 11,
			NotEnoughSpace = 12,
			PlayerOnMovingPlatform = 13
		}
		public enum gameScanningMode
		{
			Inactive = 0,
			Light = 1,
			Heavy = 2
		}
		public enum gameScanningState
		{
			Default = 0,
			Started = 1,
			Stopped = 2,
			Complete = 3,
			ShallowComplete = 4,
			Reset = 5
		}
		public enum gameSceneAnimationMotionActionParamsActionPlayDirection
		{
			Forward = 0,
			Backward = 1
		}
		public enum gameSceneAnimationMotionActionParamsEasingType
		{
			Linear = 0,
			SinusoidalEaseInOut = 1,
			QuadraticEaseIn = 2,
			QuadraticEaseOut = 3,
			CubicEaseInOut = 4,
			CubicEaseIn = 5,
			CubicEaseOut = 6
		}
		public enum gameSceneAnimationMotionActionParamsMotionType
		{
			Rid = 0,
			Anim = 1
		}
		public enum gameSceneAnimationMotionActionParamsPlacementMode
		{
			Blend = 0,
			TeleportToStart = 1,
			PlayAtActorPosition = 2
		}
		public enum gameScriptedBlackboardStorage
		{
			Default = 0
		}
		public enum gameSharedInventoryTag
		{
			None = 0,
			PlayerStash = 1000000
		}
		public enum gamesmartGunTargetState
		{
			Visible = 0,
			Targetable = 1,
			Locking = 2,
			Locked = 3,
			Unlocking = 4
		}
		public enum gameSmartObjectInstanceEntryType
		{
			UseEntryAnimation = 0,
			UseLocomotion = 1
		}
		public enum gameSmartObjectPointType
		{
			Entry = 0,
			Exit = 1,
			Action = 2
		}
		public enum gameSmartObjectType
		{
			Default = 0,
			LadderUp = 1,
			LadderDown = 2,
			JumpOnSameLevel = 3,
			Jump3mUp = 4,
			Jump3mDown = 5,
			Climb110cmUp = 6,
			Climb110cmDown = 7,
			Climb200cmUp = 8,
			Climb200cmDown = 9,
			Climb300cmUp = 10,
			Climb300cmDown = 11,
			Vault10cm = 12,
			Vault40cm = 13,
			Vault100cm = 14,
			ChargedJump400cmUp = 15,
			ChargedJump400cmDown = 16,
			ChargedJump600cmUp = 17,
			ChargedJump600cmDown = 18,
			ChargedJump800cmUp = 19,
			ChargedJump800cmDown = 20,
			ThrusterJumpUp = 21,
			ThrusterJumpDown = 22,
			Climb400cmDown = 23
		}
		public enum gameSpawnInViewState
		{
			[RED("default (true)")] default__true_ = 0,
			[RED("true")] _true = 1,
			[RED("false")] _false = 2
		}
		public enum gamestateMachineParameterAspect
		{
			Temporary = 0,
			Permanent = 1,
			Conditional = 2
		}
		public enum gameStatIDType
		{
			EntityID = 0,
			ItemID = 1,
			Invalid = 2
		}
		public enum gameStatModifierType
		{
			Additive = 0,
			AdditiveMultiplier = 1,
			Multiplier = 2,
			Count = 3,
			Invalid = 4
		}
		public enum gameStatObjectsRelation
		{
			Self = 0,
			Owner = 1,
			Root = 2,
			Parent = 3,
			Target = 4,
			Player = 5,
			Instigator = 6,
			Count = 7,
			Invalid = 9
		}
		public enum gameStatPoolDataBonusType
		{
			None = 0,
			Persistent = 1,
			NonPersistent = 2
		}
		public enum gameStatPoolDataStatPoolModificationStatus
		{
			Regeneration = 0,
			Decay = 1,
			NoModification = 2
		}
		public enum gameStatPoolDataValueChangeMode
		{
			Normal = 0,
			IncreasingOnly = 1,
			DecreasingOnly = 2,
			NonZero = 3
		}
		public enum gameStatPoolModificationTypes
		{
			Regeneration = 0,
			Decay = 1
		}
		public enum gameStatPoolModifierProperty
		{
			RangeBegin = 0,
			RangeEnd = 1,
			StartDelay = 2,
			ValuePerSec = 3,
			Enabled = 4,
			DelayOnChange = 5,
			Count = 6
		}
		public enum gameStatsBundleOwnerType
		{
			None = 0,
			Cleared = 1,
			UniqueItem = 2,
			StackableItem = 3,
			InnerItem = 4,
			Entity = 5,
			Stub = 6,
			Reinitialized = 7,
			Count = 8,
			Invalid = 9
		}
		public enum gameStoryTier
		{
			Gameplay = 0,
			Cinematic = 1
		}
		public enum gameTargetingSet
		{
			Visible = 0,
			Frustum = 2,
			Complete = 3,
			None = 4
		}
		public enum gametargetingSystemETargetFilterStatus
		{
			Stop = 0,
			Continue = 1
		}
		public enum gametargetingSystemScriptFilter
		{
			Melee = 1,
			Shooting = 2,
			Scanning = 4,
			QuickHack = 8,
			ShootingLimbCyber = 16,
			HeadTarget = 32,
			LegTarget = 64,
			MechanicalTarget = 128
		}
		public enum gametargetingSystemSearchFilterMaskValue
		{
			Obj_Player = 1,
			Obj_Puppet = 2,
			Obj_Sensor = 4,
			Obj_Device = 8,
			Obj_Other = 16,
			Att_Friendly = 32,
			Att_Hostile = 64,
			Att_Neutral = 128,
			Sp_AimAssistEnabled = 256,
			Sp_Aggressive = 512,
			St_Alive = 2048,
			St_Dead = 4096,
			St_NotDefeated = 8192,
			St_Defeated = 16384,
			St_Conscious = 32768,
			St_Unconscious = 65536,
			St_TurnedOn = 131072,
			St_AliveAndActive = 174080,
			St_TurnedOff = 262144,
			St_QuickHackable = 524288
		}
		public enum gameTelemetryDamageSituation
		{
			Irrelevant = 0,
			EnemyToPlayer = 1,
			EnemyToCompanion = 2,
			PlayerToEnemy = 3,
			CompanionToEnemy = 4
		}
		public enum gameTelemetryMilestoneType
		{
			StartFact = 0,
			ImportantFact = 1,
			Reward = 2,
			EndReward = 3,
			EndFact = 4,
			Invalid = 5
		}
		public enum gameTickableEventState
		{
			Idle = 0,
			FirstTick = 1,
			NormalTick = 2,
			LastTick = 3,
			Canceled = 4
		}
		public enum gameTransformAnimation_MoveOnSplineRotationMode
		{
			Disabled = 0,
			Yaw = 1,
			PitchAndYaw = 2
		}
		public enum gameTransformAnimation_RotateOnAxisAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}
		public enum gameTutorialBracketType
		{
			WidgetArea = 0,
			CustomArea = 1
		}
		public enum gameuiAuthorisationNotificationType
		{
			Unknown = 0,
			GotKeycard = 1,
			AccessGranted = 2
		}
		public enum gameuiBaseMenuGameControllerPuppetGenderInfo
		{
			Male = 0,
			Female = 1,
			ShouldBeDetermined = 2
		}
		public enum gameuiBinkVideoStatus
		{
			Idle = 0,
			NotStarted = 1,
			Initializing = 2,
			Playing = 3,
			Finished = 4,
			OutOfFrustum = 5,
			Stopped = 6,
			Error = 7
		}
		public enum gameuiCharacterCustomization_BrokenNoseStage
		{
			CCBN_Disabled = 0,
			CCBN_Stage1 = 1,
			CCBN_Stage2 = 2
		}
		public enum gameuiCharacterCustomizationActionType
		{
			Activate = 0,
			Deactivate = 1,
			EquipItem = 2,
			UnequipItem = 3
		}
		public enum gameuiCharacterCustomizationPart
		{
			Head = 0,
			Body = 1,
			Arms = 2
		}
		public enum gameuiChoiceIndicatorType
		{
			Default = 0,
			Speech = 1,
			Call = 2,
			Arrow = 3,
			Hand = 4,
			Loot = 5,
			Quest = 6,
			FastTravel = 7,
			Solo = 9,
			Netrunner = 10,
			Techie = 12
		}
		public enum gameuiChoiceListVisualizerType
		{
			Interaction = 0,
			Dialog = 1
		}
		public enum gameuiCyberspaceElementType
		{
			CyberspaceNPC = 0,
			CyberspaceFakeObject = 1
		}
		public enum gameuiDamageDigitsMode
		{
			Off = 0,
			Individual = 1,
			Accumulated = 2,
			Both = 3
		}
		public enum gameuiDamageDigitsStickingMode
		{
			None = 0,
			Individual = 1,
			Accumulated = 2,
			Both = 3
		}
		public enum gameuiDamageIndicatorMode
		{
			Off = 0,
			DamageOnly = 1,
			On = 2
		}
		public enum gameuiEBraindanceLayer
		{
			Visual = 0,
			Audio = 1,
			Thermal = 2
		}
		public enum gameuiEClueDescriptorMode
		{
			Invalid = 0,
			Add = 1,
			Finish = 2
		}
		public enum gameuiEIconOrientation
		{
			Upright = 0,
			Entity = 1
		}
		public enum gameuiETooltipPlacement
		{
			LeftCenter = 0,
			RightCenter = 1,
			LeftTop = 2,
			RightTop = 3
		}
		public enum gameuiEWorldMapCameraMode
		{
			TopDown = 0,
			Free = 1,
			ZoomLevels = 2,
			COUNT = 3
		}
		public enum gameuiEWorldMapDistrictView
		{
			None = 0,
			Districts = 1,
			SubDistricts = 2
		}
		public enum gameuiGenericNotificationType
		{
			Generic = 0,
			QuestUpdate = 1,
			Vendor = 3,
			ZoneAlert = 4,
			VehicleAlert = 5,
			PreventionBounty = 6,
			ProgressionView = 7
		}
		public enum gameuiHackingMinigameState
		{
			Unknown = 0,
			InProgress = 1,
			Succeeded = 2,
			Failed = 3
		}
		public enum gameuiHitType
		{
			Miss = 0,
			Glance = 1,
			Hit = 2,
			CriticalHit = 3,
			CriticalHit_x2 = 4
		}
		public enum gameuiMappinGroupState
		{
			Ungrouped = 0,
			Grouped = 1,
			GroupedCollection = 2,
			GroupedHidden = 3
		}
		public enum gameVehicleCommonCurve
		{
			RPMLimit = 0,
			ForcedBrakeForce = 1,
			COUNT = 2
		}
		public enum gameVehicleCurve
		{
			SpeedToWheelMaxTurn = 0,
			InputToWheelMaxTurn = 1,
			SpeedToWheelTurnSpeed = 2,
			InputToWheelTurnSpeed = 3,
			COUNT = 4
		}
		public enum gameVideoType
		{
			Tutorial_720x405 = 0,
			Tutorial_1024x576 = 1,
			Tutorial_1280x720 = 2,
			Tutorial_1360x768 = 3,
			Unknown = 4
		}
		public enum gameVisionModePatternType
		{
			Default = 0,
			Netrunner = 1
		}
		public enum gameVisionModeType
		{
			Default = 0,
			Focus = 1
		}
		public enum gameweaponReloadStatus
		{
			Standard = 0,
			Interrupted = 1
		}
		public enum gameWorkspotSlidingBehaviour
		{
			DontPlayAtResourcePosition = 0,
			PlayAtResourcePosition = 1,
			SlideActorAndRotateDevice = 2
		}
		public enum GenericMessageNotificationResult
		{
			Cancel = 0,
			Confirm = 1,
			OK = 2,
			Yes = 3,
			No = 4
		}
		public enum GenericMessageNotificationType
		{
			OK = 0,
			Confirm = 1,
			Cancel = 2,
			ConfirmCancel = 3,
			YesNo = 4
		}
		public enum GenericNotificationType
		{
			Generic = 0,
			JournalNotification = 1,
			LevelUpNotification = 2,
			VendorNotification = 3,
			ZoneNotification = 4,
			ProgressionNotification = 5,
			CraftingNotification = 6,
			InventoryNotification = 7
		}
		public enum genLevelRandomizerDataSource
		{
			Entries = 0,
			Markers = 1
		}
		public enum GIGIOverrideType
		{
			Default = 0,
			Override_True = 1,
			Override_False = 2
		}
		public enum GpuApieBufferUsageType
		{
			BUT_Default = 0,
			BUT_Immutable = 1,
			BUT_ImmutableInPlace = 2,
			BUT_Readback = 3,
			BUT_Dynamic_Legacy = 4,
			BUT_Transient = 5,
			BUT_Mapped = 6,
			BUT_MAX = 7
		}
		public enum GpuWrapApiBufferGroup
		{
			System = 0,
			MeshResource = 1,
			MeshCustom = 2,
			AutoSpawner = 3,
			Debug = 4,
			DPL = 5,
			Weather = 6,
			ReflectionProbe = 7,
			Skinning = 8,
			Lights = 9,
			Video = 10,
			Particles = 11,
			GIManagerLitProbes = 12,
			GIManagerLookup = 13,
			GIManagerInterpolation = 14,
			GIManagerLitBricks = 15,
			GIManagerLights = 16,
			GIManagerEnvVolume = 17,
			GIProxyBrick = 18,
			GIProxySurfel = 19,
			GIProxyProbes = 20,
			GIProxyFactors = 21,
			GIProxyAcceleration = 22,
			Raytracing = 23,
			RaytracingUpload = 24,
			RaytracingAS = 25,
			Decals = 26,
			Instances = 27,
			Materials = 28,
			Multilayer = 29,
			FrameResources = 30,
			Misc = 31,
			MorphTargets = 32,
			MAX = 33
		}
		public enum GpuWrapApieBufferChunkCategory
		{
			BCC_Staging = 0,
			BCC_Vertex = 1,
			BCC_VertexUAV = 2,
			BCC_Index16Bit = 3,
			BCC_Index32Bit = 4,
			BCC_VertexIndex16Bit = 5,
			BCC_Constant = 6,
			BCC_TypedUAV = 7,
			BCC_Structured = 8,
			BCC_StructuredUAV = 9,
			BCC_StructuredAppendUAV = 10,
			BCC_IndirectUAV = 11,
			BCC_Index16BitUAV = 12,
			BCC_Raw = 13,
			BCC_Invalid = 14
		}
		public enum GpuWrapApieIndexBufferChunkType
		{
			IBCT_IndexUInt = 0,
			IBCT_IndexUShort = 1,
			IBCT_Max = 2
		}
		public enum GpuWrapApieTextureFormat
		{
			TEXFMT_A8_Unorm ,
			TEXFMT_A8,
			TEXFMT_R8_Unorm ,
			TEXFMT_R8 ,
			TEXFMT_L8_Unorm,
			TEXFMT_L8,
			TEXFMT_R8G8_Unorm,
			TEXFMT_R8G8,
			TEXFMT_R8G8B8X8_Unorm,
			TEXFMT_R8G8B8X8,
			TEXFMT_R8G8B8A8_Unorm,
			TEXFMT_R8G8B8A8 ,
			TEXFMT_R8G8B8A8_Snorm,
			TEXFMT_Uint_16_norm,
			TEXFMT_R16_Unorm,
			TEXFMT_R16_Uint,
			TEXFMT_Uint_16,
			TEXFMT_R32_Uint,
			TEXFMT_Uint_32 ,
			TEXFMT_R32G32B32A32_Uint ,
			TEXFMT_Uint_R32G32B32A32 ,
			TEXFMT_R32G32_Uint ,
			TEXFMT_R16G16B16A16_Unorm ,
			TEXFMT_R16G16B16A16_Uint,
			//TEXFMT_Uint_R32G32B32A32,
			TEXFMT_R16G16_Uint,
			TEXFMT_R10G10B10A2,
			TEXFMT_R10G10B10A2_Unorm = 15,
			TEXFMT_R16G16B16A16_Float,
			TEXFMT_Float_R16G16B16A16 = 16,
			TEXFMT_R11G11B10_Float,
			TEXFMT_Float_R11G11B10 = 17,
			TEXFMT_R16G16_Float,
			TEXFMT_Float_R16G16 = 18,
			TEXFMT_R32G32_Float,
			TEXFMT_Float_R32G32 = 19,
			TEXFMT_R32G32B32A32_Float,
			TEXFMT_Float_R32G32B32A32 = 20,
			TEXFMT_R32_Float,
			TEXFMT_Float_R32 = 21,
			TEXFMT_R16_Float,
			TEXFMT_Float_R16 = 22,
			TEXFMT_D24S8 = 23,
			TEXFMT_D32FS8 = 24,
			TEXFMT_D32F = 26,
			TEXFMT_D16U = 27,
			TEXFMT_BC1 = 28,
			TEXFMT_BC2 = 29,
			TEXFMT_BC3 = 30,
			TEXFMT_BC4 = 31,
			TEXFMT_BC5 = 32,
			TEXFMT_BC6H = 33,
			TEXFMT_BC6H_UNSIGNED,
			TEXFMT_BC6H_SIGNED = 34,
			TEXFMT_BC7 = 35,
			TEXFMT_BC7_SRGB = 36,
			TEXFMT_R8_Uint = 37,
			//TEXFMT_R8G8B8A8,
			TEXFMT_R8G8B8A8_Unorm_SRGB = 39,
			TEXFMT_BC1_SRGB = 40,
			TEXFMT_BC2_SRGB = 41,
			TEXFMT_BC3_SRGB = 42,
			TEXFMT_R16G16_Unorm = 43,
			TEXFMT_R16G16_Sint = 44,
			TEXFMT_R16G16_Snorm = 45,
			TEXFMT_B5G6R5_Unorm = 46
		}
		public enum GpuWrapApieTextureGroup
		{
			TEXG_Generic_Color = 1,
			TEXG_Generic_Grayscale = 2,
			TEXG_Generic_Normal = 3,
			TEXG_Generic_Data = 4,
			TEXG_Generic_UI = 5,
			TEXG_Generic_Font = 6,
			TEXG_Generic_LUT = 7,
			TEXG_Generic_MorphBlend = 8,
			TEXG_Multilayer_Color = 9,
			TEXG_Multilayer_Normal = 10,
			TEXG_Multilayer_Grayscale = 11,
			TEXG_Multilayer_Microblend = 12
		}
		public enum GpuWrapApieTextureType
		{
			TEXTYPE_2D = 0,
			TEXTYPE_CUBE = 1,
			TEXTYPE_ARRAY = 2,
			TEXTYPE_3D = 3
		}
		public enum GpuWrapApiVertexPackingePackingType
		{
			PT_Invalid = -1,
			PT_Float1 = 0,
			PT_Float2 = 1,
			PT_Float3 = 2,
			PT_Float4 = 3,
			PT_Float16_2 = 4,
			PT_Float16_4 = 5,
			PT_UShort1 = 6,
			PT_UShort2 = 7,
			PT_UShort4 = 8,
			PT_UShort4N = 9,
			PT_Short1 = 10,
			PT_Short2 = 11,
			PT_Short4 = 12,
			PT_Short4N = 13,
			PT_UInt1 = 14,
			PT_UInt2 = 15,
			PT_UInt3 = 16,
			PT_UInt4 = 17,
			PT_Int1 = 18,
			PT_Int2 = 19,
			PT_Int3 = 20,
			PT_Int4 = 21,
			PT_Color = 22,
			PT_UByte1 = 23,
			PT_UByte1F = 24,
			PT_UByte4 = 25,
			PT_UByte4N = 26,
			PT_Byte4N = 27,
			PT_Dec4 = 28,
			PT_Index16 = 29,
			PT_Index32 = 30,
			PT_Max = 31
		}
		public enum GpuWrapApiVertexPackingePackingUsage
		{
			PS_Invalid = -1,
			PS_SysPosition = 0,
			PS_Position = 1,
			PS_Normal = 2,
			PS_Tangent = 3,
			PS_Binormal = 4,
			PS_TexCoord = 5,
			PS_Color = 6,
			PS_SkinIndices = 7,
			PS_SkinWeights = 8,
			PS_DestructionIndices = 9,
			PS_MultilayerPaint = 10,
			PS_InstanceTransform = 11,
			PS_InstanceLODParams = 12,
			PS_InstanceSkinningData = 13,
			PS_PatchSize = 14,
			PS_PatchBias = 15,
			PS_ExtraData = 16,
			PS_VehicleDmgNormal = 17,
			PS_VehicleDmgPosition = 18,
			PS_PositionDelta = 19,
			PS_LightBlockerIntensity = 20,
			PS_BoneIndex = 21,
			PS_Padding = 22,
			PS_PatchOffset = 23,
			PS_Max = 24
		}
		public enum GpuWrapApiVertexPackingEStreamType
		{
			ST_Invalid = -1,
			ST_PerVertex = 0,
			ST_PerInstance = 1,
			ST_Max = 2
		}
		public enum GrenadeDamageType
		{
			Normal = 0,
			DoT = 1,
			None = 2
		}
		public enum grsDeathmatchStatus
		{
			Waiting = 0,
			AdditionalWaiting = 1,
			Starting = 2,
			InGame = 3,
			Ending = 4,
			Sumup = 5
		}
		public enum grsHeistStatus
		{
			Waiting = 0,
			Starting = 1,
			Lobby = 2,
			InGame = 3,
			Ending = 4,
			Victory = 5,
			Failure = 6
		}
		public enum gsmStateError
		{
			StateError_OK = 0,
			StateError_SettingsCorrupted = 1,
			StateError_SettingsCorrupted_Save = 2,
			StateError_ProfileCorrupted = 3,
			StateError_ProfileCorrupted_Save = 4,
			StateError_CannotInitializeContext = 5,
			StateError_CantInitializeSession = 6,
			StateError_CantLoadSave_CantLoadFile = 7,
			StateError_CantLoadSave_CantCreateLoadStream = 8,
			StateError_CantLoadSave_CensorshipLevelMismatch = 9,
			StateError_CantLoadSave_CensorshipOptionalNudity = 10,
			StateError_CantLoadSave_VersionMismatch = 11,
			StateError_CantLoadSave_Corrupted = 12,
			StateError_CantLoadSave_SessionDescInvalid = 13
		}
		public enum HighlightContext
		{
			DEFAULT = 0,
			OUTLINE = 1,
			FILL = 2,
			FULL = 3
		}
		public enum HighlightMode
		{
			Row = 0,
			Column = 1
		}
		public enum hitFlag
		{
			None = 0,
			IgnoreImmortalityModes = 1,
			FriendlyFire = 2,
			DisableSounds = 3,
			DisableVFX = 4,
			CannotReturnDamage = 5,
			CanParry = 6,
			CanCounter = 7,
			CanDodge = 8,
			WasBlocked = 9,
			WasDeflected = 10,
			WasDodged = 11,
			Kill = 12,
			DontShowDamageFloater = 13,
			DealNoDamage = 14,
			CannotModifyDamage = 15,
			Headshot = 16,
			CriticalHit = 17,
			FinisherTriggered = 18,
			DamageNullified = 19,
			Nonlethal = 20,
			WasKillingBlow = 21,
			ProcessDefeated = 22,
			Defeated = 23,
			SilentKillModifier = 24,
			DeterministicDamage = 25,
			WeakspotHit = 26,
			StealthHit = 27,
			DoNotTriggerFinisher = 28,
			DealtDamage = 29,
			ImmortalTarget = 30,
			CanDamageSelf = 31,
			SuccessfulAttack = 32,
			WeaponFullyCharged = 33,
			DisableNPCHitReaction = 34,
			VehicleDamage = 35,
			VehicleImpact = 36,
			RagdollImpact = 37,
			IgnoreDifficulty = 38,
			QuickHack = 39,
			IgnoreVehicles = 40,
			DamageOverTime = 41,
			PROJECT_SPECIFIC_FLAGS = 100000,
			UsedKerenzikov = 100001,
			FragmentationSplinter = 100002,
			DetonateGrenades = 100003,
			WeakExplosion = 100004,
			GrenadeQuickhackExplosion = 100005,
			FriendlyFireIgnored = 100006,
			ForceNoCrit = 100007,
			ReduceDamage = 100008
		}
		public enum HitShape_Type
		{
			Normal = 0,
			InternalWeakSpot = 1,
			ExternalWeakSpot = 2,
			ProtectionLayer = 3
		}
		public enum HoverStatus
		{
			DEFAULT = 0,
			HOVER = 1
		}
		public enum HubMenuCharacterItems
		{
			Skills = 0,
			Stats = 1
		}
		public enum HubMenuCraftingItems
		{
			Crafting = 0,
			Upgrade = 1
		}
		public enum HubMenuDatabaseItems
		{
			Codex = 0,
			Tarot = 1,
			Shards = 2
		}
		public enum HubMenuInventoryItems
		{
			Gear = 0,
			Cyberware = 1,
			Backpack = 2
		}
		public enum HubMenuItems
		{
			None = -1,
			Crafting = 0,
			Character = 1,
			Inventory = 2,
			Map = 3,
			Journal = 4,
			Phone = 5,
			Database = 6,
			Stats = 7,
			Backpack = 8,
			HubMenuItems = 9,
			Codex = 10,
			Shards = 11,
			Tarot = 12,
			Gear = 13,
			Cyberware = 14,
			Count = 15
		}
		public enum HubVendorMenuItems
		{
			Trade = 0,
			Crafting = 1,
			Cyberware = 2
		}
		public enum HUDActorStatus
		{
			UNINITIALIZED = 0,
			REGISTERED = 1,
			ACTIVE = 2
		}
		public enum HUDActorType
		{
			UNINITIALIZED = 0,
			GAME_OBJECT = 1,
			VEHICLE = 2,
			DEVICE = 3,
			BODY_DISPOSAL_DEVICE = 4,
			PUPPET = 5,
			ITEM = 6
		}
		public enum HUDContext
		{
			DEFAULT = 0,
			FOCUS = 1,
			LOOKEDAT = 2
		}
		public enum HUDState
		{
			UNINITIALIZED = 0,
			DEACTIVATED = 1,
			ACTIVATED = 2
		}
		public enum IMaterialDataProviderDescEParameterType
		{
			PT_None = 0,
			PT_Texture = 1,
			PT_Color = 2,
			PT_Cube = 3,
			PT_Vector = 4,
			PT_Scalar = 5,
			PT_Bool = 6,
			PT_TextureArray = 7,
			PT_StructBuffer = 8,
			PT_Cpu_NameU64 = 9,
			PT_SkinProfile = 10,
			PT_MultilayerSetup = 11,
			PT_MultilayerMask = 12,
			PT_HairProfile = 13,
			PT_FoliageProfile = 14,
			PT_TerrainSetup = 15,
			PT_Gradient = 16,
			PT_MAX = 17
		}
		public enum InGameConfigChangeReason
		{
			Invalid = -1,
			Accepted = 0,
			Rejected = 1,
			NeedsConfirmation = 2,
			NeedsRestart = 3
		}
		public enum InGameConfigNotificationType
		{
			RestartRequiredConfirmed = 0,
			ChangesApplied = 1,
			ChangesRejected = 2,
			ChangesLoadLastCheckpointApplied = 3,
			Saved = 4,
			ErrorSaving = 5,
			RequiresRestart = 6,
			Loaded = 7,
			LoadCanceled = 8,
			Refresh = 10
		}
		public enum InGameConfigUserSettingsLoadStatus
		{
			NotLoaded = 0,
			InternalError = 1,
			FileIsMissing = 2,
			FileIsCorrupted = 3,
			Loaded = 4,
			ImportedFromOldVersion = 5
		}
		public enum InGameConfigUserSettingsSaveStatus
		{
			NotSaved = 0,
			InternalError = 1,
			Saved = 2
		}
		public enum InGameConfigVarType
		{
			Bool = 0,
			Int = 1,
			Float = 2,
			Name = 3,
			IntList = 4,
			FloatList = 5,
			StringList = 6,
			NameList = 7
		}
		public enum InGameConfigVarUpdatePolicy
		{
			Disabled = 0,
			Immediately = 1,
			ConfirmationRequired = 2,
			RestartRequired = 3,
			LoadLastCheckpointRequired = 4
		}
		public enum inkanimEventType
		{
			OnLoaded = 0,
			OnStart = 1,
			OnFinish = 2,
			OnPause = 3,
			OnResume = 4,
			OnStartLoop = 5,
			OnEndLoop = 6
		}
		public enum inkanimInterpolationDirection
		{
			To = 0,
			From = 1,
			FromTo = 2
		}
		public enum inkanimInterpolationMode
		{
			EasyIn = 0,
			EasyOut = 1,
			EasyInOut = 2,
			EasyOutIn = 3
		}
		public enum inkanimInterpolationType
		{
			Linear = 0,
			Quadratic = 1,
			Qubic = 2,
			Quartic = 3,
			Quintic = 4,
			Sinusoidal = 5,
			Exponential = 6,
			Elastic = 7,
			Circular = 8,
			Back = 9
		}
		public enum inkanimLoopType
		{
			None = 0,
			Cycle = 1,
			PingPong = 2
		}
		public enum inkanimPropertyType
		{
			Size = 0,
			Color = 1,
			Margin = 2,
			Padding = 3,
			Transparency = 4,
			Rotation = 5
		}
		public enum inkBrushDrawType
		{
			NoDraw = 0,
			Solid = 1,
			Wire = 2
		}
		public enum inkBrushMirrorType
		{
			NoMirror = 0,
			Horizontal = 1,
			Vertical = 2,
			Both = 3
		}
		public enum inkBrushTileType
		{
			NoTile = 0,
			Horizontal = 1,
			Vertical = 2,
			Both = 3
		}
		public enum inkCacheMode
		{
			Normal = 0,
			Minimap = 1,
			ExternalDynamicTexture = 2
		}
		public enum inkCharacterEventType
		{
			CharInput = 0,
			MoveCaretForward = 1,
			MoveCaretBackward = 2,
			Delete = 3,
			Backspace = 4
		}
		public enum inkCompositionParamType
		{
			FLOAT = 0,
			VECTOR2 = 1
		}
		public enum inkDiscreteNavigationDirection
		{
			Up = 0,
			Right = 1,
			Down = 2,
			Left = 3
		}
		public enum inkDisplayMode
		{
			Invalid = 0,
			Basic = 1,
			Bold = 2,
			Header = 3,
			Single = 4
		}
		public enum inkEAnchor
		{
			TopLeft = 0,
			TopCenter = 1,
			TopRight = 2,
			CenterLeft = 3,
			Centered = 4,
			CenterRight = 5,
			BottomLeft = 6,
			BottomCenter = 7,
			BottomRight = 8,
			TopFillHorizontaly = 9,
			CenterFillHorizontaly = 10,
			BottomFillHorizontaly = 11,
			LeftFillVerticaly = 12,
			CenterFillVerticaly = 13,
			RightFillVerticaly = 14,
			Fill = 15
		}
		public enum inkEBlurDimension
		{
			Horizontal = 0,
			Vertical = 1
		}
		public enum inkEButtonState
		{
			Normal = 0,
			Hover = 1,
			Press = 2,
			Disabled = 3
		}
		public enum inkEChildOrder
		{
			Forward = 0,
			Backward = 1
		}
		public enum inkEEndCapStyle
		{
			BUTT = 0,
			SQUARE = 1,
			ROUND = 2,
			JOINED = 3
		}
		public enum inkEffectType
		{
			ScanlineWipe = 0,
			LinearWipe = 1,
			RadialWipe = 2,
			LightSweep = 3,
			BoxBlur = 4,
			Mask = 5,
			Glitch = 6,
			PointCloud = 7,
			ColorFill = 8,
			InnerGlow = 9,
			ColorCorrection = 10,
			Multisampling = 11
		}
		public enum inkEHorizontalAlign
		{
			Fill = 0,
			Left = 1,
			Center = 2,
			Right = 3
		}
		public enum inkEJointStyle
		{
			MITER = 0,
			BEVEL = 1,
			ROUND = 2
		}
		public enum inkELayerType
		{
			Watermarks = 0,
			SystemNotifications = 1,
			Loading = 2,
			GameNotifications = 3,
			Menu = 4,
			Video = 5,
			HUD = 6,
			Editor = 7,
			World = 8,
			Offscreen = 9,
			Advertisements = 10,
			StreetSigns = 11,
			PhotoMode = 12,
			Debug = 13,
			MAX = 14
		}
		public enum inkEOrientation
		{
			Horizontal = 0,
			Vertical = 1
		}
		public enum inkEScrollDirection
		{
			Vertical = 0,
			Horizontal = 1
		}
		public enum inkEShapeVariant
		{
			Fill = 0,
			Border = 1,
			FillAndBorder = 2
		}
		public enum inkESizeRule
		{
			Fixed = 0,
			Stretch = 1
		}
		public enum inkESliderDirection
		{
			Horizontal = 0,
			Vertical = 1
		}
		public enum inkETextDirection
		{
			LeftToRight = 0,
			RightToLeft = 1,
			Mixed = 2
		}
		public enum inkETextureResolution
		{
			UltraHD_3840_2160 = 0,
			FullHD_1920_1080 = 1,
			HD_1280_720 = 2
		}
		public enum inkEToggleState
		{
			Normal = 0,
			Press = 1,
			Hover = 2,
			Disabled = 3,
			Toggled = 4,
			ToggledPress = 5,
			ToggledHover = 6
		}
		public enum inkEVerticalAlign
		{
			Fill = 0,
			Top = 1,
			Center = 2,
			Bottom = 3
		}
		public enum inkFinalConfigurationVisibility
		{
			VisibleOnlyInFinal = 0,
			HiddenOnlyInFinal = 1
		}
		public enum inkFitToContentDirection
		{
			None = 0,
			Vertical = 1,
			Horizontal = 2
		}
		public enum inkFocusCause
		{
			Mouse = 0,
			Navigation = 1,
			SetDirectly = 2,
			Cleared = 3,
			OtherWidgetLostFocus = 4,
			WindowActivate = 5
		}
		public enum inkGradientMode
		{
			Linear = 0,
			Rectangular = 1
		}
		public enum inkIconResult
		{
			Success = 0,
			UnknownIconTweak = 1,
			AtlasResourceNotFound = 2,
			PartNotFoundInAtlas = 3
		}
		public enum inkInputHintHoldIndicationType
		{
			Press = 0,
			Hold = 1,
			FromInputConfig = 2
		}
		public enum inkLanguageId
		{
			EN = 0,
			PL = 1,
			JP = 2,
			DE = 3,
			ES = 4,
			MX = 5,
			KR = 6,
			IT = 7,
			FR = 8,
			RU = 9,
			PR = 10,
			ZH_CN = 11,
			TW = 12,
			CZ = 13,
			HU = 14,
			AR = 15,
			TR = 16,
			TH = 17,
			HT = 18,
			DEBUG = 19
		}
		public enum inkLastTickVideoState
		{
			NotDrawn = 0,
			Drawn = 1,
			Paused = 2
		}
		public enum inkLifePath
		{
			Corporate = 0,
			Nomad = 1,
			StreetKid = 2,
			Invalid = 3
		}
		public enum inkLineType
		{
			RegularPatternSpacing = 0,
			LoosePatternSpacing = 1
		}
		public enum inkLoadingScreenType
		{
			Unknown = 0,
			SplashScreen = 1,
			Initial = 2,
			FastTravel = 3
		}
		public enum inkMaskDataSource
		{
			TextureAtlas = 0,
			DynamicTexture = 1
		}
		public enum inkMenuMode
		{
			Unknown = 0,
			PauseMenu = 1,
			HubMenu = 2,
			CustomMenu = 3
		}
		public enum inkMenuState
		{
			Enabled = 0,
			Disabled = 1
		}
		public enum inkSaveType
		{
			ManualSave = 0,
			QuickSave = 1,
			AutoSave = 2,
			PointOfNoReturn = 3,
			EndGameSave = 4
		}
		public enum inkSelectionRule
		{
			Single = 0,
			Parent = 1,
			Children = 2,
			TypeBased = 3,
			NameBased = 4
		}
		public enum inkSelectorChangeDirection
		{
			None = 0,
			Prior = 1,
			Next = 2
		}
		public enum inkSpawnMode
		{
			SingleAndMultiplayer = 0,
			OnlySingleplayer = 1,
			OnlyMultiplayer = 2
		}
		public enum inkState
		{
			InitEngine = 0,
			PreGameMenu = 3,
			InitialLoading = 4,
			Game = 5,
			InGameMenu = 6,
			PauseMenu = 7,
			FastTravelLoading = 8,
			PhotoMode = 9,
			MiniGameMenu = 10,
			EndGameLoading = 11,
			EditorMode = 12
		}
		public enum inkTextReplaceAnimationControllerWidgetTextUsage
		{
			BaseText = 0,
			TargetText = 1,
			NoUsage = 2
		}
		public enum inkTextureType
		{
			StaticTexture = 0,
			DynamicTexture = 1,
			InvalidTexture = 2
		}
		public enum inkTextWrappingPolicy
		{
			SingleLine = 0,
			MultiLine = 1,
			MultilineNoWrap = 2
		}
		public enum inkVideoInstanceDoneReason
		{
			Failed = 0,
			Stopped = 1,
			Finished = 2
		}
		public enum inkVideoOptimizationState
		{
			None = 0,
			TooManyBinks = 1,
			FullscreenBinkVisible = 2
		}
		public enum inkWidgetResourceVersion
		{
			Default = 0,
			BrushToAtlas = 1
		}
		public enum inputContextType
		{
			Action = 0,
			RPG = 1
		}
		public enum InstanceState
		{
			DISABLED = 0,
			HIDDEN = 1,
			RUNNING = 2,
			MALFUNCTIONING = 3,
			ON = 4
		}
		public enum IntercomStatus
		{
			DEFAULT = 0,
			CALLING = 1,
			TALKING = 2,
			CALL_MISSED = 3,
			CALL_ENDED = 4
		}
		public enum InventoryModes
		{
			Default = 0,
			Item = 1
		}
		public enum InventoryPaperdollZoomArea
		{
			Default = 0,
			Weapon = 1,
			Legs = 2,
			Feet = 3,
			Cyberware = 4,
			QuickSlot = 5,
			Consumable = 6,
			Outfit = 7,
			Head = 8,
			Face = 9,
			InnerChest = 10,
			OuterChest = 11
		}
		public enum InventoryTooltipDisplayContext
		{
			Default = 0,
			Attachment = 1,
			Crafting = 2,
			Upgrading = 3,
			HUD = 4
		}
		public enum ItemAdditionalInfoType
		{
			NONE = 0,
			PRICE = 1,
			TYPE = 2
		}
		public enum ItemDisplayType
		{
			Item = 0,
			Weapon = 1
		}
		public enum ItemFilterCategory
		{
			Invalid = -1,
			RangedWeapons = 0,
			MeleeWeapons = 1,
			Clothes = 2,
			Consumables = 3,
			Grenades = 4,
			SoftwareMods = 5,
			Attachments = 6,
			Programs = 7,
			Cyberware = 8,
			Junk = 9,
			BaseCount = 10,
			Quest = 11,
			Buyback = 12,
			AllItems = 13,
			AllCount = 14
		}
		public enum ItemFilterType
		{
			All = 0,
			Weapons = 1,
			Clothes = 2,
			Consumables = 3,
			Cyberware = 4,
			Attachments = 5,
			Quest = 6,
			Buyback = 7,
			LightWeapons = 8,
			HeavyWeapons = 9,
			MeleeWeapons = 10,
			Hacks = 11
		}
		public enum ItemLabelType
		{
			New = 0,
			Quest = 1,
			Money = 2,
			Equipped = 3,
			Owned = 4,
			Buyback = 5
		}
		public enum ItemSortMode
		{
			Default = 0,
			NewItems = 1,
			NameAsc = 2,
			NameDesc = 3,
			QualityAsc = 4,
			QualityDesc = 5,
			WeightAsc = 6,
			WeightDesc = 7,
			PriceAsc = 8,
			PriceDesc = 9,
			ItemType = 10,
			DpsAsc = 11,
			DpsDesc = 12
		}
		public enum ItemViewModes
		{
			Item = 0,
			Mod = 1
		}
		public enum LandingType
		{
			Off = 0,
			Regular = 1,
			Hard = 2,
			VeryHard = 3,
			Superhero = 4,
			Death = 5
		}
		public enum LaserTargettingState
		{
			Start = 0,
			Update = 1,
			End = 2
		}
		public enum LibTreeEParameterType
		{
			PARAM_Bool = 0,
			PARAM_Int32 = 1,
			PARAM_Enum = 2,
			PARAM_Float = 3,
			PARAM_CName = 4,
			PARAM_TreeRef = 5,
			PARAM_TreeRefList = 6,
			PARAM_NodeRef = 7,
			PARAM_Vector = 9
		}
		public enum locHolocallActorMode
		{
			Default = 0,
			ActorUsesHolocall = 1,
			ActorDoesntUseHolocall = 2
		}
		public enum locVoiceoverContext
		{
			Vo_Context_Quest = 0,
			Vo_Context_Community = 1,
			Vo_Context_Combat = 2,
			Vo_Context_Minor_Activity = 3,
			Default_Vo_Context = 5
		}
		public enum locVoiceoverExpression
		{
			Vo_Expression_Spoken = 0,
			Vo_Expression_Phone = 1,
			Vo_Expression_InnerDialog = 2,
			Vo_Expression_Loudspeaker_Room = 3,
			Vo_Expression_Loudspeaker_Street = 4,
			Vo_Expression_Loudspeaker_City = 5,
			Vo_Expression_Radio = 6,
			Vo_Expression_GlobalTV = 7,
			Vo_Experession_Cb_Radio = 8,
			Vo_Expression_Cyberspace = 9,
			Vo_Expression_Possessed = 10,
			Vo_Expression_Helmet = 11
		}
		public enum locVoiceTagGender
		{
			Undefined = 0,
			Male = 1,
			Female = 2
		}
		public enum MechanicalScanType
		{
			None = 0,
			Short = 1,
			Long = 2,
			Danger = 3
		}
		public enum meleeMoveDirection
		{
			Forward = 0,
			Right = 1,
			Back = 2,
			Left = 3
		}
		public enum meleeQueuedAttack
		{
			Block = 0,
			Combo = 1,
			Crouch = 2,
			Final = 3,
			Jump = 4,
			Safe = 5,
			Sprint = 6,
			Strong = 7,
			Throw = 8
		}
		public enum MessageViewType
		{
			Sent = 0,
			Received = 1
		}
		public enum MessengerContactType
		{
			Contact = 0,
			Group = 1,
			Thread = 2
		}
		public enum MinigameActionType
		{
			Device = 0,
			NPC = 1,
			Both = 2,
			AccessPoint = 3
		}
		public enum ModuleState
		{
			DISABLED = 0,
			HIDDEN = 1,
			ASLEEP = 2,
			MALFUNCTIONING = 3,
			ON = 4
		}
		public enum MorphTargetsDiffTextureSize
		{
			TEXTURE_SIZE_1024x1024 = 0,
			TEXTURE_SIZE_512x512 = 1,
			TEXTURE_SIZE_256x256 = 2
		}
		public enum MorphTargetsFaceRegion
		{
			FACE_REGION_EYES = 0,
			FACE_REGION_NOSE = 1,
			FACE_REGION_MOUTH = 2,
			FACE_REGION_JAW = 3,
			FACE_REGION_EARS = 4,
			FACE_REGION_NONE = 255
		}
		public enum moveCirclingDirection
		{
			None = 0,
			Left = 1,
			Right = 2
		}
		public enum moveExplorationType
		{
			None = 0,
			Ladder = 1,
			Jump = 2,
			Climb = 3,
			Vault = 4,
			ChargedJump = 5,
			ThrusterJump = 6
		}
		public enum moveLineOfSight
		{
			None = 0,
			Keep = 1,
			Avoid = 2
		}
		public enum moveMovementOrientationType
		{
			NotSet = 0,
			Forward = 1,
			Backward = 2,
			Left = 3,
			Right = 4
		}
		public enum moveMovementType
		{
			Walk = 0,
			Run = 1,
			Sprint = 2,
			Strafe = 3,
			Stand = 4
		}
		public enum moveSecureFootingFailureReason
		{
			Invalid = 0,
			Filter = 1,
			SimulationType = 2,
			Ground = 3
		}
		public enum moveSecureFootingFailureType
		{
			Invalid = 0,
			Edge = 1,
			Slope = 2
		}
		public enum NavGenAgentSize
		{
			Human = 0
		}
		public enum NavGenNavmeshImpact
		{
			Walkable = 0,
			Ignored = 1,
			Blocking = 2,
			Road = 3,
			CrowdWalkable = 4,
			Stairs = 5,
			Drones = 6
		}
		public enum navLocomotionPathSegmentTypes
		{
			Invalid = 0,
			Spline = 1,
			OffMeshLink = 2
		}
		public enum navNaviPositionType
		{
			None = 0,
			Normal = 1,
			Projected = 2
		}
		public enum operationsMode
		{
			PLAYER = 0,
			FLATHEAD = 1,
			TOOLBOX = 2
		}
		public enum OutcomeMessage
		{
			Success = 0,
			Failure = 1
		}
		public enum PackageStatus
		{
			UNINITIALIZED = 0,
			ON_HOLD = 1,
			FOR_IMMEDIATE_TRIGGER = 2,
			TRIGGERED = 3
		}
		public enum panzerBootupUI
		{
			UnbootedIdle = 0,
			BootingAttempt = 1,
			BootingSuccess = 2,
			Loop = 3
		}
		public enum PaperdollPositionAnimation
		{
			Center = 0,
			Left = 1,
			Right = 2,
			LeftFullBody = 3
		}
		public enum PauseMenuAction
		{
			OpenSubMenu = 0,
			QuickSave = 1,
			Save = 2,
			ExitGame = 3,
			ExitToMainMenu = 4,
			QuickLoad = 5
		}
		public enum PaymentStatus
		{
			DEFAULT = 0,
			IN_PROGRESS = 1,
			NO_MONEY = 2
		}
		public enum PerkMenuAttribute
		{
			Body = 0,
			Reflex = 1,
			Technical_Ability = 2,
			Johnny = 3,
			Cool = 4,
			Intelligence = 5
		}
		public enum PersistenceSource
		{
			AddThreat = 0,
			SetNewCombatTarget = 1,
			CommandAimWithWeapon = 2,
			CommandForceShoot = 3,
			CommandInjectCombatTarget = 4,
			CommandMeleeAttack = 5,
			CommandShoot = 6,
			CommandThrowGrenade = 7,
			CommandInjectThreat = 8,
			TrackedBySecuritySystemAgent = 9
		}
		public enum physicsFilterDataSource
		{
			Parent = 0,
			Component = 0,
			Collider = 1,
			Body = 1
		}
		public enum physicsMaterialFriction
		{
			Enabled = 0,
			DisabledStrong = 1,
			Disabled = 2
		}
		public enum physicsMaterialTagAIVisibility
		{
			None = 0,
			SemiTransparent = 1,
			Transparent = 2
		}
		public enum physicsMaterialTagProjectilePenetration
		{
			TechOnly = 0,
			Any = 1,
			Medium = 2,
			Heavy = 3,
			Never = 4
		}
		public enum physicsMaterialTagType
		{
			AIVisibility = 0,
			ProjectilePenetration = 1,
			VehicleTraction = 2
		}
		public enum physicsMaterialTagVehicleTraction
		{
			Default = 0,
			Gravel = 1
		}
		public enum physicsPhysicalSystemOwner
		{
			Unknown = 0,
			StaticMeshNode = 1,
			StaticCollisionAreaNode = 2,
			DynamicMeshNode = 3,
			TerrainMeshNode = 4,
			TerrainCollisionNode = 5,
			PhysicalDestructionNode = 6,
			PhysicalDestructionComponent = 7,
			PhysicalDecorationNode = 8,
			PhysicalMeshComponent = 9,
			PhysicalSkinnedMeshComponent = 10,
			ColliderComponent = 11,
			SimpleColliderComponent = 12,
			RagdollBinder = 13,
			WaterPatchNode = 14,
			WorldCollisionNode = 15,
			AggregateSystemComponent = 16,
			ClothComponent = 17,
			SkinnedClothComponent = 18,
			ClothMeshNodeInstance = 19,
			PhysicalTriggerComponent = 20,
			PhysicalTriggerNode = 21,
			StateMachineComponent = 22,
			PhysicalParticleSystem = 23,
			BakedDestructionComponent = 24,
			BakedDestructionNode = 25,
			InstancedDestructibleNode = 26,
			PhotoModeSystem = 27,
			VehicleChassisComponent = 28,
			FoliageDestruction = 29
		}
		public enum physicsPhysicsJointAxis
		{
			AxisX = 0,
			AxisY = 1,
			AxisZ = 2,
			Twist = 3,
			Swing1 = 4,
			Swing2 = 5
		}
		public enum physicsPhysicsJointDriveType
		{
			AxisX = 0,
			AxisY = 1,
			AxisZ = 2,
			Swing = 3,
			Twist = 4,
			SLERP = 5
		}
		public enum physicsPhysicsJointMotion
		{
			Locked = 0,
			Limited = 1,
			Free = 2
		}
		public enum physicsProxyType
		{
			Invalid = 0,
			PhysicalSystem = 1,
			CharacterController = 2,
			Destruction = 3,
			ParticleSystem = 4,
			Trigger = 5,
			Cloth = 6,
			WorldCollision = 7,
			Terrain = 8,
			SimpleCollider = 9,
			AggregateSystem = 10,
			FoliageDestruction = 13
		}
		public enum physicsQueryUseCase
		{
			Default = 0,
			ActionAnimation = 1,
			AI = 2,
			AnimationComponent = 3,
			Audio = 4,
			AudioHedgehog = 5,
			Components = 6,
			Debug = 7,
			Gameplay = 8,
			GeomDescription = 9,
			LineOfSightTests = 10,
			Navigation = 11,
			Nodes = 12,
			Ragdoll = 13,
			Scripts = 14,
			VehicleAI = 15,
			Vehicles = 16,
			VehicleChassis = 17,
			VehiclesCrowd = 18,
			VehicleWheel = 19,
			VehicleStreamingHack = 20,
			VehicleWater = 21,
			WorldUI = 22
		}
		public enum physicsRagdollShapeType
		{
			CAPSULE = 0,
			BOX = 1,
			SPHERE = 2
		}
		public enum physicsShapeType
		{
			Box = 0,
			Sphere = 1,
			Capsule = 2,
			ConvexMesh = 3,
			TriangleMesh = 4,
			Invalid = 6
		}
		public enum physicsSimulationType
		{
			Static = 0,
			Dynamic = 1,
			Kinematic = 2,
			Invalid = 3
		}
		public enum physicsStateValue
		{
			Position = 1,
			Rotation = 2,
			Transform = 3,
			LinearVelocity = 4,
			AngularVelocity = 5,
			LinearSpeed = 6,
			TouchesGround = 10,
			TouchesWalls = 11,
			ImpulseAccumulator = 12,
			IsSleeping = 13,
			Mass = 16,
			Volume = 18,
			IsSimulated = 20,
			IsKinematic = 21,
			TimeDeltaOverride = 27,
			Radius = 30,
			SimulationFilter = 32
		}
		public enum PlayerVisionModeControllerRefreshPolicyEnum
		{
			Persistent = 0,
			Eventful = 1
		}
		public enum populationSpawnerObjectCtrlAction
		{
			Undefined = 0,
			Activate = 1,
			Spawn = 1,
			Deactivate = 2,
			Despawn = 2,
			Reactivate = 3,
			Respawn = 3,
			ResetKillCount = 4
		}
		public enum ProgramEffect
		{
			GrantAccess = 0,
			BlockAccess = 1,
			UnlockQuestFact = 2
		}
		public enum ProgramType
		{
			BasicAccess = 0,
			ExtraPlayerProgram = 1,
			ExtraServerProgram = 2,
			EnemyProgram = 3,
			EnemyLockNetwork = 4
		}
		public enum PSODescBlendModeFactor
		{
			FAC_Zero = 0,
			FAC_One = 1,
			FAC_SrcColor = 2,
			FAC_InvSrcColor = 3,
			FAC_SrcAlpha = 4,
			FAC_InvSrcAlpha = 5,
			FAC_DestColor = 6,
			FAC_InvDestColor = 7,
			FAC_DestAlpha = 8,
			FAC_InvDestAlpha = 9,
			FAC_BlendFactor = 10,
			FAC_InvBlendFactor = 11,
			FAC_Src1Color = 12,
			FAC_InvSrc1Color = 13,
			FAC_Src1Alpha = 14,
			FAC_InvSrc1Alpha = 15
		}
		public enum PSODescBlendModeOp
		{
			OP_Add = 0,
			OP_Subtract = 1,
			OP_RevSub = 2,
			OP_Min = 3,
			OP_Max = 4,
			OP_Or = 5,
			OP_And = 6,
			OP_Xor = 7,
			OP_nAnd = 8,
			OP_nOr = 9
		}
		public enum PSODescBlendModeWriteMask
		{
			MASK_None = 0,
			MASK_R = 1,
			MASK_G = 2,
			MASK_RG = 3,
			MASK_B = 4,
			MASK_RB = 5,
			MASK_GB = 6,
			MASK_RGB = 7,
			MASK_A = 8,
			MASK_RA = 9,
			MASK_GA = 10,
			MASK_RGA = 11,
			MASK_BA = 12,
			MASK_RBA = 13,
			MASK_GBA = 14,
			MASK_RGBA = 15
		}
		public enum PSODescDepthStencilModeComparisonMode
		{
			COMPARISON_Never = 0,
			COMPARISON_Less = 1,
			COMPARISON_Equal = 2,
			COMPARISON_LessEqual = 3,
			COMPARISON_Greater = 4,
			COMPARISON_NotEqual = 5,
			COMPARISON_GreaterEqual = 6,
			COMPARISON_Always = 7
		}
		public enum PSODescDepthStencilModeStencilOpMode
		{
			STENCILOP_Keep = 0,
			STENCILOP_Zero = 1,
			STENCILOP_Replace = 2,
			STENCILOP_IncreaseSaturate = 3,
			STENCILOP_DecreaseSaturate = 4,
			STENCILOP_Invert = 5,
			STENCILOP_Increase = 6,
			STENCILOP_Decrease = 7
		}
		public enum PSODescPrimitiveTopologyType
		{
			Invalid = 0,
			Point = 1,
			Line = 2,
			Triangle = 3,
			Patch = 4
		}
		public enum PSODescRasterizerModeCullMode
		{
			CULL_None = 0,
			CULL_Front = 1,
			CULL_Back = 2
		}
		public enum PSODescRasterizerModeFrontFaceWinding
		{
			FRONTFACE_CCW = 0,
			FRONTFACE_CW = 1
		}
		public enum PSODescRasterizerModeOffsetMode
		{
			OFFSET_None = 0,
			OFFSET_NormalBias = 1,
			OFFSET_ShadowBias = 2,
			OFFSET_DecalBias = 3
		}
		public enum QuantityPickerActionType
		{
			Buy = 0,
			Sell = 1,
			TransferToStorage = 2,
			TransferToPlayer = 3,
			Drop = 4,
			Disassembly = 5
		}
		public enum questAttachmentOffsetMode
		{
			UseRealOffset = 0,
			UseCustomOffset = 1
		}
		public enum questAudioEventPrefetchMode
		{
			AddEventPrefetch = 0,
			RemoveEventPrefetch = 1
		}
		public enum questAvailableVehicleType
		{
			AnyCar = 0,
			AnyMotorcycle = 1,
			AnyVehicle = 2,
			SpecificVehicle = 3
		}
		public enum questBehindInteractionEventType
		{
			Undefined = 0,
			StartedBeingBehind = 1,
			StoppedBeingBehind = 2,
			IsBehind = 3,
			IsNotBehind = 4
		}
		public enum questBlockAction
		{
			Block = 0,
			Unblock = 1,
			UnblockAll = 2
		}
		public enum questBriefingSequencePlayerFunction
		{
			StartSequence = 0,
			ChangeSequence = 1,
			FinishSequence = 2
		}
		public enum questBriefingType
		{
			Fullscreen = 0,
			Hud = 1
		}
		public enum questCameraParallaxSpace
		{
			Trajectory = 0,
			Camera = 1,
			Chest = 2
		}
		public enum questCameraPlanesPreset
		{
			Undefined = 0,
			VeryNear = 1,
			Near = 2,
			Normal = 3
		}
		public enum questCharacterHitEventType
		{
			Bullet = 0,
			Explosion = 1,
			Melee = 2,
			Other = 3
		}
		public enum questCombatNodeFunctions
		{
			CombatTarget = 0,
			ShootAt = 1,
			LookAtTarget = 2,
			ThrowGrenade = 3,
			UseCover = 4,
			SwitchWeapon = 5,
			PrimaryWeapon = 6,
			SecondaryWeapon = 7,
			RestrictMovementToArea = 8
		}
		public enum questCompanionPositions
		{
			Behind = 0,
			InFront = 1
		}
		public enum questControlCrowdAction
		{
			Disable = 0,
			Enable = 1
		}
		public enum questCustomStyle
		{
			PlacidePhone = 0,
			VideoCallInterupt = 1
		}
		public enum questDrillingState
		{
			Undefined = 0,
			Started = 1,
			Finished = 2
		}
		public enum questEAddRemoveItemType
		{
			AddItem = 0,
			RemoveByItemID = 1,
			RemoveByTag = 2,
			RemoveAll = 3
		}
		public enum questEComparisonTypeEquality
		{
			Equal = 0,
			NotEqual = 1
		}
		public enum questEDebugViewMode
		{
			NONE = 0,
			CLAY = 1,
			PURE_GRAY = 2,
			PURE_WHITE = 3,
			SHADOWS = 4,
			BASE_COLOR = 5,
			NORMALS = 6,
			ROUGHNESS = 7,
			METALNESS = 8,
			EMISSIVE = 9,
			MATERIAL_ID = 10,
			WIREFRAME = 11,
			OVERDRAW = 12
		}
		public enum questElevator_ManageNPCAttachment_NodeTypeParamsAction
		{
			Attach = 0,
			Detach = 1
		}
		public enum questESwitchBehaviourType
		{
			[RED("First Fulfilled")] First_Fulfilled = 0,
			[RED("All Fulfilled")] All_Fulfilled = 1
		}
		public enum questETimeDilationOverride
		{
			None = 0,
			Ignore = 1,
			Inherit = 2
		}
		public enum questETimeShiftType
		{
			ShiftByTime = 0,
			ShiftToHour = 1
		}
		public enum questEUIMenuState
		{
			Open = 0,
			Closed = 1
		}
		public enum questExitType
		{
			Terminating = 0,
			NonTerminating = 1
		}
		public enum questGameplayRestrictionAction
		{
			AddRestriction = 0,
			RemoveRestriction = 1,
			RemoveAllRestrictions = 2
		}
		public enum questImpulseMagnitude
		{
			Any = 0,
			Low = 1,
			Medium = 2,
			High = 3
		}
		public enum questInjectLootOperationType
		{
			Inject = 0,
			Remove = 1
		}
		public enum questInputDevice
		{
			Undefined = 0,
			KeyboardMouse = 1,
			XBoxGamepad = 2,
			PS4Gamepad = 3
		}
		public enum questJournalAlignmentEventType
		{
			Left = 0,
			Center = 1,
			Right = 2
		}
		public enum questJournalSizeEventType
		{
			Maximize = 0,
			Minimize = 1
		}
		public enum questLanguageMode
		{
			Undefined = 0,
			VoLang = 1,
			SubsLang = 2,
			TextLang = 3
		}
		public enum questLocationAction
		{
			Entered = 0,
			Exited = 1
		}
		public enum questLogicalOperation
		{
			AND = 0,
			OR = 1,
			XOR = 2,
			NAND = 3,
			NOR = 4,
			NXOR = 5
		}
		public enum questLookAtDrivenTurnsMode
		{
			Start = 0,
			Pause = 1,
			Resume = 2,
			Stop = 3,
			ForceStop = 4
		}
		public enum questLootTokenState
		{
			Enabled = 0,
			Disabled = 1,
			Sealed = 2,
			Unsealed = 3
		}
		public enum questMountConditionType
		{
			OnMount = 0,
			OnUnmount = 1
		}
		public enum questMountVehicleOrigin
		{
			Any = 0,
			NotStolen = 1,
			Stolen = 2
		}
		public enum questMountVehicleType
		{
			Any = 0,
			Car = 1,
			Motorcycle = 2
		}
		public enum questMoveOnSplineType
		{
			Simple = 0,
			Anim = 1,
			WithCompanion = 2
		}
		public enum questMoveType
		{
			MoveOnSpline = 0,
			MoveTo = 1,
			RotateTo = 2,
			Patrol = 3,
			Follow = 4
		}
		public enum questMultiplayerAIDirectorFunction
		{
			SetStatus = 0,
			SetCurrentPath = 1,
			OverrideScheduleEntry = 2,
			SetCurrentShedule = 3
		}
		public enum questMultiplayerAIDirectorStatus
		{
			Enabled = 0,
			Disabled = 1
		}
		public enum questMultiplayerHeistState
		{
			Invalid = 0,
			Failure = 1,
			Victory = 2
		}
		public enum questNodeType
		{
			Equip = 0,
			Unequip = 1
		}
		public enum questObjectInspectEventType
		{
			Undefined = 0,
			Started = 1,
			Finished = 2
		}
		public enum questObjectInteractionEventType
		{
			Undefined = 0,
			Entered = 1,
			Exited = 2,
			Executed = 3
		}
		public enum questObjectScanEventType
		{
			Undefined = 0,
			Started = 1,
			Finished = 2
		}
		public enum questPhaseNodeType
		{
			Quest = 0,
			OpenWorld = 1,
			Combat = 2,
			Audio = 3
		}
		public enum questPhoneCallMode
		{
			Undefined = 0,
			Audio = 1,
			Video = 2
		}
		public enum questPhoneCallPhase
		{
			Undefined = 0,
			IncomingCall = 1,
			StartCall = 2,
			EndCall = 3
		}
		public enum questPhoneStatus
		{
			Available = 0,
			NotAvailable = 1,
			Busy = 2,
			Minimized = 3
		}
		public enum questPhoneTalkingState
		{
			Ended = 0,
			Initializing = 1,
			Talking = 2
		}
		public enum questPlatform
		{
			PC = 0,
			Console = 1
		}
		public enum questProximityProgressBarAction
		{
			Activated = 0,
			Inactivated = 1,
			Completed = 2,
			WentOutOfRange = 3
		}
		public enum questProximityProgressBarOrientation
		{
			Undefined = 0,
			InRange = 1,
			OutOfRange = 2
		}
		public enum questProximityProgressBarState
		{
			None = 0,
			Active = 1,
			Inactive = 2,
			Complete = 3
		}
		public enum questQuestContentType
		{
			Fixer = 0,
			MainQuest = 1,
			SideQuest_MainPath = 2,
			SideQuest_Romance = 3,
			SideQuest_Standalone = 4,
			MinorQuestAndSts = 5
		}
		public enum questQuickItemsSet
		{
			Q001_Kereznikov_Heal_Phone = 0,
			Q003_All = 1
		}
		public enum questRandomizerMode
		{
			Random = 0,
			IgnoreLastUsed = 1,
			IgnoreAllUsed = 2
		}
		public enum questScanningState
		{
			NotScanned = 0,
			Scanned = 1
		}
		public enum questSceneConditionType
		{
			Undefined = 0,
			IsInside = 1,
			IsOutside = 2,
			Entered = 3,
			Exited = 4
		}
		public enum questSetDestructionStateAction
		{
			Undefined = 0,
			Trigger = 1
		}
		public enum questSocketType
		{
			Undefined = 0,
			Input = 1,
			Output = 2,
			CutSource = 3,
			CutDestination = 4
		}
		public enum questSpawnedVehicleType
		{
			EntityReferenced = 0,
			AnyCar = 1,
			AnyMotorcycle = 2,
			SpecificVehicle = 3
		}
		public enum questSwitchWeaponModes
		{
			PrimaryWeapon = 0,
			SecondaryWeapon = 1
		}
		public enum questTriggerConditionType
		{
			Undefined = 0,
			Entered = 1,
			Exited = 2,
			IsInside = 3,
			IsOutside = 4,
			AllInsideMP = 5,
			AllOutsideMP = 6
		}
		public enum questTutorialScreenMode
		{
			Undefined = 0,
			Fullscreen = 1,
			Popup = 2
		}
		public enum questUIGameContextRequestType
		{
			Push = 0,
			Pop = 1,
			Reset = 2
		}
		public enum questUseWorkspotNodeFunctions
		{
			UseWorkspot = 0,
			JumpWorkspot = 1,
			StopWorkspot = 2,
			IdleOnlyMode = 3
		}
		public enum questUseWorkspotTier
		{
			Tier3 = 0,
			Tier4 = 1
		}
		public enum questVehicleCameraPerspective
		{
			TPP = 0,
			FPP = 1
		}
		public enum questVehicleCameraType
		{
			Undefined = 0,
			PuppetFPP = 1,
			FPP = 1,
			TPP = 2,
			DriverFPP = 3
		}
		public enum questVehicleCommandType
		{
			[RED("Move On Spline")] Move_On_Spline = 0,
			Follow = 1,
			[RED("Move To")] Move_To = 2,
			Racing = 3,
			[RED("Join Traffic")] Join_Traffic = 4
		}
		public enum questVehicleWeaponQuestID
		{
			Primary = 0,
			Secondary = 1,
			Tertiary = 2,
			Quaternary = 3,
			Quinary = 4,
			Senary = 5,
			Septenary = 6,
			Octonary = 7,
			All = 8
		}
		public enum questVisionModeType
		{
			Undefined = 0,
			FocusMode = 1,
			EnhancedMode = 2
		}
		public enum questWeaponUsageType
		{
			Shoot = 0,
			Reload = 1
		}
		public enum QuickSlotActionType
		{
			Undefined = 0,
			SelectItem = 1,
			HideWeapon = 2,
			OpenPhone = 3,
			SummonCar = 4,
			SummonBike = 5,
			ToggleRadio = 6,
			SelectRadioStation = 7,
			TurnOffRadio = 8,
			CycleTrackedQuest = 9,
			SummonVehicle = 10,
			SetActiveVehicle = 11,
			QuickHack = 12,
			ToggleSummonMode = 13,
			EquipFists = 14
		}
		public enum QuickSlotItemType
		{
			Undefined = 0,
			Vehicle = 1,
			Gadget = 2,
			Consumable = 3,
			Cyberware = 4,
			Weapon = 5,
			Interaction = 6
		}
		public enum ReactionZones_Humanoid_Side
		{
			Head = 0,
			ChestLeft = 1,
			ArmLeft = 2,
			HandLeft = 3,
			ChestRight = 4,
			ArmRight = 5,
			HandRight = 6,
			Abdomen = 7,
			LegLeft = 8,
			LegRight = 9
		}
		public enum redTaskTextMessageType
		{
			Info = 0,
			Error = 1
		}
		public enum Ref_1_3_3_BigEnum
		{
			BigValue //= 68719476735
		}
		public enum Ref_1_3_3_Colors
		{
			Red = 0,
			Green = 4,
			Blue = 5
		}
		public enum Ref_1_3_3_CustomSize_1
		{
			Test1 = -128,
			Test = 0,
			Test2 = 127
		}
		public enum Ref_1_3_3_CustomSize_2
		{
			Test = 0,
			Test1 = 256,
			Test2 = 12345
		}
		public enum Ref_2_3_3_Enum32Bit
		{
			Value = 0
		}
		public enum Ref_2_3_3_Enum64Bit
		{
			BigValue //= 68719476735
		}
		public enum rendCaptureContextType
		{
			SceneGamedef = 0,
			AnimViewer = 1
		}
		public enum rendContactShadowReciever
		{
			CSR_None = 0,
			CSR_CharacterOnly = 2,
			CSR_All = 3
		}
		public enum renddimEPreset
		{
			[RED("228x128")] _228x128 = 0,
			[RED("456x256")] _456x256 = 1,
			[RED("480x270")] _480x270 = 2,
			[RED("640x480")] _640x480 = 3,
			[RED("960x540")] _960x540 = 4,
			[RED("1280x720")] _1280x720 = 5,
			[RED("1600x900")] _1600x900 = 6,
			[RED("1920x1080")] _1920x1080 = 7,
			Console_Base = 7,
			[RED("2560x1080")] _2560x1080 = 8,
			[RED("2560x1440")] _2560x1440 = 9,
			Console_Pro_Prospero_Lockhart = 9,
			Console_Anaconda = 10,
			[RED("3440x1440")] _3440x1440 = 11,
			[RED("3840x1600")] _3840x1600 = 12,
			[RED("3840x2160")] _3840x2160 = 13,
			Console_Scorpio = 13
		}
		public enum rendEParticleSortingMode
		{
			PSM_None = 0,
			PSM_Billboard = 1,
			PSM_Regular = 2
		}
		public enum RenderDecalNormalsBlendingMode
		{
			AlphaBlending = 0,
			Reorient = 1
		}
		public enum RenderDecalOrderPriority
		{
			Priority0 = 0,
			Priority1 = 1,
			Priority2 = 2,
			Priority3 = 3
		}
		public enum renderDevEnvProbeView
		{
			RADIANCE = 0,
			ALBEDO = 1,
			NORMAL = 2,
			ROUGHNESS = 3,
			METALNESS = 4,
			EMISSIVE = 5,
			SKY_MASK = 6
		}
		public enum renderDevGIProbeView
		{
			RADIANCE = 0,
			SKY_VISIBILITY = 1,
			ENV_ID = 2,
			FLAG_0 = 3,
			FLAG_1 = 4,
			FLAG_2 = 5,
			CURRENT_ID = 6
		}
		public enum renderDevSurfelView
		{
			ALBEDO = 0,
			NORMAL = 1,
			SHADOWS = 2,
			CLOSEST_PROBE = 3,
			EMISSIVE = 4,
			LIGHTING = 5,
			BOUNCE = 6,
			INSIDE = 7,
			SHADOW = 8
		}
		public enum renderDevTXAADebugMode
		{
			TXAA_NoDebug = 0,
			TXAA_ShowHistoryBlendFactor = 1
		}
		public enum RenderSceneLayer
		{
			Default = 0,
			Cyberspace = 1,
			WorldMap = 2
		}
		public enum rendGIGroup
		{
			GI_Group0 = 0,
			GI_Group1 = 1
		}
		public enum rendGIVolume
		{
			GI_Exterior = 0,
			GI_Interior1 = 1,
			GI_Interior2 = 2,
			GI_Interior3 = 3,
			GI_Interior4 = 4
		}
		public enum rendLightAttenuation
		{
			LA_InverseSquare = 0,
			LA_Linear = 1
		}
		public enum rendLightGroup
		{
			LG_Group0 = 0,
			LG_Group1 = 1,
			LG_Group2 = 2,
			LG_Group3 = 3,
			LG_Group4 = 4,
			LG_Group5 = 5,
			LG_Group6 = 6,
			LG_Group7 = 7
		}
		public enum rendPostFx_ScanningState
		{
			Off = 0,
			Scanning = 2,
			Cancelled = 3,
			Complete = 4
		}
		public enum rendResolutionMultiplier
		{
			X1 = 1,
			X2 = 2,
			X4 = 4
		}
		public enum rendScreenshotMode
		{
			NONE = 0,
			NORMAL = 1,
			LAYERED = 3,
			HIGH_RESOLUTION = 4,
			HIGH_RESOLUTION_LAYERED = 5
		}
		public enum rendWindShapeAnchorPointDepth
		{
			AP_CENTER = 0,
			AP_FRONT = 1,
			AP_BACK = 2
		}
		public enum rendWindShapeAnchorPointHorz
		{
			AP_CENTER = 0,
			AP_RIGHT = 1,
			AP_LEFT = 2
		}
		public enum rendWindShapeAnchorPointVert
		{
			AP_CENTER = 0,
			AP_TOP = 1,
			AP_BOTTOM = 2
		}
		public enum RequestType
		{
			INSTANTLY_TRIGGER = 0,
			MANUALLY_TRIGGERED = 1
		}
		public enum RipperdocFilter
		{
			All = 0,
			Vendor = 1,
			Player = 2
		}
		public enum RipperdocModes
		{
			Default = 0,
			Item = 1
		}
		public enum Sample_Enum_4_1
		{
			Sample_Enum_Option_4_1_0 = 0,
			Sample_Enum_Option_4_1_1 = 7,
			Sample_Enum_Option_4_1_2 = 8,
			MyCustomEnumOptionName413 = 9
		}
		public enum Sample_Enum_4_4
		{
			Sample_Enum_Option_4_4_0 = 0,
			Sample_Enum_Option_4_4_1 = 1,
			Sample_Enum_Option_4_4_2 = 2
		}
		public enum Sample_Enum_4_5
		{
			Sample_Enum_Option_4_5_0 = 10,
			Sample_Enum_Option_4_5_1 = 27,
			Sample_Enum_Option_4_5_2 = 108
		}
		public enum Sample_Enum_4_6
		{
			Sample_Enum_Option_4_6_0 = 0,
			Sample_Enum_Option_4_6_1_with_a_new_name = 1,
			Sample_Enum_Option_4_6_1 = 1
		}
		public enum Sample_Enum_6_8
		{
		}
		public enum Sample_Namespace_4_2Sample_Enum_4_2
		{
			Sample_Enum_Option_4_2_0 = 0,
			Sample_Enum_Option_4_2_1 = 7,
			Sample_Enum_Option_4_2_2 = 8,
			MyCustomEnumOptionName423 = 9
		}
		public enum Sample_Namespace_4_3_0Sample_Namespace_4_3_1Sample_Enum_4_3
		{
			Sample_Enum_Option_4_3_0 = 0,
			Sample_Enum_Option_4_3_1 = 7,
			Sample_Enum_Option_4_3_2 = 8,
			MyCustomEnumOptionName433 = 9
		}
		public enum Sample_Replicated_Enum
		{
			One = 0,
			Two = 1,
			Three = 2
		}
		public enum SAnimationBufferBitwiseCompression
		{
			ABBC_None = 0,
			ABBC_24b = 1,
			ABBC_16b = 2
		}
		public enum SAnimationBufferBitwiseCompressionPreset
		{
			ABBCP_Custom = 0,
			ABBCP_VeryHighQuality = 1,
			ABBCP_HighQuality = 2,
			ABBCP_NormalQuality = 3,
			ABBCP_LowQuality = 4,
			ABBCP_VeryLowQuality = 5,
			ABBCP_Raw = 6
		}
		public enum SAnimationBufferDataCompressionMethod
		{
			ABDCM_Invalid = 0,
			ABDCM_Plain = 1,
			ABDCM_Quaternion = 2,
			ABDCM_QuaternionXYZSignedW = 3,
			ABDCM_QuaternionXYZSignedWLastBit = 4,
			ABDCM_Quaternion48b = 5,
			ABDCM_Quaternion40b = 6,
			ABDCM_Quaternion32b = 7,
			ABDCM_Quaternion64bW = 8,
			ABDCM_Quaternion48bW = 9,
			ABDCM_Quaternion40bW = 10
		}
		public enum SAnimationBufferOrientationCompressionMethod
		{
			ABOCM_PackIn64bitsW = 0,
			ABOCM_PackIn48bitsW = 1,
			ABOCM_PackIn40bitsW = 2,
			ABOCM_AsFloat_XYZW = 3,
			ABOCM_AsFloat_XYZSignedW = 4,
			ABOCM_AsFloat_XYZSignedWInLastBit = 5,
			ABOCM_PackIn48bits = 6,
			ABOCM_PackIn40bits = 7,
			ABOCM_PackIn32bits = 8
		}
		public enum SAnimationBufferStreamingOption
		{
			ABSO_NonStreamable = 0,
			ABSO_PartiallyStreamable = 1,
			ABSO_FullyStreamable = 2
		}
		public enum ScannerDataType
		{
			None = 0,
			Name = 1,
			Level = 2,
			Health = 3,
			Rarity = 4,
			WeaponBasic = 5,
			WeaponDetailed = 6,
			BountySystem = 7,
			Vulnerabilities = 8,
			Faction = 9,
			Attitude = 10,
			SquadInfo = 11,
			Resistances = 12,
			Abilities = 13,
			Requirements = 14,
			Description = 15,
			DeviceStatus = 16,
			NetworkStatus = 17,
			NetworkLevel = 18,
			DeviceConnections = 19,
			QuestEntry = 20,
			VehicleName = 21,
			VehicleManufacturer = 22,
			VehicleProductionYears = 23,
			VehicleDriveLayout = 24,
			VehicleHorsepower = 25,
			VehicleMass = 26,
			VehicleState = 27,
			VehicleInfo = 28,
			QuickHackDescription = 29
		}
		public enum ScannerNetworkState
		{
			NOT_CONNECTED = 0,
			NOT_BREACHED = 1,
			TIER1 = 2,
			TIER2 = 3,
			TIER3 = 4,
			BREACHED = 5
		}
		public enum ScannerObjectType
		{
			INVALID = 0,
			PUPPET = 1,
			VEHICLE = 2,
			DEVICE = 3,
			GENERIC = 4
		}
		public enum scnAdditionalSpeakerRole
		{
			Full = 0,
			OnlyLipsync = 1
		}
		public enum scnAdditionalSpeakerType
		{
			Normal = 0,
			Holocall = 1
		}
		public enum scnAnimationCategory
		{
			Body = 0,
			Facial = 1,
			Cyberware = 2
		}
        public enum scnAnimNameType
		{
			direct = 0,
			reference = 1,
			container = 2,
			dynamic = 3
		}
		public enum scnAudioFastForwardSupport
		{
			MuteDuringFastForward = 1,
			DontMuteDuringFastForward = 2
		}
		public enum scnAudioPlaybackDirectionSupportFlag
		{
			Forward = 1,
			Backward = 2
		}
		public enum scnblocLocaleId
		{
			db_db = 0,
			pl_pl = 1,
			en_us = 2
		}
		public enum scnBraindanceLayer
		{
			Visual = 0,
			Audio = 1,
			Thermal = 2
		}
		public enum scnBraindancePerspective
		{
			FirstPerson = 0,
			ThirdPerson = 1
		}
		public enum scnBraindanceSpeed
		{
			Any = 0,
			Slow = 1,
			Normal = 2,
			Fast = 3,
			VeryFast = 4
		}
		public enum scnChoiceNodeNsChoiceNodeFlags
		{
			IsFocusClue = 1,
			IsValidInteractionFailsafeDisabled = 2
		}
		public enum scnChoiceNodeNsMappinLocation
		{
			None = 0,
			Interaction = 1,
			Nameplate = 2,
			ObjectDefault = 4
		}
		public enum scnChoiceNodeNsOperationMode
		{
			attachToActor = 0,
			attachToProp = 1,
			attachToGameObject = 2,
			attachToScreen = 3,
			attachToWorld = 4
		}
		public enum scnChoiceNodeNsSizePreset
		{
			small = 0,
			normal = 1,
			big = 2,
			Dialogue = 3,
			Interaction = 4,
			Dialogue360 = 5
		}
		public enum scnChoiceNodeNsTimedAction
		{
			appear = 0,
			disappear = 1,
			disappearFading = 2
		}
		public enum scnChoiceNodeNsVisualizerStyle
		{
			onScreen = 0,
			inWorld = 1
		}
		public enum scnContextualActorName
		{
			Player = 0,
			VoicesetHolder = 1,
			Voice = 2,
			SpecificVoicetagHolder = 3,
			ContextActorName = 4
		}
		public enum scndevEventType
		{
			DebugMessage = 0,
			NodeFailed = 1,
			NodeProgressSet = 2
		}
		public enum scnDialogLineLanguage
		{
			Origin = 0,
			Creole = 1,
			Japanese = 2,
			Arabic = 4,
			Russian = 5,
			Chinese = 6,
			Brasilian = 7,
			English = 8,
			Korean = 9
		}
		public enum scnDialogLineType
		{
			None = 0,
			Regular = 1,
			Holocall = 2,
			SceneComment = 3,
			OverHead = 4,
			Radio = 5,
			GlobalTV = 6,
			Invisible = 7,
			OverHeadAlwaysVisible = 9,
			OwnerlessRegular = 10,
			AlwaysCinematicNoSpeaker = 11,
			GlobalTVAlwaysVisible = 12
		}
		public enum scnDialogLineVisualStyle
		{
			regular = 0,
			overHead = 1,
			radio = 2,
			globalTV = 3,
			invisible = 4,
			innerDialog = 5,
			overHeadAlwaysVisible = 6,
			alwaysCinematicNoSpeaker = 7,
			globalTVAlwaysVisible = 8
		}
		public enum scnDistractedConditionTarget
		{
			Anyone = 0,
			Speaker = 1,
			SpeakerOrAddressee = 2
		}
		public enum scnEasingType
		{
			Linear = 0,
			SinusoidalEaseInOut = 1,
			QuadraticEaseIn = 2,
			QuadraticEaseOut = 3,
			CubicEaseInOut = 4,
			CubicEaseIn = 5,
			CubicEaseOut = 6
		}
		public enum scnEndNodeNsType
		{
			Terminating = 0,
			NonTerminating = 1
		}
		public enum scnEntityAcquisitionPlan
		{
			findInContext = 1,
			findInWorld = 2,
			spawnDespawn = 3,
			findInEntity = 4,
			spawnSet = 5,
			community = 6,
			spawner = 7,
			findInNode = 8,
			findNetworkPlayer = 9
		}
		public enum scneventsRidCameraPlacement
		{
			SceneOrigin = 0,
			Actual = 1,
			Player = 2
		}
		public enum scneventsUIAnimActionType
		{
			Play = 0,
			Update = 1,
			Resume = 2,
			Pause = 3,
			Stop = 4
		}
		public enum scneventsVFXActionType
		{
			Play = 0,
			Break = 1,
			Kill = 2
		}
		public enum scnEventType
		{
		}
		public enum scnFastForwardMode
		{
			Default = 0,
			GameplayReview = 1
		}
		public enum scnFastForwardStrategy
		{
			automatic = 0,
			allow_fully = 1,
			block_on_start = 2,
			block_on_end = 3,
			block_on_start_and_end = 4,
			block_fully = 5,
			block_on_end_if_activator_matched = 6
		}
		public enum scnfppBlendOverride
		{
			Centering = 0,
			CopyPitch_CenteringYaw = 1,
			CopyPitch_CopyYaw = 2,
			Custom_PitchYaw = 3
		}
		public enum scnfppParallaxSpace
		{
			Default = 0,
			Camera = 1,
			Trajectory = 2,
			Chest = 3
		}
		public enum scnInterruptCapability
		{
			None = 0,
			Interruptable = 1,
			NotInterruptable = 2
		}
		public enum scnInterruptReturnLinesBehavior
		{
			Default = 0,
			Vehicle = 1,
			Holocall = 2
		}
		public enum scnlocLocaleId
		{
			db_db = 0,
			pl_pl = 1,
			en_us = 2
		}
		public enum scnLookAtTargetType
		{
			Actor = 0,
			Prop = 1
		}
		public enum scnMarkerType
		{
			Local = 0,
			Global = 1,
			Entity = 2
		}
		public enum scnOffsetMode
		{
			useRealOffset = 0,
			useCustomOffset = 1
		}
		public enum scnPlayDirection
		{
			Forward = 0,
			Backward = 1
		}
		public enum scnPlaySpeed
		{
			Pause = 0,
			Slow = 1,
			Normal = 2,
			Fast = 3,
			VeryFast = 4
		}
		public enum scnPropOwnershipTransferOptionsType
		{
			TransferToWorkspotSystem_Automatic = 0,
			TransferToWorkspotSystem_Custom = 1,
			DisposeAfterScene = 2
		}
		public enum scnPuppetVehicleState
		{
			IdleMounted = 0,
			IdleStand = 1,
			CombatWindowed = 2,
			CombatSeated = 3,
			Turret = 4,
			GunnerSlot = 5
		}
		public enum scnRandomizerMode
		{
			Random = 0,
			IgnoreLastUsed = 1,
			IgnoreAllUsed = 2
		}
		public enum scnReminderConditionProcessStep
		{
			ReminderA = 0,
			ReminderB = 1,
			ReminderC = 2,
			Looping = 3
		}
		public enum scnRidActorPlacement
		{
			SceneOrigin = 0,
			Actual = 1,
			Player = 2
		}
		public enum scnRootMotionAnimPlacementMode
		{
			Blend = 0,
			TeleportToStart = 1,
			PlayAtActorPosition = 2
		}
		public enum scnSceneCategoryTag
		{
			voiceset = 0,
			mainQuests = 1,
			sideQuests = 2,
			minorQuests = 3,
			otherQuests = 4,
			dialoguesQuests = 5,
			streetOpenWorld = 6,
			vendorsOpenWorld = 7,
			dancefloorsOpenWorld = 8,
			cityOpenWorld = 9,
			chatsOpenWorld = 10,
			otherOpenWorld = 11,
			other = 12
		}
		public enum scnscreenplayItemType
		{
			invalid = 0,
			dialogLine = 1,
			choiceOption = 2,
			standaloneComment = 3
		}
		public enum scnSectionInternalsActorBehaviorMode
		{
			OnlyIfAlive = 0,
			EvenIfDead = 1
		}
		public enum scnWorldMarkerType
		{
			Tag = 0,
			NodeRef = 1
		}
		public enum SecurityEventScopeSettings
		{
			GLOBAL = 0,
			AREA_WHERE_PLAYER_IS = 1,
			SPECIFIC_AGENTS_ONLY = 2
		}
		public enum senseAdditionalTraceType
		{
			Knee = 0,
			Hip = 1,
			Chest = 2
		}
		public enum senseEShapeType
		{
			INVALID = -1,
			BOX = 0,
			SPHERE = 1,
			CONE = 2,
			ANGLE_RANGE = 3
		}
		public enum senseTracingFreq
		{
			Never = 0,
			Lowest = 1,
			Low = 2,
			Medium = 3,
			High = 4,
			Highest = 5
		}
		public enum SettingsType
		{
			Slider = 0,
			Toggle = 1,
			DropdownList = 2
		}
		public enum sharedCommandResult
		{
			Success = 0,
			NeedOptions = 1,
			Fail = 2,
			Abort = 3
		}
		public enum sharedMenuItemType
		{
			Action = 0,
			Checked = 1,
			Group = 2,
			Separator = 3
		}
		public enum SignalType
		{
			DEFAULT = 0,
			REGISTRATION = 1,
			UNREGISTRATION = 2
		}
		public enum SignShape
		{
			RECTANGLE = 0,
			ARROWLEFT = 1,
			ARROWRIGHT = 2,
			SQUARE = 3
		}
		public enum SignType
		{
			INFORMATION = 0,
			ATTENTION = 1,
			WARNING = 2
		}
		public enum SlotType
		{
			DEFAULT = 0,
			HOLSTER = 1,
			WEAPON = 2,
			COMBAT_CYBERWARE = 3,
			TOOLTIP = 4,
			MISC = 5
		}
		public enum StaticShaderInputLayout
		{
			DebugVertexBase = 0,
			DebugVertexUV = 1,
			DebugVertexUV_Fullscreen = 2,
			NoBuffers_Fullscreen = 3,
			NoBuffers_PointList = 4
		}
		public enum telemetryLevelGainReason
		{
			Ignore = 0,
			Gameplay = 1,
			IsDebug = 2
		}
		public enum tempshitMapPinOperation
		{
			Undefined = 0,
			Add = 1,
			Remove = 2
		}
		public enum textHorizontalAlignment
		{
			Left = 0,
			Center = 1,
			Right = 2
		}
		public enum textJustificationType
		{
			Left = 0,
			Center = 1,
			Right = 2
		}
		public enum textLetterCase
		{
			OriginalCase = 0,
			UpperCase = 1,
			LowerCase = 2
		}
		public enum textOverflowPolicy
		{
			None = 0,
			DotsEnd = 1,
			DotsEndLastLine = 2,
			AutoScroll = 3,
			PingPongScroll = 4,
			AdjustToSize = 5
		}
		public enum textTextDirection
		{
			LeftToRight = 0,
			RightToLeft = 1,
			Mixed = 2
		}
		public enum textTextFlowDirection
		{
			Auto = 0,
			LeftToRight = 1,
			RightToLeft = 2
		}
		public enum textTextShapingMethod
		{
			Auto = 0,
			KerningOnly = 1,
			FullShaping = 2
		}
		public enum textVerticalAlignment
		{
			Top = 0,
			Center = 1,
			Bottom = 2
		}
		public enum textWrappingPolicy
		{
			Default = 0,
			PerCharacter = 1
		}
		public enum ThrowType
		{
			Quick = 0,
			Charge = 1
		}
		public enum Tier2WalkType
		{
			Undefined = 0,
			Slow = 1,
			Normal = 2,
			Fast = 3
		}
		public enum toolsMessageSeverity
		{
			Success = 0,
			Info = 1,
			Warning = 2,
			Error = 3
		}
		public enum toolsMessageTokenType
		{
			Text = 0,
			Location = 1,
			Tag = 2
		}
		public enum TrafficGenDynamicImpact
		{
			Ignored = 0,
			Blocking = 1
		}
		public enum TrafficGenMeshImpact
		{
			UseNavigation = 0,
			ForceIgnored = 1,
			ForceBlocking = 2
		}
		public enum TweakWeaponPose
		{
			Nothing = 0,
			Position = 1,
			Rotation = 2
		}
		public enum UIGameContext
		{
			Default = 0,
			QuickHack = 1,
			Scanning = 2,
			DeviceZoom = 3,
			BraindanceEditor = 4,
			BraindancePlayback = 5,
			VehicleMounted = 6,
			ModalPopup = 7,
			RadialWheel = 8,
			VehicleRace = 9
		}
		public enum UIInGameNotificationType
		{
			ActionRestriction = 0,
			CombatRestriction = 1,
			CantSaveActionRestriction = 2,
			CantSaveCombatRestriction = 3,
			CantSaveQuestRestriction = 4,
			CantSaveDeathRestriction = 5,
			NotEnoughSlotsSaveResctriction = 6,
			NotEnoughSpaceSaveResctriction = 7
		}
		public enum UIMenuNotificationType
		{
			VendorNotEnoughMoney = 0,
			VNotEnoughMoney = 1,
			VendorRequirementsNotMet = 2,
			InventoryActionBlocked = 3,
			CraftingNoPerks = 4,
			CraftingNotEnoughMaterial = 5,
			UpgradingLevelToLow = 6,
			NoPerksPoints = 7,
			PerksLocked = 8,
			MaxLevelPerks = 9,
			NoAttributePoints = 10,
			InCombat = 11
		}
		public enum UIObjectiveEntryType
		{
			Invalid = 0,
			Quest = 1,
			Objective = 2,
			SubObjective = 3
		}
		public enum UpdateBucketEnum
		{
			Vehicle = 0,
			Character = 1,
			AttachedObject = 2
		}
		public enum vehicleAudioEventAction
		{
			OnPlayerDriving = 0,
			OnPlayerPassenger = 1,
			OnPlayerEnterCombat = 2,
			OnPlayerExitCombat = 3,
			OnPlayerExitVehicle = 4,
			OnPlayerVehicleSummoned = 5
		}
		public enum vehicleBikeCurve
		{
			SpeedToTilt = 0,
			InputToTilt = 1
		}
		public enum vehicleCameraPerspective
		{
			FPP = 0,
			TPPClose = 1,
			TPPFar = 2
		}
		public enum vehicleCameraType
		{
			FPP = 0,
			TPP = 1
		}
		public enum vehicleELightMode
		{
			Off = 0,
			On = 1,
			HighBeams = 2
		}
		public enum vehicleELightType
		{
			Head = 1,
			Brake = 2,
			LeftBlinker = 4,
			RightBlinker = 8,
			Blinkers = 12,
			Reverse = 16,
			Interior = 32,
			Default = 47,
			Utility = 64
		}
		public enum vehicleEQuestVehicleDoorState
		{
			ForceOpen = 0,
			ForceClose = 1,
			OpenAll = 2,
			CloseAll = 3,
			ForceLock = 4,
			ForceUnlock = 5,
			LockAll = 6,
			EnableInteraction = 7,
			DisableInteraction = 8,
			DisableAllInteractions = 9,
			ResetInteractions = 10,
			ResetVehicle = 11,
			OpenAllRegular = 12,
			QuestLock = 13,
			QuestLockAll = 14,
			Count = 15,
			Invalid = 16
		}
		public enum vehicleEQuestVehicleWindowState
		{
			ForceOpen = 0,
			ForceClose = 1,
			OpenAll = 2,
			CloseAll = 3
		}
		public enum vehicleEState
		{
			Default = 1,
			On = 2,
			Disabled = 3,
			Destroyed = 4
		}
		public enum vehicleESummonedVehicleType
		{
			Any = 0,
			Car = 1,
			Motorcycle = 2
		}
		public enum vehicleEVehicleDoor
		{
			seat_front_left = 0,
			seat_front_right = 1,
			seat_back_left = 2,
			seat_back_right = 3,
			trunk = 4,
			hood = 5,
			count = 6,
			invalid = 7
		}
		public enum vehicleEVehicleSpeedConditionType
		{
			CT_EQUAL = 0,
			CT_NOT_EQUAL = 1,
			CT_GREATER = 2,
			CT_GREATER_EQUAL = 3,
			CT_LESS = 4,
			CT_LESS_EQUAL = 5,
			CT_ABS_GREATER = 6,
			CT_ABS_GREATER_EQUAL = 7,
			CT_ABS_LESS = 8,
			CT_ABS_LESS_EQUAL = 9
		}
		public enum vehicleEVehicleWindowState
		{
			Closed = 0,
			Open = 1
		}
		public enum vehicleExitDirection
		{
			NoDirection = -1,
			Left = 0,
			Right = 1,
			Front = 2,
			Back = 3,
			Top = 4
		}
		public enum vehicleFormationType
		{
			FORMATION_TRIANGLE = 0,
			FORMATION_TURTLE = 1,
			FORMATION_QUINCUNX = 2
		}
		public enum vehicleGarageState
		{
			NoVehiclesAvailable = 0,
			SummonAvailable = 1,
			SummonDisabled = 2
		}
		public enum vehiclePlayerToAIInterpolationType
		{
			PTAIT_INSTANT = 0,
			PTAIT_LINEAR = 1,
			PTAIT_EASE_IN_QUAD = 2,
			PTAIT_EASE_IN_CUBIC = 3,
			PTAIT_EASE_OUT_CUBIC = 4,
			PTAIT_EASE_IN_OUT_CUBIC = 5,
			PTAIT_EASE_IN_QUANTIC = 6,
			PTAIT_EASE_IN_SIN = 7,
			PTAIT_EASE_OUT_SIN = 8,
			PTAIT_EASE_IN_OUT_SIN = 9,
			PTAIT_LINEAR_NON_SMOOTHED = 10,
			PTAIT_EASE_IN_QUAD_NON_SMOOTHED = 11,
			PTAIT_EASE_IN_CUBIC_NON_SMOOTHED = 12,
			PTAIT_EASE_OUT_CUBIC_NON_SMOOTHED = 13,
			PTAIT_EASE_IN_OUT_CUBIC_NON_SMOOTHED = 14,
			PTAIT_EASE_IN_QUANTIC_NON_SMOOTHED = 15,
			PTAIT_EASE_IN_SIN_NON_SMOOTHED = 16,
			PTAIT_EASE_OUT_SIN_NON_SMOOTHED = 17,
			PTAIT_EASE_IN_OUT_SIN_NON_SMOOTHED = 18
		}
		public enum vehicleQuestUIEnable
		{
			Gameplay = 0,
			ForceEnable = 1,
			ForceDisable = 2
		}
		public enum vehicleQuestWindowDestruction
		{
			window_f = 0,
			window_fl = 1,
			window_fr = 2,
			window_bl = 3,
			window_br = 4,
			window_b = 5
		}
		public enum vehicleRaceUI
		{
			PreRaceSetup = 0,
			CountdownStart = 1,
			RaceStart = 2,
			RaceEnd = 3,
			Disable = 4
		}
		public enum vehicleSummonFinishState
		{
			Arrived = 0
		}
		public enum vehicleSummonState
		{
			Idle = 0,
			EnRoute = 1,
			AlreadySummoned = 2,
			PathfindingFailed = 3,
			Arrived = 4
		}
		public enum vehicleTPPCameraDistance
		{
			Close = 0,
			Far = 1
		}
		public enum vehicleTPPCameraHeight
		{
			Low = 0,
			High = 1
		}
		public enum vehicleVehicleDoorInteractionState
		{
			Available = 0,
			Locked = 1,
			Disabled = 2,
			QuestLocked = 3,
			Reserved = 4
		}
		public enum vehicleVehicleDoorState
		{
			Closed = 0,
			Open = 1,
			Detached = 2
		}
		public enum VendorConfirmationPopupType
		{
			Default = 0,
			ExpensiveItem = 1,
			EquippedItem = 2
		}
		public enum vgEStyleAttributeType
		{
			FillColor = 0,
			StrokeColor = 1,
			StrokeSize = 2,
			StrokeMiterLimit = 3,
			FontFamily = 4,
			FontSize = 5
		}
		public enum VisualState
		{
			OFF = 0,
			RUNNING = 1,
			MALFUNCTIONING = 2,
			ON = 3
		}
		public enum visWorldOccluderType
		{
            [RED("")]
			Default = 0,
			None = 1,
			Detail = 2,
			MinorInterior = 3,
			MajorInterior = 4,
			Exterior = 5
		}
		public enum WeaponPartType
		{
			Scope = 0,
			Magazine = 1,
			Silencer = 2
		}
		public enum workLogicalOperation
		{
			AND = 0,
			OR = 1
		}
		public enum workPropAttachMethod
		{
			BonePosition = 0,
			RelativePosition = 1,
			Custom = 2
		}
		public enum WorkspotConditionOperators
		{
			OR = 0,
			AND = 1
		}
		public enum WorkspotWeaponConditionEnum
		{
			None = 0,
			Any = 1,
			Ranged = 2,
			OneHandedRanged = 3,
			Melee = 4,
			MeleeCyberware = 5,
			LMG = 6
		}
		public enum workWeaponType
		{
			Any = 0,
			Ranged = 1,
			OneHandedRanged = 2,
			AssaultRifle = 3,
			Hammer = 5,
			Handgun = 6,
			HeavyMachineGun = 7,
			Katana = 8,
			Knife = 9,
			LightMachineGun = 10,
			LongBlade = 11,
			Melee = 12,
			OneHandedClub = 13,
			PrecisionRifle = 14,
			Revolver = 15,
			Rifle = 16,
			ShortBlade = 17,
			Shotgun = 18,
			ShotgunDual = 19,
			SniperRifle = 20,
			SubmachineGun = 21,
			TwoHandedClub = 22
		}
		public enum workWorkspotDebugMode
		{
			VisualLogToogle = 2,
			VisualLogOn = 4,
			VisualLogOff = 8,
			VisualStateToogle = 16,
			VisualStateOn = 32,
			VisualStateOff = 64,
			RecorderOn = 128,
			RecorderOff = 256,
			PlaybackOn = 512,
			PlaybackOff = 1024,
			Invalid = 4096,
			FunctionalTests = 8192
		}
		public enum workWorkspotLogic
		{
			Allow = 0,
			Deny = 1
		}
		public enum worldEClusteringModel
		{
			HierarchicalGrid = 0,
			AlwaysLoaded = 1,
			Discard = 2
		}
		public enum worldEditablePrefabType
		{
			Regular = 0,
			Decoration = 1,
			Quest = 2,
			Building = 3,
			Road = 4
		}
		public enum worldenvUtilsEBlendParamsType
		{
			EBPS_Tick = 0,
			EBPS_Game = 1,
			EBPS_Frame = 2
		}
		public enum worldFindLaneFilter
		{
			None = 0,
			Road = 1,
			PatrolRoute = 2,
			Pavement = 3
		}
		public enum worldgeometryaverageNormalDetectionHelperQueryStatus
		{
			Finished = 0,
			NoGeometry = 1
		}
		public enum worldgeometryDescriptionQueryFlags
		{
			DistanceVector = 1,
			CollisionNormal = 2,
			ObstacleDepth = 4,
			UpExtent = 8,
			DownExtent = 16,
			TopExtent = 32,
			TopPoint = 64,
			BehindPoint = 128
		}
		public enum worldgeometryDescriptionQueryStatus
		{
			OK = 0,
			NoGeometry = 1,
			UpVectorSameAsDirection = 2
		}
		public enum worldgeometryProbingStatus
		{
			None = 0,
			StillInObstacle = 1,
			GeometryDiverged = 2,
			Failure = 3
		}
		public enum WorldMapTooltipType
		{
			Default = 0,
			Police = 1,
			District = 2
		}
		public enum worldNavigationRequestStatus
		{
			OK = 0,
			InvalidStartingPosition = 1,
			InvalidEndPosition = 2,
			OtherError = 3
		}
		public enum worldNodeGroupType
		{
			RegularGroup = 0,
			PrefabVariant = 1,
			DecorationCell = 2,
			ProxyGroup = 3
		}
		public enum worldNodeSocketType
		{
			Bidirectional = 0,
			Inward = 1,
			Outward = 2,
			Disabled = 3
		}
		public enum worldObjectTag
		{
			WallExterior = 1164730711,
			WallInterior = 1231839575,
			Discard = 1668507972,
			Ladder = 1684300108,
			None = 1701736270,
			Decoration = 1868784964,
			Floor = 1869573190,
			Cover = 1920364355,
			Stairs = 1936880723
		}
		public enum worldObjectTagExt
		{
			Default = 1634100548,
			NonClimbable = 1651262286,
			None = 1701736270
		}
		public enum worldOffMeshConnectionType
		{
			Door = 0,
			Ladder = 1,
			Floor = 2,
			Jump = 3,
			Elevator = 4,
			Drone = 5,
			Exploration = 6,
			Custom = 7,
			Blockade = 8
		}
		public enum worldPatrolSplinePointTypes
		{
			Workspot = 0,
			LookAt = 1,
			ClearLookAt = 2
		}
		public enum worldPrefabMinimapContribution
		{
			Auto = 0,
			Include = 1,
			Discard = 2
		}
		public enum worldPrefabOwnership
		{
			None = 0,
			Quest = 1,
			Audio = 2,
			Environment = 3,
			FX = 4,
			LevelDesign = 5,
			Lighting = 6,
			OpenWorld = 7,
			Cinematics = 8
		}
		public enum worldPrefabProxyMeshOnly
		{
			SettingFromResource = 0,
			Enabled = 1,
			Disabled = 2
		}
		public enum worldPrefabStreamingOcclusion
		{
			Default = 0,
			Interior = 1,
			OpenInterior = 2
		}
		public enum worldPrefabType
		{
			Regular = 0,
			Area = 1,
			Generated = 2,
			Decoration = 3,
			Quest = 4,
			Road = 5,
			Building = 6,
			Terrain = 7
		}
		public enum worldProxWindowsType
		{
			SkipWindows = 0,
			PropagateWindows = 1,
			BakeLongDistantWindows = 2,
			BakeWindowsToBuffer = 3
		}
		public enum worldProxyBBoxSyncOptions
		{
			Do_Nothing = 0,
			Pull = 1,
			Pull_And_Delete = 2
		}
		public enum worldProxyCoreAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}
		public enum worldProxyGroupingNormals
		{
			Around_Core_Axis = 0,
			Around_All_Axes = 1
		}
		public enum worldProxyMeshBuildType
		{
			ProxyFromProxy = 0,
			ProxyFromScratch = 1,
			OnlyFromChildProxies = 2
		}
		public enum worldProxyMeshDependencyMode
		{
			Auto = 0,
			Discard = 1
		}
		public enum worldProxyMeshOutputType
		{
			RayScan = 0,
			SurfaceReconstruction = 1,
			LegacyFromVoxels = 2,
			FromCustomMesh = 3,
			FromBoxes = 4,
			FromCollision = 5,
			FromConvexHull = 6,
			BoundsCombine = 7,
			BlobCrowd = 8,
			KeepCurrent = 127
		}
		public enum worldProxyMeshTexRes
		{
			RES_64 = 0,
			RES_128 = 1,
			RES_256 = 2,
			RES_512 = 3,
			RES_1024 = 4
		}
		public enum worldProxyMeshUVType
		{
			UvUseExisting = 0,
			UvGenerateNew = 1
		}
		public enum worldProxyNormalAngleStepSize
		{
			STEP_90 = 0,
			STEP_45 = 1,
			STEP_15 = 2,
			STEP_5 = 3
		}
		public enum worldProxySyncNormalSource
		{
			From_Groups = 0,
			From_Face_Average = 1
		}
		public enum worldQuestPrefabLoadingMode
		{
			Disable = 0,
			ForceLoad = 1
		}
		public enum worldQuestType
		{
			MainQuest = 0,
			SideQuest = 1,
			StreetStory = 2
		}
		public enum worldRainIntensity
		{
			NoRain = 0,
			LightRain = 1,
			HeavyRain = 2
		}
		public enum worldRoadMaterial
		{
			Concrete = 0,
			ConcreteDestroyed = 1,
			Dirt = 2,
			HardenedDirtDestroyed = 3
		}
		public enum worldRotatingMeshNodeAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}
		public enum worldSpeedSplineOrientationMarkerType
		{
			UseSplineOrientation = 0,
			WorldSpace = 1,
			LocalSpace = 2,
			KeepYawRoll_WorldSpacePitch = 3,
			KeepPitchYaw_WorldSpaceRoll = 4,
			KeepPitchRoll_WorldSpaceYaw = 5,
			KeepYaw_WorldSpacePitchRoll = 6,
			KeepRoll_WorldSpacePitchYaw = 7,
			KeepPitch_WorldSpaceYawRoll = 8
		}
		public enum worldStreamingTestCheckpointType
		{
			BeginMove = 0,
			EndMove = 1
		}
		public enum worldTrafficLightColor
		{
			GREEN = 0,
			RED = 1,
			YELLOW = 2,
			INVALID = 3
		}
		public enum worldTrafficMovementBehavior
		{
			Pedestrian = 0,
			Car = 1
		}
		public enum worldTrafficSplineNodeUsage
		{
			Pavement = 0,
			Road = 1
		}
		public enum worldTrafficSpotDirection
		{
			Forward = 0,
			Backward = 1,
			Both = 2
		}
		public enum worlduiEntryVisibility
		{
			TierVisibility = 0,
			ForceShow = 1,
			ForceHide = 2
		}
    }
}
