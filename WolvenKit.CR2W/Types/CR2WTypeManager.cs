using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WolvenKit.CR2W.Types
{
    public class CR2WTypeDefinition
    {
        public string name;
        public CVariable var;

        public CR2WTypeDefinition(string name, CVariable var)
        {
            this.name = name;
            this.var = var;
        }
    }

    public class CR2WTypeManager
    {
        private static CR2WTypeManager instance;
        private readonly Dictionary<string, CR2WTypeDefinition> types = new Dictionary<string, CR2WTypeDefinition>();

        public CR2WTypeManager()
        {
            Register("CName", new CName(null));

            Register("String", new CString(null));
            Register("StringAnsi", new CStringAnsi(null));

            Register("Bool", new CBool(null));

            Register("Int8", new CInt8(null));
            Register("Int16", new CInt16(null));
            Register("Int32", new CInt32(null));
            Register("Int64", new CInt64(null));

            Register("Uint8", new CUInt8(null));
            Register("Uint16", new CUInt16(null));
            Register("Uint32", new CUInt32(null));
            Register("Uint64", new CUInt64(null));

            Register("Float", new CFloat(null));

            Register("EngineTransform", new CEngineTransform(null));
            Register("EngineQsTransform", new CEngineQsTransform(null));

            Register("CGUID", new CGUID(null));
            Register("Vector", new CVector(null));

            Register("ptr", new CPtr(null));
            Register("handle", new CHandle(null));
            Register("soft", new CSoft(null));

            Register("TagList", new CTagList(null));

            Register("Flags", new CFlags(null));
            Register("EDrawableFlags", new CFlags(null));
            Register("ETriggerChannel", new CFlags(null));
            Register("ELightChannel", new CFlags(null));
            Register("EEntityStaticFlags", new CFlags(null));

            Register("LocalizedString", new CLocalizedString(null));


            Register("CDateTime", new CDateTime(null));

            Register("DeferredDataBuffer", new CInt16(null));

            Register("CVariant", new CVariant(null));

            Register("SAppearanceAttachment", new SAppearanceAttachment(null));

            Register("CStorySceneSection", new CStorySceneSection(null));
            Register("CStorySceneCutsceneSection", new CStorySceneSection(null));
            Register("CStorySceneVideoSection", new CStorySceneSection(null));

            Register("CQuestScriptBlock", new CQuestScriptBlock(null));

            Register("CStorySceneScript", new CStorySceneScript(null));

            Register("CMaterialInstance", new CMaterialInstance(null));

            Register("CClipMapCookedData", new CBytes(null));
            Register("SharedDataBuffer", new CByteArray(null));

            Register("CSwfResource", new CSwfResource(null));
            Register("CBitmapTexture", new CBitmapTexture(null));

            Register("Color", new CColor(null));

            Register("CEntity", new CEntity(null));
            Register("CMeshComponent", new CMeshComponent(null));

            Register("SMeshTypeResourceLODLevel", new CFloat(null));

            Register("CMaterialGraph", new CMaterialGraph(null));
            Register("CMaterialGraphParameter", new CMaterialGraphParameter(null));

            Register("CSkeletalAnimationSetEntry", new CSkeletalAnimationSetEntry(null));


            var vectors = new[]
            {
                "CStorySceneRandomizer",
                "ApertureDofParams", "Box", "EulerAngles", "Vector2",
                "CEventGeneratorCameraParams", "CGenericGrassMask", "CGlobalLightingTrajectory",
                "CWorldShadowConfig", "SAnimationBufferBitwiseCompressedData",
                "SAnimationBufferBitwiseCompressionSettings", "SAttachmentReplacements",
                "SDismembermentWoundDecal", "SDynamicDecalMaterialInfo", "SFoliageLODSetting",
                "SFlareParameters",
                "SGlobalSpeedTreeParameters", "SLensFlareGroupsParameters", "SLensFlareParameters",
                "SLightFlickering", "SMeshCookedData", "SMultiCurve", "SSimpleCurve",
                "SWorldEnvironmentParameters", "SWorldMotionBlurSettings", "SWorldRenderSettings",
                "SWorldSkyboxParameters", "CEntityAppearance", "SBlockDesc", "SCachedConnections",
                "QuestScriptParam", "StorySceneCameraDefinition", "CStorySceneVoicetagMapping",
                "SStorySceneCameraLightMod", "SCurveData", "SCurveDataEntry", "CStorySceneSectionVariantElementInfo",
                "CStorySceneEventCameraInterpolationKey", "SItemNameProperty", "CColorShift", "SAbilityAttributeValue",
                "CAreaEnvironmentParams", "CEnvGameplayEffectsParameters", "CEnvWindParameters",
                "CEnvFinalColorBalanceParameters",
                "CEnvSharpenParameters",
                "CEnvNVSSAOParameters",
                "CEnvMSSSAOParameters",
                "CEnvGlobalLightParameters",
                "CEnvSpeedTreeParameters",
                "CEnvToneMappingParameters",
                "CEnvBloomNewParameters",
                "CEnvGlobalFogParameters",
                "CEnvGlobalSkyParameters",
                "CEnvDepthOfFieldParameters",
                "CEnvColorModTransparencyParameters",
                "CEnvShadowsParameters",
                "CEnvWaterParameters",
                "CEnvColorGroupsParameters",
                "CEnvFlareColorGroupsParameters",
                "CEnvSunAndMoonParameters",
                "CEnvMotionBlurParameters",
                "CEnvCameraLightsSetupParameters",
                "CEnvDialogLightParameters",
                "CEnvCameraLightParameters",
                "CEnvFlareColorParameters",
                "CEnvParametricBalanceParameters",
                "CEnvAmbientProbesGenParameters",
                "CEnvReflectionProbesGenParameters",
                "CEnvSpeedTreeRandomColorParameters",
                "CEnvToneMappingCurveParameters",
                "CEnvDistanceRangeParameters",
                "CSStoryPhaseNames",
                "CSLayerName",
                "CEnvironmentDefinition",

                //"CMaterialGraph",
                "CMaterialParameterScalar",
                "CMaterialParameterTexture",
                "CMaterialParameterColor",
                "SFurPhysicalMaterials",
                "SFurGraphicalMaterials",
                "SFurLevelOfDetail",
                "SFurSimulation",
                "SFurVolume",
                "SFurStrandWidth",
                "SFurStiffness",
                "SFurClumping",
                "SFurWaveness",
                "SFurColor",
                "SFurDiffuse",
                "SFurSpecular",
                "SFurGlint",
                "SFurShadow",
                "SFurCulling",
                "SFurDistanceLOD",
                "SFurDetailLOD",
                "SWorldDescription",
                "SMapPinConfig",
                "CWitcherGameResource",
                "SMapPinType",
                "GameTimeWrapper",
                "GameTime",
                "CQuest",
                "CQuestGraph",
                "CQuestPhaseBlock",
                "CQuestLayersHiderBlock",
                "CQuestPhaseOutputBlock",
                "CQuestPhaseInputBlock",
                "CQuestPauseConditionBlock",
                "CQuestRealtimeDelayCondition",
                "CDescriptionGraphBlock",
                "CQuestFactsDBChangingBlock",
                "CQuestAndBlock",
                "CCommentGraphBlock",
                "CQuestConditionBlock",
                "CQuestFactsDBCondition",
                "CQuestManageFastTravelBlock",
                "CQuestTimeManagementBlock",
                "SItem",
                "CQuestTagsPresenceCondition",
                "CSetTimeFunction",
                "CQuestStartBlock",
                "CJournalBlock",
                "CJournalPath",
                "CQuestPhase",
                "CQuestChangeWorldBlock",
                "CPauseTimeFunction",
                "CParticleSystem",
                "SParticleEmitterLODLevel",
                "EmitterDurationSettings",
                "CParticleDrawerBillboard",
                "CEvaluatorFloatConst",
                "CStoryScene",
                "CStorySceneInput",
                "CStorySceneEventLightProperties",
                "CStorySceneEventCameraLight",
                "CStorySceneOutput",
                "CStorySceneSectionVariant",
                "CStorySceneCutscenePlayer",
                "CStorySceneComment",
                "CStorySceneLine",
                "CStorySceneEventInfo",
                "CStorySceneVideoElement",
                "CStorySceneActor",
                "CStorySceneLight",
                "CStorySceneEventCustomCameraInstance",
                "CStorySceneEventLookAt",
                "CStorySceneEventMimicsAnim",
                "CStorySceneEventCameraAnim",
                "CStorySceneEventOverridePlacement",
                "CStorySceneEventCameraInterpolation",
                "CStorySceneChoice",
                "CStorySceneChoiceLine",
                "CStorySceneEventChangePose",
                "CStorySceneEventCustomCamera",
                "CStorySceneEventAnimation",
                "CStorySceneEventLookAtDuration",
                "CStorySceneEventMimics",
                "SStorySceneSpotLightProperties",
                "CStorySceneEventAdditiveAnimation",
                "CStorySceneResetClothAndDanglesEvent",
                "CStorySceneEventFade",
                "CStoryScenePauseElement",
                "CStorySceneFlowCondition",
                "CStorySceneLinkElement",
                "CStorySceneEventPoseKey",
                "SSSBoneTransform",
                "CStorySceneEventVisibility",
                "CExitStorySceneChoiceAction",
                "CStorySceneDialogsetInstance",
                "CStorySceneDialogsetSlot",
                "CStorySceneEventModifyEnv",
                "SStorySceneAttachmentInfo",
                "CStorySceneEventChangeActorGameState",
                "CStorySceneEventLightPropertiesInterpolation",
                "CStorySceneEventLightPropertiesInterpolationKey",
                "CStorySceneEventScenePropPlacement",
                "CStoryScenePropEffectEvent",
                "CStorySceneEventSound",
                "CStorySceneProp",
                "CStorySceneEventStartBlendToGameplayCamera",
                "CStorySceneEventPlacementInterpolation",
                "CStorySceneEventPlacementInterpolationKey",
                "CStorySceneEventAttachPropToSlot",
                "CStorySceneActorEffectEvent",
                "CStorySceneEventHideScabbard",
                "CFactsDBChoiceMemo",
                "CStorySceneActorEffectEventDuration",
                "CStorySceneEventReward",
                "W3QuestCond_chosenLanguage",
                "CStorySceneAddFactEvent",
                "Bezier2dHandle",
                "CStorySceneEventWorldEntityEffect",
                "CStorySceneDanglesShakeEvent",
                "CStorySceneEventEquipItem",
                "CStorySceneEventEnhancedCameraBlend",
                "CStorySceneEventDialogLine",
                "CStorySceneEventOpenDoor",
                "CStorySceneEventExitActor",
                "CStorySceneLocaleVariantMapping",
                "CQuestCameraFocusCondition",
                "CAxiiStorySceneChoiceAction",
                "CQuestActorCondition",
                "CQCHasItem",
                "CPayStorySceneChoiceAction",
                "CQuestLogicOperationCondition",
                "CStorySceneEventPropPlacementInterpolation",
                "CStorySceneEventPropPlacementInterpolationKey",
                "CStorySceneFlowSwitch",
                "CStorySceneFlowSwitchCase",
                "W3QuestCond_IsItemQuantityMet",
                "CGameCardsChoiceAction",
                "CShopStorySceneChoiceAction",
                "CStorySceneLinkHub",
                "CAuctionSceneChoiceAction",
                "CStorySceneEventVideoOverlay",
                "CStorySceneEventCameraLightInterpolation",
                "CStorySceneEventCameraLightInterpolationKey",
                "SStorySceneLightDimmerProperties",
                "CPayFactBasedStorySceneChoiceAction",
                "CMonsterContractChoiceAction",
                "W3QuestCond_IsItemEquipped",
                "CStorySceneEventOverrideAnimation",
                "CStorySceneQuestChoiceLine",
                "CEnvPaintEffectParameters",
                "CQuestContentActivatorBlock",
                "CQuestSceneBlock",
                "CQuestFactsDBExCondition",
                "SItemExt",
                "CFurMeshResource",
                "Matrix",
                "SFurVisualizers",
                "CDLCDefinition",
                "CR4QuestDLCMounter",
                "CR4RewardsDLCMounter",
                "CR4JournalDLCMounter",
                "CR4AttitudesDLCMounter",
                "CR4DefinitionsDLCMounter",
                "CR4DefinitionsEntitieTemplatesDLCMounter",
                "CR4SceneAnimationsDLCMounter",
                "CR4EntityTemplateParamDLCMounter",
                "CAnimAnimsetsParam",
                "CR4ResourceDefinitionsDLCMounter",
                "CR4AnimationsCategoriesDLCMounter",
                "CR4ActionPointCategoriesDLCMounter",
                "CR4ScaleformContentDLCMounter",
                "CR4EntityExternalAppearanceDLCMounter",
                "CR4EntityExternalAppearanceDLC",
                "CR4DefinitionsNGPlusDLCMounter",
                "CR4JournalEntriesDLCMounter",
                "CR4MappinsDLCMounter",
                "CR4VideoDLCMounter",
                "CSaveFileDLCMounter",
                "SStreamedAttachment",
                "EntitySlot",
                "CSkeletalAnimationSet",
                "CExtAnimDurationEvent",
                "CExtAnimSoundEvent",
                "CExtAnimFootstepEvent",
                "CEASEnumEvent",
                "SEnumVariant",
                "CPreAttackEvent",
                "CExtAnimEvent",
                "CLineMotionExtraction2",
                "CAnimationBufferBitwiseCompressed",
                "SAnimationBufferBitwiseCompressedBoneTrack",
                "CExtAnimEffectEvent",
                "CSkeletalAnimation",
                "CPreAttackEventData",
                "CExtAnimItemEffectEvent",
                "CExtAnimItemSyncEvent",
                "CExtAnimMaterialBasedFxEvent",
                "CExtAnimRaiseEventEvent",
                "CExtAnimItemSyncDurationEvent",
                "CExtAnimAttackEvent",
                "CExtAnimLocationAdjustmentEvent",
                "CExtAnimOnSlopeEvent"
            };

            foreach (string t in vectors)
            {
                Register(t, new CVector(null));
            }

            var cnames = new[]
            {
                "EActorImmortalityMode", "EAIAttitude", "EAreaName", "ECameraPlane", "ECompareFunc",
                "ECompareOp", "ECurveBaseType", "ECurveRelativeMode", "ECurveType", "ECurveValueType",
                "EDoorQuestState", "EFocusModeVisibility",
                "EEnvColorGroup",
                "EInteractionPriority", "EPhantomShape", "EFocusClueAttributeAction",
                "ELayerBuildTag", "ELayerMergedContent", "ELayerType",
                "ELogicOperation", "EMeshVertexType",
                "EShowFlags", "eQuestType", "EQueryFact",
                "ERenderDynamicDecalProjection",
                "EStorySceneOutputAction", "ETextureCompression",
                "SAnimationBufferBitwiseCompressionPreset",
                "SAnimationBufferOrientationCompressionMethod",
                "EEffectType", "EMoveType", "ESkeletonType", "EBreastPreset",
                "EInterpolationEasingStyle", "EDialogLookAtType", "EDialogResetClothAndDanglesType", "ELookAtLevel",
                "EGwintDifficultyMode", "EGwintAggressionMode", "EStorySceneAnimationType", "EGeraltPath",
                "EDrawWeaponQuestType",
                "EQueryFightMode", "ETopLevelAIPriorities", "ESoundEventSaveBehavior", "ECharacterDefenseStats",
                "ESimpleCurveType",
                "EBehaviorGraph", "EQuestNPCStates", "EDismountType", "ERenderingSortGroup", "ERenderingBlendMode",
                "ESceneEventLightColorSource",
                "ELightType",
                "ELightShadowCastingMode",
                "EFarPlaneDistance",
                "ECheckedLanguage",
                "ELanguageCheckType",
                "EInterpolationMethod",
                "EDimmerType",
                "EInputActionBlock",
                "EUsableItemType",
                "SAnimationBufferStreamingOption",
                "EItemLatentAction",
                "ESkeletalAnimationType",
                "EItemEffectAction"
            };


            for (var i = 0; i < cnames.Length; i++)
            {
                Register(cnames[i], new CName(null));
            }
        }

        public List<string> AvailableTypes => types.Keys.ToList();

        public static CR2WTypeManager Get()
        {
            return instance ?? (instance = new CR2WTypeManager());
        }

        public void Register(string name, CVariable var)
        {
            types.Add(name, new CR2WTypeDefinition(name, var));
        }

        public CVariable GetByName(string name, string varname, CR2WFile cr2w, bool readUnknownAsBytes = true)
        {
            var fullname = name;
            var reg = new Regex(@"^(\w+):(.+)$");
            var match = reg.Match(name);

            if (match.Success)
            {
                name = match.Groups[1].Value;
            }

            var regFixedSizeArray = new Regex(@"^\[(\d+)\](.+)$");
            var matchFixedSizeArray = regFixedSizeArray.Match(name);

            if (matchFixedSizeArray.Success)
            {
                return new CArray(fullname, matchFixedSizeArray.Groups[2].Value, true, cr2w);
            }

            if (name == "array")
            {
                var regArrayType = new Regex(@"(\d+),(\d+),(.+)");
                var matchArrayType = regArrayType.Match(fullname);
                if (matchArrayType.Success)
                {
                    // byte arrays, these can be huge, using ordinary arrays is just too slow.
                    if (matchArrayType.Groups[3].Value == "Uint8" || matchArrayType.Groups[3].Value == "Int8")
                    {
                        return new CByteArray(cr2w);
                    }
                    return new CArray(fullname, matchArrayType.Groups[3].Value, false, cr2w);
                }
                return new CArray(fullname, cr2w);
            }
            if (types.ContainsKey(name))
            {
                return types[name].var.Create(cr2w);
            }
            if (!cr2w.UnknownTypes.Contains(fullname))
                cr2w.UnknownTypes.Add(fullname);

            // Unknown type, just interpret as bytes
            if (readUnknownAsBytes)
            {
                return new CBytes(cr2w);
            }
            return null;
        }
    }
}