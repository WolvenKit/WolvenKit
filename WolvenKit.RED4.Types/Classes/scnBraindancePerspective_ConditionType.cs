using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnBraindancePerspective_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<scnBraindancePerspective> Perspective
		{
			get => GetPropertyValue<CEnum<scnBraindancePerspective>>();
			set => SetPropertyValue<CEnum<scnBraindancePerspective>>(value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(2)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetPropertyValue<CEnum<scnSceneVersionCheck>>();
			set => SetPropertyValue<CEnum<scnSceneVersionCheck>>(value);
		}

		public scnBraindancePerspective_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
