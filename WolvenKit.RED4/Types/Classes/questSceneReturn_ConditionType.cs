using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneReturn_ConditionType : questISceneConditionType
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
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIReturnCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIReturnCondition>>>(value);
		}

		public questSceneReturn_ConditionType()
		{
			ReturnConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
