using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class locVoLanguageDataEntry : CVariable
	{
		[Ordinal(0)]  [RED("languageCode")] public CName LanguageCode { get; set; }
		[Ordinal(1)]  [RED("lenghtMapReport")] public raRef<JsonResource> LenghtMapReport { get; set; }
		[Ordinal(2)]  [RED("voMapChunks")] public CArray<raRef<JsonResource>> VoMapChunks { get; set; }
		[Ordinal(3)]  [RED("voiceverMapReport")] public raRef<JsonResource> VoiceverMapReport { get; set; }

		public locVoLanguageDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
