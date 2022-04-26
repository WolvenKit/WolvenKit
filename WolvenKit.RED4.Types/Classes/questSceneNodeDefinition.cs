using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(3)] 
		[RED("sceneLocation")] 
		public scnWorldMarker SceneLocation
		{
			get => GetPropertyValue<scnWorldMarker>();
			set => SetPropertyValue<scnWorldMarker>(value);
		}

		[Ordinal(4)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>(value);
		}

		[Ordinal(5)] 
		[RED("syncToMusic")] 
		public CBool SyncToMusic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("notAllowedToBeFrozen")] 
		public CBool NotAllowedToBeFrozen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("reapplyInterruptionOperationsAfterGameLoad")] 
		public CBool ReapplyInterruptionOperationsAfterGameLoad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSceneNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			SceneLocation = new() { Type = Enums.scnWorldMarkerType.NodeRef };
			InterruptionOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
