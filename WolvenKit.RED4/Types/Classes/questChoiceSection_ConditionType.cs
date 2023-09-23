using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questChoiceSection_ConditionType : questISceneConditionType
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
		[RED("choiceSectionId")] 
		public scnNodeId ChoiceSectionId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(3)] 
		[RED("choiceSectionName")] 
		public CName ChoiceSectionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("mode")] 
		public CEnum<questChoiceSection_ConditionTypeMode> Mode
		{
			get => GetPropertyValue<CEnum<questChoiceSection_ConditionTypeMode>>();
			set => SetPropertyValue<CEnum<questChoiceSection_ConditionTypeMode>>(value);
		}

		public questChoiceSection_ConditionType()
		{
			ChoiceSectionId = new scnNodeId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
