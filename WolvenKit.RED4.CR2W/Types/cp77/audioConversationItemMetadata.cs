using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioConversationItemMetadata : CVariable
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

		public audioConversationItemMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
