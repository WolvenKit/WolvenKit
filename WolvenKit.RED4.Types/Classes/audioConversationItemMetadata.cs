using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioConversationItemMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CName SceneFile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("characterConditions")] 
		public CArray<audioConversationCharacterCondition> CharacterConditions
		{
			get => GetPropertyValue<CArray<audioConversationCharacterCondition>>();
			set => SetPropertyValue<CArray<audioConversationCharacterCondition>>(value);
		}

		[Ordinal(2)] 
		[RED("shouldSceneInstanceBeSaved")] 
		public CBool ShouldSceneInstanceBeSaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioConversationItemMetadata()
		{
			CharacterConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
