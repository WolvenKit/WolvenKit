using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneNode_ConditionType : questISceneConditionType
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

		[Ordinal(2)] 
		[RED("ActorName")] 
		public CName ActorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<questSceneConditionType> Type
		{
			get => GetPropertyValue<CEnum<questSceneConditionType>>();
			set => SetPropertyValue<CEnum<questSceneConditionType>>(value);
		}

		public questSceneNode_ConditionType()
		{
			Type = Enums.questSceneConditionType.IsInside;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
