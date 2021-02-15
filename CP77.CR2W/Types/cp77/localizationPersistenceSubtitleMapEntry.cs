using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleMapEntry : CVariable
	{
		[Ordinal(0)] [RED("subtitleGroup")] public CName SubtitleGroup { get; set; }
		[Ordinal(1)] [RED("subtitleFile")] public raRef<JsonResource> SubtitleFile { get; set; }

		public localizationPersistenceSubtitleMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
