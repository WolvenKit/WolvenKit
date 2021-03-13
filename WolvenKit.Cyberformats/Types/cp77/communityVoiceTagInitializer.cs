using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communityVoiceTagInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] [RED("voiceTagName")] public CName VoiceTagName { get; set; }

		public communityVoiceTagInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
