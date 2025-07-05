using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnBraindancePaused_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetPropertyValue<CEnum<scnSceneVersionCheck>>();
			set => SetPropertyValue<CEnum<scnSceneVersionCheck>>(value);
		}

		public scnBraindancePaused_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
