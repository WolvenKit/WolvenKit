using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable InconsistentNaming

namespace WolvenKit.CR2W.Types
{
    public static partial class Enums
    {

        #region Not found in Ghidra
        public enum ELinkedSocketPlacement
        {

        }
        public enum ELinkedSocketDirection
        {

        }
        public enum ELinkedSocketDrawStyle
        {

        }
        public enum EModLogLevel
        {

        }
        public enum EStoryBoardActorType
        {

        }
        public enum WmkAreaPositionType
        {

        }
        public enum EWetnessOverrideType
        {

        }
        
        
        
        
        
        public enum ENoiseTypes
        {

        }
        public enum EGradientTypes
        {

        }
        public enum EGradientExtrapolationModes
        {

        }
        public enum EFrameBasisTypes
        {

        }
        #endregion

        #region Enums with shitty names
        public enum EApertureValue
        {
            f10,
            f14,
            f20,
            f28, //f/2.8
            f40,
            f56,
            f80,
            f110,
            f160,
            f220,
            f320
        }
        public enum EStorySceneForcingMode
        {
            Dontforceanything, //Don't force anything
            Forceposition, //Force position
            Forcepositionwithcamerablending, //Force position with camera blending
            Spawnandforceposition, //Spawn and force position
            Spawnactorswhenneeded   //Spawn actors when needed
        }
        #endregion

        #region Flags
        //[Flags] // not found
        public enum EFoodGroup
        {
            FG_Corpse = 1,
            FG_Meat = 2,
            FG_Vegetable = 4,
            FG_Water = 8,
            FG_Monster = 16
        }
        [Flags]
        public enum ECameraLightBitfield
        {
            //Unknown,
            ECLB_AbsoluteBrightness = 1,
            ECLB_AbsoluteRadius = 2,
            ECLB_AbsoluteOffset = 4
        }
        [Flags] // done
        public enum EMeshChunkRenderMask
        {
            MCR_Scene = 1,
            MCR_Cascade1 = 2,
            MCR_Cascade2 = 4,
            MCR_Cascade3 = 8,
            MCR_Cascade4 = 0x10,
            MCR_LocalShadows = 0x20
        }
        [Flags] //done
        public enum ELightChannel
        {
            LC_Characters = 2,
            LC_Interactive = 4,
            LC_Custom0 = 8,
            LC_FoliageOutline = 0x10,
            LC_VisibleThroughtWalls = 0x20
        }
        [Flags] //done
        public enum EDismembermentEffectTypeFlag
        {
            DETF_Base = 1,
            DETF_Igni = 2,
            DETF_Aaard = 4,
            DETF_Yrden = 8,
            DETF_Quen = 0x10,
            DETF_Mutation6 = 0x20,
        }
        [Flags] //done
        public enum ELightUsageMask
        {
            LUM_Custom0 = 1,
            LUM_Custom1 = 2,
            LUM_Custom2 = 4,
            LUM_Custom3 = 8,
            LUM_Custom4 = 0x10,
            LUM_Custom5 = 0x20,
            LUM_Custom6 = 0x40,
            LUM_Custom7 = 0x80,
            LUM_RenderToEnvProbe = 0x100,
            LUM_ExcludeFromSceneRender = 0x200,
            LUM_IsInteriorOnly = 0x400,
            LUM_IsExteriorOnly = 0x800,
        }
        [Flags] //done
        public enum EMovementFlags
        {
            MM_CombatMode = 1,
            MM_MoveSliding = 2
        }
        [Flags] //done
        public enum ETriggerChannel
        {
            TC_Default = 1,
            TC_Player = 2,
            TC_Camera = 4,
            TC_NPC = 8,
            TC_SoundReverbArea = 0x10,
            TC_SoundAmbientArea = 0x20,
            TC_Quest = 0x40,
            TC_Projectiles = 0x80,
            TC_Horse = 0x100,
            TC_Custom1 = 0x20000,
            TC_Custom2 = 0x40000,
            TC_Custom3 = 0x80000,
            TC_Custom4 = 0x100000,
            TC_Custom5 = 0x200000,
            TC_Custom6 = 0x400000,
            TC_Custom7 = 0x800000,
            TC_Custom8 = 0x1000000,
            TC_Custom9 = 0x2000000,
            TC_Custom10 = 0x4000000,
            TC_Custom11 = 0x8000000,
            TC_Custom12 = 0x10000000,
            TC_Custom13 = 0x20000000,
            TC_Custom14 = 0x40000000
        }
        [Flags] //done
        public enum EImmunityFlags
        {
            IF_Potion = 1,
            IF_Positive = 2,
            IF_Negative = 4,
            IF_Neutral = 8,
            IF_Immobilize = 0x10,
            IF_Confuse = 0x20,
            IF_Damage = 0x40
        }
        [Flags] //done
        public enum EEntityStaticFlags
        {
            ESF_Streamed = 1,
            ESF_NoVisibilityQuery = 2,
            ESF_NoCompExtract = 4,
            ESF_NoCompMerge = 8
        }
        [Flags] //done
        public enum EDrawableFlags
        {
            DF_IsVisible = 1,
            DF_CastShadows = 2,
            DF_NoLighting = 4,
            DF_LocalWindSimulation = 8,
            DF_UseInAllApperances = 0x10,
            DF_NoColoring = 0x20,
            DF_NoDissolves = 0x40,
            DF_CameraTransformRotate = 0x80,
            DF_CameraTransformOnlyPosition = 0x100,
            DF_CastShadowsWhenNotVisible = 0x200,
            DF_CastShadowsFromLocalLightsOnly = 0x400,
            DF_ForceNoAutohide = 0x800,
            DF_DynamicGeometry = 0x4000,
            DF_ForceTwoSided = 0x10000,
            DF_ForceHighestLOD = 0x20000,
            DF_MissedUpdateTransform = 0x40000,
            DF_Collapsed = 0x80000,
            DF_ClimbBlock = 0x100000,
            DF_ClimbabUnlock = 0x200000,
            DF_IsCharacterShadowFallback = 0x800000,
            DF_UseWithSimplygonOnly = 0x1000000
        }
        [Flags] //done
        public enum EHardAttachmentFlags
        {
            HAF_FreePositionAxisX = 1,
            HAF_FreePositionAxisY = 2,
            HAF_FreePositionAxisZ = 4,
            HAF_FreeRotation = 8,
        }
        [Flags] //done
        public enum ESkeletonBoneFlags
        {
            SBF_LockTranslation = 1
        }
        #endregion

        #region Scripted Enums
        public enum EPlayerPreviewInventory
        {
            PPI_default,
            PPI_Bear_1,
            PPI_Bear_4,
            PPI_Lynx_1,
            PPI_Lynx_4,
            PPI_Gryphon_1,
            PPI_Gryphon_4,
            PPI_Common_1,
            PPI_Naked,
            PPI_Viper,
            PPI_Red_Wolf_1
        }
        public enum EStaticCameraAnimState
        {
            SCAS_Default,
            SCAS_Collapsed,
            SCAS_Window,
            SCAS_ShakeTower
        }
        public enum EStaticCameraGuiEffect
        {
            SCGE_None,
            SCGE_Hole
        }
        public enum EEncounterSpawnGroup
        {
            ESG_Quest,
            ESG_Important,
            ESG_CoreCommunity,
            ESG_SecondaryCommunity,
            ESG_OptionalCommunity
        }
        public enum EBehaviorGraph
        {
            EBG_None,
            EBG_Combat_Undefined,
            EBG_Combat_Shield,
            EBG_Combat_1Handed_Sword,
            EBG_Combat_1Handed_Axe,
            EBG_Combat_1Handed_Blunt,
            EBG_Combat_1Handed_Any,
            EBG_Combat_2Handed_Any,
            EBG_Combat_2Handed_Sword,
            EBG_Combat_2Handed_Hammer,
            EBG_Combat_2Handed_Axe,
            EBG_Combat_2Handed_Halberd,
            EBG_Combat_2Handed_Spear,
            EBG_Combat_2Handed_Staff,
            EBG_Combat_Fists,
            EBG_Combat_Bow,
            EBG_Combat_Crossbow,
            EBG_Combat_Witcher,
            EBG_Combat_Sorceress,
            EBG_Combat_WildHunt_Imlerith,
            EBG_Combat_WildHunt_Imlerith_Second_Stage,
            EBG_Combat_WildHunt_Caranthir,
            EBG_Combat_WildHunt_Caranthir_Second_Stage,
            EBG_Combat_WildHunt_Eredin,
            EBG_Combat_Olgierd,
            EBG_Combat_Caretaker,
            EBG_Combat_Dettlaff_Vampire,
            EBG_Combat_Gregoire,
            EBG_Combat_Dettlaff_Minion

        }
        public enum EStorySceneGameplayAction
        {
            SSGA_None,
            SSGA_Walk_2m,
            SSGA_Walk_5m,
            SSGA_Walk_8m,
            SSGA_Walk_2m_GoTo_Combat,
            SSGA_Walk_5m_GoTo_Combat,
            SSGA_Walk_8m_GoTo_Combat,
            SSGA_Walk_2m_GoTo_Combat_Silver,
            SSGA_Walk_5m_GoTo_Combat_Silver,
            SSGA_Walk_8m_GoTo_Combat_Silver,
            SSGA_GoTo_Combat_Pose,
            SSGA_GoTo_Combat_Pose_Silver,
            SSGA_GoTo_Combat_Pose_Fists,
            SSGA_EndInWork,
            SSGA_DelayWork
        }
        public enum EJobTreeType
        {
            EJTT_NothingSpecial,
            EJTT_Praying,
            EJTT_InfantInHand,
            EJTT_Sitting,
            EJT_PlayingMusic,
            EJTT_CatOnLap,
        }
        public enum EAchievement
        {
            EA_Undefined,


            EA_FoundYennefer,
            EA_FreedDandelion,
            EA_YenGetInfoAboutCiri,
            EA_FindBaronsFamily,
            EA_FindCiri,
            EA_ConvinceGeelsToBetrayEredin,
            EA_DefeatEredin,
            EA_FinishTheGameEasy,
            EA_FinishTheGameNormal,
            EA_FinishTheGameHard,
            EA_CompleteWitcherContracts,
            EA_CompleteSkelligeRaceForCrown,
            EA_CompleteWar,
            EA_CompleteKeiraMetz,
            EA_GetAllForKaerMorhenBattle,


            EA_Dendrology,
            EA_EnemyOfMyFriend,
            EA_FusSthSth,
            EA_EnvironmentUnfriendly,
            EA_TrainedInKaerMorhen,
            EA_TheEvilestThing,
            EA_TechnoProgress,
            EA_LearningTheRopes,
            EA_FundamentalsFirst,
            EA_TrialOfGrasses,
            EA_BreakingBad,
            EA_Bombardier,
            EA_Swank,
            EA_Rage,


            EA_GwintMaster,
            EA_Unused,
            EA_MonsterHuntFogling,
            EA_MonsterHuntEkimma,
            EA_MonsterHuntLamia,
            EA_MonsterHuntFiend,
            EA_MonsterHuntDao,
            EA_MonsterHuntDoppler,
            EA_BrawlMaster,
            EA_NeedForSpeed,
            EA_Brawler,


            EA_Finesse,
            EA_PowerOverwhelming,
            EA_Cerberus,
            EA_Bookworm,
            EA_Immortal,
            EA_FistOfTheSouthStar,
            EA_Explorer,
            EA_PestControl,
            EA_FireInTheHole,
            EA_FullyArmed,
            EA_GwintCollector,
            EA_Allin,
            EA_GeraltandFriends,



            EA_ToadPrince,
            EA_PartyAnimal,
            EA_Auctioneer,
            EA_TheCompletePicture,
            EA_HeartsOfStone,
            EA_KillEtherals,


            EA_FeatherStrongerThanSword,
            EA_Thirst,
            EA_DivineWhip,
            EA_LatestFashion,
            EA_WantedDeadOrBovine,
            EA_Slide,
            EA_KilledIt,


            EA_BeauclairWelcomeTo,
            EA_HeroOfBeauclair,
            EA_BeauclairMostWanted,
            EA_ChampionOfBeauclair,
            EA_LikeAVirgin,
            EA_HomeSweetHome,
            EA_TurnedEveryStone,
            EA_GotToHaveThemAll,
            EA_BloodAndWine,
            EA_ReadyToRoll,
            EA_SchoolOfTheMutant,
            EA_HastaLaVista,
            EA_Goliath
        }
        public enum EEffectType
        {
            EET_Undefined,


            EET_AutoVitalityRegen,
            EET_AutoStaminaRegen,
            EET_AutoEssenceRegen,
            EET_AutoMoraleRegen,


            EET_Confusion,
            EET_HeavyKnockdown,
            EET_Hypnotized,
            EET_Immobilized,
            EET_Knockdown,
            EET_KnockdownTypeApplicator,
            EET_Frozen,
            EET_Paralyzed,
            EET_Stagger,
            EET_Blindness,
            EET_PoisonCritical,


            EET_Bleeding,
            EET_BleedingTracking,
            EET_Burning,
            EET_Poison,
            EET_DoTHPRegenReduce,


            EET_Toxicity,


            EET_BlackBlood,
            EET_Blizzard,
            EET_Cat,
            EET_FullMoon,
            EET_GoldenOriole,
            EET_MariborForest,
            EET_PetriPhiltre,
            EET_Swallow,
            EET_TawnyOwl,
            EET_Thunderbolt,
            EET_Unused1,
            EET_WhiteHoney,
            EET_WhiteRaffardDecoction,
            EET_KillerWhale,


            EET_AxiiGuardMe,
            EET_IgnorePain,


            EET_StaggerAura,
            EET_OverEncumbered,
            EET_Edible,
            EET_LowHealth,
            EET_Slowdown,
            EET_Fact,
            EET_WellFed,
            EET_SlowdownFrost,


            EET_LongStagger,
            EET_WellHydrated,
            EET_BattleTrance,
            EET_YrdenHealthDrain,
            EET_AdrenalineDrain,
            EET_WeatherBonus,
            EET_Swarm,
            EET_Pull,
            EET_AbilityOnLowHealth,
            EET_Oil,
            EET_CounterStrikeHit,
            EET_Drowning,
            EET_Snowstorm,
            EET_AutoAirRegen,


            EET_ShrineAard,
            EET_ShrineAxii,
            EET_ShrineIgni,
            EET_ShrineQuen,
            EET_ShrineYrden,


            EET_Ragdoll,
            EET_AutoPanicRegen,
            EET_VitalityDrain,
            EET_DoppelgangerEssenceRegen,
            EET_FireAura,
            EET_BoostedEssenceRegen,
            EET_AirDrain,
            EET_SilverDust,


            EET_Mutagen01,
            EET_Mutagen02,
            EET_Mutagen03,
            EET_Mutagen04,
            EET_Mutagen05,
            EET_Mutagen06,
            EET_Mutagen07,
            EET_Mutagen08,
            EET_Mutagen09,
            EET_Mutagen10,
            EET_Mutagen11,
            EET_Mutagen12,
            EET_Mutagen13,
            EET_Mutagen14,
            EET_Mutagen15,
            EET_Mutagen16,
            EET_Mutagen17,
            EET_Mutagen18,
            EET_Mutagen19,
            EET_Mutagen20,
            EET_Mutagen21,
            EET_Mutagen22,
            EET_Mutagen23,
            EET_Mutagen24,
            EET_Mutagen25,
            EET_Mutagen26,
            EET_Mutagen27,
            EET_Mutagen28,


            EET_AirDrainDive,
            EET_BoostedStaminaRegen,
            EET_WitchHypnotized,
            EET_AirBoost,
            EET_StaminaDrainSwimming,
            EET_AutoSwimmingStaminaRegen,
            EET_Drunkenness,
            EET_WraithBlindness,
            EET_Choking,
            EET_StaminaDrain,
            EET_EnhancedArmor,
            EET_EnhancedWeapon,
            EET_SnowstormQ403,
            EET_SlowdownAxii,
            EET_PheromoneNekker,
            EET_PheromoneDrowner,
            EET_PheromoneBear,
            EET_Tornado,
            EET_WolfHour,
            EET_WeakeningAura,
            EET_Weaken,

            EET_Tangled,
            EET_Runeword8,
            EET_LynxSetBonus,
            EET_GryphonSetBonus,
            EET_GryphonSetBonusYrden,
            EET_POIGorA10,
            EET_Mutation7Buff,
            EET_Mutation7Debuff,
            EET_Mutation10,
            EET_Perk21InternalCooldown,
            EET_Mutation11Buff,
            EET_Mutation11Debuff,
            EET_Acid,
            EET_WellRested,
            EET_HorseStableBuff,
            EET_BookshelfBuff,
            EET_PolishedGenitals,
            EET_Mutation12Cat,
            EET_Mutation11Immortal,
            EET_Aerondight,
            EET_Trap,
            EET_Mutation3,
            EET_Mutation4,
            EET_Mutation5,
            EET_ToxicityVenom,
            EET_BasicQuen,


            EET_EffectTypesSize,
            EET_ForceEnumTo16Bit = 10000
        }
        public enum EMonsterCategory
        {
            MC_NotSet,
            MC_Relic,
            MC_Necrophage,
            MC_Cursed,
            MC_Beast,
            MC_Insectoid,
            MC_Vampire,
            MC_Specter,
            MC_Draconide,
            MC_Hybrid,
            MC_Troll,
            MC_Human,
            MC_Unused,
            MC_Magicals,
            MC_Animal
        }
        public enum EAreaName
        {
            AN_Undefined,
            AN_NMLandNovigrad,
            AN_Skellige_ArdSkellig,
            AN_Kaer_Morhen,
            AN_Prologue_Village,
            AN_Wyzima,
            AN_Island_of_Myst,
            AN_Spiral,
            AN_Prologue_Village_Winter,
            AN_Velen,
            AN_CombatTestLevel,
            AN_Bob  //not in ghidra
        }
        public enum EHitReactionType
        {
            EHRT_None,
            EHRT_Light,
            EHRT_Heavy,
            EHRT_Igni,
            EHRT_Reflect,
            EHRT_LightClose
        }
        public enum EAttackSwingType
        {
            AST_Horizontal,
            AST_Vertical,
            AST_DiagonalUp,
            AST_DiagonalDown,
            AST_Jab,
            AST_NotSet
        }
        public enum EAttackSwingDirection
        {
            ASD_UpDown,
            ASD_DownUp,
            ASD_LeftRight,
            ASD_RightLeft,
            ASD_NotSet
        }
        #endregion

        public enum EDM_MappinType
        {
            EDM_QuestAvailable,
            EDM_MonsterNest,
            EDM_Prostitute,
            EDM_HorseRacingNPC,
            EDM_NonQuestHorseRace,
            EDM_QuestAvailableFromNonActor,
            EDM_EP1QuestAvailable,
            EDM_EP1QuestAvailableFromNonActor,
            EDM_EP2QuestAvailable,
            EDM_EP2QuestAvailableFromNonActor,
            EDM_Torch,
            EDM_HorseRaceTarget,
            EDM_HorseRaceDummy,
        }

        public enum BlockDataObjectType
        {
            Invalid = 0x1,
            Mesh = 0x2,
            Collision = 0x3,
            Decal = 0x4,
            Dimmer = 0x5,
            PointLight = 0x6,
            SpotLight = 0x7,
            RigidBody = 0x8,
            Cloth = 0x9,
            Destruction = 0xA,
            Particles = 0xB,
        };

        public enum EFactValueChangeMethod
        {
            FVCM_Add,
            FVCM_Substract,
            FVCM_Multiply,
            FVCM_Divide,
        }
        public enum EQuestPadVibrationStrength
        {
            EQPVS_VeryLight,
            EQPVS_Light,
            EQPVS_Hard,
            EQPVS_VeryHard
        }
        public enum ESoundAmbientDynamicParameter
        {
            ESADP_None
        }
        public enum EJournalContentType
        {
            EJCT_Vanilla,
            EJCT_EP1,
            EJCT_EP2,
        }
        public enum ETopLevelAIPriorities
        {
            AIP_Unavailable,
            AIP_BelowIdle,
            AIP_AboveIdle,
            AIP_AboveIdle2,
            AIP_AboveEmergency,
            AIP_AboveEmergency2,
            AIP_AboveCombat,
            AIP_AboveCombat2,
        }
        public enum ESceneItemEventMode
        {
            SIEM_Default,
            SIEM_Mount,
            SIEM_Unmount
        }
        public enum EQuestManageFastTravelOperation
        {
            QMFT_EnableAndShow,
            QMFT_EnableOnly,
            QMFT_ShowOnly
        }
        public enum ELightCubeSides
        {
            LCS_NegativeX,
            LCS_PositiveX,
            LCS_NegativeY,
            LCS_PositiveY,
            LCS_NegativeZ,
            LCS_PositiveZ
        }
        public enum EFixBonesHierarchyType
        {
            FBHTAddMissingBones,
            FBHTRemoveDisconnectedBones
        }
        public enum EBehaviorVarContext
        {
            BVC_Speed,
            BVC_RotationAngle,
            BVC_Extra
        }
        public enum EArbitratorPriorities
        {
            BTAP_Unavailable,
            BTAP_Idle,
            BTAP_Emergency,
            BTAP_Combat,
            BTAP_FullCutscene,
            BTAP_BelowIdle,
            BTAP_AboveIdle,
            BTAP_AboveIdle2,
            BTAP_AboveEmergency,
            BTAP_AboveEmergency2,
            BTAP_AboveCombat,
            BTAP_AboveCombat2
        }
        public enum EAllowedActorGroups
        {
            AAG_Player,
            AAG_PlayerInCombat,
            AAG_TallNPCs,
            AAG_ShortNPCs,
            AAG_Monsters,
            AAG_Ghost
        }
        public enum ESwitchOperation
        {
            SO_TurnOn,
            SO_TurnOff,
            SO_Toggle,
            SO_Reset,
            SO_Enable,
            SO_Disable,
            SO_Lock,
            SO_Unlock
        }
        public enum ETCrEffectorId
        {
            TCrEffector_HandL,
            TCrEffector_HandR
        }
        public enum eGwintEffect
        {
            GwintEffect_None,
            GwintEffect_Bin2,
            GwintEffect_MeleeScorch,
            GwintEffect_11thCard,
            GwintEffect_ClearWeather,
            GwintEffect_PickWeatherCard,
            GwintEffect_PickRainCard,
            GwintEffect_PickFogCard,
            GwintEffect_PickFrostCard,
            GwintEffect_View3EnemyCard,
            GwintEffect_ResurectCard,
            GwintEffect_ResurectFromEnemy,
            GwintEffect_Bin2Pick1,
            GwintEffect_MeleeHorn,
            GwintEffect_RangedHorn,
            GwintEffect_SiegeHorn,
            GwintEffect_SiegeScorch,
            GwintEffect_CounterKingAbility,
            GwintEffect_Melee,
            GwintEffect_Ranged,
            GwintEffect_Siege,
            GwintEffect_UnsummonDummy,
            GwintEffect_Horn,
            GwintEffect_Draw,
            GwintEffect_Scorch,
            GwintEffect_ClearSky
        }
        public enum EQuestConditionDLCType
        {
            QCDT_Undefined,
            QCDT_EP1,
            QCDT_EP2,
            QCDT_NGP,
        }
        public enum EPlayerMutationType
        {
            EPMT_None,
            EPMT_Mutation1,
            EPMT_Mutation2,
            EPMT_Mutation3,
            EPMT_Mutation4,
            EPMT_Mutation5,
            EPMT_Mutation6,
            EPMT_Mutation7,
            EPMT_Mutation8,
            EPMT_Mutation9,
            EPMT_Mutation10,
            EPMT_Mutation11,
            EPMT_Mutation12,
            EPMT_MutationMaster
        }
        public enum EMonsterNestType
        {
            EMNT_Regular,
            EMNT_InfestedWineyard
        }
        public enum EEP2PoiType
        {
            EPT_Default,
            EPT_Belgard,
            EPT_Coronata,
            EPT_Vermentino,
        }
        public enum ELanguageCheckType
        {
            LCT_Text,
            LCT_Speech,
            LCT_TextAndSpeech,
        }
        public enum ECheckedLanguage
        {
            TL_None,
            TL_English,
            TL_Polish,
            TL_German,
            TL_Italian,
            TL_French,
            TL_Czech,
            TL_Spanish,
            TL_Chinese,
            TL_Russian,
            TL_Hungarian,
            TL_Japanese,
            TL_Turkish,
            TL_Korean,
            TL_Brazilian_Portuguese,
            TL_Latin_American_Spanish,
            TL_Arabic,
            TL_Debug,
        }
        public enum EItemSelectionPopupMode
        {
            EISPM_Default,
            EISPM_ArmorStand,
            EISPM_SwordStand,
            EISPM_Painting,
        }
        public enum EInputDeviceType
        {
            IDT_Xbox1 = 0,
            IDT_PS4 = 1,
            IDT_Steam = 2,
            IDT_KeyboardMouse = 3,
            IDT_Tablet = 4,
            IDT_Unknown = 5
        }
        public enum EHudTimeOutAction
        {
            EHTOA_Start,
            EHTOA_Stop,
            EHTOA_Add,
        }
        public enum EHorseMode
        {
            EHM_NotSet,
            EHM_Normal,
            EHM_Devil,
            EHM_Unicorn
        }
        public enum EGuiSceneControllerRenderFocus
        {
            GSCRF_Body,
            GSCRF_Head,
            GSCRF_Torso,
            GSCRF_Legs,

            GSCRF_Max
        }
        public enum EFairytaleWitchAction
        {
            EFWA_GoBackToFlight
        }
        public enum ECursorType
        {
            CT_None,
            CT_Default,
            CT_Rotate
        }
        public enum ECriticalEffectCounterType
        {
            CECT_Human,
            CECT_NonHuman,
            CECT_Undefined
        }
        public enum EAnimalType
        {
            EAT_NotSet,
            EAT_Peacock,
            EAT_Pheasant
        }
        public enum W3TableState
        {
            TS_Clue,
            TS_Table,
        }
        public enum EPlayerEvadeType
        {
            PET_Roll,
            PET_Dodge,
            PET_Pirouette
        }
        public enum EPlayerEvadeDirection
        {
            PED_Forward,
            PED_ForwardLeft,
            PED_Left,
            PED_LeftBack,
            PED_Back,
            PED_BackRight,
            PED_Right,
            PED_RightForward
        }
        public enum EPlayerParryDirection
        {
            PPD_Forward,
            PPD_Left,
            PPD_Back,
            PPD_Right
        }
        public enum EPlayerRepelType
        {
            PRT_Random,
            PRT_Bash,
            PRT_Kick,
            PRT_Slash,
            PRT_SideStepSlash
        }
        public enum EItemType
        {
            IT_Petard,
            IT_Bolt
        }
        public enum ESpecialAbilityInput
        {
            SAI_Up,
            SAI_Down,
            SAI_Left,
            SAI_Right
        }
        public enum EThrowStage
        {
            TS_Start,
            TS_Loop,
            TS_End,
            TS_Stop
        }
        public enum EParryStage
        {
            PS_Start,
            PS_Loop,
            PS_End,
            PS_Stop
        }
        public enum EAttackSwingRange
        {
            ASR_Short,
            ASR_Normal,
            ASR_Long
        }
        public enum EDismembermentWoundTypes
        {
            DWT_Head,
            DWT_Torso,
            DWT_TorsoLeft,
            DWT_TorsoRight,
            DWT_ArmLeft,
            DWT_ArmRight,
            DWT_LegLeft,
            DWT_LegRight,
            DWT_Morph_Head,
            DWT_Morph_Torso,
            DWT_Morph_TorsoLeft,
            DWT_Morph_TorsoRight,
            DWT_Morph_ArmLeft,
            DWT_Morph_ArmRight,
            DWT_Morph_LegLeft,
            DWT_Morph_LegRight,
            DWT_DLC_Defined
        }
        public enum ERecoilLevel
        {
            RL_1,
            RL_2,
            RL_3
        }
        public enum ECustomCameraType
        {
            CCT_None,
            CCT_CustomController,
            CCT_RotatedToTarget_OverShoulder,
            CCT_RotatedToTarget_Medium
        }
        public enum ECustomCameraController
        {
            CCC_NoTarget,
            CCC_Target_Interior,
            CCC_Target
        }
        public enum EInitialAction
        {
            IA_None,
            IA_AttackLight,
            IA_AttackHeavy,
            IA_CastSign,
            IA_ThrowItem,
            IA_CriticalState
        }
        public enum EDir
        {
            Dir_L180,
            Dir_L135,
            Dir_L90,
            Dir_L45,
            Dir_F,
            Dir_R45,
            Dir_R90,
            Dir_R135,
            Dir_R180
        }
        public enum EPlayerStopPose
        {
            EPS_LeftForward,
            EPS_LeftUp,
            EPS_RightForward,
            EPS_RightUp
        }
        public enum EVehicleCombatAction
        {
            EHCA_ShootCrossbow,
            EHCA_ThrowBomb,
            EHCA_CastSign,
            EHCA_Attack
        }
        public enum HorseAttackSide
        {
            HAS_Right,
            HAS_Left
        }
        public enum EBookDirection
        {
            BD_left,
            BD_right
        }
        public enum EQuestSword
        {
            EQS_Any,
            EQS_Steel,
            EQS_Silver
        }
        public enum EMapPinStatus
        {
            EMPS_Undefined,
            EMPS_Known,
            EMPS_Discovered,
            EMPS_Disabled
        }
        public enum EFocusEffectActivationAction
        {
            FEAA_Enable,
            FEAA_Disable
        }
        public enum ECameraEffect
        {
            ECE_None,
            ECE_Drunk
        }
        public enum EQuestReplacerEntities
        {
            EQRE_Geralt,
            EQRE_Ciri,
            EQRE_CiriNaked,
            EQRE_CiriWounded,
            EQRE_CiriWinter
        }
        public enum EItemSelectionType
        {
            IST_Equipped_Only,
            IST_All
        }
        public enum EQuestNPCStates
        {
            EQNS_Default,
            EQNS_Dead,
            EQNS_Agony,
            EQNS_KnockedUnconscious,
            EQNS_DeadNoAgony,
            EQNS_DeadInstantRagdoll,
            EQNS_Combat
        }
        public enum EDrawWeaponQuestType
        {
            EDWQT_Steel,
            EDWQT_Silver,
            EDWQT_NoWeapon,
            EDWQT_Fists
        }
        public enum ESwarmStateOnArrival
        {
            SSOA_Idle,
            SSOA_Shield,
            SSOA_ClueBall
        }
        public enum EAnimalReaction
        {
            AR_Rearing,
            AR_Kick,
            AR_Backing,
            AR_AddPanicPercents
        }
        public enum EDoorQuestState
        {
            EDQS_Open,
            EDQS_Close,
            EDQS_RemoveLock,
            EDQS_Enable,
            EDQS_Disable,
            EDQS_Lock
        }
        public enum EGeraltPath
        {
            EGP_SWORD,
            EGP_SIGNS,
            EGP_ALCHEMY
        }

        public enum EGwentCardFaction
        {
            EGCF_Neutral,
            EGCF_Kingdoms,
            EGCF_Nilfgaard,
            EGCF_Monsters,
            EGCF_Scoiatael
        }
        public enum EGwentDeckUnlock
        {
            EGDU_Northern_Kingdom,
            EGDU_Nilfgaard,
            EGDU_Scoiatael,
            EGDU_No_Mans_Land
        }
        public enum EEnableMode
        {
            EEM_AsIs,
            EEM_Enable,
            EEM_Disable
        }
        public enum EContainerMode
        {
            ECM_Empty,
            ECM_NotEmpty
        }
        public enum EQuestPlayerSkillLevel
        {
            EQPSL_Skill,
            EQPSL_DialogAxiiLevel
        }
        public enum EQuestConditionPlayerState
        {
            QCPS_None,
            QCPS_Walking,
            QCPS_Running,
            QCPS_Sprinting,
            QCPS_Swimming,
            QCPS_Diving,
            QCPS_Climbing,
            QCPS_CastingSign,
            QCPS_ParryStance,
            QCPS_Preparation
        }
        public enum ESwitchStateCondition
        {
            SSC_TurnedOn,
            SSC_TurnedOff,
            SSC_Enabled,
            SSC_Disabled,
            SSC_Locked,
            SSC_Unlocked,
            SSC_MaxUseCountReached
        }
        public enum EPlayerReplacerType
        {
            EPRT_Undefined,
            EPRT_Geralt,
            EPRT_Ciri
        }
        public enum ENegotiationResult
        {
            TooMuch,
            PrettyClose,
            WeHaveDeal,
            GetLost
        }
        public enum ECollectItemsRes
        {
            ItemCollected,
            NothingChanged,
            WrongItem,
            AlreadyRecieved,
            AllItemsCollected
        }
        public enum ECollectItemsCustomRes
        {
            Book1,
            Book2,
            Book3,
            Book4,
            Book5,
            NothingChangedCus,
            WrongItemCus,
            AlreadyRecievedCus,
            AllItemsCollectedCus
        }
        public enum EHorseWaterTestResult
        {
            HWTR_Normal,
            HWTR_Adjusted,
            HWTR_ToDeep
        }
        public enum ETickGroup
        {
            TICK_PrePhysics,
            TICK_PrePhysicsPost,
            TICK_Main,
            TICK_PostPhysics,
            TICK_PostPhysicsPost,
            TICK_PostUpdateTransform
        }
        public enum EMoveType
        {
            MT_Walk,
            MT_Run,
            MT_FastRun,
            MT_Sprint,
            MT_AbsSpeed
        }
        public enum EMoveFailureAction
        {
            MFA_REPLAN,
            MFA_EXIT
        }
        public enum ECheats
        {
            CHEAT_Console,
            CHEAT_FreeCamera,
            CHEAT_DebugPages,
            CHEAT_InstantKill,
            CHEAT_Teleport,
            CHEAT_MovementOnPhysics,
            CHEAT_TimeScaling
        }
        public enum EPersistanceMode
        {
            PM_DontPersist,
            PM_SaveStateOnly,
            PM_Persist
        }
        public enum ERenderingPlane
        {
            RPl_Scene,
            RPl_Background
        }
        public enum ERenderingSortGroup
        {
            RSG_DebugUnlit,
            RSG_Unlit,
            RSG_LitOpaque,
            RSG_LitOpaqueWithEmissive,
            RSG_DecalModulativeColor,
            RSG_DecalBlendedColor,
            RSG_DecalBlendedNormalsColor,
            RSG_DecalBlendedNormals,
            RSG_Sprites,
            RSG_TransparentBackground,
            RSG_RefractiveBackground,
            RSG_RefractiveBackgroundDepthWrite,
            RSG_Transparent,
            RSG_TransparentFullres,
            RSG_DebugTransparent,
            RSG_DebugOverlay,
            RSG_2D,
            RSG_Prepare,
            RSG_Skin,
            RSG_Hair,
            RSG_Forward,
            RSG_EyeOverlay,
            RSG_Volumes,
            RSG_WaterBlend,
            RSG_Max
        }
        public enum ETransparencySortGroup
        {
            TSG_Sky,
            TSG_Clouds,
            TSG_Scene,
            TSG_Max
        }
        public enum ERenderingBlendMode
        {
            RBM_None,
            RBM_Addtive,
            RBM_AlphaBlend,
            RBM_Refractive
        }
        public enum EScreenshotRenderFlags
        {
            SRF_PostProcess,
            SRF_GUI
        }
        public enum ESaveFormat
        {
            SF_BMP,
            SF_PNG,
            SF_JPG,
            SF_DDS
        }
        public enum ESoundType
        {
            SOUND_GAMEPLAY_VOICE,
            SOUND_SCENE_VOICE,
            SOUND_ANIMATION,
            SOUND_AMBIENT,
            SOUND_FX,
            SOUND_SCENE,
            SOUND_SCRIPT
        }
        public enum ESoundTypeFlag
        {
            SOUND_NONE_FLAG,
            SOUND_GAMEPLAY_VOICE_FLAG,
            SOUND_SCENE_VOICE_FLAG,
            SOUND_ANIMATION_FLAG,
            SOUND_AMBIENT_FLAG
        }
        public enum ELoadGameResult
        {
            LOAD_NotInitialized,
            LOAD_Initializing,
            LOAD_ReadyToLoad,
            LOAD_Loading,
            LOAD_Error,
            LOAD_MissingContent
        }
        public enum ESaveListUpdateState
        {
            LIST_NeedsUpdate,
            LIST_Updating,
            LIST_Updated_EventPending,
            LIST_Updated
        }
        public enum ESaveGameResult
        {
            SAVE_NotInitialized,
            SAVE_Initializing,
            SAVE_ReadyToSave,
            SAVE_Saving,
            SAVE_Error
        }
        public enum EShowFlags
        {
            SHOW_Meshes,
            SHOW_AI,
            SHOW_AISenses,
            SHOW_AIRanges,
            SHOW_Camera,
            SHOW_HierarchicalGrid,
            SHOW_BeamTree,
            SHOW_NavMesh,
            SHOW_Shadows,
            SHOW_ForceAllShadows,
            SHOW_Lights,
            SHOW_Terrain,
            SHOW_Foliage,
            SHOW_PostProcess,
            SHOW_Selection,
            SHOW_Grid,
            SHOW_Sprites,
            SHOW_Particles,
            SHOW_Wireframe,
            SHOW_WalkSurfaces,
            SHOW_Areas,
            SHOW_Locomotion,
            SHOW_MovableRep,
            SHOW_Logic,
            SHOW_Profilers,
            SHOW_Paths,
            SHOW_Stickers,
            SHOW_Steering,
            SHOW_Bboxes,
            SHOW_Exploration,
            SHOW_Behavior,
            SHOW_Emissive,
            SHOW_Spawnset,
            SHOW_Collision,
            SHOW_GUI,
            SHOW_VisualDebug,
            SHOW_Decals,
            SHOW_Lighting,
            SHOW_TSLighting,
            SHOW_Refraction,
            SHOW_Encounter,
            SHOW_BboxesParticles,
            SHOW_BboxesTerrain,
            SHOW_NavRoads,
            SHOW_Brushes,
            SHOW_BuildingBrush,
            SHOW_Sound,
            SHOW_Gizmo,
            SHOW_Flares,
            SHOW_FlaresData,
            SHOW_GUIFallback,
            SHOW_OnScreenMessages,
            SHOW_DepthOfField,
            SHOW_LightsBBoxes,
            SHOW_ErrorState,
            SHOW_Devices,
            SHOW_SelectionContacts,
            SHOW_PEObstacles,
            SHOW_Bg,
            SHOW_TriangleStats,
            SHOW_Formations,
            SHOW_Skirt,
            SHOW_Wind,
            SHOW_NonClimbable,
            SHOW_MergedMeshes,
            SHOW_UseVisibilityMask,
            SHOW_ShadowMeshDebug,
            SHOW_NavTerrain,
            SHOW_NavGraph,
            SHOW_NavObstacles,
            SHOW_Apex,
            SHOW_SpeedTreeShadows,
            SHOW_ShadowStats,
            SHOW_ShadowPreviewDynamic,
            SHOW_ShadowPreviewStatic,
            SHOW_PhysXVisualization,
            SHOW_PhysXTraceVisualization,
            SHOW_PhysXMaterials,
            SHOW_BboxesDecals,
            SHOW_SpritesDecals,
            SHOW_HiResEntityShadows,
            SHOW_Apex_EnableVisualizations,
            SHOW_ApexClothCollisionSolid,
            SHOW_ApexClothSkeleton,
            SHOW_ApexClothBackstop,
            SHOW_ApexClothMaxDistance,
            SHOW_ApexClothVelocity,
            SHOW_ApexClothSkinnedPosition,
            SHOW_ApexClothActiveTethers,
            SHOW_ApexClothLength,
            SHOW_ApexClothCrossSection,
            SHOW_ApexClothBending,
            SHOW_ApexClothShearing,
            SHOW_ApexClothZeroStretch,
            SHOW_ApexClothSelfCollision,
            SHOW_ApexClothVirtualCollision,
            SHOW_ApexClothPhysicsMeshSolid,
            SHOW_ApexClothPhysicsMeshWire,
            SHOW_ApexClothWind,
            SHOW_ApexClothBackstopPrecise,
            SHOW_ApexClothCollisionWire,
            SHOW_ApexClothLocalSpace,
            SHOW_ApexDestructSupport,
            SHOW_ApexStats,
            SHOW_DistantLights,
            SHOW_CollisionIfNotVisible,
            SHOW_Projectile,
            SHOW_EnvProbesInstances,
            SHOW_TerrainHoles,
            SHOW_CollisionSoundOcclusion,
            SHOW_Dimmers,
            SHOW_DimmersBBoxes,
            SHOW_PhysActorDampers,
            SHOW_PhysActorVelocities,
            SHOW_PhysActorMasses,
            SHOW_TBN,
            SHOW_TonemappingCurve,
            SHOW_ApexFractureRatio,
            SHOW_AnimatedProperties,
            SHOW_PhysMotionIntensity,
            SHOW_AreaShapes,
            SHOW_TriggerBounds,
            SHOW_TriggerActivators,
            SHOW_TriggerTree,
            SHOW_SoundReverb,
            SHOW_CurveAnimations,
            SHOW_AnimDangles,
            SHOW_Wetness,
            SHOW_CameraVisibility,
            SHOW_StreamingTree0,
            SHOW_StreamingTree1,
            SHOW_StreamingTree2,
            SHOW_StreamingTree3,
            SHOW_StreamingTree4,
            SHOW_StreamingTree5,
            SHOW_StreamingTree6,
            SHOW_StreamingTree7,
            SHOW_EnvProbeStats,
            SHOW_FocusMode,
            SHOW_AIBehTree,
            SHOW_NavMeshTriangles,
            SHOW_NavGraphNoOcclusion,
            SHOW_PhantomShapes,
            SHOW_Crowd,
            SHOW_SoundEmitters,
            SHOW_SoundAmbients,
            SHOW_GenericGrass,
            SHOW_ApexFracturePoints,
            SHOW_ApexThresoldLeft,
            SHOW_Underwater,
            SHOW_Scenes,
            SHOW_BoatSailing,
            SHOW_OcclusionStats,
            SHOW_UmbraFrustum,
            SHOW_UmbraObjectBounds,
            SHOW_UmbraPortals,
            SHOW_UmbraVisibleVolume,
            SHOW_UmbraViewCell,
            SHOW_UmbraVisibilityLines,
            SHOW_UmbraStatistics,
            SHOW_UmbraOcclusionBuffer,
            SHOW_UmbraCullShadows,
            SHOW_UmbraCullSpeedTreeShadows,
            SHOW_UmbraShowOccludedNonStaticGeometry,
            SHOW_UmbraStreamingVisualization,
            SHOW_UmbraCullTerrain,
            SHOW_UmbraCullFoliage,
            SHOW_UmbraShowFoliageCells,
            SHOW_DynamicDecals,
            SHOW_Swarms,
            SHOW_TerrainStats,
            SHOW_EnvProbesOverlay,
            SHOW_Interactions,
            SHOW_AIActions,
            SHOW_Stripes,
            SHOW_Waypoints,
            SHOW_RoadFollowing,
            SHOW_MapTracking,
            SHOW_QuestMapPins,
            SHOW_FlareOcclusionShapes,
            SHOW_ReversedProjection,
            SHOW_CascadesStabilizedRotation,
            SHOW_DynamicCollector,
            SHOW_DynamicComponent,
            SHOW_MeshComponent,
            SHOW_LodInfo,
            SHOW_NavMeshOverlay,
            SHOW_ActorLodInfo,
            SHOW_LocalReflections,
            SHOW_EnvProbesBigOverlay,
            SHOW_VideoOutputLimited,
            SHOW_BoatHedgehog,
            SHOW_BoatDestruction,
            SHOW_BoatBuoyancy,
            SHOW_BoatPathFollowing,
            SHOW_Histogram,
            SHOW_VolumetricPaths,
            SHOW_PigmentMap,
            SHOW_PreferTemporalAA,
            SHOW_AllowDebugPreviewTemporalAA,
            SHOW_AllowApexShadows,
            SHOW_NodeTags,
            SHOW_HairAndFur,
            SHOW_ForwardPass,
            SHOW_GeometrySkinned,
            SHOW_GeometryStatic,
            SHOW_GeometryProxies,
            SHOW_NavGraphRegions,
            SHOW_Containers,
            SHOW_RenderTargetBackground,
            SHOW_AITickets,
            SHOW_EffectAreas,
            SHOW_PathSpeedValues,
            SHOW_PhysActorIterations,
            SHOW_BoatInput,
            SHOW_Dismemberment,
            SHOW_EntityVisibility,
            SHOW_AIBehaviorDebug,
            SHOW_XB1SafeArea,
            SHOW_PS4SafeArea,
            SHOW_Skybox,
            SHOW_CameraLights,
            SHOW_AntiLightbleed,
            SHOW_BoatWaterProbbing,
            SHOW_UseRegularDeferred,
            SHOW_CommunityAgents,
            SHOW_RenderDeepTerrain,
            SHOW_CullTerrainWithFullHeight,
            SHOW_CameraInteriorFactor,
            SHOW_BrowseDebugPreviews,
            SHOW_BBoxesCloth,
            SHOW_BBoxesFur,
            SHOW_BBoxesDestruction,
            SHOW_PhysActorFloatingRatio,
            SHOW_GameplayPostFx,
            SHOW_SimpleBuoyancy,
            SHOW_ScaleformMemoryInfo,
            SHOW_GameplayLightComponent,
            SHOW_TeleportDetector,
            SHOW_SoundListener,
            SHOW_NavTerrainHeight,
            SHOW_StreamingCollisionBoxes,
            SHOW_RenderGPUProfiler
        }
        public enum ECameraLightModType
        {
            ECLT_Scene,
            ECLT_Gameplay,
            ECLT_DialogScene,
            ECLT_Interior
        }
        public enum ECompareTagsOperation
        {
            BCTO_MatchAll,
            BCTO_MatchAny
        }
        public enum ELensFlareGroup
        {
            LFG_Default,
            LFG_Sun,
            LFG_Moon,
            LFG_Custom0,
            LFG_Custom1,
            LFG_Custom2,
            LFG_Custom3,
            LFG_Custom4,
            LFG_Custom5
        }
        public enum EFlareCategory
        {
            FLARECAT_Default,
            FLARECAT_Sun,
            FLARECAT_Moon
        }
        public enum EWorldTransitionMode
        {
            Stream,
            Loadingscreen,
            Loadingscreentillkeyispressed,
            Loadingscreentillfadein,
            Blockgamebutdonotdisplayanything
        }
        public enum EPathEngineCollision
        {
            PEC_Disabled,
            PEC_Burned,
            PEC_Static,
            PEC_StaticWalkable,
            PEC_Dynamic,
            PEC_Walkable
        }
        public enum EMotionType
        {
            MT_Dynamic,
            MT_KeyFramed
        }
        public enum EAreaTerrainSide
        {
            ATS_AboveAndBelowTerrain,
            ATS_OnlyAboveTerrain,
            ATS_OnlyBelowTerrain
        }
        public enum EAreaClippingMode
        {
            ACM_NoClipping,
            ACM_ClipToNegativeAreas
        }
        public enum ESaveGameType
        {
            SGT_AutoSave,
            SGT_QuickSave,
            SGT_Manual,
            SGT_ForcedCheckPoint
        }
        public enum ESaveAttemptResult
        {
            SAR_Success,
            SAR_SaveLock,
            SAR_WriteFailure
        }
        public enum ESessionRestoreResult
        {
            RESTORE_Success,
            RESTORE_DataCorrupted,
            RESTORE_DLCRequired,
            RESTORE_MissingContent,
            RESTORE_InternalError,
            RESTORE_NoGameDefinition,
            RESTORE_WrongGameVersion
        }
        public enum EInputAction
        {
            IACT_None,
            IACT_Press,
            IACT_Release,
            IACT_Axis
        }
        public enum EGlobalEventCategory
        {
            GEC_Empty,
            GEC_Trigger,
            GEC_Tag,
            GEC_Fact,
            GEC_ScriptsCustom0,
            GEC_ScriptsCustom1,
            GEC_ScriptsCustom2,
            GEC_ScriptsCustom3,
            GEC_ScriptsCustom4,
            GEC_ScriptsCustom5,
            GEC_ScriptsCustom6,
            GEC_ScriptsCustom7,
            GEC_ScriptsCustom8,
            GEC_ScriptsCustom9,
            GEC_Last
        }
        public enum EGlobalEventType
        {
            GET_Unknown,
            GET_TriggerCreated,
            GET_TriggerRemoved,
            GET_TriggerActivatorCreated,
            GET_TriggerActivatorRemoved,
            GET_TagAdded,
            GET_TagRemoved,
            GET_StubTagAdded,
            GET_StubTagRemoved,
            GET_FactAdded,
            GET_FactRemoved,
            GET_ScriptsCustom0,
            GET_ScriptsCustom1,
            GET_ScriptsCustom2,
            GET_ScriptsCustom3
        }
        public enum ECutsceneActorType
        {
            CAT_None,
            CAT_Actor,
            CAT_Prop,
            CAT_Camera
        }
        public enum EInputSensitivityPreset
        {
            ISP_Normal,
            ISP_Aiming
        }
        public enum ELightShadowCastingMode
        {
            LSCM_None,
            LSCM_Normal,
            LSCM_OnlyDynamic,
            LSCM_OnlyStatic
        }
        public enum EInputKey
        {
            IK_None,
            IK_LeftMouse,
            IK_RightMouse,
            IK_MiddleMouse,
            IK_Unknown04,
            IK_Unknown05,
            IK_Unknown06,
            IK_Unknown07,
            IK_Backspace,
            IK_Tab,
            IK_Unknown0A,
            IK_Unknown0B,
            IK_Unknown0C,
            IK_Enter,
            IK_Unknown0E,
            IK_Unknown0F,
            IK_Shift,
            IK_Ctrl,
            IK_Alt,
            IK_Pause,
            IK_CapsLock,
            IK_Unknown15,
            IK_Unknown16,
            IK_Unknown17,
            IK_Unknown18,
            IK_Unknown19,
            IK_Unknown1A,
            IK_Escape,
            IK_Unknown1C,
            IK_Unknown1D,
            IK_Unknown1E,
            IK_Unknown1F,
            IK_Space,
            IK_PageUp,
            IK_PageDown,
            IK_End,
            IK_Home,
            IK_Left,
            IK_Up,
            IK_Right,
            IK_Down,
            IK_Select,
            IK_Print,
            IK_Execute,
            IK_PrintScrn,
            IK_Insert,
            IK_Delete,
            IK_Help,
            IK_0,
            IK_1,
            IK_2,
            IK_3,
            IK_4,
            IK_5,
            IK_6,
            IK_7,
            IK_8,
            IK_9,
            IK_Unknown3A,
            IK_Unknown3B,
            IK_Unknown3C,
            IK_Unknown3D,
            IK_Unknown3E,
            IK_Unknown3F,
            IK_Unknown40,
            IK_A,
            IK_B,
            IK_C,
            IK_D,
            IK_E,
            IK_F,
            IK_G,
            IK_H,
            IK_I,
            IK_J,
            IK_K,
            IK_L,
            IK_M,
            IK_N,
            IK_O,
            IK_P,
            IK_Q,
            IK_R,
            IK_S,
            IK_T,
            IK_U,
            IK_V,
            IK_W,
            IK_X,
            IK_Y,
            IK_Z,
            IK_Unknown5B,
            IK_Unknown5C,
            IK_Unknown5D,
            IK_Unknown5E,
            IK_Unknown5F,
            IK_NumPad0,
            IK_NumPad1,
            IK_NumPad2,
            IK_NumPad3,
            IK_NumPad4,
            IK_NumPad5,
            IK_NumPad6,
            IK_NumPad7,
            IK_NumPad8,
            IK_NumPad9,
            IK_NumStar,
            IK_NumPlus,
            IK_Separator,
            IK_NumMinus,
            IK_NumPeriod,
            IK_NumSlash,
            IK_F1,
            IK_F2,
            IK_F3,
            IK_F4,
            IK_F5,
            IK_F6,
            IK_F7,
            IK_F8,
            IK_F9,
            IK_F10,
            IK_F11,
            IK_F12,
            IK_F13,
            IK_F14,
            IK_F15,
            IK_F16,
            IK_F17,
            IK_F18,
            IK_F19,
            IK_F20,
            IK_F21,
            IK_F22,
            IK_F23,
            IK_F24,
            IK_Pad_A_CROSS,
            IK_Pad_B_CIRCLE,
            IK_Pad_X_SQUARE,
            IK_Pad_Y_TRIANGLE,
            IK_Pad_Start,
            IK_Pad_Back_Select,
            IK_Pad_DigitUp,
            IK_Pad_DigitDown,
            IK_Pad_DigitLeft,
            IK_Pad_DigitRight,
            IK_Pad_LeftThumb,
            IK_Pad_RightThumb,
            IK_Pad_LeftShoulder,
            IK_Pad_RightShoulder,
            IK_Pad_LeftTrigger,
            IK_Pad_RightTrigger,
            IK_Pad_LeftAxisX,
            IK_Pad_LeftAxisY,
            IK_Pad_RightAxisX,
            IK_Pad_RightAxisY,
            IK_NumLock,
            IK_ScrollLock,
            IK_Unknown9E,
            IK_Unknown9F,
            IK_LShift,
            IK_RShift,
            IK_LControl,
            IK_RControl,
            IK_UnknownA4,
            IK_UnknownA5,
            IK_UnknownA6,
            IK_UnknownA7,
            IK_UnknownA8,
            IK_UnknownA9,
            IK_UnknownAA,
            IK_UnknownAB,
            IK_UnknownAC,
            IK_UnknownAD,
            IK_UnknownAE,
            IK_UnknownAF,
            IK_UnknownB0,
            IK_UnknownB1,
            IK_UnknownB2,
            IK_UnknownB3,
            IK_UnknownB4,
            IK_UnknownB5,
            IK_UnknownB6,
            IK_UnknownB7,
            IK_UnknownB8,
            IK_Unicode,
            IK_Semicolon,
            IK_Equals,
            IK_Comma,
            IK_Minus,
            IK_Period,
            IK_Slash,
            IK_Tilde,
            IK_Mouse4,
            IK_Mouse5,
            IK_Mouse6,
            IK_Mouse7,
            IK_Mouse8,
            IK_UnknownC6,
            IK_UnknownC7,
            IK_Joy1,
            IK_Joy2,
            IK_Joy3,
            IK_Joy4,
            IK_Joy5,
            IK_Joy6,
            IK_Joy7,
            IK_Joy8,
            IK_Joy9,
            IK_Joy10,
            IK_Joy11,
            IK_Joy12,
            IK_Joy13,
            IK_Joy14,
            IK_Joy15,
            IK_Joy16,
            IK_UnknownD8,
            IK_UnknownD9,
            IK_UnknownDA,
            IK_LeftBracket,
            IK_Backslash,
            IK_RightBracket,
            IK_SingleQuote,
            IK_UnknownDF,
            IK_UnknownE0,
            IK_UnknownE1,
            IK_UnknownE2,
            IK_UnknownE3,
            IK_MouseX,
            IK_MouseY,
            IK_MouseZ,
            IK_MouseW,
            IK_JoyU,
            IK_JoyV,
            IK_JoySlider1,
            IK_JoySlider2,
            IK_MouseWheelUp,
            IK_MouseWheelDown,
            IK_UnknownEE,
            IK_UnknownEF,
            IK_JoyX,
            IK_JoyY,
            IK_JoyZ,
            IK_JoyR,
            IK_UnknownF4,
            IK_UnknownF5,
            IK_Attn,
            IK_ClearSel,
            IK_ExSel,
            IK_ErEof,
            IK_Play,
            IK_Zoom,
            IK_NoName,
            IK_UnknownFD,
            IK_UnknownFE,
            IK_PS4_OPTIONS,
            IK_PS4_TOUCH_PRESS,
            IK_Last,
            IK_Count
        }
        public enum EColorChannel
        {
            COLCHANNEL_Red,
            COLCHANNEL_Green,
            COLCHANNEL_Blue,
            COLCHANNEL_Alpha
        }
        public enum EBatchQueryState
        {
            BQS_NotFound,
            BQS_NotReady,
            BQS_Processed
        }
        public enum ESoundParameterCurveType
        {
            ESPCT_Log3,
            ESPCT_Sine,
            ESPCT_Log1,
            ESPCT_InversedSCurve,
            ESPCT_Linear,
            ESPCT_SCurve,
            ESPCT_Exp1,
            ESPCT_ReciprocalOfSineCurve,
            ESPCT_Exp3
        }
        
        public enum ETextureCategory
        {
            Generic,
            World,
            Scene,
            Characters,
            Heads
        }
        // srcFormat == TRF_TrueColor && srcCompression == TCM_None
        
        public enum EEnvColorGroup
        {
            ECG_Default,
            ECG_LightsDefault,
            ECG_LightsDawn,
            ECG_LightsNoon,
            ECG_LightsEvening,
            ECG_LightsNight,
            ECG_FX_Default,
            ECG_FX_Fire,
            ECG_FX_FireFlares,
            ECG_FX_FireLight,
            ECG_FX_Smoke,
            ECG_FX_SmokeExplosion,
            ECG_FX_Sky,
            ECG_FX_SkyNight,
            ECG_FX_SkyDawn,
            ECG_FX_SkyNoon,
            ECG_FX_SkySunset,
            ECG_FX_SkyRain,
            ECG_FX_MainCloudsMiddle,
            ECG_FX_MainCloudsFront,
            ECG_FX_MainCloudsBack,
            ECG_FX_MainCloudsRim,
            ECG_FX_BackgroundCloudsFront,
            ECG_FX_BackgroundCloudsBack,
            ECG_FX_BackgroundHazeFront,
            ECG_FX_BackgroundHazeBack,
            ECG_FX_Blood,
            ECG_FX_Water,
            ECG_FX_Fog,
            ECG_FX_LightShaft,
            ECG_FX_LightShaftSun,
            ECG_FX_LightShaftInteriorDawn,
            ECG_FX_LightShaftSpotlightDawn,
            ECG_FX_LightShaftReflectionLightDawn,
            ECG_FX_LightShaftInteriorNoon,
            ECG_FX_LightShaftSpotlightNoon,
            ECG_FX_LightShaftReflectionLightNoon,
            ECG_FX_LightShaftInteriorEvening,
            ECG_FX_LightShaftSpotlightEvening,
            ECG_FX_LightShaftReflectionLightEvening,
            ECG_FX_LightShaftInteriorNight,
            ECG_FX_LightShaftSpotlightNight,
            ECG_FX_LightShaftReflectionLightNight,
            ECG_FX_Trails,
            ECG_FX_ScreenParticles,
            ECG_Custom0,
            ECG_Custom1,
            ECG_Custom2
        }
        public enum EEnvFlareColorGroup
        {
            EFCG_Default,
            EFCG_Sun,
            EFCG_Moon,
            EFCG_Custom0,
            EFCG_Custom1,
            EFCG_Custom2
        }
        public enum EEnvAutoHideGroup
        {
            EAHG_None,
            EAHG_Custom0,
            EAHG_Custom1,
            EAHG_Custom2,
            EAHG_Custom3
        }
        public enum EDestructionPreset
        {
            CUSTOM_PRESET_D
        }
        public enum ECharacterPhysicsState
        {
            CPS_Simulated,
            CPS_Animated,
            CPS_Falling,
            CPS_Swimming,
            CPS_Ragdoll,
            CPS_Count
        }
        public enum ECollisionSides
        {
            CS_FRONT,
            CS_RIGHT,
            CS_BACK,
            CS_LEFT,
            CS_FRONT_LEFT,
            CS_FRONT_RIGHT,
            CS_BACK_RIGHT,
            CS_BACK_LEFT,
            CS_CENTER
        }
        public enum EBehaviorLod
        {
            BL_Lod0,
            BL_Lod1,
            BL_Lod2,
            BL_Lod3,
            BL_NoLod
        }
        public enum EInterpolationType
        {
            IT_Linear,
            IT_Bezier
        }
        public enum EAxis
        {
            A_X,
            A_Y,
            A_Z,
            A_NX,
            A_NY,
            A_NZ
        }
        public enum EBehaviorTransitionBlendMotion
        {
            BTBM_Blending,
            BTBM_Source,
            BTBM_Destination
        }
        public enum ELookAtLevel
        {
            LL_Body,
            LL_Head,
            LL_Eyes,
            LL_Null
        }
        public enum EActorAnimState
        {
            AAS_Default,
            AAS_Crossbow,
            AAS_Bow,
            AAS_Halberd,
            AAS_Drunk,
            AAS_Box,
            AAS_Broom,
            AAS_FishBasket,
            AAS_Torch,
            AAS_Bucket,
            AAS_Mage,
            AAS_Bowl,
            AAS_Sneak,
            AAS_Injured,
            AAS_Pickaxe,
            AAS_CrossbowAim,
            AAS_Sword,
            AAS_RocheSword
        }
        public enum ESkeletonType
        {
            Man,
            Woman,
            Witcher,
            Dwarf,
            Elf,
            Child,
            Monster
        }
        public enum ECompressedPoseBlend
        {
            CPBT_None,
            CPBT_Fast,
            CPBT_Normal,
            CPBT_Slow
        }
        public enum ESkeletalAnimationPoseType
        {
            SAPT_Invalid,
            SAPT_Stand,
            SAPT_Sit,
            SAPT_Lie
        }
        public enum EAnimationFps
        {
            AF_5,
            AF_10,
            AF_15,
            AF_30
        }
        public enum EAdditiveType
        {
            AT_Local,
            AT_Ref,
            AT_TPose,
            AT_Animation
        }
        public enum EPoseDeformationLevel
        {
            PDL_Small,
            PDL_Medium,
            PDL_High
        }
        public enum ESkeletalAnimationStreamingType
        {
            SAST_Standard,
            SAST_Prestreamed,
            SAST_Persistent
        }
        public enum EGraphLayerState
        {
            GLS_Visible,
            GLS_Freeze,
            GLS_Hide
        }
        public enum EPropertyCurveMode
        {
            PCM_Forward,
            PCM_Backward
        }
        public enum ECurveType
        {
            ECurveType_Uninitialized,
            ECurveType_Float,
            ECurveType_Vector,
            ECurveType_EngineTransform,
            ECurveType_EulerAngles
        }
        public enum ECurveInterpolationMode
        {
            ECurveInterpolationMode_Linear,
            ECurveInterpolationMode_Automatic,
            ECurveInterpolationMode_Manual
        }
        public enum ECurveManualMode
        {
            ECurveManualMode_Bezier,
            ECurveManualMode_BezierSymmetricDirection,
            ECurveManualMode_BezierSymmetric
        }
        public enum ECurveRelativeMode
        {
            ECurveRelativeMode_None,
            ECurveRelativeMode_InitialTransform,
            ECurveRelativeMode_CurrentTransform
        }
        public enum ECubeGenerationStrategy
        {
            ECGS_SharpAll,
            ECGS_BlurMips,
            ECGS_Preblur,
            ECGS_PreblurStrong,
            ECGS_PreblurDiffuse
        }
        public enum ELayerType
        {
            LT_AutoStatic,
            LT_NonStatic
        }
        public enum ELayerBuildTag
        {
            LBT_None,
            LBT_Ignored,
            LBT_EnvOutdoor,
            LBT_EnvIndoor,
            LBT_EnvUnderground,
            LBT_Quest,
            LBT_Communities,
            LBT_Audio,
            LBT_Nav,
            LBT_Gameplay,
            LBT_DLC
        }
        public enum ELayerMergedContent
        {
            LMC_Auto,
            LMC_ForceAlways,
            LMC_ForceNever
        }
        public enum EAnimationBufferDataAvailable
        {
            ABDA_None,
            ABDA_Partial,
            ABDA_All
        }
        public enum SAnimationBufferStreamingOption
        {
            ABSO_NonStreamable,
            ABSO_PartiallyStreamable,
            ABSO_FullyStreamable
        }
        public enum SAnimationBufferBitwiseCompression
        {
            ABBC_None,
            ABBC_24b,
            ABBC_16b
        }
        public enum SAnimationBufferDataCompressionMethod
        {
            ABDCM_Invalid,
            ABDCM_Plain,
            ABDCM_Quaternion,
            ABDCM_QuaternionXYZSignedW,
            ABDCM_QuaternionXYZSignedWLastBit,
            ABDCM_Quaternion48b,
            ABDCM_Quaternion40b,
            ABDCM_Quaternion32b,
            ABDCM_Quaternion64bW,
            ABDCM_Quaternion48bW,
            ABDCM_Quaternion40bW
        }
        public enum SAnimationBufferOrientationCompressionMethod
        {
            ABOCM_PackIn64bitsW,
            ABOCM_PackIn48bitsW,
            ABOCM_PackIn40bitsW,
            ABOCM_AsFloat_XYZW,
            ABOCM_AsFloat_XYZSignedW,
            ABOCM_AsFloat_XYZSignedWInLastBit,
            ABOCM_PackIn48bits,
            ABOCM_PackIn40bits,
            ABOCM_PackIn32bits
        }
        public enum SAnimationBufferBitwiseCompressionPreset
        {
            ABBCP_Custom,
            ABBCP_VeryHighQuality,
            ABBCP_HighQuality,
            ABBCP_NormalQuality,
            ABBCP_LowQuality,
            ABBCP_VeryLowQuality,
            ABBCP_Raw
        }
        public enum ESkeletalAnimationType
        {
            SAT_Normal,
            SAT_Additive,
            SAT_MS
        }
        public enum ENearPlaneDistance
        {
            NP_VeryClose5cm,
            NP_Close10cm,
            NP_DefaultEnv,
            NP_Medium25cm,
            NP_Further40cm,
            NP_Far60cm,
            NP_VeryFar120cm,
            NP_Extreme240cm,
            NP_CustomValue
        }
        public enum EFarPlaneDistance
        {
            FP_CrazyClose20m,
            FP_EvenCloser30m,
            FP_VeryClose40m,
            FP_Close150m,
            FP_Medium600m,
            FP_DefaultEnv,
            FP_Far1000m,
            FP_MoreFar1500m,
            FP_VeryFar2000m,
            FP_CustomValue
        }
        public enum EAnimationEventType
        {
            AET_Tick,
            AET_DurationStart,
            AET_DurationStartInTheMiddle,
            AET_DurationEnd,
            AET_Duration
        }
        public enum EInteractionPriority
        {
            IP_Prio_0,
            IP_Prio_1,
            IP_Prio_2,
            IP_Prio_3,
            IP_Prio_4,
            IP_Prio_5,
            IP_Prio_6,
            IP_Prio_7,
            IP_Prio_8,
            IP_Prio_9,
            IP_Prio_10,
            IP_Prio_11,
            IP_Prio_12,
            IP_Prio_13,
            IP_Prio_14,
            IP_Max_Unpushable,
            IP_NotSet
        }
        public enum ECameraSolver
        {
            CS_None,
            CS_LookAt,
            CS_Focus
        }
        public enum EHairStrandBlendModeType
        {
            Overwrite,
            Multiply,
            Add,
            Modulate
        }
        public enum EHairColorizeMode
        {
            LOD,
            Tangents,
            MeshNormal,
            HairNormal
        }
        public enum EHairTextureChannel
        {
            RED,
            GREEN,
            BLUE,
            ALPHA
        }
        public enum ESkyTransformType
        {
            STT_SunPosition,
            STT_MoonPosition,
            STT_GlobalLightPosition
        }
        public enum EDestroyWay
        {
            Random,
            Timed,
            OnContact,
            OnDistance
        }
        public enum EPhantomShape
        {
            PS_Sphere,
            PS_Box,
            PS_EntityBounds
        }
        public enum EDimmerType
        {
            DIMMERTYPE_Default,
            DIMMERTYPE_InsideArea,
            DIMMERTYPE_OutsideArea
        }
        public enum ETCrBoneId
        {
            TCrB_Root,
            TCrB_Pelvis,
            TCrB_Torso1,
            TCrB_Torso2,
            TCrB_Torso3,
            TCrB_Neck,
            TCrB_Head,
            TCrB_ShoulderL,
            TCrB_BicepL,
            TCrB_ForearmL,
            TCrB_HandL,
            TCrB_WeaponL,
            TCrB_ShoulderR,
            TCrB_BicepR,
            TCrB_ForearmR,
            TCrB_HandR,
            TCrB_WeaponR,
            TCrB_ThighL,
            TCrB_ShinL,
            TCrB_FootL,
            TCrB_ToeL,
            TCrB_ThighR,
            TCrB_ShinR,
            TCrB_FootR,
            TCrB_ToeR,
            TCrB_Last
        }

        public enum ETriggerShape
        {
            TS_None,
            TS_Sphere,
            TS_Box
        }
        public enum EEntityGameplayEffectFlags
        {
            EGEF_FocusModeHighlight
        }
        public enum EWoundTypeFlags
        {
            WTF_None,
            WTF_Cut,
            WTF_Explosion,
            WTF_Frost
        }
        public enum EBehaviorMimicBlendType
        {
            BMBT_Continues,
            BMBT_Max,
            BMBT_Min,
            BMBT_Add,
            BMBT_Sub,
            BMBT_Mul,
            BMBT_AbsMax
        }
        public enum EBehaviorMimicMathOp
        {
            BMMO_Add,
            BMMO_Sub,
            BMMO_Mul,
            BMMO_Div,
            BMMO_Max,
            BMMO_Min
        }
        public enum EMimicGeneratorType
        {
            MGT_Null,
            MGT_Damp,
            MGT_Cheeks,
            MGT_HeadSin
        }
        public enum EBehaviorMathOp
        {
            BMO_Add,
            BMO_Subtract,
            BMO_Multiply,
            BMO_Divide,
            BMO_SafeDivide,
            BMO_ATan,
            BMO_AngleDiff,
            BMO_Length,
            BMO_Abs
        }
        public enum EBehaviorValueLatchType
        {
            BVLT_Activation,
            BVLT_Max,
            BVLT_Min
        }
        public enum EBehaviorValueTimerType
        {
            BVTT_Activation,
            BVTT_ConditionTimer,
            BVTT_ConditionReset
        }
        public enum EBehaviorValueModifierType
        {
            BVM_OneMinus,
            BVM_AdditiveMap,
            BVM_Negative,
            BVM_11To01,
            BVM_11To02,
            BVM_01To11,
            BVM_01To02,
            BVM_11To180180,
            BVM_180180To11,
            BVM_RadToDeg,
            BVM_DegToRad,
            BVM_RadTo11,
            BVM_360To180180
        }
        public enum EBehaviorWaveValueType
        {
            BWVT_Sin,
            BWVT_Step01,
            BWVT_Step11,
            BWVT_Triangle01
        }
        public enum EBehaviorVectorMathOp
        {
            BVMO_Add,
            BVMO_Subtract,
            BVMO_Multiply,
            BVMO_Divide,
            BVMO_CrossProduct,
            BVMO_DotProduct,
            BVMO_Length,
            BVMO_XComponent,
            BVMO_YComponent,
            BVMO_ZComponent,
            BVMO_WComponent
        }
        public enum EBehaviorCustomDampType
        {
            BGCDT_DirectionalAcc,
            BGCDT_FilterLowPass
        }
        public enum EAttackDirection
        {
            AD_Front,
            AD_Left,
            AD_Right,
            AD_Back
        }
        public enum EAttackDistance
        {
            ADIST_Small,
            ADIST_Medium,
            ADIST_Large
        }
        public enum ECompareFunc
        {
            CF_Equal,
            CF_NotEqual,
            CF_Less,
            CF_LessEqual,
            CF_Greater,
            CF_GreaterEqual
        }
        public enum EBoneRotationAxis
        {
            ROTAXIS_X,
            ROTAXIS_Y,
            ROTAXIS_Z
        }
        public enum EBehaviorEngineValueType
        {
            BEVT_TimeDelta,
            BEVT_ActorToCameraAngle,
            BEVT_ActorSpeed,
            BEVT_ActorMoveDirection,
            BEVT_ActorHeading,
            BEVT_ActorRotationSpeed,
            BEVT_ActorRelativeDirection,
            BEVT_ActorRotation,
            BEVT_ActorRawDesiredRotation,
            BEVT_CameraFollowAngle,
            BEVT_ActorLookAtLevel,
            BEVT_ActorLookAtEnabled,
            BEVT_Pad,
            BEVT_ActorAnimState,
            BEVT_ActorMoveDirToFacingDiff,
            BEVT_AnimationMultiplier,
            BEVT_IsActorInScene,
            BEVT_CurrentBehaviorGraphInstanceTimeActive
        }
        public enum EBehaviorEngineVectorValueType
        {
            BEVVT_ActorLookAtTarget,
            BEVVT_ActorLookAtCompressedData,
            BEVVT_ActorLookAtBodyPartWeights,
            BEVVT_ActorEyesLookAtData
        }
        public enum ETransformType
        {
            TT_Translation,
            TT_Rotation,
            TT_Scale
        }
        public enum EVectorVariableType
        {
            VVT_Position,
            VVT_Rotation
        }
        public enum EVariableSpace
        {
            VS_Model,
            VS_Global
        }
        public enum EBehaviorGraphChooseRecoverFromRagdollAnimMode
        {
            RFR_JustOne,
            RFR_FrontBack,
            RFR_FrontBackSides
        }
        public enum EBehaviorConstraintDampType
        {
            BCDT_Duration,
            BCDT_Speed
        }
        public enum EMimicNodePoseType
        {
            MNPS_Pose,
            MNPS_Filter,
            MNPS_CustomFilter_Full,
            MNPS_CustomFilter_Lipsync
        }
        public enum ESAnimationMappedPoseMode
        {
            AMPM_Default,
            AMPM_Additive,
            AMPM_Override
        }
        public enum EAnimationAttackType
        {
            AAT_None,
            AAT_Jab,
            AAT_46,
            AAT_64,
            AAT_82,
            AAT_28,
            AAT_73,
            AAT_91,
            AAT_19,
            AAT_37
        }
        public enum EAnimationTrajectorySelectorType
        {
            ATST_None,
            ATST_IK,
            ATST_Blend2,
            ATST_Blend3,
            ATST_Blend2Direction
        }
        public enum EActionMoveAnimationSyncType
        {
            AMAST_None,
            AMAST_CrossBlendIn,
            AMAST_CrossBlendOut
        }
        public enum EBreastPreset
        {
            Default_Naked,
            Natural_Normal,
            Unnatural,
            Clothed,
            CUSTOM_PRESET
        }
        public enum EBrushFaceMapping
        {
            BFM_World,
            BFM_Local,
            BFM_Face
        }
        public enum EBrushCSGType
        {
            CSG_Edit,
            CSG_Addtive,
            CSG_Subtractive,
            CSG_Detail
        }
        public enum EParticleVertexDrawerType
        {
            PVDT_Billboard,
            PVDT_Rain,
            PVDT_Screen,
            PVDT_EmitterOrientation,
            PVDT_SphereAligned,
            PVDT_MotionBlurred,
            PVDT_Trail,
            PVDT_Mesh,
            PVDT_FacingTrail,
            PVDT_Beam
        }
        public enum EMeshParticleOrientationMode
        {
            MPOM_Normal,
            MPOM_MovementDirection,
            MPOM_NoRotation
        }
        public enum ETextureAnimationMode
        {
            TAM_Speed,
            TAM_LifeTime
        }
        public enum EFreeVectorAxes
        {
            FVA_One,
            FVA_Two,
            FVA_Three
        }
        public enum EAreaEnvironmentPointType
        {
            AEPT_FadeOut,
            AEPT_FadeIn,
            AEPT_Additive,
            AEPT_Subtractive,
            AEPT_SubEnvironment
        }
        public enum EAreaEnvironmentPointBlend
        {
            AEPB_DistanceOnly,
            AEPB_CameraFocusAndDistance,
            AEPB_CameraAngleAndDistance
        }
        public enum EMaterialDataType
        {
            MDT_Float,
            MDT_Float2,
            MDT_Float3,
            MDT_Float4,
            MDT_Float4x4,
            MDT_Float4x3,
            MDT_Float3x3,
            MDT_Bool,
            MDT_Uint,
            MDT_Int,
            MDT_Int2,
            MDT_Int3,
            MDT_Int4
        }
        public enum EMaterialSamplerType
        {
            MST_Texture,
            MST_Cubemap,
            MST_Volume,
            MST_TextureArray
        }
        public enum EMaterialParamType
        {
            MPT_Float,
            MPT_Float2,
            MPT_Float3,
            MPT_Float4,
            MPT_Float4x4,
            MPT_Float4x3,
            MPT_Float3x3,
            MPT_Bool,
            MPT_Texture,
            MPT_Cubemap,
            MPT_Volume
        }
        public enum EMaterialShaderTarget
        {
            MSH_VertexShader
        }
        public enum ERenderFeedbackDataType
        {
            RFDT_Depth,
            RFDT_Color
        }
        public enum EMaterialVertexFactory
        {
            MVF_Terrain,
            MVF_MeshStatic,
            MVF_MeshSkinned,
            MVF_ParticleBilboard,
            MVF_ParticleBilboardRain,
            MVF_ParticleParallel,
            MVF_ParticleMotionBlur,
            MVF_ParticleSphereAligned,
            MVF_ParticleVerticalFixed,
            MVF_ParticleTrail,
            MVF_ParticleFacingTrail,
            MVF_ParticleScreen,
            MVF_ParticleBeam,
            MVF_ApexWithoutBones
        }
        public enum EMaterialEngineValueType
        {
            MEVT_DistanceToCamera,
            MEVT_DistanceToCameraParallel,
            MEVT_CameraPosition,
            MEVT_CameraVectorUp,
            MEVT_CameraVectorForward,
            MEVT_CameraVectorRight,
            MEVT_CameraNear,
            MEVT_CameraFar,
            MEVT_GameTime,
            MEVT_Date,
            MEVT_WorldTime,
            MEVT_DayHour,
            MEVT_GlobalLightDir,
            MEVT_MoonDir,
            MEVT_GlobalLightDiffuseColor,
            MEVT_GlobalLightSpecularColor,
            MEVT_GlobalDayAmount,
            MEVT_Custom0,
            MEVT_Custom1,
            MEVT_FXColor,
            MEVT_GameplayFXRendererParam,
            MEVT_FoliageColor,
            MEVT_RainStrength,
            MEVT_WetSurfaceStrength,
            MEVT_DelayedWetSurfaceStrength,
            MEVT_WindStrength,
            MEVT_WindDirectionZ,
            MEVT_SkyboxWeatherBlend,
            MEVT_CloudsShadowIntensity,
            MEVT_MorphBlendRatio,
            MEVT_LightUsageMask,
            MEVT_TransparencyParams,
            MEVT_SkeletalExtraData,
            MEVT_ScreenVPOS
        }
        public enum EFieldType
        {
            FT_Const,
            FT_Linear,
            FT_Square
        }
        public enum ETerrainTileCollision
        {
            TTC_AutoOn,
            TTC_AutoOff,
            TTC_ForceOn,
            TTC_ForceOff
        }
        public enum EUmbraTileDataStatus
        {
            EUTDS_Unknown,
            EUTDS_NoData,
            EUTDS_Invalid,
            EUTDS_Valid,
            EUTDS_ComputationInProgress
        }
        public enum EVegetationAlignment
        {
            VA_Terrain,
            VA_Collision,
            VA_Max
        }
        public enum ERenderDynamicDecalProjection
        {
            RDDP_Ortho,
            RDDP_Sphere
        }
        public enum ERenderDynamicDecalAtlas
        {
            RDDA_1x1,
            RDDA_2x1,
            RDDA_2x2,
            RDDA_4x2,
            RDDA_4x4,
            RDDA_8x4
        }
        public enum EDynamicDecalSpawnPriority
        {
            RDDS_Normal,
            RDDS_Highest
        }
        public enum EMeshShadowImportanceBias
        {
            MSIB_Default,
            MSIB_MoreImportant,
            MSIB_EvenMoreImportant
        }
        public enum EPathLibCollision
        {
            PLC_Disabled,
            PLC_Static,
            PLC_StaticWalkable,
            PLC_StaticMetaobstacle,
            PLC_Dynamic,
            PLC_Walkable,
            PLC_Immediate
        }
        public enum EBatchQueryQueryFlag
        {
            EQQF_IMPACT,
            EQQF_NORMAL,
            EQQF_DISTANCE,
            EQQF_UV
        }
        public enum EMeshVertexType
        {
            MVT_StaticMesh,
            MVT_SkinnedMesh,
            MVT_DestructionMesh
        }
        public enum EDispatcherSelection
        {
            EDS_CPU_ONLY,
            EDS_GPU_ONLY,
            EDS_GPU_IF_AVAILABLE
        }
        public enum ECompressTranslationType
        {
            CT_8,
            CT_16,
            CT_None
        }
        public enum ECompressedRotationType
        {
            CRT_32,
            CRT_64,
            CRT_None
        }
        public enum ELookAtSolverType
        {
            LST_Quat,
            LST_Euler
        }
        public enum EAttitudeGroupPriority
        {
            AGP_Default,
            AGP_SpawnTree,
            AGP_Axii,
            AGP_Fistfight,
            AGP_Scenes
        }
        public enum EExplorationType
        {
            ET_Jump,
            ET_Ladder,
            ET_Horse_LF,
            ET_Horse_LB,
            ET_Horse_L,
            ET_Horse_R,
            ET_Horse_RF,
            ET_Horse_RB,
            ET_Horse_B,
            ET_Boat_B,
            ET_Boat_P,
            ET_Boat_Enter_From_Beach,
            ET_Fence,
            ET_Fence_OneSided,
            ET_Ledge,
            ET_Boat_Passenger_B
        }
        public enum ExpZComparision
        {
            EXPZCMP_ANY,
            EXPZCMP_LESSER,
            EXPZCMP_GREATER,
            EXPZCMP_DIST,
            EXPZCMP_SIDE_LG
        }
        public enum ExpDoubleSided
        {
            EXPDS_SINGLE,
            EXPDS_DOUBLE,
            EXPDS_DOUBLE_FOR_AI,
            EXPDS_DOUBLE_FOR_PLAYER
        }
        public enum EInventoryItemClass
        {
            InventoryItemClass_Common,
            InventoryItemClass_Magic,
            InventoryItemClass_Rare
        }
        public enum EUsableItemType
        {
            UI_Torch,
            UI_Horn,
            UI_Bell,
            UI_OilLamp,
            UI_Mask,
            UI_FiendLure,
            UI_Meteor,
            UI_None,
            UI_Censer,
            UI_Apple,
            UI_Cookie,
            UI_Basket
        }
        public enum EInventoryEventType
        {
            IET_Empty,
            IET_ItemAdded,
            IET_ItemRemoved,
            IET_ItemQuantityChanged,
            IET_ItemTagChanged
        }
        public enum EItemLatentAction
        {
            ILA_Draw,
            ILA_Holster,
            ILA_Switch
        }
        public enum EItemHand
        {
            IH_Right,
            IH_Left,
            IH_Both,
            IH_None
        }
        public enum EDialogLookAtType
        {
            DLT_Static,
            DLT_Dynamic,
            DLT_StaticPoint
        }
        public enum EStorySceneSignalType
        {
            SSST_Accept,
            SSST_Highlight,
            SSST_Skip
        }
        public enum EDialogResetClothAndDanglesType
        {
            DRCDT_None,
            DRCDT_Reset,
            DRCDT_ResetAndRelax
        }
        public enum EStorySceneAnimationType
        {
            AAST_Normal,
            AAST_Override,
            AAST_Additive
        }
        public enum EStorySceneMimicsKeyType
        {
            SSMKT_OverrideAll,
            SSMKT_OverridePose,
            SSMKT_OverrideAnimation,
            SSMKT_AdditiveAll
        }
        public enum EStoryScenePoseKeyType
        {
            SSPKT_AdditiveAll,
            SSPKT_AdditiveIdle
        }
        public enum ELightTrackingType
        {
            LTT_Normal,
            LTT_Reverse
        }
        public enum ESceneDialogsetCameraSet
        {
            SDSC_None,
            SDSC_Personal,
            SDSC_Master,
            SDSC_All
        }
        public enum EPushingDirection
        {
            EPD_Front,
            EPD_Back
        }
        public enum EExplorationState
        {
            EX_Normal,
            EX_WithRangedWeapon,
            EX_WithWeapon,
            EX_Drunk,
            EX_Injured,
            EX_Stealth,
            EX_CarryTorch,
            EX_WithPickaxe
        }
        public enum EPathEngineAgentType
        {
            PEAT_Player,
            PEAT_TallNPCs,
            PEAT_ShortNPCs,
            PEAT_Monsters,
            PEAT_Ghost
        }
        public enum EAIEventType
        {
            EAIE_Unknown,
            EAIE_Goal,
            EAIE_Action,
            EAIE_Sense,
            EAIE_State,
            EAIE_Movement,
            EAIE_Misc
        }
        public enum EPlayerInteractionLock
        {
            PIL_Cutscene,
            PIL_Default,
            PIL_CombatAction
        }
        public enum EStoryScenePerformActionMode
        {
            PerformAction,
            DontPerformAction,
            DontcareaboutAction
        }
        public enum EGameplayEntityFlags
        {
            FLAG_HasWind
        }
        public enum EFocusModeVisibility
        {
            FMV_None,
            FMV_Interactive,
            FMV_Clue
        }
        public enum EItemAction
        {
            IA_Mount,
            IA_MountToHand,
            IA_MountToLeftHand,
            IA_MountToRightHand,
            IA_Unmount
        }
        public enum EGettingItem
        {
            GI_ByName,
            GI_ByCategory
        }
        public enum EItemEffectAction
        {
            IEA_Start,
            IEA_Stop
        }
        public enum EDropAction
        {
            DA_DropRightHand,
            DA_DropLeftHand,
            DA_DropAny
        }
        public enum EEntityTargetingActionMechanism
        {
            ETAM_Self,
            ETAM_ByHandle,
            ETAM_Activator
        }
        public enum EMinigameState
        {
            EMS_None,
            EMS_Init
        }
        public enum EZoneAcceptor
        {
            ZA_LairAreaOnly,
            ZA_BothTriggersAndLairArea
        }
        public enum EBehaviorTreeEventType
        {
            BTET_AET_Tick,
            BTET_AET_DurationStart,
            BTET_AET_DurationStartInTheMiddle,
            BTET_AET_DurationEnd,
            BTET_AET_Duration,
            BTET_GameplayEvent
        }
        public enum EVisibilityTest
        {
            VT_None,
            VT_LineOfSight,
            VT_RangeAndLineOfSight
        }
        public enum EAIMinigameDifficulty
        {
            AIMD_Easy,
            AIMD_Normal,
            AIMD_Hard
        }
        public enum EBTNodeStatus
        {
            BTNS_Active,
            BTNS_Failed,
            BTNS_Completed
        }
        public enum EAIAreaSelectionMode
        {
            EAIASM_Encounter,
            EAIASM_GuardArea,
            EAIASM_ByTag,
            EAIASM_ByTagInEncounter,
            EAIASM_None
        }
        
        public enum EEntryState
        {
            EES_ACTIVATED,
            EES_DEACTIVATED,
            EES_LOADING,
            EES_UNLOADING,
            EES_PRESTART
        }
        public enum ESpawnTreeSpawnVisibility
        {
            STSV_SPAWN_HIDEN,
            STSV_SPAWN_ALWAYS,
            STSV_SPAWN_ONLY_VISIBLE
        }
        public enum EMovementAdjustmentNotify
        {
            MAN_None,
            MAN_LocationAdjustmentReachedDestination,
            MAN_RotationAdjustmentReachedDestination,
            MAN_AdjustmentEnded,
            MAN_AdjustmentCancelled
        }
        public enum EFormationConstraintType
        {
            EFormationConstraint_POSITION,
            EFormationConstraint_SPEED
        }
        public enum EBitOperation
        {
            BO_And,
            BO_Or,
            BO_Xor
        }
        public enum EAvoidObstacleStrategy
        {
            AOS_None,
            AOS_Left,
            AOS_Right,
            AOS_Follow,
            AOS_SlowDown,
            AOS_SpeedUp,
            AOS_Stop
        }
        public enum EAdjustRotationChangesScenario
        {
            ARCS_None,
            ARCS_CasualMovement
        }
        public enum ELogicOperator
        {
            ELO_And,
            ELO_Or
        }
        public enum ESkillColor
        {
            SC_None,
            SC_Blue,
            SC_Green,
            SC_Red,
            SC_Yellow
        }
        public enum EDialogActionIcon
        {
            DialogAction_NONE,
            DialogAction_AXII,
            DialogAction_CONTENT_MISSING,
            DialogAction_BRIBE,
            DialogAction_PERSUASION,
            DialogAction_GETBACK,
            DialogAction_GAME_DICES,
            DialogAction_GAME_FIGHT,
            DialogAction_GAME_WRESTLE,
            DialogAction_CRAFTING,
            DialogAction_SHOPPING,
            DialogAction_EXIT,
            DialogAction_HAIRCUT,
            DialogAction_MONSTERCONTRACT,
            DialogAction_BET,
            DialogAction_STORAGE,
            DialogAction_GIFT,
            DialogAction_GAME_DRINK,
            DialogAction_GAME_DAGGER,
            DialogAction_SMITH,
            DialogAction_ARMORER,
            DialogAction_RUNESMITH,
            DialogAction_TEACHER,
            DialogAction_FAST_TRAVEL,
            DialogAction_GAME_CARDS,
            DialogAction_SHAVING,
            DialogAction_TimedChoice,
            DialogAction_AUCTION,
            DialogAction_LEVELUP1,
            DialogAction_LEVELUP2,
            DialogAction_LEVELUP3,
        }
        public enum ECameraPlane
        {
            Wide,
            Medium,
            Semicloseup,
            Closeup,
            Supercloseup
        }
        public enum ELightType
        {
            LT_SpotLight,
            LT_PointLight,
            LT_Dimmer
        }

        public enum ESoundStateDuringScene
        {
            SOUND_DEFAULT,
            SOUND_NO_CHANGE,
            SOUND_SILENCE,
            SOUND_REDUCED
        }
        public enum ESceneSelectionMode
        {
            Sequential,
            Sequentialwithoutskipping,
            Random
        }
        public enum ESceneActorType
        {
            SceneActorType_NewNpcs,
            SceneActorType_BackgroundNpcs
        }
        public enum ECameraInterpolation
        {
            LINEAR,
            BEZIER
        }
        public enum ESceneEventLightColorSource
        {
            ELCS_EnvLightColor1,
            ELCS_EnvLightColor2,
            ELCS_EnvLightColor3,
            ELCS_CustomLightColor
        }
        public enum EQuestSceneSaveMode
        {
            QSSM_SaveBlocker,
            QSSM_Restart,
            QSSM_Skip
        }
        public enum EQuestPhaseSaveMode
        {
            QPSM_SaveBlocker,
            QPSM_SavesAllowed
        }
        public enum ELogicOperation
        {
            LO_And,
            LO_Or,
            LO_Xor,
            LO_Nand,
            LO_Nor,
            LO_Nxor
        }
        public enum EQuestActorConditionLogicOperation
        {
            ACTORS_All,
            ACTORS_AtLeastOne,
            ACTORS_OneAndOnly
        }
        public enum EQueryFightMode
        {
            QFM_Killed,
            QFM_Stunned,
            QFM_Hit_By_Aard,
            QFM_Hit_By_Igni,
            QFM_Hit_By_Yrden,
            QFM_Hit,
            QFM_Hit_By_Bomb,
            QFM_Hit_By_Bolt,
            QFM_Hit_By_Axii,
            QFM_KnockedUnconscious
        }
        public enum EQuestScriptSaveMode
        {
            QSCSM_SaveBlocker,
            QSCSM_Restart
        }
        public enum ECameraFocusConditionLineOfSightSource
        {
            CFCLOS_Camera,
            CFCLOS_Player
        }
        public enum EInputCompareFunc
        {
            ICF_DontCare,
            ICF_Less,
            ICF_Greater
        }
        public enum EAbilityAttributeType
        {
            EAttrT_Base,
            EAttrT_Additive,
            EAttrT_Multi
        }
        public enum EJobTreeNodeSelectionMode
        {
            SM_RANDOM,
            SM_SEQUENCE
        }
        public enum EJobMovementMode
        {
            JMM_Walk,
            JMM_Run,
            JMM_CustomSpeed
        }
        public enum EJobForceOutDropMode
        {
            JFODM_DropAll,
            JFODM_DropNonWeapon,
            JFODM_NoDrop
        }
        public enum ECommMapPinType
        {
            CMPT_None,
            CMPT_Inn,
            CMPT_Shop,
            CMPT_Craft
        }
        public enum ECommunitySpawnsetType
        {
            CST_Global,
            CST_Template
        }
        public enum EWorkPlacementImportance
        {
            WPI_Anywhere,
            WPI_Nearby,
            WPI_Precise
        }
        public enum EJournalStatus
        {
            JS_Inactive,
            JS_Active,
            JS_Success,
            JS_Failed
        }
        public enum EItemState
        {
            IS_MOUNT,
            IS_HOLD,
            IS_HIDDEN
        }
        public enum EAnimationManualSyncType
        {
            AMST_SyncBeginning,
            AMST_SyncEnd,
            AMST_SyncMatchEvents
        }
        public enum ESyncRotationUsingRefBoneType
        {
            SRT_TowardsOtherEntity,
            SRT_ToMatchOthersRotation
        }
        public enum EChangeFacingDirectionSide
        {
            CFDS_None,
            CFDS_Left,
            CFDS_Right,
            CFDS_Any
        }
        public enum EChangeDirectionSide
        {
            BGCDS_None,
            BGCDS_Left,
            BGCDS_Right,
            BGCDS_Any
        }
        public enum EBehaviorGraphRagdollNodeState
        {
            BGRN_Inactive,
            BGRN_Kinematic,
            BGRN_Ragdoll,
            BGRN_SwitchingFromRagdoll
        }
        public enum EBehaviorGraphAnimatedRagdollNodeState
        {
            BGARN_Ragdoll,
            BGARN_Flying,
            BGARN_HitWall,
            BGARN_HitGround
        }
        public enum EAnimEffectAction
        {
            EA_Start,
            EA_Stop
        }
        public enum EEffectEntityPosition
        {
            EEP_Camera,
            EEP_Player,
            EEP_XYCameraZPlayer,
            EEP_XYPlayerZCamera,
            EEP_XYCameraZTerrain,
            EEP_XYPlayerZTerrain
        }
        public enum EEffectEntityRotation
        {
            EER_None,
            EER_Spawn,
            EER_Continuous
        }
        public enum EProjectileCastPosition
        {
            PCP_Bone,
            PCP_EntityRoot
        }
        public enum EBaseCharacterStats
        {
            BCS_Vitality,
            BCS_Essence,
            BCS_Stamina,
            BCS_Toxicity,
            BCS_Focus,
            BCS_Morale,
            BCS_Air,
            BCS_Panic,
            BCS_PanicStatic,
            BCS_SwimmingStamina,
            BCS_Undefined
        }
        public enum ECharacterDefenseStats
        {
            CDS_None,
            CDS_PhysicalRes,
            CDS_BleedingRes,
            CDS_PoisonRes,
            CDS_FireRes,
            CDS_FrostRes,
            CDS_ShockRes,
            CDS_ForceRes,
            CDS_FreezeRes,
            CDS_WillRes,
            CDS_BurningRes,
            CDS_SlashingRes,
            CDS_PiercingRes,
            CDS_BludgeoningRes,
            CDS_RendingRes,
            CDS_ElementalRes,
            CDS_DoTBurningDamageRes,
            CDS_DoTPoisonDamageRes,
            CDS_DoTBleedingDamageRes
        }
        public enum EAsyncTestResult
        {
            EAsyncTastResult_Failure,
            EAsyncTastResult_Success,
            EAsyncTastResult_Pending,
            EAsyncTastResult_Invalidated
        }
        public enum ENavigationReachabilityTestType
        {
            ENavigationReachability_Any,
            ENavigationReachability_All,
            ENavigationReachability_FullTest
        }
        public enum EAIAttitude
        {
            AIA_Friendly,
            AIA_Neutral,
            AIA_Hostile
        }
        public enum EDoorState
        {
            Door_Closed,
            Door_Open
        }
        public enum EMenuPauseType
        {
            MPT_NoPause,
            MPT_ActivePause,
            MPT_FullPause
        }
        public enum EPopupPauseType
        {
            PPT_NoPause,
            PPT_ActivePause,
            PPT_FullPause
        }
        public enum EScriptQueryFlags
        {
            FLAG_ExcludePlayer,
            FLAG_OnlyActors,
            FLAG_OnlyAliveActors,
            FLAG_WindEmitters
        }
        public enum EGameplayInfoCacheType
        {
            GICT_IsInteractive,
            GICT_HasDrawableComponents,
            GICT_Custom0,
            GICT_Custom1,
            GICT_Custom2,
            GICT_Custom3,
            GICT_Custom4
        }
        public enum EActorActionType
        {
            ActorAction_None,
            ActorAction_Moving,
            ActorAction_Rotating,
            ActorAction_Animation,
            ActorAction_RaiseEvent
        }
        public enum EReactionLookAtType
        {
            RLT_None,
            RLT_Glance,
            RLT_Look,
            RLT_Gaze,
            RLT_Stare
        }
        public enum ELookAtMode
        {
            LM_Dialog,
            LM_Cutscene
        }
        public enum ENPCGroupType
        {
            ENGT_Enemy,
            ENGT_Commoner,
            ENGT_Quest,
            ENGT_Guard
        }
        public enum EQueryFact
        {
            QF_Sum,
            QF_SumSince,
            QF_LatestValue,
            QF_DoesExist
        }
        public enum EBTLoopMode
        {
            BTLM_Continue,
            BTLM_ReportCompleted,
            BTLM_ReportFailed
        }
        public enum ESpawnTreeType
        {
            STT_default,
            STT_gameplay
        }
        public enum ESlideRotation
        {
            SR_Nearest,
            SR_Right,
            SR_Left
        }
        public enum ERotationRate
        {
            RR_0
        }
        public enum EInterpolationMethod
        {
            IM_Constant,
            IM_Linear,
            IM_Bezier
        }
        public enum EInterpolationEasingStyle
        {
            IES_Smooth,
            IES_Rapid
        }
        public enum ETrapOperation
        {
            TO_Activate,
            TO_Deactivate
        }
        public enum ECameraState
        {
            CS_Exploration,
            CS_Combat,
            CS_FocusModeNC,
            CS_FocusModeCombat,
            CS_AimThrow,
            CS_Horse,
            CS_Boat
        }
        public enum EScriptedDetroyableComponentState
        {
            DC_Idle,
            DC_PreDestroy,
            DC_Destroy,
            DC_PostDestroy
        }
        public enum ENewGamePlusStatus
        {
            NGP_Success,
            NGP_Invalid,
            NGP_CantLoad,
            NGP_TooOld,
            NGP_RequirementsNotMet,
            NGP_InternalError,
            NGP_ContentRequired
        }
        public enum EDoorOperation
        {
            DO_Open,
            DO_Close,
            DO_Toggle,
            DO_Lock,
            DO_Unlock,
            DO_ToggleLock
        }
        public enum ESoundGameState
        {
            ESGS_Default,
            ESGS_Exploration,
            ESGS_ExplorationNight,
            ESGS_Focus,
            ESGS_FocusNight,
            ESGS_FocusUnderwater,
            ESGS_Combat,
            ESGS_CombatMonsterHunt,
            ESGS_Dialog,
            ESGS_DialogNight,
            ESGS_Cutscene,
            ESGS_Minigame,
            ESGS_Death,
            ESGS_Movie,
            ESGS_Boat,
            ESGS_MusicOnly,
            ESGS_Underwater,
            ESGS_UnderwaterCombat,
            ESGS_Paused,
            ESGS_Gwent,
            ESGS_FocusUnderwaterCombat
        }
        public enum EQuestBehaviorSceneSaveMode
        {
            QBDSM_SaveBlocker,
            QBDSM_Restart
        }
        public enum EPropertyAnimationOperation
        {
            PAO_Play,
            PAO_Stop,
            PAO_Rewind,
            PAO_Pause,
            PAO_Unpause
        }

        public enum EFastTravelConditionType
        {
            FTCT_StartedFastTravel,
            FTCT_FinishedFastTravel
        }
        public enum EOpenedUIPanel
        {
            OUP_Alchemy,
            OUP_Inventory,
            OUP_Container,
            OUP_Shop,
            OUP_Preparation,
            OUP_WorldMap,
            OUP_Crafting,
            OUP_Character,
            OUP_Journal
        }
        public enum EOpenedUIJournalTab
        {
            OUJT_Quests,
            OUJT_Bestiary,
            OUJT_Storybook,
            OUJT_Characters,
            OUJT_Glossary,
            OUJT_Tutorial
        }
        public enum EVehicleType
        {
            EVT_Horse,
            EVT_Boat,
            EVT_Undefined
        }
        public enum EHorseMoveType
        {
            HMT_SlowWalk,
            HMT_Walk,
            HMT_Trot,
            HMT_Gallop,
            HMT_Canter
        }
        public enum EWitcherSwordType
        {
            WST_Silver,
            WST_Steel
        }
        public enum EComboAttackType
        {
            ComboAT_Normal,
            ComboAT_Directional,
            ComboAT_Restart,
            ComboAT_Stop
        }
        public enum ENewDoorOperation
        {
            NDO_Open,
            NDO_Close,
            NDO_Toggle,
            NDO_Lock,
            NDO_Unlock,
            NDO_ToggleLock
        }
        public enum EClueOperation
        {
            CO_Enable,
            CO_Disable,
            CO_None
        }
        public enum EToxicCloudOperation
        {
            TCO_Enable,
            TCO_Disable
        }
        public enum EOilBarrelOperation
        {
            OBO_Ignite,
            OBO_Explode
        }
        
        public enum ENPCFightStage
        {
            NFS_Stage1,
            NFS_Stage2,
            NFS_Stage3,
            NFS_Stage4,
            NFS_Stage5
        }
        public enum EJournalMapPinType
        {
            EJMPT_Default,
            EJMPT_QuestReturn,
            EJMPT_HorseRace,
            EJMPT_BoatRace
        }
        public enum eQuestObjectiveType
        {
            Manual,
            Killcount,
            InventoryCount,
            HuntingList
        }
        public enum eQuestType
        {
            Story,
            Chapter,
            Side,
            MonsterHunt,
            TreasureHunt
        }
        public enum EJournalVisibilityAction
        {
            JVA_Nothing,
            JVA_Show,
            JVA_Hide
        }
        public enum ECharacterImportance
        {
            MainCharacter,
            SideCharacter
        }
        public enum eGwintFaction
        {
            GwintFaction_Neutral,
            GwintFaction_NoMansLand,
            GwintFaction_Nilfgaard,
            GwintFaction_NothernKingdom,
            GwintFaction_Scoiatael,
            GwintFaction_Skellige,
            GwintType_None,
            GwintType_Melee,
            GwintType_Ranged,
            GwintType_Siege,
            GwintType_Creature,
            GwintType_Weather,
            GwintType_Spell,
            GwintType_RowModifier,
            GwintType_Hero,
            GwintType_Spy,
            GwintType_FriendlyEffect,
            GwintType_OffensiveEffect,
            GwintType_GlobalEffect,
        }
        public enum eGwintType
        {
            GwintType_None,
            GwintType_Melee,
            GwintType_Ranged,
            GwintType_Siege,
            GwintType_Creature
        }

        public enum ECombatTargetSelectionSkipTarget
        {
            CTSST_SKIP_ALWAYS,
            CTSST_SKIP_IF_THERE_ARE_OTHER_TARGETS,
            CTSST_DONT_SKIP
        }
        public enum EVehicleMountStatus
        {
            VMS_mountInProgress,
            VMS_mounted,
            VMS_dismountInProgress,
            VMS_dismounted
        }
        public enum EMountType
        {
            MT_normal,
            MT_instant
        }
        public enum EDismountType
        {
            DT_normal,
            DT_shakeOff,
            DT_ragdoll,
            DT_instant
        }
        public enum EVehicleSlot
        {
            EVS_driver_slot,
            EVS_passenger_slot
        }
        public enum EVehicleMountType
        {
            VMT_None,
            VMT_ApproachAndMount,
            VMT_MountIfPossible,
            VMT_TeleportAndMount,
            VMT_ImmediateUse
        }
        public enum EParryType
        {
            PT_Up,
            PT_UpLeft,
            PT_Left,
            PT_LeftDown,
            PT_Down,
            PT_DownRight,
            PT_Right,
            PT_RightUp,
            PT_Jab,
            PT_None
        }
        public enum ERidingManagerTask
        {
            RMT_None,
            RMT_MountHorse,
            RMT_DismountHorse,
            RMT_MountBoat,
            RMT_DismountBoat
        }
        public enum EBehTreeTicketSourceProviderType
        {
            BTTSP_Combat,
            BTTSP_Global
        }
        public enum EExplorationHeldItems
        {
            EEHI_None,
            EEHI_Box
        }
        public enum ER4CommonStats
        {
            CS_VITALITY,
            CS_TOXICITY,
            CS_VIGOR,
            CS_SKILLPOINTS,
            CS_POSITION_X,
            CS_POSITION_Y,
            CS_POSITION_Z,
            CS_DIFFICULTY_LVL,
            CS_GAME_PROGRESS,
            CS_MEMORY,
            CS_FPS,
            CS_WORLD_ID,
            CS_GAME_TIME,
            CS_UNKNOWN
        }
        public enum ER4TelemetryEvents
        {
            TE_STATE_HORSE_RIDING,
            TE_STATE_SAILING,
            TE_STATE_AIM_THROW,
            TE_STATE_COMBAT,
            TE_STATE_EXPLORING,
            TE_STATE_DIALOG,
            TE_STATE_SWIMMING,
            TE_HERO_FAST_TRAVEL,
            TE_HERO_LEVEL_UP,
            TE_HERO_EXP_EARNED,
            TE_HERO_SKILL_POINT_EARNED,
            TE_HERO_SKILL_UP,
            TE_HERO_CASH_CHANGED,
            TE_HERO_SPAWNED,
            TE_HERO_FOCUS_ON,
            TE_HERO_FOCUS_OFF,
            TE_HERO_MUTAGEN_USED,
            TE_HERO_ACHIEVEMENT_UNLOCKED,
            TE_HERO_HEALTH_SEGMENT_LOST,
            TE_HERO_HEALTH_SEGMENT_REGAINED,
            TE_FIGHT_PLAYER_DIES,
            TE_FIGHT_PLAYER_ATTACKS,
            TE_FIGHT_PLAYER_USE_SIGN,
            TE_FIGHT_ENEMY_DIES,
            TE_FIGHT_ENEMY_GETS_HIT,
            TE_FIGHT_HERO_GETS_HIT,
            TE_FIGHT_HERO_THROWS_BOMB,
            TE_ITEM_COOKED,
            TE_ELIXIR_USED,
            TE_INV_ITEM_EQUIPPED,
            TE_INV_ITEM_UNEQUIPPED,
            TE_INV_ITEM_PICKED,
            TE_INV_ITEM_DROPPED,
            TE_INV_ITEM_SOLD,
            TE_INV_ITEM_BOUGHT,
            TE_INV_QUEST_COMPLETED,
            TE_HERO_MOVEMENT,
            TE_HERO_POSITION,
            TE_SYS_END_SESISON,
            TE_SYS_GAME_LOADED,
            TE_SYS_GAME_SAVED,
            TE_SYS_GAME_LAUNCHED,
            TE_SYS_GAME_PAUSE,
            TE_SYS_GAME_UNPAUSE,
            TE_SYS_GAME_PROGRESS,
            TE_QUEST_ACTIVATED,
            TE_QUEST_FINISHED,
            TE_QUEST_FAILED,
            TE_UNKNOWN
        }
        public enum ESceneEventSurfacePostFXType
        {
            ES_Frost,
            ES_Burn
        }
        public enum EGwintDifficultyMode
        {
            EGDM_Easy,
            EGDM_Medium,
            EGDM_Hard
        }
        public enum EGwintAggressionMode
        {
            EGAM_Defensive,
            EGAM_Normal,
            EGAM_Aggressive,
            EGAM_VeryAggressive,
            EGAM_AllIHave
        }
        public enum EFinisherSide
        {
            FinisherLeft,
            FinisherRight
        }
        public enum EBufferActionType
        {
            EBAT_EMPTY,
            EBAT_LightAttack,
            EBAT_HeavyAttack,
            EBAT_CastSign,
            EBAT_ItemUse,
            EBAT_Parry,
            EBAT_Dodge,
            EBAT_SpecialAttack_Light,
            EBAT_SpecialAttack_Heavy,
            EBAT_Roll,
            EBAT_Ciri_SpecialAttack,
            EBAT_Ciri_SpecialAttack_Heavy,
            EBAT_Ciri_Counter,
            EBAT_Ciri_Dodge,
            EBAT_Draw_Steel,
            EBAT_Draw_Silver,
            EBAT_Sheathe_Sword
        }
        public enum ECombatActionType
        {
            CAT_Attack,
            CAT_SpecialAttack,
            CAT_Dodge,
            CAT_Roll,
            CAT_ItemThrow,
            CAT_LayItem,
            CAT_CastSign,
            CAT_Pirouette,
            CAT_PreAttack,
            CAT_Parry,
            CAT_Crossbow,
            CAT_None2,
            CAT_CiriDodge
        }
        public enum EOrientationTarget
        {
            OT_Player,
            OT_Actor,
            OT_CustomHeading,
            OT_Camera,
            OT_CameraOffset,
            OT_None
        }
        public enum EDifficultyMode
        {
            EDM_NotSet,
            EDM_Easy,
            EDM_Medium,
            EDM_Hard,
            EDM_Hardcore
        }
        public enum ENpcStance
        {
            NS_Normal,
            NS_Strafe,
            NS_Retreat,
            NS_Guarded,
            NS_Wounded,
            NS_Fly,
            NS_Swim
        }
        public enum ECurvePointInterpolateMode
        {
            CPI_LINEAR,
            CPI_X2,
            CPI_X3,
            CPI_X2_INV,
            CPI_X3_INV,
            CPI_X2_HISTERESIS,
            CPI_X3_HISTERESIS,
            CPI_X2_INV_HISTERESIS,
            CPI_X3_INV_HISTERESIS
        }
        public enum ESimpleCurveType
        {
            SCT_Float,
            SCT_Vector,
            SCT_Color,
            SCT_ColorScaled
        }
        public enum ECurveBaseType
        {
            CT_Linear,
            CT_Smooth,
            CT_Segmented
        }
        public enum ECurveSegmentType
        {
            CST_Constant,
            CST_Interpolate,
            CST_Bezier,
            CST_BezierSmooth,
            CST_BezierSmoothLyzwiaz,
            CST_BezierSmoothSymertric,
            CST_Bezier2D
        }
        public enum ECurveValueType
        {
            CVT_Float,
            CVT_Vector
        }
        public enum ESide
        {
            S_Left,
            S_Right
        }
        public enum EPlayerMoveType
        {
            PMT_Idle,
            PMT_Walk,
            PMT_Run,
            PMT_Sprint
        }
        public enum EPlayerMovementLockType
        {
            PMLT_Free,
            PMLT_NoSprint,
            PMLT_NoRun
        }
        public enum EAsyncCheckResult
        {
            ASR_InProgress,
            ASR_ReadyTrue,
            ASR_ReadyFalse,
            ASR_Failed
        }
        public enum ESignType
        {
            ST_Aard,
            ST_Yrden,
            ST_Igni,
            ST_Quen,
            ST_Axii,
            ST_None
        }
        public enum ETerrainType
        {
            TT_Normal,
            TT_Rough,
            TT_Swamp,
            TT_Water
        }
        public enum EPlayerActionToRestore
        {
            PATR_Default,
            PATR_Crossbow,
            PATR_CastSign,
            PATR_ThrowBomb,
            PATR_CallHorse,
            PATR_None
        }
        public enum EPhysicalDamagemechanismOperation
        {
            EPDM_Activate,
            EPDM_Deactivate
        }
        public enum EFocusModeSoundEffectType
        {
            FMSET_Gray,
            FMSET_Red,
            FMSET_Green,
            FMSET_None
        }
        public enum EStorySceneOutputAction
        {
            SSOA_None,
            SSOA_ReturnToPreviousState,
            SSOA_MountVehicle,
            SSOA_MountVehicleFast,
            SSOA_EnterCombatSteel,
            SSOA_EnterCombatSilver,
            SSOA_EnterCombatFists
        }
        public enum EInventoryFundsType
        {
            EInventoryFunds_Unlimited,
            EInventoryFunds_Rich,
            EInventoryFunds_Avg,
            EInventoryFunds_Poor,
            EInventoryFunds_RichQuickStart,
            EInventoryFunds_Broke
        }
        public enum EInventoryActionType
        {
            IAT_None,
            IAT_Equip,
            IAT_UpgradeWeapon,
            IAT_UpgradeWeaponSteel,
            IAT_UpgradeWeaponSilver,
            IAT_UpgradeArmor,
            IAT_Consume,
            IAT_Read,
            IAT_Drop,
            IAT_Transfer,
            IAT_Sell,
            IAT_Buy,
            IAT_Repair,
            IAT_Divide,
            IAT_Socket
        }
        
        public enum EDayPart
        {
            EDP_Undefined,
            EDP_Dawn,
            EDP_Noon,
            EDP_Dusk,
            EDP_Midnight
        }
        public enum EWeatherEffect
        {
            EWE_Clear,
            EWE_Rain,
            EWE_Snow,
            EWE_Storm,
            EWE_None,
            EWE_Any
        }
        public enum EMoonState
        {
            EMS_NotFull,
            EMS_Full,
            EMS_Red,
            EMS_Any
        }
        public enum ETimescaleSource
        {
            ETS_None,
            ETS_PotionBlizzard,
            ETS_SlowMoTask,
            ETS_HeavyAttack,
            ETS_ThrowingAim,
            ETS_RadialMenu,
            ETS_CFM_PlayAnim,
            ETS_CFM_On,
            ETS_DebugInput,
            ETS_SkillFrenzy,
            ETS_RaceSlowMo,
            ETS_HorseMelee,
            ETS_FinisherInput,
            ETS_TutorialFight,
            ETS_InstantKill
        }
        public enum EStatistic
        {
            ES_Undefined,
            ES_BleedingBurnedPoisoned,
            ES_FinesseKills,
            ES_CharmedNPCKills,
            ES_AardFallKills,
            ES_EnvironmentKills,
            ES_CounterattackChain,
            ES_DragonsDreamTriggers,
            ES_FundamentalsFirstKills,
            ES_DestroyedNests,
            ES_KnownPotionRecipes,
            ES_KnownBombRecipes,
            ES_ReadBooks,
            ES_HeadShotKills
        }
        public enum ETutorialMessageType
        {
            ETMT_Undefined,
            ETMT_Hint,
            ETMT_Message
        }
        public enum ETutorialHintPositionType
        {
            ETHPT_DefaultGlobal,
            ETHPT_DefaultDialog,
            ETHPT_DefaultCombat,
            ETHPT_Custom,
            ETHPT_DefaultUI,
            ETHPT_DefaultRadialMenu
        }
        public enum ETutorialHintDurationType
        {
            ETHDT_NotSet,
            ETHDT_Short,
            ETHDT_Long,
            ETHDT_Infinite,
            ETHDT_Custom,
            ETHDT_Input
        }
        public enum ECriticalStateType
        {
            ECST_BurnCritical,
            ECST_HeavyKnockdown,
            ECST_Knockdown,
            ECST_LongStagger,
            ECST_Stagger,
            ECST_Hypnotized,
            ECST_Confusion,
            ECST_Blindness,
            ECST_Paralyzed,
            ECST_Immobilize,
            ECST_CounterStrikeHit,
            ECST_None,
            ECST_Swarm,
            ECST_Pull,
            ECST_Ragdoll,
            ECST_PoisonCritical,
            ECST_Snowstorm,
            ECST_Frozen
        }
        public enum ECameraAnimPriority
        {
            CAP_Lowest,
            CAP_Low,
            CAP_Normal,
            CAP_High,
            CAP_Highest
        }
        public enum ECraftsmanType
        {
            ECT_Undefined,
            ECT_Smith,
            ECT_Armorer,
            ECT_Crafter,
            ECT_Enchanter
        }
        public enum ECraftsmanLevel
        {
            ECL_Undefined,
            ECL_Journeyman,
            ECL_Master,
            ECL_Grand_Master,
            ECL_Arch_Master
        }
        public enum EClimbRequirementType
        {
            ECRT_Landed,
            ECRT_Jumping,
            ECRT_AirColliding,
            ECRT_Swimming,
            ECRT_Running
        }
        public enum EClimbRequirementVault
        {
            ECRV_NoVault,
            ECRV_Vault
        }
        public enum EClimbRequirementPlatform
        {
            ECRV_NoPlatform,
            ECRV_Platform
        }
        public enum EClimbHeightType
        {
            ECHT_Step,
            ECHT_VerySmall,
            ECHT_Small,
            ECHT_Medium,
            ECHT_High,
            ECHT_VeryHigh
        }
        public enum EJumpType
        {
            EJT_Fall,
            EJT_Idle,
            EJT_IdleToWalk,
            EJT_Walk,
            EJT_WalkHigh,
            EJT_Run,
            EJT_Sprint,
            EJT_Slide,
            EJT_Hit,
            EJT_Vault,
            EJT_ToWater,
            EJT_Skate,
            EJT_KnockBack,
            EJT_KnockBackFall
        }
        public enum ELandType
        {
            LT_Death,
            LT_Damaged,
            LT_Crouch,
            LT_Normal,
            LT_Higher,
            LT_Panther,
            LT_KnockBack,
            LT_FrontAircollision
        }
        public enum ELandRunForcedMode
        {
            LRFM_NotForced,
            LRFM_Idle,
            LRFM_Walk,
            LRFM_Run
        }
        public enum EEquipmentSlots
        {
            EES_InvalidSlot,
            EES_SilverSword,
            EES_SteelSword,
            EES_Armor,
            EES_Boots,
            EES_Pants,
            EES_Gloves,
            EES_Petard1,
            EES_Petard2,
            EES_RangedWeapon,
            EES_Quickslot1,
            EES_Quickslot2,
            EES_Unused,
            EES_Hair,
            EES_Potion1,
            EES_Potion2,
            EES_Mask,
            EES_Bolt,
            EES_PotionMutagen1,
            EES_PotionMutagen2,
            EES_PotionMutagen3,
            EES_PotionMutagen4,
            EES_SkillMutagen1,
            EES_SkillMutagen2,
            EES_SkillMutagen3,
            EES_SkillMutagen4,
            EES_HorseBlinders,
            EES_HorseSaddle,
            EES_HorseBag,
            EES_HorseTrophy,
            EES_Potion3,
            EES_Potion4
        }
        public enum ESkill
        {
            S_SUndefined,
            S_Sword_1,
            S_Sword_2,
            S_Sword_3,
            S_Sword_4,
            S_Sword_5,
            S_Magic_1,
            S_Magic_2,
            S_Magic_3,
            S_Magic_4,
            S_Magic_5,
            S_Alchemy_1,
            S_Alchemy_2,
            S_Alchemy_3,
            S_Alchemy_4,
            S_Alchemy_5,
            S_Sword_s01,
            S_Sword_s02,
            S_Sword_s03,
            S_Sword_s04,
            S_Sword_s05,
            S_Sword_s06,
            S_Sword_s07,
            S_Sword_s08,
            S_Sword_s09,
            S_Sword_s10,
            S_Sword_s11,
            S_Sword_s12,
            S_Sword_s13,
            S_UNUSED1,
            S_Sword_s15,
            S_Sword_s16,
            S_Sword_s17,
            S_Sword_s18,
            S_Sword_s19,
            S_Sword_s20,
            S_Sword_s21,
            S_Magic_s01,
            S_Magic_s02,
            S_Magic_s03,
            S_Magic_s04,
            S_Magic_s05,
            S_Magic_s06,
            S_Magic_s07,
            S_Magic_s08,
            S_Magic_s09,
            S_Magic_s10,
            S_Magic_s11,
            S_Magic_s12,
            S_Magic_s13,
            S_Magic_s14,
            S_Magic_s15,
            S_Magic_s16,
            S_Magic_s17,
            S_Magic_s18,
            S_Magic_s19,
            S_Magic_s20,
            S_UNUSED2,
            S_Alchemy_s01,
            S_Alchemy_s02,
            S_Alchemy_s03,
            S_Alchemy_s04,
            S_Alchemy_s05,
            S_Alchemy_s06,
            S_Alchemy_s07,
            S_Alchemy_s08,
            S_Alchemy_s09,
            S_Alchemy_s10,
            S_Alchemy_s11,
            S_Alchemy_s12,
            S_Alchemy_s13,
            S_Alchemy_s14,
            S_Alchemy_s15,
            S_Alchemy_s16,
            S_Alchemy_s17,
            S_Alchemy_s18,
            S_Alchemy_s19,
            S_Alchemy_s20,
            S_Skill_MAX,
            S_Perk_MIN,
            S_Perk_01,
            S_Perk_02,
            S_Perk_03,
            S_Perk_04,
            S_Perk_05,
            S_Perk_06,
            S_Perk_07,
            S_Perk_08,
            S_Perk_09,
            S_Perk_10,
            S_Perk_11,
            S_Perk_12,
            S_Perk_MAX
        }
        public enum ESkillPath
        {
            ESP_NotSet,
            ESP_Sword,
            ESP_Signs,
            ESP_Alchemy,
            ESP_Perks
        }
        public enum ESkillSubPath
        {
            ESSP_NotSet,
            ESSP_Sword_StyleStrong,
            ESSP_Sword_StyleFast,
            ESSP_Sword_Crossbow,
            ESSP_Sword_Utility,
            ESSP_Sword_BattleTrance,
            ESSP_Sword_Offense,
            ESSP_Sword_Defence,
            ESSP_Sword_General,
            ESSP_Signs_Aard,
            ESSP_Signs_Igni,
            ESSP_Signs_Yrden,
            ESSP_Signs_Quen,
            ESSP_Signs_Axi,
            ESSP_Signs_Offense,
            ESSP_Signs_Defence,
            ESSP_Signs_General,
            ESSP_Alchemy_Potions,
            ESSP_Alchemy_Oils,
            ESSP_Alchemy_Bombs,
            ESSP_Alchemy_Mutagens,
            ESSP_Alchemy_Grasses,
            ESSP_Alchemy_Offense,
            ESSP_Alchemy_Defence,
            ESSP_Alchemy_General,
            ESSP_Perks,
            ESSP_Perks_col1,
            ESSP_Perks_col2,
            ESSP_Perks_col3,
            ESSP_Perks_col4,
            ESSP_Perks_col5,
            ESSP_Core
        }
        public enum EAlchemyCookedItemType
        {
            EACIT_Undefined,
            EACIT_Potion,
            EACIT_Bomb,
            EACIT_Oil,
            EACIT_Substance,
            EACIT_Bolt,
            EACIT_MutagenPotion,
            EACIT_Alcohol,
            EACIT_Quest
        }
        
        public enum ECharacterPowerStats
        {
            CPS_AttackPower,
            CPS_SpellPower,
            CPS_Undefined
        }
        public enum EActionHitAnim
        {
            EAHA_Default,
            EAHA_ForceYes,
            EAHA_ForceNo
        }
        public enum ERequiredSwitchState
        {
            ERSS_ON,
            ERSS_OFF
        }
        public enum EOcurrenceTime
        {
            OT_AllDay,
            OT_DayOnly,
            OT_NightOnly
        }
        public enum EUITutorialTriggerCondition
        {
            EUITTC_OnMenuOpen
        }
        public enum ECompareOp
        {
            CO_Lesser,
            CO_LesserEq,
            CO_Greater,
            CO_GreaterEq,
            CO_Equal,
            CO_NotEqual
        }
        public enum EUpdateEventType
        {
            EUET_StartedTracking,
            EUET_TrackedQuest,
            EUET_TrackedQuestObjective,
            EUET_TrackedQuestObjectiveCounter,
            EUET_HighlightedQuestObjective
        }
        public enum EUserMessageAction
        {
            UMA_Ok,
            UMA_Cancel,
            UMA_Abort,
            UMA_Yes,
            UMA_No
        }
        public enum EBgNPCType
        {
            EBNPCT_None,
            EBNPCT_Master,
            EBNPCT_Slave
        }
        
        
        public enum EQuestPlayerSkillCondition
        {
            EQPSC_Equipped,
            EQPSC_Learned,
            EQPSC_LearnedButNotEquipped
        }
        public enum EBackgroundNPCWork_Single
        {
            EBNWS_None,
            EBNWS_Brush,
            EBNWS_Sit,
            EBNWS_SitPipe,
            EBNWS_Spyglass,
            EBNWS_StandWall,
            EBNWS_Tired,
            EBNWS_WarmUp,
            EBNWS_PlayingFlute,
            EBNWS_SitSquat,
            EBNWS_DrunkStandRope,
            EBNWS_Crouch,
            EBNWS_WriteList,
            EBNWS_GuardStand,
            EBNWS_Rowing,
            EBNWS_StandTalk1,
            EBNWS_StandTalk2,
            EBNWS_StandTalk3,
            EBNWS_SitDrink,
            EBNWS_SitEat,
            EBNWS_Kneel,
            EBNWS_SitGroundHurt,
            EBNWS_Scout,
            EBNWS_Puke,
            EBNWS_Sex,
            EBNWS_Fishing
        }
        public enum EInterpMethodType
        {
            IMT_UseNewAutoTangents,
            IMT_UseFixedTangentEval,
            IMT_UseBrokenTangentEval
        }
        public enum EInterpCurveMode
        {
            CIM_Constant,
            CIM_Linear,
            CIM_CurveAuto,
            CIM_CurveBreak
        }
        public enum ESpaceFillMode
        {
            ESFM_JustifyLeft,
            ESFM_JustifyRight
        }
        public enum EComboAttackResponse
        {
            CAR_HitFront,
            CAR_HitBack,
            CAR_ParryFront,
            CAR_ParryBack
        }
        public enum ECameraShakeState
        {
            CSS_Normal,
            CSS_Drunk,
            CSS_Elevator
        }
        public enum ECameraShakeMagnitude
        {
            CSM_0,
            CSM_1,
            CSM_2,
            CSM_3,
            CSM_4,
            CSM_5
        }
        public enum EGameplayMimicMode
        {
            GMM_Default,
            GMM_Combat,
            GMM_Work,
            GMM_Death,
            PGMM_Sleep,
            GMM_Tpose
        }
        public enum EPlayerGameplayMimicMode
        {
            PGMM_None,
            PGMM_Default,
            PGMM_Combat,
            PGMM_Inventory
        }
        public enum ESoundEventSaveBehavior
        {
            SESB_Save,
            SESB_DontSave,
            SESB_ClearSaved
        }
        
        
        public enum ECharacterRegenStats
        {
            CRS_Undefined,
            CRS_Vitality,
            CRS_Essence,
            CRS_Morale,
            CRS_UNUSED,
            CRS_Stamina,
            CRS_Air,
            CRS_Panic,
            CRS_SwimmingStamina
        }
        public enum EDirection
        {
            D_Front,
            D_Right,
            D_Back,
            D_Left,
            D_Front_60deg,
            D_Front_30deg
        }
        public enum EDirectionZ
        {
            DZ_Undefined,
            DZ_Up,
            DZ_Down,
            DZ_Left,
            DZ_Right
        }
        public enum EScriptedEventCategory
        {
	        SEC_Empty,
	        SEC_OnReusableClueUsed,		
	        SEC_OnItemEquipped,			
	        SEC_OnOilApplied,			
	        SEC_OnAmmoChanged,			
	        SEC_GameplayFact,			
	        SEC_AlchemyRecipe,			
	        SEC_CraftingSchematics,		
	        SEC_OnMapPinChanged,		
	        SEC_OnHudTimeOut,			
        }
        public enum EScriptedEventType
        {
            SET_Unknown
        }
        public enum Platform
        {
            Platform_PC,
            Platform_Xbox1,
            Platform_PS4,
            Platform_Unknown
        }
        public enum EActorImmortalityMode
        {
            AIM_None,
            AIM_Immortal,
            AIM_Invulnerable,
            AIM_Unconscious
        }
        enum EActorImmortalityChanel
        {

            AIC_Default = 1,
            AIC_Combat = 2,
            AIC_Scene = 4,
            AIC_Mutation11 = 8,
            AIC_Fistfight = 16,
            AIC_SyncedAnim = 32,
            AIC_WhiteRaffardsPotion = 64,
            AIC_IsAttackableByPlayer = 128

        }
        public enum EZoneName
        {
            ZN_Undefined,
            ZN_NML_CrowPerch,
            ZN_NML_SpitfireBluff,
            ZN_NML_TheMire,
            ZN_NML_Mudplough,
            ZN_NML_Grayrocks,
            ZN_NML_TheDescent,
            ZN_NML_CrookbackBog,
            ZN_NML_BaldMountain,
            ZN_NML_Novigrad,
            ZN_NML_Homestead,
            ZN_NML_Gustfields,
            ZN_NML_Oxenfurt
        }
        
        public enum EFocusHitReaction
        {
            EFHR_None,
            EFHR_Type1,
            EFHR_Type2,
            EFHR_Type3,
            EFHR_Type4,
            EFHR_Type5
        }
        public enum EManageGravity
        {
            EMG_DisableGravity,
            EMG_EnableGravity,
            EMG_SwitchGravity
        }
        public enum ECounterAttackSwitch
        {
            CAS_Disabled,
            CAS_Enabled
        }
       
        public enum EButtonStage
        {
            BS_Released,
            BS_Pressed,
            BS_Hold
        }
        public enum EStaminaActionType
        {
            ESAT_Undefined,
            ESAT_LightAttack,
            ESAT_HeavyAttack,
            ESAT_SuperHeavyAttack,
            ESAT_Parry,
            ESAT_Counterattack,
            ESAT_Dodge,
            ESAT_Evade,
            ESAT_Swimming,
            ESAT_Sprint,
            ESAT_Jump,
            ESAT_UsableItem,
            ESAT_Ability,
            ESAT_FixedValue,
            ESAT_Roll,
            ESAT_LightSpecial,
            ESAT_HeavySpecial
        }
        public enum ESpeedType
        {
            EST_Undefined,
            EST_Stopped,
            EST_SlowWalk,
            EST_Walk,
            EST_Run,
            EST_FastRun,
            EST_Sprint
        }
        public enum EStatOwner
        {
            SO_NPC,
            SO_Target,
            SO_ActionTarget
        }
        public enum ETestSubject
        {
            ETS_Player,
            ETS_Owner
        }
        public enum ETargetName
        {
            TN_Me,
            TN_CombatTarget,
            TN_ActionTarget,
            TN_CustomTarget,
            TN_NamedTarget
        }
        public enum EMonsterTactic
        {
            EMT_None,
            EMT_FarSurround
        }
        public enum EOperator
        {
            EO_Equal,
            EO_NotEqual,
            EO_Less,
            EO_LessEqual,
            EO_Greater,
            EO_GreaterEqual
        }
        public enum ESpawnPositionPattern
        {
            ESPP_AroundTarget,
            ESPP_AroundSpawner,
            ESPP_AroundBoth
        }
        public enum ESpawnRotation
        {
            ESR_BackAtSpawner,
            ESR_TowardsSpawner,
            ESR_TowardsTarget,
            ESR_SameAsSpawner,
            ESR_OppositeOfSpawner
        }
        public enum EFlyingCheck
        {
            EFC_TakeOff,
            EFC_Landing
        }
        public enum EActionInfoType
        {
            EAIT_ApproachAttack,
            EAIT_ApproachAttackEnd,
            EAIT_Attack,
            EAIT_AttackEnd,
            EAIT_BecomeAwareAndCanAttack,
            EAIT_BecomeUnawareOrCannotAttack,
            EAIT_BeingWarnedStart,
            EAIT_BeingWarnedStop,
            EAIT_CanFindPath,
            EAIT_CannotFindPath
        }
        public enum EBossAction
        {
            EBA_Parry,
            EBA_Siphon,
            EBA_Dodge,
            EBA_StaminaRegen,
            EBA_PhaseChange
        }
        public enum EBossSpecialAttacks
        {
            EBSA_Lightbringer,
            EBSA_Meteorites,
            EBSA_IceSpikes,
            EBSA_BlinkCombo,
            EBSA_SpecialAttacks
        }
        public enum EEredinPhaseChangeAction
        {
            EEPCA_PreparePartOne,
            EEPCA_PartOne,
            EEPCA_PreparePartTwo,
            EEPCA_PartTwo,
            EEPCA_AdjustRotation
        }
        public enum ESpawnCondition
        {
            SC_Always,
            SC_PlayerInRange
        }
        public enum ENPCCollisionStance
        {
            NCS_InPlace,
            NCS_PushGentle,
            NCS_Push,
            NCS_PushHard
        }
        public enum ENPCBaseType
        {
            ENBT_Man,
            ENBT_Woman,
            ENBT_Dwarf
        }
        public enum EGuardState
        {
            GS_Idle,
            GS_Chase,
            GS_Retreat
        }
        public enum ENPCType
        {
            ENT_AdultMale,
            ENT_AdultFemale,
            ENT_ChildMale,
            ENT_ChildFemale
        }
        public enum EChosenTarget
        {
            ECT_CombatTarget,
            ECT_AlwaysPlayer,
            ECT_Self,
            ECT_SpecifiedTag
        }
        public enum ETeleportType
        {
            TT_ToPlayer,
            TT_ToTarget,
            TT_AwayFromTarget,
            TT_FromLastPosition,
            TT_Random,
            TT_ToSelf,
            TT_ToNode,
            TT_OnRightPlayerSide,
            TT_OnLeftPlayerSide
        }
        public enum ECameraBlendSpeedMode
        {
            ECBSM_Time,
            ECBSM_Distance,
            ECBSM_Height
        }
        public enum EMerchantMapPinType
        {
            EMMPT_Shopkeeper,
            EMMPT_Blacksmith,
            EMMPT_Armorer,
            EMMPT_BoatBuilder,
            EMMPT_Hairdresser,
            EMMPT_Herbalist,
            EMMPT_Alchemist,
            EMMPT_Innkeeper,
            EMMPT_Enchanter,
            EMMPT_DyeTrader,
            EMMPT_WineTrader,
            EMMPT_Cammerlengo
        }

        public enum EClimbProbeUsed
        {
            ECPU_None,
            ECPU_Top,
            ECPU_Bottom
        }
        public enum ESideSelected
        {
            SS_SelectedNone,
            SS_SelectedLeft,
            SS_SelectedRight,
            SS_SelectedCenter
        }
        public enum EPlayerCollisionStance
        {
            GCS_Idle,
            GCS_Walk,
            GCS_Run,
            GCS_Sprint,
            GCS_Combat
        }
        public enum EMovementCorrectionType
        {
            EMCT_None,
            EMCT_Collision,
            EMCT_Push,
            EMCT_Physics,
            EMCT_NavMesh,
            EMCT_Exploration,
            EMCT_Door,
            EMCT_Fall,
            EMCT_Size
        }
        public enum EGameplayContextInput
        {
            EGCI_Ignore,
            EGCI_Exploration,
            EGCI_JumpClimb,
            EGCI_Combat,
            EGCI_Swimming
        }
        public enum EExplorationStateType
        {
            EST_None,
            EST_Idle,
            EST_OnAir,
            EST_Swim,
            EST_Skate,
            EST_Critical,
            EST_Locked,
            EST_Unchanged
        }
        public enum EBehGraphConfirmationState
        {
            BGCS_None,
            BGCS_Waiting,
            BGCS_Confirmed,
            BGCS_NotConfirmed
        }
        public enum EAirCollisionSide
        {
            EACS_Left,
            EACS_Center,
            EACS_Right
        }
        public enum EClimbDistanceType
        {
            ECDT_Normal,
            ECDT_Close,
            ECDT_Far
        }
        public enum EClimbEndReady
        {
            ECR_NotReady,
            ECR_Walk,
            ECR_Run,
            ECR_Fall,
            ECR_Idle
        }
        public enum EOutsideCapsuleState
        {
            EOCS_Inactive,
            EOCS_Starting,
            EOCS_PerfectFollow,
            EOCS_Recover
        }
        public enum EPlayerIdleSubstate
        {
            PIS_None,
            PIS_Idle,
            PIS_Walk,
            PIS_Run,
            PIS_Sprint
        }
        public enum ExplorationInteractionType
        {
            EIT_Ladder,
            EIT_Boat,
            EIT_Ledge
        }
        public enum EJumpSubState
        {
            JSS_TakingOff,
            JSS_Flight,
            JSS_Inertial,
            JSS_PredictingLand
        }
        public enum ELandPredictionType
        {
            ELPT_FlatLand,
            ELPT_SlopedLand,
            ELPT_Water
        }
        public enum PrepareJumpSubState
        {
            PJSS_Start,
            PJSS_Loop,
            PJSS_End
        }
        public enum EPushSide
        {
            EPIS_Front,
            EPIS_Left,
            EPIS_Back,
            EPIS_Right
        }
        public enum ESlidingSubState
        {
            SSS_Entering,
            SSS_Sliding,
            SSS_HardSliding,
            SSS_Exiting,
            SSS_Exited
        }
        public enum ESlideCameraShakeState
        {
            SCSS_None,
            SCSS_Soft,
            SCSS_Hard
        }
        public enum EFallType
        {
            FT_Idle,
            FT_Walk,
            FT_Run,
            FT_Sprint
        }
        public enum ECollisionTrajecoryStatus
        {
            CTS_AllClear,
            CTS_LandLow,
            CTS_LandOK,
            CTS_LandHigh,
            CTS_LandBlocked
        }
        public enum ECollisionTrajecoryExplorationStatus
        {
            CTES_None,
            CTES_Jump,
            CTES_Explore
        }
        public enum ECollisionTrajectoryPart
        {
            ECTP_Start,
            ECTP_Up,
            ECTP_Peak,
            ECTP_Down,
            ECTP_Fall,
            ECTP_FallLow,
            ECTP_GroundClose,
            ECTP_GroundFar,
            ECTP_GroundFarAfter,
            ECTP_None
        }
        public enum ECollisionTrajectoryToWaterState
        {
            ECTTWS_NoWater,
            ECTTWS_ToWaterClose,
            ECTTWS_ToWaterFar
        }
        public enum EDoorMarkingState
        {
            EDMCT_Nothing,
            EDMCT_Considered,
            EDMCT_Selected
        }
        public enum AQMTN_EntityType
        {
            AQMTN_Actor,
            AQMTN_NonActor
        }
        public enum EAlchemyExceptions
        {
            EAE_NoException,
            EAE_MissingIngredient,
            EAE_NotEnoughIngredients,
            EAE_NoRecipe,
            EAE_CannotCookMore,
            EAE_CookNotAllowed
        }
        public enum EBirdType
        {
            Crow,
            Pigeon,
            Seagull,
            Sparrow
        }
        public enum EWhaleMovementPatern
        {
            EWMP_bySpawnPoint,
            EWMP_towardsPlayer,
            EWMP_awayFromPlayer
        }
        
        public enum ECraftingException
        {
            ECE_NoException,
            ECE_TooLowCraftsmanLevel,
            ECE_MissingIngredient,
            ECE_TooFewIngredients,
            ECE_WrongCraftsmanType,
            ECE_NotEnoughMoney,
            ECE_UnknownSchematic,
            ECE_CookNotAllowed
        }
        public enum EItemUpgradeException
        {
            EIUE_NoException,
            EIUE_NotEnoughGold,
            EIUE_MissingIngredient,
            EIUE_NotEnoughIngredient,
            EIUE_MissingRequiredUpgrades,
            EIUE_AlreadyPurchased,
            EIUE_ItemNotUpgradeable,
            EIUE_NoSuchUpgradeForItem
        }
        public enum EElevatorSwitchType
        {
            DownSwitch,
            UpSwitch
        }
        public enum EEffectInteract
        {
            EI_Undefined,
            EI_Deny,
            EI_Override,
            EI_Pass,
            EI_Cumulate
        }
        public enum ECriticalHandling
        {
            ECH_HandleNow,
            ECH_Postpone,
            ECH_Abort
        }
        public enum EEncounterMonitorCounterType
        {
            EMCT_KIlledByEntry,
            EMCT_SpawnedByEntry,
            EMCT_CurrentlySpawnedByEntry,
            EMCT_LostByEntry
        }
        public enum EFocusModeChooseEntityStrategy
        {
            FMCES_ChooseNearest,
            FMCES_ChooseMostIntense
        }
        public enum ETriggeredDamageType
        {
            ETDT_Roots,
            ETDT_Poison
        }
        public enum EIllusionDiscoveredOneliner
        {
            EIDO_PlayOnFirstDiscoveryInThisSession,
            EIDO_PlayOnFirstDiscovery,
            EIDO_PlayAlways,
            EIDO_DontPlay
        }
        public enum ENestType
        {
            EN_Drowner,
            EN_Draconid,
            EN_Endriaga,
            EN_Ghoul,
            EN_Harpy,
            EN_Nekker,
            EN_Rotfiend,
            EN_Siren,
            EN_Wyvern,
            EN_None,
            EN_BlackSpider,
            EN_Kikimora,
            EN_Archespore,
            EN_Scolopendromorph
        }
        public enum EShrineBuffs
        {
            ESB_Aard,
            ESB_Axii,
            ESB_Igni,
            ESB_Quen,
            ESB_Yrden
        }
        public enum EArmorType
        {
            EAT_Undefined,
            EAT_Light,
            EAT_Medium,
            EAT_Heavy
        }
        public enum EItemGroup
        {
            EIG_PLAYER,
            EIG_HORSE
        }
        public enum EInventoryFilterType
        {
            IFT_None,
            IFT_Weapons,
            IFT_Armors,
            IFT_AlchemyItems,
            IFT_Ingredients,
            IFT_QuestItems,
            IFT_Default,
            IFT_HorseItems,
            IFT_AllExceptHorseItem
        }
        public enum ECompareType
        {
            ECT_Incomparable,
            ECT_Compare
        }
        public enum ESpendablePointType
        {
            ESkillPoint,
            EExperiencePoint
        }
        public enum ESwitchState
        {
            SS_Undefined,
            SS_Off,
            SS_SwitchingOn,
            SS_On,
            SS_SwitchingOff
        }
        public enum EResetSwitchMode
        {
            RSM_Default,
            RSM_Current,
            RSM_True,
            RSM_False
        }
        public enum PhysicalSwitchAnimationType
        {
            PSAT_Undefined,
            PSAT_Lever,
            PSAT_Button
        }
        public enum EEncounterOperation
        {
            EO_Enable,
            EO_Disable,
            EO_Toggle
        }
        public enum EFactOperation
        {
            FO_AddFact,
            FO_RemoveFact
        }
        public enum ELogicalOperator
        {
            AND,
            OR
        }
        public enum EBoidClueState
        {
            BCS_Default,
            BCS_Above
        }
        public enum EMonsterCluesTypes
        {
            MCT_MonsterSize,
            MCT_MonsterSound,
            MCT_DamageMarks,
            MCT_VictimState,
            MCT_MonsterApperance,
            MCT_SkinFacture,
            MCT_MonsterMovement,
            MCT_MonsterBehaviour,
            MCT_MonsterAttitude,
            MCT_AttackTime,
            MCT_MonsterHideout
        }
        public enum EMonsterSize
        {
            MS_Human,
            MS_Giant,
            MS_SmallHuman,
            MS_BigHuman,
            MS_Child,
            MS_GiantSnake,
            MS_Dog,
            MS_Cart,
            MS_Horse
        }
        public enum EMonsterEmittedSound
        {
            MES_Growling,
            MES_Mumbling,
            MES_Hissing,
            MES_Roaring,
            MES_Shrieking,
            MES_Yelling,
            MES_Clattering,
            MES_Murmuring,
            MES_Sneering,
            MES_Silent
        }
        public enum EMonsterDamageMarks
        {
            DM_PoisonousBite,
            DM_Bruises,
            DM_FleshRips,
            DM_SharpBites,
            DM_BluntClaws,
            DM_BluntBites,
            DM_Claws,
            DM_Crippled,
            DM_Scaldings,
            DM_RazorSharpCuts,
            DM_BleachedHair,
            DM_Frozen,
            DM_BrokenBones,
            DM_PiercedWounds,
            DM_StrangleGrip,
            DM_BlueTongue,
            DM_StickyMucus,
            DM_Drained
        }
        public enum EMonsterVictimState
        {
            VS_PartiallyEaten,
            VS_Drained,
            VS_Drowned,
            VS_TornApart,
            VS_Swollen,
            VS_Hemorrhaged,
            VS_Beaten,
            VS_Paralyzed,
            VS_Buldgeoned,
            VS_Burned,
            VS_Suffocated
        }
        public enum EMonsterApperance
        {
            MAE_Muscular,
            MAE_GlowingEyes,
            MAE_Skinny,
            MAE_Stocky,
            MAE_Beautiful,
            MAE_Mandibles,
            MAE_SkinWings,
            MAE_Trinkets,
            MAE_Pieces_of_Armor,
            MAE_PowerfulJaws,
            MAE_Massive,
            MAE_Terrifying,
            MAE_Tentacles,
            MAE_BigMandibles,
            MAE_Hungering,
            MAE_LongTail,
            MAE_Owl_like
        }
        public enum EMonsterSkinFacture
        {
            MSF_Callous,
            MSF_VeinySmooth,
            MSF_DirtyDecomposed,
            MSF_PaleOily,
            MSF_AlabasterPale,
            MSF_ScorchedEarth_like,
            MSF_Feathers,
            MSF_RuggedSkin,
            MSF_ShellSegments,
            MSF_Ethereal,
            MSF_Scales,
            MSF_Fur
        }
        public enum EMonsterMovement
        {
            MM_FastWalk,
            MM_VeryFastRun,
            MM_SluggishWalk,
            MM_LightningFastRun,
            MM_Walk,
            MM_Flight,
            MM_Swim,
            MM_Crawl,
            MM_Float,
            MM_Jump,
            MM_Roll,
            MM_NoMovement
        }
        public enum EMonsterBehaviour
        {
            MB_Lurking,
            MB_Ambushing,
            MB_Attracting,
            MB_Wandering,
            MB_Stalking
        }
        public enum EMonsterAttitude
        {
            MA_Aggressive,
            MA_Cunning,
            MA_Careful,
            MA_Vicious
        }
        public enum EMonsterAttackTime
        {
            AT_AllDay,
            AT_Day,
            AT_AfterDark,
            AT_Night
        }
        public enum EMonsterHideout
        {
            MH_Crypt,
            MH_Cave,
            MH_UnderwaterCave,
            MH_MountainCave,
            MH_MountainCliff,
            MH_RuinedBuilding,
            MH_Forest,
            MH_Underground,
            MH_Catacombs,
            MH_Ravine,
            MH_Basement,
            MH_Swamp,
            MH_Glade
        }
        public enum EPlayerCombatStance
        {
            PCS_Normal,
            PCS_AlertNear,
            PCS_AlertFar,
            PCS_Guarded
        }
        public enum EPlayerExplorationAction
        {
            PEA_None,
            PEA_SlotAnimation,
            PEA_Meditation,
            PEA_ExamineGround,
            PEA_ExamineEyeLevel,
            PEA_SmellHigh,
            PEA_SmellMid,
            PEA_SmellLow,
            PEA_InspectHigh,
            PEA_InspectMid,
            PEA_InspectLow,
            PEA_IgniLight,
            PEA_AardLight,
            PEA_SetBomb,
            PEA_PourPotion,
            PEA_DispelIllusion
        }
        public enum EFocusClueAttributeAction
        {
            FCAA_ForceSet,
            FCAA_SetToTrue,
            FCAA_SetToFalse,
            FCAA_Switch
        }
        public enum EFocusClueMedallionReaction
        {
            EFCMR_FirstDiscoveryInThisSession,
            EFCMR_FirstDiscovery,
            EFCMR_Always,
            EFCMR_Never
        }
        public enum EPlayerVoicesetType
        {
            EPVT_MonsterNestDrowners,
            EPVT_MiscFreshTracks,
            EPVT_MiscFollowingTracks,
            EPVT_MiscBloodTrail,
            EPVT_MiscInvestigateArea,
            EPVT_MiscHideoutFound,
            EPVT_MiscFindOtherWay,
            EPVT_MiscAnotherVictim,
            EPVT_MiscUnevenFight,
            EPVT_MiscALotOfBlood,
            EPVT_MiscGenericRemarks,
            EPVT_About_trophy,
            EPVT_FasterHorse,
            EPVT_None
        }
        public enum EMonsterClueAnim
        {
            MCA_None,
            MCA_SirenTreeKill,
            MCA_WarriorDeath_01_quest,
            MCA_WarriorDeath_02_quest,
            MCA_WarriorDeath_03_quest,
            MCA_WarriorDeath_quick_01_quest,
            MCA_WarriorDeath_quick_02_quest,
            MCA_WarriorDeath_quick_03_quest,
            MCA_WarriorDeath_quick_04_quest,
            MCA_WarriorDeath_quick_05_quest,
            MCA_WarriorDeath_quick_06_quest,
            MCA_WarriorDeath_quick_07_quest,
            MCA_InjuredLeg_quest,
            MCA_WomanWalking_quest,
            MCA_ManWalking_quest,
            MCA_Avallach_kill_Nithral_quest,
            MCA_Nithral_pushed_back_quest,
            MCA_Nithral_attack_quest,
            MCA_Woman_being_hit_quest,
            MCA_Avallach_surrounded_quest,
            MCA_Ciri_surrounded_quest,
            MCA_Wildhunt1_surrounded_quest,
            MCA_Wildhunt2_surrounded_quest,
            MCA_Wildhunt3_surrounded_quest,
            MCA_Wildhunt4_surrounded_quest,
            MCA_Wildhunt5_surrounded_quest,
            MCA_Wildhunt6_surrounded_quest,
            MCA_q106_step_back,
            MCA_q106_standing_leaning,
            MCA_q106_fall_kneel,
            MCA_q106_devastated_attack,
            MCA_q106_brush_floor,
            MCA_q106_crawl
        }
        public enum EReputationLevel
        {
            RL_Hated,
            RL_Disliked,
            RL_Neutral,
            RL_Liked,
            RL_Respectable
        }
        public enum EFactionName
        {
            FN_NoMansLandPoor,
            FN_NovigradNobles,
            FN_SkelligeUndvik,
            FN_MaxEnum
        }
        public enum EUserDialogButtons
        {
            UDB_Ok,
            UDB_OkCancel,
            UDB_YesNo,
            UDB_None
        }
        public enum EUniqueMessageIDs
        {
            UMID_QuestBlockMessage
        }
        public enum ELockedControlScheme
        {
            LCS_None,
            LCS_Gamepad,
            LCS_KbMouse
        }
        public enum EGamepadType
        {
            GT_Xbox,
            GT_PS4,
            GT_Steam
        }
        public enum EQuantityTransferFunction
        {
            QTF_Sell,
            QTF_Buy,
            QTF_Give,
            QTF_Take,
            QTF_Drop,
            QTF_Dismantle
        }
        public enum EFloatingValueType
        {
            EFVT_None,
            EFVT_Critical,
            EFVT_Block,
            EFVT_InstantDeath,
            EFVT_DoT,
            EFVT_Heal,
            EFVT_Buff
        }
        public enum HudItemInfoBinding
        {
            HudItemInfoBinding_item1,
            HudItemInfoBinding_potion1,
            HudItemInfoBinding_potion2
        }
        public enum InGameMenuActionType
        {
            IGMActionType_CommonMenu,
            IGMActionType_Close,
            IGMActionType_MenuHolder,
            IGMActionType_MenuLastHolder,
            IGMActionType_Load,
            IGMActionType_Save,
            IGMActionType_Quit,
            IGMActionType_Preset,
            IGMActionType_Toggle,
            IGMActionType_List,
            IGMActionType_Slider,
            IGMActionType_LoadLastSave,
            IGMActionType_Tutorials,
            IGMActionType_Credits,
            IGMActionType_Help,
            IGMActionType_Controls,
            IGMActionType_ControllerHelp,
            IGMActionType_NewGame,
            IGMActionType_CloseGame,
            IGMActionType_UIRescale,
            IGMActionType_Gamma,
            IGMActionType_DebugStartQuest,
            IGMActionType_Gwint,
            IGMActionType_ImportSave,
            IGMActionType_KeyBinds,
            IGMActionType_Back,
            IGMActionType_NewGamePlus
        }
        public enum CharacterMenuTabIndexes
        {
            CharacterMenuTab_Sword,
            CharacterMenuTab_Signs,
            CharacterMenuTab_Alchemy,
            CharacterMenuTab_Perks,
            CharacterMenuTab_Mutagens
        }
        public enum EInventoryMenuState
        {
            IMS_Player,
            IMS_Shop,
            IMS_Container,
            IMS_HorseInventory
        }
        public enum InventoryMenuTabIndexes
        {
            InventoryMenuTab_Weapons,
            InventoryMenuTab_Potions,
            InventoryMenuTab_Ingredients,
            InventoryMenuTab_QuestItems,
            InventoryMenuTab_Default
        }
        public enum ENotificationType
        {
            NT_Info,
            NT_Warning
        }
        public enum PreparationTrackType
        {
            PrepTrackType_None,
            PrepTrackType_Journal,
            PrepTrackType_Environment
        }
        public enum PreparationMenuTabIndexes
        {
            PreparationMenuTab_Bombs,
            PreparationMenuTab_Potion,
            PreparationMenuTab_Oils,
            PreparationMenuTab_Mutagens
        }
        public enum EUserMessageProgressType
        {
            UMPT_None,
            UMPT_Content,
            UMPT_GraphicsRefresh
        }
        public enum EPreporationItemType
        {
            PIT_Undefined,
            PIT_Bomb,
            PIT_Potion,
            PIT_Oil,
            PIT_Mutagen
        }
        public enum EBackgroundNPCWork_Paired
        {
            EBNWP_None,
            EBNWP_DrinkingOpposite,
            EBNWP_Saw,
            EBNWP_Q106KilledbyMorowa
        }
        public enum EBackgroundNPCWomanWork
        {
            EBNWW_None,
            EBNWW_Listening,
            EBNWW_Sweeping_floor,
            EBNWW_Washing_cloth,
            EBNWW_Brushing_floor_man,
            EBNWW_Leaning_against_fence,
            EBNWW_Sex
        }
        public enum EConverserType
        {
            CT_General,
            CT_Nobleman,
            CT_Guard,
            CT_Mage,
            CT_Bandit,
            CT_Scoiatael,
            CT_Peasant,
            CT_Poor,
            CT_Child
        }
        public enum EDeathType
        {
            EDT_Default,
            EDT_IgniDeath,
            EDT_AardDeath,
            EDT_Agony
        }
        public enum EFinisherDeathType
        {
            EFDT_None,
            EFDT_Head,
            EFDT_Torso,
            EFDT_ArmLeft,
            EFDT_ArmRight,
            EFDT_LegLeft,
            EFDT_LegRight
        }
        public enum EActionFail
        {
            EAF_ActionFail1,
            EAF_ActionFail2,
            EAF_ActionFail3,
            EAF_ActionFail4,
            EAF_ActionFail5
        }
        public enum ETauntType
        {
            TT_Taunt1,
            TT_Taunt2,
            TT_Taunt3,
            TT_Taunt4,
            TT_Taunt5,
            TT_Taunt6,
            TT_Taunt7,
            TT_Taunt8
        }
        public enum EExplorationMode
        {
            EM_None,
            EM_Ground,
            EM_Air,
            EM_Water
        }
        public enum EAgonyType
        {
            AT_ThroatCut,
            AT_Knockdown
        }
        public enum EHitReactionDirection
        {
            EHRD_Forward,
            EHRD_Back
        }
        public enum EHitReactionSide
        {
            EHRS_None,
            EHRS_Left,
            EHRS_Right
        }
        public enum EDetailedHitType
        {
            EDHT_None,
            EDHT_Straight,
            EDHT_RightLeft,
            EDHT_LeftRight
        }
        public enum EAttackType
        {
            EAT_Attack1,
            EAT_Attack2,
            EAT_Attack3,
            EAT_Attack4,
            EAT_Attack5,
            EAT_Attack6,
            EAT_Attack7,
            EAT_Attack8,
            EAT_Attack9,
            EAT_Attack10,
            EAT_Attack11,
            EAT_Attack12,
            EAT_Attack13,
            EAT_Attack14,
            EAT_Attack15,
            EAT_Attack16,
            EAT_Attack17,
            EAT_Attack18,
            EAT_Attack19,
            EAT_Attack20,
            EAT_None
        }
        public enum EInputActionBlock
        {
            EIAB_Signs,
            EIAB_DrawWeapon,
            EIAB_OpenInventory,
            EIAB_RadialMenu,
            EIAB_CallHorse,
            EIAB_FastTravel,
            EIAB_Movement,
            EIAB_HighlightObjective,
            EIAB_Fists,
            EIAB_OpenPreparation,
            EIAB_Jump,
            EIAB_Roll,
            EIAB_InteractionAction,
            EIAB_ThrowBomb,
            EIAB_RunAndSprint,
            EIAB_OpenMap,
            EIAB_OpenCharacterPanel,
            EIAB_OpenJournal,
            EIAB_OpenAlchemy,
            EIAB_ExplorationFocus,
            EIAB_Dive,
            EIAB_Interactions,
            EIAB_DismountVehicle,
            EIAB_Dodge,
            EIAB_SwordAttack,
            EIAB_Parry,
            EIAB_Sprint,
            EIAB_Explorations,
            EIAB_Undefined,
            EIAB_Counter,
            EIAB_LightAttacks,
            EIAB_HeavyAttacks,
            EIAB_QuickSlots,
            EIAB_Crossbow,
            EIAB_UsableItem,
            EIAB_OpenFastMenu,
            EIAB_OpenGlossary,
            EIAB_HardLock,
            EIAB_Climb,
            EIAB_Slide,
            EIAB_OpenGwint,
            EIAB_MeditationWaiting,
            EIAB_MountVehicle,
            EIAB_InteractionContainers,
            EIAB_SpecialAttackLight,
            EIAB_SpecialAttackHeavy,
            EIAB_OpenMeditation
        }
        public enum EChargeAttackType
        {
            ECAT_Knockdown,
            ECAT_Stagger
        }
        public enum EDodgeType
        {
            EDT_Attack_Light,
            EDT_Attack_Heavy,
            EDT_Aard,
            EDT_Igni,
            EDT_Bomb,
            EDT_Projectile,
            EDT_Fear,
            EDT_Undefined
        }
        public enum EDodgeDirection
        {
            EDD_Back,
            EDD_Left,
            EDD_Right,
            EDD_Forward
        }
        public enum ETurnDirection
        {
            ETD_Left,
            ETD_Right
        }
        public enum ETargetDirection
        {
            ETD_Direction_0,
            ETD_Direction_45,
            ETD_Direction_90,
            ETD_Direction_135,
            ETD_Direction_180,
            ETD_Direction_m180,
            ETD_Direction_m135,
            ETD_Direction_m90,
            ETD_Direction_m45
        }
        public enum ENpcPose
        {
            ENP_LeftFootFront,
            ENP_RightFootFront
        }
        public enum EFlightStance
        {
            EFS_VerticalTurns,
            EFS_HorizontalTurns,
            EFS_Glide
        }
        public enum ENPCRightItemType
        {
            RIT_None,
            RIT_Axe,
            RIT_Halberd,
            RIT_Sword,
            RIT_Torch,
            RIT_Crossbow
        }
        public enum ENPCLeftItemType
        {
            LIT_None,
            LIT_Torch,
            LIT_Shield,
            LIT_Bow
        }
        public enum EWeaponSubType1Handed
        {
            EWST1H_Sword,
            EWST1H_Axe,
            EWST1H_Blunt
        }
        public enum EWeaponSubType2Handed
        {
            EWST2H_Hammer,
            EWST2H_Axe,
            EWST2H_Halberd,
            EWST2H_Spear,
            EWST2H_Staff
        }
        public enum EWeaponSubTypeRanged
        {
            EWSTR_Bow,
            EWSTR_Crossbow
        }
        public enum ENpcWeapons
        {
            ENW_1h_Sword,
            ENW_1h_Axe,
            ENW_1h_Mace,
            ENW_Shield
        }
        public enum ENpcFightingStyles
        {
            ENFS_Sword,
            ENFS_Axe,
            ENFS_Mounted,
            ENFS_Mace,
            ENFS_SwordAndShield,
            ENFS_AxeAndShield,
            ENFS_MaceAndShield
        }
        public enum EPlayerDeathType
        {
            PDT_Normal,
            PDT_Fall,
            PDT_KnockBack
        }
        public enum EAimType
        {
            AT_Bolt,
            AT_Bomb
        }
        public enum EPlayerMode
        {
            PM_Normal,
            PM_Safe,
            PM_Combat
        }
        public enum EForceCombatModeReason
        {
            FCMR_Default,
            FCMR_Trigger
        }
        public enum EGeneralEnum
        {
            GE_0,
            GE_1,
            GE_2,
            GE_3,
            GE_4,
            GE_5,
            GE_6,
            GE_7,
            GE_8,
            GE_9,
            GE_10
        }
        public enum EPlayerBoatMountFacing
        {
            EPBMD_NotSet,
            EPBMD_Front,
            EPBMD_Back,
            EPBMD_Left,
            EPBMD_Right
        }
        public enum EPlayerAttackType
        {
            PAT_Light,
            PAT_Heavy
        }
        public enum EPlayerCommentary
        {
            PC_MedalionWarning,
            PC_MonsterReaction,
            PC_NCFMClueCommentTrace,
            PC_NCFMClueCommentRemainings,
            PC_NCFMClueSoundDetected,
            PC_ColdWaterComment
        }
        public enum EPlayerWeapon
        {
            PW_None,
            PW_Steel,
            PW_Silver,
            PW_Fists
        }
        public enum EPlayerRangedWeapon
        {
            PRW_None,
            PRW_Crossbow
        }

    }
}
