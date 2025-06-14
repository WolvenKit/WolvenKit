using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneResource : CResource
	{
		[Ordinal(1)] 
		[RED("entryPoints")] 
		public CArray<scnEntryPoint> EntryPoints
		{
			get => GetPropertyValue<CArray<scnEntryPoint>>();
			set => SetPropertyValue<CArray<scnEntryPoint>>(value);
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<scnExitPoint> ExitPoints
		{
			get => GetPropertyValue<CArray<scnExitPoint>>();
			set => SetPropertyValue<CArray<scnExitPoint>>(value);
		}

		[Ordinal(3)] 
		[RED("notablePoints")] 
		public CArray<scnNotablePoint> NotablePoints
		{
			get => GetPropertyValue<CArray<scnNotablePoint>>();
			set => SetPropertyValue<CArray<scnNotablePoint>>(value);
		}

		[Ordinal(4)] 
		[RED("executionTagEntries")] 
		public CArray<scnExecutionTagEntry> ExecutionTagEntries
		{
			get => GetPropertyValue<CArray<scnExecutionTagEntry>>();
			set => SetPropertyValue<CArray<scnExecutionTagEntry>>(value);
		}

		[Ordinal(5)] 
		[RED("actors")] 
		public CArray<scnActorDef> Actors
		{
			get => GetPropertyValue<CArray<scnActorDef>>();
			set => SetPropertyValue<CArray<scnActorDef>>(value);
		}

		[Ordinal(6)] 
		[RED("playerActors")] 
		public CArray<scnPlayerActorDef> PlayerActors
		{
			get => GetPropertyValue<CArray<scnPlayerActorDef>>();
			set => SetPropertyValue<CArray<scnPlayerActorDef>>(value);
		}

		[Ordinal(7)] 
		[RED("sceneGraph")] 
		public CHandle<scnSceneGraph> SceneGraph
		{
			get => GetPropertyValue<CHandle<scnSceneGraph>>();
			set => SetPropertyValue<CHandle<scnSceneGraph>>(value);
		}

		[Ordinal(8)] 
		[RED("localMarkers")] 
		public CArray<scnLocalMarker> LocalMarkers
		{
			get => GetPropertyValue<CArray<scnLocalMarker>>();
			set => SetPropertyValue<CArray<scnLocalMarker>>(value);
		}

		[Ordinal(9)] 
		[RED("props")] 
		public CArray<scnPropDef> Props
		{
			get => GetPropertyValue<CArray<scnPropDef>>();
			set => SetPropertyValue<CArray<scnPropDef>>(value);
		}

		[Ordinal(10)] 
		[RED("ridResources")] 
		public CArray<scnRidResourceHandler> RidResources
		{
			get => GetPropertyValue<CArray<scnRidResourceHandler>>();
			set => SetPropertyValue<CArray<scnRidResourceHandler>>(value);
		}

		[Ordinal(11)] 
		[RED("workspots")] 
		public CArray<CHandle<scnWorkspotData>> Workspots
		{
			get => GetPropertyValue<CArray<CHandle<scnWorkspotData>>>();
			set => SetPropertyValue<CArray<CHandle<scnWorkspotData>>>(value);
		}

		[Ordinal(12)] 
		[RED("workspotInstances")] 
		public CArray<scnWorkspotInstance> WorkspotInstances
		{
			get => GetPropertyValue<CArray<scnWorkspotInstance>>();
			set => SetPropertyValue<CArray<scnWorkspotInstance>>(value);
		}

		[Ordinal(13)] 
		[RED("resouresReferences")] 
		public scnSRRefCollection ResouresReferences
		{
			get => GetPropertyValue<scnSRRefCollection>();
			set => SetPropertyValue<scnSRRefCollection>(value);
		}

		[Ordinal(14)] 
		[RED("screenplayStore")] 
		public scnscreenplayStore ScreenplayStore
		{
			get => GetPropertyValue<scnscreenplayStore>();
			set => SetPropertyValue<scnscreenplayStore>(value);
		}

		[Ordinal(15)] 
		[RED("locStore")] 
		public scnlocLocStoreEmbedded LocStore
		{
			get => GetPropertyValue<scnlocLocStoreEmbedded>();
			set => SetPropertyValue<scnlocLocStoreEmbedded>(value);
		}

		[Ordinal(16)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(17)] 
		[RED("voInfo")] 
		public CArray<scnSceneVOInfo> VoInfo
		{
			get => GetPropertyValue<CArray<scnSceneVOInfo>>();
			set => SetPropertyValue<CArray<scnSceneVOInfo>>(value);
		}

		[Ordinal(18)] 
		[RED("effectDefinitions")] 
		public CArray<scnEffectDef> EffectDefinitions
		{
			get => GetPropertyValue<CArray<scnEffectDef>>();
			set => SetPropertyValue<CArray<scnEffectDef>>(value);
		}

		[Ordinal(19)] 
		[RED("effectInstances")] 
		public CArray<scnEffectInstance> EffectInstances
		{
			get => GetPropertyValue<CArray<scnEffectInstance>>();
			set => SetPropertyValue<CArray<scnEffectInstance>>(value);
		}

		[Ordinal(20)] 
		[RED("executionTags")] 
		public CArray<scnExecutionTag> ExecutionTags
		{
			get => GetPropertyValue<CArray<scnExecutionTag>>();
			set => SetPropertyValue<CArray<scnExecutionTag>>(value);
		}

		[Ordinal(21)] 
		[RED("referencePoints")] 
		public CArray<scnReferencePointDef> ReferencePoints
		{
			get => GetPropertyValue<CArray<scnReferencePointDef>>();
			set => SetPropertyValue<CArray<scnReferencePointDef>>(value);
		}

		[Ordinal(22)] 
		[RED("interruptionScenarios")] 
		public CArray<scnInterruptionScenario> InterruptionScenarios
		{
			get => GetPropertyValue<CArray<scnInterruptionScenario>>();
			set => SetPropertyValue<CArray<scnInterruptionScenario>>(value);
		}

		[Ordinal(23)] 
		[RED("sceneSolutionHash")] 
		public scnSceneSolutionHash SceneSolutionHash
		{
			get => GetPropertyValue<scnSceneSolutionHash>();
			set => SetPropertyValue<scnSceneSolutionHash>(value);
		}

		[Ordinal(24)] 
		[RED("sceneCategoryTag")] 
		public CEnum<scnSceneCategoryTag> SceneCategoryTag
		{
			get => GetPropertyValue<CEnum<scnSceneCategoryTag>>();
			set => SetPropertyValue<CEnum<scnSceneCategoryTag>>(value);
		}

		[Ordinal(25)] 
		[RED("debugSymbols")] 
		public scnDebugSymbols DebugSymbols
		{
			get => GetPropertyValue<scnDebugSymbols>();
			set => SetPropertyValue<scnDebugSymbols>(value);
		}

		public scnSceneResource()
		{
			EntryPoints = new();
			ExitPoints = new();
			NotablePoints = new();
			ExecutionTagEntries = new();
			Actors = new();
			PlayerActors = new();
			LocalMarkers = new();
			Props = new();
			RidResources = new();
			Workspots = new();
			WorkspotInstances = new();
			ResouresReferences = new scnSRRefCollection { RidAnimations = new(), RidAnimSets = new(), RidFacialAnimSets = new(), RidCyberwareAnimSets = new(), RidDeformationAnimSets = new(), LipsyncAnimSets = new(), RidCameraAnimations = new(), CinematicAnimSets = new(), GameplayAnimSets = new(), DynamicAnimSets = new(), CinematicAnimNames = new(), GameplayAnimNames = new(), DynamicAnimNames = new(), RidAnimationContainers = new() };
			ScreenplayStore = new scnscreenplayStore { Lines = new(), Options = new() };
			LocStore = new scnlocLocStoreEmbedded { VdEntries = new(), VpEntries = new() };
			VoInfo = new();
			EffectDefinitions = new();
			EffectInstances = new();
			ExecutionTags = new();
			ReferencePoints = new();
			InterruptionScenarios = new();
			SceneSolutionHash = new scnSceneSolutionHash { SceneSolutionHash = new scnSceneSolutionHashHash() };
			SceneCategoryTag = Enums.scnSceneCategoryTag.other;
			DebugSymbols = new scnDebugSymbols { PerformersDebugSymbols = new(), WorkspotsDebugSymbols = new(), SceneEventsDebugSymbols = new(), SceneNodesDebugSymbols = new() };

			PostConstruct();
		}

		partial void PostConstruct();
		
		/// <summary>
		/// Adds an actor to the scene with automatic ID calculation and performer debug symbol creation
		/// </summary>
		/// <param name="actor">The actor to add</param>
		public void AddActor(scnActorDef actor)
		{
			if (actor == null) return;
			
			// Initialize the actor with automatic ID and performer symbol
			actor.InitializeInScene(this);
			
			// Add to actors collection
			Actors.Add(actor);
		}
		
		/// <summary>
		/// Adds a player actor to the scene with automatic ID calculation and performer debug symbol creation
		/// </summary>
		/// <param name="playerActor">The player actor to add</param>
		public void AddPlayerActor(scnPlayerActorDef playerActor)
		{
			if (playerActor == null) return;
			
			// Initialize the player actor with automatic ID and performer symbol
			playerActor.InitializeInScene(this);
			
			// Add to player actors collection
			PlayerActors.Add(playerActor);
		}
		
		/// <summary>
		/// Gets the next available actor ID
		/// </summary>
		/// <returns>The next actor ID that should be used</returns>
		public uint GetNextActorId()
		{
			return (uint)(Actors.Count + PlayerActors.Count);
		}
		
		/// <summary>
		/// Calculates the performer ID for a given actor index
		/// </summary>
		/// <param name="actorIndex">The actor index (0, 1, 2, etc.)</param>
		/// <returns>The corresponding performer ID (1, 257, 513, etc.)</returns>
		public static uint CalculatePerformerId(uint actorIndex)
		{
			return 1 + actorIndex * 256;
		}
	}
}
