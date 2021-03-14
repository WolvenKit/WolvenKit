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
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (CName) CR2WTypeManager.Create("CName", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("characterConditions")] 
		public CArray<audioConversationCharacterCondition> CharacterConditions
		{
			get
			{
				if (_characterConditions == null)
				{
					_characterConditions = (CArray<audioConversationCharacterCondition>) CR2WTypeManager.Create("array:audioConversationCharacterCondition", "characterConditions", cr2w, this);
				}
				return _characterConditions;
			}
			set
			{
				if (_characterConditions == value)
				{
					return;
				}
				_characterConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldSceneInstanceBeSaved")] 
		public CBool ShouldSceneInstanceBeSaved
		{
			get
			{
				if (_shouldSceneInstanceBeSaved == null)
				{
					_shouldSceneInstanceBeSaved = (CBool) CR2WTypeManager.Create("Bool", "shouldSceneInstanceBeSaved", cr2w, this);
				}
				return _shouldSceneInstanceBeSaved;
			}
			set
			{
				if (_shouldSceneInstanceBeSaved == value)
				{
					return;
				}
				_shouldSceneInstanceBeSaved = value;
				PropertySet(this);
			}
		}

		public audioConversationItemMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
