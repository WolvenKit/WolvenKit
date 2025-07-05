using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnScenesVersionsChangedRecord : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("changeInVersion")] 
		public CUInt32 ChangeInVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("sceneBeforeChange")] 
		public CResourceAsyncReference<scnSceneResource> SceneBeforeChange
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		public scnScenesVersionsChangedRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
