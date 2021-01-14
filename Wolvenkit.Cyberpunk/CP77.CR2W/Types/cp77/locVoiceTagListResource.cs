using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class locVoiceTagListResource : CResource
	{
		[Ordinal(0)]  [RED("voiceTags")] public CArray<locVoiceTag> VoiceTags { get; set; }

		public locVoiceTagListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
