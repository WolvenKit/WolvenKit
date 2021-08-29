using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterestingConversationData : ISerializable
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFilename;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetProperty(ref _sceneFilename);
			set => SetProperty(ref _sceneFilename, value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}
	}
}
