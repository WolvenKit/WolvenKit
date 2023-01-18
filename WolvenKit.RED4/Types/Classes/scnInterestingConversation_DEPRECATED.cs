using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterestingConversation_DEPRECATED : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		public scnInterestingConversation_DEPRECATED()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
