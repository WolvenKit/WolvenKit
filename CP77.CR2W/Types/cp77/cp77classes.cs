using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{

	[REDMeta]
	public class questCharacterSpawned_ConditionType : CVariable
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("comparisonParams")] public CHandle<questComparisonParam> ComparisonParams { get; set; }
		public questCharacterSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class animAnimNode_BlendByMaskDynamic : CVariable
	{
		[Ordinal(0)] [RED("base")] public animPoseLink Base { get; set; }
		[Ordinal(1)] [RED("blend")] public animPoseLink Blend { get; set; }
		[Ordinal(2)] [RED("mask")] public animIntLink Mask { get; set; }
		[Ordinal(3)] [RED("weight")] public animFloatLink Weight { get; set; }
		[Ordinal(4)] [RED("masks")] public CArray<CName> Masks { get; set; }
		public animAnimNode_BlendByMaskDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class questRandomizerNodeDefinition : CVariable
	{
		[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
		[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
		public questRandomizerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class questCharacterTriggeredCombatInSecuritySystem_ConditionType : CVariable
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		public questCharacterTriggeredCombatInSecuritySystem_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class CheckFriendlyNPCAboutToBeHit : CVariable
	{
		[Ordinal(0)] [RED("outStatusArgument")] public CHandle<AIArgumentMapping> OutStatusArgument { get; set; }
		[Ordinal(1)] [RED("outPositionStatusArgument")] public CHandle<AIArgumentMapping> OutPositionStatusArgument { get; set; }
		[Ordinal(2)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		public CheckFriendlyNPCAboutToBeHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class gamedataCompanionDistancePreset : CVariable
	{
		public gamedataCompanionDistancePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : CVariable
	{
		[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
		[Ordinal(1)] [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(2)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
		[Ordinal(3)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
		[Ordinal(4)] [RED("phase")] public CName Phase { get; set; }
		[Ordinal(5)] [RED("speedLink")] public animFloatLink SpeedLink { get; set; }
		public animAnimNode_SkPhaseWithSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class AIMoveRotateToCommandHandler : CVariable
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
		[Ordinal(3)] [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
		[Ordinal(4)] [RED("speed")] public CHandle<AIArgumentMapping> Speed { get; set; }
		public AIMoveRotateToCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class worldGenericProxyMeshNode : CVariable
	{
		[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
		[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
		public worldGenericProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class worldAudioSignpostTriggerNode : CVariable
	{
		[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
		[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
		[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
		[Ordinal(4)] [RED("enterSignpost")] public CName EnterSignpost { get; set; }
		[Ordinal(5)] [RED("exitSignpost")] public CName ExitSignpost { get; set; }
		public worldAudioSignpostTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class questSetLocationName_NodeType : CVariable
	{
		[Ordinal(0)] [RED("locationName")] public CString LocationName { get; set; }
		[Ordinal(1)] [RED("isNewLocation")] public CBool IsNewLocation { get; set; }
		public questSetLocationName_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class gameEffectFilter_ReachableByAcousticGraph : CVariable
	{
		[Ordinal(0)] [RED("maxPathLength")] public gameEffectInputParameter_Float MaxPathLength { get; set; }
		public gameEffectFilter_ReachableByAcousticGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class questAudioParameterNodeType : CVariable
	{
		[Ordinal(0)] [RED("param")] public audioAudParameter Param { get; set; }
		[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		public questAudioParameterNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class questCharacterManagerVisuals_ChangeEntityAppearance : CVariable
	{
		[Ordinal(0)] [RED("appearanceEntries")] public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries { get; set; }
		public questCharacterManagerVisuals_ChangeEntityAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class SetCloseItself : CVariable
	{
		public SetCloseItself(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBending : CVariable
	{
		[Ordinal(0)] [RED("effects")] public CArray<gameEffectExecutor_KatanaBulletBendingEffectEntry> Effects { get; set; }
		public gameEffectExecutor_KatanaBulletBending(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class SetSkipDeathAnimationTask : CVariable
	{
		public SetSkipDeathAnimationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearestMelee : CVariable
	{
		public gameEffectObjectFilter_OnlyNearestMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class animAnimVariableInt : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		public animAnimVariableInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	[REDMeta]
	public class IsFacingTowardsSource : CVariable
	{
		[Ordinal(0)] [RED("applyForPlayer")] public CBool ApplyForPlayer { get; set; }
		[Ordinal(1)] [RED("maxAllowedAngleYaw")] public CFloat MaxAllowedAngleYaw { get; set; }
		[Ordinal(2)] [RED("maxAllowedAnglePitch")] public CFloat MaxAllowedAnglePitch { get; set; }
		public IsFacingTowardsSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
	
    [REDMeta]
    public class gamePersistentStateDataResource : CVariable
    {
	    [Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	    public gamePersistentStateDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
[REDMeta]
public class gameJournalTarot : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("index")] public CInt32 Index { get; set; }
	[Ordinal(2)] [RED("name")] public LocalizationString Name { get; set; }
	[Ordinal(3)] [RED("description")] public LocalizationString Description { get; set; }
	[Ordinal(4)] [RED("imagePart")] public CName ImagePart { get; set; }
	public gameJournalTarot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSaveSanitizationForbiddenAreaNotifier : CVariable
{
	public worldSaveSanitizationForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RegisterTrafficRunner : CVariable
{
	public RegisterTrafficRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerBillboard : CVariable
{
	[Ordinal(0)] [RED("pivotOffset")] public CFloat PivotOffset { get; set; }
	public CParticleDrawerBillboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TriggerCombatReaction : CVariable
{
	public TriggerCombatReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentUint64Value : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentUint64Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WindAreaSettings : CVariable
{
	[Ordinal(0)] [RED("strength")] public curveData<CFloat> Strength { get; set; }
	public WindAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BlockReactionTask : CVariable
{
	public BlockReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsTimeLineItemCollection : CVariable
{
	[Ordinal(0)] [RED("items")] public CArray<CHandle<toolsTimeLineItemDescription>> Items { get; set; }
	public toolsTimeLineItemCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficCollisionResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("data")] public CHandle<worldTrafficStaticCollisionData> Data { get; set; }
	public worldTrafficCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDialogLineVisualStyle : CVariable
{
	public scnDialogLineVisualStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DistantFogAreaSettings : CVariable
{
	[Ordinal(0)] [RED("range")] public curveData<CFloat> Range { get; set; }
	[Ordinal(1)] [RED("albedoNear")] public curveData<HDRColor> AlbedoNear { get; set; }
	[Ordinal(2)] [RED("albedoFar")] public curveData<HDRColor> AlbedoFar { get; set; }
	[Ordinal(3)] [RED("nearDistance")] public curveData<CFloat> NearDistance { get; set; }
	[Ordinal(4)] [RED("farDistance")] public curveData<CFloat> FarDistance { get; set; }
	[Ordinal(5)] [RED("density")] public curveData<CFloat> Density { get; set; }
	[Ordinal(6)] [RED("heightFallof")] public curveData<CFloat> HeightFallof { get; set; }
	[Ordinal(7)] [RED("densitySecond")] public curveData<CFloat> DensitySecond { get; set; }
	[Ordinal(8)] [RED("heightFallofSecond")] public curveData<CFloat> HeightFallofSecond { get; set; }
	public DistantFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_BoolEdgeFeature : CVariable
{
	[Ordinal(0)] [RED("featureName")] public CName FeatureName { get; set; }
	[Ordinal(1)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
	public animAnimStateTransitionCondition_BoolEdgeFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMLocomotionStates : CVariable
{
	public gamePSMLocomotionStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIactionParamsPackageTypes : CVariable
{
	public AIactionParamsPackageTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderTextureResource : CVariable
{
	[Ordinal(0)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }
	public rendRenderTextureResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCoverHeight : CVariable
{
	public gameCoverHeight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectPostAction_BeamVFX_Custom : CVariable
{
	[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	[Ordinal(1)] [RED("attached")] public CBool Attached { get; set; }
	[Ordinal(2)] [RED("breakLoopOnDetach")] public CBool BreakLoopOnDetach { get; set; }
	[Ordinal(3)] [RED("effectTag")] public CName EffectTag { get; set; }
	public gameEffectPostAction_BeamVFX_Custom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TagObjectEvent : CVariable
{
	[Ordinal(0)] [RED("isTagged")] public CBool IsTagged { get; set; }
	public TagObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestChangeSecuritySystemAttitudeGroup : CVariable
{
	[Ordinal(0)] [RED("newAttitudeGroup")] public TweakDBID NewAttitudeGroup { get; set; }
	public QuestChangeSecuritySystemAttitudeGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workConditionalSequence : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
	[Ordinal(2)] [RED("conditionList")] public CArray<CHandle<workIWorkspotCondition>> ConditionList { get; set; }
	public workConditionalSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentNodeRefValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentNodeRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("entryPoints")] public CArray<scnEntryPoint> EntryPoints { get; set; }
	[Ordinal(2)] [RED("exitPoints")] public CArray<scnExitPoint> ExitPoints { get; set; }
	[Ordinal(3)] [RED("actors")] public CArray<scnActorDef> Actors { get; set; }
	[Ordinal(4)] [RED("sceneGraph")] public CHandle<scnSceneGraph> SceneGraph { get; set; }
	[Ordinal(5)] [RED("resouresReferences")] public scnSRRefCollection ResouresReferences { get; set; }
	[Ordinal(6)] [RED("screenplayStore")] public scnscreenplayStore ScreenplayStore { get; set; }
	[Ordinal(7)] [RED("locStore")] public scnlocLocStoreEmbedded LocStore { get; set; }
	[Ordinal(8)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(9)] [RED("interruptionScenarios")] public CArray<scnInterruptionScenario> InterruptionScenarios { get; set; }
	[Ordinal(10)] [RED("sceneCategoryTag")] public scnSceneCategoryTag SceneCategoryTag { get; set; }
	[Ordinal(11)] [RED("debugSymbols")] public scnDebugSymbols DebugSymbols { get; set; }
	public scnSceneResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterruptionScenarioId : CVariable
	{
    [Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
    public scnInterruptionScenarioId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
	[REDMeta]
public class questDeletionMarkerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("deletedNodeIds")] public CArray<CUInt16> DeletedNodeIds { get; set; }
	public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakerOrAddressDistractedInterruptCondition : CVariable
{
	public scnCheckSpeakerOrAddressDistractedInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkFrameAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(2)] [RED("progressLink")] public animFloatLink ProgressLink { get; set; }
	public animAnimNode_SkFrameAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questItemManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIItemManagerNodeType> Type { get; set; }
	public questItemManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowBracket_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("bracketID")] public CName BracketID { get; set; }
	[Ordinal(1)] [RED("bracketType")] public gameTutorialBracketType BracketType { get; set; }
	[Ordinal(2)] [RED("offset")] public Vector2 Offset { get; set; }
	[Ordinal(3)] [RED("size")] public Vector2 Size { get; set; }
	[Ordinal(4)] [RED("ignoreDisabledTutorials")] public CBool IgnoreDisabledTutorials { get; set; }
	public questShowBracket_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageBrushParams : CVariable
{
	[Ordinal(0)] [RED("Proximity")] public CFloat Proximity { get; set; }
	[Ordinal(1)] [RED("Scale")] public CFloat Scale { get; set; }
	[Ordinal(2)] [RED("ScaleVariation")] public CFloat ScaleVariation { get; set; }
	public worldFoliageBrushParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questControlCrowdAction : CVariable
{
	public questControlCrowdAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMovePuppetNodeParams : CVariable
{
	[Ordinal(0)] [RED("moveOnSplineParams")] public CHandle<questMoveOnSplineParams> MoveOnSplineParams { get; set; }
	[Ordinal(1)] [RED("moveToParams")] public CHandle<questMoveToParams> MoveToParams { get; set; }
	public questMovePuppetNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_State : CVariable
{
	[Ordinal(0)] [RED("nodes")] public CArray<CHandle<animAnimNode_Base>> Nodes { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	[Ordinal(2)] [RED("outTransitionIndices")] public CArray<CInt16> OutTransitionIndices { get; set; }
	public animAnimNode_State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnPlayerVehicle_NodeType : CVariable
{
	[Ordinal(0)] [RED("despawn")] public CBool Despawn { get; set; }
	[Ordinal(1)] [RED("positionRef")] public CHandle<questUniversalRef> PositionRef { get; set; }
	[Ordinal(2)] [RED("despawnAllVehicles")] public CBool DespawnAllVehicles { get; set; }
	public questSpawnPlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ConeLimit : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("coneTransform")] public animTransformIndex ConeTransform { get; set; }
	[Ordinal(2)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
	[Ordinal(3)] [RED("marginEaseOutCurve")] public curveData<CFloat> MarginEaseOutCurve { get; set; }
	[Ordinal(4)] [RED("limit1")] public CFloat Limit1 { get; set; }
	[Ordinal(5)] [RED("paraboloidRadius1")] public CFloat ParaboloidRadius1 { get; set; }
	[Ordinal(6)] [RED("limit2")] public CFloat Limit2 { get; set; }
	[Ordinal(7)] [RED("paraboloidRadius2")] public CFloat ParaboloidRadius2 { get; set; }
	[Ordinal(8)] [RED("limit3")] public CFloat Limit3 { get; set; }
	[Ordinal(9)] [RED("paraboloidRadius3")] public CFloat ParaboloidRadius3 { get; set; }
	[Ordinal(10)] [RED("limit4")] public CFloat Limit4 { get; set; }
	[Ordinal(11)] [RED("paraboloidRadius4")] public CFloat ParaboloidRadius4 { get; set; }
	public animAnimNode_ConeLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkSpeedAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("collectEvents")] public CBool CollectEvents { get; set; }
	[Ordinal(2)] [RED("Speed")] public animFloatLink Speed { get; set; }
	public animAnimNode_SkSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class populationSpawnerObjectCtrlAction : CVariable
{
	public populationSpawnerObjectCtrlAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsConeDefinition : CVariable
{
	[Ordinal(0)] [RED("pos1")] public Vector4 Pos1 { get; set; }
	[Ordinal(1)] [RED("pos2")] public Vector4 Pos2 { get; set; }
	[Ordinal(2)] [RED("radius1")] public CFloat Radius1 { get; set; }
	[Ordinal(3)] [RED("radius2")] public CFloat Radius2 { get; set; }
	public gameinteractionsConeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetGlobalTvOnly : CVariable
{
	public SetGlobalTvOnly(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVarVsVarComparison_ConditionType : CVariable
{
	[Ordinal(0)] [RED("factName1")] public CString FactName1 { get; set; }
	[Ordinal(1)] [RED("factName2")] public CString FactName2 { get; set; }
	public questVarVsVarComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_ReactionStimuli : CVariable
{
	public EffectExecutor_ReactionStimuli(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animIntLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_IntValue> Node { get; set; }
	public animIntLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FilmGrainAreaSettings : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	[Ordinal(1)] [RED("strength")] public curveData<Vector4> Strength { get; set; }
	[Ordinal(2)] [RED("luminanceBias")] public curveData<CFloat> LuminanceBias { get; set; }
	public FilmGrainAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleVehicleDoorState : CVariable
{
	public vehicleVehicleDoorState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorRotation3DOverLife : CVariable
{
	[Ordinal(0)] [RED("rotation")] public CHandle<IEvaluatorVector> Rotation { get; set; }
	public CParticleModificatorRotation3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerVehicleStatePrereq : CVariable
{
	public PlayerVehicleStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimTextOffsetInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("startValue")] public CFloat StartValue { get; set; }
	public inkanimTextOffsetInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGameTimeDelay_ConditionType : CVariable
{
	[Ordinal(0)] [RED("hours")] public CUInt32 Hours { get; set; }
	public questGameTimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleEventGenerator : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(1)] [RED("frequency")] public CFloat Frequency { get; set; }
	public CParticleEventGenerator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("entryPoints")] public CArray<gameSmartObjectGate> EntryPoints { get; set; }
	[Ordinal(2)] [RED("exitPoints")] public CArray<gameSmartObjectGate> ExitPoints { get; set; }
	[Ordinal(3)] [RED("bodyTypes")] public CArray<gameBodyTypeAnimationDefinition> BodyTypes { get; set; }
	[Ordinal(4)] [RED("loopAnimations")] public CArray<gameSmartObjectGate> LoopAnimations { get; set; }
	[Ordinal(5)] [RED("type")] public gameSmartObjectType Type { get; set; }
	public gameSmartObjectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_CurvePathSlot : CVariable
{
	[Ordinal(0)] [RED("input")] public animPoseLink Input { get; set; }
	public animAnimNode_CurvePathSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIVehicleConditionType> Type { get; set; }
	public questVehicleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneEventId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt64 Id { get; set; }
	public scnSceneEventId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GlobalLightingTrajectoryOverride : CVariable
{
	[Ordinal(0)] [RED("overrideScale")] public CFloat OverrideScale { get; set; }
	[Ordinal(1)] [RED("latitude")] public CFloat Latitude { get; set; }
	public GlobalLightingTrajectoryOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_HealPlayer : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	public questCharacterManagerParameters_HealPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EnableDocumentEvent : CVariable
{
	[Ordinal(0)] [RED("documentName")] public CName DocumentName { get; set; }
	[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
	public EnableDocumentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimation : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(2)] [RED("animBuffer")] public CHandle<animIAnimationBuffer> AnimBuffer { get; set; }
	[Ordinal(3)] [RED("additionalTracks")] public animAdditionalFloatTrackContainer AdditionalTracks { get; set; }
	public animAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_FoleyAction : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("actionName")] public CName ActionName { get; set; }
	public animAnimEvent_FoleyAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMBodyCarryingStyle : CVariable
{
	public gamePSMBodyCarryingStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorNoise : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("amplitude")] public CHandle<IEvaluatorVector> Amplitude { get; set; }
	[Ordinal(2)] [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
	[Ordinal(3)] [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
	[Ordinal(4)] [RED("worldSpaceOffset")] public CBool WorldSpaceOffset { get; set; }
	[Ordinal(5)] [RED("noiseType")] public ENoiseType NoiseType { get; set; }
	public CParticleModificatorNoise(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMuteAnimEvents : CVariable
{
	public animMuteAnimEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ETextureAnimationMode : CVariable
{
	public ETextureAnimationMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AlertedState : CVariable
{
	public AlertedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestGuidanceMarker : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	[Ordinal(2)] [RED("isPortal")] public CBool IsPortal { get; set; }
	public gameJournalQuestGuidanceMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDesiredReaction : CVariable
{
	[Ordinal(0)] [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
	[Ordinal(1)] [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
	[Ordinal(2)] [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
	public SetDesiredReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questProximityProgressBar_NodeType : CVariable
{
	[Ordinal(0)] [RED("show")] public CBool Show { get; set; }
	public questProximityProgressBar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioEventNodeType : CVariable
{
	[Ordinal(0)] [RED("event")] public audioAudEventStruct Event { get; set; }
	[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questAudioEventNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterScalar : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(3)] [RED("max")] public CFloat Max { get; set; }
	public CMaterialParameterScalar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questResetMovement_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questResetMovement_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUICondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIUIConditionType> Type { get; set; }
	public questUICondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorFloatRandomUniform : CVariable
{
	[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(1)] [RED("max")] public CFloat Max { get; set; }
	public CEvaluatorFloatRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimMarginInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(4)] [RED("startValue")] public inkMargin StartValue { get; set; }
	[Ordinal(5)] [RED("endValue")] public inkMargin EndValue { get; set; }
	public inkanimMarginInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandStartAnimFeature : CVariable
{
	public ReprimandStartAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameMessageSender : CVariable
{
	public gameMessageSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalEntryUserState : CVariable
{
	public gameJournalEntryUserState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnNodeId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnNodeId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFindPositionAroundTarget : CVariable
{
	public AIFindPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCrowdHit_ConditionType : CVariable
{
	public questVehicleCrowdHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetCustomPersonalLinkReason : CVariable
{
	[Ordinal(0)] [RED("reason")] public TweakDBID Reason { get; set; }
	public SetCustomPersonalLinkReason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAcousticZoneNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("tagName")] public CName TagName { get; set; }
	[Ordinal(3)] [RED("tagSpread")] public CFloat TagSpread { get; set; }
	public worldAcousticZoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Dangle : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("dangleConstraint")] public CHandle<animDangleConstraint_Simulation> DangleConstraint { get; set; }
	public animAnimNode_Dangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RevealQuestTargetEvent : CVariable
{
	[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
	public RevealQuestTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWorkspotList : CVariable
{
	[Ordinal(0)] [RED("spots")] public CArray<NodeRef> Spots { get; set; }
	public AIbehaviorWorkspotList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldReflectionProbeNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
	[Ordinal(3)] [RED("priority")] public CUInt8 Priority { get; set; }
	[Ordinal(4)] [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
	[Ordinal(5)] [RED("skyScale")] public CFloat SkyScale { get; set; }
	[Ordinal(6)] [RED("allInShadow")] public CBool AllInShadow { get; set; }
	[Ordinal(7)] [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
	[Ordinal(8)] [RED("ambientMode")] public envUtilsReflectionProbeAmbientContributionMode AmbientMode { get; set; }
	[Ordinal(9)] [RED("captureOffset")] public Vector3 CaptureOffset { get; set; }
	[Ordinal(10)] [RED("subScene")] public CBool SubScene { get; set; }
	[Ordinal(11)] [RED("noFadeBlend")] public CBool NoFadeBlend { get; set; }
	public worldReflectionProbeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_ApplyEffector : CVariable
{
	[Ordinal(0)] [RED("effector")] public TweakDBID Effector { get; set; }
	public EffectExecutor_ApplyEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalQuestObjectiveCounter_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	public questJournalQuestObjectiveCounter_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatCumulative : CVariable
{
	[Ordinal(0)] [RED("normalize180")] public CBool Normalize180 { get; set; }
	[Ordinal(1)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	[Ordinal(2)] [RED("minValue")] public animFloatLink MinValue { get; set; }
	[Ordinal(3)] [RED("maxValue")] public animFloatLink MaxValue { get; set; }
	[Ordinal(4)] [RED("curValue")] public animFloatLink CurValue { get; set; }
	public animAnimNode_FloatCumulative(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsCameraEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	public scneventsCameraEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemDecal : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("material")] public rRef<IMaterial> Material { get; set; }
	[Ordinal(3)] [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
	[Ordinal(4)] [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
	[Ordinal(5)] [RED("randomRotation")] public CBool RandomRotation { get; set; }
	public effectTrackItemDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerSize : CVariable
{
	[Ordinal(0)] [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }
	[Ordinal(1)] [RED("scale")] public CFloat Scale { get; set; }
	public CParticleInitializerSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_Ricochet : CVariable
{
	[Ordinal(0)] [RED("outputRicochetVector")] public gameEffectOutputParameter_Vector OutputRicochetVector { get; set; }
	public gameEffectExecutor_Ricochet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVarComparison_ConditionType : CVariable
{
	[Ordinal(0)] [RED("factName")] public CString FactName { get; set; }
	public questVarComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFloatLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_FloatValue> Node { get; set; }
	public animFloatLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMVehicle : CVariable
{
	public gamePSMVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class StrikeExecutor_Kill : CVariable
{
	public StrikeExecutor_Kill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCFunctorDefinition : CVariable
{
	[Ordinal(0)] [RED("predicate")] public gameinteractionsCPredicateDefinition Predicate { get; set; }
	public gameinteractionsCFunctorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_SingleRicochetTarget : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_SingleRicochetTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPerformanceAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	[Ordinal(4)] [RED("qualitySettingsArray")] public CArray<worldQualitySetting> QualitySettingsArray { get; set; }
	public worldPerformanceAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTerrainMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("meshRef")] public raRef<CMesh> MeshRef { get; set; }
	public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Ik2Constraint : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("inputTarget")] public CHandle<animIAnimNodeSourceChannel_Vector> InputTarget { get; set; }
	[Ordinal(2)] [RED("inputPoleVector")] public CHandle<animIAnimNodeSourceChannel_Vector> InputPoleVector { get; set; }
	[Ordinal(3)] [RED("firstBoneIndex")] public animTransformIndex FirstBoneIndex { get; set; }
	[Ordinal(4)] [RED("secondBoneIndex")] public animTransformIndex SecondBoneIndex { get; set; }
	[Ordinal(5)] [RED("endBoneIndex")] public animTransformIndex EndBoneIndex { get; set; }
	[Ordinal(6)] [RED("hingeAxis")] public animAxis HingeAxis { get; set; }
	public animAnimNode_Ik2Constraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ChangeStanceState : CVariable
{
	public ChangeStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIMovementTypeSpec : CVariable
{
	[Ordinal(0)] [RED("movementType")] public moveMovementType MovementType { get; set; }
	public AIMovementTypeSpec(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsFilterData : CVariable
{
	[Ordinal(0)] [RED("simulationFilter")] public physicsSimulationFilter SimulationFilter { get; set; }
	[Ordinal(1)] [RED("queryFilter")] public physicsQueryFilter QueryFilter { get; set; }
	[Ordinal(2)] [RED("preset")] public CName Preset { get; set; }
	public physicsFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_BulletImpact : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("noAudio")] public CBool NoAudio { get; set; }
	public gameEffectExecutor_BulletImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NavGenNavigationSetting : CVariable
{
	[Ordinal(0)] [RED("navmeshImpact")] public NavGenNavmeshImpact NavmeshImpact { get; set; }
	public NavGenNavigationSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInstancedDestructibleMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(3)] [RED("occluderType")] public visWorldOccluderType OccluderType { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("simulationType")] public physicsSimulationType SimulationType { get; set; }
	[Ordinal(6)] [RED("startInactive")] public CBool StartInactive { get; set; }
	[Ordinal(7)] [RED("isDestructible")] public CBool IsDestructible { get; set; }
	[Ordinal(8)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	[Ordinal(9)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
	[Ordinal(10)] [RED("fracturingEffect")] public raRef<worldEffect> FracturingEffect { get; set; }
	[Ordinal(11)] [RED("cookedInstanceTransforms")] public worldTransformBuffer CookedInstanceTransforms { get; set; }
	public worldInstancedDestructibleMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questReactionPresetRecordSelector : CVariable
{
	[Ordinal(0)] [RED("isGanger")] public CBool IsGanger { get; set; }
	[Ordinal(1)] [RED("isNoReaction")] public CBool IsNoReaction { get; set; }
	[Ordinal(2)] [RED("noReactionRecordID")] public TweakDBID NoReactionRecordID { get; set; }
	public questReactionPresetRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_ModifyHealth : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(2)] [RED("percent")] public CFloat Percent { get; set; }
	public questCharacterManagerCombat_ModifyHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleSummoned_ConditionType : CVariable
{
	public questVehicleSummoned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDiscoverBraindanceClue_NodeType : CVariable
{
	[Ordinal(0)] [RED("clueName")] public CName ClueName { get; set; }
	public questDiscoverBraindanceClue_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questHUDVideo_NodeType : CVariable
{
	[Ordinal(0)] [RED("video")] public raRef<Bink> Video { get; set; }
	[Ordinal(1)] [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
	[Ordinal(2)] [RED("playOnHud")] public CBool PlayOnHud { get; set; }
	[Ordinal(3)] [RED("size")] public Vector2 Size { get; set; }
	public questHUDVideo_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetBoneOrientation : CVariable
{
	[Ordinal(0)] [RED("bone")] public animTransformIndex Bone { get; set; }
	[Ordinal(1)] [RED("orientationMs")] public animQuaternionLink OrientationMs { get; set; }
	public animAnimNode_SetBoneOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSelectCoverTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("cover")] public CHandle<AIArgumentMapping> Cover { get; set; }
	[Ordinal(1)] [RED("coverID")] public CHandle<AIArgumentMapping> CoverID { get; set; }
	[Ordinal(2)] [RED("multiCoverID")] public CHandle<AIArgumentMapping> MultiCoverID { get; set; }
	[Ordinal(3)] [RED("combatTarget")] public CHandle<AIArgumentMapping> CombatTarget { get; set; }
	[Ordinal(4)] [RED("friendlyTarget")] public CHandle<AIArgumentMapping> FriendlyTarget { get; set; }
	[Ordinal(5)] [RED("combatZone")] public CHandle<AIArgumentMapping> CombatZone { get; set; }
	[Ordinal(6)] [RED("ignoreRestrictMovementArea")] public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea { get; set; }
	[Ordinal(7)] [RED("selectionPreset")] public CHandle<AIArgumentMapping> SelectionPreset { get; set; }
	[Ordinal(8)] [RED("onActivationSelectionPreset")] public CHandle<AIArgumentMapping> OnActivationSelectionPreset { get; set; }
	[Ordinal(9)] [RED("secondStagePreset")] public CHandle<AIArgumentMapping> SecondStagePreset { get; set; }
	[Ordinal(10)] [RED("coverChangeThreshold")] public CHandle<AIArgumentMapping> CoverChangeThreshold { get; set; }
	[Ordinal(11)] [RED("coverGatheringCenterObject")] public CHandle<AIArgumentMapping> CoverGatheringCenterObject { get; set; }
	[Ordinal(12)] [RED("coverDisablingDuration")] public CHandle<AIArgumentMapping> CoverDisablingDuration { get; set; }
	public AIbehaviorSelectCoverTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkTextureAtlas : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("slots", 3)] public CArrayFixedSize<inkTextureSlot> Slots { get; set; }
public inkTextureAtlas(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorTrueConditionDefinition : CVariable
{
	public AIbehaviorTrueConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterBodyType_CondtionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(2)] [RED("gender")] public CName Gender { get; set; }
	public questCharacterBodyType_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class HitData_Humanoid : CVariable
{
	[Ordinal(0)] [RED("hitShapeTag")] public CName HitShapeTag { get; set; }
	[Ordinal(1)] [RED("bodyPartStatPoolName")] public CName BodyPartStatPoolName { get; set; }
	[Ordinal(2)] [RED("hitShapeType")] public HitShape_Type HitShapeType { get; set; }
	public HitData_Humanoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCrowdCreationDataRegistry : CVariable
{
	public gameCrowdCreationDataRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolAction : CVariable
{
	public PatrolAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UseCoverCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public UseCoverCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectObjectProvider_PhysicalCollisionTrapEntities : CVariable
{
	public EffectObjectProvider_PhysicalCollisionTrapEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTier2Params_NodeType : CVariable
{
	[Ordinal(0)] [RED("playerWalkType")] public Tier2WalkType PlayerWalkType { get; set; }
	public questSetTier2Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RegisterFastTravelPointsRequest : CVariable
{
	[Ordinal(0)] [RED("fastTravelNodes")] public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes { get; set; }
	[Ordinal(1)] [RED("register")] public CBool Register { get; set; }
	public RegisterFastTravelPointsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMountRequestConditionDefinition : CVariable
{
	public AIbehaviorMountRequestConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChangeIdleAnimEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("animData")] public scneventsPlayAnimEventExData AnimData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("actorComponent")] public CName ActorComponent { get; set; }
	[Ordinal(5)] [RED("bakedFacialTransition")] public animFacialEmotionTransitionBaked BakedFacialTransition { get; set; }
	public scnChangeIdleAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIsValueValidConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("value")] public CHandle<AIArgumentMapping> Value { get; set; }
	public AIbehaviorIsValueValidConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questObjectDistance : CVariable
{
	[Ordinal(0)] [RED("nodeRef2")] public gameEntityReference NodeRef2 { get; set; }
	public questObjectDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMovementPolicyTaskItemDefinition : CVariable
{
	[Ordinal(0)] [RED("params", 4)] public CStatic<CHandle<AIbehaviorExpressionSocket>> Params { get; set; }
	public AIbehaviorMovementPolicyTaskItemDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorClearSearchInfluenceTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }
	[Ordinal(1)] [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
	[Ordinal(2)] [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }
	public AIbehaviorClearSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemLoopMarker : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	public effectTrackItemLoopMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalBriefingVideoSection : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
	public gameJournalBriefingVideoSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAlertedStateDelegate : CVariable
{
	public AIAlertedStateDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnXorNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	public scnXorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_SimpleDuration : CVariable
{
	[Ordinal(0)] [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_SimpleDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animPoseLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_Base> Node { get; set; }
	public animPoseLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPrefetchStreaming_NodeTypeV2 : CVariable
{
	[Ordinal(0)] [RED("prefetchPositionRef")] public NodeRef PrefetchPositionRef { get; set; }
	public questPrefetchStreaming_NodeTypeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataProficiencyType : CVariable
{
	public gamedataProficiencyType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorLimiterNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	public AIbehaviorLimiterNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questContentLock_ConditionType : CVariable
{
	public questContentLock_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorInterpolation : CVariable
{
	[Ordinal(0)] [RED("firstInput")] public animVectorLink FirstInput { get; set; }
	[Ordinal(1)] [RED("secondInput")] public animVectorLink SecondInput { get; set; }
	[Ordinal(2)] [RED("weight")] public animFloatLink Weight { get; set; }
	public animAnimNode_VectorInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetAnimWrappersFromMountData : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	public SetAnimWrappersFromMountData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlaylistTrackChanged_ConditionType : CVariable
{
	[Ordinal(0)] [RED("playlistName")] public CName PlaylistName { get; set; }
	public questPlaylistTrackChanged_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsMappinLocation : CVariable
{
	public scnChoiceNodeNsMappinLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendAdditive : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
	[Ordinal(1)] [RED("addedInputNode")] public animPoseLink AddedInputNode { get; set; }
	[Ordinal(2)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	public animAnimNode_BlendAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EEnvColorGroup : CVariable
{
	public EEnvColorGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_WrapperValue : CVariable
{
	[Ordinal(0)] [RED("wrapperName")] public CName WrapperName { get; set; }
	public animAnimStateTransitionCondition_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	public animAnimNode_FloatVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StateMachine : CVariable
{
	[Ordinal(0)] [RED("states")] public CArray<CHandle<animAnimNode_State>> States { get; set; }
	[Ordinal(1)] [RED("frozenState")] public CHandle<animAnimNode_StateFrozen> FrozenState { get; set; }
	[Ordinal(2)] [RED("transitions")] public CArray<CHandle<animAnimStateTransitionDescription>> Transitions { get; set; }
	[Ordinal(3)] [RED("conditionalEntries")] public CArray<CHandle<animAnimStateMachineConditionalEntry>> ConditionalEntries { get; set; }
	[Ordinal(4)] [RED("globalTransitions")] public CArray<CHandle<animAnimStateTransitionDescription>> GlobalTransitions { get; set; }
	[Ordinal(5)] [RED("anyStateInterpolator")] public CHandle<animIAnimStateTransitionInterpolator> AnyStateInterpolator { get; set; }
	public animAnimNode_StateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CombatRestrictMovementAreaAllDeadCondition : CVariable
{
	public CombatRestrictMovementAreaAllDeadCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CustomEventCondition : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public CustomEventCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterColor : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("color")] public CColor Color { get; set; }
	public CMaterialParameterColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Tier2WalkType : CVariable
{
	public Tier2WalkType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameContactType : CVariable
{
	public gameContactType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuickHackLockHacks : CVariable
{
	[Ordinal(0)] [RED("IsLocked")] public CBool IsLocked { get; set; }
	public QuickHackLockHacks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animDyngConstraintLinkType : CVariable
{
	public animDyngConstraintLinkType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerNotInBraindancePrereq : CVariable
{
	public PlayerNotInBraindancePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneInterrupt_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(1)] [RED("onlyInSafeMoment")] public CBool OnlyInSafeMoment { get; set; }
	[Ordinal(2)] [RED("interruptConditions")] public CArray<CHandle<scnIInterruptCondition>> InterruptConditions { get; set; }
	public questSceneInterrupt_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayEnv_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public questPlayEnv_NodeTypeParams Params { get; set; }
	public questPlayEnv_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerMountPuppet_NodeType : CVariable
{
	[Ordinal(0)] [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
	[Ordinal(1)] [RED("childRef")] public gameEntityReference ChildRef { get; set; }
	[Ordinal(2)] [RED("slotName")] public CName SlotName { get; set; }
	public questEntityManagerMountPuppet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AssignRestrictMovementAreaHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	[Ordinal(1)] [RED("resultOnNoChange")] public AIbehaviorCompletionStatus ResultOnNoChange { get; set; }
	public AssignRestrictMovementAreaHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckLastTriggeredStimuli : CVariable
{
	public CheckLastTriggeredStimuli(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCommandConditionExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("commandName")] public CName CommandName { get; set; }
	[Ordinal(1)] [RED("useInheritance")] public CBool UseInheritance { get; set; }
	[Ordinal(2)] [RED("isExecuting")] public CBool IsExecuting { get; set; }
	public AIbehaviorCommandConditionExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderParticleUpdaterData : CVariable
{
	[Ordinal(0)] [RED("data")] public DataBuffer Data { get; set; }
	[Ordinal(1)] [RED("modifOffset")] public CUInt32 ModifOffset { get; set; }
	[Ordinal(2)] [RED("animFrameInit")] public CArray<CFloat> AnimFrameInit { get; set; }
	public rendRenderParticleUpdaterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleLightQuestToggleEvent : CVariable
{
	[Ordinal(0)] [RED("toggle")] public CBool Toggle { get; set; }
	[Ordinal(1)] [RED("lightType")] public vehicleELightType LightType { get; set; }
	public VehicleLightQuestToggleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameStoryTier : CVariable
{
	public gameStoryTier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCableMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("deformationData")] public CArray<CMatrix> DeformationData { get; set; }
	[Ordinal(4)] [RED("deformedBox")] public Box DeformedBox { get; set; }
	[Ordinal(5)] [RED("destructionHashes", 2)] public CArrayFixedSize<CUInt64> DestructionHashes { get; set; }
[Ordinal(6)] [RED("cableLength")] public CFloat CableLength { get; set; }
[Ordinal(7)] [RED("cableRadius")] public CFloat CableRadius { get; set; }
public worldCableMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_CombatTarget : CVariable
{
	[Ordinal(0)] [RED("targetPuppet")] public gameEntityReference TargetPuppet { get; set; }
	public questCombatNodeParams_CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsActorReminderParams : CVariable
{
	[Ordinal(0)] [RED("reminderActor")] public scnActorId ReminderActor { get; set; }
	[Ordinal(1)] [RED("waitTimeForReminderA")] public scnSceneTime WaitTimeForReminderA { get; set; }
	[Ordinal(2)] [RED("waitTimeForReminderB")] public scnSceneTime WaitTimeForReminderB { get; set; }
	[Ordinal(3)] [RED("waitTimeForReminderC")] public scnSceneTime WaitTimeForReminderC { get; set; }
	[Ordinal(4)] [RED("waitTimeForLooping")] public scnSceneTime WaitTimeForLooping { get; set; }
	public scnChoiceNodeNsActorReminderParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamGpuBuffer : CVariable
{
	[Ordinal(0)] [RED("stride")] public CUInt32 Stride { get; set; }
	[Ordinal(1)] [RED("data")] public DataBuffer Data { get; set; }
	public meshMeshParamGpuBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questNodeType : CVariable
{
	public questNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPerformanceAreaNotifier : CVariable
{
	public worldPerformanceAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolSpotAction : CVariable
{
	[Ordinal(0)] [RED("patrolAction")] public CHandle<AIArgumentMapping> PatrolAction { get; set; }
	public PatrolSpotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalEntryState_ConditionType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("state")] public gameJournalEntryState State { get; set; }
	public questJournalEntryState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVendorPanel_NodeType : CVariable
{
	[Ordinal(0)] [RED("vendorId")] public CString VendorId { get; set; }
	[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questVendorPanel_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEFootPhase : CVariable
{
	public animEFootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveRacingTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
	[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
	[Ordinal(3)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
	[Ordinal(4)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
	[Ordinal(5)] [RED("backwards")] public CHandle<AIArgumentMapping> Backwards { get; set; }
	[Ordinal(6)] [RED("reverse")] public CHandle<AIArgumentMapping> Reverse { get; set; }
	[Ordinal(7)] [RED("closest")] public CHandle<AIArgumentMapping> Closest { get; set; }
	[Ordinal(8)] [RED("forcedStartSpeed")] public CHandle<AIArgumentMapping> ForcedStartSpeed { get; set; }
	[Ordinal(9)] [RED("stopAtPathEnd")] public CHandle<AIArgumentMapping> StopAtPathEnd { get; set; }
	[Ordinal(10)] [RED("keepDistanceParamBool")] public CHandle<AIArgumentMapping> KeepDistanceParamBool { get; set; }
	[Ordinal(11)] [RED("keepDistanceParamCompanion")] public CHandle<AIArgumentMapping> KeepDistanceParamCompanion { get; set; }
	[Ordinal(12)] [RED("keepDistanceParamDistance")] public CHandle<AIArgumentMapping> KeepDistanceParamDistance { get; set; }
	[Ordinal(13)] [RED("rubberBandingBool")] public CHandle<AIArgumentMapping> RubberBandingBool { get; set; }
	[Ordinal(14)] [RED("rubberBandingTargetRef")] public CHandle<AIArgumentMapping> RubberBandingTargetRef { get; set; }
	[Ordinal(15)] [RED("rubberBandingMinDistance")] public CHandle<AIArgumentMapping> RubberBandingMinDistance { get; set; }
	[Ordinal(16)] [RED("rubberBandingMaxDistance")] public CHandle<AIArgumentMapping> RubberBandingMaxDistance { get; set; }
	[Ordinal(17)] [RED("rubberBandingStopAndWait")] public CHandle<AIArgumentMapping> RubberBandingStopAndWait { get; set; }
	[Ordinal(18)] [RED("rubberBandingTeleportToCatchUp")] public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp { get; set; }
	[Ordinal(19)] [RED("rubberBandingStayInFront")] public CHandle<AIArgumentMapping> RubberBandingStayInFront { get; set; }
	public AIbehaviorDriveRacingTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BoolInput : CVariable
{
	[Ordinal(0)] [RED("group")] public CName Group { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	public animAnimNode_BoolInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerVelocity : CVariable
{
	[Ordinal(0)] [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }
	[Ordinal(1)] [RED("worldSpace")] public CBool WorldSpace { get; set; }
	public CParticleInitializerVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnerCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questISpawnerConditionType> Type { get; set; }
	public questSpawnerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUIElement_ConditionType : CVariable
{
	[Ordinal(0)] [RED("element")] public TweakDBID Element { get; set; }
	public questUIElement_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ELightUnit : CVariable
{
	public ELightUnit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Multilayer_LayerTemplateOverrides : CVariable
{
	[Ordinal(0)] [RED("colorScale")] public CArray<Multilayer_LayerTemplateOverridesColor> ColorScale { get; set; }
	[Ordinal(1)] [RED("roughLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsIn { get; set; }
	[Ordinal(2)] [RED("roughLevelsOut")] public CArray<Multilayer_LayerTemplateOverridesLevels> RoughLevelsOut { get; set; }
	[Ordinal(3)] [RED("metalLevelsIn")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsIn { get; set; }
	[Ordinal(4)] [RED("metalLevelsOut")] public CArray<Multilayer_LayerTemplateOverridesLevels> MetalLevelsOut { get; set; }
	[Ordinal(5)] [RED("normalStrength")] public CArray<Multilayer_LayerTemplateOverridesNormalStrength> NormalStrength { get; set; }
	public Multilayer_LayerTemplateOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAssignCharacter_NodeType : CVariable
{
	[Ordinal(0)] [RED("characterRef")] public gameEntityReference CharacterRef { get; set; }
	[Ordinal(1)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(2)] [RED("assign")] public CBool Assign { get; set; }
	[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }
	public questAssignCharacter_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWorkspotItemOverride : CVariable
{
	[Ordinal(0)] [RED("itemOverrides")] public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides { get; set; }
	public workWorkspotItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleDeathTask : CVariable
{
	public VehicleDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EOutlineType : CVariable
{
	public EOutlineType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SAnimationBufferOrientationCompressionMethod : CVariable
{
	public SAnimationBufferOrientationCompressionMethod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckArgumentInt : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("comparator")] public ECompareOp Comparator { get; set; }
	public CheckArgumentInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlaySkAnimEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("animData")] public scneventsPlayAnimEventExData AnimData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("actorComponent")] public CName ActorComponent { get; set; }
	[Ordinal(5)] [RED("gameplayAnimName")] public CHandle<scnAnimName> GameplayAnimName { get; set; }
	[Ordinal(6)] [RED("FPPControlActive")] public CBool FPPControlActive { get; set; }
	[Ordinal(7)] [RED("blendOverride")] public scnfppBlendOverride BlendOverride { get; set; }
	[Ordinal(8)] [RED("cameraBlendInDuration")] public CFloat CameraBlendInDuration { get; set; }
	[Ordinal(9)] [RED("cameraBlendOutDuration")] public CFloat CameraBlendOutDuration { get; set; }
	[Ordinal(10)] [RED("animName")] public CHandle<scnAnimName> AnimName { get; set; }
	[Ordinal(11)] [RED("rootMotionData")] public scnPlaySkAnimRootMotionData RootMotionData { get; set; }
	[Ordinal(12)] [RED("playerData")] public scnPlayerAnimData PlayerData { get; set; }
	public scnPlaySkAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatInput : CVariable
{
	[Ordinal(0)] [RED("group")] public CName Group { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	public animAnimNode_FloatInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_CurveFloatValue : CVariable
{
	[Ordinal(0)] [RED("curveData")] public curveData<CFloat> CurveData { get; set; }
	[Ordinal(1)] [RED("argument")] public animFloatLink Argument { get; set; }
	public animAnimNode_CurveFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InvestigationReactionFilter : CVariable
{
	public InvestigationReactionFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EFreeVectorAxes : CVariable
{
	public EFreeVectorAxes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAutoFoliageMapping : CVariable
{
	[Ordinal(0)] [RED("Items")] public CArray<worldAutoFoliageMappingItem> Items { get; set; }
	public worldAutoFoliageMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_AnimFeatureApplyTo : CVariable
{
	public gameEffectExecutor_AnimFeatureApplyTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlayerAnimData : CVariable
{
	[Ordinal(0)] [RED("tierData")] public CHandle<gameSceneTierData> TierData { get; set; }
	public scnPlayerAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIForceShootCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetOverridePuppetRef")] public gameEntityReference TargetOverridePuppetRef { get; set; }
	public AIForceShootCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameTier3CameraSettings : CVariable
{
	[Ordinal(0)] [RED("yawLeftLimit")] public CFloat YawLeftLimit { get; set; }
	[Ordinal(1)] [RED("yawRightLimit")] public CFloat YawRightLimit { get; set; }
	[Ordinal(2)] [RED("pitchTopLimit")] public CFloat PitchTopLimit { get; set; }
	[Ordinal(3)] [RED("pitchBottomLimit")] public CFloat PitchBottomLimit { get; set; }
	public gameTier3CameraSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterestingConversationData : CVariable
{
	[Ordinal(0)] [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }
	[Ordinal(1)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
	public scnInterestingConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSermoTestController : CVariable
{
	[Ordinal(0)] [RED("jaw_mid_open")] public CFloat Jaw_mid_open { get; set; }
	public animSermoTestController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionDescription : CVariable
{
	[Ordinal(0)] [RED("targetStateIndex")] public CUInt32 TargetStateIndex { get; set; }
	[Ordinal(1)] [RED("condition")] public CHandle<animIAnimStateTransitionCondition> Condition { get; set; }
	[Ordinal(2)] [RED("interpolator")] public CHandle<animIAnimStateTransitionInterpolator> Interpolator { get; set; }
	[Ordinal(3)] [RED("priority")] public CInt32 Priority { get; set; }
	[Ordinal(4)] [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }
	[Ordinal(5)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
	[Ordinal(6)] [RED("actionAnimDatabaseRef")] public rRef<animActionAnimDatabase> ActionAnimDatabaseRef { get; set; }
	public animAnimStateTransitionDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalInternetRectangle : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("linkAddress")] public CString LinkAddress { get; set; }
	public gameJournalInternetRectangle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicalJointPin : CVariable
{
	[Ordinal(0)] [RED("object")] public CHandle<physicsISystemObject> Object { get; set; }
	public physicsPhysicalJointPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameFearStage : CVariable
{
	public gameFearStage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIBehaviorCallbackExpression : CVariable
{
	[Ordinal(0)] [RED("callbackName")] public CName CallbackName { get; set; }
	public AIBehaviorCallbackExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetBoneTransform : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<animSetBoneTransformEntry> Entries { get; set; }
	public animAnimNode_SetBoneTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCloseMessage_NodeType : CVariable
{
	[Ordinal(0)] [RED("msg")] public CHandle<gameJournalPath> Msg { get; set; }
	public questCloseMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGameplayRestrictionAction : CVariable
{
	public questGameplayRestrictionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSplineControlRubberbanding_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("keepDistanceFromRef")] public gameEntityReference KeepDistanceFromRef { get; set; }
	[Ordinal(2)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(3)] [RED("minSpeed")] public CFloat MinSpeed { get; set; }
	public questMoveOnSplineControlRubberbanding_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectTriggerPositioningType : CVariable
{
	public gameEffectTriggerPositioningType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup_OneSermoBufferInfo : CVariable
{
	[Ordinal(0)] [RED("numGlobalLimits")] public CUInt16 NumGlobalLimits { get; set; }
	[Ordinal(1)] [RED("numInfluencedPoses")] public CUInt16 NumInfluencedPoses { get; set; }
	[Ordinal(2)] [RED("numInfluenceIndices")] public CUInt16 NumInfluenceIndices { get; set; }
	[Ordinal(3)] [RED("numUpperLowerFace")] public CUInt16 NumUpperLowerFace { get; set; }
	[Ordinal(4)] [RED("numLipsyncPosesSides")] public CUInt16 NumLipsyncPosesSides { get; set; }
	[Ordinal(5)] [RED("numAllCorrectives")] public CUInt16 NumAllCorrectives { get; set; }
	[Ordinal(6)] [RED("numGlobalCorrectiveEntries")] public CUInt16 NumGlobalCorrectiveEntries { get; set; }
	[Ordinal(7)] [RED("numInbetweenCorrectiveEntries")] public CUInt16 NumInbetweenCorrectiveEntries { get; set; }
	[Ordinal(8)] [RED("numCorrectiveInfluencedPoses")] public CUInt16 NumCorrectiveInfluencedPoses { get; set; }
	[Ordinal(9)] [RED("numCorrectiveInfluenceIndices")] public CUInt16 NumCorrectiveInfluenceIndices { get; set; }
	[Ordinal(10)] [RED("numAllMainPoses")] public CUInt16 NumAllMainPoses { get; set; }
	[Ordinal(11)] [RED("numAllMainPosesInbetweens")] public CUInt16 NumAllMainPosesInbetweens { get; set; }
	[Ordinal(12)] [RED("numAllMainPosesInbetweenScopeMultipliers")] public CUInt16 NumAllMainPosesInbetweenScopeMultipliers { get; set; }
	[Ordinal(13)] [RED("numEnvelopesPerTrackMapping")] public CUInt16 NumEnvelopesPerTrackMapping { get; set; }
	[Ordinal(14)] [RED("wrinkleStartingIndex")] public CUInt16 WrinkleStartingIndex { get; set; }
	[Ordinal(15)] [RED("numWrinkles")] public CUInt16 NumWrinkles { get; set; }
	public animFacialSetup_OneSermoBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIdleTreeNodeDefinition : CVariable
{
	public AIbehaviorIdleTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Sermo : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("testController")] public animSermoTestController TestController { get; set; }
	public animAnimNode_Sermo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_PhysicalImpulseFromInstigator : CVariable
{
	public gameEffectExecutor_PhysicalImpulseFromInstigator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDialogLineEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("screenplayLineId")] public scnscreenplayItemId ScreenplayLineId { get; set; }
	[Ordinal(3)] [RED("voParams")] public scnDialogLineVoParams VoParams { get; set; }
	[Ordinal(4)] [RED("visualStyle")] public scnDialogLineVisualStyle VisualStyle { get; set; }
	public scnDialogLineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetFadeInOut_NodeType : CVariable
{
	public questSetFadeInOut_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TrafficGenDynamicTrafficSetting : CVariable
{
	[Ordinal(0)] [RED("impact")] public TrafficGenDynamicImpact Impact { get; set; }
	public TrafficGenDynamicTrafficSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsMappinParams : CVariable
{
	[Ordinal(0)] [RED("locationType")] public scnChoiceNodeNsMappinLocation LocationType { get; set; }
	[Ordinal(1)] [RED("mappinSettings")] public TweakDBID MappinSettings { get; set; }
	public scnChoiceNodeNsMappinParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NoWeaponCombatConditions : CVariable
{
	public NoWeaponCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entEntityInstanceData : CVariable
{
	[Ordinal(0)] [RED("buffer")] public DataBuffer Buffer { get; set; }
	public entEntityInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseBlendMethod_Mask : CVariable
{
	[Ordinal(0)] [RED("maskName")] public CName MaskName { get; set; }
	public animPoseBlendMethod_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsChoiceNodeBitFlags : CVariable
{
	public scnChoiceNodeNsChoiceNodeBitFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFSMTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("states")] public CArray<CHandle<AIbehaviorFSMStateDefinition>> States { get; set; }
	[Ordinal(1)] [RED("transitions")] public CArray<CHandle<AIbehaviorFSMTransitionDefinition>> Transitions { get; set; }
	[Ordinal(2)] [RED("initialState")] public CHandle<AIbehaviorFSMStateDefinition> InitialState { get; set; }
	public AIbehaviorFSMTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEAddRemoveItemType : CVariable
{
	public questEAddRemoveItemType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawner_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
	public questSpawner_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveFollowSplineTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
	[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
	[Ordinal(3)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
	[Ordinal(4)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
	[Ordinal(5)] [RED("backwards")] public CHandle<AIArgumentMapping> Backwards { get; set; }
	[Ordinal(6)] [RED("reverse")] public CHandle<AIArgumentMapping> Reverse { get; set; }
	[Ordinal(7)] [RED("closest")] public CHandle<AIArgumentMapping> Closest { get; set; }
	[Ordinal(8)] [RED("forcedStartSpeed")] public CHandle<AIArgumentMapping> ForcedStartSpeed { get; set; }
	[Ordinal(9)] [RED("stopAtPathEnd")] public CHandle<AIArgumentMapping> StopAtPathEnd { get; set; }
	[Ordinal(10)] [RED("keepDistanceParamBool")] public CHandle<AIArgumentMapping> KeepDistanceParamBool { get; set; }
	[Ordinal(11)] [RED("keepDistanceParamCompanion")] public CHandle<AIArgumentMapping> KeepDistanceParamCompanion { get; set; }
	[Ordinal(12)] [RED("keepDistanceParamDistance")] public CHandle<AIArgumentMapping> KeepDistanceParamDistance { get; set; }
	[Ordinal(13)] [RED("rubberBandingBool")] public CHandle<AIArgumentMapping> RubberBandingBool { get; set; }
	[Ordinal(14)] [RED("rubberBandingTargetRef")] public CHandle<AIArgumentMapping> RubberBandingTargetRef { get; set; }
	[Ordinal(15)] [RED("rubberBandingMinDistance")] public CHandle<AIArgumentMapping> RubberBandingMinDistance { get; set; }
	[Ordinal(16)] [RED("rubberBandingMaxDistance")] public CHandle<AIArgumentMapping> RubberBandingMaxDistance { get; set; }
	[Ordinal(17)] [RED("rubberBandingStopAndWait")] public CHandle<AIArgumentMapping> RubberBandingStopAndWait { get; set; }
	[Ordinal(18)] [RED("rubberBandingTeleportToCatchUp")] public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp { get; set; }
	public AIbehaviorDriveFollowSplineTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveCoverSelectionConditions : CVariable
{
	public PassiveCoverSelectionConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StrikeExecutor_Heal : CVariable
{
	[Ordinal(0)] [RED("healthPerc")] public CFloat HealthPerc { get; set; }
	public StrikeExecutor_Heal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentEnumValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("enumClass")] public CName EnumClass { get; set; }
	[Ordinal(2)] [RED("defaultValue")] public CInt64 DefaultValue { get; set; }
	public AIArgumentEnumValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AddWeapon : CVariable
{
	public AddWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCutControlNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questCutControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectParameter_FloatEvaluator_Blackboard : CVariable
{
	[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
	public gameEffectParameter_FloatEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestWindowDestructionEvent : CVariable
{
	[Ordinal(0)] [RED("window")] public vehicleQuestWindowDestruction Window { get; set; }
	public VehicleQuestWindowDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class sourcePrefabHash : CVariable
{
	public sourcePrefabHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AdditionalTransform : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("additionalTransforms")] public animAdditionalTransformContainer AdditionalTransforms { get; set; }
	public animAnimNode_AdditionalTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetStressOnTrafficLane : CVariable
{
	public SetStressOnTrafficLane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorDepthCollision : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	public CParticleModificatorDepthCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorOrConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("conditions")] public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions { get; set; }
	public AIbehaviorOrConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetArgumentVector : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("newValue")] public CHandle<AIArgumentMapping> NewValue { get; set; }
	public SetArgumentVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIScriptActionDelegate : CVariable
{
	[Ordinal(0)] [RED("actionPackageType")] public AIactionParamsPackageTypes ActionPackageType { get; set; }
	public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSetAsQuestImportantEvent : CVariable
{
	[Ordinal(0)] [RED("propagateToSlaves")] public CBool PropagateToSlaves { get; set; }
	public gameSetAsQuestImportantEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class localizationPersistenceSubtitleMap : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<localizationPersistenceSubtitleMapEntry> Entries { get; set; }
	public localizationPersistenceSubtitleMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentTreeRefValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("defaultValue")] public CHandle<AIbehaviorParameterizedBehavior> DefaultValue { get; set; }
	public AIArgumentTreeRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderParticleBlob : CVariable
{
	[Ordinal(0)] [RED("header")] public rendRenderParticleBlobHeader Header { get; set; }
	[Ordinal(1)] [RED("updaterData")] public rendRenderParticleUpdaterData UpdaterData { get; set; }
	public rendRenderParticleBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GrappleInteractionCondition : CVariable
{
	public GrappleInteractionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimTextReplaceInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("endValue")] public CFloat EndValue { get; set; }
	public inkanimTextReplaceInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEAnimGraphMathOp : CVariable
{
	public animEAnimGraphMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCommunityTemplate_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
	public questCommunityTemplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIScanTargetCommandParams : CVariable
{
	public AIScanTargetCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCompiledCrowdParkingSpaceNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("crowdCreationIndex")] public CUInt32 CrowdCreationIndex { get; set; }
	[Ordinal(3)] [RED("parkingSpaceId")] public CUInt32 ParkingSpaceId { get; set; }
	public worldCompiledCrowdParkingSpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsBraindanceVisibilityEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(3)] [RED("customMaterialParam")] public ECustomMaterialParam CustomMaterialParam { get; set; }
	[Ordinal(4)] [RED("parameterIndex")] public CUInt32 ParameterIndex { get; set; }
	public scneventsBraindanceVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BoolConstant : CVariable
{
	[Ordinal(0)] [RED("value")] public CBool Value { get; set; }
	public animAnimNode_BoolConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsScreenplaySection : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt64 Id { get; set; }
	[Ordinal(1)] [RED("index")] public CUInt64 Index { get; set; }
	[Ordinal(2)] [RED("lines")] public CArray<toolsScreenplayLine> Lines { get; set; }
	public toolsScreenplaySection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestAddTransition : CVariable
{
	[Ordinal(0)] [RED("transition")] public AreaTypeTransition Transition { get; set; }
	public QuestAddTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EInkAnimationPlaybackOption : CVariable
{
	public EInkAnimationPlaybackOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetEntityDistanceInterruptConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("targetEntity")] public gameEntityReference TargetEntity { get; set; }
	public scnCheckPlayerTargetEntityDistanceInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EFocusForcedHighlightType : CVariable
{
	public EFocusForcedHighlightType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamemappinsOutlineMappinVolume : CVariable
{
	[Ordinal(0)] [RED("height")] public CFloat Height { get; set; }
	[Ordinal(1)] [RED("outlinePoints")] public CArray<Vector2> OutlinePoints { get; set; }
	public gamemappinsOutlineMappinVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemFilmGrain : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("luminanceBias")] public effectEffectParameterEvaluatorFloat LuminanceBias { get; set; }
	[Ordinal(3)] [RED("strength")] public effectEffectParameterEvaluatorVector Strength { get; set; }
	public effectTrackItemFilmGrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CompleteCommand : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public CompleteCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneCallPhase_ConditionType : CVariable
{
	[Ordinal(0)] [RED("inverted")] public CBool Inverted { get; set; }
	[Ordinal(1)] [RED("callPhase")] public questPhoneCallPhase CallPhase { get; set; }
	public questPhoneCallPhase_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questElevator_ManageNPCAttachment_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questElevator_ManageNPCAttachment_NodeTypeParams> Params { get; set; }
	public questElevator_ManageNPCAttachment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EComparisonType : CVariable
{
	public EComparisonType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableProvider_MasterSlaveBlend : CVariable
{
	[Ordinal(0)] [RED("parentId")] public CInt32 ParentId { get; set; }
	[Ordinal(1)] [RED("type")] public animMotionTableType Type { get; set; }
	[Ordinal(2)] [RED("action")] public animMotionTableAction Action { get; set; }
	[Ordinal(3)] [RED("parentStaticSwitchBranch")] public animParentStaticSwitchBranch ParentStaticSwitchBranch { get; set; }
	[Ordinal(4)] [RED("masterInputIdx")] public CUInt8 MasterInputIdx { get; set; }
	public animMotionTableProvider_MasterSlaveBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsColliderSphere : CVariable
{
	[Ordinal(0)] [RED("material")] public CName Material { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	public physicsColliderSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animUncompressedMotionExtraction : CVariable
{
	[Ordinal(0)] [RED("frames")] public CArray<Vector4> Frames { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	public animUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolAlertedControllerTask : CVariable
{
	public PatrolAlertedControllerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EquipPrimaryWeaponCommandDelegate : CVariable
{
	public EquipPrimaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_QuaternionWsToMs : CVariable
{
	[Ordinal(0)] [RED("quaternionWs")] public animQuaternionLink QuaternionWs { get; set; }
	public animAnimNode_QuaternionWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAchievementManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIAchievementManagerNodeType> Type { get; set; }
	public questAchievementManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MorphTargetMesh : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("baseMesh")] public rRef<CMesh> BaseMesh { get; set; }
	[Ordinal(2)] [RED("targets")] public CArray<MorphTargetMeshEntry> Targets { get; set; }
	[Ordinal(3)] [RED("boundingBox")] public Box BoundingBox { get; set; }
	[Ordinal(4)] [RED("baseTextureParamName")] public CName BaseTextureParamName { get; set; }
	[Ordinal(5)] [RED("blob")] public CHandle<IRenderResourceBlob> Blob { get; set; }
	[Ordinal(6)] [RED("baseMeshAppearance")] public CName BaseMeshAppearance { get; set; }
	[Ordinal(7)] [RED("baseTexture")] public rRef<ITexture> BaseTexture { get; set; }
	[Ordinal(8)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
	public MorphTargetMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CDistantLightsResource : CVariable
{
	[Ordinal(0)] [RED("data")] public DataBuffer Data { get; set; }
	public CDistantLightsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAdditionalTransformContainer : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<CHandle<animAdditionalTransformEntry>> Entries { get; set; }
	public animAdditionalTransformContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTagged_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questTagged_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsPlayerAKiller : CVariable
{
	public IsPlayerAKiller(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleBrokenTire_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("tire")] public CUInt32 Tire { get; set; }
	public questToggleBrokenTire_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDistanceVsDistanceComparison_ConditionType : CVariable
{
	[Ordinal(0)] [RED("distanceDefinition1")] public CHandle<questObjectDistance> DistanceDefinition1 { get; set; }
	[Ordinal(1)] [RED("distanceDefinition2")] public CHandle<questObjectDistance> DistanceDefinition2 { get; set; }
	[Ordinal(2)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questDistanceVsDistanceComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsPlayAnimEventData : CVariable
{
	[Ordinal(0)] [RED("blendIn")] public CFloat BlendIn { get; set; }
	public scneventsPlayAnimEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPlaySoundEvent : CVariable
{
	[Ordinal(0)] [RED("soundEventName")] public CName SoundEventName { get; set; }
	public inkanimPlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleELightType : CVariable
{
	public vehicleELightType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCommandConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("commandName")] public CHandle<AIArgumentMapping> CommandName { get; set; }
	[Ordinal(1)] [RED("useInheritance")] public CBool UseInheritance { get; set; }
	[Ordinal(2)] [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }
	public AIbehaviorCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CRenderSimWaterFFT : CVariable
{
	[Ordinal(0)] [RED("windSpeed")] public CFloat WindSpeed { get; set; }
	public CRenderSimWaterFFT(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class CParticleModificatorDrag : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("dragCoefficient")] public CHandle<IEvaluatorFloat> DragCoefficient { get; set; }
	[Ordinal(2)] [RED("scale")] public CFloat Scale { get; set; }
	public CParticleModificatorDrag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WaterAreaSettings : CVariable
{
	public WaterAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDeviceManager_NodeTypeParams : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	[Ordinal(1)] [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
	[Ordinal(2)] [RED("deviceAction")] public CName DeviceAction { get; set; }
	public questDeviceManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEffectNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	public worldEffectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoPlayer : CVariable
{
	public gameEffectObjectFilter_NoPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AddSnapToTerrainIkRequest : CVariable
{
	[Ordinal(0)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(2)] [RED("debug")] public CBool Debug { get; set; }
	[Ordinal(3)] [RED("animDeltaZ")] public animFloatLink AnimDeltaZ { get; set; }
	[Ordinal(4)] [RED("leftFootRequest")] public animSnapToTerrainIkRequest LeftFootRequest { get; set; }
	[Ordinal(5)] [RED("rightFootRequest")] public animSnapToTerrainIkRequest RightFootRequest { get; set; }
	[Ordinal(6)] [RED("hipsRequest")] public animHipsIkRequest HipsRequest { get; set; }
	public animAnimNode_AddSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PrimaryWeaponTypeCondition : CVariable
{
	[Ordinal(0)] [RED("weaponType")] public WorkspotWeaponConditionEnum WeaponType { get; set; }
	public PrimaryWeaponTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentWoundTypeE : CVariable
{
	public entdismembermentWoundTypeE(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStreamingSector : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("level")] public CUInt8 Level { get; set; }
	[Ordinal(2)] [RED("category")] public CInt8 Category { get; set; }
	public worldStreamingSector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LightDirectionSettings : CVariable
{
	[Ordinal(0)] [RED("direction")] public GlobalLightingTrajectoryOverride Direction { get; set; }
	public LightDirectionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnableScanning_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questEnableScanning_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerToggleComponent_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questEntityManagerToggleComponent_NodeTypeParams> Params { get; set; }
	public questEntityManagerToggleComponent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentResourceSetMask : CVariable
{
	public entdismembermentResourceSetMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInterestingConversationsAreaNotifier : CVariable
{
	public worldInterestingConversationsAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIClearRoleCommandParams : CVariable
{
	public AIClearRoleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questNPCLookAt_NodeType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("refPlayer")] public CBool RefPlayer { get; set; }
	public questNPCLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionMoveToWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("workspotSetup")] public CHandle<AIArgumentMapping> WorkspotSetup { get; set; }
	[Ordinal(2)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
	[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
	[Ordinal(4)] [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
	[Ordinal(5)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	[Ordinal(7)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
	[Ordinal(8)] [RED("spotReservation")] public CHandle<AIArgumentMapping> SpotReservation { get; set; }
	[Ordinal(9)] [RED("startTangent")] public CHandle<AIArgumentMapping> StartTangent { get; set; }
	[Ordinal(10)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
	[Ordinal(11)] [RED("ignoreExploration")] public CHandle<AIArgumentMapping> IgnoreExploration { get; set; }
	public AIbehaviorActionMoveToWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameVisualTagsAppearanceNamesPreset : CVariable
{
	[Ordinal(0)] [RED("presets")] public CArray<gameVisualTagsAppearanceNamesPreset_Entity> Presets { get; set; }
	public gameVisualTagsAppearanceNamesPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleSpawned_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questVehicleSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEndNodeNsType : CVariable
{
	public scnEndNodeNsType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverrideInterruptConditions_InterruptionScenarioOperation : CVariable
{
	[Ordinal(0)] [RED("interruptConditions")] public CArray<CHandle<scnIInterruptCondition>> InterruptConditions { get; set; }
	public scnOverrideInterruptConditions_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimGraph : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rootNode")] public CHandle<animAnimNode_Root> RootNode { get; set; }
	[Ordinal(2)] [RED("variables")] public CHandle<animAnimVariableContainer> Variables { get; set; }
	[Ordinal(3)] [RED("animFeatures")] public CArray<animAnimFeatureEntry> AnimFeatures { get; set; }
	[Ordinal(4)] [RED("nodesToInit")] public CArray<CHandle<animAnimNode_Base>> NodesToInit { get; set; }
	public animAnimGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEndNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questEndNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animHipsIkRequest : CVariable
{
	[Ordinal(0)] [RED("leftLegIkChain")] public CName LeftLegIkChain { get; set; }
	[Ordinal(1)] [RED("rightLegIkChain")] public CName RightLegIkChain { get; set; }
	[Ordinal(2)] [RED("hipsTransformIndex")] public animTransformIndex HipsTransformIndex { get; set; }
	[Ordinal(3)] [RED("leftFootTransformIndex")] public animTransformIndex LeftFootTransformIndex { get; set; }
	[Ordinal(4)] [RED("rightFootTransformIndex")] public animTransformIndex RightFootTransformIndex { get; set; }
	public animHipsIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ELightType : CVariable
{
	public ELightType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCTreeNodeControlledByQuestNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorCTreeNodeControlledByQuestNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UnregisterTrafficRunner : CVariable
{
	public UnregisterTrafficRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTime_NodeType : CVariable
{
	[Ordinal(0)] [RED("hours")] public CInt32 Hours { get; set; }
	[Ordinal(1)] [RED("source")] public CName Source { get; set; }
	public questSetTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInteraction_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	[Ordinal(1)] [RED("eventType")] public questObjectInteractionEventType EventType { get; set; }
	public questInteraction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverridePhantomParamsEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("params")] public scnOverridePhantomParamsEventParams Params { get; set; }
	public scnOverridePhantomParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_GameObjectOutline : CVariable
{
	[Ordinal(0)] [RED("outlineType")] public EOutlineType OutlineType { get; set; }
	public EffectExecutor_GameObjectOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questExitType : CVariable
{
	public questExitType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTriggerNotifier_Quest : CVariable
{
	public questTriggerNotifier_Quest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIMeleeAttackCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetOverridePuppetRef")] public gameEntityReference TargetOverridePuppetRef { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	public AIMeleeAttackCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questETimeShiftType : CVariable
{
	public questETimeShiftType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectsCompiledResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("animationDatabase")] public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase { get; set; }
	[Ordinal(2)] [RED("transformDictionary")] public CHandle<gameSmartObjectTransformDictionary> TransformDictionary { get; set; }
	[Ordinal(3)] [RED("propertyDictionary")] public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary { get; set; }
	[Ordinal(4)] [RED("transformSequenceDictionary")] public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary { get; set; }
	public gameSmartObjectsCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StealthStimThreshold : CVariable
{
	[Ordinal(0)] [RED("stealthThresholdNumber")] public CInt32 StealthThresholdNumber { get; set; }
	public StealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FilterNPCDodgeOpportunity : CVariable
{
	[Ordinal(0)] [RED("applyToTechWeapons")] public CBool ApplyToTechWeapons { get; set; }
	[Ordinal(1)] [RED("doDodgingTargetsGetFilteredOut")] public CBool DoDodgingTargetsGetFilteredOut { get; set; }
	public FilterNPCDodgeOpportunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPhoneChoiceEntry : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("text")] public LocalizationString Text { get; set; }
	public gameJournalPhoneChoiceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSectionNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
	[Ordinal(3)] [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }
	[Ordinal(4)] [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
	public scnSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnLookAtAdvancedEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("advancedData")] public scnLookAtAdvancedEventData AdvancedData { get; set; }
	public scnLookAtAdvancedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimSetEntry : CVariable
{
	[Ordinal(0)] [RED("animation")] public CHandle<animAnimation> Animation { get; set; }
	public animAnimSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TrackSetter : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("track")] public animNamedTrackIndex Track { get; set; }
	[Ordinal(2)] [RED("value")] public animFloatLink Value { get; set; }
	public animAnimNode_TrackSetter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUseWorkspotPlayerParams : CVariable
{
	[Ordinal(0)] [RED("cameraSettings")] public gameTier3CameraSettings CameraSettings { get; set; }
	[Ordinal(1)] [RED("emptyHands")] public CBool EmptyHands { get; set; }
	[Ordinal(2)] [RED("vehicleProceduralCameraWeight")] public CFloat VehicleProceduralCameraWeight { get; set; }
	public questUseWorkspotPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FindNavmeshPointAroundThePlayer : CVariable
{
	[Ordinal(0)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
	public FindNavmeshPointAroundThePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questWorldDataManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIWorldDataManagerNodeType> Type { get; set; }
	public questWorldDataManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorRotationOverLife : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("rotation")] public CHandle<IEvaluatorFloat> Rotation { get; set; }
	public CParticleModificatorRotationOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameTargetSearchQuery : CVariable
{
	[Ordinal(0)] [RED("testedSet")] public gameTargetingSet TestedSet { get; set; }
	[Ordinal(1)] [RED("includeSecondaryTargets")] public CBool IncludeSecondaryTargets { get; set; }
	public gameTargetSearchQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AmbientOverrideAreaSettings : CVariable
{
	public AmbientOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetGlitchOnUIEvent : CVariable
{
	[Ordinal(0)] [RED("intensity")] public CFloat Intensity { get; set; }
	public SetGlitchOnUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIRagdollDelegate : CVariable
{
	public AIRagdollDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CHairProfile : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("gradientEntriesID")] public CArray<rendGradientEntry> GradientEntriesID { get; set; }
	[Ordinal(2)] [RED("gradientEntriesRootToTip")] public CArray<rendGradientEntry> GradientEntriesRootToTip { get; set; }
	public CHairProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalRootFolderEntry : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(1)] [RED("descriptor")] public raRef<gameJournalDescriptorResource> Descriptor { get; set; }
	public gameJournalRootFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleMinimapVisibility_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(1)] [RED("show")] public CBool Show { get; set; }
	public questToggleMinimapVisibility_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableRPGRequirementsForDeviceActions : CVariable
{
	[Ordinal(0)] [RED("action")] public TweakDBID Action { get; set; }
	public DisableRPGRequirementsForDeviceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEffectId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnEffectId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionDroneMoveTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("moveType")] public CHandle<AIArgumentMapping> MoveType { get; set; }
	[Ordinal(2)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(3)] [RED("movementTarget")] public CHandle<AIArgumentMapping> MovementTarget { get; set; }
	[Ordinal(4)] [RED("toleranceRadius")] public CHandle<AIArgumentMapping> ToleranceRadius { get; set; }
	[Ordinal(5)] [RED("desiredDistanceFromTarget")] public CHandle<AIArgumentMapping> DesiredDistanceFromTarget { get; set; }
	[Ordinal(6)] [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
	[Ordinal(7)] [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
	[Ordinal(8)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	public AIbehaviorActionDroneMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticFogVolumeNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("absolute")] public CBool Absolute { get; set; }
	[Ordinal(3)] [RED("densityFalloff")] public CFloat DensityFalloff { get; set; }
	[Ordinal(4)] [RED("blendFalloff")] public CFloat BlendFalloff { get; set; }
	[Ordinal(5)] [RED("densityFactor")] public CFloat DensityFactor { get; set; }
	[Ordinal(6)] [RED("absorption")] public CFloat Absorption { get; set; }
	[Ordinal(7)] [RED("ambientScale")] public CFloat AmbientScale { get; set; }
	public worldStaticFogVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SimpleBounce : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("debug")] public CBool Debug { get; set; }
	[Ordinal(2)] [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
	[Ordinal(3)] [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
	[Ordinal(4)] [RED("multiplier")] public CFloat Multiplier { get; set; }
	[Ordinal(5)] [RED("smoothStep")] public CFloat SmoothStep { get; set; }
	[Ordinal(6)] [RED("delay")] public CFloat Delay { get; set; }
	[Ordinal(7)] [RED("transformOutputs")] public CArray<animSimpleBounceTransformOutput> TransformOutputs { get; set; }
	public animAnimNode_SimpleBounce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_QuaternionConstant : CVariable
{
	[Ordinal(0)] [RED("value")] public Quaternion Value { get; set; }
	public animAnimNode_QuaternionConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCommunitySpawnSetNameToID : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<gameCommunitySpawnSetNameToIDEntry> Entries { get; set; }
	public gameCommunitySpawnSetNameToID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalOnscreenGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalOnscreenGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workEquipInventoryWeaponAction : CVariable
{
	[Ordinal(0)] [RED("weaponType")] public workWeaponType WeaponType { get; set; }
	[Ordinal(1)] [RED("keepEquippedAfterExit")] public CBool KeepEquippedAfterExit { get; set; }
	public workEquipInventoryWeaponAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AnimDatabase : CVariable
{
	[Ordinal(0)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(1)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(2)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(3)] [RED("animDataBase")] public animAnimDatabaseCollectionEntry AnimDataBase { get; set; }
	[Ordinal(4)] [RED("inputLinks")] public CArray<animIntLink> InputLinks { get; set; }
	public animAnimNode_AnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetEntityDistanceInterruptCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckPlayerTargetEntityDistanceInterruptConditionParams Params { get; set; }
	public scnCheckPlayerTargetEntityDistanceInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsInVehicle : CVariable
{
	public IsInVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorColorOverLife : CVariable
{
	[Ordinal(0)] [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }
	public CParticleModificatorColorOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ChromaticAberrationAreaSettings : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	[Ordinal(1)] [RED("chromaticAberrationOffset")] public CFloat ChromaticAberrationOffset { get; set; }
	[Ordinal(2)] [RED("chromaticAberrationExp")] public CFloat ChromaticAberrationExp { get; set; }
	public ChromaticAberrationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTriggerCondition : CVariable
{
	[Ordinal(0)] [RED("triggerAreaRef")] public NodeRef TriggerAreaRef { get; set; }
	public questTriggerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TranslateBone : CVariable
{
	[Ordinal(0)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(1)] [RED("inputTranslation")] public animVectorLink InputTranslation { get; set; }
	[Ordinal(2)] [RED("bone")] public animTransformIndex Bone { get; set; }
	public animAnimNode_TranslateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableType : CVariable
{
	public animMotionTableType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIMoveToCoverCommandParams : CVariable
{
	[Ordinal(0)] [RED("coverNodeRef")] public NodeRef CoverNodeRef { get; set; }
	public AIMoveToCoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BoolVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	public animAnimNode_BoolVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTeleportPuppetParamsV1 : CVariable
{
	[Ordinal(0)] [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }
	public questTeleportPuppetParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShiftTime_NodeType : CVariable
{
	[Ordinal(0)] [RED("preventVisualGlitch")] public CBool PreventVisualGlitch { get; set; }
	[Ordinal(1)] [RED("seconds")] public CUInt32 Seconds { get; set; }
	public questShiftTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionMoveTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("movementTarget")] public CHandle<AIArgumentMapping> MovementTarget { get; set; }
	[Ordinal(2)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
	[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
	[Ordinal(4)] [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
	[Ordinal(5)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	[Ordinal(7)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
	[Ordinal(8)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
	[Ordinal(9)] [RED("destinationTangent")] public CHandle<AIArgumentMapping> DestinationTangent { get; set; }
	[Ordinal(10)] [RED("startTangent")] public CHandle<AIArgumentMapping> StartTangent { get; set; }
	[Ordinal(11)] [RED("spotReservation")] public CHandle<AIArgumentMapping> SpotReservation { get; set; }
	[Ordinal(12)] [RED("ignoreRestrictedArea")] public CHandle<AIArgumentMapping> IgnoreRestrictedArea { get; set; }
	public AIbehaviorActionMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsAttachToGameObjectParams : CVariable
{
	[Ordinal(0)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	[Ordinal(1)] [RED("visualizerStyle")] public scnChoiceNodeNsVisualizerStyle VisualizerStyle { get; set; }
	public scnChoiceNodeNsAttachToGameObjectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFinalBoardsOpenSpeakerScreen_NodeType : CVariable
{
	[Ordinal(0)] [RED("openSpeakerScreen")] public CBool OpenSpeakerScreen { get; set; }
	[Ordinal(1)] [RED("speakerName")] public CString SpeakerName { get; set; }
	public questFinalBoardsOpenSpeakerScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animHasAnimationCondition : CVariable
{
	[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
	public animHasAnimationCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workPauseClip : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("timeMin")] public CFloat TimeMin { get; set; }
	[Ordinal(2)] [RED("timeMax")] public CFloat TimeMax { get; set; }
	[Ordinal(3)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	public workPauseClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameVisionModePatternType : CVariable
{
	public gameVisionModePatternType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EulerAngles : CVariable
{
	[Ordinal(0)] [RED("Pitch")] public CFloat Pitch { get; set; }
	[Ordinal(1)] [RED("Yaw")] public CFloat Yaw { get; set; }
	[Ordinal(2)] [RED("Roll")] public CFloat Roll { get; set; }
	public EulerAngles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestUIEffectEvent : CVariable
{
	[Ordinal(0)] [RED("glitch")] public CBool Glitch { get; set; }
	public VehicleQuestUIEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimAnchorInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(2)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimAnchorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_KeyPose : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_KeyPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleWeaponEnabled_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questToggleWeaponEnabled_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAmbientGroupingVariant : CVariable
{
	public audioAmbientGroupingVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AuthorizePlayerInSecuritySystem : CVariable
{
	public AuthorizePlayerInSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class locVoiceoverExpression : CVariable
{
	public locVoiceoverExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnVehicleMoveOnSpline_Overrides : CVariable
{
	[Ordinal(0)] [RED("useExit")] public CBool UseExit { get; set; }
	[Ordinal(1)] [RED("exitSpeed")] public CFloat ExitSpeed { get; set; }
	[Ordinal(2)] [RED("exitTransform")] public Transform ExitTransform { get; set; }
	[Ordinal(3)] [RED("exitMarker")] public scnMarker ExitMarker { get; set; }
	public scnVehicleMoveOnSpline_Overrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFlatheadSetSoloModeCommandParams : CVariable
{
	[Ordinal(0)] [RED("soloMode")] public CBool SoloMode { get; set; }
	public AIFlatheadSetSoloModeCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TogglePreventionSystem : CVariable
{
	[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
	public TogglePreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterSkinParameters : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("skinProfile")] public rRef<CSkinProfile> SkinProfile { get; set; }
	public CMaterialParameterSkinParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindanceRewinding_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindanceRewinding_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatRandom : CVariable
{
	[Ordinal(0)] [RED("max")] public CFloat Max { get; set; }
	public animAnimNode_FloatRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableTimeCallbacks : CVariable
{
	public DisableTimeCallbacks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckTriggerReturnCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckTriggerReturnConditionParams Params { get; set; }
	public scnCheckTriggerReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorVectorRandomUniform : CVariable
{
	[Ordinal(0)] [RED("min")] public Vector4 Min { get; set; }
	[Ordinal(1)] [RED("max")] public Vector4 Max { get; set; }
	public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCoverDefinition : CVariable
{
	public gameCoverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WaitBeforeExiting : CVariable
{
	public WaitBeforeExiting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIBackgroundCombatDelegate : CVariable
{
	public AIBackgroundCombatDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TeleportFailsafeHelper : CVariable
{
	public TeleportFailsafeHelper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterAttack_ConditionType : CVariable
{
	[Ordinal(0)] [RED("attackerRef")] public gameEntityReference AttackerRef { get; set; }
	[Ordinal(1)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	public questCharacterAttack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectVectorEvaluator_HitDirection : CVariable
{
	[Ordinal(0)] [RED("modifier")] public CFloat Modifier { get; set; }
	public gameEffectVectorEvaluator_HitDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowWorldNode_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	public questShowWorldNode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIInjectCombatThreatCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }
	public AIInjectCombatThreatCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalEntry_ConditionType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("state")] public gameJournalEntryUserState State { get; set; }
	public questJournalEntry_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ContactShadowsConfig : CVariable
{
	[Ordinal(0)] [RED("rangeLimit")] public CFloat RangeLimit { get; set; }
	[Ordinal(1)] [RED("screenEdgeFadeRange")] public CFloat ScreenEdgeFadeRange { get; set; }
	[Ordinal(2)] [RED("distanceFadeLimit")] public CFloat DistanceFadeLimit { get; set; }
	[Ordinal(3)] [RED("distanceFadeRange")] public CFloat DistanceFadeRange { get; set; }
	public ContactShadowsConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsDespawnEntityEventParams : CVariable
{
	[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }
	public scneventsDespawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorkspotWeaponConditionEnum : CVariable
{
	public WorkspotWeaponConditionEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StaticSwitch : CVariable
{
	[Ordinal(0)] [RED("condition")] public CHandle<animIStaticCondition> Condition { get; set; }
	[Ordinal(1)] [RED("True")] public animPoseLink True { get; set; }
	[Ordinal(2)] [RED("False")] public animPoseLink False { get; set; }
	public animAnimNode_StaticSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendOverride : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
	[Ordinal(1)] [RED("overrideInputNode")] public animPoseLink OverrideInputNode { get; set; }
	[Ordinal(2)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	[Ordinal(3)] [RED("blendMethod")] public CHandle<animIPoseBlendMethod> BlendMethod { get; set; }
	public animAnimNode_BlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAnimName : CVariable
{
	public scnAnimName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentEffectResource : CVariable
{
	[Ordinal(0)] [RED("Name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("BodyPartMask")] public physicsRagdollBodyPartE BodyPartMask { get; set; }
	[Ordinal(2)] [RED("Offset")] public Transform Offset { get; set; }
	[Ordinal(3)] [RED("ResourceSets")] public entdismembermentResourceSetMask ResourceSets { get; set; }
	[Ordinal(4)] [RED("WoundType")] public entdismembermentWoundTypeE WoundType { get; set; }
	[Ordinal(5)] [RED("Effect")] public raRef<worldEffect> Effect { get; set; }
	public entdismembermentEffectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneTime : CVariable
{
	[Ordinal(0)] [RED("stu")] public CUInt32 Stu { get; set; }
	public scnSceneTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetCustomShootPosition : CVariable
{
	[Ordinal(0)] [RED("offset")] public Vector3 Offset { get; set; }
	[Ordinal(1)] [RED("fxOffset")] public Vector3 FxOffset { get; set; }
	[Ordinal(2)] [RED("lockTimer")] public CFloat LockTimer { get; set; }
	[Ordinal(3)] [RED("landIndicatorFX")] public gameFxResource LandIndicatorFX { get; set; }
	public SetCustomShootPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInt32ValueWrapper : CVariable
{
	[Ordinal(0)] [RED("valueProvider")] public CHandle<questIInt32ValueProvider> ValueProvider { get; set; }
	public questInt32ValueWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentObjectValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentObjectValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCHotSpotGameLogicFilterDefinition : CVariable
{
	public gameinteractionsCHotSpotGameLogicFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectDuration_Infinite : CVariable
{
	public gameEffectDuration_Infinite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_DirectConnConstraint : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("sourceTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform { get; set; }
	[Ordinal(2)] [RED("isSourceTransformResaved")] public CBool IsSourceTransformResaved { get; set; }
	[Ordinal(3)] [RED("sourceTransformIndex")] public animTransformIndex SourceTransformIndex { get; set; }
	[Ordinal(4)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(5)] [RED("posZ")] public CBool PosZ { get; set; }
	public animAnimNode_DirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDistanceToExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("target")] public CHandle<AIbehaviorExpressionSocket> Target { get; set; }
	[Ordinal(1)] [RED("updatePeriod")] public CFloat UpdatePeriod { get; set; }
	public AIbehaviorDistanceToExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsEquipItemToPerformer : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(4)] [RED("slotId")] public TweakDBID SlotId { get; set; }
	[Ordinal(5)] [RED("itemId")] public TweakDBID ItemId { get; set; }
	public scneventsEquipItemToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSectorEntry : CVariable
{
	[Ordinal(0)] [RED("sectorBounds")] public Box SectorBounds { get; set; }
	[Ordinal(1)] [RED("entrySize")] public CUInt32 EntrySize { get; set; }
	public physicsSectorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGatherTriggerCondition : CVariable
{
	[Ordinal(0)] [RED("triggerAreaRef")] public NodeRef TriggerAreaRef { get; set; }
	public questGatherTriggerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerVelocitySpread : CVariable
{
	[Ordinal(0)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
	public CParticleInitializerVelocitySpread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workEquipItemToSlotAction : CVariable
{
	[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }
	[Ordinal(1)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }
	public workEquipItemToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldOffMeshSmartObjectUserData : CVariable
{
	[Ordinal(0)] [RED("nodeTransform")] public WorldTransform NodeTransform { get; set; }
	[Ordinal(1)] [RED("localSpaceTrajectoryStartPoint")] public Vector3 LocalSpaceTrajectoryStartPoint { get; set; }
	[Ordinal(2)] [RED("localSpaceTrajectoryEndPoint")] public Vector3 LocalSpaceTrajectoryEndPoint { get; set; }
	[Ordinal(3)] [RED("smartObjectDefinition")] public CHandle<gameSmartObjectDefinition> SmartObjectDefinition { get; set; }
	[Ordinal(4)] [RED("type")] public worldOffMeshConnectionType Type { get; set; }
	public worldOffMeshSmartObjectUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkPhaseAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(2)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(3)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(4)] [RED("convertToAdditive")] public CBool ConvertToAdditive { get; set; }
	[Ordinal(5)] [RED("phase")] public CName Phase { get; set; }
	public animAnimNode_SkPhaseAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ThrowGrenadeCommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ThrowGrenadeCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class AIbehaviorMappingConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("isInverted")] public CBool IsInverted { get; set; }
	[Ordinal(1)] [RED("value")] public CHandle<AIArgumentMapping> Value { get; set; }
	public AIbehaviorMappingConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FilterTargetsByDistanceFromRoot : CVariable
{
	public FilterTargetsByDistanceFromRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCameraFocus_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("timeInterval")] public CFloat TimeInterval { get; set; }
	[Ordinal(2)] [RED("onScreenTest")] public CBool OnScreenTest { get; set; }
	[Ordinal(3)] [RED("angleTolerance")] public CFloat AngleTolerance { get; set; }
	[Ordinal(4)] [RED("inverted")] public CBool Inverted { get; set; }
	public questCameraFocus_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SlotReservationDecorator : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	public SlotReservationDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorColorRandom : CVariable
{
	[Ordinal(0)] [RED("min")] public CColor Min { get; set; }
	[Ordinal(1)] [RED("randomPerChannel")] public CBool RandomPerChannel { get; set; }
	public CEvaluatorColorRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckAnyoneDistractedInterruptCondition : CVariable
{
	public scnCheckAnyoneDistractedInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsInTrafficLane : CVariable
{
	public IsInTrafficLane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIBackgroundCombatCommandParams : CVariable
{
	public AIBackgroundCombatCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSendAICommandNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
	[Ordinal(3)] [RED("commandParams")] public CHandle<questAICommandParams> CommandParams { get; set; }
	public questSendAICommandNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckStatusEffectState : CVariable
{
	[Ordinal(0)] [RED("statusEffectType")] public gamedataStatusEffectType StatusEffectType { get; set; }
	public CheckStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISetSoloModeHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AISetSoloModeHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIPatrolPathParameters : CVariable
{
	[Ordinal(0)] [RED("path")] public NodeRef Path { get; set; }
	[Ordinal(1)] [RED("patrolWithWeapon")] public CBool PatrolWithWeapon { get; set; }
	[Ordinal(2)] [RED("isBackAndForth")] public CBool IsBackAndForth { get; set; }
	public AIPatrolPathParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEventsContainer : CVariable
{
	[Ordinal(0)] [RED("events")] public CArray<CHandle<animAnimEvent>> Events { get; set; }
	public animEventsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveJoinTrafficTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveJoinTrafficTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EnvironmentColorGroupsSettings : CVariable
{
	public EnvironmentColorGroupsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetGroupsAttitude : CVariable
{
	[Ordinal(0)] [RED("group1Name")] public CName Group1Name { get; set; }
	[Ordinal(1)] [RED("group2Name")] public CName Group2Name { get; set; }
	[Ordinal(2)] [RED("attitude")] public EAIAttitude Attitude { get; set; }
	public questCharacterManagerParameters_SetGroupsAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAcousticSectorNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("data")] public raRef<worldAcousticDataResource> Data { get; set; }
	[Ordinal(2)] [RED("inSectorCoordsX")] public CUInt32 InSectorCoordsX { get; set; }
	[Ordinal(3)] [RED("inSectorCoordsZ")] public CUInt32 InSectorCoordsZ { get; set; }
	[Ordinal(4)] [RED("generatorId")] public CUInt32 GeneratorId { get; set; }
	public worldAcousticSectorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBlockTokenActivation_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("action")] public questBlockAction Action { get; set; }
	[Ordinal(1)] [RED("source")] public CName Source { get; set; }
	public questBlockTokenActivation_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_SceneItem : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_SceneItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorJoinFollowerSquadWithTargetDefinition : CVariable
{
	[Ordinal(0)] [RED("follower")] public CHandle<AIArgumentMapping> Follower { get; set; }
	public AIbehaviorJoinFollowerSquadWithTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkSyncedMasterAnimByTime : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(2)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(3)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
	[Ordinal(4)] [RED("timeLink")] public animFloatLink TimeLink { get; set; }
	public animAnimNode_SkSyncedMasterAnimByTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animBoolLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_BoolValue> Node { get; set; }
	public animBoolLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsUniqueNodeData : CVariable
{
	[Ordinal(0)] [RED("className")] public CName ClassName { get; set; }
	public toolsUniqueNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIMoveToCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	[Ordinal(1)] [RED("outIsDynamicMove")] public CHandle<AIArgumentMapping> OutIsDynamicMove { get; set; }
	[Ordinal(2)] [RED("outMovementTarget")] public CHandle<AIArgumentMapping> OutMovementTarget { get; set; }
	[Ordinal(3)] [RED("outMovementTargetPos")] public CHandle<AIArgumentMapping> OutMovementTargetPos { get; set; }
	[Ordinal(4)] [RED("outRotateEntityTowardsFacingTarget")] public CHandle<AIArgumentMapping> OutRotateEntityTowardsFacingTarget { get; set; }
	[Ordinal(5)] [RED("outFacingTarget")] public CHandle<AIArgumentMapping> OutFacingTarget { get; set; }
	[Ordinal(6)] [RED("outMovementType")] public CHandle<AIArgumentMapping> OutMovementType { get; set; }
	[Ordinal(7)] [RED("outIgnoreNavigation")] public CHandle<AIArgumentMapping> OutIgnoreNavigation { get; set; }
	[Ordinal(8)] [RED("outUseStart")] public CHandle<AIArgumentMapping> OutUseStart { get; set; }
	[Ordinal(9)] [RED("outUseStop")] public CHandle<AIArgumentMapping> OutUseStop { get; set; }
	[Ordinal(10)] [RED("outDesiredDistanceFromTarget")] public CHandle<AIArgumentMapping> OutDesiredDistanceFromTarget { get; set; }
	[Ordinal(11)] [RED("outFinishWhenDestinationReached")] public CHandle<AIArgumentMapping> OutFinishWhenDestinationReached { get; set; }
	public AIMoveToCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentWoundResource : CVariable
{
	[Ordinal(0)] [RED("Name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("BodyPart")] public physicsRagdollBodyPartE BodyPart { get; set; }
	[Ordinal(2)] [RED("CullObject")] public entdismembermentCullObject CullObject { get; set; }
	[Ordinal(3)] [RED("GarmentMorphStrength")] public CFloat GarmentMorphStrength { get; set; }
	[Ordinal(4)] [RED("Resources")] public CArray<entdismembermentWoundMeshes> Resources { get; set; }
	[Ordinal(5)] [RED("Decals")] public CArray<entdismembermentWoundDecal> Decals { get; set; }
	[Ordinal(6)] [RED("CensoredPaths")] public CArray<CUInt64> CensoredPaths { get; set; }
	[Ordinal(7)] [RED("CensoredCookedPaths")] public CArray<raRef<CResource>> CensoredCookedPaths { get; set; }
	public entdismembermentWoundResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SpringDamp : CVariable
{
	[Ordinal(0)] [RED("springFactor")] public CFloat SpringFactor { get; set; }
	[Ordinal(1)] [RED("dampFactor")] public CFloat DampFactor { get; set; }
	[Ordinal(2)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
	[Ordinal(3)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
	[Ordinal(4)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_SpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ThrowGrenadeCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ThrowGrenadeCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DeathIsRagdollCondition : CVariable
{
	public DeathIsRagdollCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckTriggerInterruptConditionParams : CVariable
{
	[Ordinal(0)] [RED("triggerArea")] public NodeRef TriggerArea { get; set; }
	public scnCheckTriggerInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStimuli_ConditionType : CVariable
{
	[Ordinal(0)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	[Ordinal(1)] [RED("type")] public gamedataStimType Type { get; set; }
	public questStimuli_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFinalBoardsVideosFinished_NodeType : CVariable
{
	public questFinalBoardsVideosFinished_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSimpleParameterizedBehavior : CVariable
{
	[Ordinal(0)] [RED("treeDefinition")] public rRef<AIbehaviorResource> TreeDefinition { get; set; }
	public AIbehaviorSimpleParameterizedBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GetCurrentPatrolSpotActionPath : CVariable
{
	[Ordinal(0)] [RED("outPathArgument")] public CHandle<AIArgumentMapping> OutPathArgument { get; set; }
	public GetCurrentPatrolSpotActionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetPhoneRestriction_NodeType : CVariable
{
	public questSetPhoneRestriction_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BlindManagerTask : CVariable
{
	public BlindManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameDeviceResourceData : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	public gameDeviceResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorTypeRef : CVariable
{
	[Ordinal(0)] [RED("isSet")] public CBool IsSet { get; set; }
	[Ordinal(1)] [RED("customType")] public CName CustomType { get; set; }
	public AIbehaviorTypeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckArgumentBoolean : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("customVar")] public CBool CustomVar { get; set; }
	public CheckArgumentBoolean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkETextureResolution : CVariable
{
	public inkETextureResolution(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAddBraindanceClue_NodeType : CVariable
{
	[Ordinal(0)] [RED("clueName")] public CName ClueName { get; set; }
	[Ordinal(1)] [RED("startTime")] public CFloat StartTime { get; set; }
	[Ordinal(2)] [RED("endTime")] public CFloat EndTime { get; set; }
	[Ordinal(3)] [RED("layer")] public gameuiEBraindanceLayer Layer { get; set; }
	public questAddBraindanceClue_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsConnectedToSecuritySystem : CVariable
{
	public IsConnectedToSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Variant : CVariable
{
	public Variant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AdditionalFloatTrack : CVariable
{
	[Ordinal(0)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
	[Ordinal(1)] [RED("additionalTracks")] public animAdditionalFloatTrackContainer AdditionalTracks { get; set; }
	public animAnimNode_AdditionalFloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalOnscreen : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
	[Ordinal(3)] [RED("description")] public LocalizationString Description { get; set; }
	public gameJournalOnscreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerColor : CVariable
{
	[Ordinal(0)] [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }
	public CParticleInitializerColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerFacingTrail : CVariable
{
	[Ordinal(0)] [RED("dynamicTexCoords")] public CBool DynamicTexCoords { get; set; }
	[Ordinal(1)] [RED("minSegmentsPer360Degrees")] public CInt32 MinSegmentsPer360Degrees { get; set; }
	public CParticleDrawerFacingTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PaymentFixedAmount_ScriptConditionType : CVariable
{
	[Ordinal(0)] [RED("payAmount")] public CUInt32 PayAmount { get; set; }
	public PaymentFixedAmount_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InjectCombatTargetCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public InjectCombatTargetCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnFastForwardStrategy : CVariable
{
	public scnFastForwardStrategy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsClueEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(3)] [RED("clueEntity")] public gameEntityReference ClueEntity { get; set; }
	[Ordinal(4)] [RED("clueName")] public CName ClueName { get; set; }
	[Ordinal(5)] [RED("overrideFact")] public CBool OverrideFact { get; set; }
	public scneventsClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStatsCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIStatsConditionType> Type { get; set; }
	public questStatsCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnerReady_ConditionType : CVariable
{
	[Ordinal(0)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
	public questSpawnerReady_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetMortality : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	public questCharacterManagerParameters_SetMortality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindancePlaying_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindancePlaying_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleWindowState : CVariable
{
	public VehicleWindowState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLifePath_ConditionType : CVariable
{
	[Ordinal(0)] [RED("scriptCondition")] public CHandle<IScriptable> ScriptCondition { get; set; }
	public questLifePath_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_OnlyNearest_Pierce : CVariable
{
	[Ordinal(0)] [RED("alwaysApplyFullWeaponCharge")] public CBool AlwaysApplyFullWeaponCharge { get; set; }
	public gameEffectObjectFilter_OnlyNearest_Pierce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsBasicLookAtParams : CVariable
{
	[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
	public scnChoiceNodeNsBasicLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandDeescalation : CVariable
{
	public ReprimandDeescalation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DressPlayer : CVariable
{
	public DressPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsEClothCollisionMaskEnum : CVariable
{
	public physicsEClothCollisionMaskEnum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetSecuritySystemState : CVariable
{
	[Ordinal(0)] [RED("state")] public ESecuritySystemState State { get; set; }
	public SetSecuritySystemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneSolutionHashHash : CVariable
{
	[Ordinal(0)] [RED("sceneSolutionHashDate")] public CUInt64 SceneSolutionHashDate { get; set; }
	public scnSceneSolutionHashHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayerLookAt_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(2)] [RED("endOnCameraInputApplied")] public CBool EndOnCameraInputApplied { get; set; }
	[Ordinal(3)] [RED("maxDuration")] public CFloat MaxDuration { get; set; }
	public questPlayerLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentPlacementE : CVariable
{
	public entdismembermentPlacementE(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlaySpeed : CVariable
{
	public scnPlaySpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimStopAnimEvent : CVariable
{
	[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
	public inkanimStopAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetCyberspacePostFX_NodeType : CVariable
{
	[Ordinal(0)] [RED("fullScreen")] public CBool FullScreen { get; set; }
	public questSetCyberspacePostFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPerformerId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnPerformerId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsPlayerNotInteractingWithDevice : CVariable
{
	public IsPlayerNotInteractingWithDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDebugFailsafeConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("logMessage")] public CHandle<AIArgumentMapping> LogMessage { get; set; }
	public AIbehaviorDebugFailsafeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class AIbehaviorFSMTransitionDefinition : CVariable
{
	[Ordinal(0)] [RED("inState")] public CUInt16 InState { get; set; }
	[Ordinal(1)] [RED("monitorConditions")] public CArray<CHandle<AIbehaviorMonitorConditionDefinition>> MonitorConditions { get; set; }
	public AIbehaviorFSMTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_CriticalSpringDamp : CVariable
{
	[Ordinal(0)] [RED("smoothTime")] public CFloat SmoothTime { get; set; }
	[Ordinal(1)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_CriticalSpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEAnimGraphLogicOp : CVariable
{
	public animEAnimGraphLogicOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimEffectInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("startValue")] public CFloat StartValue { get; set; }
	[Ordinal(3)] [RED("endValue")] public CFloat EndValue { get; set; }
	[Ordinal(4)] [RED("paramName")] public CName ParamName { get; set; }
	public inkanimEffectInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterCpuNameU64 : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	public CMaterialParameterCpuNameU64(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class WorldLightingConfig : CVariable
{
	[Ordinal(0)] [RED("lightAttenuationClamp")] public CFloat LightAttenuationClamp { get; set; }
	public WorldLightingConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsLootContainer : CVariable
{
	[Ordinal(0)] [RED("invert")] public CBool Invert { get; set; }
	public IsLootContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRecordSelector : CVariable
{
	public questRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AnimFeature_MeleeAttack : CVariable
{
	[Ordinal(0)] [RED("hit")] public CBool Hit { get; set; }
	public AnimFeature_MeleeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsInteractionDescriptorResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("definition")] public gameinteractionsCHotSpotDefinition Definition { get; set; }
	public gameinteractionsInteractionDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FollowerFindTeleportPositionAroundTarget : CVariable
{
	[Ordinal(0)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(1)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
	public FollowerFindTeleportPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetVar_NodeType : CVariable
{
	[Ordinal(0)] [RED("factName")] public CString FactName { get; set; }
	[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }
	[Ordinal(2)] [RED("setExactValue")] public CBool SetExactValue { get; set; }
	public questSetVar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DropPointRequest : CVariable
{
	[Ordinal(0)] [RED("record")] public TweakDBID Record { get; set; }
	[Ordinal(1)] [RED("status")] public DropPointPackageStatus Status { get; set; }
	public DropPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterruptManagerNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
	public scnInterruptManagerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerVisuals_PrefetchEntityAppearance : CVariable
{
	[Ordinal(0)] [RED("appearanceEntries")] public CArray<questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry> AppearanceEntries { get; set; }
	public questCharacterManagerVisuals_PrefetchEntityAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCameraClippingPlane_NodeType : CVariable
{
	[Ordinal(0)] [RED("preset")] public questCameraPlanesPreset Preset { get; set; }
	public questCameraClippingPlane_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MixerSlot : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_MixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestToggleEngineEvent : CVariable
{
	[Ordinal(0)] [RED("toggle")] public CBool Toggle { get; set; }
	public VehicleQuestToggleEngineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakersDistanceInterruptConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	public scnCheckSpeakersDistanceInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsVisibleTargetPredicate : CVariable
{
	[Ordinal(0)] [RED("stopOnTransparent")] public CBool StopOnTransparent { get; set; }
	public gameinteractionsVisibleTargetPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NPCIncapacitatedPrereq : CVariable
{
	public NPCIncapacitatedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSensesCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questISensesConditionType> Type { get; set; }
	public questSensesCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameWorldBoundaryNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	public gameWorldBoundaryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMappinState_ConditionType : CVariable
{
	[Ordinal(0)] [RED("mappinPath")] public CHandle<gameJournalPath> MappinPath { get; set; }
	public questMappinState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRidCameraAnimationSRRefId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnRidCameraAnimationSRRefId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendLightGroup : CVariable
{
	public rendLightGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UpdateDyingStimSource : CVariable
{
	public UpdateDyingStimSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_MuteBubble : CVariable
{
	public EffectExecutor_MuteBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficCompiledNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("aabb")] public Box Aabb { get; set; }
	public worldTrafficCompiledNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBehind_ConditionType : CVariable
{
	[Ordinal(0)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	[Ordinal(1)] [RED("eventType")] public questBehindInteractionEventType EventType { get; set; }
	public questBehind_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleEQuestVehicleDoorState : CVariable
{
	public vehicleEQuestVehicleDoorState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questOpenPhotoMode_NodeType : CVariable
{
	[Ordinal(0)] [RED("factName")] public CString FactName { get; set; }
	[Ordinal(1)] [RED("alwaysAllowTPP")] public CBool AlwaysAllowTPP { get; set; }
	[Ordinal(2)] [RED("lockExitUntilScreenshot")] public CBool LockExitUntilScreenshot { get; set; }
	public questOpenPhotoMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestType : CVariable
{
	public gameJournalQuestType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAudioEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(3)] [RED("audioEventName")] public CName AudioEventName { get; set; }
	[Ordinal(4)] [RED("emitterName")] public CName EmitterName { get; set; }
	public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkMenuResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("menusEntries")] public CArray<inkMenuEntry> MenusEntries { get; set; }
	[Ordinal(2)] [RED("scenariosNames")] public CArray<CName> ScenariosNames { get; set; }
	[Ordinal(3)] [RED("initialScenarioName")] public CName InitialScenarioName { get; set; }
	public inkMenuResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowCustomTooltip_NodeType : CVariable
{
	[Ordinal(0)] [RED("text")] public LocalizationString Text { get; set; }
	[Ordinal(1)] [RED("inputAction")] public CString InputAction { get; set; }
	public questShowCustomTooltip_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetBonePosition : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("bone")] public animTransformIndex Bone { get; set; }
	[Ordinal(5)] [RED("positionMs")] public animVectorLink PositionMs { get; set; }
	public animAnimNode_SetBonePosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entragdollActivationRequestType : CVariable
{
	public entragdollActivationRequestType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamemappinsCommonVariant : CVariable
{
	[Ordinal(0)] [RED("variant")] public gamedataMappinVariant Variant { get; set; }
	public gamemappinsCommonVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISquadType : CVariable
{
	public AISquadType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_PointConstraint : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("inputTransforms")] public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> InputTransforms { get; set; }
	[Ordinal(2)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNode_PointConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnlocLocStoreEmbedded : CVariable
{
	[Ordinal(0)] [RED("vdEntries")] public CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> VdEntries { get; set; }
	[Ordinal(1)] [RED("vpEntries")] public CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> VpEntries { get; set; }
	public scnlocLocStoreEmbedded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ERenderMaterialType : CVariable
{
	public ERenderMaterialType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animClampType : CVariable
{
	public animClampType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsFriendlyToPlayer : CVariable
{
	public IsFriendlyToPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetContainerStateEvent : CVariable
{
	[Ordinal(0)] [RED("isDisabled")] public CBool IsDisabled { get; set; }
	public SetContainerStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questParamRubberbanding : CVariable
{
	[Ordinal(0)] [RED("targetRef")] public CHandle<questUniversalRef> TargetRef { get; set; }
	public questParamRubberbanding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDyngConstraintCone : CVariable
{
	[Ordinal(0)] [RED("constrainedBone")] public animTransformIndex ConstrainedBone { get; set; }
	[Ordinal(1)] [RED("coneAttachmentBone")] public animTransformIndex ConeAttachmentBone { get; set; }
	[Ordinal(2)] [RED("coneTransformLS")] public QsTransform ConeTransformLS { get; set; }
	[Ordinal(3)] [RED("constraintType")] public animPendulumConstraintType ConstraintType { get; set; }
	[Ordinal(4)] [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
	public animDyngConstraintCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EquipSecondaryWeaponCommandDelegate : CVariable
{
	public EquipSecondaryWeaponCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questComparisonParam : CVariable
{
	[Ordinal(0)] [RED("entireCommunity")] public CBool EntireCommunity { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questComparisonParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterHairParameters : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("hairProfile")] public rRef<CHairProfile> HairProfile { get; set; }
	public CMaterialParameterHairParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderParticleBlobHeader : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(1)] [RED("emitterInfo")] public rendRenderParticleBlobEmitterInfo EmitterInfo { get; set; }
	public rendRenderParticleBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLootTokenManager_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questLootTokenManager_NodeTypeParams> Params { get; set; }
	public questLootTokenManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AnimSetTagValue : CVariable
{
	[Ordinal(0)] [RED("tags")] public redTagList Tags { get; set; }
	public animAnimNode_AnimSetTagValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamCloth : CVariable
{
	[Ordinal(0)] [RED("lodChunkIndices")] public CArray<CArray<CUInt16>> LodChunkIndices { get; set; }
	[Ordinal(1)] [RED("chunks")] public CArray<meshPhxClothChunkData> Chunks { get; set; }
	public meshMeshParamCloth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetHUDEntryForcedVisibility_NodeType : CVariable
{
	[Ordinal(0)] [RED("usePreset")] public CBool UsePreset { get; set; }
	[Ordinal(1)] [RED("hudVisibilityPreset")] public TweakDBID HudVisibilityPreset { get; set; }
	[Ordinal(2)] [RED("visibility")] public worlduiEntryVisibility Visibility { get; set; }
	public questSetHUDEntryForcedVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlatform : CVariable
{
	public questPlatform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorStoryTierConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("tier")] public gameStoryTier Tier { get; set; }
	[Ordinal(1)] [RED("storyTier")] public CHandle<AIArgumentMapping> StoryTier { get; set; }
	public AIbehaviorStoryTierConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetFocusClueState_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("clueId")] public CInt32 ClueId { get; set; }
	[Ordinal(2)] [RED("clueState")] public CBool ClueState { get; set; }
	public questSetFocusClueState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionSlideToWorldPositionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
	[Ordinal(2)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	[Ordinal(3)] [RED("rotateTowardsMovementDirection")] public CHandle<AIArgumentMapping> RotateTowardsMovementDirection { get; set; }
	[Ordinal(4)] [RED("worldPosition")] public CHandle<AIArgumentMapping> WorldPosition { get; set; }
	[Ordinal(5)] [RED("useMovePlanner")] public CBool UseMovePlanner { get; set; }
	public AIbehaviorActionSlideToWorldPositionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EnableBraindanceActions : CVariable
{
	[Ordinal(0)] [RED("actionMask")] public SBraindanceInputMask ActionMask { get; set; }
	public EnableBraindanceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EmissiveColorSettings : CVariable
{
	public EmissiveColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_NewEffect_RicochetScan : CVariable
{
	[Ordinal(0)] [RED("tagInThisFile")] public CName TagInThisFile { get; set; }
	[Ordinal(1)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
	[Ordinal(2)] [RED("childEffect")] public CBool ChildEffect { get; set; }
	[Ordinal(3)] [RED("childEffectTag")] public CName ChildEffectTag { get; set; }
	[Ordinal(4)] [RED("box")] public Vector4 Box { get; set; }
	[Ordinal(5)] [RED("isPreview")] public CBool IsPreview { get; set; }
	public gameEffectExecutor_NewEffect_RicochetScan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEasingType : CVariable
{
	public scnEasingType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_ToggleDevice : CVariable
{
	public EffectExecutor_ToggleDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnerNotReady_ConditionType : CVariable
{
	[Ordinal(0)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
	public questSpawnerNotReady_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDefaultHighlightEvent : CVariable
{
	[Ordinal(0)] [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }
	public SetDefaultHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsEBinaryOperator : CVariable
{
	public gameinteractionsEBinaryOperator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("root")] public CHandle<AIbehaviorTreeNodeDefinition> Root { get; set; }
	public AIbehaviorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectSet : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("effects")] public CArray<gameEffectDefinition> Effects { get; set; }
	public gameEffectSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsCameraOverrideSettings : CVariable
{
	[Ordinal(0)] [RED("overrideDof")] public CBool OverrideDof { get; set; }
	public scneventsCameraOverrideSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamGarmentSupport : CVariable
{
	[Ordinal(0)] [RED("chunkCapVertices")] public CArray<CArray<CUInt32>> ChunkCapVertices { get; set; }
	[Ordinal(1)] [RED("customMorph")] public CBool CustomMorph { get; set; }
	public meshMeshParamGarmentSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStartNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questStartNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCollisionNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("compiledData")] public DataBuffer CompiledData { get; set; }
	[Ordinal(3)] [RED("numActors")] public CUInt16 NumActors { get; set; }
	[Ordinal(4)] [RED("numShapeInfos")] public CUInt16 NumShapeInfos { get; set; }
	[Ordinal(5)] [RED("numShapePositions")] public CUInt16 NumShapePositions { get; set; }
	[Ordinal(6)] [RED("numScales")] public CUInt16 NumScales { get; set; }
	[Ordinal(7)] [RED("numMaterials")] public CUInt16 NumMaterials { get; set; }
	[Ordinal(8)] [RED("numPresets")] public CUInt16 NumPresets { get; set; }
	[Ordinal(9)] [RED("numMaterialIndices")] public CUInt16 NumMaterialIndices { get; set; }
	[Ordinal(10)] [RED("numShapeIndices")] public CUInt16 NumShapeIndices { get; set; }
	[Ordinal(11)] [RED("sectorHash")] public CUInt64 SectorHash { get; set; }
	[Ordinal(12)] [RED("extents")] public Vector4 Extents { get; set; }
	[Ordinal(13)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
	public worldCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveCombatConditions : CVariable
{
	public PassiveCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckDistractedReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("target")] public scnDistractedConditionTarget Target { get; set; }
	public scnCheckDistractedReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IntVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	public animAnimNode_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ERevealPlayerType : CVariable
{
	public ERevealPlayerType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animIKTargetRequest : CVariable
{
	[Ordinal(0)] [RED("transitionIn")] public CFloat TransitionIn { get; set; }
	[Ordinal(1)] [RED("priority")] public CInt32 Priority { get; set; }
	public animIKTargetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestExecuteTransition : CVariable
{
	[Ordinal(0)] [RED("transition")] public AreaTypeTransition Transition { get; set; }
	public QuestExecuteTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_FootPhase : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("phase")] public animEFootPhase Phase { get; set; }
	public animAnimEvent_FootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveFollowPositionTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveFollowPositionTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveType : CVariable
{
	public questMoveType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetScanningTime_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("time")] public CFloat Time { get; set; }
	public questSetScanningTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransformAnimatorNode_Action_Skip : CVariable
{
	[Ordinal(0)] [RED("skipTo")] public CFloat SkipTo { get; set; }
	[Ordinal(1)] [RED("skipToEnd")] public CBool SkipToEnd { get; set; }
	public questTransformAnimatorNode_Action_Skip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEnvAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("blendTimeIn")] public CFloat BlendTimeIn { get; set; }
	[Ordinal(1)] [RED("blendTimeOut")] public CFloat BlendTimeOut { get; set; }
	[Ordinal(2)] [RED("params")] public WorldRenderAreaSettings Params { get; set; }
	public worldEnvAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInteriorMapNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(2)] [RED("coords")] public CUInt64 Coords { get; set; }
	[Ordinal(3)] [RED("buffer")] public serializationDeferredDataBuffer Buffer { get; set; }
	public worldInteriorMapNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFactsDBCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIFactsDBConditionType> Type { get; set; }
	public questFactsDBCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorldShadowConfig : CVariable
{
	[Ordinal(0)] [RED("distantShadowsNumLevels")] public CUInt32 DistantShadowsNumLevels { get; set; }
	[Ordinal(1)] [RED("distantShadowsBaseLevelRadius")] public CFloat DistantShadowsBaseLevelRadius { get; set; }
	public WorldShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataStimType : CVariable
{
	public gamedataStimType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class ApplyAnimWrappersOnWeapon : CVariable
{
	[Ordinal(0)] [RED("wrapperName")] public CName WrapperName { get; set; }
	public ApplyAnimWrappersOnWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCrowdManagerNodeType_ControlCrowd : CVariable
{
	[Ordinal(0)] [RED("action")] public questControlCrowdAction Action { get; set; }
	[Ordinal(1)] [RED("debugSource")] public CName DebugSource { get; set; }
	public questCrowdManagerNodeType_ControlCrowd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatConstant : CVariable
{
	[Ordinal(0)] [RED("value")] public CFloat Value { get; set; }
	public animAnimNode_FloatConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckFollowTarget : CVariable
{
	public CheckFollowTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetFOV_NodeType : CVariable
{
	[Ordinal(0)] [RED("FOV")] public CFloat FOV { get; set; }
	public questSetFOV_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionInterpolator_Blend : CVariable
{
	public animAnimStateTransitionInterpolator_Blend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectEffectParameterEvaluatorFloat : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorFloat> Evaluator { get; set; }
	public effectEffectParameterEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameTutorialBracketType : CVariable
{
	public gameTutorialBracketType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerSpawnCircle : CVariable
{
	[Ordinal(0)] [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
	[Ordinal(1)] [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
	public CParticleInitializerSpawnCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckTimestamp : CVariable
{
	[Ordinal(0)] [RED("validationTime")] public CFloat ValidationTime { get; set; }
	[Ordinal(1)] [RED("timestampArgument")] public CName TimestampArgument { get; set; }
	public CheckTimestamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workCoverTypeCondition : CVariable
{
	[Ordinal(0)] [RED("equals")] public CBool Equals { get; set; }
	[Ordinal(1)] [RED("isHighCover")] public CBool IsHighCover { get; set; }
	public workCoverTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animAnimEvent_Simple : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindanceLayer : CVariable
{
	public scnBraindanceLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questConditionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
	public questConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAssignRoleCommand : CVariable
{
	[Ordinal(0)] [RED("role")] public CHandle<AIRole> Role { get; set; }
	public AIAssignRoleCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DropPointPackageStatus : CVariable
{
	public DropPointPackageStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatTimeDependentSinus : CVariable
{
	[Ordinal(0)] [RED("frequencyFactor")] public CFloat FrequencyFactor { get; set; }
	public animAnimNode_FloatTimeDependentSinus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnscreenplayStore : CVariable
{
	[Ordinal(0)] [RED("lines")] public CArray<scnscreenplayDialogLine> Lines { get; set; }
	public scnscreenplayStore(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBehaviourManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("newType")] public CHandle<questIBehaviourManager_NodeType> NewType { get; set; }
	public questBehaviourManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkDurationAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(2)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(3)] [RED("Duration")] public animFloatLink Duration { get; set; }
	public animAnimNode_SkDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetInteractionState_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
	public questSetInteractionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGiveReward_NodeType : CVariable
{
	[Ordinal(0)] [RED("rewards")] public CArray<TweakDBID> Rewards { get; set; }
	public questGiveReward_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkPhaseWithDurationAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(2)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(3)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(4)] [RED("phase")] public CName Phase { get; set; }
	[Ordinal(5)] [RED("durationLink")] public animFloatLink DurationLink { get; set; }
	public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsVFXDurationEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
	[Ordinal(3)] [RED("endAction")] public scneventsVFXActionType EndAction { get; set; }
	[Ordinal(4)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	public scneventsVFXDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhaseFreezingAreaNotifier : CVariable
{
	public questPhaseFreezingAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestTitleModifier : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("title")] public LocalizationString Title { get; set; }
	public gameJournalQuestTitleModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIStackSignalCondition : CVariable
{
	[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }
	public AIStackSignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workExitAnim : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("isSynchronized")] public CBool IsSynchronized { get; set; }
	[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }
	[Ordinal(4)] [RED("syncOffset")] public Transform SyncOffset { get; set; }
	public workExitAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBriefingSequencePlayer_NodeType : CVariable
{
	[Ordinal(0)] [RED("briefingResource")] public raRef<inkWidgetLibraryResource> BriefingResource { get; set; }
	[Ordinal(1)] [RED("animationName")] public CName AnimationName { get; set; }
	[Ordinal(2)] [RED("startMarkerName")] public CName StartMarkerName { get; set; }
	[Ordinal(3)] [RED("endMarkerName")] public CName EndMarkerName { get; set; }
	public questBriefingSequencePlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVision_ConditionType : CVariable
{
	[Ordinal(0)] [RED("observerPuppetRef")] public gameEntityReference ObserverPuppetRef { get; set; }
	[Ordinal(1)] [RED("isInstant")] public CBool IsInstant { get; set; }
	public questVision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_ExternalEvent : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimStateTransitionCondition_ExternalEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlaceholderNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("replacedNodeClassName")] public CName ReplacedNodeClassName { get; set; }
	[Ordinal(3)] [RED("copiedSockets")] public CArray<questPlaceholderNodeSocketInfo> CopiedSockets { get; set; }
	[Ordinal(4)] [RED("clipboardHolder")] public CHandle<ISerializable> ClipboardHolder { get; set; }
	public questPlaceholderNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldVehicleForbiddenAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("innerAreaOutline")] public CHandle<AreaShapeOutline> InnerAreaOutline { get; set; }
	[Ordinal(1)] [RED("parkingSpots")] public CArray<NodeRef> ParkingSpots { get; set; }
	[Ordinal(2)] [RED("areaSpeedLimit")] public CFloat AreaSpeedLimit { get; set; }
	[Ordinal(3)] [RED("enableNullArea")] public CBool EnableNullArea { get; set; }
	[Ordinal(4)] [RED("dismount")] public CBool Dismount { get; set; }
	public worldVehicleForbiddenAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsFilterDataSource : CVariable
{
	public physicsFilterDataSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhaseNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("phaseGraph")] public CHandle<questGraphDefinition> PhaseGraph { get; set; }
	public questPhaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialTemplate : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("paramBlockSize", 3)] public CArrayFixedSize<CUInt32> ParamBlockSize { get; set; }
    [Ordinal(2)] [RED("materialVersion")] public CUInt8 MaterialVersion { get; set; }
    [Ordinal(3)] [RED("vertexFactories")] public CArray<CEnum<EMaterialVertexFactory>> VertexFactories { get; set; }
    [Ordinal(4)] [RED("name")] public CName Name { get; set; }
    [Ordinal(5)]  [RED("parameters", 3)] public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters { get; set; }
	[Ordinal(6)] [RED("techniques")] public CArray<MaterialTechnique> Techniques { get; set; }
    [Ordinal(7)]  [RED("samplerStates", 3)] public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates { get; set; }
	[Ordinal(8)]  [RED("usedParameters", 3)] public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters { get; set; }
	[Ordinal(9)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
public CMaterialTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPropId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnPropId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableObjectDescriptionEvent : CVariable
{
	public DisableObjectDescriptionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuest : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
	[Ordinal(3)] [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
	public gameJournalQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class visOccluderMeshResource : CVariable
{
	[Ordinal(0)] [RED("resourceHash")] public CUInt32 ResourceHash { get; set; }
	[Ordinal(1)] [RED("resourceVersion")] public CUInt32 ResourceVersion { get; set; }
	[Ordinal(2)] [RED("vertices")] public DataBuffer Vertices { get; set; }
	[Ordinal(3)] [RED("indices")] public DataBuffer Indices { get; set; }
	[Ordinal(4)] [RED("boundingBox")] public Box BoundingBox { get; set; }
	[Ordinal(5)] [RED("twoSided")] public CBool TwoSided { get; set; }
	public visOccluderMeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakAIActionCondition : CVariable
{
	[Ordinal(0)] [RED("record")] public TweakDBID Record { get; set; }
	public TweakAIActionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workLogicalOperation : CVariable
{
	public workLogicalOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsPlayerLookAtEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(3)] [RED("lookAtParams")] public scneventsPlayerLookAtEventParams LookAtParams { get; set; }
	public scneventsPlayerLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StrikeFilterSingle_NPC : CVariable
{
	[Ordinal(0)] [RED("onlyAlive")] public CBool OnlyAlive { get; set; }
	public StrikeFilterSingle_NPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SceneForceWeaponAim : CVariable
{
	public SceneForceWeaponAim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorTextureAnimation : CVariable
{
	[Ordinal(0)] [RED("initialFrame")] public CHandle<IEvaluatorFloat> InitialFrame { get; set; }
	[Ordinal(1)] [RED("animationSpeed")] public CHandle<IEvaluatorFloat> AnimationSpeed { get; set; }
	public CParticleModificatorTextureAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAdditionalSpeakerRole : CVariable
{
	public scnAdditionalSpeakerRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup_OneSermoPoseBufferInfo : CVariable
{
	[Ordinal(0)] [RED("numMainPoses")] public CUInt16 NumMainPoses { get; set; }
	[Ordinal(1)] [RED("numCorrectivePoses")] public CUInt16 NumCorrectivePoses { get; set; }
	[Ordinal(2)] [RED("numMainTransforms")] public CUInt32 NumMainTransforms { get; set; }
	[Ordinal(3)] [RED("numCorrectiveTransforms")] public CUInt32 NumCorrectiveTransforms { get; set; }
	public animFacialSetup_OneSermoPoseBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RootMotionCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	[Ordinal(1)] [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }
	public RootMotionCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ForegroundSegmentEnd : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("segmentBeginNodeId")] public CUInt32 SegmentBeginNodeId { get; set; }
	public animAnimNode_ForegroundSegmentEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRenderFxManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIRenderFxManagerNodeType> Type { get; set; }
	public questRenderFxManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HoldPositionCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public HoldPositionCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJumpWorkspotAnim_NodeType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("entryIdToJumpTo")] public CInt32 EntryIdToJumpTo { get; set; }
	public questJumpWorkspotAnim_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IncrimentStimThreshold : CVariable
{
	[Ordinal(0)] [RED("thresholdTimeout")] public CFloat ThresholdTimeout { get; set; }
	public IncrimentStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendLightAttenuation : CVariable
{
	public rendLightAttenuation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_ThrowGrenade : CVariable
{
	[Ordinal(0)] [RED("targetOverridePuppet")] public gameEntityReference TargetOverridePuppet { get; set; }
	[Ordinal(1)] [RED("once")] public CBool Once { get; set; }
	[Ordinal(2)] [RED("immediately")] public CBool Immediately { get; set; }
	public questCombatNodeParams_ThrowGrenade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CSkinProfile : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("diffuse")] public CColor Diffuse { get; set; }
	[Ordinal(2)] [RED("roughness0")] public CFloat Roughness0 { get; set; }
	[Ordinal(3)] [RED("roughness1")] public CFloat Roughness1 { get; set; }
	[Ordinal(4)] [RED("lobeMix")] public CFloat LobeMix { get; set; }
	public CSkinProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_NPCExploration : CVariable
{
	public animAnimNode_NPCExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InitCombatAfterHit : CVariable
{
	public InitCombatAfterHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animLipsyncMapping : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("languageCodeName")] public CName LanguageCodeName { get; set; }
	[Ordinal(2)] [RED("scenePaths")] public CArray<CUInt64> ScenePaths { get; set; }
	[Ordinal(3)] [RED("scenePreviewPaths")] public CArray<CUInt64> ScenePreviewPaths { get; set; }
	[Ordinal(4)] [RED("sceneEntries")] public CArray<animLipsyncMappingSceneEntry> SceneEntries { get; set; }
	public animLipsyncMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayFX_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questPlayFX_NodeTypeParams> Params { get; set; }
	public questPlayFX_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemVignette : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("vignetteRadius")] public effectEffectParameterEvaluatorFloat VignetteRadius { get; set; }
	[Ordinal(3)] [RED("vignetteExp")] public effectEffectParameterEvaluatorFloat VignetteExp { get; set; }
	[Ordinal(4)] [RED("color")] public effectEffectParameterEvaluatorColor Color { get; set; }
	public effectTrackItemVignette(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPopulationSpawnerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("objectRecordId")] public TweakDBID ObjectRecordId { get; set; }
	[Ordinal(3)] [RED("appearanceName")] public CName AppearanceName { get; set; }
	public worldPopulationSpawnerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_Kill : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	public questCharacterManagerCombat_Kill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEComparisonTypeEquality : CVariable
{
	public questEComparisonTypeEquality(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UseWorkspotCommandDelegate : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public UseWorkspotCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakersDistanceInterruptCondition : CVariable
{
	public scnCheckSpeakersDistanceInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorExtractMountParentStubPositionTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	[Ordinal(1)] [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }
	public AIbehaviorExtractMountParentStubPositionTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetAttachment_ToActor : CVariable
{
	[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
	[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(3)] [RED("slot")] public CName Slot { get; set; }
	[Ordinal(4)] [RED("offsetMode")] public questAttachmentOffsetMode OffsetMode { get; set; }
	public questEntityManagerSetAttachment_ToActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAnimationTask : CVariable
{
	[Ordinal(0)] [RED("record")] public TweakDBID Record { get; set; }
	[Ordinal(1)] [RED("animVariation")] public CHandle<AIArgumentMapping> AnimVariation { get; set; }
	public AIAnimationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowOnscreen_NodeType : CVariable
{
	[Ordinal(0)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	public questShowOnscreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsCustomFilterData : CVariable
{
	[Ordinal(0)] [RED("queryDetect")] public CArray<CName> QueryDetect { get; set; }
	public physicsCustomFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRadio_ConditionType : CVariable
{
	[Ordinal(0)] [RED("limitToSpecifiedSpeakersStations")] public CBool LimitToSpecifiedSpeakersStations { get; set; }
	public questRadio_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInt32FixedValueProvider : CVariable
{
	[Ordinal(0)] [RED("value")] public CInt32 Value { get; set; }
	public questInt32FixedValueProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsEGroupType : CVariable
{
	public gameinteractionsEGroupType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animTransformIndex : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public animTransformIndex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsAnimTimelineEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt64 Id { get; set; }
	[Ordinal(1)] [RED("type")] public CString Type { get; set; }
	[Ordinal(2)] [RED("visualType")] public CString VisualType { get; set; }
	[Ordinal(3)] [RED("caption")] public CString Caption { get; set; }
	[Ordinal(4)] [RED("trackId")] public CUInt64 TrackId { get; set; }
	[Ordinal(5)] [RED("startTime")] public CFloat StartTime { get; set; }
	[Ordinal(6)] [RED("runtimeEvent")] public CHandle<animAnimEvent> RuntimeEvent { get; set; }
	public toolsAnimTimelineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectOutputParameter_Vector : CVariable
{
	[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
	public gameEffectOutputParameter_Vector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointAngularLimitPair : CVariable
{
	[Ordinal(0)] [RED("upper")] public CFloat Upper { get; set; }
	[Ordinal(1)] [RED("lower")] public CFloat Lower { get; set; }
	public physicsPhysicsJointAngularLimitPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HitShape_Type : CVariable
{
	public HitShape_Type(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorFloatCurve : CVariable
{
	[Ordinal(0)] [RED("curves")] public curveData<CFloat> Curves { get; set; }
	public CEvaluatorFloatCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISetAutocraftingState : CVariable
{
	public AISetAutocraftingState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_KillFXAction : CVariable
{
	public gameEffectAction_KillFXAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorStoryActionConditionDefinition : CVariable
{
	public AIbehaviorStoryActionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInteriorAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldInteriorAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEventManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(3)] [RED("managerName")] public CString ManagerName { get; set; }
	[Ordinal(4)] [RED("event")] public CHandle<IScriptable> Event { get; set; }
	public questEventManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ELightShadowSoftnessMode : CVariable
{
	public ELightShadowSoftnessMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_HasAnimation : CVariable
{
	[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
	public animAnimStateTransitionCondition_HasAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorAssignTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("assignments")] public CArray<AIbehaviorAssignTaskItem> Assignments { get; set; }
	public AIbehaviorAssignTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AreaTypeTransition : CVariable
{
	[Ordinal(0)] [RED("transitionMode")] public ETransitionMode TransitionMode { get; set; }
	public AreaTypeTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsDespawnEntityEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("params")] public scneventsDespawnEntityEventParams Params { get; set; }
	public scneventsDespawnEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterEquippedWeapon_ConditionType : CVariable
{
	[Ordinal(0)] [RED("weaponTag")] public CName WeaponTag { get; set; }
	public questCharacterEquippedWeapon_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EColorMappingFunction : CVariable
{
	public EColorMappingFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAdditionalSpeakers : CVariable
{
	[Ordinal(0)] [RED("executionTag")] public CUInt8 ExecutionTag { get; set; }
	[Ordinal(1)] [RED("speakers")] public CArray<scnAdditionalSpeaker> Speakers { get; set; }
	public scnAdditionalSpeakers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EquipItemCommandDelegate : CVariable
{
	public EquipItemCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorScriptTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("script")] public CHandle<AIbehaviortaskScript> Script { get; set; }
	public AIbehaviorScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPatrolParams : CVariable
{
	[Ordinal(0)] [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
	public questPatrolParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EnterVehicle : CVariable
{
	public EnterVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsPlayerCompanion : CVariable
{
	public IsPlayerCompanion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectTransformSequenceDictionary : CVariable
{
	public gameSmartObjectTransformSequenceDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorInput : CVariable
{
	[Ordinal(0)] [RED("group")] public CName Group { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	public animAnimNode_VectorInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleEventExecutionTag_NodeType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(1)] [RED("eventExecutionTag")] public CName EventExecutionTag { get; set; }
	[Ordinal(2)] [RED("mute")] public CBool Mute { get; set; }
	public questToggleEventExecutionTag_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioSetListenerOverrideNodeType : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	public questAudioSetListenerOverrideNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakAIActionSequence : CVariable
{
	[Ordinal(0)] [RED("sequence")] public TweakDBID Sequence { get; set; }
	public TweakAIActionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerTrail : CVariable
{
	public CParticleDrawerTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_QuaternionInterpolation : CVariable
{
	[Ordinal(0)] [RED("firstInput")] public animQuaternionLink FirstInput { get; set; }
	[Ordinal(1)] [RED("secondInput")] public animQuaternionLink SecondInput { get; set; }
	[Ordinal(2)] [RED("weight")] public animFloatLink Weight { get; set; }
	public animAnimNode_QuaternionInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsColliderCapsule : CVariable
{
	[Ordinal(0)] [RED("localToBody")] public Transform LocalToBody { get; set; }
	[Ordinal(1)] [RED("material")] public CName Material { get; set; }
	[Ordinal(2)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(4)] [RED("height")] public CFloat Height { get; set; }
	public physicsColliderCapsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRandomizerMode : CVariable
{
	public scnRandomizerMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemChromaticAberration : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(2)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(3)] [RED("chromaticAberrationOffset")] public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset { get; set; }
	[Ordinal(4)] [RED("chromaticAberrationExp")] public effectEffectParameterEvaluatorFloat ChromaticAberrationExp { get; set; }
	public effectTrackItemChromaticAberration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorOrbit : CVariable
{
	[Ordinal(0)] [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
	[Ordinal(1)] [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
	[Ordinal(2)] [RED("phase")] public CHandle<IEvaluatorVector> Phase { get; set; }
	public CParticleModificatorOrbit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_NewEffect_ReverseFromLastHit : CVariable
{
	[Ordinal(0)] [RED("tagInThisFile")] public CName TagInThisFile { get; set; }
	[Ordinal(1)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
	[Ordinal(2)] [RED("childEffect")] public CBool ChildEffect { get; set; }
	[Ordinal(3)] [RED("childEffectTag")] public CName ChildEffectTag { get; set; }
	public gameEffectAction_NewEffect_ReverseFromLastHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RevealObjectExecutor : CVariable
{
	public RevealObjectExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldBuildingProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
	[Ordinal(5)] [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
	[Ordinal(6)] [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }
	public worldBuildingProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSocketDefinition : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("type")] public questSocketType Type { get; set; }
	public questSocketDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ECoverSpecialAction : CVariable
{
	public ECoverSpecialAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDummyAlwaysTrueReturnCondition : CVariable
{
	public scnDummyAlwaysTrueReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimSequence : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("definitions")] public CArray<CHandle<inkanimDefinition>> Definitions { get; set; }
	[Ordinal(2)] [RED("targets")] public CArray<CHandle<inkanimSequenceTargetInfo>> Targets { get; set; }
	public inkanimSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GameTime : CVariable
{
	[Ordinal(0)] [RED("seconds")] public CInt32 Seconds { get; set; }
	public GameTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TeleportCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	[Ordinal(1)] [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }
	[Ordinal(2)] [RED("rotation")] public CHandle<AIArgumentMapping> Rotation { get; set; }
	[Ordinal(3)] [RED("doNavTest")] public CHandle<AIArgumentMapping> DoNavTest { get; set; }
	public TeleportCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInventory_ConditionType : CVariable
{
	[Ordinal(0)] [RED("itemID")] public TweakDBID ItemID { get; set; }
	[Ordinal(1)] [RED("quantity")] public CUInt32 Quantity { get; set; }
	[Ordinal(2)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questInventory_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEntityProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("ownerGlobalId")] public worldGlobalNodeID OwnerGlobalId { get; set; }
	[Ordinal(4)] [RED("entityAttachDistance")] public CFloat EntityAttachDistance { get; set; }
	public worldEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSceneTier4Data : CVariable
{
	[Ordinal(0)] [RED("emptyHands")] public CBool EmptyHands { get; set; }
	public gameSceneTier4Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkipConsoleBegin : CVariable
{
	public animAnimNode_SkipConsoleBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animAnimNode_Event : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimNode_Event(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animfssBodyOfflineParams : CVariable
{
	[Ordinal(0)] [RED("HipsTilt")] public CFloat HipsTilt { get; set; }
	public animfssBodyOfflineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWorkspotTree : CVariable
{
	[Ordinal(0)] [RED("rootEntry")] public CHandle<workIEntry> RootEntry { get; set; }
	[Ordinal(1)] [RED("idCounter")] public CUInt32 IdCounter { get; set; }
	[Ordinal(2)] [RED("animsets")] public CArray<workWorkspotAnimsetEntry> Animsets { get; set; }
	[Ordinal(3)] [RED("finalAnimsets")] public CArray<workWorkspotAnimsetEntry> FinalAnimsets { get; set; }
	[Ordinal(4)] [RED("snapToTerrain")] public CBool SnapToTerrain { get; set; }
	public workWorkspotTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSwitchNameplate_NodeType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(2)] [RED("enable")] public CBool Enable { get; set; }
	[Ordinal(3)] [RED("alternativeName")] public CBool AlternativeName { get; set; }
	public questSwitchNameplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workAnimClip : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("flags")] public CUInt32 Flags { get; set; }
	[Ordinal(2)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(3)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	public workAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransformAnimatorNode_Action_Pause : CVariable
{
	public questTransformAnimatorNode_Action_Pause(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDoorType : CVariable
{
	[Ordinal(0)] [RED("doorTypeSideOne")] public EDoorType DoorTypeSideOne { get; set; }
	[Ordinal(1)] [RED("doorTypeSideTwo")] public EDoorType DoorTypeSideTwo { get; set; }
	public SetDoorType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class garmentMeshParamGarment : CVariable
{
	[Ordinal(0)] [RED("chunks")] public CArray<garmentMeshParamGarmentChunkData> Chunks { get; set; }
	public garmentMeshParamGarment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_AssignSquad : CVariable
{
	[Ordinal(0)] [RED("presetID")] public TweakDBID PresetID { get; set; }
	[Ordinal(1)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(2)] [RED("squadType")] public AISquadType SquadType { get; set; }
	public questCharacterManagerCombat_AssignSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ESecuritySystemState : CVariable
{
	public ESecuritySystemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatTrackModifier : CVariable
{
	[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
	[Ordinal(1)] [RED("operationType")] public animFloatTrackOperationType OperationType { get; set; }
	[Ordinal(2)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
	[Ordinal(3)] [RED("floatInputNode")] public animFloatLink FloatInputNode { get; set; }
	public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questvehicleOnSplineParams : CVariable
{
	[Ordinal(0)] [RED("keepDistanceParam")] public CHandle<questParamKeepDistance> KeepDistanceParam { get; set; }
	[Ordinal(1)] [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }
	public questvehicleOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CGradient : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public CGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSpeedSplineNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
	[Ordinal(3)] [RED("speedChangeSections")] public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections { get; set; }
	[Ordinal(4)] [RED("deprecatedDefaultSpeed")] public CFloat DeprecatedDefaultSpeed { get; set; }
	[Ordinal(5)] [RED("orientationChangeSections")] public CArray<worldSpeedSplineNodeOrientationChangeSection> OrientationChangeSections { get; set; }
	public worldSpeedSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ChangePresetEvent : CVariable
{
	[Ordinal(0)] [RED("presetID")] public ESmartHousePreset PresetID { get; set; }
	public ChangePresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterMountedTogether_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleType")] public questMountVehicleType VehicleType { get; set; }
	[Ordinal(1)] [RED("characters")] public CArray<CHandle<questMountedObjectInfo>> Characters { get; set; }
	public questCharacterMountedTogether_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorExpressionSocket : CVariable
{
	[Ordinal(0)] [RED("expression")] public CHandle<AIbehaviorPassiveExpressionDefinition> Expression { get; set; }
	public AIbehaviorExpressionSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCommandType : CVariable
{
	public questVehicleCommandType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class appearanceCookedAppearanceData : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("dependencies")] public CArray<rRef<CResource>> Dependencies { get; set; }
	[Ordinal(2)] [RED("totalSizeOnDisk")] public CUInt32 TotalSizeOnDisk { get; set; }
	public appearanceCookedAppearanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterTexture : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("texture")] public rRef<ITexture> Texture { get; set; }
	public CMaterialParameterTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorLeaveCoverImmediatelyNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	public AIbehaviorLeaveCoverImmediatelyNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDestructibleProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
	[Ordinal(5)] [RED("ownerHash")] public CUInt64 OwnerHash { get; set; }
	public worldDestructibleProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleDoor_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("doorAction")] public vehicleEQuestVehicleDoorState DoorAction { get; set; }
	public questToggleDoor_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalNotification_ConditionType : CVariable
{
	[Ordinal(0)] [RED("journalPath")] public CHandle<gameJournalPath> JournalPath { get; set; }
	public questJournalNotification_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveSummoningTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveSummoningTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_HitRepresentation_Raycast : CVariable
{
	public gameEffectObjectFilter_HitRepresentation_Raycast(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEventSide : CVariable
{
	public animEventSide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticParticleNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("particleSystem")] public raRef<CParticleSystem> ParticleSystem { get; set; }
	public worldStaticParticleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOutputSocketStamp : CVariable
{
	[Ordinal(0)] [RED("name")] public CUInt16 Name { get; set; }
	[Ordinal(1)] [RED("ordinal")] public CUInt16 Ordinal { get; set; }
	public scnOutputSocketStamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneConditionType : CVariable
{
	public questSceneConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSplineParams : CVariable
{
	[Ordinal(0)] [RED("splineNodeRef")] public NodeRef SplineNodeRef { get; set; }
	[Ordinal(1)] [RED("reverse")] public CBool Reverse { get; set; }
	[Ordinal(2)] [RED("additionalParams")] public CHandle<questMoveOnSplineAdditionalParams> AdditionalParams { get; set; }
	public questMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class moveMovementOrientationType : CVariable
{
	public moveMovementOrientationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleRaceUI : CVariable
{
	public vehicleRaceUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakersDistanceReturnCondition : CVariable
{
	public scnCheckSpeakersDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AtmosphereAreaSettings : CVariable
{
	[Ordinal(0)] [RED("skydomeColor")] public curveData<HDRColor> SkydomeColor { get; set; }
	[Ordinal(1)] [RED("skylightColor")] public curveData<HDRColor> SkylightColor { get; set; }
	[Ordinal(2)] [RED("groundReflectance")] public curveData<HDRColor> GroundReflectance { get; set; }
	[Ordinal(3)] [RED("horizonMinZ")] public curveData<CFloat> HorizonMinZ { get; set; }
	[Ordinal(4)] [RED("horizonFalloff")] public curveData<CFloat> HorizonFalloff { get; set; }
	[Ordinal(5)] [RED("turbidity")] public curveData<CFloat> Turbidity { get; set; }
	[Ordinal(6)] [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
	[Ordinal(7)] [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
	[Ordinal(8)] [RED("moonGlowIntensity")] public curveData<CFloat> MoonGlowIntensity { get; set; }
	[Ordinal(9)] [RED("moonGlowFalloff")] public curveData<CFloat> MoonGlowFalloff { get; set; }
	[Ordinal(10)] [RED("moonTexture")] public rRef<CBitmapTexture> MoonTexture { get; set; }
	[Ordinal(11)] [RED("starMapIntensity")] public curveData<CFloat> StarMapIntensity { get; set; }
	[Ordinal(12)] [RED("cloudSunShadowFaloff")] public curveData<CFloat> CloudSunShadowFaloff { get; set; }
	[Ordinal(13)] [RED("cloudSunScattering")] public curveData<CFloat> CloudSunScattering { get; set; }
	[Ordinal(14)] [RED("cloudAmbientIntensity")] public curveData<CFloat> CloudAmbientIntensity { get; set; }
	[Ordinal(15)] [RED("cloudCirrusOpacity")] public curveData<CFloat> CloudCirrusOpacity { get; set; }
	[Ordinal(16)] [RED("cloudCirrusTexture")] public rRef<CBitmapTexture> CloudCirrusTexture { get; set; }
	public AtmosphereAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMonitorConditionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
	public AIbehaviorMonitorConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoWeapon : CVariable
{
	public gameEffectObjectFilter_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_WeightedVector : CVariable
{
	[Ordinal(0)] [RED("channel")] public CHandle<animIAnimNodeSourceChannel_Vector> Channel { get; set; }
	public animAnimNodeSourceChannel_WeightedVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_WorkspotAnim : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_WorkspotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLanguage_ConditionType : CVariable
{
	[Ordinal(0)] [RED("mode")] public questLanguageMode Mode { get; set; }
	[Ordinal(1)] [RED("languageCode")] public CString LanguageCode { get; set; }
	public questLanguage_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBlockAction : CVariable
{
	public questBlockAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UseWorkspotCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	[Ordinal(1)] [RED("outContinueInCombat")] public CHandle<AIArgumentMapping> OutContinueInCombat { get; set; }
	public UseWorkspotCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkipPerformanceModeEnd : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_SkipPerformanceModeEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questObjectInteractionEventType : CVariable
{
	public questObjectInteractionEventType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseInfoLoggerEntry_FloatTrack : CVariable
{
	[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
	public animPoseInfoLoggerEntry_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questNodeLoadingCondition : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	public questNodeLoadingCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_TransformQuat : CVariable
{
	[Ordinal(0)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNodeSourceChannel_TransformQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameAlwaysSpawnedState : CVariable
{
	public gameAlwaysSpawnedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ShootCommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ShootCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UnregisterReactionAction : CVariable
{
	[Ordinal(0)] [RED("reactionName")] public CName ReactionName { get; set; }
	public UnregisterReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendFromPose : CVariable
{
	[Ordinal(0)] [RED("debug")] public CBool Debug { get; set; }
	public animAnimNode_BlendFromPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EAreaLightShape : CVariable
{
	public EAreaLightShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questOverrideSplineSpeed_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("speed")] public CFloat Speed { get; set; }
	[Ordinal(2)] [RED("adjustTime")] public CFloat AdjustTime { get; set; }
	public questOverrideSplineSpeed_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSpawnInViewState : CVariable
{
	public gameSpawnInViewState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerBeam : CVariable
{
	[Ordinal(0)] [RED("texturesPerUnit")] public CFloat TexturesPerUnit { get; set; }
	[Ordinal(1)] [RED("numSegments")] public CUInt32 NumSegments { get; set; }
	[Ordinal(2)] [RED("rotation")] public CFloat Rotation { get; set; }
	public CParticleDrawerBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlayVideoEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("videoPath")] public CString VideoPath { get; set; }
	[Ordinal(3)] [RED("isPhoneCall")] public CBool IsPhoneCall { get; set; }
	[Ordinal(4)] [RED("forceFrameRate")] public CBool ForceFrameRate { get; set; }
	public scnPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalInternetPage : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("address")] public CString Address { get; set; }
	[Ordinal(2)] [RED("widgetFile")] public raRef<inkWidgetLibraryResource> WidgetFile { get; set; }
	[Ordinal(3)] [RED("texts")] public CArray<CHandle<gameJournalInternetText>> Texts { get; set; }
	public gameJournalInternetPage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_HitRepresentation_Sphere : CVariable
{
	public gameEffectObjectFilter_HitRepresentation_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CurveSet : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("curves")] public CArray<CurveSetEntry> Curves { get; set; }
	public CurveSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckMountedVehicleImpactInterruptCondition : CVariable
{
	public scnCheckMountedVehicleImpactInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleSpeed_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("speed")] public CFloat Speed { get; set; }
	[Ordinal(2)] [RED("comparisonType")] public vehicleEVehicleSpeedConditionType ComparisonType { get; set; }
	public questVehicleSpeed_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StackAlertedState : CVariable
{
	public StackAlertedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamBakedDestructionData : CVariable
{
	[Ordinal(0)] [RED("regionData")] public CArray<meshRegionData> RegionData { get; set; }
	[Ordinal(1)] [RED("indices")] public CArray<DataBuffer> Indices { get; set; }
	public meshMeshParamBakedDestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorPuppetRefToGameObjectTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public CHandle<AIArgumentMapping> PuppetRef { get; set; }
	[Ordinal(1)] [RED("result")] public CHandle<AIArgumentMapping> Result { get; set; }
	public AIbehaviorPuppetRefToGameObjectTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPoseCorrectionEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	public scnPoseCorrectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EMP : CVariable
{
	public EMP(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckCurrentWorkspotTag : CVariable
{
	[Ordinal(0)] [RED("tag")] public CHandle<AIArgumentMapping> Tag { get; set; }
	public CheckCurrentWorkspotTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSpline_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
	public questMoveOnSpline_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Stage : CVariable
{
	[Ordinal(0)] [RED("nodes")] public CArray<CHandle<animAnimNode_Base>> Nodes { get; set; }
	public animAnimNode_Stage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentCullObject : CVariable
{
	[Ordinal(0)] [RED("Plane")] public Plane Plane { get; set; }
	[Ordinal(1)] [RED("Plane1")] public Plane Plane1 { get; set; }
	[Ordinal(2)] [RED("CapsulePointA")] public Vector3 CapsulePointA { get; set; }
	[Ordinal(3)] [RED("CapsulePointB")] public Vector3 CapsulePointB { get; set; }
	[Ordinal(4)] [RED("CapsuleRadius")] public CFloat CapsuleRadius { get; set; }
	[Ordinal(5)] [RED("NearestAnimBoneName")] public CName NearestAnimBoneName { get; set; }
	[Ordinal(6)] [RED("NearestAnimIndex")] public CInt16 NearestAnimIndex { get; set; }
	[Ordinal(7)] [RED("RagdollBodyIndex")] public CUInt16 RagdollBodyIndex { get; set; }
	public entdismembermentCullObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameGodModeType : CVariable
{
	public gameGodModeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MotionBlurAreaSettings : CVariable
{
	public MotionBlurAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhone_ConditionType : CVariable
{
	[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
	[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }
	public questPhone_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ParentTransform : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("mapping")] public CArray<animAnimTransformMappingEntry> Mapping { get; set; }
	public animAnimNode_ParentTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TriggerNotifier_BarbedWire : CVariable
{
	[Ordinal(0)] [RED("attackType")] public TweakDBID AttackType { get; set; }
	public TriggerNotifier_BarbedWire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorGenerateSearchInfluenceTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }
	[Ordinal(1)] [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
	[Ordinal(2)] [RED("radius")] public CHandle<AIArgumentMapping> Radius { get; set; }
	public AIbehaviorGenerateSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetMeshAppearance_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questEntityManagerSetMeshAppearance_NodeTypeParams> Params { get; set; }
	public questEntityManagerSetMeshAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStreamingTestCheckpointType : CVariable
{
	public worldStreamingTestCheckpointType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MountRequestCondition : CVariable
{
	[Ordinal(0)] [RED("testMountRequest")] public CBool TestMountRequest { get; set; }
	[Ordinal(1)] [RED("testUnmountRequest")] public CBool TestUnmountRequest { get; set; }
	public MountRequestCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleEVehicleDoor : CVariable
{
	public vehicleEVehicleDoor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DistantProxiesSettings : CVariable
{
	public DistantProxiesSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class navLocomotionPathResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public navLocomotionPathResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSaveSanitizationForbiddenAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldSaveSanitizationForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questCharacterState_PuppetSubType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("highLevelState")] public CInt32 HighLevelState { get; set; }
	public questCharacterState_PuppetSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsAttachToPropParams : CVariable
{
	[Ordinal(0)] [RED("propId")] public scnPropId PropId { get; set; }
	[Ordinal(1)] [RED("visualizerStyle")] public scnChoiceNodeNsVisualizerStyle VisualizerStyle { get; set; }
	public scnChoiceNodeNsAttachToPropParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NotInDefeated : CVariable
{
	public NotInDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAxis : CVariable
{
	public animAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamTerrain : CVariable
{
	[Ordinal(0)] [RED("chunkBoundingBoxes")] public CArray<Box> ChunkBoundingBoxes { get; set; }
	public meshMeshParamTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CombatRestrictMovementAreaPlayerEnterMainRMACondition : CVariable
{
	public CombatRestrictMovementAreaPlayerEnterMainRMACondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RemoveStatusEffectOnOwner : CVariable
{
	[Ordinal(0)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
	public RemoveStatusEffectOnOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workScriptedCondition : CVariable
{
	[Ordinal(0)] [RED("script")] public CHandle<workIScriptedCondition> Script { get; set; }
	public workScriptedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDistanceCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIDistanceConditionType> Type { get; set; }
	public questDistanceCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTimer_NodeType : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	public questSetTimer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatClamp : CVariable
{
	[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(1)] [RED("max")] public CFloat Max { get; set; }
	[Ordinal(2)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_FloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamSpeedTreeWind : CVariable
{
	public meshMeshParamSpeedTreeWind(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsELookAtTest : CVariable
{
	public gameinteractionsELookAtTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EscalateProvoke : CVariable
{
	public EscalateProvoke(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SinglePlayerPrereq : CVariable
{
	public SinglePlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communityCommunityTemplateData : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<CHandle<communitySpawnEntry>> Entries { get; set; }
	[Ordinal(1)] [RED("spawnSetReference")] public CName SpawnSetReference { get; set; }
	public communityCommunityTemplateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InVehicleDecorator : CVariable
{
	public InVehicleDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitConditionDefinition : CVariable
{
	public AIbehaviorWaitConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsBoss : CVariable
{
	public IsBoss(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worlduiEntryVisibility : CVariable
{
	public worlduiEntryVisibility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_CoordinateFromVector : CVariable
{
	public animAnimNode_CoordinateFromVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnUseSceneWorkspotParamsV1 : CVariable
{
	[Ordinal(0)] [RED("finishAnimation")] public CBool FinishAnimation { get; set; }
	[Ordinal(1)] [RED("jumpToEntry")] public CBool JumpToEntry { get; set; }
	[Ordinal(2)] [RED("entryId")] public workWorkEntryId EntryId { get; set; }
	[Ordinal(3)] [RED("enableIdleMode")] public CBool EnableIdleMode { get; set; }
	[Ordinal(4)] [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }
	[Ordinal(5)] [RED("workspotInstanceId")] public scnSceneWorkspotInstanceId WorkspotInstanceId { get; set; }
	[Ordinal(6)] [RED("playAtActorLocation")] public CBool PlayAtActorLocation { get; set; }
	public scnUseSceneWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleForceBrake_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("val")] public CBool Val { get; set; }
	public questToggleForceBrake_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnableVehicleSummon_NodeType : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	public questEnableVehicleSummon_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectEffectParameterEvaluator : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluator> Evaluator { get; set; }
	public effectEffectParameterEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questWeather_ConditionType : CVariable
{
	[Ordinal(0)] [RED("weather")] public CName Weather { get; set; }
	[Ordinal(1)] [RED("inverted")] public CBool Inverted { get; set; }
	public questWeather_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AITreeArgumentsDefinition : CVariable
{
	[Ordinal(0)] [RED("args")] public CArray<CHandle<AIArgumentDefinition>> Args { get; set; }
	public AITreeArgumentsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_QuerySphere_Value : CVariable
{
	[Ordinal(0)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(1)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_QuerySphere_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransformAnimatorNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(3)] [RED("animationName")] public CName AnimationName { get; set; }
	[Ordinal(4)] [RED("action")] public CHandle<questTransformAnimatorNode_ActionType> Action { get; set; }
	public questTransformAnimatorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAcousticDataResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("cells")] public CArray<worldAcousticDataCell> Cells { get; set; }
	public worldAcousticDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_CurveVectorValue : CVariable
{
	[Ordinal(0)] [RED("curveData")] public curveData<Vector4> CurveData { get; set; }
	public animAnimNode_CurveVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoPuppet : CVariable
{
	public gameEffectObjectFilter_NoPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animRig : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
	[Ordinal(2)] [RED("trackNames")] public CArray<CName> TrackNames { get; set; }
	[Ordinal(3)] [RED("rigExtraTracks")] public CArray<animFloatTrackInfo> RigExtraTracks { get; set; }
	[Ordinal(4)] [RED("levelOfDetailStartIndices")] public CArray<CInt16> LevelOfDetailStartIndices { get; set; }
	[Ordinal(5)] [RED("distanceCategoryToLodMap")] public CArray<CInt16> DistanceCategoryToLodMap { get; set; }
	[Ordinal(6)] [RED("referenceTracks")] public CArray<CFloat> ReferenceTracks { get; set; }
	[Ordinal(7)] [RED("aPoseLS")] public CArray<QsTransform> APoseLS { get; set; }
	[Ordinal(8)] [RED("aPoseMS")] public CArray<QsTransform> APoseMS { get; set; }
	[Ordinal(9)] [RED("tags")] public redTagList Tags { get; set; }
	[Ordinal(10)] [RED("parts")] public CArray<animRigPart> Parts { get; set; }
	[Ordinal(11)] [RED("retargets")] public CArray<animRigRetarget> Retargets { get; set; }
	[Ordinal(12)] [RED("ikSetups")] public CArray<CHandle<animIRigIkSetup>> IkSetups { get; set; }
	[Ordinal(13)] [RED("ragdollDesc")] public CArray<physicsRagdollBodyInfo> RagdollDesc { get; set; }
	[Ordinal(14)] [RED("ragdollNames")] public CArray<physicsRagdollBodyNames> RagdollNames { get; set; }
	public animRig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animNamedTrackIndex : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public animNamedTrackIndex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questContentToken_ConditionType : CVariable
{
	[Ordinal(0)] [RED("type")] public questQuestContentType Type { get; set; }
	public questContentToken_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SharedMetaPoseAdditive : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_SharedMetaPoseAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemColorGrade : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("contrast")] public effectEffectParameterEvaluatorFloat Contrast { get; set; }
	[Ordinal(3)] [RED("saturate")] public effectEffectParameterEvaluatorFloat Saturate { get; set; }
	[Ordinal(4)] [RED("brightness")] public effectEffectParameterEvaluatorFloat Brightness { get; set; }
	[Ordinal(5)] [RED("lutWeight")] public effectEffectParameterEvaluatorFloat LutWeight { get; set; }
	[Ordinal(6)] [RED("lutParams")] public ColorGradingLutParams LutParams { get; set; }
	[Ordinal(7)] [RED("lutParamsHdr")] public ColorGradingLutParams LutParamsHdr { get; set; }
	public effectTrackItemColorGrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterCube : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("texture")] public rRef<ITexture> Texture { get; set; }
	public CMaterialParameterCube(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTimeManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questITimeManagerNodeType> Type { get; set; }
	public questTimeManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetNodeDistanceInterruptConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("targetNode")] public NodeRef TargetNode { get; set; }
	public scnCheckPlayerTargetNodeDistanceInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIStopCoverCommandParams : CVariable
{
	public AIStopCoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_SecondaryWeapon : CVariable
{
	public questCombatNodeParams_SecondaryWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsUnequipItemFromPerformer : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(4)] [RED("slotId")] public TweakDBID SlotId { get; set; }
	public scneventsUnequipItemFromPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckFactReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("factCondition")] public CHandle<scnInterruptFactConditionType> FactCondition { get; set; }
	public scnCheckFactReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorldTransform : CVariable
{
	[Ordinal(0)] [RED("Position")] public WorldPosition Position { get; set; }
	[Ordinal(1)] [RED("Orientation")] public Quaternion Orientation { get; set; }
	public WorldTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStopRecording_NodeType : CVariable
{
	public questStopRecording_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DoesVehicleSupportCombat : CVariable
{
	public DoesVehicleSupportCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Quaternion : CVariable
{
	[Ordinal(0)] [RED("i")] public CFloat I { get; set; }
	[Ordinal(1)] [RED("j")] public CFloat J { get; set; }
	[Ordinal(2)] [RED("k")] public CFloat K { get; set; }
	[Ordinal(3)] [RED("r")] public CFloat R { get; set; }
	public Quaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnIKEventData : CVariable
{
	[Ordinal(0)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
	[Ordinal(1)] [RED("chainName")] public CName ChainName { get; set; }
	[Ordinal(2)] [RED("request")] public animIKTargetRequest Request { get; set; }
	public scnIKEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPendulumConstraintType : CVariable
{
	public animPendulumConstraintType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendEmitterSimulationShaders : CVariable
{
	[Ordinal(0)] [RED("simCS", 2)] public CArrayFixedSize<DataBuffer> SimCS { get; set; }
public rendEmitterSimulationShaders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AICombatSpaceSize : CVariable
{
	public AICombatSpaceSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterCombat_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	public questCharacterCombat_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorVelocityTurbulize : CVariable
{
	[Ordinal(0)] [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
	[Ordinal(1)] [RED("timelifeLimit")] public CHandle<IEvaluatorFloat> TimelifeLimit { get; set; }
	[Ordinal(2)] [RED("noiseInterval")] public CFloat NoiseInterval { get; set; }
	public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workEquipPropToSlotAction : CVariable
{
	[Ordinal(0)] [RED("itemId")] public CName ItemId { get; set; }
	[Ordinal(1)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }
	public workEquipPropToSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInteractionShapeParams : CVariable
{
	[Ordinal(0)] [RED("customIndicationRange")] public CFloat CustomIndicationRange { get; set; }
	[Ordinal(1)] [RED("customActivationRange")] public CFloat CustomActivationRange { get; set; }
	[Ordinal(2)] [RED("activationYawLimit")] public CFloat ActivationYawLimit { get; set; }
	public scnInteractionShapeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GlobalLightOverrideAreaSettings : CVariable
{
	public GlobalLightOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentCNameValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentCNameValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EDoorType : CVariable
{
	public EDoorType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AnimFeature_SceneSystemCarrying : CVariable
{
	[Ordinal(0)] [RED("carrying")] public CBool Carrying { get; set; }
	public AnimFeature_SceneSystemCarrying(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRenderPlane_NodeType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("renderPlane")] public ERenderingPlane RenderPlane { get; set; }
	public questRenderPlane_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_GenerateIkAnimFeatureData : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("ikChainSettings")] public CArray<animIKChainSettings> IkChainSettings { get; set; }
	public animAnimNode_GenerateIkAnimFeatureData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SendEquipWeaponCommand : CVariable
{
	public SendEquipWeaponCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitWorldPositionConditionDefinition : CVariable
{
	public AIbehaviorWaitWorldPositionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DodgeReactionTask : CVariable
{
	public DodgeReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_WorkspotHub : CVariable
{
	public animAnimNode_WorkspotHub(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MoveToCoverCommandDelegate : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public MoveToCoverCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RemotelyConnectToAccessPoint : CVariable
{
	public RemotelyConnectToAccessPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsDead : CVariable
{
	public IsDead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSimulationType : CVariable
{
	public physicsSimulationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameAppearanceNameVisualTagsPreset : CVariable
{
	[Ordinal(0)] [RED("presets")] public CArray<gameAppearanceNameVisualTagsPreset_Entity> Presets { get; set; }
	public gameAppearanceNameVisualTagsPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_AxisRangeAxis : CVariable
{
	public gameEffectObjectFilter_AxisRangeAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioMixNodeType : CVariable
{
	[Ordinal(0)] [RED("mixSignpost")] public CName MixSignpost { get; set; }
	public questAudioMixNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemPointLight : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("tint")] public effectEffectParameterEvaluatorColor Tint { get; set; }
	[Ordinal(3)] [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
	[Ordinal(4)] [RED("EV")] public CFloat EV { get; set; }
	[Ordinal(5)] [RED("radius")] public effectEffectParameterEvaluatorFloat Radius { get; set; }
	[Ordinal(6)] [RED("color")] public CColor Color { get; set; }
	public effectTrackItemPointLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTier3Params_NodeType : CVariable
{
	[Ordinal(0)] [RED("yawLeftLimit")] public CFloat YawLeftLimit { get; set; }
	[Ordinal(1)] [RED("yawRightLimit")] public CFloat YawRightLimit { get; set; }
	[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questSetTier3Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_TerminateGameEffect : CVariable
{
	public gameEffectExecutor_TerminateGameEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_FootPlant : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_FootPlant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIGateSignalSender : CVariable
{
	[Ordinal(0)] [RED("tags")] public CArray<CName> Tags { get; set; }
	[Ordinal(1)] [RED("priority")] public CFloat Priority { get; set; }
	public AIGateSignalSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSplineType : CVariable
{
	public questMoveOnSplineType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkSyncedMasterAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(2)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(3)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
	[Ordinal(4)] [RED("Speed")] public animFloatLink Speed { get; set; }
	[Ordinal(5)] [RED("syncTag")] public CName SyncTag { get; set; }
	public animAnimNode_SkSyncedMasterAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTerrainProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
	[Ordinal(5)] [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
	[Ordinal(6)] [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }
	public worldTerrainProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class locVoiceoverLengthMap : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<locVoLengthEntry> Entries { get; set; }
	public locVoiceoverLengthMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectInputParameter_Float : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<gameIEffectParameter_FloatEvaluator> Evaluator { get; set; }
	public gameEffectInputParameter_Float(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetInteractionVisualizerOverride : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	public questSetInteractionVisualizerOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePopupPosition : CVariable
{
	public gamePopupPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTogglePrefabVariant_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questTogglePrefabVariant_NodeTypeParams> Params { get; set; }
	public questTogglePrefabVariant_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RenderSceneLayerMask : CVariable
{
	public RenderSceneLayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalEntryState : CVariable
{
	public gameJournalEntryState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerPosition : CVariable
{
	[Ordinal(0)] [RED("position")] public CHandle<IEvaluatorVector> Position { get; set; }
	public CParticleInitializerPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMappingExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("mapping")] public CHandle<AIArgumentMapping> Mapping { get; set; }
	[Ordinal(1)] [RED("behaviorCallbackNames")] public CArray<CName> BehaviorCallbackNames { get; set; }
	public AIbehaviorMappingExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_SendStimuli : CVariable
{
	public gameEffectExecutor_SendStimuli(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorForcedBehaviorNodeDefinition : CVariable
{
	public AIbehaviorForcedBehaviorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsSocketDirection : CVariable
{
	public toolsSocketDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSwitchToScenario_NodeType : CVariable
{
	[Ordinal(0)] [RED("startScenarioName")] public CName StartScenarioName { get; set; }
	[Ordinal(1)] [RED("endScenarioName")] public CName EndScenarioName { get; set; }
	public questSwitchToScenario_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestPhase : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalQuestPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetTopThreatToCombatTarget : CVariable
{
	public SetTopThreatToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentIntValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("defaultValue")] public CInt32 DefaultValue { get; set; }
	public AIArgumentIntValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamemappinsMappinData : CVariable
{
	[Ordinal(0)] [RED("mappinType")] public TweakDBID MappinType { get; set; }
	[Ordinal(1)] [RED("variant")] public gamedataMappinVariant Variant { get; set; }
	[Ordinal(2)] [RED("debugCaption")] public CString DebugCaption { get; set; }
	public gamemappinsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorEntityReuseEventResolverDefinition : CVariable
{
	[Ordinal(0)] [RED("destination")] public CHandle<AIArgumentMapping> Destination { get; set; }
	[Ordinal(1)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
	public AIbehaviorEntityReuseEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMovementPolicyTaskFunctions : CVariable
{
	public AIbehaviorMovementPolicyTaskFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDialogLineVoParams : CVariable
{
	[Ordinal(0)] [RED("voContext")] public locVoiceoverContext VoContext { get; set; }
	public scnDialogLineVoParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IgnorePlayerMountedVehicle : CVariable
{
	public IgnorePlayerMountedVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnScalingData_KeepRelationWithOtherEvents : CVariable
{
	[Ordinal(0)] [RED("groupRfrncNdspaceEndtime")] public scnSceneTime GroupRfrncNdspaceEndtime { get; set; }
	public scnScalingData_KeepRelationWithOtherEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnWorkspotData_EmbeddedWorkspotTree : CVariable
{
	[Ordinal(0)] [RED("dataId")] public scnSceneWorkspotDataId DataId { get; set; }
	[Ordinal(1)] [RED("workspotTree")] public CHandle<workWorkspotTree> WorkspotTree { get; set; }
	public scnWorkspotData_EmbeddedWorkspotTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AITakedownHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AITakedownHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ESmartHousePreset : CVariable
{
	public ESmartHousePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IncrimentStealthStimThreshold : CVariable
{
	[Ordinal(0)] [RED("thresholdTimeout")] public CFloat ThresholdTimeout { get; set; }
	public IncrimentStealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Vector3 : CVariable
{
	[Ordinal(0)] [RED("X")] public CFloat X { get; set; }
	[Ordinal(1)] [RED("Y")] public CFloat Y { get; set; }
	[Ordinal(2)] [RED("Z")] public CFloat Z { get; set; }
	public Vector3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorVectorCurve : CVariable
{
	[Ordinal(0)] [RED("freeAxes")] public EFreeVectorAxes FreeAxes { get; set; }
	[Ordinal(1)] [RED("curves")] public curveData<Vector4> Curves { get; set; }
	public CEvaluatorVectorCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleAVArrived_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questVehicleAVArrived_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_GraphSlot_Test : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("dontDeactivateInput")] public CBool DontDeactivateInput { get; set; }
	[Ordinal(2)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(3)] [RED("graph_TEST")] public rRef<animAnimGraph> Graph_TEST { get; set; }
	public animAnimNode_GraphSlot_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_NewEffect_Ricochet : CVariable
{
	[Ordinal(0)] [RED("tagInThisFile")] public CName TagInThisFile { get; set; }
	[Ordinal(1)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
	[Ordinal(2)] [RED("childEffect")] public CBool ChildEffect { get; set; }
	[Ordinal(3)] [RED("childEffectTag")] public CName ChildEffectTag { get; set; }
	public gameEffectAction_NewEffect_Ricochet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animAnimNode_FacialMixerSlot : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("lookAtDefinitions")] public CArray<animLookAtAnimationDefinition> LookAtDefinitions { get; set; }
	public animAnimNode_FacialMixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakDBID : CVariable
{
	public TweakDBID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ToggleContainerLockEvent : CVariable
{
	[Ordinal(0)] [RED("isLocked")] public CBool IsLocked { get; set; }
	public ToggleContainerLockEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workUnequipPropAction : CVariable
{
	[Ordinal(0)] [RED("itemId")] public CName ItemId { get; set; }
	public workUnequipPropAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorColorStartEnd : CVariable
{
	[Ordinal(0)] [RED("start")] public CColor Start { get; set; }
	[Ordinal(1)] [RED("end")] public CColor End { get; set; }
	public CEvaluatorColorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorAlphaByDistance : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("nearBlendDistance")] public Vector2 NearBlendDistance { get; set; }
	public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnableBraindanceFinish_NodeType : CVariable
{
	public questEnableBraindanceFinish_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_PhysicalRayFan : CVariable
{
	[Ordinal(0)] [RED("inputPosition")] public gameEffectInputParameter_Vector InputPosition { get; set; }
	[Ordinal(1)] [RED("inputForward")] public gameEffectInputParameter_Vector InputForward { get; set; }
	[Ordinal(2)] [RED("inputRange")] public gameEffectInputParameter_Float InputRange { get; set; }
	[Ordinal(3)] [RED("outputRaycastEnd")] public gameEffectOutputParameter_Vector OutputRaycastEnd { get; set; }
	[Ordinal(4)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	[Ordinal(5)] [RED("inputMinRayAngleDiff")] public gameEffectInputParameter_Float InputMinRayAngleDiff { get; set; }
	public gameEffectObjectProvider_PhysicalRayFan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakersDistanceReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public scnCheckSpeakersDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ImpactReactionTask : CVariable
{
	public ImpactReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workSelector : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
	[Ordinal(2)] [RED("idleAnim")] public CName IdleAnim { get; set; }
	[Ordinal(3)] [RED("maxClips")] public CInt8 MaxClips { get; set; }
	[Ordinal(4)] [RED("pauseBetweenLength")] public CFloat PauseBetweenLength { get; set; }
	[Ordinal(5)] [RED("pauseLengthDeviation")] public CFloat PauseLengthDeviation { get; set; }
	[Ordinal(6)] [RED("weights")] public CArray<CFloat> Weights { get; set; }
	[Ordinal(7)] [RED("pauseBlendOutTime")] public CFloat PauseBlendOutTime { get; set; }
	[Ordinal(8)] [RED("dontRepeatLastAnims")] public CInt8 DontRepeatLastAnims { get; set; }
	public workSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AimAtTargetCommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AimAtTargetCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCityAreaType : CVariable
{
	public gameCityAreaType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorVelocityOverLife : CVariable
{
	[Ordinal(0)] [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }
	public CParticleModificatorVelocityOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPaymentCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIPayment_ConditionType> Type { get; set; }
	public questPaymentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameFastTravelPointData : CVariable
{
	[Ordinal(0)] [RED("pointRecord")] public TweakDBID PointRecord { get; set; }
	[Ordinal(1)] [RED("markerRef")] public NodeRef MarkerRef { get; set; }
	public gameFastTravelPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GeometryShape : CVariable
{
	[Ordinal(0)] [RED("vertices")] public CArray<Vector3> Vertices { get; set; }
	[Ordinal(1)] [RED("indices")] public CArray<CUInt16> Indices { get; set; }
	public GeometryShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEBlendTypeLBC : CVariable
{
	public animEBlendTypeLBC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRecordingNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIRecordingNodeType> Type { get; set; }
	public questRecordingNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerMesh : CVariable
{
	[Ordinal(0)] [RED("meshes")] public CArray<rRef<CMesh>> Meshes { get; set; }
	public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnvironmentManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIEnvironmentManagerNodeType> Type { get; set; }
	public questEnvironmentManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerRotationRate3D : CVariable
{
	[Ordinal(0)] [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }
	public CParticleInitializerRotationRate3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetEntityDistanceReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	[Ordinal(2)] [RED("targetEntity")] public gameEntityReference TargetEntity { get; set; }
	public scnCheckPlayerTargetEntityDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckEquippedWeapon : CVariable
{
	[Ordinal(0)] [RED("slotID")] public CHandle<AIArgumentMapping> SlotID { get; set; }
	[Ordinal(1)] [RED("itemID")] public CHandle<AIArgumentMapping> ItemID { get; set; }
	public CheckEquippedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorComparisonExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("leftHandSide")] public CHandle<AIbehaviorExpressionSocket> LeftHandSide { get; set; }
	[Ordinal(1)] [RED("rightHandSide")] public CHandle<AIbehaviorExpressionSocket> RightHandSide { get; set; }
	public AIbehaviorComparisonExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Build_ScriptConditionType : CVariable
{
	[Ordinal(0)] [RED("questAssignment")] public TweakDBID QuestAssignment { get; set; }
	[Ordinal(1)] [RED("buildId")] public TweakDBID BuildId { get; set; }
	[Ordinal(2)] [RED("difficulty")] public EGameplayChallengeLevel Difficulty { get; set; }
	[Ordinal(3)] [RED("comparisonType")] public ECompareOp ComparisonType { get; set; }
	public Build_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NodeRef : CVariable
{
	public NodeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Root : CVariable
{
	[Ordinal(0)] [RED("nodes")] public CArray<CHandle<animAnimNode_Base>> Nodes { get; set; }
	public animAnimNode_Root(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransformAnimatorNode_Action_Reset : CVariable
{
	public questTransformAnimatorNode_Action_Reset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPhoneConversation : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
	public gameJournalPhoneConversation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MountCommandHandlerTask : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("mountEventData")] public CHandle<AIArgumentMapping> MountEventData { get; set; }
	[Ordinal(2)] [RED("callbackName")] public CName CallbackName { get; set; }
	public MountCommandHandlerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_Slide : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_Slide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCommandHandlerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("commandName")] public CName CommandName { get; set; }
	[Ordinal(2)] [RED("useInheritance")] public CBool UseInheritance { get; set; }
	[Ordinal(3)] [RED("commandOut")] public CHandle<AIArgumentMapping> CommandOut { get; set; }
	public AIbehaviorCommandHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnMarkerType : CVariable
{
	public scnMarkerType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameMultiPrereq : CVariable
{
	[Ordinal(0)] [RED("nestedPrereqs")] public CArray<CHandle<gameIPrereq>> NestedPrereqs { get; set; }
	public gameMultiPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceShootCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ForceShootCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GetTargetLastKnownPosition : CVariable
{
	[Ordinal(0)] [RED("inTargetObject")] public CHandle<AIArgumentMapping> InTargetObject { get; set; }
	[Ordinal(1)] [RED("outPosition")] public CHandle<AIArgumentMapping> OutPosition { get; set; }
	public GetTargetLastKnownPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointDrive : CVariable
{
	[Ordinal(0)] [RED("forceLimit")] public CFloat ForceLimit { get; set; }
	[Ordinal(1)] [RED("damping")] public CFloat Damping { get; set; }
	public physicsPhysicsJointDrive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_Effect : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("effectName")] public CName EffectName { get; set; }
	public animAnimEvent_Effect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ETimeOfYearSeason : CVariable
{
	public ETimeOfYearSeason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnToken_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("immediate")] public CBool Immediate { get; set; }
	public questSpawnToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("enterClosest")] public CHandle<AIArgumentMapping> EnterClosest { get; set; }
	[Ordinal(1)] [RED("avoidedPosition")] public CHandle<AIArgumentMapping> AvoidedPosition { get; set; }
	[Ordinal(2)] [RED("avoidedPositionDistance")] public CHandle<AIArgumentMapping> AvoidedPositionDistance { get; set; }
	[Ordinal(3)] [RED("usePreviousPosition")] public CHandle<AIArgumentMapping> UsePreviousPosition { get; set; }
	[Ordinal(4)] [RED("checkRoadIntersection")] public CHandle<AIArgumentMapping> CheckRoadIntersection { get; set; }
	[Ordinal(5)] [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }
	[Ordinal(6)] [RED("pathDirection")] public CHandle<AIArgumentMapping> PathDirection { get; set; }
	[Ordinal(7)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
	public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCommunityRegistryNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("spawnSetNameToCommunityID")] public gameCommunitySpawnSetNameToID SpawnSetNameToCommunityID { get; set; }
	[Ordinal(3)] [RED("crowdCreationRegistry")] public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry { get; set; }
	[Ordinal(4)] [RED("communitiesData")] public CArray<worldCommunityRegistryItem> CommunitiesData { get; set; }
	public worldCommunityRegistryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectPostAction_Beam_RicochetPreviewPreviewEffect : CVariable
{
	[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	[Ordinal(1)] [RED("effectTag")] public CName EffectTag { get; set; }
	[Ordinal(2)] [RED("effectSnap")] public raRef<worldEffect> EffectSnap { get; set; }
	[Ordinal(3)] [RED("effectSnapTag")] public CName EffectSnapTag { get; set; }
	[Ordinal(4)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
	public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsAttachToWorldParams : CVariable
{
	[Ordinal(0)] [RED("entityPosition")] public Vector3 EntityPosition { get; set; }
	public scnChoiceNodeNsAttachToWorldParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorldRenderAreaSettings : CVariable
{
	[Ordinal(0)] [RED("areaParameters")] public CArray<CHandle<IAreaSettings>> AreaParameters { get; set; }
	public WorldRenderAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_WorkspotPlayFacialAnim : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("facialAnimName")] public CName FacialAnimName { get; set; }
	public animAnimEvent_WorkspotPlayFacialAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetReactionPreset : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("recordSelector")] public CHandle<questReactionPresetRecordSelector> RecordSelector { get; set; }
	public questCharacterManagerParameters_SetReactionPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StopCallReinforcements : CVariable
{
	public StopCallReinforcements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleRadioTierEvent : CVariable
{
	public VehicleRadioTierEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDisplayMessageBox_NodeType : CVariable
{
	[Ordinal(0)] [RED("title")] public CString Title { get; set; }
	[Ordinal(1)] [RED("message")] public CString Message { get; set; }
	public questDisplayMessageBox_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleAudioVehicleCurveSet : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("curves")] public CArray<CurveSetEntry> Curves { get; set; }
	public vehicleAudioVehicleCurveSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUseWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(3)] [RED("paramsV1")] public CHandle<questUseWorkspotParamsV1> ParamsV1 { get; set; }
	public questUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDelegateExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("delegateAttribute")] public AIbehaviorDelegateAttrRef DelegateAttribute { get; set; }
	[Ordinal(1)] [RED("behaviorCallbackNames")] public CArray<CName> BehaviorCallbackNames { get; set; }
	public AIbehaviorDelegateExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTerrainCollisionNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("materials")] public CArray<CName> Materials { get; set; }
	[Ordinal(3)] [RED("materialIndices")] public CArray<Uint8> MaterialIndices { get; set; }
	[Ordinal(4)] [RED("heightfieldGeometry")] public serializationDeferredDataBuffer HeightfieldGeometry { get; set; }
	[Ordinal(5)] [RED("actorTransform")] public WorldTransform ActorTransform { get; set; }
	[Ordinal(6)] [RED("extents")] public Vector4 Extents { get; set; }
	[Ordinal(7)] [RED("rowScale")] public CFloat RowScale { get; set; }
	[Ordinal(8)] [RED("columnScale")] public CFloat ColumnScale { get; set; }
	[Ordinal(9)] [RED("heightScale")] public CFloat HeightScale { get; set; }
	[Ordinal(10)] [RED("increaseStreamingDistance")] public CBool IncreaseStreamingDistance { get; set; }
	public worldTerrainCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBriefingSequencePlayerFunction : CVariable
{
	public questBriefingSequencePlayerFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimMarkerEvent : CVariable
{
	[Ordinal(0)] [RED("markerName")] public CName MarkerName { get; set; }
	public inkanimMarkerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LookAtPose360Direction : CVariable
{
	public animAnimNode_LookAtPose360Direction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetCustomObjectDescriptionEvent : CVariable
{
	[Ordinal(0)] [RED("objectDescription")] public CHandle<ObjectScanningDescription> ObjectDescription { get; set; }
	public SetCustomObjectDescriptionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workSyncMasterEntryAnim : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("slotName")] public CName SlotName { get; set; }
	[Ordinal(3)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	public workSyncMasterEntryAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionTeleportTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("destinationPoint")] public CHandle<AIArgumentMapping> DestinationPoint { get; set; }
	[Ordinal(2)] [RED("doNavTest")] public CHandle<AIArgumentMapping> DoNavTest { get; set; }
	[Ordinal(3)] [RED("rotation")] public CHandle<AIArgumentMapping> Rotation { get; set; }
	public AIbehaviorActionTeleportTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitingKeepMountedCommandConditionDefinition : CVariable
{
	public AIbehaviorWaitingKeepMountedCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalEmail : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("sender")] public LocalizationString Sender { get; set; }
	[Ordinal(2)] [RED("addressee")] public LocalizationString Addressee { get; set; }
	[Ordinal(3)] [RED("title")] public LocalizationString Title { get; set; }
	[Ordinal(4)] [RED("content")] public LocalizationString Content { get; set; }
	public gameJournalEmail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldRotatingMeshNodeAxis : CVariable
{
	public worldRotatingMeshNodeAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSplineCompressedMotionExtraction : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("posKeysData")] public CArray<Uint8> PosKeysData { get; set; }
	[Ordinal(2)] [RED("rotKeysData")] public CArray<Uint8> RotKeysData { get; set; }
	public animSplineCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneTalking_ConditionType : CVariable
{
	[Ordinal(0)] [RED("GlobalEntityRef")] public gameEntityReference GlobalEntityRef { get; set; }
	[Ordinal(1)] [RED("isInverted")] public CBool IsInverted { get; set; }
	public questSceneTalking_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMaybeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	public AIbehaviorMaybeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsSectionClipboardDataHolder : CVariable
{
	[Ordinal(0)] [RED("backendNodeDescriptor")] public CHandle<toolsIGraphNodeDescriptor> BackendNodeDescriptor { get; set; }
	[Ordinal(1)] [RED("socketData")] public CArray<toolsSocketVisibilityData> SocketData { get; set; }
	[Ordinal(2)] [RED("uniqueNodeData")] public CHandle<toolsUniqueNodeData> UniqueNodeData { get; set; }
	[Ordinal(3)] [RED("variants")] public CArray<scnblocVariant> Variants { get; set; }
	[Ordinal(4)] [RED("section")] public toolsScreenplaySection Section { get; set; }
	[Ordinal(5)] [RED("actorData")] public CArray<scnbSceneActorData> ActorData { get; set; }
	public toolsSectionClipboardDataHolder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EAIRole : CVariable
{
	public EAIRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ActionWeightCondition : CVariable
{
	[Ordinal(0)] [RED("selectedActionIndex")] public CHandle<AIArgumentMapping> SelectedActionIndex { get; set; }
	[Ordinal(1)] [RED("thisIndex")] public CInt32 ThisIndex { get; set; }
	public ActionWeightCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DistantIrradianceeSettings : CVariable
{
	public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EAIDismembermentBodyPart : CVariable
{
	public EAIDismembermentBodyPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamDestructionBonds : CVariable
{
	[Ordinal(0)] [RED("bonds")] public CArray<meshDestructionBond> Bonds { get; set; }
	public meshMeshParamDestructionBonds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animCAnimationBufferBitwiseCompressed : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(1)] [RED("bones")] public CArray<animSAnimationBufferBitwiseCompressedBoneTrack> Bones { get; set; }
	[Ordinal(2)] [RED("data")] public CArray<CInt8> Data { get; set; }
	[Ordinal(3)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(4)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
	[Ordinal(5)] [RED("dt")] public CFloat Dt { get; set; }
	[Ordinal(6)] [RED("nonStreamableBones")] public CUInt32 NonStreamableBones { get; set; }
	public animCAnimationBufferBitwiseCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectPostAction_BulletExplode : CVariable
{
	public EffectPostAction_BulletExplode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rig")] public rRef<animRig> Rig { get; set; }
	[Ordinal(2)] [RED("info")] public animFacialSetup_BufferInfo Info { get; set; }
	[Ordinal(3)] [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
	[Ordinal(4)] [RED("bakedData")] public DataBuffer BakedData { get; set; }
	[Ordinal(5)] [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
	[Ordinal(6)] [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
	[Ordinal(7)] [RED("faceCorrectiveNames")] public CArray<CName> FaceCorrectiveNames { get; set; }
	[Ordinal(8)] [RED("tongueCorrectiveNames")] public CArray<CName> TongueCorrectiveNames { get; set; }
	[Ordinal(9)] [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
	[Ordinal(10)] [RED("version")] public CUInt32 Version { get; set; }
	public animFacialSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticStickerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("labels")] public CArray<CString> Labels { get; set; }
	[Ordinal(3)] [RED("textColor")] public CColor TextColor { get; set; }
	[Ordinal(4)] [RED("visibilityDistance")] public CFloat VisibilityDistance { get; set; }
	public worldStaticStickerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestEnableUIEvent : CVariable
{
	[Ordinal(0)] [RED("mode")] public vehicleQuestUIEnable Mode { get; set; }
	public VehicleQuestEnableUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWorkEntryId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public workWorkEntryId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetConveyorState_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	public questSetConveyorState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectEffectParameterEvaluatorColor : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorColor> Evaluator { get; set; }
	public effectEffectParameterEvaluatorColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlaylistTrackNode : CVariable
{
	[Ordinal(0)] [RED("playlistEvents")] public CArray<audioPlaylistTrackEventStruct> PlaylistEvents { get; set; }
	public questPlaylistTrackNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameMountingSlotRole : CVariable
{
	public gameMountingSlotRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_AnimEvent : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimStateTransitionCondition_AnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class locVoiceoverContext : CVariable
{
	public locVoiceoverContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questOpenMessage_NodeType : CVariable
{
	[Ordinal(0)] [RED("msg")] public CHandle<gameJournalPath> Msg { get; set; }
	public questOpenMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlayDefaultMountedSlotWorkspotEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(3)] [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
	[Ordinal(4)] [RED("slotName")] public CName SlotName { get; set; }
	public scnPlayDefaultMountedSlotWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ToggleVisibleObjectComponent : CVariable
{
	[Ordinal(0)] [RED("componentTargetState")] public CBool ComponentTargetState { get; set; }
	[Ordinal(1)] [RED("visibleObjectDescription")] public CName VisibleObjectDescription { get; set; }
	public ToggleVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableProvider_MultiBlend : CVariable
{
	[Ordinal(0)] [RED("type")] public animMotionTableType Type { get; set; }
	[Ordinal(1)] [RED("action")] public animMotionTableAction Action { get; set; }
	public animMotionTableProvider_MultiBlend(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorConstantExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("type")] public AIbehaviorTypeRef Type { get; set; }
	[Ordinal(1)] [RED("value")] public Variant Value { get; set; }
	public AIbehaviorConstantExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsColliderConvex : CVariable
{
	[Ordinal(0)] [RED("localToBody")] public Transform LocalToBody { get; set; }
	[Ordinal(1)] [RED("material")] public CName Material { get; set; }
	[Ordinal(2)] [RED("compiledGeometryBuffer")] public DataBuffer CompiledGeometryBuffer { get; set; }
	public physicsColliderConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HearStimThreshold : CVariable
{
	[Ordinal(0)] [RED("thresholdNumber")] public CInt32 ThresholdNumber { get; set; }
	public HearStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnGameplayActionEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("gameplayActionData")] public CHandle<scnIGameplayActionData> GameplayActionData { get; set; }
	public scnGameplayActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AITrafficWorkspotCompiled : CVariable
{
public AITrafficWorkspotCompiled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISetHealthRegenerationState : CVariable
{
	public AISetHealthRegenerationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class aousticcSector14670276 : CVariable
{
	public aousticcSector14670276(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InCombatHighLevelState : CVariable
{
	public InCombatHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class VolumetricFogAreaSettings : CVariable
{
	[Ordinal(0)] [RED("albedo")] public curveData<HDRColor> Albedo { get; set; }
	[Ordinal(1)] [RED("range")] public curveData<CFloat> Range { get; set; }
	[Ordinal(2)] [RED("fogHeight")] public curveData<CFloat> FogHeight { get; set; }
	[Ordinal(3)] [RED("density")] public curveData<CFloat> Density { get; set; }
	[Ordinal(4)] [RED("absorption")] public curveData<CFloat> Absorption { get; set; }
	[Ordinal(5)] [RED("ambientScale")] public curveData<CFloat> AmbientScale { get; set; }
	[Ordinal(6)] [RED("globalLightScale")] public curveData<CFloat> GlobalLightScale { get; set; }
	[Ordinal(7)] [RED("globalLightAnisotropy")] public curveData<CFloat> GlobalLightAnisotropy { get; set; }
	[Ordinal(8)] [RED("localLightRange")] public curveData<CFloat> LocalLightRange { get; set; }
	public VolumetricFogAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FixedPoint : CVariable
{
	[Ordinal(0)] [RED("Bits")] public CInt32 Bits { get; set; }
	public FixedPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInputAction_ConditionType : CVariable
{
	[Ordinal(0)] [RED("inputAction")] public CName InputAction { get; set; }
	[Ordinal(1)] [RED("axisAction")] public CBool AxisAction { get; set; }
	[Ordinal(2)] [RED("valueMoreThan")] public CFloat ValueMoreThan { get; set; }
	public questInputAction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questObservableUniversalRef : CVariable
{
	[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(1)] [RED("refLocalPlayer")] public CBool RefLocalPlayer { get; set; }
	public questObservableUniversalRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_OverrideMaterial : CVariable
{
	[Ordinal(0)] [RED("material")] public rRef<IMaterial> Material { get; set; }
	public gameEffectExecutor_OverrideMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_PingNetwork : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
	public EffectExecutor_PingNetwork(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterruptCapability : CVariable
{
	public scnInterruptCapability(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsFollowTargetInCombat : CVariable
{
	public IsFollowTargetInCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSplineAdditionalParams : CVariable
{
	[Ordinal(0)] [RED("simpleParams")] public questSimpleMoveOnSplineParams SimpleParams { get; set; }
	[Ordinal(1)] [RED("withCompanionParams")] public questWithCompanionMoveOnSplineParams WithCompanionParams { get; set; }
	public questMoveOnSplineAdditionalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AimConstraint : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
	[Ordinal(5)] [RED("targetTransforms")] public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> TargetTransforms { get; set; }
	[Ordinal(6)] [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
	[Ordinal(7)] [RED("upTransform")] public CHandle<animIAnimNodeSourceChannel_Vector> UpTransform { get; set; }
	[Ordinal(8)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(9)] [RED("forwardAxisLS")] public Vector3 ForwardAxisLS { get; set; }
	[Ordinal(10)] [RED("upAxisLS")] public Vector3 UpAxisLS { get; set; }
	public animAnimNode_AimConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_LandingFX : CVariable
{
	public gameEffectExecutor_LandingFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLogicalXorNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questLogicalXorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetEntityDistanceReturnCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckPlayerTargetEntityDistanceReturnConditionParams Params { get; set; }
	public scnCheckPlayerTargetEntityDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
	public AIbehaviorConvertCommandToDynamicWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentLaneConnectionsResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldTrafficPersistentLaneConnectionsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendSpace_InternalsBlendSpace : CVariable
{
	[Ordinal(0)] [RED("spaceDimension")] public CUInt32 SpaceDimension { get; set; }
	[Ordinal(1)] [RED("coordinatesDescriptions")] public CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> CoordinatesDescriptions { get; set; }
	[Ordinal(2)] [RED("spacePoints")] public CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> SpacePoints { get; set; }
	[Ordinal(3)] [RED("boundaryPointsCount")] public CUInt32 BoundaryPointsCount { get; set; }
	[Ordinal(4)] [RED("needsRuntimeTriangulation")] public CBool NeedsRuntimeTriangulation { get; set; }
	[Ordinal(5)] [RED("wasRuntimeTriangulationResaveDone")] public CBool WasRuntimeTriangulationResaveDone { get; set; }
	public animAnimNode_BlendSpace_InternalsBlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetCustomStyle_NodeType : CVariable
{
	[Ordinal(0)] [RED("isActive")] public CBool IsActive { get; set; }
	public questSetCustomStyle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorVectorMultiCurve : CVariable
{
	[Ordinal(0)] [RED("freeAxes")] public EFreeVectorAxes FreeAxes { get; set; }
	[Ordinal(1)] [RED("curves")] public multiChannelCurve<CFloat> Curves { get; set; }
	public CEvaluatorVectorMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EMPExplosion : CVariable
{
	public EMPExplosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayInitFearAnimation : CVariable
{
	public PlayInitFearAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animConditionalSegmentCondition : CVariable
{
	[Ordinal(0)] [RED("lod")] public CInt32 Lod { get; set; }
	public animConditionalSegmentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowLevelUpNotification_NodeType : CVariable
{
	[Ordinal(0)] [RED("levelUpData")] public questLevelUpData LevelUpData { get; set; }
	public questShowLevelUpNotification_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamUICollisionData : CVariable
{
	[Ordinal(0)] [RED("uvs")] public CArray<Vector2> Uvs { get; set; }
	[Ordinal(1)] [RED("trianglesIndices")] public CArray<CUInt16> TrianglesIndices { get; set; }
	[Ordinal(2)] [RED("vertices")] public CArray<Vector3> Vertices { get; set; }
	public meshMeshParamUICollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSelectWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("spotInstance")] public CHandle<AIArgumentMapping> SpotInstance { get; set; }
	[Ordinal(2)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(3)] [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
	[Ordinal(4)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
	public AIbehaviorSelectWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ShouldExitVehicle : CVariable
{
	public ShouldExitVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMaybeNodeAction : CVariable
{
	public AIbehaviorMaybeNodeAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshAppearance : CVariable
{
	[Ordinal(0)] [RED("chunkMaterials")] public CArray<CName> ChunkMaterials { get; set; }
	public meshMeshAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectTriggerRotationType : CVariable
{
	public gameEffectTriggerRotationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animActionAnimDatabase : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rows")] public CArray<animActionAnimDatabase_DatabaseRow> Rows { get; set; }
	public animActionAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBuild_ConditionType : CVariable
{
	[Ordinal(0)] [RED("scriptCondition")] public CHandle<IScriptable> ScriptCondition { get; set; }
	public questBuild_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_EnumSwitch : CVariable
{
	[Ordinal(0)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	[Ordinal(1)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
	[Ordinal(2)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
	[Ordinal(3)] [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }
	[Ordinal(4)] [RED("selectIntNode")] public animIntLink SelectIntNode { get; set; }
	[Ordinal(5)] [RED("enumName")] public CName EnumName { get; set; }
	public animAnimNode_EnumSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimRotationInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(4)] [RED("startValue")] public CFloat StartValue { get; set; }
	[Ordinal(5)] [RED("endValue")] public CFloat EndValue { get; set; }
	public inkanimRotationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workFastExit : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	public workFastExit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMovementPolicyTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("useCurrentPolicy")] public CBool UseCurrentPolicy { get; set; }
	[Ordinal(1)] [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
	[Ordinal(2)] [RED("policies")] public CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> Policies { get; set; }
	public AIbehaviorMovementPolicyTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCompleteOnEventNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("resultOnEvent")] public AIbehaviorCompletionStatus ResultOnEvent { get; set; }
	public AIbehaviorCompleteOnEventNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneCategoryTag : CVariable
{
	public scnSceneCategoryTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EEmitterGroup : CVariable
{
	public EEmitterGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CombatConditions : CVariable
{
	public CombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ShootCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ShootCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindanceLayer_ConditionType : CVariable
{
	[Ordinal(0)] [RED("layer")] public scnBraindanceLayer Layer { get; set; }
	[Ordinal(1)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindanceLayer_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStartVehicle_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	public questStartVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorVectorStartEnd : CVariable
{
	[Ordinal(0)] [RED("freeAxes")] public EFreeVectorAxes FreeAxes { get; set; }
	[Ordinal(1)] [RED("start")] public Vector4 Start { get; set; }
	[Ordinal(2)] [RED("end")] public Vector4 End { get; set; }
	public CEvaluatorVectorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseInfoLoggerEntry_Transform : CVariable
{
	[Ordinal(0)] [RED("transform")] public animTransformIndex Transform { get; set; }
	public animPoseInfoLoggerEntry_Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_VisualEffect : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	[Ordinal(2)] [RED("attached")] public CBool Attached { get; set; }
	[Ordinal(3)] [RED("breakLoopOnDetach")] public CBool BreakLoopOnDetach { get; set; }
	[Ordinal(4)] [RED("effectTag")] public CName EffectTag { get; set; }
	[Ordinal(5)] [RED("vectorEvaluator")] public CHandle<gameEffectVectorEvaluator> VectorEvaluator { get; set; }
	public gameEffectExecutor_VisualEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEndNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	public scnEndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRealtimeDelay_ConditionType : CVariable
{
	[Ordinal(0)] [RED("seconds")] public CUInt32 Seconds { get; set; }
	public questRealtimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SendPatrolEndSignal : CVariable
{
	public SendPatrolEndSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questICharacterManager_NodeType> Type { get; set; }
	public questCharacterManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkMargin : CVariable
{
	[Ordinal(0)] [RED("left")] public CFloat Left { get; set; }
	public inkMargin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UndressPlayer : CVariable
{
	public UndressPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCreditsRolling_ConditionType : CVariable
{
	public questCreditsRolling_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMountedObjectInfo : CVariable
{
	[Ordinal(0)] [RED("isFirst")] public CBool IsFirst { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(2)] [RED("role")] public gameMountingSlotRole Role { get; set; }
	public questMountedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageDestructionNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("compiledData")] public DataBuffer CompiledData { get; set; }
	[Ordinal(3)] [RED("numActors")] public CUInt16 NumActors { get; set; }
	[Ordinal(4)] [RED("numShapeInfos")] public CUInt16 NumShapeInfos { get; set; }
	[Ordinal(5)] [RED("numShapePositions")] public CUInt16 NumShapePositions { get; set; }
	[Ordinal(6)] [RED("numScales")] public CUInt16 NumScales { get; set; }
	[Ordinal(7)] [RED("numMaterials")] public CUInt16 NumMaterials { get; set; }
	[Ordinal(8)] [RED("numPresets")] public CUInt16 NumPresets { get; set; }
	[Ordinal(9)] [RED("numMaterialIndices")] public CUInt16 NumMaterialIndices { get; set; }
	[Ordinal(10)] [RED("numShapeIndices")] public CUInt16 NumShapeIndices { get; set; }
	[Ordinal(11)] [RED("extents")] public Vector4 Extents { get; set; }
	[Ordinal(12)] [RED("lod")] public CUInt8 Lod { get; set; }
	[Ordinal(13)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
	[Ordinal(14)] [RED("populationIndex")] public CArray<CUInt32> PopulationIndex { get; set; }
	[Ordinal(15)] [RED("foliageResourceHash")] public CUInt64 FoliageResourceHash { get; set; }
	[Ordinal(16)] [RED("dataVersion")] public CUInt32 DataVersion { get; set; }
	public worldFoliageDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverridePhantomParamsEventParams : CVariable
{
	[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }
	public scnOverridePhantomParamsEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSharedDataBuffer : CVariable
{
	[Ordinal(0)] [RED("buffer")] public DataBuffer Buffer { get; set; }
	public worldSharedDataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAudioAttractAreaNotifier : CVariable
{
	public worldAudioAttractAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableProvider_Default : CVariable
{
	[Ordinal(0)] [RED("type")] public animMotionTableType Type { get; set; }
	[Ordinal(1)] [RED("action")] public animMotionTableAction Action { get; set; }
	public animMotionTableProvider_Default(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAmbientAreaGroupingSettings : CVariable
{
	[Ordinal(0)] [RED("GroupCountTag")] public CName GroupCountTag { get; set; }
	[Ordinal(1)] [RED("GroupCountRtpc")] public CName GroupCountRtpc { get; set; }
	[Ordinal(2)] [RED("groupingVariant")] public audioAmbientGroupingVariant GroupingVariant { get; set; }
	[Ordinal(3)] [RED("MaxDistance")] public CFloat MaxDistance { get; set; }
	public audioAmbientAreaGroupingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestMultiMapPin : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("references")] public CArray<NodeRef> References { get; set; }
	public gameJournalQuestMultiMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetTimestampToBehaviorAgrument : CVariable
{
	[Ordinal(0)] [RED("timestampArgument")] public CName TimestampArgument { get; set; }
	public SetTimestampToBehaviorAgrument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneWorkspotDataId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnSceneWorkspotDataId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamDeformableShapesData : CVariable
{
	[Ordinal(0)] [RED("ownerIndex")] public CArray<Uint8> OwnerIndex { get; set; }
	[Ordinal(1)] [RED("startingPose")] public CArray<Transform> StartingPose { get; set; }
	[Ordinal(2)] [RED("finalPose")] public CArray<Transform> FinalPose { get; set; }
	public meshMeshParamDeformableShapesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimSequenceTargetInfo : CVariable
{
	[Ordinal(0)] [RED("path")] public CArray<CUInt32> Path { get; set; }
	public inkanimSequenceTargetInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioRadioSpeakerType : CVariable
{
	public audioRadioSpeakerType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StandState : CVariable
{
	public StandState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GuardbreakReactionTask : CVariable
{
	public GuardbreakReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerVisuals_GenitalsManager : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
	public questCharacterManagerVisuals_GenitalsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldRotatingMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(3)] [RED("occluderType")] public visWorldOccluderType OccluderType { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("rotationAxis")] public worldRotatingMeshNodeAxis RotationAxis { get; set; }
	[Ordinal(6)] [RED("fullRotationTime")] public CFloat FullRotationTime { get; set; }
	[Ordinal(7)] [RED("reverseDirection")] public CBool ReverseDirection { get; set; }
	public worldRotatingMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerLifeTime : CVariable
{
	[Ordinal(0)] [RED("lifeTime")] public CHandle<IEvaluatorFloat> LifeTime { get; set; }
	public CParticleInitializerLifeTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorInfluenceExcludeObstaclePointTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(1)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	public AIbehaviorInfluenceExcludeObstaclePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleVisionMode_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questToggleVisionMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorAlphaOverEffect : CVariable
{
	public CParticleModificatorAlphaOverEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAssignRoleCommandParams : CVariable
{
	[Ordinal(0)] [RED("role")] public CHandle<AIRole> Role { get; set; }
	public AIAssignRoleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldLightChannelVolumeNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("channels")] public rendLightChannel Channels { get; set; }
	public worldLightChannelVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimVariableVector : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public animAnimVariableVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForcedRagdollDeathTask : CVariable
{
	public ForcedRagdollDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animGenericAnimDatabase : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rows")] public CArray<animGenericAnimDatabase_DatabaseRow> Rows { get; set; }
	public animGenericAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemSound : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(2)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(3)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(4)] [RED("positionName")] public CName PositionName { get; set; }
	[Ordinal(5)] [RED("rtpcValue")] public CHandle<IEvaluatorFloat> RtpcValue { get; set; }
	public effectTrackItemSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTeleportPuppetParams : CVariable
{
	[Ordinal(0)] [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }
	public questTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ResolveAllSkillchecksEvent : CVariable
{
	public ResolveAllSkillchecksEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerCombatInterruptCondition : CVariable
{
	public scnCheckPlayerCombatInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_SweepMelee_Box : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_SweepMelee_Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialCustomizationSet : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("baseSetup")] public rRef<animFacialSetup> BaseSetup { get; set; }
	[Ordinal(2)] [RED("targetSetups")] public CArray<raRef<animFacialSetup>> TargetSetups { get; set; }
	[Ordinal(3)] [RED("targetSetupsTemp")] public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp { get; set; }
	[Ordinal(4)] [RED("numTargets")] public CUInt32 NumTargets { get; set; }
	[Ordinal(5)] [RED("posesInfo")] public animFacialSetup_PosesBufferInfo PosesInfo { get; set; }
	[Ordinal(6)] [RED("jointRegions")] public CArray<Uint8> JointRegions { get; set; }
	[Ordinal(7)] [RED("mainPosesData")] public DataBuffer MainPosesData { get; set; }
	[Ordinal(8)] [RED("usedTransformIndices")] public CArray<CUInt16> UsedTransformIndices { get; set; }
	[Ordinal(9)] [RED("correctivePosesData")] public DataBuffer CorrectivePosesData { get; set; }
	[Ordinal(10)] [RED("numJoints")] public CUInt32 NumJoints { get; set; }
	[Ordinal(11)] [RED("rigReferencePosesData")] public DataBuffer RigReferencePosesData { get; set; }
	[Ordinal(12)] [RED("isCooked")] public CBool IsCooked { get; set; }
	public animFacialCustomizationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorColorCurve : CVariable
{
	[Ordinal(0)] [RED("curves")] public curveData<Vector4> Curves { get; set; }
	public CEvaluatorColorCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsVisualizerStyle : CVariable
{
	public scnChoiceNodeNsVisualizerStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleEventReceiverSpawn : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public CParticleEventReceiverSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NPCGrappledByPlayerPrereq : CVariable
{
	public NPCGrappledByPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorSizeByDistance : CVariable
{
	[Ordinal(0)] [RED("nearDistanceRangeStart")] public CHandle<IEvaluatorFloat> NearDistanceRangeStart { get; set; }
	[Ordinal(1)] [RED("nearDistanceRangeEnd")] public CHandle<IEvaluatorFloat> NearDistanceRangeEnd { get; set; }
	[Ordinal(2)] [RED("nearDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier { get; set; }
	[Ordinal(3)] [RED("farDistanceRangeStart")] public CHandle<IEvaluatorFloat> FarDistanceRangeStart { get; set; }
	[Ordinal(4)] [RED("farDistanceRangeEnd")] public CHandle<IEvaluatorFloat> FarDistanceRangeEnd { get; set; }
	[Ordinal(5)] [RED("farDistanceSizeMultiplier")] public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier { get; set; }
	public CParticleModificatorSizeByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questFlushAutopilot_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questFlushAutopilot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameLocationResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public gameLocationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableProvider_Animation : CVariable
{
	[Ordinal(0)] [RED("type")] public animMotionTableType Type { get; set; }
	[Ordinal(1)] [RED("action")] public animMotionTableAction Action { get; set; }
	public animMotionTableProvider_Animation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetTrafficLaneMovementParams : CVariable
{
	[Ordinal(0)] [RED("movementType")] public CString MovementType { get; set; }
	[Ordinal(1)] [RED("fearStage")] public gameFearStage FearStage { get; set; }
	public SetTrafficLaneMovementParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SBraindanceInputMask : CVariable
{
	[Ordinal(0)] [RED("pauseAction")] public CBool PauseAction { get; set; }
	[Ordinal(1)] [RED("playForwardAction")] public CBool PlayForwardAction { get; set; }
	[Ordinal(2)] [RED("playBackwardAction")] public CBool PlayBackwardAction { get; set; }
	[Ordinal(3)] [RED("restartAction")] public CBool RestartAction { get; set; }
	[Ordinal(4)] [RED("switchLayerAction")] public CBool SwitchLayerAction { get; set; }
	[Ordinal(5)] [RED("cameraToggleAction")] public CBool CameraToggleAction { get; set; }
	public SBraindanceInputMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReactionManagerTask : CVariable
{
	public ReactionManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneCallMode_ConditionType : CVariable
{
	[Ordinal(0)] [RED("inverted")] public CBool Inverted { get; set; }
	[Ordinal(1)] [RED("callMode")] public questPhoneCallMode CallMode { get; set; }
	public questPhoneCallMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDelegateTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("onActivate")] public AIbehaviorDelegateTaskRef OnActivate { get; set; }
	[Ordinal(1)] [RED("onDeactivate")] public AIbehaviorDelegateTaskRef OnDeactivate { get; set; }
	public AIbehaviorDelegateTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCheckpointNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("debugString")] public CString DebugString { get; set; }
	public questCheckpointNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ValueBySpeed : CVariable
{
	[Ordinal(0)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
	[Ordinal(1)] [RED("speed")] public animFloatLink Speed { get; set; }
	public animAnimNode_ValueBySpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DynamicTexture : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("width")] public CUInt32 Width { get; set; }
	[Ordinal(2)] [RED("height")] public CUInt32 Height { get; set; }
	[Ordinal(3)] [RED("generator")] public CHandle<IDynamicTextureGenerator> Generator { get; set; }
	public DynamicTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPhysicalImpulseAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("shape")] public physicsTriggerShape Shape { get; set; }
	[Ordinal(3)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	[Ordinal(4)] [RED("impulse")] public Vector3 Impulse { get; set; }
	[Ordinal(5)] [RED("impulseRadius")] public CFloat ImpulseRadius { get; set; }
	public worldPhysicalImpulseAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionUnequipItemNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("slotId")] public CHandle<AIArgumentMapping> SlotId { get; set; }
	[Ordinal(2)] [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
	public AIbehaviorActionUnequipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTimePeriod_ConditionType : CVariable
{
	[Ordinal(0)] [RED("begin")] public GameTime Begin { get; set; }
	[Ordinal(1)] [RED("end")] public GameTime End { get; set; }
	public questTimePeriod_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorUnmountImmediatelyNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	public AIbehaviorUnmountImmediatelyNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsAttachPropToPerformer : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("propId")] public scnPropId PropId { get; set; }
	[Ordinal(4)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(5)] [RED("slot")] public CName Slot { get; set; }
	[Ordinal(6)] [RED("offsetMode")] public scnOffsetMode OffsetMode { get; set; }
	public scneventsAttachPropToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderTextureBlobPC : CVariable
{
	[Ordinal(0)] [RED("header")] public rendRenderTextureBlobHeader Header { get; set; }
	[Ordinal(1)] [RED("textureData")] public serializationDeferredDataBuffer TextureData { get; set; }
	public rendRenderTextureBlobPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GameplayTier : CVariable
{
	public GameplayTier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnMarker : CVariable
{
	[Ordinal(0)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	public scnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInvalidProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
	public worldInvalidProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_KillFX : CVariable
{
	[Ordinal(0)] [RED("action")] public gameEffectAction_KillFXAction Action { get; set; }
	[Ordinal(1)] [RED("effectTag")] public CName EffectTag { get; set; }
	public gameEffectAction_KillFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderTextureBlobSizeInfo : CVariable
{
	[Ordinal(0)] [RED("width")] public CUInt16 Width { get; set; }
	[Ordinal(1)] [RED("height")] public CUInt16 Height { get; set; }
	[Ordinal(2)] [RED("depth")] public CUInt16 Depth { get; set; }
	public rendRenderTextureBlobSizeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DistantLightsAreaSettings : CVariable
{
	public DistantLightsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimSet : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("animations")] public CArray<CHandle<animAnimSetEntry>> Animations { get; set; }
	[Ordinal(2)] [RED("animationDataChunks")] public CArray<animAnimDataChunk> AnimationDataChunks { get; set; }
	[Ordinal(3)] [RED("rig")] public rRef<animRig> Rig { get; set; }
	[Ordinal(4)] [RED("tags")] public redTagList Tags { get; set; }
	[Ordinal(5)] [RED("version")] public CUInt32 Version { get; set; }
	public animAnimSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkTextureType : CVariable
{
	public inkTextureType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialEmotionTransitionBaked : CVariable
{
	[Ordinal(0)] [RED("toIdleMale")] public CName ToIdleMale { get; set; }
	[Ordinal(1)] [RED("toIdleFemale")] public CName ToIdleFemale { get; set; }
	[Ordinal(2)] [RED("transitionType")] public animFacialEmotionTransitionType TransitionType { get; set; }
	[Ordinal(3)] [RED("transitionDuration")] public CFloat TransitionDuration { get; set; }
	[Ordinal(4)] [RED("timeScale")] public CFloat TimeScale { get; set; }
	[Ordinal(5)] [RED("toIdleNeckWeight")] public CFloat ToIdleNeckWeight { get; set; }
	[Ordinal(6)] [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
	public animFacialEmotionTransitionBaked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDistantLightsNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("data")] public raRef<CDistantLightsResource> Data { get; set; }
	public worldDistantLightsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DeviceScanningDescription : CVariable
{
	[Ordinal(0)] [RED("DeviceGameplayDescription")] public TweakDBID DeviceGameplayDescription { get; set; }
	public DeviceScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetPanicOnTrafficLane : CVariable
{
	public SetPanicOnTrafficLane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_QuaternionInput : CVariable
{
	[Ordinal(0)] [RED("group")] public CName Group { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	public animAnimNode_QuaternionInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterestingConversationsResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("conversationGroups")] public CArray<CHandle<scnInterestingConversationsGroup>> ConversationGroups { get; set; }
	public scnInterestingConversationsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animVisualTagCondition : CVariable
{
	[Ordinal(0)] [RED("visualTag")] public CName VisualTag { get; set; }
	public animVisualTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerManageBinkComponent_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questEntityManagerManageBinkComponent_NodeTypeParams> Params { get; set; }
	public questEntityManagerManageBinkComponent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_NewEffect_CopyData : CVariable
{
	[Ordinal(0)] [RED("tagInThisFile")] public CName TagInThisFile { get; set; }
	public gameEffectExecutor_NewEffect_CopyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalInternetSite : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("shortName")] public LocalizationString ShortName { get; set; }
	[Ordinal(3)] [RED("mainPagePath")] public CHandle<gameJournalPath> MainPagePath { get; set; }
	[Ordinal(4)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
	[Ordinal(5)] [RED("texturePart")] public CName TexturePart { get; set; }
	public gameJournalInternetSite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPlaneUncompressedMotionExtraction : CVariable
{
	[Ordinal(0)] [RED("frames")] public CArray<Vector3> Frames { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	public animPlaneUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentMapping : CVariable
{
	[Ordinal(0)] [RED("parameterizationType")] public AIParameterizationType ParameterizationType { get; set; }
	[Ordinal(1)] [RED("customTypeName")] public CName CustomTypeName { get; set; }
	public AIArgumentMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDelegateAttrRef : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIbehaviorDelegateAttrRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDyngConstraintMulti : CVariable
{
	[Ordinal(0)] [RED("innerConstraints")] public CArray<CHandle<animIDyngConstraint>> InnerConstraints { get; set; }
	public animDyngConstraintMulti(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPhoneChoiceGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalPhoneChoiceGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CIESDataResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("samples", 128)] public CArrayFixedSize<Uint8> Samples { get; set; }
public CIESDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsLookAtPredicate : CVariable
{
	[Ordinal(0)] [RED("testType")] public gameinteractionsELookAtTest TestType { get; set; }
	[Ordinal(1)] [RED("stopOnTransparent")] public CBool StopOnTransparent { get; set; }
	public gameinteractionsLookAtPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CustomUIAnimationEvent : CVariable
{
	[Ordinal(0)] [RED("libraryItemName")] public CName LibraryItemName { get; set; }
	[Ordinal(1)] [RED("forceRespawnLibraryItem")] public CBool ForceRespawnLibraryItem { get; set; }
	[Ordinal(2)] [RED("animationName")] public CName AnimationName { get; set; }
	[Ordinal(3)] [RED("animOptionsOverride")] public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride { get; set; }
	public CustomUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveNoWeaponCombatConditions : CVariable
{
	public PassiveNoWeaponCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleState : CVariable
{
	public VehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_GameplayVo : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(1)] [RED("voContext")] public CName VoContext { get; set; }
	public animAnimEvent_GameplayVo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsSetAnimFeatureEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("actorId")] public scnActorId ActorId { get; set; }
	[Ordinal(4)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
	[Ordinal(5)] [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }
	public scneventsSetAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISetCombatPresetCommandParams : CVariable
{
	[Ordinal(0)] [RED("combatPreset")] public EAICombatPreset CombatPreset { get; set; }
	public AISetCombatPresetCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMeshBlob : CVariable
{
	[Ordinal(0)] [RED("header")] public rendRenderMeshBlobHeader Header { get; set; }
	[Ordinal(1)] [RED("renderBuffer")] public DataBuffer RenderBuffer { get; set; }
	public rendRenderMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPaddingInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	public inkanimPaddingInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioQuadEmitterSettings : CVariable
{
	[Ordinal(0)] [RED("Enabled")] public CBool Enabled { get; set; }
	[Ordinal(1)] [RED("Radius")] public CFloat Radius { get; set; }
	[Ordinal(2)] [RED("Events", 4)] public CArrayFixedSize<audioAudEventStruct> Events { get; set; }
public audioQuadEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ParentConstraint : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("parentTransform")] public CHandle<animIAnimNodeSourceChannel_QsTransform> ParentTransform { get; set; }
	[Ordinal(5)] [RED("isParentTransformResaved")] public CBool IsParentTransformResaved { get; set; }
	[Ordinal(6)] [RED("parentTransformIndex")] public animTransformIndex ParentTransformIndex { get; set; }
	[Ordinal(7)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(8)] [RED("offsetEulerRotationLS")] public animVectorLink OffsetEulerRotationLS { get; set; }
	public animAnimNode_ParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInputDevice : CVariable
{
	public questInputDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_QuerySphere : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_QuerySphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIJoinTargetsSquadCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }
	public AIJoinTargetsSquadCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDecorationMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(3)] [RED("occluderType")] public visWorldOccluderType OccluderType { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public worldDecorationMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IntLatch : CVariable
{
	[Ordinal(0)] [RED("input")] public animIntLink Input { get; set; }
	public animAnimNode_IntLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitSummonConditionDefinition : CVariable
{
	public AIbehaviorWaitSummonConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCrowdManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questICrowdManager_NodeType> Type { get; set; }
	public questCrowdManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderTextureBlobTextureInfo : CVariable
{
	[Ordinal(0)] [RED("textureDataSize")] public CUInt32 TextureDataSize { get; set; }
	[Ordinal(1)] [RED("sliceSize")] public CUInt32 SliceSize { get; set; }
	[Ordinal(2)] [RED("dataAlignment")] public CUInt32 DataAlignment { get; set; }
	[Ordinal(3)] [RED("sliceCount")] public CUInt16 SliceCount { get; set; }
	[Ordinal(4)] [RED("mipCount")] public CUInt8 MipCount { get; set; }
	public rendRenderTextureBlobTextureInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandEscalation : CVariable
{
	public ReprimandEscalation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderTextureBlobHeader : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(1)] [RED("sizeInfo")] public rendRenderTextureBlobSizeInfo SizeInfo { get; set; }
	[Ordinal(2)] [RED("textureInfo")] public rendRenderTextureBlobTextureInfo TextureInfo { get; set; }
	[Ordinal(3)] [RED("mipMapInfo")] public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo { get; set; }
	[Ordinal(4)] [RED("flags")] public CUInt32 Flags { get; set; }
	public rendRenderTextureBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRewardManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIRewardManagerNodeType> Type { get; set; }
	public questRewardManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneCallMode : CVariable
{
	public questPhoneCallMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseBlendMethod_BoneBranch : CVariable
{
	[Ordinal(0)] [RED("bones")] public CArray<animOverrideBlendBoneInfo> Bones { get; set; }
	public animPoseBlendMethod_BoneBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animHitReactionType : CVariable
{
	public animHitReactionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_RotationLimit : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
	[Ordinal(5)] [RED("limitOnX")] public animSmoothFloatClamp LimitOnX { get; set; }
	[Ordinal(6)] [RED("limitOnY")] public animSmoothFloatClamp LimitOnY { get; set; }
	[Ordinal(7)] [RED("limitOnZ")] public animSmoothFloatClamp LimitOnZ { get; set; }
	public animAnimNode_RotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerSpawnSphere : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("innerRadius")] public CHandle<IEvaluatorFloat> InnerRadius { get; set; }
	[Ordinal(2)] [RED("outerRadius")] public CHandle<IEvaluatorFloat> OuterRadius { get; set; }
	[Ordinal(3)] [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
	public CParticleInitializerSpawnSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckHighLevelState : CVariable
{
	[Ordinal(0)] [RED("state")] public gamedataNPCHighLevelState State { get; set; }
	public CheckHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestPointOfInterestMapPin : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	public gameJournalQuestPointOfInterestMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleWeaponQuestID : CVariable
{
	public questVehicleWeaponQuestID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LODBegin : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("levelOfDetail")] public CUInt32 LevelOfDetail { get; set; }
	public animAnimNode_LODBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class EnableFastTravelRequest : CVariable
{
	[Ordinal(0)] [RED("reason")] public CName Reason { get; set; }
	public EnableFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workUnequipItemAction : CVariable
{
	[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }
	public workUnequipItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPatrolSplinePointDefinition : CVariable
{
	[Ordinal(0)] [RED("node")] public NodeRef Node { get; set; }
	public worldPatrolSplinePointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class worldAdvertisementNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("format")] public AdvertisementFormat Format { get; set; }
	[Ordinal(6)] [RED("adGroupTDBID")] public TweakDBID AdGroupTDBID { get; set; }
	[Ordinal(7)] [RED("lightsData")] public CArray<worldAdvertisementLightData> LightsData { get; set; }
	public worldAdvertisementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMountEventResolverDefinition : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(2)] [RED("isInstant")] public CHandle<AIArgumentMapping> IsInstant { get; set; }
	[Ordinal(3)] [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }
	public AIbehaviorMountEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorAlphaOverLife : CVariable
{
	[Ordinal(0)] [RED("alpha")] public CHandle<IEvaluatorFloat> Alpha { get; set; }
	public CParticleModificatorAlphaOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsSocketDescription : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	[Ordinal(1)] [RED("caption")] public CString Caption { get; set; }
	[Ordinal(2)] [RED("captionColor")] public CColor CaptionColor { get; set; }
	public toolsSocketDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldConversationGroupData : CVariable
{
	[Ordinal(0)] [RED("conversationGroup")] public rRef<scnInterestingConversationsResource> ConversationGroup { get; set; }
	[Ordinal(1)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
	[Ordinal(2)] [RED("ignoreGlobalLimit")] public CBool IgnoreGlobalLimit { get; set; }
	public worldConversationGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TranslationLimit : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
	[Ordinal(5)] [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
	[Ordinal(6)] [RED("limitOnZAxis")] public animFloatClamp LimitOnZAxis { get; set; }
	public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionMoveOnSplineNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
	[Ordinal(2)] [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
	[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
	[Ordinal(4)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	[Ordinal(5)] [RED("snapToTerrain")] public CHandle<AIArgumentMapping> SnapToTerrain { get; set; }
	[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	[Ordinal(7)] [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
	[Ordinal(8)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
	[Ordinal(9)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
	[Ordinal(10)] [RED("reverse")] public CHandle<AIArgumentMapping> Reverse { get; set; }
	[Ordinal(11)] [RED("isBackAndForth")] public CHandle<AIArgumentMapping> IsBackAndForth { get; set; }
	[Ordinal(12)] [RED("isInfinite")] public CHandle<AIArgumentMapping> IsInfinite { get; set; }
	[Ordinal(13)] [RED("numberOfLoops")] public CHandle<AIArgumentMapping> NumberOfLoops { get; set; }
	[Ordinal(14)] [RED("useOffMeshLinkReservation")] public CHandle<AIArgumentMapping> UseOffMeshLinkReservation { get; set; }
	public AIbehaviorActionMoveOnSplineNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SDocumentAdress : CVariable
{
	[Ordinal(0)] [RED("documentID")] public CInt32 DocumentID { get; set; }
	public SDocumentAdress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class gameEffectObjectProvider_TargetingObjectsInCone : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	[Ordinal(1)] [RED("searchQuery")] public gameTargetSearchQuery SearchQuery { get; set; }
	[Ordinal(2)] [RED("searchAngles")] public EulerAngles SearchAngles { get; set; }
	[Ordinal(3)] [RED("maxTargets")] public CUInt32 MaxTargets { get; set; }
	public gameEffectObjectProvider_TargetingObjectsInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneNode_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(1)] [RED("inputName")] public CName InputName { get; set; }
	[Ordinal(2)] [RED("type")] public questSceneConditionType Type { get; set; }
	public questSceneNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_OnlyNearest : CVariable
{
	[Ordinal(0)] [RED("count")] public CUInt32 Count { get; set; }
	public gameEffectObjectFilter_OnlyNearest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckArgumentObjectSet : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	public CheckArgumentObjectSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetBackOffAnimFeature : CVariable
{
	public SetBackOffAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAddCombatLogMessage_NodeType : CVariable
{
	[Ordinal(0)] [RED("message")] public CString Message { get; set; }
	[Ordinal(1)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
	public questAddCombatLogMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStreetCredTier_ConditionType : CVariable
{
	[Ordinal(0)] [RED("tierID")] public TweakDBID TierID { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questStreetCredTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_UseCover : CVariable
{
	[Ordinal(0)] [RED("cover")] public NodeRef Cover { get; set; }
	[Ordinal(1)] [RED("oneTimeSelection")] public CBool OneTimeSelection { get; set; }
	[Ordinal(2)] [RED("immediately")] public CBool Immediately { get; set; }
	public questCombatNodeParams_UseCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimChangeStateEvent : CVariable
{
	public inkanimChangeStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticGpsLocationEntranceMarkerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	public worldStaticGpsLocationEntranceMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldWaterPatchNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsOperationMode : CVariable
{
	public scnChoiceNodeNsOperationMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTeleportPuppetNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public CHandle<questUniversalRef> EntityReference { get; set; }
	[Ordinal(3)] [RED("params")] public CHandle<questTeleportPuppetParamsV1> Params { get; set; }
	public questTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameRegular1v1FinisherScenario : CVariable
{
	[Ordinal(0)] [RED("attackerWorkspot")] public raRef<workWorkspotResource> AttackerWorkspot { get; set; }
	[Ordinal(1)] [RED("targetWorkspot")] public raRef<workWorkspotResource> TargetWorkspot { get; set; }
	[Ordinal(2)] [RED("syncAnimSlotName")] public CName SyncAnimSlotName { get; set; }
	[Ordinal(3)] [RED("targetBlendTime")] public CFloat TargetBlendTime { get; set; }
	[Ordinal(4)] [RED("attackerBlendTime")] public CFloat AttackerBlendTime { get; set; }
	public gameRegular1v1FinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionRotateToPositionTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(2)] [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
	[Ordinal(3)] [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
	[Ordinal(4)] [RED("speed")] public CHandle<AIArgumentMapping> Speed { get; set; }
	public AIbehaviorActionRotateToPositionTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioSwitchNodeType : CVariable
{
	[Ordinal(0)] [RED("switch")] public audioAudSwitch Switch { get; set; }
	[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questAudioSwitchNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Join : CVariable
{
	[Ordinal(0)] [RED("input")] public animPoseLink Input { get; set; }
	public animAnimNode_Join(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NormalDeathTask : CVariable
{
	[Ordinal(0)] [RED("fastForwardAnimation")] public CHandle<AIArgumentMapping> FastForwardAnimation { get; set; }
	public NormalDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_CompositeSimultaneous : CVariable
{
	[Ordinal(0)] [RED("conditions")] public CArray<CHandle<animIAnimStateTransitionCondition>> Conditions { get; set; }
	public animAnimStateTransitionCondition_CompositeSimultaneous(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorColorConst : CVariable
{
	public CEvaluatorColorConst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StimTargetsEvent : CVariable
{
	[Ordinal(0)] [RED("targets")] public CArray<StimTargetData> Targets { get; set; }
	public StimTargetsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneSolutionHash : CVariable
{
	[Ordinal(0)] [RED("sceneSolutionHash")] public scnSceneSolutionHashHash SceneSolutionHash { get; set; }
	public scnSceneSolutionHash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questReplacer_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questReplacer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSectionNode_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(1)] [RED("sectionName")] public CName SectionName { get; set; }
	[Ordinal(2)] [RED("type")] public questSceneConditionType Type { get; set; }
	public questSectionNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerScreen : CVariable
{
	public CParticleDrawerScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableScannerEvent : CVariable
{
	public DisableScannerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorRecalculateVehicleWorkspotPositionTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	public AIbehaviorRecalculateVehicleWorkspotPositionTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questUIManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIUIManagerNodeType> Type { get; set; }
	public questUIManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ToggleUIInteractivity : CVariable
{
	public ToggleUIInteractivity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPauseTime_NodeType : CVariable
{
	[Ordinal(0)] [RED("source")] public CName Source { get; set; }
	public questPauseTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HighestPrioritySignalCondition : CVariable
{
	[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }
	public HighestPrioritySignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerVisuals_SetBrokenNoseStage : CVariable
{
	public questCharacterManagerVisuals_SetBrokenNoseStage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleEmitter : CVariable
{
	[Ordinal(0)] [RED("editorName")] public CString EditorName { get; set; }
	[Ordinal(1)] [RED("modules")] public CArray<CHandle<IParticleModule>> Modules { get; set; }
	[Ordinal(2)] [RED("material")] public rRef<IMaterial> Material { get; set; }
	[Ordinal(3)] [RED("localMaterialInstance")] public CHandle<IMaterial> LocalMaterialInstance { get; set; }
	[Ordinal(4)] [RED("maxParticles")] public CUInt16 MaxParticles { get; set; }
	[Ordinal(5)] [RED("emitterLoops")] public CInt8 EmitterLoops { get; set; }
	[Ordinal(6)] [RED("particleDrawer")] public CHandle<IParticleDrawer> ParticleDrawer { get; set; }
	[Ordinal(7)] [RED("lods")] public CArray<SParticleEmitterLODLevel> Lods { get; set; }
	[Ordinal(8)] [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
	public CParticleEmitter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceRagdoll : CVariable
{
	public ForceRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectEffectParameterEvaluatorVector : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<IEvaluatorVector> Evaluator { get; set; }
	public effectEffectParameterEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLootPurge_NodeType : CVariable
{
	public questLootPurge_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSystemBody : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("params")] public physicsSystemBodyParams Params { get; set; }
	[Ordinal(2)] [RED("collisionShapes")] public CArray<CHandle<physicsICollider>> CollisionShapes { get; set; }
	public physicsSystemBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReactiveEventSender : CVariable
{
	[Ordinal(0)] [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
	[Ordinal(1)] [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
	[Ordinal(2)] [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
	[Ordinal(3)] [RED("reactiveType")] public CName ReactiveType { get; set; }
	public ReactiveEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamDestructionChunkIndicesOffsets : CVariable
{
	[Ordinal(0)] [RED("offsets")] public CArray<meshChunkIndicesOffset> Offsets { get; set; }
	[Ordinal(1)] [RED("chunkOffsets")] public CArray<CUInt32> ChunkOffsets { get; set; }
	[Ordinal(2)] [RED("indices")] public CArray<DataBuffer> Indices { get; set; }
	public meshMeshParamDestructionChunkIndicesOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameWaypoint : CVariable
{
	public gameWaypoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questWarningMessage_NodeType : CVariable
{
	[Ordinal(0)] [RED("localizedMessage")] public LocalizationString LocalizedMessage { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(2)] [RED("show")] public CBool Show { get; set; }
	public questWarningMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorSizeOverLife : CVariable
{
	[Ordinal(0)] [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }
	public CParticleModificatorSizeOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_WorkspotItem : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(1)] [RED("actions")] public CArray<CHandle<workIWorkspotItemAction>> Actions { get; set; }
	public animAnimEvent_WorkspotItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questvehicleToNodeParams : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(1)] [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
	public questvehicleToNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TransformToTrack : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("floatTrackIndex")] public animNamedTrackIndex FloatTrackIndex { get; set; }
	[Ordinal(2)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(3)] [RED("channel")] public animTransformChannel Channel { get; set; }
	public animAnimNode_TransformToTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldVehicleForbiddenAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldVehicleForbiddenAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_ChildEffectsMovingInCone : CVariable
{
	[Ordinal(0)] [RED("effectsCount")] public CUInt32 EffectsCount { get; set; }
	[Ordinal(1)] [RED("effectTagInThisFile")] public CName EffectTagInThisFile { get; set; }
	[Ordinal(2)] [RED("coneAngle")] public CFloat ConeAngle { get; set; }
	public gameEffectAction_ChildEffectsMovingInCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_Finisher : CVariable
{
	[Ordinal(0)] [RED("finisherScenarios")] public CArray<CHandle<gameIFinisherScenario>> FinisherScenarios { get; set; }
	[Ordinal(1)] [RED("alwaysUseEntryAnims")] public CBool AlwaysUseEntryAnims { get; set; }
	public gameEffectExecutor_Finisher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalFolderEntry : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animTransformInfo : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("parentName")] public CName ParentName { get; set; }
	public animTransformInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SlotAnimationInProgress : CVariable
{
	public SlotAnimationInProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DemolitionContainer : CVariable
{
	[Ordinal(0)] [RED("demolitionCheck")] public CHandle<DemolitionSkillCheck> DemolitionCheck { get; set; }
	public DemolitionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateMachineConditionalEntry : CVariable
{
	[Ordinal(0)] [RED("targetStateIndex")] public CUInt32 TargetStateIndex { get; set; }
	[Ordinal(1)] [RED("condition")] public CHandle<animIAnimStateTransitionCondition> Condition { get; set; }
	[Ordinal(2)] [RED("priority")] public CInt32 Priority { get; set; }
	public animAnimStateMachineConditionalEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStreamingWorld : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(2)] [RED("exteriorSectors")] public CArray<worldStreamingSectorDescriptor> ExteriorSectors { get; set; }
	[Ordinal(3)] [RED("questSectors")] public CArray<worldStreamingSectorDescriptor> QuestSectors { get; set; }
	[Ordinal(4)] [RED("alwaysLoadedSectors")] public CArray<worldStreamingSectorDescriptor> AlwaysLoadedSectors { get; set; }
	[Ordinal(5)] [RED("environmentDefinition")] public rRef<worldEnvironmentDefinition> EnvironmentDefinition { get; set; }
	[Ordinal(6)] [RED("worldBoundingBox")] public Box WorldBoundingBox { get; set; }
	[Ordinal(7)] [RED("persistentStateData")] public rRef<CResource> PersistentStateData { get; set; }
	[Ordinal(8)] [RED("deviceResource")] public rRef<CResource> DeviceResource { get; set; }
	[Ordinal(9)] [RED("deviceInitResource")] public rRef<CResource> DeviceInitResource { get; set; }
	[Ordinal(10)] [RED("mappinResource")] public rRef<CResource> MappinResource { get; set; }
	[Ordinal(11)] [RED("poiMappinResource")] public rRef<CResource> PoiMappinResource { get; set; }
	[Ordinal(12)] [RED("areaResource")] public rRef<CResource> AreaResource { get; set; }
	[Ordinal(13)] [RED("lootResource")] public rRef<CResource> LootResource { get; set; }
	[Ordinal(14)] [RED("locationResource")] public rRef<CResource> LocationResource { get; set; }
	[Ordinal(15)] [RED("locomotionPathResource")] public raRef<CResource> LocomotionPathResource { get; set; }
	[Ordinal(16)] [RED("trafficPersistentResource")] public raRef<CResource> TrafficPersistentResource { get; set; }
	[Ordinal(17)] [RED("trafficLaneConnectivityResource")] public raRef<CResource> TrafficLaneConnectivityResource { get; set; }
	[Ordinal(18)] [RED("trafficLanePolygonsResource")] public raRef<CResource> TrafficLanePolygonsResource { get; set; }
	[Ordinal(19)] [RED("trafficLaneSpotsResource")] public raRef<CResource> TrafficLaneSpotsResource { get; set; }
	[Ordinal(20)] [RED("trafficSpatialRepresentationResource")] public raRef<CResource> TrafficSpatialRepresentationResource { get; set; }
	[Ordinal(21)] [RED("trafficCollisionResource")] public raRef<CResource> TrafficCollisionResource { get; set; }
	[Ordinal(22)] [RED("trafficNullAreaCollisionResource")] public raRef<CResource> TrafficNullAreaCollisionResource { get; set; }
	[Ordinal(23)] [RED("smartObjectCompiledRootResource")] public raRef<CResource> SmartObjectCompiledRootResource { get; set; }
	[Ordinal(24)] [RED("geometryCacheResource")] public rRef<CResource> GeometryCacheResource { get; set; }
	[Ordinal(25)] [RED("streamingQueryDataResource")] public raRef<worldStreamingQueryDataResource> StreamingQueryDataResource { get; set; }
	public worldStreamingWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workSyncAnimClip : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	[Ordinal(3)] [RED("slotName")] public CName SlotName { get; set; }
	public workSyncAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_HitReaction : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public gameEffectExecutor_HitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestSirenEvent : CVariable
{
	public VehicleQuestSirenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehiclePlayerToAIInterpolationType : CVariable
{
	public vehiclePlayerToAIInterpolationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCameraPerspective : CVariable
{
	public questVehicleCameraPerspective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RemoveCommand : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public RemoveCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimInterpolationMode : CVariable
{
	public inkanimInterpolationMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRewindableSectionNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("events")] public CArray<CHandle<scnSceneEvent>> Events { get; set; }
	[Ordinal(3)] [RED("sectionDuration")] public scnSceneTime SectionDuration { get; set; }
	[Ordinal(4)] [RED("actorBehaviors")] public CArray<scnSectionInternalsActorBehavior> ActorBehaviors { get; set; }
	public scnRewindableSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticMarkerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("tags")] public redTagList Tags { get; set; }
	[Ordinal(3)] [RED("data")] public CHandle<worldIMarker> Data { get; set; }
	public worldStaticMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamemappinsPhaseVariant : CVariable
{
	[Ordinal(0)] [RED("phase")] public gamedataMappinPhase Phase { get; set; }
	[Ordinal(1)] [RED("variant")] public gamedataMappinVariant Variant { get; set; }
	public gamemappinsPhaseVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEBlendTracksMode : CVariable
{
	public animEBlendTracksMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerSpawnBox : CVariable
{
	[Ordinal(0)] [RED("extents")] public CHandle<IEvaluatorVector> Extents { get; set; }
	[Ordinal(1)] [RED("worldSpace")] public CBool WorldSpace { get; set; }
	public CParticleInitializerSpawnBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleCombatForPlayer_NodeType : CVariable
{
	[Ordinal(0)] [RED("startCombat")] public CBool StartCombat { get; set; }
	public questToggleCombatForPlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorFloatStartEnd : CVariable
{
	[Ordinal(0)] [RED("start")] public CFloat Start { get; set; }
	[Ordinal(1)] [RED("end")] public CFloat End { get; set; }
	public CEvaluatorFloatStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_EyesTracksLookAt : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("eyeTransform")] public animTransformIndex EyeTransform { get; set; }
	[Ordinal(2)] [RED("leftTrack")] public animNamedTrackIndex LeftTrack { get; set; }
	[Ordinal(3)] [RED("rightTrack")] public animNamedTrackIndex RightTrack { get; set; }
	[Ordinal(4)] [RED("upTrack")] public animNamedTrackIndex UpTrack { get; set; }
	[Ordinal(5)] [RED("downTrack")] public animNamedTrackIndex DownTrack { get; set; }
	public animAnimNode_EyesTracksLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckFactInterruptConditionParams : CVariable
{
	[Ordinal(0)] [RED("factCondition")] public CHandle<scnInterruptFactConditionType> FactCondition { get; set; }
	public scnCheckFactInterruptConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPatrolSplineNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
	public worldPatrolSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ReadIkRequest : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("ikChain")] public CName IkChain { get; set; }
	[Ordinal(5)] [RED("outTransform")] public animTransformIndex OutTransform { get; set; }
	public animAnimNode_ReadIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetAsCrowdObstacle : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questSetAsCrowdObstacle_NodeTypeParams> Params { get; set; }
	public questCharacterManagerParameters_SetAsCrowdObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup_TracksMapping : CVariable
{
	[Ordinal(0)] [RED("numEnvelopes")] public CUInt16 NumEnvelopes { get; set; }
	[Ordinal(1)] [RED("numMainPoses")] public CUInt16 NumMainPoses { get; set; }
	[Ordinal(2)] [RED("numLipsyncOverrides")] public CUInt16 NumLipsyncOverrides { get; set; }
	[Ordinal(3)] [RED("numWrinkles")] public CUInt16 NumWrinkles { get; set; }
	public animFacialSetup_TracksMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGraphDefinition : CVariable
{
	[Ordinal(0)] [RED("nodes")] public CArray<CHandle<graphGraphNodeDefinition>> Nodes { get; set; }
	public questGraphDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionSceneAnimationMotionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("params")] public CHandle<AIArgumentMapping> Params { get; set; }
	public AIbehaviorActionSceneAnimationMotionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalCodexDescription : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("subTitle")] public LocalizationString SubTitle { get; set; }
	[Ordinal(2)] [RED("textContent")] public LocalizationString TextContent { get; set; }
	public gameJournalCodexDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIDeviceFeedbackData : CVariable
{
	public AIDeviceFeedbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameuiEBraindanceLayer : CVariable
{
	public gameuiEBraindanceLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetBountyEvent : CVariable
{
	[Ordinal(0)] [RED("bountyID")] public TweakDBID BountyID { get; set; }
	public SetBountyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetManouverPosition : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("angle")] public CFloat Angle { get; set; }
	public SetManouverPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetSkillcheckEvent : CVariable
{
	[Ordinal(0)] [RED("skillcheckContainer")] public CHandle<BaseSkillCheckContainer> SkillcheckContainer { get; set; }
	public SetSkillcheckEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAdditionalFloatTrackContainer : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<animAdditionalFloatTrackEntry> Entries { get; set; }
	public animAdditionalFloatTrackContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_RestrictMovementToArea : CVariable
{
	[Ordinal(0)] [RED("area")] public NodeRef Area { get; set; }
	public questCombatNodeParams_RestrictMovementToArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class BlacklistReason : CVariable
{
	public BlacklistReason(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLegacy_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
	[Ordinal(2)] [RED("communityEntryName")] public CName CommunityEntryName { get; set; }
	[Ordinal(3)] [RED("communityEntryPhaseName")] public CName CommunityEntryPhaseName { get; set; }
	public questLegacy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticLightNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("type")] public ELightType Type { get; set; }
	[Ordinal(3)] [RED("color")] public CColor Color { get; set; }
	[Ordinal(4)] [RED("unit")] public ELightUnit Unit { get; set; }
	[Ordinal(5)] [RED("intensity")] public CFloat Intensity { get; set; }
	[Ordinal(6)] [RED("temperature")] public CFloat Temperature { get; set; }
	[Ordinal(7)] [RED("lightChannel")] public rendLightChannel LightChannel { get; set; }
	[Ordinal(8)] [RED("useInFog")] public CBool UseInFog { get; set; }
	[Ordinal(9)] [RED("clampAttenuation")] public CBool ClampAttenuation { get; set; }
	[Ordinal(10)] [RED("spotCapsule")] public CBool SpotCapsule { get; set; }
	[Ordinal(11)] [RED("sourceRadius")] public CFloat SourceRadius { get; set; }
	[Ordinal(12)] [RED("capsuleLength")] public CFloat CapsuleLength { get; set; }
	[Ordinal(13)] [RED("innerAngle")] public CFloat InnerAngle { get; set; }
	[Ordinal(14)] [RED("outerAngle")] public CFloat OuterAngle { get; set; }
	[Ordinal(15)] [RED("enableLocalShadows")] public CBool EnableLocalShadows { get; set; }
	[Ordinal(16)] [RED("contactShadows")] public rendContactShadowReciever ContactShadows { get; set; }
	[Ordinal(17)] [RED("shadowFadeDistance")] public CFloat ShadowFadeDistance { get; set; }
	[Ordinal(18)] [RED("shadowSoftnessMode")] public ELightShadowSoftnessMode ShadowSoftnessMode { get; set; }
	[Ordinal(19)] [RED("allowDistantLight")] public CBool AllowDistantLight { get; set; }
	[Ordinal(20)] [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
	public worldStaticLightNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAssignRoleTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AIAssignRoleTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandResetAnimFeature : CVariable
{
	public ReprimandResetAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldBendedMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("deformationData")] public CArray<CMatrix> DeformationData { get; set; }
	[Ordinal(4)] [RED("deformedBox")] public Box DeformedBox { get; set; }
	[Ordinal(5)] [RED("isBendedRoad")] public CBool IsBendedRoad { get; set; }
	[Ordinal(6)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
	public worldBendedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_QuerySphere_GrowOverTime : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_QuerySphere_GrowOverTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameHitShape_Sphere : CVariable
{
	[Ordinal(0)] [RED("localTransform")] public CMatrix LocalTransform { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	public gameHitShape_Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimVariableBool : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public animAnimVariableBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderParticleBlobEmitterInfo : CVariable
{
	[Ordinal(0)] [RED("diffuseWrapFactor")] public CFloat DiffuseWrapFactor { get; set; }
	[Ordinal(1)] [RED("backLightingFactor")] public CFloat BackLightingFactor { get; set; }
	[Ordinal(2)] [RED("maxParticles")] public CUInt32 MaxParticles { get; set; }
	[Ordinal(3)] [RED("emitterLoops")] public CInt8 EmitterLoops { get; set; }
	[Ordinal(4)] [RED("renderObjectType")] public ERenderObjectType RenderObjectType { get; set; }
	[Ordinal(5)] [RED("numModifiers")] public CUInt32 NumModifiers { get; set; }
	[Ordinal(6)] [RED("modifierSetMask")] public CUInt64 ModifierSetMask { get; set; }
	[Ordinal(7)] [RED("numInitializers")] public CUInt32 NumInitializers { get; set; }
	[Ordinal(8)] [RED("initializerSetMask")] public CUInt64 InitializerSetMask { get; set; }
	[Ordinal(9)] [RED("seeds")] public CArray<CUInt32> Seeds { get; set; }
	[Ordinal(10)] [RED("lods")] public CArray<rendEmitterLOD> Lods { get; set; }
	[Ordinal(11)] [RED("volumetricParticleColor")] public HDRColor VolumetricParticleColor { get; set; }
	[Ordinal(12)] [RED("volumetricParticleSize")] public CFloat VolumetricParticleSize { get; set; }
	[Ordinal(13)] [RED("volumetricParticleDensity")] public CFloat VolumetricParticleDensity { get; set; }
	[Ordinal(14)] [RED("volumetricParticleFalloff")] public CFloat VolumetricParticleFalloff { get; set; }
	[Ordinal(15)] [RED("volumetricParticleNoiseScale")] public CFloat VolumetricParticleNoiseScale { get; set; }
	public rendRenderParticleBlobEmitterInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CustomValueTimeout : CVariable
{
	[Ordinal(0)] [RED("timeoutValue")] public CFloat TimeoutValue { get; set; }
	public CustomValueTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimVariableContainer : CVariable
{
	public animAnimVariableContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveStunnedTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveStunnedTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakAIActionSelector : CVariable
{
	[Ordinal(0)] [RED("selector")] public TweakDBID Selector { get; set; }
	public TweakAIActionSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolControllerTask : CVariable
{
	public PatrolControllerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableAllVehicleInteractionsNotEnabledPrereq : CVariable
{
	public DisableAllVehicleInteractionsNotEnabledPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SharedMetaPose : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_SharedMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestMapPinLink : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	public gameJournalQuestMapPinLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsTriggerShape : CVariable
{
	[Ordinal(0)] [RED("shapeType")] public physicsShapeType ShapeType { get; set; }
	public physicsTriggerShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDebugSymbols : CVariable
{
	[Ordinal(0)] [RED("performersDebugSymbols")] public CArray<scnPerformerSymbol> PerformersDebugSymbols { get; set; }
	[Ordinal(1)] [RED("sceneEventsDebugSymbols")] public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols { get; set; }
	[Ordinal(2)] [RED("sceneNodesDebugSymbols")] public CArray<scnNodeSymbol> SceneNodesDebugSymbols { get; set; }
	public scnDebugSymbols(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleQuestUIEnable : CVariable
{
	public vehicleQuestUIEnable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questISceneManagerNodeType> Type { get; set; }
	public questSceneManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPaymentFixedAmount_ConditionType : CVariable
{
	[Ordinal(0)] [RED("scriptCondition")] public CHandle<IScriptable> ScriptCondition { get; set; }
	public questPaymentFixedAmount_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldWaterNullAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	public worldWaterNullAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInterestingConversationsAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	[Ordinal(4)] [RED("conversationGroups")] public CArray<rRef<scnInterestingConversationsResource>> ConversationGroups { get; set; }
	[Ordinal(5)] [RED("workspots")] public CArray<NodeRef> Workspots { get; set; }
	public worldInterestingConversationsAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ForegroundSegmentBegin : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("segmentEndNodeId")] public CUInt32 SegmentEndNodeId { get; set; }
	public animAnimNode_ForegroundSegmentBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public PatrolCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NPCNotMountedToVehiclePrereq : CVariable
{
	public NPCNotMountedToVehiclePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterWorkspot_ConditionType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("spotRef")] public NodeRef SpotRef { get; set; }
	public questCharacterWorkspot_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LightColorSettings : CVariable
{
	[Ordinal(0)] [RED("light")] public worldWorldGlobalLightParameters Light { get; set; }
	public LightColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransformAnimatorNode_Action_Play : CVariable
{
	[Ordinal(0)] [RED("timesPlayed")] public CInt32 TimesPlayed { get; set; }
	[Ordinal(1)] [RED("timeScale")] public CFloat TimeScale { get; set; }
	[Ordinal(2)] [RED("reverse")] public CBool Reverse { get; set; }
	public questTransformAnimatorNode_Action_Play(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questObjectCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIObjectConditionType> Type { get; set; }
	public questObjectCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsTimeLineTrackBaseItem : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt64 Id { get; set; }
	[Ordinal(1)] [RED("type")] public CString Type { get; set; }
	[Ordinal(2)] [RED("visualType")] public CString VisualType { get; set; }
	[Ordinal(3)] [RED("children")] public CArray<CUInt64> Children { get; set; }
	public toolsTimeLineTrackBaseItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleWater_ConditionType : CVariable
{
	public questVehicleWater_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetDestructionStateAction : CVariable
{
	public questSetDestructionStateAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorExitWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("skipExitAnimation")] public CHandle<AIArgumentMapping> SkipExitAnimation { get; set; }
	[Ordinal(2)] [RED("useSlowExitAnimation")] public CHandle<AIArgumentMapping> UseSlowExitAnimation { get; set; }
	[Ordinal(3)] [RED("doSlowIfFastExitFails")] public CHandle<AIArgumentMapping> DoSlowIfFastExitFails { get; set; }
	[Ordinal(4)] [RED("stayInWorkspotIfExitFails")] public CHandle<AIArgumentMapping> StayInWorkspotIfExitFails { get; set; }
	[Ordinal(5)] [RED("tryBlendFastExitToWalk")] public CHandle<AIArgumentMapping> TryBlendFastExitToWalk { get; set; }
	[Ordinal(6)] [RED("dontRequestExit")] public CHandle<AIArgumentMapping> DontRequestExit { get; set; }
	[Ordinal(7)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	public AIbehaviorExitWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoInstigatorIfPlayerControlled : CVariable
{
	public gameEffectObjectFilter_NoInstigatorIfPlayerControlled(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalChangeMappinPhase_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("phase")] public gamedataMappinPhase Phase { get; set; }
	public questJournalChangeMappinPhase_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAnimTargetBasicData : CVariable
{
	[Ordinal(0)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(1)] [RED("targetPerformerId")] public scnPerformerId TargetPerformerId { get; set; }
	public scnAnimTargetBasicData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCompanionPositions : CVariable
{
	public questCompanionPositions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointLinearLimit : CVariable
{
	[Ordinal(0)] [RED("x")] public physicsPhysicsJointMotion X { get; set; }
	[Ordinal(1)] [RED("y")] public physicsPhysicsJointMotion Y { get; set; }
	[Ordinal(2)] [RED("z")] public physicsPhysicsJointMotion Z { get; set; }
	[Ordinal(3)] [RED("value")] public CFloat Value { get; set; }
	public physicsPhysicsJointLinearLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ConditionalSegmentBegin : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("segmentEndNodeId")] public CUInt32 SegmentEndNodeId { get; set; }
	public animAnimNode_ConditionalSegmentBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_VisualEffectAtInstigator : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	public gameEffectExecutor_VisualEffectAtInstigator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamDestructionBoneChunkMapping : CVariable
{
	[Ordinal(0)] [RED("boneChunkMasks")] public CArray<CUInt64> BoneChunkMasks { get; set; }
	public meshMeshParamDestructionBoneChunkMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TrajectoryFromMetaPose : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("metaPoseTrajectoryLs")] public animTransformIndex MetaPoseTrajectoryLs { get; set; }
	public animAnimNode_TrajectoryFromMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterFoliageParameters : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("foliageProfile")] public rRef<CFoliageProfile> FoliageProfile { get; set; }
	public CMaterialParameterFoliageParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldOffMeshUserData : CVariable
{
	public worldOffMeshUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PreviousFearPhaseCheck : CVariable
{
	[Ordinal(0)] [RED("fearPhase")] public CInt32 FearPhase { get; set; }
	public PreviousFearPhaseCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkStyleResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("styles")] public CArray<inkStyle> Styles { get; set; }
	public inkStyleResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldLocationAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldLocationAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRemoveToken_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("removeAll")] public CBool RemoveAll { get; set; }
	public questRemoveToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameMappinResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public gameMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ECustomMaterialParam : CVariable
{
	public ECustomMaterialParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Uint8 : CVariable
{
	public Uint8(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMovePuppetNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(3)] [RED("nodeParams")] public CHandle<questAICommandParams> NodeParams { get; set; }
	public questMovePuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_SetDeviceON : CVariable
{
	public EffectExecutor_SetDeviceON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindancePerspective_ConditionType : CVariable
{
	[Ordinal(0)] [RED("perspective")] public scnBraindancePerspective Perspective { get; set; }
	[Ordinal(1)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindancePerspective_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class appearanceAppearanceDefinition : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("partsMasks")] public CArray<CArray<CName>> PartsMasks { get; set; }
	[Ordinal(2)] [RED("partsValues")] public CArray<appearanceAppearancePart> PartsValues { get; set; }
	[Ordinal(3)] [RED("partsOverrides")] public CArray<appearanceAppearancePartOverrides> PartsOverrides { get; set; }
	[Ordinal(4)] [RED("visualTags")] public redTagList VisualTags { get; set; }
	[Ordinal(5)] [RED("compiledData")] public serializationDeferredDataBuffer CompiledData { get; set; }
	[Ordinal(6)] [RED("resolvedDependencies")] public CArray<raRef<CResource>> ResolvedDependencies { get; set; }
	public appearanceAppearanceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	public worldMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_BlockingGeometry : CVariable
{
	public gameEffectObjectFilter_BlockingGeometry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("options")] public CArray<scnChoiceNodeOption> Options { get; set; }
	[Ordinal(3)] [RED("mode")] public scnChoiceNodeNsOperationMode Mode { get; set; }
	[Ordinal(4)] [RED("reminderParams")] public CHandle<scnChoiceNodeNsActorReminderParams> ReminderParams { get; set; }
	[Ordinal(5)] [RED("shapeParams")] public CHandle<scnInteractionShapeParams> ShapeParams { get; set; }
	[Ordinal(6)] [RED("lookAtParams")] public CHandle<scnChoiceNodeNsLookAtParams> LookAtParams { get; set; }
	[Ordinal(7)] [RED("ataParams")] public scnChoiceNodeNsAttachToActorParams AtaParams { get; set; }
	[Ordinal(8)] [RED("mappinParams")] public CHandle<scnChoiceNodeNsMappinParams> MappinParams { get; set; }
	public scnChoiceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InUnconsciousHighLevelState : CVariable
{
	public InUnconsciousHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageCompiledResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(2)] [RED("populationCount")] public CUInt32 PopulationCount { get; set; }
	[Ordinal(3)] [RED("bucketCount")] public CUInt32 BucketCount { get; set; }
	[Ordinal(4)] [RED("dataBuffer")] public DataBuffer DataBuffer { get; set; }
	public worldFoliageCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsTimedAction : CVariable
{
	public scnChoiceNodeNsTimedAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSendMessage_NodeType : CVariable
{
	[Ordinal(0)] [RED("msg")] public CHandle<gameJournalPath> Msg { get; set; }
	public questSendMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimationBufferSimd : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
	[Ordinal(2)] [RED("numJoints")] public CUInt16 NumJoints { get; set; }
	[Ordinal(3)] [RED("numTracks")] public CUInt16 NumTracks { get; set; }
	[Ordinal(4)] [RED("numTranslationsToCopy")] public CUInt16 NumTranslationsToCopy { get; set; }
	[Ordinal(5)] [RED("numTranslationsToEvalAlignedToSimd")] public CUInt16 NumTranslationsToEvalAlignedToSimd { get; set; }
	[Ordinal(6)] [RED("quantizationBits")] public CUInt16 QuantizationBits { get; set; }
	[Ordinal(7)] [RED("isScaleConstant")] public CBool IsScaleConstant { get; set; }
	[Ordinal(8)] [RED("defferedBuffer")] public serializationDeferredDataBuffer DefferedBuffer { get; set; }
	[Ordinal(9)] [RED("fallbackFrameDesc")] public animAnimFallbackFrameDesc FallbackFrameDesc { get; set; }
	[Ordinal(10)] [RED("fallbackFrameBuffer")] public DataBuffer FallbackFrameBuffer { get; set; }
	public animAnimationBufferSimd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCompletionStatus : CVariable
{
	public AIbehaviorCompletionStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCOrientedBoxDefinition : CVariable
{
	[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
	[Ordinal(1)] [RED("forward")] public Vector4 Forward { get; set; }
	[Ordinal(2)] [RED("up")] public Vector4 Up { get; set; }
	public gameinteractionsCOrientedBoxDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questProximityProgressBar_ConditionType : CVariable
{
	public questProximityProgressBar_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animVectorLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_VectorValue> Node { get; set; }
	public animVectorLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateInterpolationType : CVariable
{
	public animAnimStateInterpolationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFinalBoardsEnableSkipCredits_NodeType : CVariable
{
	[Ordinal(0)] [RED("enableSkipping")] public CBool EnableSkipping { get; set; }
	public questFinalBoardsEnableSkipCredits_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameuiCharacterCustomization_BrokenNoseStage : CVariable
{
	public gameuiCharacterCustomization_BrokenNoseStage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorAvoidThreatTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
	[Ordinal(1)] [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }
	public AIbehaviorAvoidThreatTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRadioSongNodeType : CVariable
{
	[Ordinal(0)] [RED("radioStationEvents")] public CArray<audioRadioStationSongEventStruct> RadioStationEvents { get; set; }
	public questRadioSongNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_DampVector : CVariable
{
	[Ordinal(0)] [RED("defaultIncreaseSpeed")] public Vector4 DefaultIncreaseSpeed { get; set; }
	[Ordinal(1)] [RED("defaultDecreaseSpeed")] public Vector4 DefaultDecreaseSpeed { get; set; }
	public animAnimNode_DampVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerFacingBeam : CVariable
{
	public CParticleDrawerFacingBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InStealthHighLevelState : CVariable
{
	public InStealthHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questShowOverlay_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("overlayLibrary")] public raRef<inkWidgetLibraryResource> OverlayLibrary { get; set; }
	public questShowOverlay_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IdentityPoseTerminator : CVariable
{
	public animAnimNode_IdentityPoseTerminator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentReference : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("type")] public AIArgumentType Type { get; set; }
	[Ordinal(2)] [RED("defaultValue")] public Variant DefaultValue { get; set; }
	public AIArgumentReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldBakedDestructionNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(3)] [RED("occluderType")] public visWorldOccluderType OccluderType { get; set; }
	[Ordinal(4)] [RED("meshFractured")] public raRef<CMesh> MeshFractured { get; set; }
	[Ordinal(5)] [RED("numFrames")] public CFloat NumFrames { get; set; }
	[Ordinal(6)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public worldBakedDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMonitorTaskNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("task")] public CHandle<AIbehaviorTaskDefinition> Task { get; set; }
	public AIbehaviorMonitorTaskNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMenuState_ConditionType : CVariable
{
	public questMenuState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAmbientAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldAmbientAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetPendingReactionBB : CVariable
{
	public SetPendingReactionBB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckDistractedReturnCondition : CVariable
{
	public scnCheckDistractedReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestObjective : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("description")] public LocalizationString Description { get; set; }
	public gameJournalQuestObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISocketsForRig : CVariable
{
	public AISocketsForRig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWeaponType : CVariable
{
	public workWeaponType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_AxisRange : CVariable
{
	[Ordinal(0)] [RED("axis")] public gameEffectObjectFilter_AxisRangeAxis Axis { get; set; }
	[Ordinal(1)] [RED("position")] public gameEffectInputParameter_Vector Position { get; set; }
	[Ordinal(2)] [RED("constraints")] public gameEffectInputParameter_Vector Constraints { get; set; }
	public gameEffectObjectFilter_AxisRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetRequiredDistanceCategoryByBone : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("bone")] public animTransformIndex Bone { get; set; }
	public animAnimNode_SetRequiredDistanceCategoryByBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSequenceTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("children")] public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children { get; set; }
	public AIbehaviorSequenceTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEventFilterType : CVariable
{
	public animEventFilterType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RainAreaSettings : CVariable
{
	public RainAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_ItemEffect : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("effectName")] public CName EffectName { get; set; }
	public animAnimEvent_ItemEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GoToMenuEvent : CVariable
{
	[Ordinal(0)] [RED("wakeUp")] public CBool WakeUp { get; set; }
	public GoToMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckSpeakerDistractedInterruptCondition : CVariable
{
	public scnCheckSpeakerDistractedInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnbPerformerAcquisitionPlanType : CVariable
{
	public scnbPerformerAcquisitionPlanType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BaseSwitch : CVariable
{
	public animAnimNode_BaseSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetProgress_NodeType : CVariable
{
	[Ordinal(0)] [RED("achievement")] public TweakDBID Achievement { get; set; }
	[Ordinal(1)] [RED("factName")] public CString FactName { get; set; }
	[Ordinal(2)] [RED("maxValue")] public CUInt32 MaxValue { get; set; }
	public questSetProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class JsonResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("root")] public CHandle<ISerializable> Root { get; set; }
	public JsonResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalEntry_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	public questJournalEntry_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldPhysicalDestructionNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("destructionParams")] public physicsDestructionParams DestructionParams { get; set; }
	[Ordinal(4)] [RED("destructionLevelData")] public CArray<physicsDestructionLevelData> DestructionLevelData { get; set; }
	public worldPhysicalDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(3)] [RED("sceneLocation")] public scnWorldMarker SceneLocation { get; set; }
	public questSceneNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorParallelNodeWaitFor : CVariable
{
	public AIbehaviorParallelNodeWaitFor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsContainedInShapesPredicate : CVariable
{
	public gameinteractionsContainedInShapesPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questCharacterLifePath_ConditionType : CVariable
{
	[Ordinal(0)] [RED("lifePathID")] public TweakDBID LifePathID { get; set; }
	public questCharacterLifePath_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsVFXEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
	[Ordinal(2)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	public scneventsVFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questForceModule_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questForceVMModule_NodeTypeParams> Params { get; set; }
	public questForceModule_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandDeescalateAnimFeature : CVariable
{
	public ReprimandDeescalateAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AimConstraint_ObjectUp : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
	[Ordinal(4)] [RED("upTransform")] public animTransformIndex UpTransform { get; set; }
	[Ordinal(5)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(6)] [RED("forwardAxisLS")] public Vector3 ForwardAxisLS { get; set; }
	public animAnimNode_AimConstraint_ObjectUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetDestructionState_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public questSetDestructionStateAction Action { get; set; }
	[Ordinal(1)] [RED("params")] public CArray<questEntityManagerSetDestructionState_NodeTypeParams> Params { get; set; }
	public questEntityManagerSetDestructionState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleStealthMappinVisibility_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	public questToggleStealthMappinVisibility_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectPostAction_Beam_RicochetPreview : CVariable
{
	[Ordinal(0)] [RED("ricocheted")] public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted { get; set; }
	[Ordinal(1)] [RED("fromMuzzle")] public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle { get; set; }
	public gameEffectPostAction_Beam_RicochetPreview(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneCallPhase : CVariable
{
	public questPhoneCallPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_Timed : CVariable
{
	[Ordinal(0)] [RED("timeToFireTransition")] public CFloat TimeToFireTransition { get; set; }
	public animAnimStateTransitionCondition_Timed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakAIAction : CVariable
{
	[Ordinal(0)] [RED("record")] public TweakDBID Record { get; set; }
	public TweakAIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questInputHint_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public CName Action { get; set; }
	[Ordinal(1)] [RED("localizedLabel")] public CString LocalizedLabel { get; set; }
	public questInputHint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatTrackDirectConnConstraint : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("floatTrackIndex")] public animNamedTrackIndex FloatTrackIndex { get; set; }
	[Ordinal(5)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(6)] [RED("channel")] public animTransformChannel Channel { get; set; }
	public animAnimNode_FloatTrackDirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Plane : CVariable
{
	[Ordinal(0)] [RED("NormalDistance")] public Vector4 NormalDistance { get; set; }
	public Plane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLanguageMode : CVariable
{
	public questLanguageMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TrafficGenDynamicImpact : CVariable
{
	public TrafficGenDynamicImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemDynamicDecal : CVariable
{
	[Ordinal(0)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(1)] [RED("material")] public rRef<IMaterial> Material { get; set; }
	[Ordinal(2)] [RED("width")] public CFloat Width { get; set; }
	[Ordinal(3)] [RED("height")] public CFloat Height { get; set; }
	[Ordinal(4)] [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
	[Ordinal(5)] [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
	[Ordinal(6)] [RED("randomRotation")] public CBool RandomRotation { get; set; }
	public effectTrackItemDynamicDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Inertialization : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_Inertialization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsAccessPointFilter : CVariable
{
	public IsAccessPointFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TonemappingAreaSettings : CVariable
{
	[Ordinal(0)] [RED("mode")] public CHandle<ITonemappingMode> Mode { get; set; }
	[Ordinal(1)] [RED("hdrMode")] public CHandle<ITonemappingMode> HdrMode { get; set; }
	public TonemappingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIJournalConditionType> Type { get; set; }
	public questJournalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshMaterialBuffer : CVariable
{
	[Ordinal(0)] [RED("rawData")] public DataBuffer RawData { get; set; }
	[Ordinal(1)] [RED("rawDataHeaders")] public CArray<meshLocalMaterialHeader> RawDataHeaders { get; set; }
	public meshMeshMaterialBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPlayAnimEvent : CVariable
{
	[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("playbackOptions")] public inkanimPlaybackOptions PlaybackOptions { get; set; }
	public inkanimPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRewindableSectionTimeJump_NodeType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	[Ordinal(1)] [RED("jumpTargetTime")] public CUInt32 JumpTargetTime { get; set; }
	[Ordinal(2)] [RED("jumpSpeed")] public CFloat JumpSpeed { get; set; }
	public questRewindableSectionTimeJump_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questWithCompanionMoveOnSplineParams : CVariable
{
	[Ordinal(0)] [RED("shootingTargetRef")] public CHandle<questUniversalRef> ShootingTargetRef { get; set; }
	[Ordinal(1)] [RED("companionRef")] public CHandle<questUniversalRef> CompanionRef { get; set; }
	[Ordinal(2)] [RED("lookAtTargetRef")] public CHandle<questUniversalRef> LookAtTargetRef { get; set; }
	public questWithCompanionMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimScaleInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(4)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimScaleInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TagValue : CVariable
{
	[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
	public animAnimNode_TagValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAddIdleAnimEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	public scnAddIdleAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectMembership : CVariable
{
	[Ordinal(0)] [RED("members")] public CArray<gameSmartObjectMembershipMemberShip> Members { get; set; }
	public gameSmartObjectMembership(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorWsToMs : CVariable
{
	[Ordinal(0)] [RED("vectorWs")] public animVectorLink VectorWs { get; set; }
	public animAnimNode_VectorWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitJoinTrafficConditionDefinition : CVariable
{
	public AIbehaviorWaitJoinTrafficConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workActorTagCondition : CVariable
{
	[Ordinal(0)] [RED("equals")] public CBool Equals { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	public workActorTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questSetPhoneStatus_NodeType : CVariable
{
	public questSetPhoneStatus_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerSphereAligned : CVariable
{
	[Ordinal(0)] [RED("pivotOffset")] public CFloat PivotOffset { get; set; }
	public CParticleDrawerSphereAligned(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameItemEquipContexts : CVariable
{
	public gameItemEquipContexts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldObjectTag : CVariable
{
	public worldObjectTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointMotion : CVariable
{
	public physicsPhysicsJointMotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CacheFXOnDefeated : CVariable
{
	public CacheFXOnDefeated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class animAnimVariableFloat : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(2)] [RED("max")] public CFloat Max { get; set; }
	public animAnimVariableFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalBriefingMapSection : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	public gameJournalBriefingMapSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceAnimationOffScreen : CVariable
{
	public ForceAnimationOffScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsSocket : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }
	public scneventsSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QsTransform : CVariable
{
	[Ordinal(0)] [RED("Translation")] public Vector4 Translation { get; set; }
	[Ordinal(1)] [RED("Rotation")] public Quaternion Rotation { get; set; }
	[Ordinal(2)] [RED("Scale")] public Vector4 Scale { get; set; }
	public QsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDestruction_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("threshold")] public CFloat Threshold { get; set; }
	public questDestruction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldNavigationNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("navigationTileResource")] public raRef<worldNavigationTileResource> NavigationTileResource { get; set; }
	public worldNavigationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsAggressive : CVariable
{
	public IsAggressive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HDRColor : CVariable
{
	[Ordinal(0)] [RED("Red")] public CFloat Red { get; set; }
	[Ordinal(1)] [RED("Green")] public CFloat Green { get; set; }
	[Ordinal(2)] [RED("Blue")] public CFloat Blue { get; set; }
	[Ordinal(3)] [RED("Alpha")] public CFloat Alpha { get; set; }
	public HDRColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AdjustAnimWrappersForEscalatingPanicPhase : CVariable
{
	public AdjustAnimWrappersForEscalatingPanicPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FPPCamera : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_FPPCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleNodeCommandDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("vehicle")] public gameEntityReference Vehicle { get; set; }
	[Ordinal(3)] [RED("commandParams")] public CHandle<questVehicleCommandParams> CommandParams { get; set; }
	public questVehicleNodeCommandDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnSet_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("reference")] public NodeRef Reference { get; set; }
	[Ordinal(2)] [RED("phaseName")] public CName PhaseName { get; set; }
	public questSpawnSet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamWaterPatchData : CVariable
{
	[Ordinal(0)] [RED("animLength")] public CFloat AnimLength { get; set; }
	[Ordinal(1)] [RED("nodes", 4096, 16)] public CStatic<CStatic<CFloat>> Nodes { get; set; }
	public meshMeshParamWaterPatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AdjustAnimWrappersForEscalatingFearPhase : CVariable
{
	public AdjustAnimWrappersForEscalatingFearPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamOccluderData : CVariable
{
	[Ordinal(0)] [RED("occluderResource")] public CHandle<visIOccluderResource> OccluderResource { get; set; }
	[Ordinal(1)] [RED("defaultOccluderType")] public visWorldOccluderType DefaultOccluderType { get; set; }
	public meshMeshParamOccluderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorRandomConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("chance")] public CFloat Chance { get; set; }
	public AIbehaviorRandomConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInteriorAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("gameRestrictionIDs")] public CArray<TweakDBID> GameRestrictionIDs { get; set; }
	[Ordinal(1)] [RED("setTier2")] public CBool SetTier2 { get; set; }
	public worldInteriorAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalCodexEntry : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("title")] public LocalizationString Title { get; set; }
	[Ordinal(3)] [RED("imageId")] public TweakDBID ImageId { get; set; }
	[Ordinal(4)] [RED("linkImageId")] public TweakDBID LinkImageId { get; set; }
	public gameJournalCodexEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPlayVOEvent : CVariable
{
	[Ordinal(0)] [RED("VOLine")] public CString VOLine { get; set; }
	[Ordinal(1)] [RED("speakerName")] public CString SpeakerName { get; set; }
	public inkanimPlayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CTextureArray : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("setup")] public STextureGroupSetup Setup { get; set; }
	[Ordinal(2)] [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }
	public CTextureArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AINoRole : CVariable
{
	public AINoRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlaySkAnimRootMotionData : CVariable
{
	[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
	[Ordinal(1)] [RED("placementMode")] public scnRootMotionAnimPlacementMode PlacementMode { get; set; }
	[Ordinal(2)] [RED("trajectoryLOD")] public CArray<scnAnimationMotionSample> TrajectoryLOD { get; set; }
	public scnPlaySkAnimRootMotionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLogicalOperation : CVariable
{
	public questLogicalOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckStatusEffect : CVariable
{
	[Ordinal(0)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
	public CheckStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMWeaponStates : CVariable
{
	public gamePSMWeaponStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsCameraParamsEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("fovValue")] public CFloat FovValue { get; set; }
	[Ordinal(3)] [RED("dofIntensity")] public CFloat DofIntensity { get; set; }
	[Ordinal(4)] [RED("dofFarBlur")] public CFloat DofFarBlur { get; set; }
	[Ordinal(5)] [RED("dofFarFocus")] public CFloat DofFarFocus { get; set; }
	[Ordinal(6)] [RED("useNearPlane")] public CBool UseNearPlane { get; set; }
	[Ordinal(7)] [RED("isPlayerCamera")] public CBool IsPlayerCamera { get; set; }
	[Ordinal(8)] [RED("cameraOverrideSettings")] public scneventsCameraOverrideSettings CameraOverrideSettings { get; set; }
	[Ordinal(9)] [RED("targetActor")] public scnPerformerId TargetActor { get; set; }
	[Ordinal(10)] [RED("targetSlot")] public CName TargetSlot { get; set; }
	public scneventsCameraParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataMetaQuest : CVariable
{
	public gamedataMetaQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsSpawnEntityEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("params")] public scneventsSpawnEntityEventParams Params { get; set; }
	public scneventsSpawnEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckArgumentFloat : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("customVar")] public CFloat CustomVar { get; set; }
	[Ordinal(2)] [RED("comparator")] public ECompareOp Comparator { get; set; }
	public CheckArgumentFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workMotionAnimClip : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	public workMotionAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsCollisionPresetsOverridesResource : CVariable
{
	[Ordinal(0)] [RED("overrides")] public CArray<physicsCollisionPresetOverride> Overrides { get; set; }
	public physicsCollisionPresetsOverridesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTriggerManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questITriggerManagerNodeType> Type { get; set; }
	public questTriggerManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindancePerspective : CVariable
{
	public scnBraindancePerspective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsSpawnEntityEventParams : CVariable
{
	[Ordinal(0)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(1)] [RED("referencePerformer")] public scnPerformerId ReferencePerformer { get; set; }
	[Ordinal(2)] [RED("referencePerformerSlotId")] public TweakDBID ReferencePerformerSlotId { get; set; }
	[Ordinal(3)] [RED("fallbackCachedBones", 2)] public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones { get; set; }
	[Ordinal(4)] [RED("fallbackAnimset")] public rRef<animAnimSet> FallbackAnimset { get; set; }
	[Ordinal(5)] [RED("fallbackAnimationName")] public CName FallbackAnimationName { get; set; }
	[Ordinal(6)] [RED("fallbackAnimTime")] public CFloat FallbackAnimTime { get; set; }
	public scneventsSpawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalTarotGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalTarotGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGatherTriggerNotifier_Quest : CVariable
{
	public questGatherTriggerNotifier_Quest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitFormationPositionConditionDefinition : CVariable
{
	public AIbehaviorWaitFormationPositionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questObjectScanEventType : CVariable
{
	public questObjectScanEventType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMultilayerMaskBlobPC : CVariable
{
	[Ordinal(0)] [RED("header")] public rendRenderMultilayerMaskBlobHeader Header { get; set; }
	[Ordinal(1)] [RED("atlasData")] public serializationDeferredDataBuffer AtlasData { get; set; }
	[Ordinal(2)] [RED("tilesData")] public serializationDeferredDataBuffer TilesData { get; set; }
	public rendRenderMultilayerMaskBlobPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCompiledNodes : CVariable
{
	[Ordinal(0)] [RED("compiledSmartObjects")] public CArray<gameCompiledSmartObjectNode> CompiledSmartObjects { get; set; }
	public gameCompiledNodes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnWorldMarkerType : CVariable
{
	public scnWorldMarkerType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BlacklistPlayer : CVariable
{
	public BlacklistPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVoicesetManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIVoicesetManager_NodeType> Type { get; set; }
	public questVoicesetManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAudioFastForwardSupport : CVariable
{
	public scnAudioFastForwardSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questESwitchBehaviourType : CVariable
{
	public questESwitchBehaviourType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SquadAlertedSync : CVariable
{
	public SquadAlertedSync(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questCharacterQuickHacked_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questCharacterQuickHacked_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVisionModesManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIVisionModeNodeType> Type { get; set; }
	public questVisionModesManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ToggleForcedHighlightEvent : CVariable
{
	[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
	[Ordinal(1)] [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }
	[Ordinal(2)] [RED("operation")] public EToggleOperationType Operation { get; set; }
	public ToggleForcedHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSyncMethodByFootPhase : CVariable
{
	public animSyncMethodByFootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SSAOAreaSettings : CVariable
{
	[Ordinal(0)] [RED("coneAoDiffuseStrength")] public curveData<CFloat> ConeAoDiffuseStrength { get; set; }
	[Ordinal(1)] [RED("coneAoSpecularTreshold")] public curveData<CFloat> ConeAoSpecularTreshold { get; set; }
	[Ordinal(2)] [RED("lightAoDiffuseStrength")] public curveData<CFloat> LightAoDiffuseStrength { get; set; }
	[Ordinal(3)] [RED("lightAoSpecularStrength")] public curveData<CFloat> LightAoSpecularStrength { get; set; }
	public SSAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animVectorCoordinateType : CVariable
{
	public animVectorCoordinateType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEventBlendWorkspotSetupParameters : CVariable
{
	[Ordinal(0)] [RED("workspotId")] public scnSceneWorkspotInstanceId WorkspotId { get; set; }
	[Ordinal(1)] [RED("sequenceEntryId")] public workWorkEntryId SequenceEntryId { get; set; }
	public scnEventBlendWorkspotSetupParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSmoothFloatClamp : CVariable
{
	[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(1)] [RED("max")] public CFloat Max { get; set; }
	[Ordinal(2)] [RED("marginEaseOutCurve")] public curveData<CFloat> MarginEaseOutCurve { get; set; }
	public animSmoothFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionMoveToSmartObjectNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("smartObjectId")] public CHandle<AIArgumentMapping> SmartObjectId { get; set; }
	[Ordinal(2)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
	[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
	[Ordinal(4)] [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
	[Ordinal(5)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	[Ordinal(7)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
	[Ordinal(8)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
	[Ordinal(9)] [RED("forcedEntryAnimation")] public CHandle<AIArgumentMapping> ForcedEntryAnimation { get; set; }
	public AIbehaviorActionMoveToSmartObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkCreditsResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("sections")] public CArray<inkCreditsSectionEntry> Sections { get; set; }
	public inkCreditsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetLifePath : CVariable
{
	[Ordinal(0)] [RED("lifePathID")] public TweakDBID LifePathID { get; set; }
	public questCharacterManagerParameters_SetLifePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_SetWeaponState : CVariable
{
	[Ordinal(0)] [RED("areaType")] public gameCityAreaType AreaType { get; set; }
	public questCharacterManagerCombat_SetWeaponState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCompiledCommunityAreaNode_Streamable : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("area")] public CHandle<communityArea> Area { get; set; }
	[Ordinal(3)] [RED("sourceObjectId")] public entEntityID SourceObjectId { get; set; }
	[Ordinal(4)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
	public worldCompiledCommunityAreaNode_Streamable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDropItemFromSlot_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questDropItemFromSlot_NodeTypeParams> Params { get; set; }
	public questDropItemFromSlot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MarkingBubble : CVariable
{
	[Ordinal(0)] [RED("delaySecondsPerMeterOfDistance")] public CFloat DelaySecondsPerMeterOfDistance { get; set; }
	[Ordinal(1)] [RED("delayAdditionalRandomDelayMax")] public CFloat DelayAdditionalRandomDelayMax { get; set; }
	public MarkingBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectFilter_NotObstructed : CVariable
{
	[Ordinal(0)] [RED("forwardOffset")] public CFloat ForwardOffset { get; set; }
	[Ordinal(1)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectFilter_NotObstructed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterVector : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("vector")] public Vector4 Vector { get; set; }
	public CMaterialParameterVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communityVoiceTagInitializer : CVariable
{
	[Ordinal(0)] [RED("voiceTagName")] public CName VoiceTagName { get; set; }
	public communityVoiceTagInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GetFollowTarget : CVariable
{
	public GetFollowTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWorkspotResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rootNode")] public CHandle<animAnimNode_Root> RootNode { get; set; }
	[Ordinal(2)] [RED("variables")] public CHandle<animAnimVariableContainer> Variables { get; set; }
	[Ordinal(3)] [RED("animFeatures")] public CArray<animAnimFeatureEntry> AnimFeatures { get; set; }
	[Ordinal(4)] [RED("nodesToInit")] public CArray<CHandle<animAnimNode_Base>> NodesToInit { get; set; }
	[Ordinal(5)] [RED("workspotTree")] public CHandle<workWorkspotTree> WorkspotTree { get; set; }
	public workWorkspotResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : CVariable
{
	[Ordinal(0)] [RED("magnitude")] public CFloat Magnitude { get; set; }
	public gameEffectExecutor_PhysicalImpulseFromInstigator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAmbientAreaSettings : CVariable
{
	[Ordinal(0)] [RED("EventsOnActive")] public CArray<audioAudEventStruct> EventsOnActive { get; set; }
	[Ordinal(1)] [RED("outerDistance")] public CFloat OuterDistance { get; set; }
	[Ordinal(2)] [RED("verticalOuterDistance")] public CFloat VerticalOuterDistance { get; set; }
	public audioAmbientAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOffsetMode : CVariable
{
	public scnOffsetMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentType : CVariable
{
	public AIArgumentType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ReferencePoseTerminator : CVariable
{
	public animAnimNode_ReferencePoseTerminator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficNullAreaCollisionData : CVariable
{
	[Ordinal(0)] [RED("header")] public worldCrowdNullAreaCollisionHeader Header { get; set; }
	public worldTrafficNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoleVectorDetails : CVariable
{
	[Ordinal(0)] [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
	public animPoleVectorDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalContact : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("name")] public LocalizationString Name { get; set; }
	[Ordinal(3)] [RED("avatarID")] public TweakDBID AvatarID { get; set; }
	public gameJournalContact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentFloatValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
	public AIArgumentFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrack : CVariable
{
	public effectTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questValueDistance : CVariable
{
	[Ordinal(0)] [RED("distanceValue")] public CFloat DistanceValue { get; set; }
	public questValueDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetProgressionBuild : CVariable
{
	[Ordinal(0)] [RED("buildID")] public TweakDBID BuildID { get; set; }
	public questCharacterManagerParameters_SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NavGenNavmeshImpact : CVariable
{
	public NavGenNavmeshImpact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RegisterCommunityRunner : CVariable
{
	public RegisterCommunityRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetAttachment_ToNode : CVariable
{
	[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
	[Ordinal(1)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	public questEntityManagerSetAttachment_ToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsNPCDriver : CVariable
{
	public IsNPCDriver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAnimMoveOnSplineParams : CVariable
{
	[Ordinal(0)] [RED("customStartAnimationName")] public CName CustomStartAnimationName { get; set; }
	[Ordinal(1)] [RED("customMainAnimationName")] public CName CustomMainAnimationName { get; set; }
	[Ordinal(2)] [RED("customStopAnimationName")] public CName CustomStopAnimationName { get; set; }
	public questAnimMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerNotGrapplingPrereq : CVariable
{
	public PlayerNotGrapplingPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AddActiveStimuli : CVariable
{
	[Ordinal(0)] [RED("stimType")] public gamedataStimType StimType { get; set; }
	[Ordinal(1)] [RED("lifetime")] public CFloat Lifetime { get; set; }
	public AddActiveStimuli(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questICharacterConditionType> Type { get; set; }
	public questCharacterCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVisionMode_ConditionType : CVariable
{
	[Ordinal(0)] [RED("timeInterval")] public CFloat TimeInterval { get; set; }
	[Ordinal(1)] [RED("visionModeType")] public questVisionModeType VisionModeType { get; set; }
	public questVisionMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageBrushItem : CVariable
{
	[Ordinal(0)] [RED("Mesh")] public rRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("Params")] public worldFoliageBrushParams Params { get; set; }
	public worldFoliageBrushItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterState_ConditionType : CVariable
{
	[Ordinal(0)] [RED("subType")] public CHandle<questICharacterConditionSubType> SubType { get; set; }
	public questCharacterState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLookAtDrivenTurnsNode : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(3)] [RED("canLookAtDrivenTurnsInterruptGesture")] public CBool CanLookAtDrivenTurnsInterruptGesture { get; set; }
	public questLookAtDrivenTurnsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleSwitchSeatsForPlayer_NodeType : CVariable
{
	public questToggleSwitchSeatsForPlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InjectAttackInstigatorAsThreat : CVariable
{
	public InjectAttackInstigatorAsThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Drag : CVariable
{
	[Ordinal(0)] [RED("visPostPoseColor")] public CColor VisPostPoseColor { get; set; }
	[Ordinal(1)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("sourceBone")] public animTransformIndex SourceBone { get; set; }
	[Ordinal(5)] [RED("outTargetBone")] public animTransformIndex OutTargetBone { get; set; }
	[Ordinal(6)] [RED("simulationFps")] public CFloat SimulationFps { get; set; }
	[Ordinal(7)] [RED("sourceSpeedMultiplier")] public CFloat SourceSpeedMultiplier { get; set; }
	[Ordinal(8)] [RED("hasOvershoot")] public CBool HasOvershoot { get; set; }
	public animAnimNode_Drag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnfppBlendOverride : CVariable
{
	public scnfppBlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataPlayerPossesion : CVariable
{
	public gamedataPlayerPossesion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSnapToTerrainIkRequest : CVariable
{
	[Ordinal(0)] [RED("ikChain")] public CName IkChain { get; set; }
	[Ordinal(1)] [RED("footTransformIndex")] public animTransformIndex FootTransformIndex { get; set; }
	[Ordinal(2)] [RED("poleVectorRefTransformIndex")] public animTransformIndex PoleVectorRefTransformIndex { get; set; }
	[Ordinal(3)] [RED("enableFootLockFloatTrack")] public animNamedTrackIndex EnableFootLockFloatTrack { get; set; }
	public animSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPointOfInterestGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalPointOfInterestGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Ik2 : CVariable
{
	[Ordinal(0)] [RED("firstBone")] public animTransformIndex FirstBone { get; set; }
	[Ordinal(1)] [RED("secondBone")] public animTransformIndex SecondBone { get; set; }
	[Ordinal(2)] [RED("endBone")] public animTransformIndex EndBone { get; set; }
	[Ordinal(3)] [RED("hingeAxis")] public animAxis HingeAxis { get; set; }
	[Ordinal(4)] [RED("inputPoseNode")] public animPoseLink InputPoseNode { get; set; }
	[Ordinal(5)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	[Ordinal(6)] [RED("endTargetPositionNode")] public animVectorLink EndTargetPositionNode { get; set; }
	public animAnimNode_Ik2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTutorialScreenMode : CVariable
{
	public questTutorialScreenMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestCodexLink : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	public gameJournalQuestCodexLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMinigameNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("networkRef")] public gameEntityReference NetworkRef { get; set; }
	public questMinigameNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnQuestNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("questNode")] public CHandle<questNodeDefinition> QuestNode { get; set; }
	[Ordinal(3)] [RED("isockMappings")] public CArray<CName> IsockMappings { get; set; }
	[Ordinal(4)] [RED("osockMappings")] public CArray<CName> OsockMappings { get; set; }
	public scnQuestNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animLinearCompressedMotionExtraction : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("rotFrames")] public CArray<Quaternion> RotFrames { get; set; }
	[Ordinal(2)] [RED("posFrames")] public CArray<Vector3> PosFrames { get; set; }
	[Ordinal(3)] [RED("rotTime")] public CArray<CFloat> RotTime { get; set; }
	[Ordinal(4)] [RED("posTime")] public CArray<CFloat> PosTime { get; set; }
	public animLinearCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimShapeBorderTransparencyInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("startValue")] public CFloat StartValue { get; set; }
	public inkanimShapeBorderTransparencyInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPath : CVariable
{
	[Ordinal(0)] [RED("realPath")] public CString RealPath { get; set; }
	[Ordinal(1)] [RED("fileEntryIndex")] public CInt32 FileEntryIndex { get; set; }
	[Ordinal(2)] [RED("className")] public CName ClassName { get; set; }
	public gameJournalPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RenderDecalOrderPriority : CVariable
{
	public RenderDecalOrderPriority(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindanceResetting_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindanceResetting_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerCombatReturnCondition : CVariable
{
	public scnCheckPlayerCombatReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetVendorPriceMultiplierRequest : CVariable
{
	[Ordinal(0)] [RED("vendorID")] public TweakDBID VendorID { get; set; }
	[Ordinal(1)] [RED("multiplier")] public CFloat Multiplier { get; set; }
	public SetVendorPriceMultiplierRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransferItems_NodeTypeParams_TransferAllOperationData : CVariable
{
	[Ordinal(0)] [RED("tagsToIgnore")] public CArray<CName> TagsToIgnore { get; set; }
	public questTransferItems_NodeTypeParams_TransferAllOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerRotation : CVariable
{
	[Ordinal(0)] [RED("rotation")] public CHandle<IEvaluatorFloat> Rotation { get; set; }
	public CParticleInitializerRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestMapPin : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("reference")] public gameEntityReference Reference { get; set; }
	[Ordinal(2)] [RED("mappinData")] public gamemappinsMappinData MappinData { get; set; }
	[Ordinal(3)] [RED("offset")] public Vector3 Offset { get; set; }
	public gameJournalQuestMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDangleConstraint_SimulationPendulum : CVariable
{
	[Ordinal(0)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }
	[Ordinal(1)] [RED("dangleBone")] public animTransformIndex DangleBone { get; set; }
	[Ordinal(2)] [RED("halfOfMaxApertureAngle")] public CFloat HalfOfMaxApertureAngle { get; set; }
	[Ordinal(3)] [RED("mass")] public CFloat Mass { get; set; }
	[Ordinal(4)] [RED("damping")] public CFloat Damping { get; set; }
	[Ordinal(5)] [RED("pullForceFactor")] public CFloat PullForceFactor { get; set; }
	[Ordinal(6)] [RED("pullForceDirectionLS")] public Vector3 PullForceDirectionLS { get; set; }
	[Ordinal(7)] [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
	[Ordinal(8)] [RED("cosOfHalfMaxApertureAngle")] public CFloat CosOfHalfMaxApertureAngle { get; set; }
	[Ordinal(9)] [RED("cosOfHalfOfHalfMaxApertureAngle")] public CFloat CosOfHalfOfHalfMaxApertureAngle { get; set; }
	[Ordinal(10)] [RED("sinOfHalfOfHalfMaxApertureAngle")] public CFloat SinOfHalfOfHalfMaxApertureAngle { get; set; }
	[Ordinal(11)] [RED("invertedMass")] public CFloat InvertedMass { get; set; }
	public animDangleConstraint_SimulationPendulum(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalBriefing : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalBriefing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EquipmentPriority : CVariable
{
	public EquipmentPriority(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TonemappingModeACES : CVariable
{
	[Ordinal(0)] [RED("params")] public STonemappingACESParams Params { get; set; }
	public TonemappingModeACES(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEquipItemNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public CHandle<questObservableUniversalRef> EntityReference { get; set; }
	[Ordinal(3)] [RED("params")] public CHandle<questEquipItemParams> Params { get; set; }
	public questEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MultipleParentConstraint : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("areSourceChannelsResaved")] public CBool AreSourceChannelsResaved { get; set; }
	[Ordinal(2)] [RED("parentsTransforms")] public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms { get; set; }
	[Ordinal(3)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNode_MultipleParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsCoverDevice : CVariable
{
	public IsCoverDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentLanePolygonResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldTrafficPersistentLanePolygonResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldWeatherAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("weatherStateNames")] public CArray<CName> WeatherStateNames { get; set; }
	[Ordinal(1)] [RED("weatherStateValues")] public CArray<CFloat> WeatherStateValues { get; set; }
	public worldWeatherAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameFxResource : CVariable
{
	[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	public gameFxResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StrikeExecutor_ModifyStat : CVariable
{
	public StrikeExecutor_ModifyStat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStopVehicle_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("time")] public CFloat Time { get; set; }
	public questStopVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalFile : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("title")] public LocalizationString Title { get; set; }
	[Ordinal(2)] [RED("content")] public LocalizationString Content { get; set; }
	public gameJournalFile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_GrenadeTargetTracker : CVariable
{
	public EffectExecutor_GrenadeTargetTracker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HighlightEditableData : CVariable
{
	[Ordinal(0)] [RED("highlightType")] public EFocusForcedHighlightType HighlightType { get; set; }
	[Ordinal(1)] [RED("outlineType")] public EFocusOutlineType OutlineType { get; set; }
	[Ordinal(2)] [RED("priority")] public EPriority Priority { get; set; }
	public HighlightEditableData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveFollowSlotTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveFollowSlotTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEquipItemParams : CVariable
{
	[Ordinal(0)] [RED("slotId")] public TweakDBID SlotId { get; set; }
	[Ordinal(1)] [RED("itemId")] public TweakDBID ItemId { get; set; }
	[Ordinal(2)] [RED("equipDurationOverride")] public CFloat EquipDurationOverride { get; set; }
	[Ordinal(3)] [RED("instant")] public CBool Instant { get; set; }
	[Ordinal(4)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(5)] [RED("byItem")] public CBool ByItem { get; set; }
	public questEquipItemParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LookAtPose360 : CVariable
{
	[Ordinal(0)] [RED("speedInDegreesPerSecond")] public CFloat SpeedInDegreesPerSecond { get; set; }
	[Ordinal(1)] [RED("angleOffsetNode")] public animFloatLink AngleOffsetNode { get; set; }
	[Ordinal(2)] [RED("targetAngleOffsetNode")] public animFloatLink TargetAngleOffsetNode { get; set; }
	[Ordinal(3)] [RED("animation")] public CName Animation { get; set; }
	public animAnimNode_LookAtPose360(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterHit_ConditionType : CVariable
{
	[Ordinal(0)] [RED("isAttackerPlayer")] public CBool IsAttackerPlayer { get; set; }
	[Ordinal(1)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	public questCharacterHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetStatusEffect : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
	[Ordinal(2)] [RED("isPlayerStatusEffectSource")] public CBool IsPlayerStatusEffectSource { get; set; }
	[Ordinal(3)] [RED("statusEffectSourceObject")] public gameEntityReference StatusEffectSourceObject { get; set; }
	[Ordinal(4)] [RED("recordSelector")] public CHandle<questRecordSelector> RecordSelector { get; set; }
	public questCharacterManagerParameters_SetStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMountVehicleType : CVariable
{
	public questMountVehicleType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questParamKeepDistance : CVariable
{
	[Ordinal(0)] [RED("companionTargetRef")] public CHandle<questUniversalRef> CompanionTargetRef { get; set; }
	public questParamKeepDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSystemCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questISystemConditionType> Type { get; set; }
	public questSystemCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsUnequipItemFromPerformerByItem : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
	[Ordinal(4)] [RED("itemId")] public TweakDBID ItemId { get; set; }
	public scneventsUnequipItemFromPerformerByItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsPlayAnimEventExData : CVariable
{
	[Ordinal(0)] [RED("basic")] public scneventsPlayAnimEventData Basic { get; set; }
	public scneventsPlayAnimEventExData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questvehicleJoinTrafficParams : CVariable
{
	public questvehicleJoinTrafficParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workBodytypeCondition : CVariable
{
	[Ordinal(0)] [RED("rig")] public raRef<animRig> Rig { get; set; }
	public workBodytypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCreateAlertedInfluenceMapTaskDefinition : CVariable
{
	public AIbehaviorCreateAlertedInfluenceMapTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentVectorValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentVectorValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_WrapperValue : CVariable
{
	[Ordinal(0)] [RED("wrapperNames")] public CArray<CName> WrapperNames { get; set; }
	public animAnimNode_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StaggerReactionTask : CVariable
{
	public StaggerReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_TriggerDestruction : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public gameEffectExecutor_TriggerDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCutControlNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	public scnCutControlNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workReactionSequence : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
	[Ordinal(2)] [RED("idleAnim")] public CName IdleAnim { get; set; }
	[Ordinal(3)] [RED("reactionTypes")] public CArray<TweakDBID> ReactionTypes { get; set; }
	public workReactionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalInternetImage : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("linkAddress")] public CString LinkAddress { get; set; }
	[Ordinal(2)] [RED("textureAtlas")] public raRef<inkTextureAtlas> TextureAtlas { get; set; }
	[Ordinal(3)] [RED("texturePart")] public CName TexturePart { get; set; }
	public gameJournalInternetImage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSimpleMoveOnSplineParams : CVariable
{
	[Ordinal(0)] [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
	public questSimpleMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerRole : CVariable
{
	[Ordinal(0)] [RED("followerRef")] public gameEntityReference FollowerRef { get; set; }
	public AIFollowerRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EDocumentType : CVariable
{
	public EDocumentType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestVisualDestructionEvent : CVariable
{
	[Ordinal(0)] [RED("frontLeft")] public CFloat FrontLeft { get; set; }
	[Ordinal(1)] [RED("frontRight")] public CFloat FrontRight { get; set; }
	[Ordinal(2)] [RED("front")] public CFloat Front { get; set; }
	[Ordinal(3)] [RED("right")] public CFloat Right { get; set; }
	[Ordinal(4)] [RED("left")] public CFloat Left { get; set; }
	[Ordinal(5)] [RED("backLeft")] public CFloat BackLeft { get; set; }
	[Ordinal(6)] [RED("backRight")] public CFloat BackRight { get; set; }
	[Ordinal(7)] [RED("back")] public CFloat Back { get; set; }
	[Ordinal(8)] [RED("roof")] public CFloat Roof { get; set; }
	public VehicleQuestVisualDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EAIAttitude : CVariable
{
	public EAIAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentWoundsConfigSet : CVariable
{
	[Ordinal(0)] [RED("Configs")] public CArray<CHandle<entdismembermentWoundConfigContainer>> Configs { get; set; }
	public entdismembermentWoundsConfigSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CReflectionProbeDataResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("textureData")] public rendRenderTextureResource TextureData { get; set; }
	[Ordinal(2)] [RED("dataHash")] public CUInt64 DataHash { get; set; }
	[Ordinal(3)] [RED("faceDepth", 6)] public CArrayFixedSize<CFloat> FaceDepth { get; set; }
public CReflectionProbeDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnToggleScenario_InterruptionScenarioOperation : CVariable
{
	public scnToggleScenario_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LODEnd : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_LODEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class CParticleDrawerEmitterOrientation : CVariable
{
	public CParticleDrawerEmitterOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestAVThrusterEvent : CVariable
{
	public VehicleQuestAVThrusterEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PuppetIncapacitatedPrereq : CVariable
{
	public PuppetIncapacitatedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAimAtTargetCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetOverridePuppetRef")] public gameEntityReference TargetOverridePuppetRef { get; set; }
	public AIAimAtTargetCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetGlobalTvChannel : CVariable
{
	[Ordinal(0)] [RED("channel")] public TweakDBID Channel { get; set; }
	public SetGlobalTvChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitStunnedConditionDefinition : CVariable
{
	public AIbehaviorWaitStunnedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnWorldMarker : CVariable
{
	[Ordinal(0)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	public scnWorldMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoDuplicates : CVariable
{
	public gameEffectObjectFilter_NoDuplicates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerVisuals_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questICharacterManagerVisuals_NodeSubType> Subtype { get; set; }
	public questCharacterManagerVisuals_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkOneShotAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(2)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
	[Ordinal(3)] [RED("Input")] public animPoseLink Input { get; set; }
	public animAnimNode_SkOneShotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehiclePanzerBootupUIQuestEvent : CVariable
{
	[Ordinal(0)] [RED("mode")] public panzerBootupUI Mode { get; set; }
	public VehiclePanzerBootupUIQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StackTracksShrinker : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(2)] [RED("extenderNodeId")] public CUInt32 ExtenderNodeId { get; set; }
	public animAnimNode_StackTracksShrinker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AddIkRequest : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("ikChain")] public CName IkChain { get; set; }
	[Ordinal(2)] [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
	public animAnimNode_AddIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerRotationRate : CVariable
{
	[Ordinal(0)] [RED("rotationRate")] public CHandle<IEvaluatorFloat> RotationRate { get; set; }
	public CParticleInitializerRotationRate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communityCommunityTemplate : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("communityTemplate")] public CHandle<communityCommunityTemplateData> CommunityTemplate { get; set; }
	public communityCommunityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUnassignAll_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questUnassignAll_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DeathWithoutAnimationCondition : CVariable
{
	public DeathWithoutAnimationCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorClearUsedAlertedSpotsTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("usedTokens")] public CHandle<AIArgumentMapping> UsedTokens { get; set; }
	public AIbehaviorClearUsedAlertedSpotsTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entdismembermentWoundConfigContainer : CVariable
{
	[Ordinal(0)] [RED("AppearanceName")] public CName AppearanceName { get; set; }
	public entdismembermentWoundConfigContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Vector2 : CVariable
{
	[Ordinal(0)] [RED("X")] public CFloat X { get; set; }
	[Ordinal(1)] [RED("Y")] public CFloat Y { get; set; }
	public Vector2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorForce : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(2)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
	[Ordinal(3)] [RED("damp")] public CHandle<IEvaluatorVector> Damp { get; set; }
	public CParticleModificatorForce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_PoseCorrection : CVariable
{
	[Ordinal(0)] [RED("visPostPoseColor")] public CColor VisPostPoseColor { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_PoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_SweepOverTime_Box : CVariable
{
	[Ordinal(0)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_SweepOverTime_Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIParameterizationType : CVariable
{
	public AIParameterizationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BodyInvestigated : CVariable
{
	public BodyInvestigated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animParentStaticSwitchBranch : CVariable
{
	public animParentStaticSwitchBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckTriggerReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("triggerArea")] public NodeRef TriggerArea { get; set; }
	public scnCheckTriggerReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_PoseLsToMs : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_PoseLsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMathExpressionNodeData : CVariable
{
	[Ordinal(0)] [RED("expression")] public CHandle<mathExprExpression> Expression { get; set; }
	[Ordinal(1)] [RED("floatSockets")] public CArray<animAnimMathExpressionFloatSocket> FloatSockets { get; set; }
	public animMathExpressionNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameShootingSpotDefinition : CVariable
{
	public gameShootingSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldClothMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("collisionMask")] public physicsEClothCollisionMaskEnum CollisionMask { get; set; }
	public worldClothMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ColorGradingAreaSettings : CVariable
{
	[Ordinal(0)] [RED("ldrLut")] public ColorGradingLutParams LdrLut { get; set; }
	public ColorGradingAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimSizeInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(3)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimSizeInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAttachmentOffsetMode : CVariable
{
	public questAttachmentOffsetMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckStimRevealsInstigatorPosition : CVariable
{
	[Ordinal(0)] [RED("checkStimType")] public CBool CheckStimType { get; set; }
	[Ordinal(1)] [RED("stimType")] public gamedataStimType StimType { get; set; }
	public CheckStimRevealsInstigatorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemFOV : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("FOV")] public effectEffectParameterEvaluatorFloat FOV { get; set; }
	public effectTrackItemFOV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AddItemForPlayerToPickUp : CVariable
{
	[Ordinal(0)] [RED("lootTable")] public TweakDBID LootTable { get; set; }
	public AddItemForPlayerToPickUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ColorBalance : CVariable
{
	[Ordinal(0)] [RED("Red")] public CFloat Red { get; set; }
	[Ordinal(1)] [RED("Green")] public CFloat Green { get; set; }
	[Ordinal(2)] [RED("Blue")] public CFloat Blue { get; set; }
	[Ordinal(3)] [RED("Luminance")] public CFloat Luminance { get; set; }
	public ColorBalance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questCharacterGender_CondtionType : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	public questCharacterGender_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSwitchNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("conditions")] public CArray<questConditionItem> Conditions { get; set; }
	public questSwitchNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatInterpolation : CVariable
{
	[Ordinal(0)] [RED("x2")] public CFloat X2 { get; set; }
	[Ordinal(1)] [RED("y2")] public CFloat Y2 { get; set; }
	[Ordinal(2)] [RED("interpolationType")] public animEAnimGraphMathInterpolation InterpolationType { get; set; }
	[Ordinal(3)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_FloatInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TriggerFearRunningVO : CVariable
{
	public TriggerFearRunningVO(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectInputParameter_Vector : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<gameIEffectParameter_VectorEvaluator> Evaluator { get; set; }
	public gameEffectInputParameter_Vector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSystemJoint : CVariable
{
	[Ordinal(0)] [RED("localToWorld")] public CMatrix LocalToWorld { get; set; }
	[Ordinal(1)] [RED("pinA")] public CHandle<physicsPhysicalJointPin> PinA { get; set; }
	[Ordinal(2)] [RED("pinB")] public CHandle<physicsPhysicalJointPin> PinB { get; set; }
	[Ordinal(3)] [RED("twistLimit")] public physicsPhysicsJointAngularLimitPair TwistLimit { get; set; }
	[Ordinal(4)] [RED("swingLimit")] public physicsPhysicsJointLimitConePair SwingLimit { get; set; }
	[Ordinal(5)] [RED("isBreakable")] public CBool IsBreakable { get; set; }
	[Ordinal(6)] [RED("breakingForce")] public CFloat BreakingForce { get; set; }
	[Ordinal(7)] [RED("breakingTorque")] public CFloat BreakingTorque { get; set; }
	public physicsSystemJoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorEventHandlerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(2)] [RED("resolver")] public CHandle<AIbehaviorEventResolverDefinition> Resolver { get; set; }
	public AIbehaviorEventHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questQuestPhaseResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("graph")] public CHandle<graphGraphDefinition> Graph { get; set; }
	public questQuestPhaseResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSyncMethodByEvent : CVariable
{
	public animSyncMethodByEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_RejectOnPrereq : CVariable
{
	[Ordinal(0)] [RED("prereq")] public CHandle<gameIPrereq> Prereq { get; set; }
	public gameEffectObjectFilter_RejectOnPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetDebugView_NodeType : CVariable
{
	public questSetDebugView_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsAttachPropToWorld : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("propId")] public scnPropId PropId { get; set; }
	[Ordinal(3)] [RED("offsetMode")] public scnOffsetMode OffsetMode { get; set; }
	[Ordinal(4)] [RED("customOffsetPos")] public Vector3 CustomOffsetPos { get; set; }
	public scneventsAttachPropToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCameraParallaxSpace : CVariable
{
	public questCameraParallaxSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerChangeAppearance_NodeType : CVariable
{
	[Ordinal(0)] [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
	[Ordinal(1)] [RED("appearanceName")] public CName AppearanceName { get; set; }
	public questEntityManagerChangeAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceUIRefreshEvent : CVariable
{
	public ForceUIRefreshEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class worldGuardAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("communityEntries")] public CArray<AIGuardAreaConnectedCommunity> CommunityEntries { get; set; }
	public worldGuardAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questNewPlayerPuppetAttached_ConditionType : CVariable
{
	public questNewPlayerPuppetAttached_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsNotWeakspotFilter : CVariable
{
	public IsNotWeakspotFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questForbiddenTrigger_NodeType : CVariable
{
	[Ordinal(0)] [RED("triggerNodeRef")] public NodeRef TriggerNodeRef { get; set; }
	[Ordinal(1)] [RED("dismount")] public CBool Dismount { get; set; }
	public questForbiddenTrigger_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ParticleDamage : CVariable
{
	[Ordinal(0)] [RED("boundingBoxes")] public CArray<Box> BoundingBoxes { get; set; }
	public ParticleDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameKillTriggerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	public gameKillTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetItemTags_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questSetItemTags_NodeTypeParams> Params { get; set; }
	public questSetItemTags_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Multilayer_LayerOverrideSelection : CVariable
{
	[Ordinal(0)] [RED("colorScale")] public CName ColorScale { get; set; }
	[Ordinal(1)] [RED("normalStrength")] public CName NormalStrength { get; set; }
	[Ordinal(2)] [RED("roughLevelsIn")] public CName RoughLevelsIn { get; set; }
	[Ordinal(3)] [RED("roughLevelsOut")] public CName RoughLevelsOut { get; set; }
	[Ordinal(4)] [RED("metalLevelsIn")] public CName MetalLevelsIn { get; set; }
	[Ordinal(5)] [RED("metalLevelsOut")] public CName MetalLevelsOut { get; set; }
	public Multilayer_LayerOverrideSelection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsVFXActionType : CVariable
{
	public scneventsVFXActionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMiscAICommandNode : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(3)] [RED("params")] public CHandle<questAICommandParams> Params { get; set; }
	public questMiscAICommandNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TempClearForcedCombatTarget : CVariable
{
	public TempClearForcedCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Signal : CVariable
{
	[Ordinal(0)] [RED("startEvent")] public CName StartEvent { get; set; }
	[Ordinal(1)] [RED("endEvent")] public CName EndEvent { get; set; }
	public animAnimNode_Signal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalQuestDescription : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("description")] public LocalizationString Description { get; set; }
	public gameJournalQuestDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemMotionBlurScale : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(2)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(3)] [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }
	public effectTrackItemMotionBlurScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_ManageRagdoll : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("enableRagdoll")] public CBool EnableRagdoll { get; set; }
	public questCharacterManagerCombat_ManageRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkAnimDecorator : CVariable
{
	[Ordinal(0)] [RED("Fallback")] public animPoseLink Fallback { get; set; }
	public animAnimNode_SkAnimDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animUncompressedAllAnglesMotionExtraction : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("frames")] public CArray<Transform> Frames { get; set; }
	public animUncompressedAllAnglesMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CFoliageProfile : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public CFoliageProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questShowPopup_NodeSubType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("pauseGame")] public CBool PauseGame { get; set; }
	[Ordinal(2)] [RED("screenMode")] public questTutorialScreenMode ScreenMode { get; set; }
	[Ordinal(3)] [RED("position")] public gamePopupPosition Position { get; set; }
	[Ordinal(4)] [RED("ignoreDisabledTutorials")] public CBool IgnoreDisabledTutorials { get; set; }
	public questShowPopup_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_SetDeviceOFF : CVariable
{
	public EffectExecutor_SetDeviceOFF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entEntityID : CVariable
{
	[Ordinal(0)] [RED("hash")] public CUInt64 Hash { get; set; }
	public entEntityID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LookAtController : CVariable
{
	[Ordinal(0)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(2)] [RED("orderedBodyParts")] public CArray<animLookAtPartInfo> OrderedBodyParts { get; set; }
	[Ordinal(3)] [RED("stateMachinesSettings")] public CArray<animLookAtStateMachineSettings> StateMachinesSettings { get; set; }
	[Ordinal(4)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }
	public animAnimNode_LookAtController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EngDemoContainer : CVariable
{
	[Ordinal(0)] [RED("engineeringCheck")] public CHandle<EngineeringSkillCheck> EngineeringCheck { get; set; }
	public EngDemoContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatMathOp : CVariable
{
	[Ordinal(0)] [RED("operationType")] public animEAnimGraphMathOp OperationType { get; set; }
	[Ordinal(1)] [RED("firstInputNode")] public animFloatLink FirstInputNode { get; set; }
	[Ordinal(2)] [RED("secondInputNode")] public animFloatLink SecondInputNode { get; set; }
	public animAnimNode_FloatMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldTrafficPersistentResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GlobalIlluminationSettings : CVariable
{
	[Ordinal(0)] [RED("multiBouceScale")] public curveData<CFloat> MultiBouceScale { get; set; }
	[Ordinal(1)] [RED("emissiveScale")] public curveData<CFloat> EmissiveScale { get; set; }
	[Ordinal(2)] [RED("lightScaleCompenensation")] public curveData<CFloat> LightScaleCompenensation { get; set; }
	[Ordinal(3)] [RED("reflectionCompensation")] public curveData<CFloat> ReflectionCompensation { get; set; }
	public GlobalIlluminationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnablePlayerVehicle_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicle")] public CString Vehicle { get; set; }
	public questEnablePlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VignetteAreaSettings : CVariable
{
	[Ordinal(0)] [RED("vignetteRadius")] public CFloat VignetteRadius { get; set; }
	[Ordinal(1)] [RED("vignetteExp")] public CFloat VignetteExp { get; set; }
	public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAudioTagNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("audioTag")] public CName AudioTag { get; set; }
	[Ordinal(3)] [RED("radius")] public CFloat Radius { get; set; }
	public worldAudioTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckFactInterruptCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckFactInterruptConditionParams Params { get; set; }
	public scnCheckFactInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldWorldGlobalLightParameters : CVariable
{
	[Ordinal(0)] [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
	[Ordinal(1)] [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
	[Ordinal(2)] [RED("sunSize")] public curveData<CFloat> SunSize { get; set; }
	[Ordinal(3)] [RED("moonSize")] public curveData<CFloat> MoonSize { get; set; }
	public worldWorldGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneWorkspotInstanceId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnSceneWorkspotInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnToggleInterruption_InterruptionOperation : CVariable
{
	public scnToggleInterruption_InterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVisionModeType : CVariable
{
	public questVisionModeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCHotSpotLayerDefinition : CVariable
{
	[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(2)] [RED("group")] public gameinteractionsEGroupType Group { get; set; }
	[Ordinal(3)] [RED("areaFilterDefinition")] public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition { get; set; }
	[Ordinal(4)] [RED("gameLogicFilterDefinition")] public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition { get; set; }
	public gameinteractionsCHotSpotLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_TransformQsTransform : CVariable
{
	[Ordinal(0)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNodeSourceChannel_TransformQsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGameplayRestrictions_NodeType : CVariable
{
	[Ordinal(0)] [RED("source")] public CName Source { get; set; }
	[Ordinal(1)] [RED("restrictionIDs")] public CArray<TweakDBID> RestrictionIDs { get; set; }
	public questGameplayRestrictions_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFindAlertedWorkspotTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("usedTokens")] public CHandle<AIArgumentMapping> UsedTokens { get; set; }
	[Ordinal(1)] [RED("spots")] public CHandle<AIArgumentMapping> Spots { get; set; }
	[Ordinal(2)] [RED("radius")] public CHandle<AIArgumentMapping> Radius { get; set; }
	[Ordinal(3)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
	public AIbehaviorFindAlertedWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_LookAtApplyVehicleRestrictions : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("group")] public CName Group { get; set; }
	[Ordinal(2)] [RED("name")] public CName Name { get; set; }
	[Ordinal(3)] [RED("referenceBone")] public animTransformIndex ReferenceBone { get; set; }
	public animAnimNode_LookAtApplyVehicleRestrictions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questScan_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questScan_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionDieTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorActionDieTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameLootResourceData : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	public gameLootResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldRaceSplineNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
	[Ordinal(3)] [RED("speedChangeSections")] public CArray<worldSpeedSplineNodeSpeedChangeSection> SpeedChangeSections { get; set; }
	[Ordinal(4)] [RED("offsets")] public CArray<worldRaceSplineNodeOffset> Offsets { get; set; }
	public worldRaceSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterKilled_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("comparisonParams")] public CHandle<questComparisonParam> ComparisonParams { get; set; }
	public questCharacterKilled_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetTrackRange : CVariable
{
	[Ordinal(0)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(2)] [RED("max")] public CFloat Max { get; set; }
	[Ordinal(3)] [RED("oldMin")] public CFloat OldMin { get; set; }
	[Ordinal(4)] [RED("track")] public animNamedTrackIndex Track { get; set; }
	public animAnimNode_SetTrackRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NPCInitTask : CVariable
{
	public NPCInitTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EToggleOperationType : CVariable
{
	public EToggleOperationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorAttachToElevatorCommandTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorAttachToElevatorCommandTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalCodexGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("groupName")] public LocalizationString GroupName { get; set; }
	public gameJournalCodexGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSystemResource : CVariable
{
	[Ordinal(0)] [RED("bodies")] public CArray<CHandle<physicsSystemBody>> Bodies { get; set; }
	public physicsSystemResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ManagePersonalLinkChangeEvent : CVariable
{
	[Ordinal(0)] [RED("shouldEquip")] public CBool ShouldEquip { get; set; }
	public ManagePersonalLinkChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animConstraintWeightMode : CVariable
{
	public animConstraintWeightMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PainReactionTask : CVariable
{
	public PainReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSubtreeDefinition : CVariable
{
	[Ordinal(0)] [RED("tree")] public CHandle<AIbehaviorParameterizedBehavior> Tree { get; set; }
	public AIbehaviorSubtreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_TransformVector : CVariable
{
	[Ordinal(0)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNodeSourceChannel_TransformVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animComponentTagCondition : CVariable
{
	[Ordinal(0)] [RED("animTag")] public CName AnimTag { get; set; }
	public animComponentTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckTriggerInterruptCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckTriggerInterruptConditionParams Params { get; set; }
	public scnCheckTriggerInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BoolToFloatConverter : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animBoolLink InputNode { get; set; }
	public animAnimNode_BoolToFloatConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class minimapEncodedShapes : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("Buffer")] public DataBuffer Buffer { get; set; }
	[Ordinal(2)] [RED("QuantizationScale")] public Vector2 QuantizationScale { get; set; }
	[Ordinal(3)] [RED("QuantizationBias")] public Vector2 QuantizationBias { get; set; }
	[Ordinal(4)] [RED("BoxQuantizationScale")] public Vector3 BoxQuantizationScale { get; set; }
	[Ordinal(5)] [RED("BoxQuantizationBias")] public Vector3 BoxQuantizationBias { get; set; }
	[Ordinal(6)] [RED("NumBorderPoints")] public CUInt32 NumBorderPoints { get; set; }
	[Ordinal(7)] [RED("NumFillPoints")] public CUInt32 NumFillPoints { get; set; }
	[Ordinal(8)] [RED("NumShapes")] public CUInt32 NumShapes { get; set; }
	[Ordinal(9)] [RED("NumSpatialBuckets")] public CUInt32 NumSpatialBuckets { get; set; }
	[Ordinal(10)] [RED("NumUniqueGeometry")] public CUInt32 NumUniqueGeometry { get; set; }
	[Ordinal(11)] [RED("NumOwners")] public CUInt32 NumOwners { get; set; }
	[Ordinal(12)] [RED("Version")] public CUInt32 Version { get; set; }
	public minimapEncodedShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleDoor_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("door")] public vehicleEVehicleDoor Door { get; set; }
	public questVehicleDoor_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSaveLock_ConditionType : CVariable
{
	public questSaveLock_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTriggerState_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questSetTriggerState_NodeTypeParams> Params { get; set; }
	public questSetTriggerState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStreamingSectorInplaceContent : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("inplaceResources")] public CArray<rRef<CResource>> InplaceResources { get; set; }
	public worldStreamingSectorInplaceContent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EGameplayChallengeLevel : CVariable
{
	public EGameplayChallengeLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnedVehicleType : CVariable
{
	public questSpawnedVehicleType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class scnLookAtBasicEventData : CVariable
{
	[Ordinal(0)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
	[Ordinal(1)] [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }
	public scnLookAtBasicEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInteractiveObjectManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIInteractiveObjectManagerNodeType> Type { get; set; }
	public questInteractiveObjectManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterGradient : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("gradient")] public rRef<CGradient> Gradient { get; set; }
	public CMaterialParameterGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckUnregisteredWeapon : CVariable
{
	public CheckUnregisteredWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatLatch : CVariable
{
	[Ordinal(0)] [RED("input")] public animFloatLink Input { get; set; }
	public animAnimNode_FloatLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LocalizationString : CVariable
{
	public LocalizationString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communitySpawnEntry : CVariable
{
	[Ordinal(0)] [RED("entryName")] public CName EntryName { get; set; }
	[Ordinal(1)] [RED("characterRecordId")] public TweakDBID CharacterRecordId { get; set; }
	[Ordinal(2)] [RED("phases")] public CArray<CHandle<communitySpawnPhase>> Phases { get; set; }
	public communitySpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerAlpha : CVariable
{
	[Ordinal(0)] [RED("alpha")] public CHandle<IEvaluatorFloat> Alpha { get; set; }
	public CParticleInitializerAlpha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetPossesion_NodeType : CVariable
{
	[Ordinal(0)] [RED("playerPossesion")] public gamedataPlayerPossesion PlayerPossesion { get; set; }
	public questSetPossesion_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EngineeringSkillCheck : CVariable
{
	[Ordinal(0)] [RED("difficulty")] public EGameplayChallengeLevel Difficulty { get; set; }
	public EngineeringSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectDefinition : CVariable
{
	[Ordinal(0)] [RED("resource")] public rRef<gameSmartObjectResource> Resource { get; set; }
	public gameSmartObjectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStreamingQueryDataResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldStreamingQueryDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DemolitionSkillCheck : CVariable
{
	[Ordinal(0)] [RED("difficulty")] public EGameplayChallengeLevel Difficulty { get; set; }
	public DemolitionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_IntEdgeToFeature : CVariable
{
	[Ordinal(0)] [RED("featureName")] public CName FeatureName { get; set; }
	[Ordinal(1)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
	[Ordinal(2)] [RED("toValue")] public CInt32 ToValue { get; set; }
	public animAnimStateTransitionCondition_IntEdgeToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTransferItem_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questTransferItems_NodeTypeParams> Params { get; set; }
	public questTransferItem_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questScanningState : CVariable
{
	public questScanningState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_SlashEffect : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<EffectExecutor_SlashEffect_Entry> Entries { get; set; }
	public EffectExecutor_SlashEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_Phase : CVariable
{
	[Ordinal(0)] [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_Phase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectVectorEvaluator_HitNormal : CVariable
{
	public gameEffectVectorEvaluator_HitNormal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EDecalRenderMode : CVariable
{
	public EDecalRenderMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectPreAction_PreAttack : CVariable
{
	public EffectPreAction_PreAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_SendActionSignal : CVariable
{
	[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }
	[Ordinal(1)] [RED("signalDuration")] public CFloat SignalDuration { get; set; }
	public EffectExecutor_SendActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFindClosestPointOnPathTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
	[Ordinal(1)] [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
	[Ordinal(2)] [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }
	[Ordinal(3)] [RED("entryTangent")] public CHandle<AIArgumentMapping> EntryTangent { get; set; }
	public AIbehaviorFindClosestPointOnPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitTargetToFollowConditionDefinition : CVariable
{
	public AIbehaviorWaitTargetToFollowConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimVideoInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("endValue")] public CFloat EndValue { get; set; }
	public inkanimVideoInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamPhysics : CVariable
{
	[Ordinal(0)] [RED("physicsData")] public CHandle<physicsSystemResource> PhysicsData { get; set; }
	public meshMeshParamPhysics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIncludedTreeDefinition : CVariable
{
	[Ordinal(0)] [RED("treeReference")] public CHandle<AIArgumentMapping> TreeReference { get; set; }
	public AIbehaviorIncludedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameAreaResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public gameAreaResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SnapToTargetExecutor : CVariable
{
	public SnapToTargetExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entAllowVehicleCollisionRagdollInSceneEvent : CVariable
{
	public entAllowVehicleCollisionRagdollInSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleDrawerMotionBlur : CVariable
{
	[Ordinal(0)] [RED("stretchPerVelocity")] public CFloat StretchPerVelocity { get; set; }
	public CParticleDrawerMotionBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemExposureScale : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }
	public effectTrackItemExposureScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FacialSharedMetaPose : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_FacialSharedMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EnableTimeCallbacks : CVariable
{
	public EnableTimeCallbacks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AITrafficExternalWorkspotDefinition : CVariable
{
	[Ordinal(0)] [RED("globalWorkspotNodeRef")] public NodeRef GlobalWorkspotNodeRef { get; set; }
	public AITrafficExternalWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsPlayerFilter : CVariable
{
	public IsPlayerFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAudioAttractAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	[Ordinal(4)] [RED("interestingConversationsNodeRef")] public NodeRef InterestingConversationsNodeRef { get; set; }
	[Ordinal(5)] [RED("audioAttractSoundSettings")] public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings { get; set; }
	public worldAudioAttractAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorRotationRate3DOverLife : CVariable
{
	[Ordinal(0)] [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }
	public CParticleModificatorRotationRate3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LeaveCoverImmediately : CVariable
{
	[Ordinal(0)] [RED("delay")] public CFloat Delay { get; set; }
	public LeaveCoverImmediately(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIPrepareTakedownData : CVariable
{
	public AIPrepareTakedownData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalCodexCategory : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	[Ordinal(2)] [RED("categoryName")] public LocalizationString CategoryName { get; set; }
	public gameJournalCodexCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsNPCAloneInVehicle : CVariable
{
	public IsNPCAloneInVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendFont : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("fontBuffer")] public DataBuffer FontBuffer { get; set; }
	public rendFont(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCPredicateDefinition : CVariable
{
	[Ordinal(0)] [RED("predicateType")] public CHandle<gameinteractionsIPredicateType> PredicateType { get; set; }
	public gameinteractionsCPredicateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentPuppetRefValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentPuppetRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ECompareOp : CVariable
{
	public ECompareOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animRigTagCondition : CVariable
{
	[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
	public animRigTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ContactShadowsSettings : CVariable
{
	[Ordinal(0)] [RED("contactShadows")] public ContactShadowsConfig ContactShadows { get; set; }
	public ContactShadowsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkipConsoleEnd : CVariable
{
	public animAnimNode_SkipConsoleEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkHudEntriesResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("rootWidget")] public rRef<inkWidgetLibraryResource> RootWidget { get; set; }
	[Ordinal(2)] [RED("entries")] public CArray<inkHudWidgetSpawnEntry> Entries { get; set; }
	public inkHudEntriesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIActionSpot : CVariable
{
	[Ordinal(0)] [RED("resource")] public raRef<workWorkspotResource> Resource { get; set; }
	[Ordinal(1)] [RED("snapToGround")] public CBool SnapToGround { get; set; }
	public AIActionSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioLoadingNodeType : CVariable
{
	[Ordinal(0)] [RED("banksToLoad")] public CArray<audioSoundBankStruct> BanksToLoad { get; set; }
	public questAudioLoadingNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIPatrolRole : CVariable
{
	[Ordinal(0)] [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
	public AIPatrolRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetCombatSpace : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("combatSpaceSize")] public AICombatSpaceSize CombatSpaceSize { get; set; }
	public questCharacterManagerParameters_SetCombatSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialEmotionTransitionType : CVariable
{
	public animFacialEmotionTransitionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterHealth_ConditionType : CVariable
{
	[Ordinal(0)] [RED("percent")] public CFloat Percent { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questCharacterHealth_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GameEffectExecutor_StimOnHit : CVariable
{
	[Ordinal(0)] [RED("stimType")] public gamedataStimType StimType { get; set; }
	public GameEffectExecutor_StimOnHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	public animAnimNode_VectorVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	public worldStaticMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIsThreatOnPathConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("isInverted")] public CBool IsInverted { get; set; }
	[Ordinal(1)] [RED("threatObject")] public CHandle<AIArgumentMapping> ThreatObject { get; set; }
	[Ordinal(2)] [RED("threatRadius")] public CHandle<AIArgumentMapping> ThreatRadius { get; set; }
	public AIbehaviorIsThreatOnPathConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStartRecording_NodeType : CVariable
{
	[Ordinal(0)] [RED("sectionName")] public CString SectionName { get; set; }
	public questStartRecording_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetArgumentInt : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("customVar")] public CInt32 CustomVar { get; set; }
	public SetArgumentInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMultilayerMaskResource : CVariable
{
	[Ordinal(0)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }
	public rendRenderMultilayerMaskResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableBraindanceActions : CVariable
{
	[Ordinal(0)] [RED("actionMask")] public SBraindanceInputMask ActionMask { get; set; }
	public DisableBraindanceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_PostProcess_Footlock : CVariable
{
	public animAnimNode_PostProcess_Footlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCHotSpotAreaFilterDefinition : CVariable
{
	[Ordinal(0)] [RED("functor")] public CHandle<gameinteractionsCFunctorDefinition> Functor { get; set; }
	[Ordinal(1)] [RED("shapes")] public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes { get; set; }
	public gameinteractionsCHotSpotAreaFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MultiBoolToFloatValue : CVariable
{
	[Ordinal(0)] [RED("allMustBeTrue")] public CBool AllMustBeTrue { get; set; }
	[Ordinal(1)] [RED("inputsData")] public CArray<animAnimMultiBoolToFloatEntry> InputsData { get; set; }
	public animAnimNode_MultiBoolToFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RTAOAreaSettings : CVariable
{
	[Ordinal(0)] [RED("RangeNear")] public curveData<CFloat> RangeNear { get; set; }
	[Ordinal(1)] [RED("RangeFar")] public curveData<CFloat> RangeFar { get; set; }
	[Ordinal(2)] [RED("RadiusNear")] public curveData<CFloat> RadiusNear { get; set; }
	[Ordinal(3)] [RED("coneAoDiffuseStrength")] public curveData<CFloat> ConeAoDiffuseStrength { get; set; }
	[Ordinal(4)] [RED("coneAoSpecularTreshold")] public curveData<CFloat> ConeAoSpecularTreshold { get; set; }
	[Ordinal(5)] [RED("lightAoDiffuseStrength")] public curveData<CFloat> LightAoDiffuseStrength { get; set; }
	public RTAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_RuntimeSwitch : CVariable
{
	[Ordinal(0)] [RED("condition")] public CHandle<animIRuntimeCondition> Condition { get; set; }
	[Ordinal(1)] [RED("True")] public animPoseLink True { get; set; }
	public animAnimNode_RuntimeSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionUseWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("eventData")] public CHandle<AIArgumentMapping> EventData { get; set; }
	[Ordinal(2)] [RED("playStartAnimationAfterwards")] public CHandle<AIArgumentMapping> PlayStartAnimationAfterwards { get; set; }
	[Ordinal(3)] [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
	[Ordinal(4)] [RED("playExitAutomatically")] public CHandle<AIArgumentMapping> PlayExitAutomatically { get; set; }
	[Ordinal(5)] [RED("markUninterruptable")] public CHandle<AIArgumentMapping> MarkUninterruptable { get; set; }
	public AIbehaviorActionUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamemappinsPointOfInterestMappinData : CVariable
{
	[Ordinal(0)] [RED("typedVariant")] public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant { get; set; }
	public gamemappinsPointOfInterestMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimTextValueProgressInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("endValue")] public CFloat EndValue { get; set; }
	public inkanimTextValueProgressInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimFallbackFrameDesc : CVariable
{
	[Ordinal(0)] [RED("rsion")] public CUInt16 Rsion { get; set; }
	[Ordinal(1)] [RED("pe")] public CUInt16 Pe { get; set; }
	[Ordinal(2)] [RED("mPositions")] public CUInt16 MPositions { get; set; }
	[Ordinal(3)] [RED("mRotations")] public CUInt16 MRotations { get; set; }
	public animAnimFallbackFrameDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetPersistentForcedHighlightEvent : CVariable
{
	[Ordinal(0)] [RED("highlightData")] public CHandle<HighlightEditableData> HighlightData { get; set; }
	[Ordinal(1)] [RED("operation")] public EToggleOperationType Operation { get; set; }
	public SetPersistentForcedHighlightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorConstant : CVariable
{
	[Ordinal(0)] [RED("value")] public Vector4 Value { get; set; }
	public animAnimNode_VectorConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataStatType : CVariable
{
	public gamedataStatType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveToPointTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("targetPosition")] public CHandle<AIArgumentMapping> TargetPosition { get; set; }
	[Ordinal(2)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
	[Ordinal(3)] [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
	[Ordinal(4)] [RED("speedInTraffic")] public CHandle<AIArgumentMapping> SpeedInTraffic { get; set; }
	[Ordinal(5)] [RED("forceGreenLights")] public CHandle<AIArgumentMapping> ForceGreenLights { get; set; }
	[Ordinal(6)] [RED("portals")] public CHandle<AIArgumentMapping> Portals { get; set; }
	[Ordinal(7)] [RED("trafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart { get; set; }
	[Ordinal(8)] [RED("trafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd { get; set; }
	public AIbehaviorDriveToPointTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectFilter_ReachableByNavigation : CVariable
{
	[Ordinal(0)] [RED("maxPathLength")] public gameEffectInputParameter_Float MaxPathLength { get; set; }
	public gameEffectFilter_ReachableByNavigation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSendAnimationEvent_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public questEntityManagerSendAnimationEvent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimInterpolationType : CVariable
{
	public inkanimInterpolationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameAttitudePrereq : CVariable
{
	[Ordinal(0)] [RED("attitude")] public EAIAttitude Attitude { get; set; }
	public gameAttitudePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_TwistConstraint : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("frontAxis")] public animAxis FrontAxis { get; set; }
	[Ordinal(5)] [RED("transformA")] public animTransformIndex TransformA { get; set; }
	[Ordinal(6)] [RED("transformB")] public animTransformIndex TransformB { get; set; }
	[Ordinal(7)] [RED("outputs")] public CArray<animTwistOutput> Outputs { get; set; }
	public animAnimNode_TwistConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_GraphSlotInput : CVariable
{
	public animAnimNode_GraphSlotInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldGINode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("data")] public raRef<CGIDataResource> Data { get; set; }
	[Ordinal(2)] [RED("location", 3)] public CArrayFixedSize<CInt16> Location { get; set; }
public worldGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_PuppetForceVisionAppearance : CVariable
{
	public EffectExecutor_PuppetForceVisionAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTriggerConditionType : CVariable
{
	public questTriggerConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAudParameter : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }
	public audioAudParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticSoundEmitterNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(3)] [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
	[Ordinal(4)] [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
	[Ordinal(5)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
	[Ordinal(6)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
	[Ordinal(7)] [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
	public worldStaticSoundEmitterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsAdaptiveLookAtParams : CVariable
{
	[Ordinal(0)] [RED("nearbySlotName")] public CName NearbySlotName { get; set; }
	[Ordinal(1)] [RED("distantSlotName")] public CName DistantSlotName { get; set; }
	[Ordinal(2)] [RED("blendLimit")] public CFloat BlendLimit { get; set; }
	public scnChoiceNodeNsAdaptiveLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetAnimset : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("variableName")] public CName VariableName { get; set; }
	public questCharacterManagerParameters_SetAnimset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnbgraphSectionNode : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt64 Id { get; set; }
	[Ordinal(1)] [RED("position")] public Point Position { get; set; }
	[Ordinal(2)] [RED("caption")] public CString Caption { get; set; }
	[Ordinal(3)] [RED("sockets")] public CArray<CHandle<toolsSocketDescription>> Sockets { get; set; }
	[Ordinal(4)] [RED("sceneNodeId")] public scnNodeId SceneNodeId { get; set; }
	[Ordinal(5)] [RED("titleFixedSize")] public Point TitleFixedSize { get; set; }
	public scnbgraphSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAdditionalTransformEntry : CVariable
{
	[Ordinal(0)] [RED("transformInfo")] public animTransformInfo TransformInfo { get; set; }
	[Ordinal(1)] [RED("value")] public QsTransform Value { get; set; }
	public animAdditionalTransformEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_Valued : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_Valued(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnLookAtEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("basicData")] public scnLookAtBasicEventData BasicData { get; set; }
	public scnLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficNullAreaCollisionResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("nullAreasCollisionData")] public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData { get; set; }
	[Ordinal(2)] [RED("nullAreaBlockadeData")] public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData { get; set; }
	public worldTrafficNullAreaCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CCubeTexture : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("setup")] public STextureGroupSetup Setup { get; set; }
	[Ordinal(2)] [RED("renderTextureResource")] public rendRenderTextureResource RenderTextureResource { get; set; }
	public CCubeTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_AimConstraint_ObjectRotationUp : CVariable
{
	[Ordinal(0)] [RED("visAxes")] public CBool VisAxes { get; set; }
	[Ordinal(1)] [RED("visNames")] public CBool VisNames { get; set; }
	[Ordinal(2)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
	[Ordinal(3)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(4)] [RED("targetTransform")] public animTransformIndex TargetTransform { get; set; }
	[Ordinal(5)] [RED("upTransform")] public animTransformIndex UpTransform { get; set; }
	[Ordinal(6)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(7)] [RED("forwardAxisLS")] public Vector3 ForwardAxisLS { get; set; }
	public animAnimNode_AimConstraint_ObjectRotationUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceBraindanceCameraToggle : CVariable
{
	[Ordinal(0)] [RED("editorState")] public CBool EditorState { get; set; }
	public ForceBraindanceCameraToggle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorEventConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public AIbehaviorEventConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MathExpressionPose : CVariable
{
	[Ordinal(0)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(2)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
	[Ordinal(3)] [RED("outputFloatTrack")] public animNamedTrackIndex OutputFloatTrack { get; set; }
	[Ordinal(4)] [RED("expressionString")] public CString ExpressionString { get; set; }
	public animAnimNode_MathExpressionPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveGlobalDeathCondition : CVariable
{
	public PassiveGlobalDeathCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSystemBodyParams : CVariable
{
	[Ordinal(0)] [RED("simulationType")] public physicsSimulationType SimulationType { get; set; }
	public physicsSystemBodyParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ClearCombatTarget : CVariable
{
	public ClearCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questISceneConditionType> Type { get; set; }
	public questSceneCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnbPerformerInScene_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("performer")] public CRUID Performer { get; set; }
	[Ordinal(2)] [RED("performerAcquisitionPlanType")] public scnbPerformerAcquisitionPlanType PerformerAcquisitionPlanType { get; set; }
	[Ordinal(3)] [RED("reference")] public NodeRef Reference { get; set; }
	[Ordinal(4)] [RED("entryName")] public CName EntryName { get; set; }
	[Ordinal(5)] [RED("template")] public rRef<communityCommunityTemplate> Template { get; set; }
	[Ordinal(6)] [RED("phaseName")] public CName PhaseName { get; set; }
	public scnbPerformerInScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MeleeAttackCommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public MeleeAttackCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ActionWeightManagerDelegate : CVariable
{
	[Ordinal(0)] [RED("actionsConditions")] public CArray<CName> ActionsConditions { get; set; }
	public ActionWeightManagerDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerRotation3D : CVariable
{
	[Ordinal(0)] [RED("rotation")] public CHandle<IEvaluatorVector> Rotation { get; set; }
	public CParticleInitializerRotation3D(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questForcedBehaviourNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
	[Ordinal(3)] [RED("behavior")] public CHandle<AIbehaviorParameterizedBehavior> Behavior { get; set; }
	public questForcedBehaviourNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TriggerChannel : CVariable
{
	public TriggerChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questProgressBar_NodeType : CVariable
{
	[Ordinal(0)] [RED("text")] public LocalizationString Text { get; set; }
	public questProgressBar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetMetaQuestProgress_NodeType : CVariable
{
	[Ordinal(0)] [RED("percent")] public CUInt32 Percent { get; set; }
	[Ordinal(1)] [RED("text")] public LocalizationString Text { get; set; }
	public questSetMetaQuestProgress_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalQuestEntry_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("trackQuest")] public CBool TrackQuest { get; set; }
	public questJournalQuestEntry_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAudEventStruct : CVariable
{
	[Ordinal(0)] [RED("event")] public CName Event { get; set; }
	public audioAudEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhonePickUp_ConditionType : CVariable
{
	[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
	[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }
	public questPhonePickUp_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_EffectDuration : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
	[Ordinal(2)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(3)] [RED("effectName")] public CName EffectName { get; set; }
	[Ordinal(4)] [RED("breakAllLoopsOnStop")] public CBool BreakAllLoopsOnStop { get; set; }
	public animAnimEvent_EffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTutorial_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questITutorial_NodeSubType> Subtype { get; set; }
	public questTutorial_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_DampFloat : CVariable
{
	[Ordinal(0)] [RED("defaultIncreaseSpeed")] public CFloat DefaultIncreaseSpeed { get; set; }
	[Ordinal(1)] [RED("defaultDecreaseSpeed")] public CFloat DefaultDecreaseSpeed { get; set; }
	[Ordinal(2)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_DampFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DynamicTextureDataFormat : CVariable
{
	public DynamicTextureDataFormat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSocketType : CVariable
{
	public questSocketType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsQueryFilter : CVariable
{
	[Ordinal(0)] [RED("mask2")] public CUInt64 Mask2 { get; set; }
	public physicsQueryFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldLocationAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("districtID")] public TweakDBID DistrictID { get; set; }
	public worldLocationAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackGroup : CVariable
{
	[Ordinal(0)] [RED("tracks")] public CArray<CHandle<effectTrackBase>> Tracks { get; set; }
	public effectTrackGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questICharacterManagerParameters_NodeSubType> Subtype { get; set; }
	public questCharacterManagerParameters_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnHubNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	public scnHubNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questQuestContentType : CVariable
{
	public questQuestContentType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimStopVideoEvent : CVariable
{
	[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
	public inkanimStopVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_QuaternionVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	public animAnimNode_QuaternionVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIAudioNodeType> Type { get; set; }
	public questAudioNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemColorGradeV2 : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("contrast")] public effectEffectParameterEvaluatorFloat Contrast { get; set; }
	[Ordinal(3)] [RED("contrastPivot")] public effectEffectParameterEvaluatorFloat ContrastPivot { get; set; }
	[Ordinal(4)] [RED("saturation")] public effectEffectParameterEvaluatorFloat Saturation { get; set; }
	[Ordinal(5)] [RED("hue")] public effectEffectParameterEvaluatorFloat Hue { get; set; }
	[Ordinal(6)] [RED("brightness")] public effectEffectParameterEvaluatorFloat Brightness { get; set; }
	[Ordinal(7)] [RED("lowRange")] public effectEffectParameterEvaluatorFloat LowRange { get; set; }
	[Ordinal(8)] [RED("highRange")] public effectEffectParameterEvaluatorFloat HighRange { get; set; }
	[Ordinal(9)] [RED("lift")] public effectEffectParameterEvaluatorVector Lift { get; set; }
	[Ordinal(10)] [RED("gamma")] public effectEffectParameterEvaluatorVector Gamma { get; set; }
	[Ordinal(11)] [RED("gain")] public effectEffectParameterEvaluatorVector Gain { get; set; }
	[Ordinal(12)] [RED("offset")] public effectEffectParameterEvaluatorVector Offset { get; set; }
	[Ordinal(13)] [RED("shadow")] public effectEffectParameterEvaluatorVector Shadow { get; set; }
	[Ordinal(14)] [RED("midtone")] public effectEffectParameterEvaluatorVector Midtone { get; set; }
	[Ordinal(15)] [RED("highlight")] public effectEffectParameterEvaluatorVector Highlight { get; set; }
	public effectTrackItemColorGradeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workWorkspotItemPolicy : CVariable
{
	public workWorkspotItemPolicy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStreamingTestCheckpoint_NodeType : CVariable
{
	public questStreamingTestCheckpoint_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WithoutHitDataDeathTask : CVariable
{
	[Ordinal(0)] [RED("fastForwardAnimation")] public CHandle<AIArgumentMapping> FastForwardAnimation { get; set; }
	public WithoutHitDataDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnVarComparison_FactConditionTypeParams : CVariable
{
	[Ordinal(0)] [RED("factName")] public CName FactName { get; set; }
	[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }
	[Ordinal(2)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public scnVarComparison_FactConditionTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HACK_AREA_Settings : CVariable
{
	public HACK_AREA_Settings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEAnimGraphMathInterpolation : CVariable
{
	public animEAnimGraphMathInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGameManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIGameManagerNodeType> Type { get; set; }
	public questGameManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questvehicleFollowParams : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(1)] [RED("useTraffic")] public CBool UseTraffic { get; set; }
	public questvehicleFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveRoleCondition : CVariable
{
	[Ordinal(0)] [RED("role")] public EAIRole Role { get; set; }
	public PassiveRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entEntitySpawnPriority : CVariable
{
	public entEntitySpawnPriority(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRotateToParams : CVariable
{
	[Ordinal(0)] [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
	public questRotateToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkipPerformanceModeBegin : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_SkipPerformanceModeBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ImageBasedFlareAreaSettings : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	public ImageBasedFlareAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameLootResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("data")] public CHandle<gameLootResourceData> Data { get; set; }
	public gameLootResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionDroneMoveSplineTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
	public AIbehaviorActionDroneMoveSplineTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCrowdManagerNodeType_EnableNullArea : CVariable
{
	[Ordinal(0)] [RED("areaReference")] public NodeRef AreaReference { get; set; }
	[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
	public questCrowdManagerNodeType_EnableNullArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsCameraPlacementEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	public scneventsCameraPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitingNotMountedCommandConditionDefinition : CVariable
{
	public AIbehaviorWaitingNotMountedCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolRoleCommandDelegate : CVariable
{
	public PatrolRoleCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectAction_TerminateChildEffect : CVariable
{
	[Ordinal(0)] [RED("effectTag")] public CName EffectTag { get; set; }
	public gameEffectAction_TerminateChildEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StackTransformsShrinker : CVariable
{
	[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(1)] [RED("extenderNodeId")] public CUInt32 ExtenderNodeId { get; set; }
	public animAnimNode_StackTransformsShrinker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldObjectTagExt : CVariable
{
	public worldObjectTagExt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsDestructionParams : CVariable
{
	[Ordinal(0)] [RED("simulationType")] public physicsSimulationType SimulationType { get; set; }
	[Ordinal(1)] [RED("turnDynamicOnImpulse")] public CBool TurnDynamicOnImpulse { get; set; }
	[Ordinal(2)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
	[Ordinal(3)] [RED("impulsePropagationFactor")] public CFloat ImpulsePropagationFactor { get; set; }
	[Ordinal(4)] [RED("impulseDiminishingFactor")] public CFloat ImpulseDiminishingFactor { get; set; }
	[Ordinal(5)] [RED("debrisTimeout")] public CBool DebrisTimeout { get; set; }
	[Ordinal(6)] [RED("debrisTimeoutMin")] public CFloat DebrisTimeoutMin { get; set; }
	[Ordinal(7)] [RED("debrisTimeoutMax")] public CFloat DebrisTimeoutMax { get; set; }
	[Ordinal(8)] [RED("visualsRemain")] public CBool VisualsRemain { get; set; }
	public physicsDestructionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsAlwaysSamePredicate : CVariable
{
	public gameinteractionsAlwaysSamePredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_ChangeLevel : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("level")] public questInt32ValueWrapper Level { get; set; }
	[Ordinal(2)] [RED("setExactLevel")] public CBool SetExactLevel { get; set; }
	public questCharacterManagerCombat_ChangeLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemBloom : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(2)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(3)] [RED("sceneColorScale")] public effectEffectParameterEvaluatorFloat SceneColorScale { get; set; }
	[Ordinal(4)] [RED("bloomColorScale")] public effectEffectParameterEvaluatorFloat BloomColorScale { get; set; }
	public effectTrackItemBloom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendContactShadowReciever : CVariable
{
	public rendContactShadowReciever(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BlurAreaSettings : CVariable
{
	public BlurAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimTransparencyInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(4)] [RED("startValue")] public CFloat StartValue { get; set; }
	public inkanimTransparencyInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnVarComparison_FactConditionType : CVariable
{
	[Ordinal(0)] [RED("params")] public scnVarComparison_FactConditionTypeParams Params { get; set; }
	public scnVarComparison_FactConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEntityNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
	[Ordinal(3)] [RED("instanceData")] public CHandle<entEntityInstanceData> InstanceData { get; set; }
	public worldEntityNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleTrunk_ConditionType : CVariable
{
	[Ordinal(0)] [RED("playerVehicle")] public CBool PlayerVehicle { get; set; }
	[Ordinal(1)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questVehicleTrunk_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePointOfInterestMappinResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public gamePointOfInterestMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorNaryOperatorExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("operands")] public CArray<CHandle<AIbehaviorExpressionSocket>> Operands { get; set; }
	public AIbehaviorNaryOperatorExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReserveItemToThisDropPoint : CVariable
{
	[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }
	public ReserveItemToThisDropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ResetReprimandEscalation : CVariable
{
	public ResetReprimandEscalation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEBlendFromPoseMode : CVariable
{
	public animEBlendFromPoseMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestCrystalDomeEvent : CVariable
{
	public VehicleQuestCrystalDomeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimSetVisibilityEvent : CVariable
{
	public inkanimSetVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class physicsCollisionPresetsResource : CVariable
{
	[Ordinal(0)] [RED("presets")] public CArray<physicsCollisionPreset> Presets { get; set; }
	public physicsCollisionPresetsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuickMeleeHitExecutor : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public QuickMeleeHitExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEntityTemplateDefaultAppearancePreset : CVariable
{
	[Ordinal(0)] [RED("defaultAppearancePresets")] public CArray<gameDefaultAppearancePreset_Entity> DefaultAppearancePresets { get; set; }
	public gameEntityTemplateDefaultAppearancePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterTextureArray : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("texture")] public rRef<ITexture> Texture { get; set; }
	public CMaterialParameterTextureArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAudioPlaybackDirectionSupportFlag : CVariable
{
	public scnAudioPlaybackDirectionSupportFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectTriggerEffectDesc : CVariable
{
	[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
	[Ordinal(1)] [RED("positionType")] public gameEffectTriggerPositioningType PositionType { get; set; }
	public gameEffectTriggerEffectDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsSocketPlacement : CVariable
{
	public toolsSocketPlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGlobalTvScheduler_NodeType : CVariable
{
	[Ordinal(0)] [RED("channelId")] public TweakDBID ChannelId { get; set; }
	[Ordinal(1)] [RED("overlayResource")] public raRef<inkWidgetLibraryResource> OverlayResource { get; set; }
	[Ordinal(2)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
	[Ordinal(3)] [RED("VOScene")] public raRef<scnSceneResource> VOScene { get; set; }
	[Ordinal(4)] [RED("audioEvent")] public CName AudioEvent { get; set; }
	public questGlobalTvScheduler_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_SendStatusEffect : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public gameEffectExecutor_SendStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameHitShape_Capsule : CVariable
{
	[Ordinal(0)] [RED("localTransform")] public CMatrix LocalTransform { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(2)] [RED("height")] public CFloat Height { get; set; }
	public gameHitShape_Capsule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class questFlowControlNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questFlowControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MathExpressionVector : CVariable
{
	[Ordinal(0)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
	[Ordinal(1)] [RED("expressionString")] public CString ExpressionString { get; set; }
	public animAnimNode_MathExpressionVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AnimationsLoadedTask : CVariable
{
	[Ordinal(0)] [RED("melee")] public CBool Melee { get; set; }
	public AnimationsLoadedTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIJournal_NodeType> Type { get; set; }
	public questJournalNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimDefinition : CVariable
{
	[Ordinal(0)] [RED("interpolators")] public CArray<CHandle<inkanimInterpolator>> Interpolators { get; set; }
	public inkanimDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverrideInterruptionScenario_InterruptionOperation : CVariable
{
	[Ordinal(0)] [RED("scenarioId")] public scnInterruptionScenarioId ScenarioId { get; set; }
	[Ordinal(1)] [RED("scenarioOperations")] public CArray<CHandle<scnIInterruptionScenarioOperation>> ScenarioOperations { get; set; }
	public scnOverrideInterruptionScenario_InterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMTakedown : CVariable
{
	public gamePSMTakedown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsclothClothCapsuleExportData : CVariable
{
	[Ordinal(0)] [RED("capsules")] public CArray<physicsclothExportedCapsule> Capsules { get; set; }
	public physicsclothClothCapsuleExportData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HasPositionFarFromThreat : CVariable
{
	[Ordinal(0)] [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
	[Ordinal(1)] [RED("minDistance")] public CFloat MinDistance { get; set; }
	[Ordinal(2)] [RED("minPathLength")] public CFloat MinPathLength { get; set; }
	[Ordinal(3)] [RED("distanceFromTraffic")] public CFloat DistanceFromTraffic { get; set; }
	public HasPositionFarFromThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameBlackboardPropertyBindingDefinition : CVariable
{
	[Ordinal(0)] [RED("serializableID")] public gameBlackboardSerializableID SerializableID { get; set; }
	[Ordinal(1)] [RED("propertyType")] public CName PropertyType { get; set; }
	public gameBlackboardPropertyBindingDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAudSwitch : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("value")] public CName Value { get; set; }
	public audioAudSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ColorGradingLutParams : CVariable
{
	[Ordinal(0)] [RED("LUT")] public rRef<CBitmapTexture> LUT { get; set; }
	[Ordinal(1)] [RED("inputMapping")] public EColorMappingFunction InputMapping { get; set; }
	[Ordinal(2)] [RED("outputMapping")] public EColorMappingFunction OutputMapping { get; set; }
	public ColorGradingLutParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendSpace : CVariable
{
	[Ordinal(0)] [RED("inputLinks")] public CArray<animFloatLink> InputLinks { get; set; }
	[Ordinal(1)] [RED("blendSpace")] public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace { get; set; }
	public animAnimNode_BlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EmitterGroupAreaSettings : CVariable
{
	public EmitterGroupAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectObjectProvider_AOEAreaEntities : CVariable
{
	public EffectObjectProvider_AOEAreaEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnIKEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(3)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(4)] [RED("ikData")] public scnIKEventData IkData { get; set; }
	public scnIKEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class panzerBootupUI : CVariable
{
	public panzerBootupUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetGender : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questSetGender_NodeTypeParams> Params { get; set; }
	public questCharacterManagerParameters_SetGender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsDriverActive : CVariable
{
	public IsDriverActive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsvisDeviceVisualizerDefinition : CVariable
{
	[Ordinal(0)] [RED("isDynamic")] public CBool IsDynamic { get; set; }
	public gameinteractionsvisDeviceVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldRenderProxyTransformBuffer : CVariable
{
	[Ordinal(0)] [RED("sharedDataBuffer")] public CHandle<worldSharedDataBuffer> SharedDataBuffer { get; set; }
	[Ordinal(1)] [RED("numElements")] public CUInt32 NumElements { get; set; }
	public worldRenderProxyTransformBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCSphereDefinition : CVariable
{
	[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	public gameinteractionsCSphereDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsSimulationFilter : CVariable
{
	[Ordinal(0)] [RED("mask1")] public CUInt64 Mask1 { get; set; }
	[Ordinal(1)] [RED("mask2")] public CUInt64 Mask2 { get; set; }
	public physicsSimulationFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class audioAmbientAreaNotifier : CVariable
{
	[Ordinal(0)] [RED("includeChannels")] public TriggerChannel IncludeChannels { get; set; }
	[Ordinal(1)] [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
	[Ordinal(2)] [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
	[Ordinal(3)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
	public audioAmbientAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLookAtDrivenTurnsMode : CVariable
{
	public questLookAtDrivenTurnsMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPrimaryFolderEntry : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalPrimaryFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetHUDEntryVisibility_NodeType : CVariable
{
	[Ordinal(0)] [RED("hudEntryName")] public CArray<CName> HudEntryName { get; set; }
	public questSetHUDEntryVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSaveEventResolverDefinition : CVariable
{
	[Ordinal(0)] [RED("eventData")] public CHandle<AIArgumentMapping> EventData { get; set; }
	public AIbehaviorSaveEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_AnimFeature : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	[Ordinal(1)] [RED("key")] public CName Key { get; set; }
	[Ordinal(2)] [RED("animFeature")] public CHandle<animAnimFeature> AnimFeature { get; set; }
	[Ordinal(3)] [RED("applyTo")] public gameEffectExecutor_AnimFeatureApplyTo ApplyTo { get; set; }
	public gameEffectExecutor_AnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EWoundedBodyPart : CVariable
{
	public EWoundedBodyPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckCurrentWoundedState : CVariable
{
	[Ordinal(0)] [RED("woundedTypeToCompare")] public EWoundedBodyPart WoundedTypeToCompare { get; set; }
	public CheckCurrentWoundedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayEnv_NodeTypeParams : CVariable
{
	[Ordinal(0)] [RED("envParams")] public rRef<worldEnvironmentAreaParameters> EnvParams { get; set; }
	[Ordinal(1)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	public questPlayEnv_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communitySquadInitializer : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<communitySquadInitializerEntry> Entries { get; set; }
	public communitySquadInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIAggressiveReactionPresetCondition : CVariable
{
	public AIAggressiveReactionPresetCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UnregisterCommunityRunner : CVariable
{
	public UnregisterCommunityRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataUICondition : CVariable
{
	public gamedataUICondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NotJohnnyReplacerPrereq : CVariable
{
	public NotJohnnyReplacerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class mathExprExpression : CVariable
{
	[Ordinal(0)] [RED("tokenData")] public CArray<CUInt32> TokenData { get; set; }
	[Ordinal(1)] [RED("valuesData")] public CArray<CFloat> ValuesData { get; set; }
	[Ordinal(2)] [RED("returnVarType")] public CUInt16 ReturnVarType { get; set; }
	public mathExprExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communitySpawnPhase : CVariable
{
	[Ordinal(0)] [RED("phaseName")] public CName PhaseName { get; set; }
	[Ordinal(1)] [RED("timePeriods")] public CArray<communityPhaseTimePeriod> TimePeriods { get; set; }
	public communitySpawnPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class OnlySingleStatusEffectFromInstigator : CVariable
{
	public OnlySingleStatusEffectFromInstigator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workRandomList : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
	[Ordinal(2)] [RED("minClips")] public CInt8 MinClips { get; set; }
	[Ordinal(3)] [RED("maxClips")] public CInt8 MaxClips { get; set; }
	[Ordinal(4)] [RED("pauseBetweenLength")] public CFloat PauseBetweenLength { get; set; }
	[Ordinal(5)] [RED("pauseLengthDeviation")] public CFloat PauseLengthDeviation { get; set; }
	[Ordinal(6)] [RED("weights")] public CArray<CFloat> Weights { get; set; }
	[Ordinal(7)] [RED("pauseBlendOutTime")] public CFloat PauseBlendOutTime { get; set; }
	[Ordinal(8)] [RED("dontRepeatLastAnims")] public CInt8 DontRepeatLastAnims { get; set; }
	public workRandomList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entEntityParametersBuffer : CVariable
{
	[Ordinal(0)] [RED("parameterBuffers")] public CArray<serializationDeferredDataBuffer> ParameterBuffers { get; set; }
	public entEntityParametersBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSelectWorkspotEntryTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(1)] [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
	[Ordinal(2)] [RED("tangentPoint")] public CHandle<AIArgumentMapping> TangentPoint { get; set; }
	[Ordinal(3)] [RED("entranceFromStand")] public CHandle<AIArgumentMapping> EntranceFromStand { get; set; }
	public AIbehaviorSelectWorkspotEntryTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsReprimandOngoing : CVariable
{
	public IsReprimandOngoing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SimpleSpline : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("startTransform")] public animTransformIndex StartTransform { get; set; }
	[Ordinal(2)] [RED("middleTransform")] public animTransformIndex MiddleTransform { get; set; }
	[Ordinal(3)] [RED("endTransform")] public animTransformIndex EndTransform { get; set; }
	[Ordinal(4)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
	[Ordinal(5)] [RED("defaultProgress")] public CFloat DefaultProgress { get; set; }
	public animAnimNode_SimpleSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterMultilayerSetup : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("setup")] public rRef<Multilayer_Setup> Setup { get; set; }
	public CMaterialParameterMultilayerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterReaction_ConditionType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("isAnyReaction")] public CBool IsAnyReaction { get; set; }
	public questCharacterReaction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_EventValue : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimNode_EventValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAcousticPortalNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("radius")] public CUInt8 Radius { get; set; }
	[Ordinal(3)] [RED("nominalRadius")] public CUInt8 NominalRadius { get; set; }
	public worldAcousticPortalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIMoveCommandsDelegate : CVariable
{
	public AIMoveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entTriggerNotifier_Entity : CVariable
{
	[Ordinal(0)] [RED("entityRef")] public NodeRef EntityRef { get; set; }
	public entTriggerNotifier_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectParameter_BoolEvaluator_Blackboard : CVariable
{
	[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
	public gameEffectParameter_BoolEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverrideTalkOnReturn_InterruptionScenarioOperation : CVariable
{
	[Ordinal(0)] [RED("talkOnReturn")] public CBool TalkOnReturn { get; set; }
	public scnOverrideTalkOnReturn_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_TechPreview : CVariable
{
	public gameEffectObjectFilter_TechPreview(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsPlayerLookAtEventParams : CVariable
{
	[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(2)] [RED("adjustYaw")] public CBool AdjustYaw { get; set; }
	[Ordinal(3)] [RED("endOnTargetReached")] public CBool EndOnTargetReached { get; set; }
	[Ordinal(4)] [RED("endOnTimeExceeded")] public CBool EndOnTimeExceeded { get; set; }
	[Ordinal(5)] [RED("cameraInputMagToBreak")] public CFloat CameraInputMagToBreak { get; set; }
	[Ordinal(6)] [RED("precision")] public CFloat Precision { get; set; }
	[Ordinal(7)] [RED("maxDuration")] public CFloat MaxDuration { get; set; }
	public scneventsPlayerLookAtEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class envUtilsReflectionProbeAmbientContributionMode : CVariable
{
	public envUtilsReflectionProbeAmbientContributionMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DispenseFreeSpecificItem : CVariable
{
	[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }
	public DispenseFreeSpecificItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entragdollActivationRequestData : CVariable
{
	[Ordinal(0)] [RED("type")] public entragdollActivationRequestType Type { get; set; }
	public entragdollActivationRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsAttachPropToNode : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("propId")] public scnPropId PropId { get; set; }
	[Ordinal(3)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	public scneventsAttachPropToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneGraph : CVariable
{
	[Ordinal(0)] [RED("graph")] public CArray<CHandle<scnSceneGraphNode>> Graph { get; set; }
	[Ordinal(1)] [RED("startNodes")] public CArray<scnNodeId> StartNodes { get; set; }
	[Ordinal(2)] [RED("endNodes")] public CArray<scnNodeId> EndNodes { get; set; }
	public scnSceneGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFactsDBManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIFactsDBManagerNodeType> Type { get; set; }
	public questFactsDBManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuickHackTimeDilationOverride : CVariable
{
	[Ordinal(0)] [RED("overrideDilationToTutorialPreset")] public CBool OverrideDilationToTutorialPreset { get; set; }
	public QuickHackTimeDilationOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerTakedownCommandParams : CVariable
{
	[Ordinal(0)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	public AIFollowerTakedownCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMeshBlobHeader : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(1)] [RED("dataProcessing")] public CUInt32 DataProcessing { get; set; }
	[Ordinal(2)] [RED("renderLODs")] public CArray<CFloat> RenderLODs { get; set; }
	[Ordinal(3)] [RED("renderChunkInfos")] public CArray<rendChunk> RenderChunkInfos { get; set; }
	[Ordinal(4)] [RED("topology")] public CArray<rendTopologyData> Topology { get; set; }
	[Ordinal(5)] [RED("quantizationScale")] public Vector4 QuantizationScale { get; set; }
	[Ordinal(6)] [RED("quantizationOffset")] public Vector4 QuantizationOffset { get; set; }
	[Ordinal(7)] [RED("vertexBufferSize")] public CUInt32 VertexBufferSize { get; set; }
	[Ordinal(8)] [RED("indexBufferSize")] public CUInt32 IndexBufferSize { get; set; }
	[Ordinal(9)] [RED("indexBufferOffset")] public CUInt32 IndexBufferOffset { get; set; }
	public rendRenderMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DeviceDirectInteractionCondition : CVariable
{
	public DeviceDirectInteractionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatTrackModifierMarkUnstable : CVariable
{
	[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
	[Ordinal(1)] [RED("poseInputNode")] public animPoseLink PoseInputNode { get; set; }
	[Ordinal(2)] [RED("floatInputNode")] public animFloatLink FloatInputNode { get; set; }
	[Ordinal(3)] [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }
	public animAnimNode_FloatTrackModifierMarkUnstable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFloatTrackOperationType : CVariable
{
	public animFloatTrackOperationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFailerNodeDefinition : CVariable
{
	public AIbehaviorFailerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCameraPlanesPreset : CVariable
{
	public questCameraPlanesPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InDeadHighLevelState : CVariable
{
	public InDeadHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldQuestType : CVariable
{
	public worldQuestType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerCanTakeCPOMissionDataPrereq : CVariable
{
	public PlayerCanTakeCPOMissionDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_NoInstigator : CVariable
{
	public gameEffectObjectFilter_NoInstigator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalBulkUpdate_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("requiredEntryType")] public CName RequiredEntryType { get; set; }
	[Ordinal(2)] [RED("sendNotification")] public CBool SendNotification { get; set; }
	public questJournalBulkUpdate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCallContact_NodeType : CVariable
{
	[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
	[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }
	[Ordinal(2)] [RED("phase")] public questPhoneCallPhase Phase { get; set; }
	public questCallContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorAndConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("conditions")] public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions { get; set; }
	public AIbehaviorAndConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StealthState : CVariable
{
	public StealthState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEUIMenuState : CVariable
{
	public questEUIMenuState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRemoveAllContacts_NodeType : CVariable
{
	[Ordinal(0)] [RED("excludedContacts")] public CArray<CHandle<gameJournalPath>> ExcludedContacts { get; set; }
	public questRemoveAllContacts_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InjectLookatTargetCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public InjectLookatTargetCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ConditionalSegmentEnd : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("segmentBeginNodeId")] public CUInt32 SegmentBeginNodeId { get; set; }
	public animAnimNode_ConditionalSegmentEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorTrackPatrolProgressNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("pathParameters")] public CHandle<AIArgumentMapping> PathParameters { get; set; }
	[Ordinal(2)] [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
	[Ordinal(3)] [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
	public AIbehaviorTrackPatrolProgressNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorkspotConditionOperators : CVariable
{
	public WorkspotConditionOperators(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatJoin : CVariable
{
	[Ordinal(0)] [RED("input")] public animFloatLink Input { get; set; }
	public animAnimNode_FloatJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Transform : CVariable
{
	[Ordinal(0)] [RED("position")] public Vector4 Position { get; set; }
	[Ordinal(1)] [RED("orientation")] public Quaternion Orientation { get; set; }
	public Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerDestroyCarriedObject : CVariable
{
	[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
	[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	public questEntityManagerDestroyCarriedObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnWorkspotData_ExternalWorkspotResource : CVariable
{
	[Ordinal(0)] [RED("dataId")] public scnSceneWorkspotDataId DataId { get; set; }
	[Ordinal(1)] [RED("workspotResource")] public rRef<workWorkspotResource> WorkspotResource { get; set; }
	public scnWorkspotData_ExternalWorkspotResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communityPatrolInitializer : CVariable
{
	[Ordinal(0)] [RED("patrolRole")] public CHandle<AIPatrolRole> PatrolRole { get; set; }
	public communityPatrolInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IntJoin : CVariable
{
	[Ordinal(0)] [RED("input")] public animIntLink Input { get; set; }
	public animAnimNode_IntJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFindNavigablePointTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("destination")] public CHandle<AIArgumentMapping> Destination { get; set; }
	[Ordinal(1)] [RED("outAdjustedDestination")] public CHandle<AIArgumentMapping> OutAdjustedDestination { get; set; }
	[Ordinal(2)] [RED("outWasAdjusted")] public CHandle<AIArgumentMapping> OutWasAdjusted { get; set; }
	public AIbehaviorFindNavigablePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questWaitForAnyKeyLoadingScreen_NodeType : CVariable
{
	public questWaitForAnyKeyLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectPreAction_PreAttack_WithFriendlyFire : CVariable
{
	public EffectPreAction_PreAttack_WithFriendlyFire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointDriveVelocity : CVariable
{
	[Ordinal(0)] [RED("angularVelocity")] public Vector4 AngularVelocity { get; set; }
	public physicsPhysicsJointDriveVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StackClearCombatTarget : CVariable
{
	public StackClearCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("fireAnimLoopEvent")] public CBool FireAnimLoopEvent { get; set; }
	[Ordinal(2)] [RED("animLoopEventName")] public CName AnimLoopEventName { get; set; }
	[Ordinal(3)] [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
	public animAnimNode_SkAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsColliderBox : CVariable
{
	[Ordinal(0)] [RED("material")] public CName Material { get; set; }
	[Ordinal(1)] [RED("halfExtents")] public Vector3 HalfExtents { get; set; }
	public physicsColliderBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnOverrideReturnConditions_InterruptionScenarioOperation : CVariable
{
	[Ordinal(0)] [RED("returnConditions")] public CArray<CHandle<scnIReturnCondition>> ReturnConditions { get; set; }
	public scnOverrideReturnConditions_InterruptionScenarioOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CombatState : CVariable
{
	public CombatState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animETransformAxis : CVariable
{
	public animETransformAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionEquipItemNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("slotId")] public CHandle<AIArgumentMapping> SlotId { get; set; }
	[Ordinal(2)] [RED("itemId")] public CHandle<AIArgumentMapping> ItemId { get; set; }
	[Ordinal(3)] [RED("duration")] public CHandle<AIArgumentMapping> Duration { get; set; }
	[Ordinal(4)] [RED("failIfItemNotFound")] public CHandle<AIArgumentMapping> FailIfItemNotFound { get; set; }
	[Ordinal(5)] [RED("spawnDelay")] public CHandle<AIArgumentMapping> SpawnDelay { get; set; }
	public AIbehaviorActionEquipItemNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRumble_NodeType : CVariable
{
	[Ordinal(0)] [RED("rumbleEvent")] public CName RumbleEvent { get; set; }
	[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	public questRumble_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StateFrozen : CVariable
{
	[Ordinal(0)] [RED("nodes")] public CArray<CHandle<animAnimNode_Base>> Nodes { get; set; }
	public animAnimNode_StateFrozen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LowFPSSelectCoverMode : CVariable
{
	public LowFPSSelectCoverMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ApplyStatusEffectOnOwner : CVariable
{
	[Ordinal(0)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
	public ApplyStatusEffectOnOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDroppedThreatLastKnowPosition : CVariable
{
	public SetDroppedThreatLastKnowPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalBriefingPaperDollSection : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	public gameJournalBriefingPaperDollSection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EPriority : CVariable
{
	public EPriority(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameRegular1v1FinisherScenarioPivotSetting : CVariable
{
	public gameRegular1v1FinisherScenarioPivotSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Output : CVariable
{
	[Ordinal(0)] [RED("node")] public animPoseLink Node { get; set; }
	public animAnimNode_Output(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class UnconsciousManagerTask : CVariable
{
	public UnconsciousManagerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDynamicMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(3)] [RED("occluderType")] public visWorldOccluderType OccluderType { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("initialGuess")] public CBool InitialGuess { get; set; }
	public worldDynamicMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SetRequiredDistanceCategory : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }
	public animAnimNode_SetRequiredDistanceCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questContentTokenManager_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questIContentTokenManager_NodeSubType> Subtype { get; set; }
	public questContentTokenManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_GraphSlotConditions : CVariable
{
	[Ordinal(0)] [RED("dontDeactivateInput")] public CBool DontDeactivateInput { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(2)] [RED("conditions")] public CArray<animGraphSlotCondition> Conditions { get; set; }
	public animAnimNode_GraphSlotConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CTerrainSetup : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("tiling")] public CArray<CFloat> Tiling { get; set; }
	[Ordinal(2)] [RED("physicalMaterial")] public CArray<CName> PhysicalMaterial { get; set; }
	public CTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkPhaseSlotWithDurationAnim : CVariable
{
	[Ordinal(0)] [RED("isLooped")] public CBool IsLooped { get; set; }
	[Ordinal(1)] [RED("phase")] public CName Phase { get; set; }
	[Ordinal(2)] [RED("durationLink")] public animFloatLink DurationLink { get; set; }
	[Ordinal(3)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
	[Ordinal(4)] [RED("actionAnimDatabaseRef")] public rRef<animActionAnimDatabase> ActionAnimDatabaseRef { get; set; }
	public animAnimNode_SkPhaseSlotWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialInstance : CVariable
{
	[Ordinal(0)] [RED("baseMaterial")] public rRef<IMaterial> BaseMaterial { get; set; }
	[Ordinal(1)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
	public CMaterialInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUseWorkspotParamsV1 : CVariable
{
	[Ordinal(0)] [RED("workspotNode")] public NodeRef WorkspotNode { get; set; }
	public questUseWorkspotParamsV1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPointOfInterestMappin : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("staticNodeRef")] public NodeRef StaticNodeRef { get; set; }
	[Ordinal(2)] [RED("mappinData")] public gamemappinsPointOfInterestMappinData MappinData { get; set; }
	[Ordinal(3)] [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
	[Ordinal(4)] [RED("notificationTriggerAreaRef")] public NodeRef NotificationTriggerAreaRef { get; set; }
	public gameJournalPointOfInterestMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FilterNPCsByType : CVariable
{
	[Ordinal(0)] [RED("allowedTypes")] public CArray<gamedataNPCType> AllowedTypes { get; set; }
	[Ordinal(1)] [RED("invert")] public CBool Invert { get; set; }
	public FilterNPCsByType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIEntityManager_NodeType> Type { get; set; }
	public questEntityManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsGeometryCache : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("sectorGeometries")] public CArray<physicsGeometryKey> SectorGeometries { get; set; }
	[Ordinal(2)] [RED("sectorCacheEntries")] public CArray<physicsSectorCacheEntry> SectorCacheEntries { get; set; }
	[Ordinal(3)] [RED("alwaysLoadedSector")] public physicsSectorEntry AlwaysLoadedSector { get; set; }
	[Ordinal(4)] [RED("alwaysLoadedSectorDDB")] public serializationDeferredDataBuffer AlwaysLoadedSectorDDB { get; set; }
	public physicsGeometryCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameExistingWorkspotFinisherScenario : CVariable
{
	[Ordinal(0)] [RED("playerWorkspot")] public raRef<workWorkspotResource> PlayerWorkspot { get; set; }
	[Ordinal(1)] [RED("syncAnimSlotName")] public CName SyncAnimSlotName { get; set; }
	[Ordinal(2)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	public gameExistingWorkspotFinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class BloomAreaSettings : CVariable
{
	[Ordinal(0)] [RED("luminanceThresholdMin")] public CFloat LuminanceThresholdMin { get; set; }
	[Ordinal(1)] [RED("luminanceThresholdMax")] public CFloat LuminanceThresholdMax { get; set; }
	[Ordinal(2)] [RED("sceneColorScale")] public CFloat SceneColorScale { get; set; }
	[Ordinal(3)] [RED("bloomColorScale")] public CFloat BloomColorScale { get; set; }
	public BloomAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRidSerialNumber : CVariable
{
	[Ordinal(0)] [RED("serialNumber")] public CUInt32 SerialNumber { get; set; }
	public scnRidSerialNumber(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBriefingType : CVariable
{
	public questBriefingType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TryStopMovingOnTrafficLane : CVariable
{
	public TryStopMovingOnTrafficLane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsDistanceFromScreenCenterPredicate : CVariable
{
	[Ordinal(0)] [RED("height")] public CFloat Height { get; set; }
	[Ordinal(1)] [RED("width")] public CFloat Width { get; set; }
	[Ordinal(2)] [RED("curvature")] public CFloat Curvature { get; set; }
	public gameinteractionsDistanceFromScreenCenterPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPuppetVehicleState : CVariable
{
	public scnPuppetVehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAnimNameType : CVariable
{
	public scnAnimNameType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentData : CVariable
{
	[Ordinal(0)] [RED("lanes")] public CArray<worldTrafficLanePersistent> Lanes { get; set; }
	public worldTrafficPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Multilayer_LayerTemplate : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("overrides")] public Multilayer_LayerTemplateOverrides Overrides { get; set; }
	[Ordinal(2)] [RED("colorTexture")] public rRef<CBitmapTexture> ColorTexture { get; set; }
	[Ordinal(3)] [RED("normalTexture")] public rRef<CBitmapTexture> NormalTexture { get; set; }
	[Ordinal(4)] [RED("roughnessTexture")] public rRef<CBitmapTexture> RoughnessTexture { get; set; }
	[Ordinal(5)] [RED("metalnessTexture")] public rRef<CBitmapTexture> MetalnessTexture { get; set; }
	[Ordinal(6)] [RED("tilingMultiplier")] public CFloat TilingMultiplier { get; set; }
	[Ordinal(7)] [RED("colorMaskLevelsIn", 2)] public CArrayFixedSize<CFloat> ColorMaskLevelsIn { get; set; }
public Multilayer_LayerTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandToCombatAnimFeature : CVariable
{
	public ReprimandToCombatAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuickHackScreenOpen : CVariable
{
	public QuickHackScreenOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animCompareFunc : CVariable
{
	public animCompareFunc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ExposureAreaSettings : CVariable
{
	[Ordinal(0)] [RED("exposureAdaptationSpeedUp")] public curveData<CFloat> ExposureAdaptationSpeedUp { get; set; }
	[Ordinal(1)] [RED("exposureAdaptationSpeedDown")] public curveData<CFloat> ExposureAdaptationSpeedDown { get; set; }
	[Ordinal(2)] [RED("exposurePercentageThresholdLow")] public curveData<CFloat> ExposurePercentageThresholdLow { get; set; }
	[Ordinal(3)] [RED("exposurePercentageThresholdHigh")] public curveData<CFloat> ExposurePercentageThresholdHigh { get; set; }
	[Ordinal(4)] [RED("exposureCompensation")] public curveData<CFloat> ExposureCompensation { get; set; }
	[Ordinal(5)] [RED("exposureSkyImpact")] public curveData<CFloat> ExposureSkyImpact { get; set; }
	[Ordinal(6)] [RED("exposureMin")] public curveData<CFloat> ExposureMin { get; set; }
	[Ordinal(7)] [RED("exposureMax")] public curveData<CFloat> ExposureMax { get; set; }
	public ExposureAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectPostAction_BulletTrace : CVariable
{
	public gameEffectPostAction_BulletTrace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficNullAreaDynamicBlockadeData : CVariable
{
	public worldTrafficNullAreaDynamicBlockadeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("entry")] public CHandle<gameJournalEntry> Entry { get; set; }
	public gameJournalResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDeviceNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
	[Ordinal(3)] [RED("deviceConnections")] public CArray<worldDeviceConnections> DeviceConnections { get; set; }
	public worldDeviceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workLookAtDrivenTurn : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("turnAngle")] public CInt32 TurnAngle { get; set; }
	[Ordinal(2)] [RED("turnAnimName")] public CName TurnAnimName { get; set; }
	public workLookAtDrivenTurn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitTargetToReachConditionDefinition : CVariable
{
	public AIbehaviorWaitTargetToReachConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEnvironmentDefinition : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("worldRenderSettings")] public WorldRenderAreaSettings WorldRenderSettings { get; set; }
	[Ordinal(2)] [RED("worldShadowConfig")] public WorldShadowConfig WorldShadowConfig { get; set; }
	[Ordinal(3)] [RED("worldLightingConfig")] public WorldLightingConfig WorldLightingConfig { get; set; }
	[Ordinal(4)] [RED("resaved")] public CBool Resaved { get; set; }
	public worldEnvironmentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCLinkedLayersDefinition : CVariable
{
	[Ordinal(0)] [RED("layersDefinitions")] public CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> LayersDefinitions { get; set; }
	public gameinteractionsCLinkedLayersDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LightAreaSettings : CVariable
{
	[Ordinal(0)] [RED("season")] public ETimeOfYearSeason Season { get; set; }
	[Ordinal(1)] [RED("sunColor")] public curveData<HDRColor> SunColor { get; set; }
	[Ordinal(2)] [RED("moonColor")] public curveData<HDRColor> MoonColor { get; set; }
	[Ordinal(3)] [RED("moonSize")] public curveData<CFloat> MoonSize { get; set; }
	[Ordinal(4)] [RED("specularTint")] public curveData<HDRColor> SpecularTint { get; set; }
	public LightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDestructibleEntityProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
	[Ordinal(4)] [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }
	[Ordinal(5)] [RED("ownerGlobalId")] public worldGlobalNodeID OwnerGlobalId { get; set; }
	[Ordinal(6)] [RED("entityAttachDistance")] public CFloat EntityAttachDistance { get; set; }
	public worldDestructibleEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_TrackTargets : CVariable
{
	public EffectExecutor_TrackTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CustomLightAreaSettings : CVariable
{
	public CustomLightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorStoryActionType : CVariable
{
	public AIbehaviorStoryActionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class KnockdownReactionTask : CVariable
{
	public KnockdownReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalPhoneMessage : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("text")] public LocalizationString Text { get; set; }
	public gameJournalPhoneMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCommandParams : CVariable
{
	[Ordinal(0)] [RED("type")] public questVehicleCommandType Type { get; set; }
	[Ordinal(1)] [RED("additionalParamsOnSpline")] public CHandle<questvehicleOnSplineParams> AdditionalParamsOnSpline { get; set; }
	[Ordinal(2)] [RED("additionalParamsFollow")] public CHandle<questvehicleFollowParams> AdditionalParamsFollow { get; set; }
	[Ordinal(3)] [RED("additionalParamsToNode")] public CHandle<questvehicleToNodeParams> AdditionalParamsToNode { get; set; }
	[Ordinal(4)] [RED("additionalParamsRacing")] public CHandle<questvehicleRacingParams> AdditionalParamsRacing { get; set; }
	[Ordinal(5)] [RED("additionalParamsJoinTraffic")] public CHandle<questvehicleJoinTrafficParams> AdditionalParamsJoinTraffic { get; set; }
	public questVehicleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEntityReference : CVariable
{
	[Ordinal(0)] [RED("type")] public gameEntityReferenceType Type { get; set; }
	[Ordinal(1)] [RED("sceneActorContextName")] public CName SceneActorContextName { get; set; }
	public gameEntityReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetNodeDistanceInterruptCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckPlayerTargetNodeDistanceInterruptConditionParams Params { get; set; }
	public scnCheckPlayerTargetNodeDistanceInterruptCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerTakedownCommandHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AIFollowerTakedownCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEffectEntry : CVariable
{
	[Ordinal(0)] [RED("effectName")] public CName EffectName { get; set; }
	public scnEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInstancedMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(2)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
	[Ordinal(3)] [RED("castShadows")] public CBool CastShadows { get; set; }
	[Ordinal(4)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(5)] [RED("occluderAutohideDistanceScale")] public CUInt8 OccluderAutohideDistanceScale { get; set; }
	[Ordinal(6)] [RED("worldTransformsBuffer")] public worldRenderProxyTransformBuffer WorldTransformsBuffer { get; set; }
	public worldInstancedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSpawnPointMarker : CVariable
{
	public worldSpawnPointMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehiclePortalsList : CVariable
{
	public vehiclePortalsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_ForceRagdoll : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_ForceRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetAutopilot_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("val")] public CBool Val { get; set; }
	public questSetAutopilot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SharpeningAreaSettings : CVariable
{
	[Ordinal(0)] [RED("sharpeningStrength")] public CFloat SharpeningStrength { get; set; }
	public SharpeningAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerBeforeTakedown : CVariable
{
	public AIFollowerBeforeTakedown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerToggleMirrorsArea_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("isInMirrorsArea")] public CBool IsInMirrorsArea { get; set; }
	public questEntityManagerToggleMirrorsArea_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameVideoType : CVariable
{
	public gameVideoType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetScanningState_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	public questSetScanningState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFreeReservedWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	public AIbehaviorFreeReservedWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CanDoReactionAction : CVariable
{
	[Ordinal(0)] [RED("reactionName")] public CName ReactionName { get; set; }
	public CanDoReactionAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ForceShootCommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public ForceShootCommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEntityReferenceType : CVariable
{
	public gameEntityReferenceType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataMappinPhase : CVariable
{
	public gamedataMappinPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RevealPlayerSettings : CVariable
{
	[Ordinal(0)] [RED("revealPlayer")] public ERevealPlayerType RevealPlayer { get; set; }
	[Ordinal(1)] [RED("revealPlayerOutsideSecurityPerimeter")] public CBool RevealPlayerOutsideSecurityPerimeter { get; set; }
	public RevealPlayerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StrikeExecutor_Debug_ApplyStatusEffect : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public StrikeExecutor_Debug_ApplyStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectObjectProvider_TrapEntities : CVariable
{
	public EffectObjectProvider_TrapEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnPlayRidAnimEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("animData")] public scneventsPlayAnimEventExData AnimData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("actorComponent")] public CName ActorComponent { get; set; }
	[Ordinal(5)] [RED("gameplayAnimName")] public CHandle<scnAnimName> GameplayAnimName { get; set; }
	[Ordinal(6)] [RED("FPPControlActive")] public CBool FPPControlActive { get; set; }
	[Ordinal(7)] [RED("blendOverride")] public scnfppBlendOverride BlendOverride { get; set; }
	[Ordinal(8)] [RED("ridVersinon")] public CUInt32 RidVersinon { get; set; }
	[Ordinal(9)] [RED("animResRefId")] public scnRidAnimationSRRefId AnimResRefId { get; set; }
	[Ordinal(10)] [RED("animOriginMarker")] public scnMarker AnimOriginMarker { get; set; }
	public scnPlayRidAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFXManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIFXManagerNodeType> Type { get; set; }
	public questFXManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LogicalCondition : CVariable
{
	[Ordinal(0)] [RED("operation")] public WorkspotConditionOperators Operation { get; set; }
	[Ordinal(1)] [RED("conditions")] public CArray<CHandle<workIScriptedCondition>> Conditions { get; set; }
	public LogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimInterpolationDirection : CVariable
{
	public inkanimInterpolationDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetSaveDataLoadingScreen_NodeType : CVariable
{
	[Ordinal(0)] [RED("selectedLoading")] public TweakDBID SelectedLoading { get; set; }
	public questSetSaveDataLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameNotPrereq : CVariable
{
	[Ordinal(0)] [RED("negatedPrereq")] public CHandle<gameIPrereq> NegatedPrereq { get; set; }
	public gameNotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInjectLoot_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questInjectLoot_NodeTypeParams> Params { get; set; }
	public questInjectLoot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entVisualTagsSchema : CVariable
{
	public entVisualTagsSchema(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsUIAnimationBraindanceEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(3)] [RED("animationName")] public CName AnimationName { get; set; }
	[Ordinal(4)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	public scneventsUIAnimationBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldGISpaceNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("priority")] public CUInt32 Priority { get; set; }
	[Ordinal(4)] [RED("group")] public rendGIGroup Group { get; set; }
	[Ordinal(5)] [RED("interior")] public CBool Interior { get; set; }
	[Ordinal(6)] [RED("runtime")] public CBool Runtime { get; set; }
	[Ordinal(7)] [RED("updated")] public CBool Updated { get; set; }
	public worldGISpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HitShapeUserDataBase : CVariable
{
	[Ordinal(0)] [RED("dismembermentPart")] public EAIDismembermentBodyPart DismembermentPart { get; set; }
	public HitShapeUserDataBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleEVehicleSpeedConditionType : CVariable
{
	public vehicleEVehicleSpeedConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_AnimEnd : CVariable
{
	[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimStateTransitionCondition_AnimEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDyngConstraintLink : CVariable
{
	[Ordinal(0)] [RED("bone1")] public animTransformIndex Bone1 { get; set; }
	[Ordinal(1)] [RED("bone2")] public animTransformIndex Bone2 { get; set; }
	public animDyngConstraintLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionUseCommunityWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(2)] [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
	[Ordinal(3)] [RED("playExitAutomatically")] public CHandle<AIArgumentMapping> PlayExitAutomatically { get; set; }
	[Ordinal(4)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
	public AIbehaviorActionUseCommunityWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorHasPendingForcedBehaviorConditionDefinition : CVariable
{
	public AIbehaviorHasPendingForcedBehaviorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnscreenplayItemId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnscreenplayItemId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workEntryAnim : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
	public workEntryAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class StackRelaxedState : CVariable
{
	public StackRelaxedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectExecutor_DamageProjection : CVariable
{
	public gameEffectExecutor_DamageProjection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RegisterFastTravelPointsEvent : CVariable
{
	[Ordinal(0)] [RED("fastTravelNodes")] public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes { get; set; }
	public RegisterFastTravelPointsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIHoldPositionCommandParams : CVariable
{
	public AIHoldPositionCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleQuestWindowDestruction : CVariable
{
	public vehicleQuestWindowDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemHudParameter : CVariable
{
	[Ordinal(0)] [RED("timeBegin")] public CFloat TimeBegin { get; set; }
	[Ordinal(1)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(2)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(3)] [RED("glitchParameter1")] public effectEffectParameterEvaluator GlitchParameter1 { get; set; }
	public effectTrackItemHudParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimationType : CVariable
{
	public animAnimationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandToAlertedAnimFeature : CVariable
{
	public ReprimandToAlertedAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLogicalHubNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("inputSocketCount")] public CUInt32 InputSocketCount { get; set; }
	public questLogicalHubNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMultilayerMaskBlobHeader : CVariable
{
	[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
	[Ordinal(1)] [RED("atlasWidth")] public CUInt32 AtlasWidth { get; set; }
	[Ordinal(2)] [RED("atlasHeight")] public CUInt32 AtlasHeight { get; set; }
	[Ordinal(3)] [RED("numLayers")] public CUInt32 NumLayers { get; set; }
	[Ordinal(4)] [RED("maskWidth")] public CUInt32 MaskWidth { get; set; }
	[Ordinal(5)] [RED("maskHeight")] public CUInt32 MaskHeight { get; set; }
	[Ordinal(6)] [RED("maskWidthLow")] public CUInt32 MaskWidthLow { get; set; }
	[Ordinal(7)] [RED("maskHeightLow")] public CUInt32 MaskHeightLow { get; set; }
	[Ordinal(8)] [RED("maskTileSize")] public CUInt32 MaskTileSize { get; set; }
	[Ordinal(9)] [RED("flags")] public CUInt32 Flags { get; set; }
	public rendRenderMultilayerMaskBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleCollision_ConditionType : CVariable
{
	public questVehicleCollision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_DisableSleepMode : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_DisableSleepMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRepair_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questRepair_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorCollision : CVariable
{
	[Ordinal(0)] [RED("restitution")] public CFloat Restitution { get; set; }
	[Ordinal(1)] [RED("staticFriction")] public CFloat StaticFriction { get; set; }
	[Ordinal(2)] [RED("velocityDamp")] public CFloat VelocityDamp { get; set; }
	[Ordinal(3)] [RED("particleRadius")] public CFloat ParticleRadius { get; set; }
	public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerParameters_SetAttitudeGroupForPuppet : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("groupName")] public CName GroupName { get; set; }
	public questCharacterManagerParameters_SetAttitudeGroupForPuppet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIJoinTargetsSquadTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AIJoinTargetsSquadTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDyngParticlesContainer : CVariable
{
	[Ordinal(0)] [RED("externalForceWsLink")] public animVectorLink ExternalForceWsLink { get; set; }
	[Ordinal(1)] [RED("particles")] public CArray<animDyngParticle> Particles { get; set; }
	public animDyngParticlesContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionDynamicMoveTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("moveType")] public CHandle<AIArgumentMapping> MoveType { get; set; }
	[Ordinal(2)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(3)] [RED("targetPosition")] public CHandle<AIArgumentMapping> TargetPosition { get; set; }
	[Ordinal(4)] [RED("toleranceRadius")] public CHandle<AIArgumentMapping> ToleranceRadius { get; set; }
	[Ordinal(5)] [RED("desiredDistanceFromTarget")] public CHandle<AIArgumentMapping> DesiredDistanceFromTarget { get; set; }
	[Ordinal(6)] [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
	[Ordinal(7)] [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
	[Ordinal(8)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
	[Ordinal(9)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
	public AIbehaviorActionDynamicMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAudioDurationEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("audioEventName")] public CName AudioEventName { get; set; }
	[Ordinal(5)] [RED("playbackDirectionSupport")] public scnAudioPlaybackDirectionSupportFlag PlaybackDirectionSupport { get; set; }
	public scnAudioDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLevelUpData : CVariable
{
	[Ordinal(0)] [RED("lvl")] public CInt32 Lvl { get; set; }
	[Ordinal(1)] [RED("type")] public gamedataProficiencyType Type { get; set; }
	public questLevelUpData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class worldOffMeshConnectionType : CVariable
{
	public worldOffMeshConnectionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameHitRepresentationResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("representations")] public CArray<gameHitShapeContainer> Representations { get; set; }
	[Ordinal(2)] [RED("overrides")] public CArray<gameHitRepresentationVisualTaggedOverride> Overrides { get; set; }
	public gameHitRepresentationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectParameter_VectorEvaluator_Blackboard : CVariable
{
	[Ordinal(0)] [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }
	public gameEffectParameter_VectorEvaluator_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_EquipWeapon : CVariable
{
	[Ordinal(0)] [RED("weaponID")] public TweakDBID WeaponID { get; set; }
	[Ordinal(1)] [RED("forceFirstEquip")] public CBool ForceFirstEquip { get; set; }
	public questCharacterManagerCombat_EquipWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CPhysicsDecorationResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
	[Ordinal(2)] [RED("parameters")] public CArray<CHandle<meshMeshParameter>> Parameters { get; set; }
	[Ordinal(3)] [RED("boundingBox")] public Box BoundingBox { get; set; }
	[Ordinal(4)] [RED("surfaceAreaPerAxis")] public Vector3 SurfaceAreaPerAxis { get; set; }
	[Ordinal(5)] [RED("materialEntries")] public CArray<CMeshMaterialEntry> MaterialEntries { get; set; }
	[Ordinal(6)] [RED("preloadLocalMaterialInstances")] public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances { get; set; }
	[Ordinal(7)] [RED("appearances")] public CArray<CHandle<meshMeshAppearance>> Appearances { get; set; }
	[Ordinal(8)] [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
	[Ordinal(9)] [RED("lodLevelInfo")] public CArray<CFloat> LodLevelInfo { get; set; }
	[Ordinal(10)] [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
	[Ordinal(11)] [RED("boneRigMatrices")] public CArray<CMatrix> BoneRigMatrices { get; set; }
	[Ordinal(12)] [RED("boneVertexEpsilons")] public CArray<CFloat> BoneVertexEpsilons { get; set; }
	[Ordinal(13)] [RED("lodBoneMask")] public CArray<Uint8> LodBoneMask { get; set; }
	[Ordinal(14)] [RED("castGlobalShadowsCachedInCook")] public CBool CastGlobalShadowsCachedInCook { get; set; }
	[Ordinal(15)] [RED("castLocalShadowsCachedInCook")] public CBool CastLocalShadowsCachedInCook { get; set; }
	public CPhysicsDecorationResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticOccluderMeshNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	public worldStaticOccluderMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup_BufferInfo : CVariable
{
	[Ordinal(0)] [RED("tracksMapping")] public animFacialSetup_TracksMapping TracksMapping { get; set; }
	[Ordinal(1)] [RED("numLipsyncOverridesIndexMapping")] public CUInt16 NumLipsyncOverridesIndexMapping { get; set; }
	[Ordinal(2)] [RED("numJointRegions")] public CUInt16 NumJointRegions { get; set; }
	[Ordinal(3)] [RED("face")] public animFacialSetup_OneSermoBufferInfo Face { get; set; }
	[Ordinal(4)] [RED("eyes")] public animFacialSetup_OneSermoBufferInfo Eyes { get; set; }
	[Ordinal(5)] [RED("tongue")] public animFacialSetup_OneSermoBufferInfo Tongue { get; set; }
	public animFacialSetup_BufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ResetAllFearWrappers : CVariable
{
	public ResetAllFearWrappers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SceneForceWeaponSafe : CVariable
{
	[Ordinal(0)] [RED("weaponLoweringSpeedOverride")] public CFloat WeaponLoweringSpeedOverride { get; set; }
	public SceneForceWeaponSafe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorColorMultiCurve : CVariable
{
	[Ordinal(0)] [RED("curves")] public multiChannelCurve<CFloat> Curves { get; set; }
	public CEvaluatorColorMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitSplineToFollowConditionDefinition : CVariable
{
	public AIbehaviorWaitSplineToFollowConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorParallelNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("children")] public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children { get; set; }
	[Ordinal(1)] [RED("waitFor")] public AIbehaviorParallelNodeWaitFor WaitFor { get; set; }
	public AIbehaviorParallelNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendSLightFlickering : CVariable
{
	[Ordinal(0)] [RED("flickerStrength")] public CFloat FlickerStrength { get; set; }
	[Ordinal(1)] [RED("flickerPeriod")] public CFloat FlickerPeriod { get; set; }
	public rendSLightFlickering(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterMultilayerMask : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("mask")] public rRef<Multilayer_Mask> Mask { get; set; }
	public CMaterialParameterMultilayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInstancedCrowdControlNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("crowdVariantTag")] public CName CrowdVariantTag { get; set; }
	public questInstancedCrowdControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDevice_ConditionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
	[Ordinal(1)] [RED("deviceControllerClass")] public CName DeviceControllerClass { get; set; }
	[Ordinal(2)] [RED("deviceConditionFunction")] public CName DeviceConditionFunction { get; set; }
	public questDevice_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimDatabaseCollectionEntry : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("animDatabase")] public rRef<C2dArray> AnimDatabase { get; set; }
	public animAnimDatabaseCollectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Multilayer_Setup : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("layers")] public CArray<Multilayer_Layer> Layers { get; set; }
	public Multilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUseWorkspotNodeFunctions : CVariable
{
	public questUseWorkspotNodeFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CGIDataResource : CVariable
{
	[Ordinal(0)] [RED("data")] public serializationDeferredDataBuffer Data { get; set; }
	public CGIDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemParticles : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("particleSystem")] public rRef<CParticleSystem> ParticleSystem { get; set; }
	[Ordinal(3)] [RED("emissionScale")] public effectEffectParameterEvaluatorFloat EmissionScale { get; set; }
	[Ordinal(4)] [RED("alpha")] public effectEffectParameterEvaluatorFloat Alpha { get; set; }
	[Ordinal(5)] [RED("size")] public effectEffectParameterEvaluatorFloat Size { get; set; }
	[Ordinal(6)] [RED("velocity")] public effectEffectParameterEvaluatorFloat Velocity { get; set; }
	public effectTrackItemParticles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AddItemToVendorRequest : CVariable
{
	[Ordinal(0)] [RED("vendorID")] public TweakDBID VendorID { get; set; }
	[Ordinal(1)] [RED("itemToAddID")] public TweakDBID ItemToAddID { get; set; }
	public AddItemToVendorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkDynamicTextureSlot : CVariable
{
	[Ordinal(0)] [RED("texture")] public raRef<DynamicTexture> Texture { get; set; }
	[Ordinal(1)] [RED("parts")] public CArray<inkTextureAtlasMapper> Parts { get; set; }
	public inkDynamicTextureSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPlayVideoEvent : CVariable
{
	public inkanimPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIPhoneManagerNodeType> Type { get; set; }
	public questPhoneManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetTier_NodeType : CVariable
{
	[Ordinal(0)] [RED("forceEmptyHands")] public CBool ForceEmptyHands { get; set; }
	public questSetTier_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentBoolValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentBoolValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatToIntConverter : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
	public animAnimNode_FloatToIntConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorAcceleration : CVariable
{
	[Ordinal(0)] [RED("direction")] public CHandle<IEvaluatorVector> Direction { get; set; }
	[Ordinal(1)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
	public CParticleModificatorAcceleration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CameraAreaSettings : CVariable
{
	[Ordinal(0)] [RED("automated")] public CBool Automated { get; set; }
	[Ordinal(1)] [RED("ISO")] public CUInt32 ISO { get; set; }
	[Ordinal(2)] [RED("shutterTime")] public CFloat ShutterTime { get; set; }
	[Ordinal(3)] [RED("fStop")] public CFloat FStop { get; set; }
	public CameraAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataStatusEffectType : CVariable
{
	public gamedataStatusEffectType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RelaxedState : CVariable
{
	public RelaxedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_LookAtTarget : CVariable
{
	[Ordinal(0)] [RED("targetNode")] public NodeRef TargetNode { get; set; }
	[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(2)] [RED("immediately")] public CBool Immediately { get; set; }
	public questCombatNodeParams_LookAtTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectDuration_Instant : CVariable
{
	public gameEffectDuration_Instant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimAdvertPauseEvent : CVariable
{
	[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
	public inkanimAdvertPauseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAddRemoveItem_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<CHandle<questAddRemoveItem_NodeTypeParams>> Params { get; set; }
	public questAddRemoveItem_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_OrientConstraint : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("inputTransforms")] public CArray<CHandle<animAnimNodeSourceChannel_WeightedQuat>> InputTransforms { get; set; }
	[Ordinal(2)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	public animAnimNode_OrientConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MeleeAttackCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public MeleeAttackCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSucceederNodeDefinition : CVariable
{
	public AIbehaviorSucceederNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMorphTargetMeshBlob : CVariable
{
	[Ordinal(0)] [RED("header")] public rendRenderMorphTargetMeshBlobHeader Header { get; set; }
	[Ordinal(1)] [RED("diffsBuffer")] public DataBuffer DiffsBuffer { get; set; }
	[Ordinal(2)] [RED("mappingBuffer")] public DataBuffer MappingBuffer { get; set; }
	[Ordinal(3)] [RED("baseBlob")] public CHandle<IRenderResourceBlob> BaseBlob { get; set; }
	public rendRenderMorphTargetMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleRaceQuestEvent : CVariable
{
	[Ordinal(0)] [RED("mode")] public vehicleRaceUI Mode { get; set; }
	[Ordinal(1)] [RED("maxPosition")] public CInt32 MaxPosition { get; set; }
	[Ordinal(2)] [RED("maxCheckpoints")] public CInt32 MaxCheckpoints { get; set; }
	public VehicleRaceQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsNotInstigatorWeakspotFilter : CVariable
{
	public IsNotInstigatorWeakspotFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HasPatrolAction : CVariable
{
	public HasPatrolAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSystemVariableExpressionDefinition : CVariable
{
	public AIbehaviorSystemVariableExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAISpotNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("spot")] public CHandle<AISpot> Spot { get; set; }
	[Ordinal(3)] [RED("isWorkspotInfinite")] public CBool IsWorkspotInfinite { get; set; }
	[Ordinal(4)] [RED("markings")] public CArray<CName> Markings { get; set; }
	[Ordinal(5)] [RED("useCrowdWhitelist")] public CBool UseCrowdWhitelist { get; set; }
	[Ordinal(6)] [RED("useCrowdBlacklist")] public CBool UseCrowdBlacklist { get; set; }
	public worldAISpotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMountToEntTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	public AIbehaviorMountToEntTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EAICombatPreset : CVariable
{
	public EAICombatPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCrowdNullAreaCollisionHeader : CVariable
{
	[Ordinal(0)] [RED("direction")] public Vector3 Direction { get; set; }
	[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }
	[Ordinal(2)] [RED("flags")] public CUInt8 Flags { get; set; }
	public worldCrowdNullAreaCollisionHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ReprimandEscalateAnimFeature : CVariable
{
	public ReprimandEscalateAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("foliageResource")] public raRef<worldFoliageCompiledResource> FoliageResource { get; set; }
	[Ordinal(4)] [RED("foliageLocalBounds")] public Box FoliageLocalBounds { get; set; }
	[Ordinal(5)] [RED("autoHideDistanceScale")] public CFloat AutoHideDistanceScale { get; set; }
	[Ordinal(6)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
	[Ordinal(7)] [RED("populationSpanInfo")] public worldFoliagePopulationSpanInfo PopulationSpanInfo { get; set; }
	[Ordinal(8)] [RED("destructionHash")] public CUInt64 DestructionHash { get; set; }
	[Ordinal(9)] [RED("meshHeight")] public CFloat MeshHeight { get; set; }
	public worldFoliageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_WeightedQuat : CVariable
{
	[Ordinal(0)] [RED("channel")] public CHandle<animIAnimNodeSourceChannel_Quat> Channel { get; set; }
	public animAnimNodeSourceChannel_WeightedQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMountConditionType : CVariable
{
	public questMountConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questConstAICommandParams : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AICommand> Command { get; set; }
	public questConstAICommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterEquippedItem_ConditionType : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(1)] [RED("itemTag")] public CName ItemTag { get; set; }
	public questCharacterEquippedItem_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseInfoLogger : CVariable
{
	[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<animPoseInfoLoggerEntry>> Entries { get; set; }
	public animPoseInfoLogger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUseWeapon_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
	public questUseWeapon_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimToggleVisibilityEvent : CVariable
{
	[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
	public inkanimToggleVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workAnimClipWithItem : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
	[Ordinal(2)] [RED("itemActions")] public CArray<CHandle<workIWorkspotItemAction>> ItemActions { get; set; }
	public workAnimClipWithItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questUniversalRef : CVariable
{
	[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(1)] [RED("refLocalPlayer")] public CBool RefLocalPlayer { get; set; }
	public questUniversalRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workSequence : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("list")] public CArray<CHandle<workIEntry>> List { get; set; }
	public workSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class communityArea : CVariable
{
	[Ordinal(0)] [RED("entriesData")] public CArray<communityCommunityEntrySpotsData> EntriesData { get; set; }
	public communityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamePSMUpperBodyStates : CVariable
{
	public gamePSMUpperBodyStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterAim_ConditionType : CVariable
{
	[Ordinal(0)] [RED("preciseAiming")] public CBool PreciseAiming { get; set; }
	[Ordinal(1)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
	public questCharacterAim_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IgnoreAlreadyAffectedEntities : CVariable
{
	public IgnoreAlreadyAffectedEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsPhysicsJointLimitConePair : CVariable
{
	[Ordinal(0)] [RED("swingZ")] public physicsPhysicsJointMotion SwingZ { get; set; }
	[Ordinal(1)] [RED("zAngle")] public CFloat ZAngle { get; set; }
	public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectTransformDictionary : CVariable
{
	public gameSmartObjectTransformDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTimeCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questITimeConditionType> Type { get; set; }
	public questTimeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AICommandDeviceHandler : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AICommandDeviceHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorInstantConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
	public AIbehaviorInstantConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveAlertedConditions : CVariable
{
	public PassiveAlertedConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ContainerStateInteractionCondition : CVariable
{
	public ContainerStateInteractionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSmartObjectNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("object")] public CHandle<gameSmartObjectDefinition> Object { get; set; }
	public worldSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnInterestingConversationsGroup : CVariable
{
	[Ordinal(0)] [RED("conversations")] public CArray<CHandle<scnInterestingConversationData>> Conversations { get; set; }
	public scnInterestingConversationsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StackTracksExtender : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(2)] [RED("newTracks")] public CArray<animFloatTrackInfo> NewTracks { get; set; }
	[Ordinal(3)] [RED("shrinkerNodeId")] public CUInt32 ShrinkerNodeId { get; set; }
	public animAnimNode_StackTracksExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterStructBuffer : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	public CMaterialParameterStructBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MeleeHitTerminateGameEffectExecutor : CVariable
{
	public MeleeHitTerminateGameEffectExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestCombatActionNotification : CVariable
{
	[Ordinal(0)] [RED("notifySpecificNPCs")] public CArray<NPCReference> NotifySpecificNPCs { get; set; }
	[Ordinal(1)] [RED("revealPlayerSettings")] public RevealPlayerSettings RevealPlayerSettings { get; set; }
	public QuestCombatActionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameBlackboardSerializableID : CVariable
{
	[Ordinal(0)] [RED("blackboardName")] public CName BlackboardName { get; set; }
	[Ordinal(1)] [RED("fieldName")] public CName FieldName { get; set; }
	public gameBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEffect : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("length")] public CFloat Length { get; set; }
	[Ordinal(2)] [RED("trackRoot")] public CHandle<effectTrackGroup> TrackRoot { get; set; }
	[Ordinal(3)] [RED("events")] public CArray<CHandle<effectTrackItem>> Events { get; set; }
	public worldEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPaymentBalanced_ConditionType : CVariable
{
	[Ordinal(0)] [RED("scriptCondition")] public CHandle<IScriptable> ScriptCondition { get; set; }
	public questPaymentBalanced_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animSyncMethodByProgress : CVariable
{
	public animSyncMethodByProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveOnSplineAndKeepDistance_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("keepDistanceFromRef")] public gameEntityReference KeepDistanceFromRef { get; set; }
	[Ordinal(2)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
	[Ordinal(3)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(4)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	public questMoveOnSplineAndKeepDistance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficStaticCollisionData : CVariable
{
	[Ordinal(0)] [RED("laneCollisions")] public CArray<worldStaticLaneCollisions> LaneCollisions { get; set; }
	public worldTrafficStaticCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentSpatialResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldTrafficPersistentSpatialResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldEnvironmentAreaParameters : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("renderAreaSettings")] public WorldRenderAreaSettings RenderAreaSettings { get; set; }
	[Ordinal(2)] [RED("resaved")] public CBool Resaved { get; set; }
	public worldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class toolsTimeLineBaseDescriptor : CVariable
{
	[Ordinal(0)] [RED("tracks")] public toolsTimeLineItemCollection Tracks { get; set; }
	[Ordinal(1)] [RED("lastUsedId")] public CUInt64 LastUsedId { get; set; }
	[Ordinal(2)] [RED("tracksRootId")] public CUInt64 TracksRootId { get; set; }
	public toolsTimeLineBaseDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Switch : CVariable
{
	[Ordinal(0)] [RED("numInputs")] public CUInt32 NumInputs { get; set; }
	[Ordinal(1)] [RED("blendTime")] public CFloat BlendTime { get; set; }
	[Ordinal(2)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	[Ordinal(3)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
	public animAnimNode_Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameuiCharacterCustomizationUiPreset : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("isMaleVO")] public CBool IsMaleVO { get; set; }
	[Ordinal(2)] [RED("values")] public CArray<gameuiCharacterCustomizationUiPresetValue> Values { get; set; }
	public gameuiCharacterCustomizationUiPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class redTagList : CVariable
{
	[Ordinal(0)] [RED("tags")] public CArray<CName> Tags { get; set; }
	public redTagList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_RotateBoneByQuaternion : CVariable
{
	[Ordinal(0)] [RED("quaternionNode")] public animQuaternionLink QuaternionNode { get; set; }
	[Ordinal(1)] [RED("bone")] public animTransformIndex Bone { get; set; }
	public animAnimNode_RotateBoneByQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnEffectInstanceId : CVariable
{
	[Ordinal(0)] [RED("effectId")] public scnEffectId EffectId { get; set; }
	public scnEffectInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MinimapDataNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("encodedShapesRef")] public raRef<minimapEncodedShapes> EncodedShapesRef { get; set; }
	[Ordinal(2)] [RED("localBounds")] public Box LocalBounds { get; set; }
	public MinimapDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_BoolFeature : CVariable
{
	[Ordinal(0)] [RED("featureName")] public CName FeatureName { get; set; }
	[Ordinal(1)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
	public animAnimStateTransitionCondition_BoolFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRootMotionAnimPlacementMode : CVariable
{
	public scnRootMotionAnimPlacementMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerIgnoreFriendlyAndAlive : CVariable
{
	public PlayerIgnoreFriendlyAndAlive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameQuestGuidanceMarkerPathfindingType : CVariable
{
	public gameQuestGuidanceMarkerPathfindingType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataNPCHighLevelState : CVariable
{
	public gamedataNPCHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_FloatTrack : CVariable
{
	[Ordinal(0)] [RED("floatTrack")] public animNamedTrackIndex FloatTrack { get; set; }
	public animAnimNodeSourceChannel_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterStatPool_ConditionType : CVariable
{
	[Ordinal(0)] [RED("percent")] public CFloat Percent { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	[Ordinal(2)] [RED("statPoolType")] public gamedataStatPoolType StatPoolType { get; set; }
	public questCharacterStatPool_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questGOGReward_ConditionType : CVariable
{
	[Ordinal(0)] [RED("rewardRecordId")] public TweakDBID RewardRecordId { get; set; }
	public questGOGReward_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Timer : CVariable
{
	public animAnimNode_Timer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimAnimationLibraryResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("sequences")] public CArray<CHandle<inkanimSequence>> Sequences { get; set; }
	public inkanimAnimationLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldDistantGINode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("dataAlbedo")] public raRef<CBitmapTexture> DataAlbedo { get; set; }
	[Ordinal(2)] [RED("dataNormal")] public raRef<CBitmapTexture> DataNormal { get; set; }
	[Ordinal(3)] [RED("dataHeight")] public raRef<CBitmapTexture> DataHeight { get; set; }
	[Ordinal(4)] [RED("sectorSpan")] public Vector4 SectorSpan { get; set; }
	public worldDistantGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkWidgetLibraryResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("libraryItems")] public CArray<inkWidgetLibraryItem> LibraryItems { get; set; }
	[Ordinal(2)] [RED("externalDependenciesForInternalItems")] public CArray<raRef<CResource>> ExternalDependenciesForInternalItems { get; set; }
	public inkWidgetLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorEntityLODConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("none")] public CArray<AIbehaviorEntityLODConditions> None { get; set; }
	public AIbehaviorEntityLODConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRandomizerMode : CVariable
{
	public questRandomizerMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetRenderLayer_NodeType : CVariable
{
	[Ordinal(0)] [RED("renderSceneLayer")] public RenderSceneLayer RenderSceneLayer { get; set; }
	public questSetRenderLayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorPickSearchDestinationTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
	[Ordinal(1)] [RED("desiredDistance")] public CHandle<AIArgumentMapping> DesiredDistance { get; set; }
	[Ordinal(2)] [RED("maxDistance")] public CHandle<AIArgumentMapping> MaxDistance { get; set; }
	[Ordinal(3)] [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }
	[Ordinal(4)] [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
	[Ordinal(5)] [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }
	[Ordinal(6)] [RED("ignoreRestrictMovementArea")] public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea { get; set; }
	public AIbehaviorPickSearchDestinationTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemMaterialParameter : CVariable
{
	[Ordinal(0)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(1)] [RED("customParameter0")] public effectEffectParameterEvaluator CustomParameter0 { get; set; }
	public effectTrackItemMaterialParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AdjustAnimWrappersForDeescalatingFearPhase : CVariable
{
	public AdjustAnimWrappersForDeescalatingFearPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlatform_ConditionType : CVariable
{
	[Ordinal(0)] [RED("platform")] public questPlatform Platform { get; set; }
	public questPlatform_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_AnyAnimEnd : CVariable
{
	public animAnimStateTransitionCondition_AnyAnimEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimsetWithOverridesTagCondition : CVariable
{
	[Ordinal(0)] [RED("animsetTags")] public redTagList AnimsetTags { get; set; }
	public animAnimsetWithOverridesTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class ENoiseType : CVariable
{
	public ENoiseType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_VectorJoin : CVariable
{
	[Ordinal(0)] [RED("input")] public animVectorLink Input { get; set; }
	public animAnimNode_VectorJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RenderDecalNormalsBlendingMode : CVariable
{
	public RenderDecalNormalsBlendingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_DirectionToEuler : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animVectorLink InputNode { get; set; }
	[Ordinal(1)] [RED("conversionType")] public animEDirectionToEuler ConversionType { get; set; }
	public animAnimNode_DirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_PoseMsToLs : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_PoseMsToLs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorScriptPassiveExpressionDefinition : CVariable
{
	[Ordinal(0)] [RED("script")] public CHandle<AIbehaviorexpressionScript> Script { get; set; }
	public AIbehaviorScriptPassiveExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IntInput : CVariable
{
	[Ordinal(0)] [RED("group")] public CName Group { get; set; }
	[Ordinal(1)] [RED("name")] public CName Name { get; set; }
	public animAnimNode_IntInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendRenderMorphTargetMeshBlobHeader : CVariable
{
	public rendRenderMorphTargetMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalInternetText : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("text")] public LocalizationString Text { get; set; }
	public gameJournalInternetText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PatrolRoleHandler : CVariable
{
	public PatrolRoleHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMonitorConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
	public AIbehaviorMonitorConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FPPCameraSharedVar : CVariable
{
	public animAnimNode_FPPCameraSharedVar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameCyberspaceBoundaryNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	[Ordinal(4)] [RED("marker1Ref")] public NodeRef Marker1Ref { get; set; }
	[Ordinal(5)] [RED("marker2Ref")] public NodeRef Marker2Ref { get; set; }
	public gameCyberspaceBoundaryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questContentCondition : CVariable
{
	[Ordinal(0)] [RED("type")] public CHandle<questIContentConditionType> Type { get; set; }
	public questContentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimColorInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(2)] [RED("startValue")] public HDRColor StartValue { get; set; }
	[Ordinal(3)] [RED("endValue")] public HDRColor EndValue { get; set; }
	public inkanimColorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsRagdollBodyPartE : CVariable
{
	public physicsRagdollBodyPartE(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SuppressSecuritySystemStateChange : CVariable
{
	[Ordinal(0)] [RED("forceSecuritySystemIntoStrictQuestControl")] public CBool ForceSecuritySystemIntoStrictQuestControl { get; set; }
	public SuppressSecuritySystemStateChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class EMaterialPriority : CVariable
{
	public EMaterialPriority(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorShouldEnterCrowdConditionDefinition : CVariable
{
	public AIbehaviorShouldEnterCrowdConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AdvertisementFormat : CVariable
{
	public AdvertisementFormat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSceneTier3Data : CVariable
{
	[Ordinal(0)] [RED("emptyHands")] public CBool EmptyHands { get; set; }
	[Ordinal(1)] [RED("cameraSettings")] public gameTier3CameraSettings CameraSettings { get; set; }
	public gameSceneTier3Data(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorExtractVehicleSlotWorkspotTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
	public AIbehaviorExtractVehicleSlotWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassivePatrolConditions : CVariable
{
	public PassivePatrolConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetLootInteractionAccess_NodeType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("accessible")] public CBool Accessible { get; set; }
	public questSetLootInteractionAccess_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class C2dArray : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("headers")] public CArray<CString> Headers { get; set; }
	[Ordinal(2)] [RED("data")] public CArray<CArray<CString>> Data { get; set; }
	public C2dArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_Blend2 : CVariable
{
	[Ordinal(0)] [RED("firstInputNode")] public animPoseLink FirstInputNode { get; set; }
	[Ordinal(1)] [RED("secondInputNode")] public animPoseLink SecondInputNode { get; set; }
	[Ordinal(2)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	public animAnimNode_Blend2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InRelaxedHighLevelState : CVariable
{
	public InRelaxedHighLevelState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCompiledCommunityAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("area")] public CHandle<communityArea> Area { get; set; }
	[Ordinal(3)] [RED("sourceObjectId")] public entEntityID SourceObjectId { get; set; }
	public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_NameHashConstant : CVariable
{
	[Ordinal(0)] [RED("value")] public CName Value { get; set; }
	public animAnimNode_NameHashConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CallPolice : CVariable
{
	public CallPolice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IgnoreFriendlyTargets : CVariable
{
	public IgnoreFriendlyTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animPoseCorrectionGroup : CVariable
{
	[Ordinal(0)] [RED("poseCorrections", 2)] public CStatic<animPoseCorrection> PoseCorrections { get; set; }
	public animPoseCorrectionGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsPlayRidCameraAnimEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(2)] [RED("cameraRef")] public NodeRef CameraRef { get; set; }
	[Ordinal(3)] [RED("animData")] public scneventsPlayAnimEventData AnimData { get; set; }
	[Ordinal(4)] [RED("animSRRefId")] public scnRidCameraAnimationSRRefId AnimSRRefId { get; set; }
	[Ordinal(5)] [RED("animOriginMarker")] public scnMarker AnimOriginMarker { get; set; }
	public scneventsPlayRidCameraAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questClearForcedBehavioursNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
	public questClearForcedBehavioursNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class graphGraphConnectionDefinition : CVariable
{
	[Ordinal(0)] [RED("source")] public wCHandle<graphGraphSocketDefinition> Source { get; set; }
	[Ordinal(1)] [RED("destination")] public wCHandle<graphGraphSocketDefinition> Destination { get; set; }
	public graphGraphConnectionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestCombatActionAreaNotification : CVariable
{
	[Ordinal(0)] [RED("revealPlayerSettings")] public RevealPlayerSettings RevealPlayerSettings { get; set; }
	public QuestCombatActionAreaNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIfElseNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("children")] public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children { get; set; }
	[Ordinal(1)] [RED("condition")] public CHandle<AIbehaviorExpressionSocket> Condition { get; set; }
	public AIbehaviorIfElseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldAudioSignpostTriggerNotifier : CVariable
{
	public worldAudioSignpostTriggerNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendGIGroup : CVariable
{
	public rendGIGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectDuration_Duration_Blackboard : CVariable
{
	public gameEffectDuration_Duration_Blackboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEDirectionToEuler : CVariable
{
	public animEDirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_BoolVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	[Ordinal(1)] [RED("compareValue")] public CBool CompareValue { get; set; }
	public animAnimStateTransitionCondition_BoolVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_IntFeature : CVariable
{
	[Ordinal(0)] [RED("compareValue")] public CInt32 CompareValue { get; set; }
	[Ordinal(1)] [RED("featureName")] public CName FeatureName { get; set; }
	[Ordinal(2)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
	public animAnimStateTransitionCondition_IntFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorRepeatNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("limit")] public CHandle<AIArgumentMapping> Limit { get; set; }
	[Ordinal(2)] [RED("repeatChildOnFailure")] public CBool RepeatChildOnFailure { get; set; }
	public AIbehaviorRepeatNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameDynamicEventNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("mappinRef")] public NodeRef MappinRef { get; set; }
	[Ordinal(4)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
	public gameDynamicEventNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDistractedConditionTarget : CVariable
{
	public scnDistractedConditionTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnStartNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	public scnStartNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InVehicleCombatDecorator : CVariable
{
	public InVehicleCombatDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficPersistentNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("resource")] public raRef<worldTrafficPersistentResource> Resource { get; set; }
	public worldTrafficPersistentNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LockDeviceChainCreation : CVariable
{
	[Ordinal(0)] [RED("isLocked")] public CBool IsLocked { get; set; }
	[Ordinal(1)] [RED("source")] public CName Source { get; set; }
	public LockDeviceChainCreation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnBraindanceJumpInProgress_ConditionType : CVariable
{
	[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
	public scnBraindanceJumpInProgress_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HitData_Base : CVariable
{
	[Ordinal(0)] [RED("hitShapeType")] public HitShape_Type HitShapeType { get; set; }
	public HitData_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionRotateToObjectTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(2)] [RED("angleOffset")] public CHandle<AIArgumentMapping> AngleOffset { get; set; }
	[Ordinal(3)] [RED("angleTolerance")] public CHandle<AIArgumentMapping> AngleTolerance { get; set; }
	[Ordinal(4)] [RED("speed")] public CHandle<AIArgumentMapping> Speed { get; set; }
	[Ordinal(5)] [RED("completeWhenRotated")] public CHandle<AIArgumentMapping> CompleteWhenRotated { get; set; }
	public AIbehaviorActionRotateToObjectTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ExitFromVehicle : CVariable
{
	[Ordinal(0)] [RED("useFastExit")] public CBool UseFastExit { get; set; }
	[Ordinal(1)] [RED("tryBlendToWalk")] public CBool TryBlendToWalk { get; set; }
	public ExitFromVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsValidCombatTarget : CVariable
{
	public IsValidCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workUnequipFromSlotAction : CVariable
{
	[Ordinal(0)] [RED("itemSlot")] public TweakDBID ItemSlot { get; set; }
	public workUnequipFromSlotAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ChangeUpperBodyState : CVariable
{
	public ChangeUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInputController_ConditionType : CVariable
{
	[Ordinal(0)] [RED("inputController")] public questInputDevice InputController { get; set; }
	public questInputController_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIRoleCondition : CVariable
{
	[Ordinal(0)] [RED("role")] public EAIRole Role { get; set; }
	public AIRoleCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalEmailGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalEmailGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Box : CVariable
{
	[Ordinal(0)] [RED("Min")] public Vector4 Min { get; set; }
	[Ordinal(1)] [RED("Max")] public Vector4 Max { get; set; }
	public Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animRigIkRightFootSetup : CVariable
{
	[Ordinal(0)] [RED("firstBone")] public CName FirstBone { get; set; }
	[Ordinal(1)] [RED("secondBone")] public CName SecondBone { get; set; }
	[Ordinal(2)] [RED("endBone")] public CName EndBone { get; set; }
	[Ordinal(3)] [RED("hingeAxis")] public animAxis HingeAxis { get; set; }
	[Ordinal(4)] [RED("firstBoneIdx")] public CInt16 FirstBoneIdx { get; set; }
	[Ordinal(5)] [RED("secondBoneIdx")] public CInt16 SecondBoneIdx { get; set; }
	[Ordinal(6)] [RED("endBoneIdx")] public CInt16 EndBoneIdx { get; set; }
	public animRigIkRightFootSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimationBufferCompressed : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
	[Ordinal(2)] [RED("numJoints")] public CUInt16 NumJoints { get; set; }
	[Ordinal(3)] [RED("numTracks")] public CUInt16 NumTracks { get; set; }
	[Ordinal(4)] [RED("numAnimKeys")] public CUInt32 NumAnimKeys { get; set; }
	[Ordinal(5)] [RED("numAnimKeysRaw")] public CUInt32 NumAnimKeysRaw { get; set; }
	[Ordinal(6)] [RED("numConstAnimKeys")] public CUInt32 NumConstAnimKeys { get; set; }
	[Ordinal(7)] [RED("numConstTrackKeys")] public CUInt32 NumConstTrackKeys { get; set; }
	[Ordinal(8)] [RED("isScaleConstant")] public CBool IsScaleConstant { get; set; }
	[Ordinal(9)] [RED("fallbackFrameDesc")] public animAnimFallbackFrameDesc FallbackFrameDesc { get; set; }
	[Ordinal(10)] [RED("fallbackFrameBuffer")] public DataBuffer FallbackFrameBuffer { get; set; }
	[Ordinal(11)] [RED("dataAddress")] public animAnimDataAddress DataAddress { get; set; }
	public animAnimationBufferCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectSingleFilter_BlackboardBoolCondition : CVariable
{
	[Ordinal(0)] [RED("parameter")] public gameEffectInputParameter_Bool Parameter { get; set; }
	[Ordinal(1)] [RED("filter")] public CHandle<gameEffectObjectSingleFilter> Filter { get; set; }
	public gameEffectObjectSingleFilter_BlackboardBoolCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_PhysicalRay : CVariable
{
	[Ordinal(0)] [RED("inputPosition")] public gameEffectInputParameter_Vector InputPosition { get; set; }
	[Ordinal(1)] [RED("inputForward")] public gameEffectInputParameter_Vector InputForward { get; set; }
	[Ordinal(2)] [RED("inputRange")] public gameEffectInputParameter_Float InputRange { get; set; }
	[Ordinal(3)] [RED("outputRaycastEnd")] public gameEffectOutputParameter_Vector OutputRaycastEnd { get; set; }
	[Ordinal(4)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
	public gameEffectObjectProvider_PhysicalRay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RenderSceneLayer : CVariable
{
	public RenderSceneLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsShapeType : CVariable
{
	public physicsShapeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimDataAddress : CVariable
{
	[Ordinal(0)] [RED("unkIndex")] public CUInt32 UnkIndex { get; set; }
	[Ordinal(1)] [RED("fsetInBytes")] public CUInt32 FsetInBytes { get; set; }
	[Ordinal(2)] [RED("zeInBytes")] public CUInt32 ZeInBytes { get; set; }
	public animAnimDataAddress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectInputParameter_Bool : CVariable
{
	[Ordinal(0)] [RED("evaluator")] public CHandle<gameIEffectParameter_BoolEvaluator> Evaluator { get; set; }
	public gameEffectInputParameter_Bool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorScriptConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("script")] public CHandle<AIbehaviorconditionScript> Script { get; set; }
	public AIbehaviorScriptConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Spline : CVariable
{
	[Ordinal(0)] [RED("points")] public CArray<SplinePoint> Points { get; set; }
	public Spline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questFollowParams : CVariable
{
	[Ordinal(0)] [RED("companionRef")] public CHandle<questUniversalRef> CompanionRef { get; set; }
	[Ordinal(1)] [RED("companionDistance")] public CFloat CompanionDistance { get; set; }
	[Ordinal(2)] [RED("destinationPointTolerance")] public CFloat DestinationPointTolerance { get; set; }
	public questFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIPatrolCommand : CVariable
{
	[Ordinal(0)] [RED("pathParams")] public CHandle<AIPatrolPathParameters> PathParams { get; set; }
	public AIPatrolCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MoveToCoverCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public MoveToCoverCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class moveMovementType : CVariable
{
	public moveMovementType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectFilter_Cone : CVariable
{
	public gameEffectObjectFilter_Cone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPhoneStatus : CVariable
{
	public questPhoneStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animTransformChannel : CVariable
{
	public animTransformChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPlaybackOptions : CVariable
{
	[Ordinal(0)] [RED("loopType")] public inkanimLoopType LoopType { get; set; }
	public inkanimPlaybackOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIInjectCombatTargetCommand : CVariable
{
	[Ordinal(0)] [RED("immediately")] public CBool Immediately { get; set; }
	[Ordinal(1)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }
	public AIInjectCombatTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectObjectProvider_VentilationAreaEntities : CVariable
{
	public EffectObjectProvider_VentilationAreaEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AimAtTargetCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AimAtTargetCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDistanceToTargetObjectConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(1)] [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }
	[Ordinal(2)] [RED("comparisonOperator")] public EComparisonType ComparisonOperator { get; set; }
	public AIbehaviorDistanceToTargetObjectConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CustomEventSender : CVariable
{
	[Ordinal(0)] [RED("tags")] public CArray<CName> Tags { get; set; }
	[Ordinal(1)] [RED("priority")] public CFloat Priority { get; set; }
	public CustomEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StagePoseEntry : CVariable
{
	[Ordinal(0)] [RED("inputName")] public CName InputName { get; set; }
	public animAnimNode_StagePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameDeviceResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("data")] public CHandle<gameDeviceResourceData> Data { get; set; }
	public gameDeviceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animDyngConstraintEllipsoid : CVariable
{
	[Ordinal(0)] [RED("bone")] public animTransformIndex Bone { get; set; }
	[Ordinal(1)] [RED("ellipsoidTransformLS")] public QsTransform EllipsoidTransformLS { get; set; }
	[Ordinal(2)] [RED("constraintRadius")] public CFloat ConstraintRadius { get; set; }
	[Ordinal(3)] [RED("constraintScale1")] public CFloat ConstraintScale1 { get; set; }
	[Ordinal(4)] [RED("constraintScale2")] public CFloat ConstraintScale2 { get; set; }
	public animDyngConstraintEllipsoid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class rendLightChannel : CVariable
{
	public rendLightChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalFileGroup : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	[Ordinal(1)] [RED("entries")] public CArray<CHandle<gameJournalEntry>> Entries { get; set; }
	public gameJournalFileGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleSystem : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("emitters")] public CArray<CHandle<CParticleEmitter>> Emitters { get; set; }
	[Ordinal(2)] [RED("boundingBox")] public Box BoundingBox { get; set; }
	[Ordinal(3)] [RED("forceDynamicBbox")] public CBool ForceDynamicBbox { get; set; }
	public CParticleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMappinManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(3)] [RED("disablePreviousMappins")] public CBool DisablePreviousMappins { get; set; }
	public questMappinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameTargetingSet : CVariable
{
	public gameTargetingSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleAvailable_ConditionType : CVariable
{
	[Ordinal(0)] [RED("vehicleType")] public questAvailableVehicleType VehicleType { get; set; }
	public questVehicleAvailable_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_MathExpressionFloat : CVariable
{
	[Ordinal(0)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }
	[Ordinal(1)] [RED("expressionString")] public CString ExpressionString { get; set; }
	public animAnimNode_MathExpressionFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class locVoiceoverMap : CVariable
{
	public locVoiceoverMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_Sound : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_Sound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questBehindInteractionEventType : CVariable
{
	public questBehindInteractionEventType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AISetCombatPresetTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AISetCombatPresetTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CMaterialParameterTerrainSetup : CVariable
{
	[Ordinal(0)] [RED("parameterName")] public CName ParameterName { get; set; }
	[Ordinal(1)] [RED("register")] public CUInt32 Register { get; set; }
	[Ordinal(2)] [RED("setup")] public rRef<CTerrainSetup> Setup { get; set; }
	public CMaterialParameterTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class physicsColliderMesh : CVariable
{
	[Ordinal(0)] [RED("localToBody")] public Transform LocalToBody { get; set; }
	[Ordinal(1)] [RED("material")] public CName Material { get; set; }
	[Ordinal(2)] [RED("compiledGeometryBuffer")] public DataBuffer CompiledGeometryBuffer { get; set; }
	public physicsColliderMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnGameplayTransitionEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	[Ordinal(4)] [RED("vehState")] public scnPuppetVehicleState VehState { get; set; }
	public scnGameplayTransitionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamDestructionStepData : CVariable
{
	[Ordinal(0)] [RED("offsets")] public CArray<physicsDestructionHierarchyOffset> Offsets { get; set; }
	[Ordinal(1)] [RED("isInstantRemovable")] public CString IsInstantRemovable { get; set; }
	public meshMeshParamDestructionStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkFontFamilyResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("familyName")] public CName FamilyName { get; set; }
	[Ordinal(2)] [RED("fontStyles")] public CArray<inkFontStyle> FontStyles { get; set; }
	public inkFontFamilyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalContactModifierEntry : CVariable
{
	[Ordinal(0)] [RED("id")] public CString Id { get; set; }
	public gameJournalContactModifierEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_ApplyCorrectivePoseRBF : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("correctives")] public CArray<animCorrectivePoseEntry> Correctives { get; set; }
	public animAnimNode_ApplyCorrectivePoseRBF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableProvider_StaticSwitch : CVariable
{
	[Ordinal(0)] [RED("type")] public animMotionTableType Type { get; set; }
	[Ordinal(1)] [RED("action")] public animMotionTableAction Action { get; set; }
	public animMotionTableProvider_StaticSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(3)] [RED("params")] public CHandle<questAICommandParams> Params { get; set; }
	public questCombatNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entRagdollActivationRequestEvent : CVariable
{
	[Ordinal(0)] [RED("data")] public entragdollActivationRequestData Data { get; set; }
	public entRagdollActivationRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SuspensionLimit : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
	[Ordinal(2)] [RED("radiusTrack")] public animNamedTrackIndex RadiusTrack { get; set; }
	[Ordinal(3)] [RED("deviationTrack")] public animNamedTrackIndex DeviationTrack { get; set; }
	[Ordinal(4)] [RED("axis")] public animAxis Axis { get; set; }
	public animAnimNode_SuspensionLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDeviceControllerInvestigationData : CVariable
{
	public SetDeviceControllerInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TonemappingModeLinear : CVariable
{
	public TonemappingModeLinear(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class entEntityTemplate : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("compiledData")] public DataBuffer CompiledData { get; set; }
	[Ordinal(2)] [RED("resolvedDependencies")] public CArray<raRef<CResource>> ResolvedDependencies { get; set; }
	public entEntityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LightGroupsAreaSettings : CVariable
{
	public LightGroupsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerInterpolateFollowingSpeed : CVariable
{
	[Ordinal(0)] [RED("enterCondition")] public TweakDBID EnterCondition { get; set; }
	[Ordinal(1)] [RED("exitCondition")] public TweakDBID ExitCondition { get; set; }
	[Ordinal(2)] [RED("minInterpolationDistanceToDestination")] public CFloat MinInterpolationDistanceToDestination { get; set; }
	[Ordinal(3)] [RED("maxInterpolationDistanceToDestination")] public CFloat MaxInterpolationDistanceToDestination { get; set; }
	[Ordinal(4)] [RED("maxTimeDilation")] public CFloat MaxTimeDilation { get; set; }
	public AIFollowerInterpolateFollowingSpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SimpleCombatConditon : CVariable
{
	public SimpleCombatConditon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsSuppressedPredicate : CVariable
{
	public gameinteractionsSuppressedPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animRigIkLeftFootSetup : CVariable
{
	[Ordinal(0)] [RED("firstBone")] public CName FirstBone { get; set; }
	[Ordinal(1)] [RED("secondBone")] public CName SecondBone { get; set; }
	[Ordinal(2)] [RED("endBone")] public CName EndBone { get; set; }
	[Ordinal(3)] [RED("hingeAxis")] public animAxis HingeAxis { get; set; }
	[Ordinal(4)] [RED("firstBoneIdx")] public CInt16 FirstBoneIdx { get; set; }
	[Ordinal(5)] [RED("secondBoneIdx")] public CInt16 SecondBoneIdx { get; set; }
	[Ordinal(6)] [RED("endBoneIdx")] public CInt16 EndBoneIdx { get; set; }
	public animRigIkLeftFootSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_BlendMultiple : CVariable
{
	[Ordinal(0)] [RED("inputValues")] public CArray<CFloat> InputValues { get; set; }
	[Ordinal(1)] [RED("sortedInputValues")] public CArray<CFloat> SortedInputValues { get; set; }
	[Ordinal(2)] [RED("minWeight")] public CFloat MinWeight { get; set; }
	[Ordinal(3)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
	[Ordinal(4)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
	public animAnimNode_BlendMultiple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorStackScriptTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("script")] public CHandle<AIbehaviortaskStackScript> Script { get; set; }
	public AIbehaviorStackScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRidResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("actors")] public CArray<scnActorRid> Actors { get; set; }
	[Ordinal(2)] [RED("nextSerialNumber")] public scnRidSerialNumber NextSerialNumber { get; set; }
	[Ordinal(3)] [RED("version")] public CUInt32 Version { get; set; }
	public scnRidResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PaymentBalanced_ScriptConditionType : CVariable
{
	[Ordinal(0)] [RED("questAssignment")] public TweakDBID QuestAssignment { get; set; }
	[Ordinal(1)] [RED("difficulty")] public EGameplayChallengeLevel Difficulty { get; set; }
	public PaymentBalanced_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticQuestMarkerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("questType")] public worldQuestType QuestType { get; set; }
	[Ordinal(3)] [RED("questLabel")] public CString QuestLabel { get; set; }
	public worldStaticQuestMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questQuestResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("graph")] public CHandle<graphGraphDefinition> Graph { get; set; }
	public questQuestResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MountRequestPassiveCondition : CVariable
{
	public MountRequestPassiveCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlaybackOptionsUpdateData : CVariable
{
	public PlaybackOptionsUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalEntryVisited_ConditionType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	[Ordinal(1)] [RED("visited")] public CBool Visited { get; set; }
	public questJournalEntryVisited_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CensorshipFlags : CVariable
{
	public CensorshipFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleRadioEvent : CVariable
{
	[Ordinal(0)] [RED("toggle")] public CBool Toggle { get; set; }
	[Ordinal(1)] [RED("setStation")] public CBool SetStation { get; set; }
	[Ordinal(2)] [RED("station")] public CInt32 Station { get; set; }
	public VehicleRadioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameItemUnequipContexts : CVariable
{
	public gameItemUnequipContexts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArgumentSerializableValue : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIArgumentSerializableValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleTankCustomFPPLockOff_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("val")] public CBool Val { get; set; }
	public questToggleTankCustomFPPLockOff_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetNodeDistanceReturnConditionParams : CVariable
{
	[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }
	[Ordinal(1)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	[Ordinal(2)] [RED("targetNode")] public NodeRef TargetNode { get; set; }
	public scnCheckPlayerTargetNodeDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_SingleEntity : CVariable
{
	public gameEffectObjectProvider_SingleEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class VehicleQuestHornEvent : CVariable
{
	[Ordinal(0)] [RED("honkTime")] public CFloat HonkTime { get; set; }
	public VehicleQuestHornEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CRUID : CVariable
{
	public CRUID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scneventsVFXBraindanceEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("duration")] public CUInt32 Duration { get; set; }
	[Ordinal(3)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
	[Ordinal(4)] [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
	[Ordinal(5)] [RED("fullyRewindable")] public CBool FullyRewindable { get; set; }
	public scneventsVFXBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_FloatVariable : CVariable
{
	[Ordinal(0)] [RED("variableName")] public CName VariableName { get; set; }
	[Ordinal(1)] [RED("compareValue")] public CFloat CompareValue { get; set; }
	[Ordinal(2)] [RED("compareFunc")] public animCompareFunc CompareFunc { get; set; }
	public animAnimStateTransitionCondition_FloatVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PauseBraindance : CVariable
{
	public PauseBraindance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorRotationRateOverLife : CVariable
{
	[Ordinal(0)] [RED("rotationRate")] public CHandle<IEvaluatorFloat> RotationRate { get; set; }
	public CParticleModificatorRotationRateOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CacheAnimationForPotentialRagdoll : CVariable
{
	[Ordinal(0)] [RED("currentBehavior")] public CName CurrentBehavior { get; set; }
	public CacheAnimationForPotentialRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldGlobalNodeID : CVariable
{
	[Ordinal(0)] [RED("hash")] public CUInt64 Hash { get; set; }
	public worldGlobalNodeID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldLightChannelShapeNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }
	[Ordinal(3)] [RED("channels")] public rendLightChannel Channels { get; set; }
	public worldLightChannelShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayVoiceset_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questPlayVoiceset_NodeTypeParams> Params { get; set; }
	public questPlayVoiceset_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkEffectType : CVariable
{
	public inkEffectType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workIsPlayerCondition : CVariable
{
	public workIsPlayerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FloatComparator : CVariable
{
	[Ordinal(0)] [RED("secondValue")] public CFloat SecondValue { get; set; }
	[Ordinal(1)] [RED("trueValue")] public CFloat TrueValue { get; set; }
	[Ordinal(2)] [RED("operation")] public animEAnimGraphCompareFunc Operation { get; set; }
	[Ordinal(3)] [RED("firstInputLink")] public animFloatLink FirstInputLink { get; set; }
	public animAnimNode_FloatComparator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsCHotSpotDefinition : CVariable
{
	[Ordinal(0)] [RED("layersDefinition")] public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition { get; set; }
	public gameinteractionsCHotSpotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorFloatConst : CVariable
{
	[Ordinal(0)] [RED("value")] public CFloat Value { get; set; }
	public CEvaluatorFloatConst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorTimeoutNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("time")] public CHandle<AIArgumentMapping> Time { get; set; }
	public AIbehaviorTimeoutNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DeadState : CVariable
{
	public DeadState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameAggregationType : CVariable
{
	public gameAggregationType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIDriveCommandsDelegate : CVariable
{
	public AIDriveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterManagerCombat_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questICharacterManagerCombat_NodeSubType> Subtype { get; set; }
	public questCharacterManagerCombat_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetMessageRecordEvent : CVariable
{
	[Ordinal(0)] [RED("messageRecordID")] public TweakDBID MessageRecordID { get; set; }
	[Ordinal(1)] [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }
	[Ordinal(2)] [RED("customNumber")] public CInt32 CustomNumber { get; set; }
	public SetMessageRecordEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CompareArgumentsObjects : CVariable
{
	[Ordinal(0)] [RED("var1")] public CName Var1 { get; set; }
	[Ordinal(1)] [RED("var2")] public CName Var2 { get; set; }
	public CompareArgumentsObjects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class WorldPosition : CVariable
{
	[Ordinal(0)] [RED("x")] public FixedPoint X { get; set; }
	[Ordinal(1)] [RED("y")] public FixedPoint Y { get; set; }
	[Ordinal(2)] [RED("z")] public FixedPoint Z { get; set; }
	public WorldPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDistanceComparison_ConditionType : CVariable
{
	[Ordinal(0)] [RED("distanceDefinition1")] public CHandle<questObjectDistance> DistanceDefinition1 { get; set; }
	[Ordinal(1)] [RED("distanceDefinition2")] public CHandle<questValueDistance> DistanceDefinition2 { get; set; }
	[Ordinal(2)] [RED("comparisonType")] public EComparisonType ComparisonType { get; set; }
	public questDistanceComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTriggerAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }
	public worldTriggerAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRequestVehicleCameraPerspective_NodeType : CVariable
{
	[Ordinal(0)] [RED("cameraPerspective")] public questVehicleCameraPerspective CameraPerspective { get; set; }
	public questRequestVehicleCameraPerspective_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleEQuestVehicleWindowState : CVariable
{
	public vehicleEQuestVehicleWindowState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EHitReactionZone : CVariable
{
	public EHitReactionZone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleModificatorTarget : CVariable
{
	[Ordinal(0)] [RED("position")] public CHandle<IEvaluatorVector> Position { get; set; }
	[Ordinal(1)] [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
	[Ordinal(2)] [RED("killRadius")] public CHandle<IEvaluatorFloat> KillRadius { get; set; }
	public CParticleModificatorTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAudioMusicSyncNodeType : CVariable
{
	[Ordinal(0)] [RED("syncTrack")] public CName SyncTrack { get; set; }
	public questAudioMusicSyncNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTransformBuffer : CVariable
{
	[Ordinal(0)] [RED("sharedDataBuffer")] public CHandle<worldSharedDataBuffer> SharedDataBuffer { get; set; }
	[Ordinal(1)] [RED("numElements")] public CUInt32 NumElements { get; set; }
	public worldTransformBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetAttachment_ToWorld : CVariable
{
	[Ordinal(0)] [RED("attachmentRef")] public NodeRef AttachmentRef { get; set; }
	public questEntityManagerSetAttachment_ToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorPatrolActionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
	[Ordinal(2)] [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
	[Ordinal(3)] [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
	[Ordinal(4)] [RED("playStartAnimation")] public CHandle<AIArgumentMapping> PlayStartAnimation { get; set; }
	[Ordinal(5)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(6)] [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
	[Ordinal(7)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
	public AIbehaviorPatrolActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_WorkspotFastExitCutoff : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
	public animAnimEvent_WorkspotFastExitCutoff(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SyncAnimDeathTask : CVariable
{
	public SyncAnimDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class appearanceAppearanceResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("appearances")] public CArray<CHandle<appearanceAppearanceDefinition>> Appearances { get; set; }
	[Ordinal(2)] [RED("DismWoundConfig")] public entdismembermentWoundsConfigSet DismWoundConfig { get; set; }
	public appearanceAppearanceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CRenderTextureMaterial : CVariable
{
	public CRenderTextureMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSceneMarker : CVariable
{
	public scnSceneMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(2)] [RED("returnPosition")] public CHandle<AIArgumentMapping> ReturnPosition { get; set; }
	[Ordinal(3)] [RED("returnPositionVector")] public CHandle<AIArgumentMapping> ReturnPositionVector { get; set; }
	[Ordinal(4)] [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }
	[Ordinal(5)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
	[Ordinal(6)] [RED("overrideExit")] public CHandle<AIArgumentMapping> OverrideExit { get; set; }
	public AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimTranslationInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(2)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimTranslationInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class STonemappingACESParams : CVariable
{
	[Ordinal(0)] [RED("applyAfterLUT")] public CBool ApplyAfterLUT { get; set; }
	public STonemappingACESParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questOutputNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("socketName")] public CName SocketName { get; set; }
	public questOutputNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamCloth_Graphical : CVariable
{
	[Ordinal(0)] [RED("lodChunkIndices")] public CArray<CArray<CUInt16>> LodChunkIndices { get; set; }
	[Ordinal(1)] [RED("chunks")] public CArray<meshGfxClothChunkData> Chunks { get; set; }
	public meshMeshParamCloth_Graphical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CEvaluatorVectorConst : CVariable
{
	[Ordinal(0)] [RED("value")] public Vector4 Value { get; set; }
	public CEvaluatorVectorConst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldInstancedOccluderNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	public worldInstancedOccluderNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsSizePreset : CVariable
{
	public scnChoiceNodeNsSizePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CreditsData : CVariable
{
	[Ordinal(0)] [RED("showRewardPrompt")] public CBool ShowRewardPrompt { get; set; }
	public CreditsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitingMountCommandConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("requestArgument")] public CHandle<AIArgumentMapping> RequestArgument { get; set; }
	public AIbehaviorWaitingMountCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectType : CVariable
{
	public gameSmartObjectType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorInstantTaskNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("task")] public CHandle<AIbehaviorTaskDefinition> Task { get; set; }
	public AIbehaviorInstantTaskNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Point : CVariable
{
	[Ordinal(0)] [RED("x")] public CInt32 X { get; set; }
	[Ordinal(1)] [RED("y")] public CInt32 Y { get; set; }
	public Point(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveFollowTargetTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
	[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
	[Ordinal(3)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
	[Ordinal(4)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
	[Ordinal(5)] [RED("distanceMin")] public CHandle<AIArgumentMapping> DistanceMin { get; set; }
	[Ordinal(6)] [RED("distanceMax")] public CHandle<AIArgumentMapping> DistanceMax { get; set; }
	[Ordinal(7)] [RED("isPlayer")] public CHandle<AIArgumentMapping> IsPlayer { get; set; }
	[Ordinal(8)] [RED("stopHasReachedTarget")] public CHandle<AIArgumentMapping> StopHasReachedTarget { get; set; }
	[Ordinal(9)] [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
	[Ordinal(10)] [RED("allowStubMovement")] public CHandle<AIArgumentMapping> AllowStubMovement { get; set; }
	public AIbehaviorDriveFollowTargetTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameJournalDescriptorResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("entriesActivatedAtStart")] public CArray<CString> EntriesActivatedAtStart { get; set; }
	public gameJournalDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimEvent_ItemEffectDuration : CVariable
{
	[Ordinal(0)] [RED("startFrame")] public CUInt32 StartFrame { get; set; }
	[Ordinal(1)] [RED("durationInFrames")] public CUInt32 DurationInFrames { get; set; }
	[Ordinal(2)] [RED("eventName")] public CName EventName { get; set; }
	[Ordinal(3)] [RED("effectName")] public CName EffectName { get; set; }
	[Ordinal(4)] [RED("breakAllLoopsOnStop")] public CBool BreakAllLoopsOnStop { get; set; }
	public animAnimEvent_ItemEffectDuration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class visWorldOccluderType : CVariable
{
	public visWorldOccluderType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class vehicleESummonedVehicleType : CVariable
{
	public vehicleESummonedVehicleType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class navLocomotionPath : CVariable
{
	[Ordinal(0)] [RED("splineNodeRef")] public NodeRef SplineNodeRef { get; set; }
	[Ordinal(1)] [RED("segments")] public CArray<navLocomotionPathSegmentInfo> Segments { get; set; }
	[Ordinal(2)] [RED("backwardSegments")] public CArray<navLocomotionPathSegmentInfo> BackwardSegments { get; set; }
	public navLocomotionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEnforceScreenSpaceReflectionsUberQuality_NodeType : CVariable
{
	public questEnforceScreenSpaceReflectionsUberQuality_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimVariableQuaternion : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnActorId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnActorId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLogicalAndNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	public questLogicalAndNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterStatusEffect_CondtionType : CVariable
{
	[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
	[Ordinal(1)] [RED("statusEffectID")] public CString StatusEffectID { get; set; }
	public questCharacterStatusEffect_CondtionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkFullscreenCompositionResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("compositionPresets")] public CArray<inkCompositionPreset> CompositionPresets { get; set; }
	public inkFullscreenCompositionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DisableAllWorldInteractionsNotEnabledPrereq : CVariable
{
	public DisableAllWorldInteractionsNotEnabledPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsTargetObjectPlayer : CVariable
{
	[Ordinal(0)] [RED("targetObject")] public CHandle<AIArgumentMapping> TargetObject { get; set; }
	public IsTargetObjectPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimShearInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(4)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(5)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimShearInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class QuestForceDisconnectPersonalLink : CVariable
{
	public QuestForceDisconnectPersonalLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LifePath_ScriptConditionType : CVariable
{
	[Ordinal(0)] [RED("lifePathId")] public TweakDBID LifePathId { get; set; }
	public LifePath_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldNullMarker : CVariable
{
	public worldNullMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questvehicleRacingParams : CVariable
{
	[Ordinal(0)] [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }
	public questvehicleRacingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EquippedWeaponTypeCondition : CVariable
{
	[Ordinal(0)] [RED("weaponType")] public WorkspotWeaponConditionEnum WeaponType { get; set; }
	public EquippedWeaponTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CacheStatusEffectAnimationTask : CVariable
{
	public CacheStatusEffectAnimationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCompiledSmartObjectsNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("resource")] public raRef<gameSmartObjectsCompiledResource> Resource { get; set; }
	public worldCompiledSmartObjectsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveIsPlayerCompanionCondition : CVariable
{
	public PassiveIsPlayerCompanionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldRoadProxyMeshNode : CVariable
{
	[Ordinal(0)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(1)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(2)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	[Ordinal(3)] [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
	[Ordinal(4)] [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
	[Ordinal(5)] [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }
	public worldRoadProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimLoopType : CVariable
{
	public inkanimLoopType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckCurrentStatusEffect : CVariable
{
	[Ordinal(0)] [RED("statusEffectTypeToCompare")] public gamedataStatusEffectType StatusEffectTypeToCompare { get; set; }
	[Ordinal(1)] [RED("statusEffectTagToCompare")] public CName StatusEffectTagToCompare { get; set; }
	public CheckCurrentStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CParticleInitializerVelocityInherit : CVariable
{
	[Ordinal(0)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
	public CParticleInitializerVelocityInherit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnSRRefCollection : CVariable
{
	[Ordinal(0)] [RED("lipsyncAnimSets")] public CArray<scnLipsyncAnimSetSRRef> LipsyncAnimSets { get; set; }
	public scnSRRefCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_RagdollControl : CVariable
{
	[Ordinal(0)] [RED("inputPoseNode")] public animPoseLink InputPoseNode { get; set; }
	public animAnimNode_RagdollControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNodeSourceChannel_OrientationVector : CVariable
{
	[Ordinal(0)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
	[Ordinal(1)] [RED("inputTransformIndex")] public animTransformIndex InputTransformIndex { get; set; }
	[Ordinal(2)] [RED("up")] public Vector3 Up { get; set; }
	public animAnimNodeSourceChannel_OrientationVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFloatClamp : CVariable
{
	[Ordinal(0)] [RED("useMin")] public CBool UseMin { get; set; }
	[Ordinal(1)] [RED("min")] public CFloat Min { get; set; }
	[Ordinal(2)] [RED("useMax")] public CBool UseMax { get; set; }
	[Ordinal(3)] [RED("max")] public CFloat Max { get; set; }
	public animFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animFacialSetup_PosesBufferInfo : CVariable
{
	[Ordinal(0)] [RED("face")] public animFacialSetup_OneSermoPoseBufferInfo Face { get; set; }
	[Ordinal(1)] [RED("tongue")] public animFacialSetup_OneSermoPoseBufferInfo Tongue { get; set; }
	[Ordinal(2)] [RED("eyes")] public animFacialSetup_OneSermoPoseBufferInfo Eyes { get; set; }
	public animFacialSetup_PosesBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterCover_ConditionType : CVariable
{
	[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
	[Ordinal(1)] [RED("coverRef")] public NodeRef CoverRef { get; set; }
	public questCharacterCover_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questLogicalCondition : CVariable
{
	[Ordinal(0)] [RED("operation")] public questLogicalOperation Operation { get; set; }
	[Ordinal(1)] [RED("conditions")] public CArray<CHandle<questIBaseCondition>> Conditions { get; set; }
	public questLogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetDeviceInvestigationData : CVariable
{
	public SetDeviceInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAvailableVehicleType : CVariable
{
	public questAvailableVehicleType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questTeleport_NodeType : CVariable
{
	[Ordinal(0)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	[Ordinal(1)] [RED("params")] public questTeleportPuppetParams Params { get; set; }
	public questTeleport_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ERenderingPlane : CVariable
{
	public ERenderingPlane(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class RemoveStatusEffectsOnStoryTier : CVariable
{
	public RemoveStatusEffectsOnStoryTier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class envUtilsNeighborMode : CVariable
{
	public envUtilsNeighborMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorStateCompletionStatus : CVariable
{
	public AIbehaviorStateCompletionStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ApproachVehicleDecorator : CVariable
{
	[Ordinal(0)] [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
	[Ordinal(1)] [RED("mountRequest")] public CHandle<AIArgumentMapping> MountRequest { get; set; }
	[Ordinal(2)] [RED("entryPoint")] public CHandle<AIArgumentMapping> EntryPoint { get; set; }
	public ApproachVehicleDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questManageCollision_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questManageCollision_NodeTypeParams> Params { get; set; }
	public questManageCollision_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questStat_ConditionType : CVariable
{
	[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
	[Ordinal(1)] [RED("statType")] public gamedataStatType StatType { get; set; }
	public questStat_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveIdleTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	public AIbehaviorDriveIdleTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCombatModeTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("mode")] public AIbehaviorCombatModes Mode { get; set; }
	public AIbehaviorCombatModeTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TriggerCombatAgainstStimTarget : CVariable
{
	public TriggerCombatAgainstStimTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_StackTransformsExtender : CVariable
{
	[Ordinal(0)] [RED("tag")] public CName Tag { get; set; }
	[Ordinal(1)] [RED("transformInfos")] public CArray<animTransformInfo> TransformInfos { get; set; }
	[Ordinal(2)] [RED("snapMethods")] public CArray<animStackTransformsExtender_SnapToBoneMethod> SnapMethods { get; set; }
	[Ordinal(3)] [RED("snapToReferenceValues")] public CArray<CBool> SnapToReferenceValues { get; set; }
	[Ordinal(4)] [RED("snapTargetBones")] public CArray<animTransformIndex> SnapTargetBones { get; set; }
	[Ordinal(5)] [RED("offsetToReferenceValues")] public CArray<CBool> OffsetToReferenceValues { get; set; }
	[Ordinal(6)] [RED("offsetSpaceBones")] public CArray<animTransformIndex> OffsetSpaceBones { get; set; }
	[Ordinal(7)] [RED("offsets")] public CArray<QsTransform> Offsets { get; set; }
	[Ordinal(8)] [RED("shrinkerNodeId")] public CUInt32 ShrinkerNodeId { get; set; }
	public animAnimNode_StackTransformsExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class NPCDeadPrereq : CVariable
{
	public NPCDeadPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMoveToParams : CVariable
{
	[Ordinal(0)] [RED("movementTargetRef")] public CHandle<questUniversalRef> MovementTargetRef { get; set; }
	[Ordinal(1)] [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
	[Ordinal(2)] [RED("movementType")] public moveMovementType MovementType { get; set; }
	public questMoveToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsEUnaryOperator : CVariable
{
	public gameinteractionsEUnaryOperator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animQuaternionLink : CVariable
{
	[Ordinal(0)] [RED("node")] public wCHandle<animAnimNode_QuaternionValue> Node { get; set; }
	public animQuaternionLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldConversationData : CVariable
{
	[Ordinal(0)] [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }
	[Ordinal(1)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
	[Ordinal(2)] [RED("ignoreLocalLimit")] public CBool IgnoreLocalLimit { get; set; }
	[Ordinal(3)] [RED("ignoreGlobalLimit")] public CBool IgnoreGlobalLimit { get; set; }
	public worldConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataStatPoolType : CVariable
{
	public gamedataStatPoolType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_VisualEffectAtTarget : CVariable
{
	[Ordinal(0)] [RED("effect")] public gameFxResource Effect { get; set; }
	public EffectExecutor_VisualEffectAtTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldTrafficLanesSpotsResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	public worldTrafficLanesSpotsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSpawnManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("actions")] public CArray<questSpawnManagerNodeActionEntry> Actions { get; set; }
	public questSpawnManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorSelectorTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("children")] public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children { get; set; }
	public AIbehaviorSelectorTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_PrimaryWeapon : CVariable
{
	[Ordinal(0)] [RED("unEquip")] public CBool UnEquip { get; set; }
	public questCombatNodeParams_PrimaryWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gamedataMappinVariant : CVariable
{
	public gamedataMappinVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckCurrentHitReaction : CVariable
{
	[Ordinal(0)] [RED("HitReactionTypeToCompare")] public animHitReactionType HitReactionTypeToCompare { get; set; }
	[Ordinal(1)] [RED("shouldCheckDeathStimName")] public CBool ShouldCheckDeathStimName { get; set; }
	public CheckCurrentHitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorIsNodeStreamedConditionDefinition : CVariable
{
	[Ordinal(0)] [RED("isInverted")] public CBool IsInverted { get; set; }
	[Ordinal(1)] [RED("nodeRef")] public CHandle<AIArgumentMapping> NodeRef { get; set; }
	public AIbehaviorIsNodeStreamedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCombatNodeParams_ShootAt : CVariable
{
	[Ordinal(0)] [RED("targetOverridePuppet")] public gameEntityReference TargetOverridePuppet { get; set; }
	[Ordinal(1)] [RED("immediately")] public CBool Immediately { get; set; }
	public questCombatNodeParams_ShootAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gsmGameDefinition : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("mainQuest")] public raRef<questQuestResource> MainQuest { get; set; }
	[Ordinal(2)] [RED("world")] public raRef<worldWorld> World { get; set; }
	[Ordinal(3)] [RED("streamingWorld")] public raRef<CResource> StreamingWorld { get; set; }
	[Ordinal(4)] [RED("worldName")] public CString WorldName { get; set; }
	[Ordinal(5)] [RED("spawnPointTags")] public redTagList SpawnPointTags { get; set; }
	public gsmGameDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class localizationPersistenceSubtitleEntries : CVariable
{
	public localizationPersistenceSubtitleEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorMoveAlongTrafficPathActionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }
	[Ordinal(2)] [RED("ignoreTrafficSpots")] public CHandle<AIArgumentMapping> IgnoreTrafficSpots { get; set; }
	[Ordinal(3)] [RED("useCrowdAnimationGraph")] public CHandle<AIArgumentMapping> UseCrowdAnimationGraph { get; set; }
	[Ordinal(4)] [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
	[Ordinal(5)] [RED("workspotExitPositionWS")] public CHandle<AIArgumentMapping> WorkspotExitPositionWS { get; set; }
	[Ordinal(6)] [RED("workspotReturnPositionVector")] public CHandle<AIArgumentMapping> WorkspotReturnPositionVector { get; set; }
	[Ordinal(7)] [RED("workspotExitTangent")] public CHandle<AIArgumentMapping> WorkspotExitTangent { get; set; }
	[Ordinal(8)] [RED("trafficLaneReturnTangent")] public CHandle<AIArgumentMapping> TrafficLaneReturnTangent { get; set; }
	[Ordinal(9)] [RED("trafficLaneExitTangent")] public CHandle<AIArgumentMapping> TrafficLaneExitTangent { get; set; }
	public AIbehaviorMoveAlongTrafficPathActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorCombatModes : CVariable
{
	public AIbehaviorCombatModes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimShapeFillTransparencyInterpolator : CVariable
{
	[Ordinal(0)] [RED("interpolationMode")] public inkanimInterpolationMode InterpolationMode { get; set; }
	[Ordinal(1)] [RED("interpolationType")] public inkanimInterpolationType InterpolationType { get; set; }
	[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
	[Ordinal(4)] [RED("endValue")] public CFloat EndValue { get; set; }
	public inkanimShapeFillTransparencyInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnAndNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("numInSockets")] public CUInt32 NumInSockets { get; set; }
	public scnAndNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRidAnimationSRRefId : CVariable
{
	[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
	public scnRidAnimationSRRefId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AlertedRoleHandler : CVariable
{
	public AlertedRoleHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AnimationsLoadedCondition : CVariable
{
	[Ordinal(0)] [RED("melee")] public CBool Melee { get; set; }
	public AnimationsLoadedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldNavigationTileResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("localBoundingBox")] public Box LocalBoundingBox { get; set; }
	[Ordinal(2)] [RED("tilesData")] public CArray<worldNavigationTileData> TilesData { get; set; }
	public worldNavigationTileResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameSmartObjectPropertyDictionary : CVariable
{
	public gameSmartObjectPropertyDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckHitReactionStimID : CVariable
{
	public CheckHitReactionStimID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerNotCarryingPrereq : CVariable
{
	public PlayerNotCarryingPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_Explosion : CVariable
{
	public gameEffectObjectProvider_Explosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CommandCleanup : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public CommandCleanup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class meshMeshParamWorkspotOffsets : CVariable
{
	[Ordinal(0)] [RED("names")] public CArray<CName> Names { get; set; }
	[Ordinal(1)] [RED("offsets")] public CArray<CMatrix> Offsets { get; set; }
	public meshMeshParamWorkspotOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IgnorePlayerIfMountedToVehicle : CVariable
{
	public IgnorePlayerIfMountedToVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPauseConditionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
	public questPauseConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class InjectCombatThreatCommandTask : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public InjectCombatThreatCommandTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldStaticDecalNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("material")] public raRef<IMaterial> Material { get; set; }
	[Ordinal(3)] [RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }
	[Ordinal(4)] [RED("alpha")] public CFloat Alpha { get; set; }
	[Ordinal(5)] [RED("diffuseColorScale")] public HDRColor DiffuseColorScale { get; set; }
	[Ordinal(6)] [RED("forcedAutoHideDistance")] public CFloat ForcedAutoHideDistance { get; set; }
	public worldStaticDecalNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class HeatHazeAreaSettings : CVariable
{
	public HeatHazeAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_RotateBone : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
	[Ordinal(1)] [RED("angleNode")] public animFloatLink AngleNode { get; set; }
	[Ordinal(2)] [RED("bone")] public animTransformIndex Bone { get; set; }
	[Ordinal(3)] [RED("axis")] public animETransformAxis Axis { get; set; }
	[Ordinal(4)] [RED("minAngle")] public CFloat MinAngle { get; set; }
	[Ordinal(5)] [RED("maxAngle")] public CFloat MaxAngle { get; set; }
	[Ordinal(6)] [RED("clampRotation")] public CBool ClampRotation { get; set; }
	public animAnimNode_RotateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsAttachToActorParams : CVariable
{
	[Ordinal(0)] [RED("actorId")] public scnActorId ActorId { get; set; }
	public scnChoiceNodeNsAttachToActorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckDroppedThreat : CVariable
{
	public CheckDroppedThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectDuration_PredefinedTimeout : CVariable
{
	[Ordinal(0)] [RED("timeToLive")] public CFloat TimeToLive { get; set; }
	public gameEffectDuration_PredefinedTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animEAnimGraphCompareFunc : CVariable
{
	public animEAnimGraphCompareFunc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_GraphSlot : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	[Ordinal(1)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	public animAnimNode_GraphSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PassiveCannotMoveConditions : CVariable
{
	public PassiveCannotMoveConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameHitShape_OBB : CVariable
{
	[Ordinal(0)] [RED("localTransform")] public CMatrix LocalTransform { get; set; }
	[Ordinal(1)] [RED("dimensions")] public Vector3 Dimensions { get; set; }
	public gameHitShape_OBB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIArchetype : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("behaviorDefinition")] public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition { get; set; }
	[Ordinal(2)] [RED("movementParameters", 5)] public CStatic<moveMovementParameters> MovementParameters { get; set; }
	public AIArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class IsRagdolling : CVariable
{
	public IsRagdolling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectObjectProvider_ProjectileHitEvent : CVariable
{
	public gameEffectObjectProvider_ProjectileHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Vector4 : CVariable
{
	[Ordinal(0)] [RED("X")] public CFloat X { get; set; }
	[Ordinal(1)] [RED("Y")] public CFloat Y { get; set; }
	[Ordinal(2)] [RED("Z")] public CFloat Z { get; set; }
	[Ordinal(3)] [RED("W")] public CFloat W { get; set; }
	public Vector4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questToggleWindow_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	[Ordinal(1)] [RED("windowState")] public vehicleEQuestVehicleWindowState WindowState { get; set; }
	[Ordinal(2)] [RED("door")] public vehicleEVehicleDoor Door { get; set; }
	public questToggleWindow_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animMotionTableAction : CVariable
{
	public animMotionTableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorFSMStateDefinition : CVariable
{
	[Ordinal(0)] [RED("behaviorRoot")] public CHandle<AIbehaviorTreeNodeDefinition> BehaviorRoot { get; set; }
	[Ordinal(1)] [RED("isExit")] public CBool IsExit { get; set; }
	public AIbehaviorFSMStateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EFocusClueInvestigationState : CVariable
{
	public EFocusClueInvestigationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questDeviceManager_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<CHandle<questDeviceManager_NodeTypeParams>> Params { get; set; }
	public questDeviceManager_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class LockTakeControlAction : CVariable
{
	[Ordinal(0)] [RED("isLocked")] public CBool IsLocked { get; set; }
	public LockTakeControlAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ShouldNPCContinueInAlerted : CVariable
{
	public ShouldNPCContinueInAlerted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ESecurityAreaType : CVariable
{
	public ESecurityAreaType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMinimize_NodeType : CVariable
{
	public questMinimize_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questChangeVoicesetState_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questChangeVoicesetState_NodeTypeParams> Params { get; set; }
	public questChangeVoicesetState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questInputNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("socketName")] public CName SocketName { get; set; }
	public questInputNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameinteractionsvisLootVisualizerDefinition : CVariable
{
	public gameinteractionsvisLootVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnGameplayActionSetVehicleSuspensionData : CVariable
{
	[Ordinal(0)] [RED("active")] public CBool Active { get; set; }
	public scnGameplayActionSetVehicleSuspensionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class EffectExecutor_Spread : CVariable
{
	public EffectExecutor_Spread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitSlotConditionDefinition : CVariable
{
	public AIbehaviorWaitSlotConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorActionAnimationCurvePathDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("nodeReference")] public CHandle<AIArgumentMapping> NodeReference { get; set; }
	[Ordinal(2)] [RED("controllersSetupName")] public CHandle<AIArgumentMapping> ControllersSetupName { get; set; }
	[Ordinal(3)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
	[Ordinal(4)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
	[Ordinal(5)] [RED("blendTime")] public CHandle<AIArgumentMapping> BlendTime { get; set; }
	[Ordinal(6)] [RED("globalInBlendTime")] public CHandle<AIArgumentMapping> GlobalInBlendTime { get; set; }
	[Ordinal(7)] [RED("globalOutBlendTime")] public CHandle<AIArgumentMapping> GlobalOutBlendTime { get; set; }
	[Ordinal(8)] [RED("turnCharacterToMatchVelocity")] public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity { get; set; }
	[Ordinal(9)] [RED("customStartAnimationName")] public CHandle<AIArgumentMapping> CustomStartAnimationName { get; set; }
	[Ordinal(10)] [RED("customMainAnimationName")] public CHandle<AIArgumentMapping> CustomMainAnimationName { get; set; }
	[Ordinal(11)] [RED("customStopAnimationName")] public CHandle<AIArgumentMapping> CustomStopAnimationName { get; set; }
	[Ordinal(12)] [RED("startSnapToTerrain")] public CHandle<AIArgumentMapping> StartSnapToTerrain { get; set; }
	[Ordinal(13)] [RED("mainSnapToTerrain")] public CHandle<AIArgumentMapping> MainSnapToTerrain { get; set; }
	[Ordinal(14)] [RED("stopSnapToTerrain")] public CHandle<AIArgumentMapping> StopSnapToTerrain { get; set; }
	[Ordinal(15)] [RED("startSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime { get; set; }
	[Ordinal(16)] [RED("stopSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime { get; set; }
	public AIbehaviorActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIFollowerTakedownCommandDelegate : CVariable
{
	[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
	public AIFollowerTakedownCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class GlobalDeathCondition : CVariable
{
	public GlobalDeathCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questMountVehicleOrigin : CVariable
{
	public questMountVehicleOrigin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCreditsForceStopped_ConditionType : CVariable
{
	public questCreditsForceStopped_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterState_PlayerSubType : CVariable
{
	[Ordinal(0)] [RED("locomotionState")] public gamePSMLocomotionStates LocomotionState { get; set; }
	[Ordinal(1)] [RED("vehicleComparisonType")] public questEComparisonTypeEquality VehicleComparisonType { get; set; }
	[Ordinal(2)] [RED("vehicleState")] public gamePSMVehicle VehicleState { get; set; }
	public questCharacterState_PlayerSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSceneTier_ConditionType : CVariable
{
	[Ordinal(0)] [RED("tier")] public GameplayTier Tier { get; set; }
	[Ordinal(1)] [RED("isInverted")] public CBool IsInverted { get; set; }
	public questSceneTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldGIShapeNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }
	[Ordinal(3)] [RED("priority")] public CUInt32 Priority { get; set; }
	[Ordinal(4)] [RED("interior")] public CBool Interior { get; set; }
	[Ordinal(5)] [RED("runtime")] public CBool Runtime { get; set; }
	[Ordinal(6)] [RED("updated")] public CBool Updated { get; set; }
	public worldGIShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_FloatFeature : CVariable
{
	[Ordinal(0)] [RED("compareValue")] public CFloat CompareValue { get; set; }
	[Ordinal(1)] [RED("featureName")] public CName FeatureName { get; set; }
	[Ordinal(2)] [RED("featurePropertyName")] public CName FeaturePropertyName { get; set; }
	[Ordinal(3)] [RED("compareFunc")] public animCompareFunc CompareFunc { get; set; }
	public animAnimStateTransitionCondition_FloatFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnRandomizerNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	[Ordinal(2)] [RED("numOutSockets")] public CUInt32 NumOutSockets { get; set; }
	[Ordinal(3)] [RED("weights", 32)] public CArrayFixedSize<CUInt8> Weights { get; set; }
public scnRandomizerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAddRemoveContact_NodeType : CVariable
{
	[Ordinal(0)] [RED("params")] public CArray<questChangeContactList_NodeTypeParams> Params { get; set; }
	public questAddRemoveContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDriveToNodeTreeNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
	[Ordinal(1)] [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
	[Ordinal(2)] [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
	[Ordinal(3)] [RED("nodeRef")] public CHandle<AIArgumentMapping> NodeRef { get; set; }
	[Ordinal(4)] [RED("stopAtPathEnd")] public CHandle<AIArgumentMapping> StopAtPathEnd { get; set; }
	[Ordinal(5)] [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
	[Ordinal(6)] [RED("isPlayer")] public CHandle<AIArgumentMapping> IsPlayer { get; set; }
	[Ordinal(7)] [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
	[Ordinal(8)] [RED("speedInTraffic")] public CHandle<AIArgumentMapping> SpeedInTraffic { get; set; }
	[Ordinal(9)] [RED("forceGreenLights")] public CHandle<AIArgumentMapping> ForceGreenLights { get; set; }
	[Ordinal(10)] [RED("portals")] public CHandle<AIArgumentMapping> Portals { get; set; }
	[Ordinal(11)] [RED("trafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart { get; set; }
	[Ordinal(12)] [RED("trafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd { get; set; }
	public AIbehaviorDriveToNodeTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PlayerCanGiveCPOMissionDataPrereq : CVariable
{
	public PlayerCanGiveCPOMissionDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questSetImmovable_NodeType : CVariable
{
	[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
	public questSetImmovable_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnfppParallaxSpace : CVariable
{
	public scnfppParallaxSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldCrowdNullAreaNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	public worldCrowdNullAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckStimTag : CVariable
{
	[Ordinal(0)] [RED("stimTagToCompare")] public CArray<CName> StimTagToCompare { get; set; }
	public CheckStimTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class Multilayer_Mask : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("renderResourceBlob")] public rendRenderMultilayerMaskResource RenderResourceBlob { get; set; }
	public Multilayer_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorWaitRefPositionConditionDefinition : CVariable
{
	public AIbehaviorWaitRefPositionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckFactReturnCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckFactReturnConditionParams Params { get; set; }
	public scnCheckFactReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCustomStyle : CVariable
{
	public questCustomStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetBooleanArgumentWhenActive : CVariable
{
	[Ordinal(0)] [RED("booleanArgument")] public CName BooleanArgument { get; set; }
	public SetBooleanArgumentWhenActive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPlayEnv_SetWeather : CVariable
{
	[Ordinal(0)] [RED("reset")] public CBool Reset { get; set; }
	[Ordinal(1)] [RED("weatherID")] public TweakDBID WeatherID { get; set; }
	[Ordinal(2)] [RED("source")] public CName Source { get; set; }
	public questPlayEnv_SetWeather(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class CheckRagdollOutOfNavmeshTask : CVariable
{
	[Ordinal(0)] [RED("outStatusArgument")] public CHandle<AIArgumentMapping> OutStatusArgument { get; set; }
	[Ordinal(1)] [RED("outPositionStatusArgument")] public CHandle<AIArgumentMapping> OutPositionStatusArgument { get; set; }
	[Ordinal(2)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
	public CheckRagdollOutOfNavmeshTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_FootStepScaling : CVariable
{
	[Ordinal(0)] [RED("inputLink")] public animPoseLink InputLink { get; set; }
	[Ordinal(1)] [RED("hipsIndex")] public animTransformIndex HipsIndex { get; set; }
	[Ordinal(2)] [RED("leftFootIKIndex")] public animTransformIndex LeftFootIKIndex { get; set; }
	[Ordinal(3)] [RED("rightFootIKIndex")] public animTransformIndex RightFootIKIndex { get; set; }
	[Ordinal(4)] [RED("inputSpeed")] public animFloatLink InputSpeed { get; set; }
	[Ordinal(5)] [RED("weight")] public animFloatLink Weight { get; set; }
	public animAnimNode_FootStepScaling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class workTagNode : CVariable
{
	[Ordinal(0)] [RED("id")] public workWorkEntryId Id { get; set; }
	[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
	public workTagNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkanimPivotInterpolator : CVariable
{
	[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
	[Ordinal(1)] [RED("startValue")] public Vector2 StartValue { get; set; }
	[Ordinal(2)] [RED("endValue")] public Vector2 EndValue { get; set; }
	public inkanimPivotInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class DispenseFreeItem : CVariable
{
	public DispenseFreeItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetAppearance : CVariable
{
	[Ordinal(0)] [RED("appearance")] public CName Appearance { get; set; }
	public SetAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ToggleFocusClueEvent : CVariable
{
	[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
	[Ordinal(1)] [RED("investigationState")] public EFocusClueInvestigationState InvestigationState { get; set; }
	public ToggleFocusClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class TweakAIActionSmartComposite : CVariable
{
	[Ordinal(0)] [RED("smartComposite")] public TweakDBID SmartComposite { get; set; }
	public TweakAIActionSmartComposite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MeleeHitAnimEventExecutor : CVariable
{
	[Ordinal(0)] [RED("usesHitCooldown")] public CBool UsesHitCooldown { get; set; }
	public MeleeHitAnimEventExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questEntityManagerSetAttachment_NodeType : CVariable
{
	[Ordinal(0)] [RED("subtype")] public CHandle<questIEntityManagerSetAttachment_NodeSubType> Subtype { get; set; }
	public questEntityManagerSetAttachment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetGameplayRoleEvent : CVariable
{
	[Ordinal(0)] [RED("gameplayRole")] public EGameplayRole GameplayRole { get; set; }
	public SetGameplayRoleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class inkShapeCollectionResource : CVariable
{
	[Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
	[Ordinal(1)] [RED("presets")] public CArray<inkShapePreset> Presets { get; set; }
	public inkShapeCollectionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnDeletionMarkerNode : CVariable
{
	[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
	[Ordinal(1)] [RED("ffStrategy")] public scnFastForwardStrategy FfStrategy { get; set; }
	[Ordinal(2)] [RED("outputSockets")] public CArray<scnOutputSocket> OutputSockets { get; set; }
	public scnDeletionMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class SetArgumentBoolean : CVariable
{
	[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }
	[Ordinal(1)] [RED("customVar")] public CBool CustomVar { get; set; }
	public SetArgumentBoolean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldMirrorNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
	[Ordinal(3)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
	[Ordinal(4)] [RED("forceAutoHideDistance")] public CFloat ForceAutoHideDistance { get; set; }
	[Ordinal(5)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
	public worldMirrorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_IntToFloatConverter : CVariable
{
	[Ordinal(0)] [RED("inputNode")] public animIntLink InputNode { get; set; }
	public animAnimNode_IntToFloatConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnUnmountEvent : CVariable
{
	[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
	[Ordinal(1)] [RED("startTime")] public CUInt32 StartTime { get; set; }
	[Ordinal(2)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }
	[Ordinal(3)] [RED("performer")] public scnPerformerId Performer { get; set; }
	public scnUnmountEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questRadioAnnouncementNodeType : CVariable
{
	[Ordinal(0)] [RED("radioStationEvents")] public CArray<questRadioStationAnnouncementEventStruct> RadioStationEvents { get; set; }
	public questRadioAnnouncementNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class gameEffectTriggerNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
	[Ordinal(3)] [RED("effectDescs")] public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs { get; set; }
	public gameEffectTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorDelegateTaskRef : CVariable
{
	[Ordinal(0)] [RED("name")] public CName Name { get; set; }
	public AIbehaviorDelegateTaskRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questAddRemoveItem_NodeTypeParams : CVariable
{
	[Ordinal(0)] [RED("entityRef")] public CHandle<questUniversalRef> EntityRef { get; set; }
	[Ordinal(1)] [RED("itemID")] public TweakDBID ItemID { get; set; }
	[Ordinal(2)] [RED("quantity")] public CInt32 Quantity { get; set; }
	public questAddRemoveItem_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questVehicleNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("type")] public CHandle<questIVehicleManagerNodeType> Type { get; set; }
	public questVehicleNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimNode_SkSyncedSlaveAnim : CVariable
{
	[Ordinal(0)] [RED("animation")] public CName Animation { get; set; }
	[Ordinal(1)] [RED("syncTag")] public CName SyncTag { get; set; }
	public animAnimNode_SkSyncedSlaveAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnLookAtAdvancedEventData : CVariable
{
	[Ordinal(0)] [RED("basic")] public scnAnimTargetBasicData Basic { get; set; }
	[Ordinal(1)] [RED("requests")] public CArray<animLookAtRequestForPart> Requests { get; set; }
	public scnLookAtAdvancedEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliageBrush : CVariable
{
	[Ordinal(0)] [RED("items")] public CArray<CHandle<worldFoliageBrushItem>> Items { get; set; }
	public worldFoliageBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class FilterStimTargets : CVariable
{
	public FilterStimTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorExtractMountDataTaskDefinition : CVariable
{
	[Ordinal(0)] [RED("mountEventData")] public CHandle<AIArgumentMapping> MountEventData { get; set; }
	[Ordinal(1)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
	[Ordinal(2)] [RED("outIsInstant")] public CHandle<AIArgumentMapping> OutIsInstant { get; set; }
	public AIbehaviorExtractMountDataTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questCharacterMount_ConditionType : CVariable
{
	[Ordinal(0)] [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
	[Ordinal(1)] [RED("childIsPlayer")] public CBool ChildIsPlayer { get; set; }
	[Ordinal(2)] [RED("condition")] public questMountConditionType Condition { get; set; }
	[Ordinal(3)] [RED("role")] public gameMountingSlotRole Role { get; set; }
	public questCharacterMount_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldSplineNode : CVariable
{
	[Ordinal(0)] [RED("debugName")] public CName DebugName { get; set; }
	[Ordinal(1)] [RED("sourcePrefabHash")] public CUInt64 SourcePrefabHash { get; set; }
	[Ordinal(2)] [RED("splineData")] public CHandle<Spline> SplineData { get; set; }
	public worldSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questJournalTrackQuest_NodeType : CVariable
{
	[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
	public questJournalTrackQuest_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class localizationPersistenceOnScreenEntries : CVariable
{
	[Ordinal(0)] [RED("entries")] public CArray<localizationPersistenceOnScreenEntry> Entries { get; set; }
	public localizationPersistenceOnScreenEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class worldFoliagePopulationSpanInfo : CVariable
{
	[Ordinal(0)] [RED("stancesBegin")] public CUInt32 StancesBegin { get; set; }
	[Ordinal(1)] [RED("cketBegin")] public CUInt32 CketBegin { get; set; }
	[Ordinal(2)] [RED("stancesCount")] public CUInt32 StancesCount { get; set; }
	[Ordinal(3)] [RED("cketCount")] public CUInt32 CketCount { get; set; }
	public worldFoliagePopulationSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class effectTrackItemLightParameter : CVariable
{
	[Ordinal(0)] [RED("timeDuration")] public CFloat TimeDuration { get; set; }
	[Ordinal(1)] [RED("ruid")] public CRUID Ruid { get; set; }
	[Ordinal(2)] [RED("scale")] public CFloat Scale { get; set; }
	[Ordinal(3)] [RED("intensityMultiplier")] public effectEffectParameterEvaluatorFloat IntensityMultiplier { get; set; }
	[Ordinal(4)] [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
	[Ordinal(5)] [RED("radius")] public effectEffectParameterEvaluatorFloat Radius { get; set; }
	public effectTrackItemLightParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class AIbehaviorInstantConditionNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }
	[Ordinal(1)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
	[Ordinal(2)] [RED("resultIfFailed")] public AIbehaviorCompletionStatus ResultIfFailed { get; set; }
	public AIbehaviorInstantConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnCheckPlayerTargetNodeDistanceReturnCondition : CVariable
{
	[Ordinal(0)] [RED("params")] public scnCheckPlayerTargetNodeDistanceReturnConditionParams Params { get; set; }
	public scnCheckPlayerTargetNodeDistanceReturnCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class animAnimStateTransitionCondition_IntVariable : CVariable
{
	public animAnimStateTransitionCondition_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class ExposureCompensationAreaSettings : CVariable
{
	[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
	public ExposureCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questPuppetAIManagerNodeDefinition : CVariable
{
	[Ordinal(0)] [RED("sockets")] public CArray<CHandle<graphGraphSocketDefinition>> Sockets { get; set; }
	[Ordinal(1)] [RED("id")] public CUInt16 Id { get; set; }
	[Ordinal(2)] [RED("entries")] public CArray<questPuppetAIManagerNodeDefinitionEntry> Entries { get; set; }
	public questPuppetAIManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class questScene_NodeType : CVariable
{
	[Ordinal(0)] [RED("action")] public populationSpawnerObjectCtrlAction Action { get; set; }
	[Ordinal(1)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }
	public questScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class scnChoiceNodeNsTimedParams : CVariable
{
	[Ordinal(0)] [RED("action")] public scnChoiceNodeNsTimedAction Action { get; set; }
	[Ordinal(1)] [RED("duration")] public scnSceneTime Duration { get; set; }
	public scnChoiceNodeNsTimedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}

[REDMeta]
public class MaterialTechnique : CVariable
	{
    [Ordinal(0)] [RED("passes")] public CArray<MaterialPass> Passes { get; set; }
    [Ordinal(1)] [RED("featureFlagsEnabledMask")] public FeatureFlagsMask FeatureFlagsEnabledMask { get; set; }
    [Ordinal(2)] [RED("streamsToBind")] public CUInt32 StreamsToBind { get; set; }
    public MaterialTechnique(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class MaterialPass : CVariable
	{
    [Ordinal(0)] [RED("stagePassNameRegular")] public CName StagePassNameRegular { get; set; }
    [Ordinal(1)] [RED("stagePassNameDiscarded")] public CName StagePassNameDiscarded { get; set; }
    [Ordinal(2)] [RED("depthStencilMode")] public PSODescDepthStencilModeDesc DepthStencilMode { get; set; }
    [Ordinal(3)] [RED("rasterizerMode")] public PSODescRasterizerModeDesc RasterizerMode { get; set; }
    [Ordinal(4)] [RED("blendMode")] public PSODescBlendModeDesc BlendMode { get; set; }
    [Ordinal(5)] [RED("stencilWriteMask")] public CUInt8 StencilWriteMask { get; set; }
    [Ordinal(6)] [RED("stencilRef")] public CUInt8 StencilRef { get; set; }
    [Ordinal(7)] [RED("enablePixelShader")] public CBool EnablePixelShader { get; set; }
    public MaterialPass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PSODescRasterizerModeDesc : CVariable
	{
    [Ordinal(0)] [RED("frontWinding")] public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding { get; set; }
    [Ordinal(1)] [RED("valid")] public CBool Valid { get; set; }
    public PSODescRasterizerModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
[REDMeta]
public class PSODescBlendModeDesc : CVariable
	{
    [Ordinal(0)] [RED("renderTarget", 8)] public CArrayFixedSize<PSODescRenderTarget> RenderTarget { get; set; }
    public PSODescBlendModeDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
}
}