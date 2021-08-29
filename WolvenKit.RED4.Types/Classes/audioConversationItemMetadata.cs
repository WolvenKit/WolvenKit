using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioConversationItemMetadata : RedBaseClass
	{
		private CName _sceneFile;
		private CArray<audioConversationCharacterCondition> _characterConditions;
		private CBool _shouldSceneInstanceBeSaved;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CName SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("characterConditions")] 
		public CArray<audioConversationCharacterCondition> CharacterConditions
		{
			get => GetProperty(ref _characterConditions);
			set => SetProperty(ref _characterConditions, value);
		}

		[Ordinal(2)] 
		[RED("shouldSceneInstanceBeSaved")] 
		public CBool ShouldSceneInstanceBeSaved
		{
			get => GetProperty(ref _shouldSceneInstanceBeSaved);
			set => SetProperty(ref _shouldSceneInstanceBeSaved, value);
		}
	}
}
