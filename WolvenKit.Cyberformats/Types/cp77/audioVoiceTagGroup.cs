using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagGroup : audioAudioMetadata
	{
		[Ordinal(1)] [RED("voiceTags")] public CArray<CName> VoiceTags { get; set; }

		public audioVoiceTagGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
