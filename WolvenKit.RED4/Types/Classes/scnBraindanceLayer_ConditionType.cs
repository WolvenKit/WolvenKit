using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnBraindanceLayer_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] 
		[RED("layer")] 
		public CEnum<scnBraindanceLayer> Layer
		{
			get => GetPropertyValue<CEnum<scnBraindanceLayer>>();
			set => SetPropertyValue<CEnum<scnBraindanceLayer>>(value);
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

		public scnBraindanceLayer_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
