using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioConversationCharacterCondition : CVariable
	{
		[Ordinal(0)]  [RED("voiceTag")] public CName VoiceTag { get; set; }
		[Ordinal(1)]  [RED("characterRecordId")] public CUInt64 CharacterRecordId { get; set; }
		[Ordinal(2)]  [RED("actorContextName")] public CName ActorContextName { get; set; }
		[Ordinal(3)]  [RED("actorsInitialWorkspotNodeRefHash")] public CUInt64 ActorsInitialWorkspotNodeRefHash { get; set; }

		public audioConversationCharacterCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
