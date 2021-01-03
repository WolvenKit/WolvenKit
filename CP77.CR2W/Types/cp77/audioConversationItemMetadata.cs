using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioConversationItemMetadata : CVariable
	{
		[Ordinal(0)]  [RED("characterConditions")] public CArray<audioConversationCharacterCondition> CharacterConditions { get; set; }
		[Ordinal(1)]  [RED("sceneFile")] public CName SceneFile { get; set; }
		[Ordinal(2)]  [RED("shouldSceneInstanceBeSaved")] public CBool ShouldSceneInstanceBeSaved { get; set; }

		public audioConversationItemMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
