using System;
using System.Collections.Generic;
using System.Text;
using FastMember;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Reflection;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_Simulation : CVariable
    {
        public animDangleConstraint_Simulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class CResource : CVariable
    {
        public CResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnInterruptionScenario : CVariable
    {
        [Ordinal(0)] [RED("id")] public scnInterruptionScenarioId Id { get; set; }
        [Ordinal(1)] [RED("name")] public CName Name { get; set; }
        [Ordinal(2)] [RED("interruptConditions")] public CHandle<scnIInterruptCondition> InterruptConditions { get; set; }
        [Ordinal(3)] [RED("returnConditions")] public CHandle<scnIReturnCondition> ReturnConditions { get; set; }
        public scnInterruptionScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimEvent : CVariable
    {
        public animAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimFeature : CVariable
    {
        public animAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class CComponent : CVariable
    {
        public CComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class CMeshMaterialEntry : CVariable
    {
        public CMeshMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class IMaterial : CVariable
    {
        public IMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class ISerializable : CVariable
    {
        public ISerializable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class IEvaluatorFloat : CVariable
    {
        public IEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class FeatureFlagsMask : CVariable
    {
        [Ordinal(0)] [RED("flags")] public CUInt64 Flags { get; set; }
        public FeatureFlagsMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class PSODescDepthStencilModeDesc : CVariable
    {
        [Ordinal(0)] [RED("depthTestEnable")] public CBool DepthTestEnable { get; set; }
        [Ordinal(1)] [RED("depthFunc")] public CEnum<Enums.PSODescDepthStencilModeComparisonMode> DepthFunc { get; set; }
        [Ordinal(2)] [RED("stencilEnable")] public CBool StencilEnable { get; set; }
        [Ordinal(3)] [RED("stencilWriteMask")] public CBool StencilWriteMask { get; set; }
        [Ordinal(4)] [RED("frontFace")] public PSODescStencilFuncDesc FrontFace { get; set; }
        public PSODescDepthStencilModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class PSODescStencilFuncDesc : CVariable
    {
        [Ordinal(0)] [RED("stencilPassOp")] public CEnum<Enums.PSODescDepthStencilModeStencilOpMode> StencilPassOp { get; set; }
        [Ordinal(1)] [RED("stencilFunc")] public CEnum<Enums.PSODescDepthStencilModeComparisonMode> StencilFunc { get; set; }
        public PSODescStencilFuncDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class PSODescRenderTarget : CVariable
    {
        [Ordinal(0)] [RED("srcFactor")] public CEnum<Enums.PSODescBlendModeFactor> SrcFactor { get; set; }
        [Ordinal(1)] [RED("srcAlphaFactor")] public CEnum<Enums.PSODescBlendModeFactor> srcAlphaFactor { get; set; }
        public PSODescRenderTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class IEvaluatorColor : CVariable { public IEvaluatorColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorTreeNodeDefinition : CVariable { public AIbehaviorTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AreaShapeOutline : CVariable { public AreaShapeOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldITriggerAreaNotifer : CVariable { public worldITriggerAreaNotifer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry : CVariable
    {
        [Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
        [Ordinal(1)] [RED("appearanceName")] public CName AppearanceName { get; set; }
        public questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class gameEffectExecutor_KatanaBulletBendingEffectEntry : CVariable { public gameEffectExecutor_KatanaBulletBendingEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class toolsTimeLineItemDescription : CVariable { public toolsTimeLineItemDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class workIEntry : CVariable { public workIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class workIWorkspotCondition : CVariable { public workIWorkspotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class scnEntryPoint : CVariable
    {
        [Ordinal(0)] [RED("name")] public CName Name { get; set; }
        [Ordinal(1)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
        public scnEntryPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnExitPoint : CVariable
    {
        [Ordinal(0)] [RED("name")] public CName Name { get; set; }
        [Ordinal(1)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
        public scnExitPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnActorDef : CVariable
    {
        [Ordinal(0)] [RED("actorId")] public scnActorId ActorId { get; set; }
        [Ordinal(1)] [RED("voicetagId")] public scnVoicetagId VoicetagId { get; set; }
        [Ordinal(2)] [RED("acquisitionPlan")] public scnEntityAcquisitionPlan AcquisitionPlan { get; set; }
        [Ordinal(3)] [RED("findActorInContextParams")] public scnFindEntityInContextParams FindActorInContextParams { get; set; }
        [Ordinal(4)] [RED("lipsyncAnimSet")] public scnLipsyncAnimSetSRRefId LipsyncAnimSet { get; set; }
        [Ordinal(5)] [RED("actorName")] public CString ActorName { get; set; }
        public scnActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnLipsyncAnimSetSRRefId : CVariable
    {
        [Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
        public scnLipsyncAnimSetSRRefId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnFindEntityInContextParams : CVariable
    {
        [Ordinal(0)] [RED("contextualName")] public scnContextualActorName ContextualName { get; set; }
        [Ordinal(1)] [RED("voiceVagId")] public scnVoicetagId VoiceVagId { get; set; }
        [Ordinal(2)] [RED("specRecordId")] public TweakDBID SpecRecordId { get; set; }
        public scnFindEntityInContextParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnContextualActorName : CVariable
    {
        public scnContextualActorName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnVoicetagId : CVariable
    {
        [Ordinal(0)] [RED("id")] public CRUID Id { get; set; }
        public scnVoicetagId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnEntityAcquisitionPlan : CVariable
    {
        public scnEntityAcquisitionPlan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class graphGraphSocketDefinition : CVariable { public graphGraphSocketDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameJournalEntry : CVariable { public gameJournalEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorConditionDefinition : CVariable { public AIbehaviorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIArgumentDefinition : CVariable { public AIArgumentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldWorld : CVariable { public worldWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldTrafficLanePersistent : CVariable { public worldTrafficLanePersistent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldStreamingSectorDescriptor : CVariable { public worldStreamingSectorDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldStaticLaneCollisions : CVariable { public worldStaticLaneCollisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldSpeedSplineNodeSpeedChangeSection : CVariable { public worldSpeedSplineNodeSpeedChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldSpeedSplineNodeOrientationChangeSection : CVariable { public worldSpeedSplineNodeOrientationChangeSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldRaceSplineNodeOffset : CVariable { public worldRaceSplineNodeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldQualitySetting : CVariable { public worldQualitySetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldNavigationTileData : CVariable { public worldNavigationTileData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldIMarker : CVariable { public worldIMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldDeviceConnections : CVariable { public worldDeviceConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldCommunityRegistryItem : CVariable { public worldCommunityRegistryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldAutoFoliageMappingItem : CVariable { public worldAutoFoliageMappingItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldAudioAttractAreaNodeSettings : CVariable { public worldAudioAttractAreaNodeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldAdvertisementLightData : CVariable { public worldAdvertisementLightData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class worldAcousticDataCell : CVariable { public worldAcousticDataCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class workWorkspotItemOverrideItemOverride : CVariable
    {
        [Ordinal(0)] [RED("prevItemId")] public TweakDBID PrevItemId { get; set; }
        public workWorkspotItemOverrideItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class workWorkspotAnimsetEntry : CVariable
    {
        [Ordinal(0)] [RED("rig")] public raRef<animRig> Rig { get; set; }
        [Ordinal(1)] [RED("animations")] public animAnimSetup Animations { get; set; }
        [Ordinal(2)] [RED("loadingHandles")] public rRef<animAnimSet> LoadingHandles { get; set; }
        public workWorkspotAnimsetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimSetup : CVariable
    {
        [Ordinal(0)] [RED("cinematics")] public animAnimSetupEntry Cinematics { get; set; }
        public animAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimSetupEntry : CVariable
    {
        [Ordinal(0)] [RED("animSet")] public raRef<animAnimSet> AnimSet { get; set; }
        public animAnimSetupEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class workIWorkspotItemAction : CVariable { public workIWorkspotItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class workIScriptedCondition : CVariable { public workIScriptedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class visIOccluderResource : CVariable { public visIOccluderResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class toolsSocketVisibilityData : CVariable
    {
        [Ordinal(0)] [RED("socketId")] public CUInt32 SocketId { get; set; }
        [Ordinal(1)] [RED("name")] public CName Name { get; set; }
        [Ordinal(2)] [RED("placement")] public toolsSocketPlacement Placement { get; set; }
        [Ordinal(3)] [RED("hidden")] public CBool Hidden { get; set; }
        public toolsSocketVisibilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class toolsScreenplayLine : CVariable { public toolsScreenplayLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class toolsIGraphNodeDescriptor : CVariable { public toolsIGraphNodeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class StimTargetData : CVariable { public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class SplinePoint : CVariable { public SplinePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class SParticleEmitterLODLevel : CVariable { public SParticleEmitterLODLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnSectionInternalsActorBehavior : CVariable { public scnSectionInternalsActorBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnscreenplayDialogLine : CVariable { public scnscreenplayDialogLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnSceneGraphNode : CVariable { public scnSceneGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnSceneEventSymbol : CVariable { public scnSceneEventSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnSceneEvent : CVariable { public scnSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnPerformerSymbol : CVariable { public scnPerformerSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnOutputSocket : CVariable { public scnOutputSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnNodeSymbol : CVariable { public scnNodeSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnlocLocStoreEmbeddedVariantPayloadEntry : CVariable { public scnlocLocStoreEmbeddedVariantPayloadEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnlocLocStoreEmbeddedVariantDescriptorEntry : CVariable { public scnlocLocStoreEmbeddedVariantDescriptorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnLipsyncAnimSetSRRef : CVariable { public scnLipsyncAnimSetSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIScalingData : CVariable { public scnIScalingData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIReturnCondition : CVariable { public scnIReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnInterruptFactConditionType : CVariable { public scnInterruptFactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIInterruptionScenarioOperation : CVariable { public scnIInterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIInterruptionOperation : CVariable { public scnIInterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIInterruptCondition : CVariable { public scnIInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnIGameplayActionData : CVariable { public scnIGameplayActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scneventsSpawnEntityEventCachedFallbackBone : CVariable { public scneventsSpawnEntityEventCachedFallbackBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnChoiceNodeOption : CVariable { public scnChoiceNodeOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnChoiceNodeNsLookAtParams : CVariable { public scnChoiceNodeNsLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnbSceneActorData : CVariable { public scnbSceneActorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnblocVariant : CVariable { public scnblocVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnAnimationMotionSample : CVariable { public scnAnimationMotionSample(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnAdditionalSpeaker : CVariable { public scnAdditionalSpeaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class scnActorRid : CVariable { public scnActorRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class SamplerStateInfo : CVariable { public SamplerStateInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class rendTopologyData : CVariable { public rendTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class rendGradientEntry : CVariable { public rendGradientEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class rendEmitterLOD : CVariable { public rendEmitterLOD(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questTransformAnimatorNode_ActionType : CVariable { public questTransformAnimatorNode_ActionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questTransferItems_NodeTypeParams : CVariable { public questTransferItems_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questTogglePrefabVariant_NodeTypeParams : CVariable { public questTogglePrefabVariant_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questSpawnManagerNodeActionEntry : CVariable { public questSpawnManagerNodeActionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questSetTriggerState_NodeTypeParams : CVariable { public questSetTriggerState_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questSetItemTags_NodeTypeParams : CVariable { public questSetItemTags_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questSetGender_NodeTypeParams : CVariable { public questSetGender_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questSetAsCrowdObstacle_NodeTypeParams : CVariable { public questSetAsCrowdObstacle_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questRadioStationAnnouncementEventStruct : CVariable { public questRadioStationAnnouncementEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questPuppetAIManagerNodeDefinitionEntry : CVariable { public questPuppetAIManagerNodeDefinitionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questPlayVoiceset_NodeTypeParams : CVariable { public questPlayVoiceset_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questPlayFX_NodeTypeParams : CVariable { public questPlayFX_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questPlaceholderNodeSocketInfo : CVariable { public questPlaceholderNodeSocketInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questNodeDefinition : CVariable { public questNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questManageCollision_NodeTypeParams : CVariable { public questManageCollision_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questLootTokenManager_NodeTypeParams : CVariable { public questLootTokenManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIWorldDataManagerNodeType : CVariable { public questIWorldDataManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIVoicesetManager_NodeType : CVariable { public questIVoicesetManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIVisionModeNodeType : CVariable { public questIVisionModeNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIVehicleManagerNodeType : CVariable { public questIVehicleManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIVehicleConditionType : CVariable { public questIVehicleConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIUIManagerNodeType : CVariable { public questIUIManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIUIConditionType : CVariable { public questIUIConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questITutorial_NodeSubType : CVariable { public questITutorial_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questITriggerManagerNodeType : CVariable { public questITriggerManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questITimeManagerNodeType : CVariable { public questITimeManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questITimeConditionType : CVariable { public questITimeConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questISystemConditionType : CVariable { public questISystemConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIStatsConditionType : CVariable { public questIStatsConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questISpawnerConditionType : CVariable { public questISpawnerConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questISensesConditionType : CVariable { public questISensesConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questISceneManagerNodeType : CVariable { public questISceneManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questISceneConditionType : CVariable { public questISceneConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIRewardManagerNodeType : CVariable { public questIRewardManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIRenderFxManagerNodeType : CVariable { public questIRenderFxManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIRecordingNodeType : CVariable { public questIRecordingNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIPhoneManagerNodeType : CVariable { public questIPhoneManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIPayment_ConditionType : CVariable { public questIPayment_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIObjectConditionType : CVariable { public questIObjectConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questInjectLoot_NodeTypeParams : CVariable { public questInjectLoot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIJournal_NodeType : CVariable { public questIJournal_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIJournalConditionType : CVariable { public questIJournalConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIItemManagerNodeType : CVariable { public questIItemManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIInteractiveObjectManagerNodeType : CVariable { public questIInteractiveObjectManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIInt32ValueProvider : CVariable { public questIInt32ValueProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIGameManagerNodeType : CVariable { public questIGameManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIFXManagerNodeType : CVariable { public questIFXManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIFactsDBManagerNodeType : CVariable { public questIFactsDBManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIFactsDBConditionType : CVariable { public questIFactsDBConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIEnvironmentManagerNodeType : CVariable { public questIEnvironmentManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIEntityManager_NodeType : CVariable { public questIEntityManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIEntityManagerSetAttachment_NodeSubType : CVariable { public questIEntityManagerSetAttachment_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIDistanceConditionType : CVariable { public questIDistanceConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICrowdManager_NodeType : CVariable { public questICrowdManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIContentTokenManager_NodeSubType : CVariable { public questIContentTokenManager_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIContentConditionType : CVariable { public questIContentConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterManager_NodeType : CVariable { public questICharacterManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterManagerVisuals_NodeSubType : CVariable { public questICharacterManagerVisuals_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterManagerParameters_NodeSubType : CVariable { public questICharacterManagerParameters_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterManagerCombat_NodeSubType : CVariable { public questICharacterManagerCombat_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterConditionType : CVariable { public questICharacterConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questICharacterConditionSubType : CVariable { public questICharacterConditionSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIBehaviourManager_NodeType : CVariable { public questIBehaviourManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIBaseCondition : CVariable { public questIBaseCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIAudioNodeType : CVariable { public questIAudioNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questIAchievementManagerNodeType : CVariable { public questIAchievementManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questForceVMModule_NodeTypeParams : CVariable { public questForceVMModule_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questEntityManagerToggleComponent_NodeTypeParams : CVariable { public questEntityManagerToggleComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questEntityManagerSetMeshAppearance_NodeTypeParams : CVariable { public questEntityManagerSetMeshAppearance_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questEntityManagerSetDestructionState_NodeTypeParams : CVariable { public questEntityManagerSetDestructionState_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questEntityManagerManageBinkComponent_NodeTypeParams : CVariable { public questEntityManagerManageBinkComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questElevator_ManageNPCAttachment_NodeTypeParams : CVariable { public questElevator_ManageNPCAttachment_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questDropItemFromSlot_NodeTypeParams : CVariable { public questDropItemFromSlot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questConditionItem : CVariable { public questConditionItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questChangeVoicesetState_NodeTypeParams : CVariable { public questChangeVoicesetState_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questChangeContactList_NodeTypeParams : CVariable { public questChangeContactList_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class questAICommandParams : CVariable { public questAICommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsSectorCacheEntry : CVariable { public physicsSectorCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsRagdollBodyNames : CVariable { public physicsRagdollBodyNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsRagdollBodyInfo : CVariable { public physicsRagdollBodyInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsISystemObject : CVariable { public physicsISystemObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsICollider : CVariable { public physicsICollider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsGeometryKey : CVariable { public physicsGeometryKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsDestructionLevelData : CVariable { public physicsDestructionLevelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsDestructionHierarchyOffset : CVariable { public physicsDestructionHierarchyOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsCollisionPresetOverride : CVariable { public physicsCollisionPresetOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsCollisionPreset : CVariable { public physicsCollisionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class physicsclothExportedCapsule : CVariable { public physicsclothExportedCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class ObjectScanningDescription : CVariable { public ObjectScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class NPCReference : CVariable { public NPCReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class navLocomotionPathSegmentInfo : CVariable { public navLocomotionPathSegmentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class moveMovementParameters : CVariable { public moveMovementParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class MorphTargetMeshEntry : CVariable { public MorphTargetMeshEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshRegionData : CVariable { public meshRegionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshPhxClothChunkData : CVariable { public meshPhxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshLocalMaterialHeader : CVariable { public meshLocalMaterialHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshGfxClothChunkData : CVariable { public meshGfxClothChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshDestructionBond : CVariable { public meshDestructionBond(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class meshChunkIndicesOffset : CVariable { public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class MaterialUsedParameter : CVariable { public MaterialUsedParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class locVoLengthEntry : CVariable { public locVoLengthEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class localizationPersistenceSubtitleMapEntry : CVariable { public localizationPersistenceSubtitleMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class localizationPersistenceOnScreenEntry : CVariable { public localizationPersistenceOnScreenEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class ITonemappingMode : CVariable { public ITonemappingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class ITexture : CVariable { public ITexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IScriptable : CVariable { public IScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IParticleModule : CVariable { public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IParticleDrawer : CVariable { public IParticleDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkWidgetLibraryItem : CVariable { public inkWidgetLibraryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkTextureSlot : CVariable { public inkTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkTextureAtlasMapper : CVariable { public inkTextureAtlasMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkStyle : CVariable { public inkStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkShapePreset : CVariable { public inkShapePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkMenuEntry : CVariable { public inkMenuEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkHudWidgetSpawnEntry : CVariable { public inkHudWidgetSpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkFontStyle : CVariable { public inkFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkCreditsSectionEntry : CVariable { public inkCreditsSectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkCompositionPreset : CVariable { public inkCompositionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class inkanimInterpolator : CVariable { public inkanimInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IEvaluatorVector : CVariable { public IEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IEvaluator : CVariable { public IEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IDynamicTextureGenerator : CVariable { public IDynamicTextureGenerator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class IAreaSettings : CVariable { public IAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class graphGraphNodeDefinition : CVariable { public graphGraphNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class graphGraphDefinition : CVariable { public graphGraphDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class garmentMeshParamGarmentChunkData : CVariable { public garmentMeshParamGarmentChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameVisualTagsAppearanceNamesPreset_Entity : CVariable { public gameVisualTagsAppearanceNamesPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }

    [REDMeta]
    public class gameuiCharacterCustomizationUiPresetValue : CVariable
    {
        [Ordinal(0)] [RED("optionName")] public CName OptionName { get; set; }
        [Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }
        [Ordinal(2)] [RED("value")] public CUInt32 value { get; set; }
        public gameuiCharacterCustomizationUiPresetValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class gameSmartObjectMembershipMemberShip : CVariable { public gameSmartObjectMembershipMemberShip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameSmartObjectGate : CVariable { public gameSmartObjectGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameSmartObjectAnimationDatabase : CVariable { public gameSmartObjectAnimationDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameSceneTierData : CVariable { public gameSceneTierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gamemappinsIPointOfInterestVariant : CVariable { public gamemappinsIPointOfInterestVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameIPrereq : CVariable { public gameIPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameinteractionsIShapeDefinition : CVariable { public gameinteractionsIShapeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameinteractionsIPredicateType : CVariable { public gameinteractionsIPredicateType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameIFinisherScenario : CVariable { public gameIFinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameIEffectParameter_VectorEvaluator : CVariable { public gameIEffectParameter_VectorEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameIEffectParameter_FloatEvaluator : CVariable { public gameIEffectParameter_FloatEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameIEffectParameter_BoolEvaluator : CVariable { public gameIEffectParameter_BoolEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameHitShapeContainer : CVariable { public gameHitShapeContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameHitRepresentationVisualTaggedOverride : CVariable { public gameHitRepresentationVisualTaggedOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameEffectVectorEvaluator : CVariable { public gameEffectVectorEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameEffectObjectSingleFilter : CVariable { public gameEffectObjectSingleFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameEffectDefinition : CVariable { public gameEffectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameDefaultAppearancePreset_Entity : CVariable { public gameDefaultAppearancePreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gamedataNPCType : CVariable { public gamedataNPCType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameCompiledSmartObjectNode : CVariable { public gameCompiledSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameCommunitySpawnSetNameToIDEntry : CVariable { public gameCommunitySpawnSetNameToIDEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameBodyTypeAnimationDefinition : CVariable { public gameBodyTypeAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class gameAppearanceNameVisualTagsPreset_Entity : CVariable { public gameAppearanceNameVisualTagsPreset_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class ETransitionMode : CVariable { public ETransitionMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class ERenderObjectType : CVariable { public ERenderObjectType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class entdismembermentWoundMeshes : CVariable { public entdismembermentWoundMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class entdismembermentWoundDecal : CVariable { public entdismembermentWoundDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class EGameplayRole : CVariable { public EGameplayRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class EFocusOutlineType : CVariable { public EFocusOutlineType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class effectTrackItem : CVariable { public effectTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class effectTrackBase : CVariable { public effectTrackBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class EffectExecutor_SlashEffect_Entry : CVariable { public EffectExecutor_SlashEffect_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class CurveSetEntry : CVariable { public CurveSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class communitySquadInitializerEntry : CVariable { public communitySquadInitializerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class communityPhaseTimePeriod : CVariable { public communityPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class communityCommunityEntrySpotsData : CVariable { public communityCommunityEntrySpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class CMaterialParameter : CVariable { public CMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class Bink : CVariable { public Bink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class BaseSkillCheckContainer : CVariable { public BaseSkillCheckContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class audioSoundBankStruct : CVariable { public audioSoundBankStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class audioRadioStationSongEventStruct : CVariable { public audioRadioStationSongEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class audioPlaylistTrackEventStruct : CVariable { public audioPlaylistTrackEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class appearanceAppearancePartOverrides : CVariable { public appearanceAppearancePartOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class appearanceAppearancePart : CVariable { public appearanceAppearancePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animTwistOutput : CVariable { public animTwistOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animStackTransformsExtender_SnapToBoneMethod : CVariable { public animStackTransformsExtender_SnapToBoneMethod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animSimpleBounceTransformOutput : CVariable { public animSimpleBounceTransformOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animSetBoneTransformEntry : CVariable { public animSetBoneTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animSAnimationBufferBitwiseCompressedBoneTrack : CVariable { public animSAnimationBufferBitwiseCompressedBoneTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animRigRetarget : CVariable { public animRigRetarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animRigPart : CVariable { public animRigPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animPoseInfoLoggerEntry : CVariable { public animPoseInfoLoggerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animPoseCorrection : CVariable { public animPoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animOverrideBlendBoneInfo : CVariable { public animOverrideBlendBoneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animLookAtStateMachineSettings : CVariable { public animLookAtStateMachineSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animLookAtRequestForPart : CVariable { public animLookAtRequestForPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animLookAtPartInfo : CVariable { public animLookAtPartInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animLookAtAnimationDefinition : CVariable { public animLookAtAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animLipsyncMappingSceneEntry : CVariable { public animLipsyncMappingSceneEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIStaticCondition : CVariable { public animIStaticCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIRuntimeCondition : CVariable { public animIRuntimeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIRigIkSetup : CVariable { public animIRigIkSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIPoseBlendMethod : CVariable { public animIPoseBlendMethod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIMotionTableProvider : CVariable { public animIMotionTableProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIKChainSettings : CVariable { public animIKChainSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIDyngConstraint : CVariable { public animIDyngConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimStateTransitionInterpolator : CVariable { public animIAnimStateTransitionInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimStateTransitionCondition : CVariable { public animIAnimStateTransitionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimNodeSourceChannel_Vector : CVariable { public animIAnimNodeSourceChannel_Vector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimNodeSourceChannel_Quat : CVariable { public animIAnimNodeSourceChannel_Quat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimNodeSourceChannel_QsTransform : CVariable { public animIAnimNodeSourceChannel_QsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animIAnimationBuffer : CVariable { public animIAnimationBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animGraphSlotCondition : CVariable { public animGraphSlotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animGenericAnimDatabase_DatabaseRow : CVariable { public animGenericAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animFloatTrackInfo : CVariable { public animFloatTrackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animFacialCustomizationTargetEntryTemp : CVariable { public animFacialCustomizationTargetEntryTemp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animDyngParticle : CVariable
    {
        [Ordinal(0)] [RED("isFree")] public CBool IsFree { get; set; }
        [Ordinal(1)] [RED("bone")] public animTransformIndex Bone { get; set; }
        public animDyngParticle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animDangleConstraint_SimulationDyng : CVariable
    {
        [Ordinal(0)] [RED("parentRotationAltersTransformsOfNonDanglesAndItsChildren")] public CBool ParentRotationAltersTransformsOfNonDanglesAndItsChildren { get; set; }
        [Ordinal(1)] [RED("dangleAltersTransformsOfItsChildren")] public CBool DangleAltersTransformsOfItsChildren { get; set; }
        [Ordinal(2)] [RED("substepTime")] public CFloat SubstepTime { get; set; }
        [Ordinal(3)] [RED("particlesContainer")] public animDyngParticlesContainer ParticlesContainer { get; set; }
        [Ordinal(4)] [RED("dyngConstraint")] public CHandle<animIDyngConstraint> DyngConstraint { get; set; }
        public animDangleConstraint_SimulationDyng(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class animCorrectivePoseEntry : CVariable { public animCorrectivePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animAnimTransformMappingEntry : CVariable
    {
        [Ordinal(0)] [RED("from")] public CName From { get; set; }
        [Ordinal(1)] [RED("to")] public CName To { get; set; }
        public animAnimTransformMappingEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class animAnimNode_VectorValue : CVariable { public animAnimNode_VectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animAnimNode_QuaternionValue : CVariable { public animAnimNode_QuaternionValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animAnimNode_MultipleParentConstraint_ParentInfo : CVariable
    {
        [Ordinal(0)] [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
        [Ordinal(1)] [RED("parentWeightMode")] public animConstraintWeightMode ParentWeightMode { get; set; }
        [Ordinal(2)] [RED("parentTrackWeight")] public animNamedTrackIndex ParentTrackWeight { get; set; }
        public animAnimNode_MultipleParentConstraint_ParentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class animAnimNode_IntValue : CVariable { public animAnimNode_IntValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animAnimNode_FloatValue : CVariable { public animAnimNode_FloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class animAnimNode_BoolValue : CVariable { public animAnimNode_BoolValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animAnimNode_BlendSpace_InternalsBlendSpacePoint : CVariable
    {
        [Ordinal(0)] [RED("fixedCoordinates")] public CFloat FixedCoordinates { get; set; }
        public animAnimNode_BlendSpace_InternalsBlendSpacePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : CVariable
    {
        [Ordinal(0)] [RED("name")] public CName Name { get; set; }
        public animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class animAnimNode_Base : CVariable { public animAnimNode_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animAnimMultiBoolToFloatEntry : CVariable
    {
        [Ordinal(0)] [RED("group")] public CName Group { get; set; }
        [Ordinal(1)] [RED("name")] public CName Name { get; set; }
        public animAnimMultiBoolToFloatEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimMathExpressionFloatSocket : CVariable
    {
        [Ordinal(0)] [RED("link")] public animFloatLink Link { get; set; }
        public animAnimMathExpressionFloatSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimFeatureEntry : CVariable
    {
        [Ordinal(0)] [RED("name")] public CName Name { get; set; }
        [Ordinal(1)] [RED("className")] public CName ClassName { get; set; }
        public animAnimFeatureEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animAnimFeature_VehiclePassengerAnimSetup : CVariable
    {
        [Ordinal(0)] [RED("enableAdditiveAnim")] public CBool EnableAdditiveAnim { get; set; }
        public animAnimFeature_VehiclePassengerAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class animAnimDataChunk : CVariable { public animAnimDataChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta]
    public class animAdditionalFloatTrackEntry : CVariable
    {
        [Ordinal(0)] [RED("trackInfo")] public animFloatTrackInfo TrackInfo { get; set; }
        public animAdditionalFloatTrackEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animActionAnimDatabase_AnimationData : CVariable
    {
        [Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
        [Ordinal(1)] [RED("outTransitionDuration")] public CFloat OutTransitionDuration { get; set; }
        [Ordinal(2)] [RED("outCanRequestInertialization")] public CBool OutCanRequestInertialization { get; set; }
        [Ordinal(3)] [RED("streamingContext")] public CName StreamingContext { get; set; }
        public animActionAnimDatabase_AnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animActionAnimDatabase_DatabaseRow : CVariable
    {
        [Ordinal(0)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
        [Ordinal(1)] [RED("state")] public CInt32 State { get; set; }
        [Ordinal(2)] [RED("animVariation")] public CInt32 AnimVariation { get; set; }
        [Ordinal(3)] [RED("animationData")] public animActionAnimDatabase_AnimationData AnimationData { get; set; }
        public animActionAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta] public class AISpot : CVariable { public AISpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIRole : CVariable { public AIRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIGuardAreaConnectedCommunity : CVariable { public AIGuardAreaConnectedCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AICommand : CVariable { public AICommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviortaskStackScript : CVariable { public AIbehaviortaskStackScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviortaskScript : CVariable { public AIbehaviortaskScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorTaskDefinition : CVariable { public AIbehaviorTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorPassiveExpressionDefinition : CVariable { public AIbehaviorPassiveExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorParameterizedBehavior : CVariable { public AIbehaviorParameterizedBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorexpressionScript : CVariable { public AIbehaviorexpressionScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorEventResolverDefinition : CVariable { public AIbehaviorEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorEntityLODConditions : CVariable { public AIbehaviorEntityLODConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorconditionScript : CVariable { public AIbehaviorconditionScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }
    [REDMeta] public class AIbehaviorAssignTaskItem : CVariable { public AIbehaviorAssignTaskItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { } }



}
