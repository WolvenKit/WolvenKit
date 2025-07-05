using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnScenesVersionsSceneChanges : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("scene")] 
		public CResourceAsyncReference<scnSceneResource> Scene
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("sceneChanges")] 
		public CArray<scnScenesVersionsChangedRecord> SceneChanges
		{
			get => GetPropertyValue<CArray<scnScenesVersionsChangedRecord>>();
			set => SetPropertyValue<CArray<scnScenesVersionsChangedRecord>>(value);
		}

		public scnScenesVersionsSceneChanges()
		{
			SceneChanges = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
