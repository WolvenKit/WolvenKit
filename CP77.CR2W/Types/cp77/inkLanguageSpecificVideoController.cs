using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificVideoController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("fallbackVideo")] public raRef<Bink> FallbackVideo { get; set; }
		[Ordinal(1)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(2)]  [RED("languages")] public CArray<CEnum<inkLanguageId>> Languages { get; set; }
		[Ordinal(3)]  [RED("specificVideoForLanguage")] public raRef<Bink> SpecificVideoForLanguage { get; set; }

		public inkLanguageSpecificVideoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
