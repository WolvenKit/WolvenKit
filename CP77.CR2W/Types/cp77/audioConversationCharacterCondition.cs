using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioConversationCharacterCondition : CVariable
	{
		[Ordinal(0)]  [RED("actorContextName")] public CName ActorContextName { get; set; }
		[Ordinal(1)]  [RED("actorsInitialWorkspotNodeRefHash")] public CUInt64 ActorsInitialWorkspotNodeRefHash { get; set; }
		[Ordinal(2)]  [RED("characterRecordId")] public CUInt64 CharacterRecordId { get; set; }
		[Ordinal(3)]  [RED("voiceTag")] public CName VoiceTag { get; set; }

		public audioConversationCharacterCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
