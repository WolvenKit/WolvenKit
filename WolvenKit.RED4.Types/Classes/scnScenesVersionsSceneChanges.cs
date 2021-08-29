using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnScenesVersionsSceneChanges : RedBaseClass
	{
		private CResourceAsyncReference<scnSceneResource> _scene;
		private CArray<scnScenesVersionsChangedRecord> _sceneChanges;

		[Ordinal(0)] 
		[RED("scene")] 
		public CResourceAsyncReference<scnSceneResource> Scene
		{
			get => GetProperty(ref _scene);
			set => SetProperty(ref _scene, value);
		}

		[Ordinal(1)] 
		[RED("sceneChanges")] 
		public CArray<scnScenesVersionsChangedRecord> SceneChanges
		{
			get => GetProperty(ref _sceneChanges);
			set => SetProperty(ref _sceneChanges, value);
		}
	}
}
