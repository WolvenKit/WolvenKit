using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnBraindanceJumpInProgress_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] 
		[RED("inProgress")] 
		public CBool InProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

		public scnBraindanceJumpInProgress_ConditionType()
		{
			InProgress = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
