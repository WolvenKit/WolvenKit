using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAudioAttractAreaNode : worldTriggerAreaNode
	{
		[Ordinal(7)] [RED("interestingConversationsNodeRef")] public NodeRef InterestingConversationsNodeRef { get; set; }
		[Ordinal(8)] [RED("audioAttractSoundSettings")] public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings { get; set; }

		public worldAudioAttractAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
