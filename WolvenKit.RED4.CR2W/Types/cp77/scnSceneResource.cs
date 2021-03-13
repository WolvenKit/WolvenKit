using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneResource : CResource
	{
		[Ordinal(1)] [RED("entryPoints")] public CArray<scnEntryPoint> EntryPoints { get; set; }
		[Ordinal(2)] [RED("exitPoints")] public CArray<scnExitPoint> ExitPoints { get; set; }
		[Ordinal(3)] [RED("notablePoints")] public CArray<scnNotablePoint> NotablePoints { get; set; }
		[Ordinal(4)] [RED("executionTagEntries")] public CArray<scnExecutionTagEntry> ExecutionTagEntries { get; set; }
		[Ordinal(5)] [RED("actors")] public CArray<scnActorDef> Actors { get; set; }
		[Ordinal(6)] [RED("playerActors")] public CArray<scnPlayerActorDef> PlayerActors { get; set; }
		[Ordinal(7)] [RED("sceneGraph")] public CHandle<scnSceneGraph> SceneGraph { get; set; }
		[Ordinal(8)] [RED("localMarkers")] public CArray<scnLocalMarker> LocalMarkers { get; set; }
		[Ordinal(9)] [RED("props")] public CArray<scnPropDef> Props { get; set; }
		[Ordinal(10)] [RED("ridResources")] public CArray<scnRidResourceHandler> RidResources { get; set; }
		[Ordinal(11)] [RED("workspots")] public CArray<CHandle<scnWorkspotData>> Workspots { get; set; }
		[Ordinal(12)] [RED("workspotInstances")] public CArray<scnWorkspotInstance> WorkspotInstances { get; set; }
		[Ordinal(13)] [RED("resouresReferences")] public scnSRRefCollection ResouresReferences { get; set; }
		[Ordinal(14)] [RED("screenplayStore")] public scnscreenplayStore ScreenplayStore { get; set; }
		[Ordinal(15)] [RED("locStore")] public scnlocLocStoreEmbedded LocStore { get; set; }
		[Ordinal(16)] [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(17)] [RED("voInfo")] public CArray<scnSceneVOInfo> VoInfo { get; set; }
		[Ordinal(18)] [RED("effectDefinitions")] public CArray<scnEffectDef> EffectDefinitions { get; set; }
		[Ordinal(19)] [RED("effectInstances")] public CArray<scnEffectInstance> EffectInstances { get; set; }
		[Ordinal(20)] [RED("executionTags")] public CArray<scnExecutionTag> ExecutionTags { get; set; }
		[Ordinal(21)] [RED("referencePoints")] public CArray<scnReferencePointDef> ReferencePoints { get; set; }
		[Ordinal(22)] [RED("interruptionScenarios")] public CArray<scnInterruptionScenario> InterruptionScenarios { get; set; }
		[Ordinal(23)] [RED("sceneSolutionHash")] public scnSceneSolutionHash SceneSolutionHash { get; set; }
		[Ordinal(24)] [RED("sceneCategoryTag")] public CEnum<scnSceneCategoryTag> SceneCategoryTag { get; set; }
		[Ordinal(25)] [RED("debugSymbols")] public scnDebugSymbols DebugSymbols { get; set; }

		public scnSceneResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
