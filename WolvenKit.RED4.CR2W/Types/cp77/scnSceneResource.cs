using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneResource : CResource
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
			get
			{
				if (_entryPoints == null)
				{
					_entryPoints = (CArray<scnEntryPoint>) CR2WTypeManager.Create("array:scnEntryPoint", "entryPoints", cr2w, this);
				}
				return _entryPoints;
			}
			set
			{
				if (_entryPoints == value)
				{
					return;
				}
				_entryPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<scnExitPoint> ExitPoints
		{
			get
			{
				if (_exitPoints == null)
				{
					_exitPoints = (CArray<scnExitPoint>) CR2WTypeManager.Create("array:scnExitPoint", "exitPoints", cr2w, this);
				}
				return _exitPoints;
			}
			set
			{
				if (_exitPoints == value)
				{
					return;
				}
				_exitPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("notablePoints")] 
		public CArray<scnNotablePoint> NotablePoints
		{
			get
			{
				if (_notablePoints == null)
				{
					_notablePoints = (CArray<scnNotablePoint>) CR2WTypeManager.Create("array:scnNotablePoint", "notablePoints", cr2w, this);
				}
				return _notablePoints;
			}
			set
			{
				if (_notablePoints == value)
				{
					return;
				}
				_notablePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("executionTagEntries")] 
		public CArray<scnExecutionTagEntry> ExecutionTagEntries
		{
			get
			{
				if (_executionTagEntries == null)
				{
					_executionTagEntries = (CArray<scnExecutionTagEntry>) CR2WTypeManager.Create("array:scnExecutionTagEntry", "executionTagEntries", cr2w, this);
				}
				return _executionTagEntries;
			}
			set
			{
				if (_executionTagEntries == value)
				{
					return;
				}
				_executionTagEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actors")] 
		public CArray<scnActorDef> Actors
		{
			get
			{
				if (_actors == null)
				{
					_actors = (CArray<scnActorDef>) CR2WTypeManager.Create("array:scnActorDef", "actors", cr2w, this);
				}
				return _actors;
			}
			set
			{
				if (_actors == value)
				{
					return;
				}
				_actors = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playerActors")] 
		public CArray<scnPlayerActorDef> PlayerActors
		{
			get
			{
				if (_playerActors == null)
				{
					_playerActors = (CArray<scnPlayerActorDef>) CR2WTypeManager.Create("array:scnPlayerActorDef", "playerActors", cr2w, this);
				}
				return _playerActors;
			}
			set
			{
				if (_playerActors == value)
				{
					return;
				}
				_playerActors = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sceneGraph")] 
		public CHandle<scnSceneGraph> SceneGraph
		{
			get
			{
				if (_sceneGraph == null)
				{
					_sceneGraph = (CHandle<scnSceneGraph>) CR2WTypeManager.Create("handle:scnSceneGraph", "sceneGraph", cr2w, this);
				}
				return _sceneGraph;
			}
			set
			{
				if (_sceneGraph == value)
				{
					return;
				}
				_sceneGraph = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("localMarkers")] 
		public CArray<scnLocalMarker> LocalMarkers
		{
			get
			{
				if (_localMarkers == null)
				{
					_localMarkers = (CArray<scnLocalMarker>) CR2WTypeManager.Create("array:scnLocalMarker", "localMarkers", cr2w, this);
				}
				return _localMarkers;
			}
			set
			{
				if (_localMarkers == value)
				{
					return;
				}
				_localMarkers = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("props")] 
		public CArray<scnPropDef> Props
		{
			get
			{
				if (_props == null)
				{
					_props = (CArray<scnPropDef>) CR2WTypeManager.Create("array:scnPropDef", "props", cr2w, this);
				}
				return _props;
			}
			set
			{
				if (_props == value)
				{
					return;
				}
				_props = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ridResources")] 
		public CArray<scnRidResourceHandler> RidResources
		{
			get
			{
				if (_ridResources == null)
				{
					_ridResources = (CArray<scnRidResourceHandler>) CR2WTypeManager.Create("array:scnRidResourceHandler", "ridResources", cr2w, this);
				}
				return _ridResources;
			}
			set
			{
				if (_ridResources == value)
				{
					return;
				}
				_ridResources = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("workspots")] 
		public CArray<CHandle<scnWorkspotData>> Workspots
		{
			get
			{
				if (_workspots == null)
				{
					_workspots = (CArray<CHandle<scnWorkspotData>>) CR2WTypeManager.Create("array:handle:scnWorkspotData", "workspots", cr2w, this);
				}
				return _workspots;
			}
			set
			{
				if (_workspots == value)
				{
					return;
				}
				_workspots = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("workspotInstances")] 
		public CArray<scnWorkspotInstance> WorkspotInstances
		{
			get
			{
				if (_workspotInstances == null)
				{
					_workspotInstances = (CArray<scnWorkspotInstance>) CR2WTypeManager.Create("array:scnWorkspotInstance", "workspotInstances", cr2w, this);
				}
				return _workspotInstances;
			}
			set
			{
				if (_workspotInstances == value)
				{
					return;
				}
				_workspotInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("resouresReferences")] 
		public scnSRRefCollection ResouresReferences
		{
			get
			{
				if (_resouresReferences == null)
				{
					_resouresReferences = (scnSRRefCollection) CR2WTypeManager.Create("scnSRRefCollection", "resouresReferences", cr2w, this);
				}
				return _resouresReferences;
			}
			set
			{
				if (_resouresReferences == value)
				{
					return;
				}
				_resouresReferences = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("screenplayStore")] 
		public scnscreenplayStore ScreenplayStore
		{
			get
			{
				if (_screenplayStore == null)
				{
					_screenplayStore = (scnscreenplayStore) CR2WTypeManager.Create("scnscreenplayStore", "screenplayStore", cr2w, this);
				}
				return _screenplayStore;
			}
			set
			{
				if (_screenplayStore == value)
				{
					return;
				}
				_screenplayStore = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("locStore")] 
		public scnlocLocStoreEmbedded LocStore
		{
			get
			{
				if (_locStore == null)
				{
					_locStore = (scnlocLocStoreEmbedded) CR2WTypeManager.Create("scnlocLocStoreEmbedded", "locStore", cr2w, this);
				}
				return _locStore;
			}
			set
			{
				if (_locStore == value)
				{
					return;
				}
				_locStore = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("voInfo")] 
		public CArray<scnSceneVOInfo> VoInfo
		{
			get
			{
				if (_voInfo == null)
				{
					_voInfo = (CArray<scnSceneVOInfo>) CR2WTypeManager.Create("array:scnSceneVOInfo", "voInfo", cr2w, this);
				}
				return _voInfo;
			}
			set
			{
				if (_voInfo == value)
				{
					return;
				}
				_voInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("effectDefinitions")] 
		public CArray<scnEffectDef> EffectDefinitions
		{
			get
			{
				if (_effectDefinitions == null)
				{
					_effectDefinitions = (CArray<scnEffectDef>) CR2WTypeManager.Create("array:scnEffectDef", "effectDefinitions", cr2w, this);
				}
				return _effectDefinitions;
			}
			set
			{
				if (_effectDefinitions == value)
				{
					return;
				}
				_effectDefinitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("effectInstances")] 
		public CArray<scnEffectInstance> EffectInstances
		{
			get
			{
				if (_effectInstances == null)
				{
					_effectInstances = (CArray<scnEffectInstance>) CR2WTypeManager.Create("array:scnEffectInstance", "effectInstances", cr2w, this);
				}
				return _effectInstances;
			}
			set
			{
				if (_effectInstances == value)
				{
					return;
				}
				_effectInstances = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("executionTags")] 
		public CArray<scnExecutionTag> ExecutionTags
		{
			get
			{
				if (_executionTags == null)
				{
					_executionTags = (CArray<scnExecutionTag>) CR2WTypeManager.Create("array:scnExecutionTag", "executionTags", cr2w, this);
				}
				return _executionTags;
			}
			set
			{
				if (_executionTags == value)
				{
					return;
				}
				_executionTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("referencePoints")] 
		public CArray<scnReferencePointDef> ReferencePoints
		{
			get
			{
				if (_referencePoints == null)
				{
					_referencePoints = (CArray<scnReferencePointDef>) CR2WTypeManager.Create("array:scnReferencePointDef", "referencePoints", cr2w, this);
				}
				return _referencePoints;
			}
			set
			{
				if (_referencePoints == value)
				{
					return;
				}
				_referencePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("interruptionScenarios")] 
		public CArray<scnInterruptionScenario> InterruptionScenarios
		{
			get
			{
				if (_interruptionScenarios == null)
				{
					_interruptionScenarios = (CArray<scnInterruptionScenario>) CR2WTypeManager.Create("array:scnInterruptionScenario", "interruptionScenarios", cr2w, this);
				}
				return _interruptionScenarios;
			}
			set
			{
				if (_interruptionScenarios == value)
				{
					return;
				}
				_interruptionScenarios = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHash SceneSolutionHash
		{
			get
			{
				if (_sceneSolutionHash == null)
				{
					_sceneSolutionHash = (scnSceneSolutionHash) CR2WTypeManager.Create("scnSceneSolutionHash", "sceneSolutionHash", cr2w, this);
				}
				return _sceneSolutionHash;
			}
			set
			{
				if (_sceneSolutionHash == value)
				{
					return;
				}
				_sceneSolutionHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("sceneCategoryTag")] 
		public CEnum<scnSceneCategoryTag> SceneCategoryTag
		{
			get
			{
				if (_sceneCategoryTag == null)
				{
					_sceneCategoryTag = (CEnum<scnSceneCategoryTag>) CR2WTypeManager.Create("scnSceneCategoryTag", "sceneCategoryTag", cr2w, this);
				}
				return _sceneCategoryTag;
			}
			set
			{
				if (_sceneCategoryTag == value)
				{
					return;
				}
				_sceneCategoryTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("debugSymbols")] 
		public scnDebugSymbols DebugSymbols
		{
			get
			{
				if (_debugSymbols == null)
				{
					_debugSymbols = (scnDebugSymbols) CR2WTypeManager.Create("scnDebugSymbols", "debugSymbols", cr2w, this);
				}
				return _debugSymbols;
			}
			set
			{
				if (_debugSymbols == value)
				{
					return;
				}
				_debugSymbols = value;
				PropertySet(this);
			}
		}

		public scnSceneResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
