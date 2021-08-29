using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFile;
		private scnWorldMarker _sceneLocation;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _syncToMusic;
		private CBool _notAllowedToBeFrozen;
		private CBool _reapplyInterruptionOperationsAfterGameLoad;

		[Ordinal(2)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(3)] 
		[RED("sceneLocation")] 
		public scnWorldMarker SceneLocation
		{
			get => GetProperty(ref _sceneLocation);
			set => SetProperty(ref _sceneLocation, value);
		}

		[Ordinal(4)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}

		[Ordinal(5)] 
		[RED("syncToMusic")] 
		public CBool SyncToMusic
		{
			get => GetProperty(ref _syncToMusic);
			set => SetProperty(ref _syncToMusic, value);
		}

		[Ordinal(6)] 
		[RED("notAllowedToBeFrozen")] 
		public CBool NotAllowedToBeFrozen
		{
			get => GetProperty(ref _notAllowedToBeFrozen);
			set => SetProperty(ref _notAllowedToBeFrozen, value);
		}

		[Ordinal(7)] 
		[RED("reapplyInterruptionOperationsAfterGameLoad")] 
		public CBool ReapplyInterruptionOperationsAfterGameLoad
		{
			get => GetProperty(ref _reapplyInterruptionOperationsAfterGameLoad);
			set => SetProperty(ref _reapplyInterruptionOperationsAfterGameLoad, value);
		}
	}
}
