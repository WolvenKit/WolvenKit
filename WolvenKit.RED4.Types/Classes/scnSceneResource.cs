using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneResource : CResource
	{
		private CArray<scnEntryPoint> _entryPoints;
		private CArray<scnExitPoint> _exitPoints;
		private CArray<scnNotablePoint> _notablePoints;
		private CArray<scnExecutionTagEntry> _executionTagEntries;
		private CArray<scnActorDef> _actors;
		private CArray<scnPlayerActorDef> _playerActors;
		private CHandle<scnSceneGraph> _sceneGraph;
		private CArray<scnLocalMarker> _localMarkers;
		private CArray<scnPropDef> _props;
		private CArray<scnRidResourceHandler> _ridResources;
		private CArray<CHandle<scnWorkspotData>> _workspots;
		private CArray<scnWorkspotInstance> _workspotInstances;
		private scnSRRefCollection _resouresReferences;
		private scnscreenplayStore _screenplayStore;
		private scnlocLocStoreEmbedded _locStore;
		private CUInt32 _version;
		private CArray<scnSceneVOInfo> _voInfo;
		private CArray<scnEffectDef> _effectDefinitions;
		private CArray<scnEffectInstance> _effectInstances;
		private CArray<scnExecutionTag> _executionTags;
		private CArray<scnReferencePointDef> _referencePoints;
		private CArray<scnInterruptionScenario> _interruptionScenarios;
		private scnSceneSolutionHash _sceneSolutionHash;
		private CEnum<scnSceneCategoryTag> _sceneCategoryTag;
		private scnDebugSymbols _debugSymbols;

		[Ordinal(1)] 
		[RED("entryPoints")] 
		public CArray<scnEntryPoint> EntryPoints
		{
			get => GetProperty(ref _entryPoints);
			set => SetProperty(ref _entryPoints, value);
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<scnExitPoint> ExitPoints
		{
			get => GetProperty(ref _exitPoints);
			set => SetProperty(ref _exitPoints, value);
		}

		[Ordinal(3)] 
		[RED("notablePoints")] 
		public CArray<scnNotablePoint> NotablePoints
		{
			get => GetProperty(ref _notablePoints);
			set => SetProperty(ref _notablePoints, value);
		}

		[Ordinal(4)] 
		[RED("executionTagEntries")] 
		public CArray<scnExecutionTagEntry> ExecutionTagEntries
		{
			get => GetProperty(ref _executionTagEntries);
			set => SetProperty(ref _executionTagEntries, value);
		}

		[Ordinal(5)] 
		[RED("actors")] 
		public CArray<scnActorDef> Actors
		{
			get => GetProperty(ref _actors);
			set => SetProperty(ref _actors, value);
		}

		[Ordinal(6)] 
		[RED("playerActors")] 
		public CArray<scnPlayerActorDef> PlayerActors
		{
			get => GetProperty(ref _playerActors);
			set => SetProperty(ref _playerActors, value);
		}

		[Ordinal(7)] 
		[RED("sceneGraph")] 
		public CHandle<scnSceneGraph> SceneGraph
		{
			get => GetProperty(ref _sceneGraph);
			set => SetProperty(ref _sceneGraph, value);
		}

		[Ordinal(8)] 
		[RED("localMarkers")] 
		public CArray<scnLocalMarker> LocalMarkers
		{
			get => GetProperty(ref _localMarkers);
			set => SetProperty(ref _localMarkers, value);
		}

		[Ordinal(9)] 
		[RED("props")] 
		public CArray<scnPropDef> Props
		{
			get => GetProperty(ref _props);
			set => SetProperty(ref _props, value);
		}

		[Ordinal(10)] 
		[RED("ridResources")] 
		public CArray<scnRidResourceHandler> RidResources
		{
			get => GetProperty(ref _ridResources);
			set => SetProperty(ref _ridResources, value);
		}

		[Ordinal(11)] 
		[RED("workspots")] 
		public CArray<CHandle<scnWorkspotData>> Workspots
		{
			get => GetProperty(ref _workspots);
			set => SetProperty(ref _workspots, value);
		}

		[Ordinal(12)] 
		[RED("workspotInstances")] 
		public CArray<scnWorkspotInstance> WorkspotInstances
		{
			get => GetProperty(ref _workspotInstances);
			set => SetProperty(ref _workspotInstances, value);
		}

		[Ordinal(13)] 
		[RED("resouresReferences")] 
		public scnSRRefCollection ResouresReferences
		{
			get => GetProperty(ref _resouresReferences);
			set => SetProperty(ref _resouresReferences, value);
		}

		[Ordinal(14)] 
		[RED("screenplayStore")] 
		public scnscreenplayStore ScreenplayStore
		{
			get => GetProperty(ref _screenplayStore);
			set => SetProperty(ref _screenplayStore, value);
		}

		[Ordinal(15)] 
		[RED("locStore")] 
		public scnlocLocStoreEmbedded LocStore
		{
			get => GetProperty(ref _locStore);
			set => SetProperty(ref _locStore, value);
		}

		[Ordinal(16)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(17)] 
		[RED("voInfo")] 
		public CArray<scnSceneVOInfo> VoInfo
		{
			get => GetProperty(ref _voInfo);
			set => SetProperty(ref _voInfo, value);
		}

		[Ordinal(18)] 
		[RED("effectDefinitions")] 
		public CArray<scnEffectDef> EffectDefinitions
		{
			get => GetProperty(ref _effectDefinitions);
			set => SetProperty(ref _effectDefinitions, value);
		}

		[Ordinal(19)] 
		[RED("effectInstances")] 
		public CArray<scnEffectInstance> EffectInstances
		{
			get => GetProperty(ref _effectInstances);
			set => SetProperty(ref _effectInstances, value);
		}

		[Ordinal(20)] 
		[RED("executionTags")] 
		public CArray<scnExecutionTag> ExecutionTags
		{
			get => GetProperty(ref _executionTags);
			set => SetProperty(ref _executionTags, value);
		}

		[Ordinal(21)] 
		[RED("referencePoints")] 
		public CArray<scnReferencePointDef> ReferencePoints
		{
			get => GetProperty(ref _referencePoints);
			set => SetProperty(ref _referencePoints, value);
		}

		[Ordinal(22)] 
		[RED("interruptionScenarios")] 
		public CArray<scnInterruptionScenario> InterruptionScenarios
		{
			get => GetProperty(ref _interruptionScenarios);
			set => SetProperty(ref _interruptionScenarios, value);
		}

		[Ordinal(23)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHash SceneSolutionHash
		{
			get => GetProperty(ref _sceneSolutionHash);
			set => SetProperty(ref _sceneSolutionHash, value);
		}

		[Ordinal(24)] 
		[RED("sceneCategoryTag")] 
		public CEnum<scnSceneCategoryTag> SceneCategoryTag
		{
			get => GetProperty(ref _sceneCategoryTag);
			set => SetProperty(ref _sceneCategoryTag, value);
		}

		[Ordinal(25)] 
		[RED("debugSymbols")] 
		public scnDebugSymbols DebugSymbols
		{
			get => GetProperty(ref _debugSymbols);
			set => SetProperty(ref _debugSymbols, value);
		}
	}
}
