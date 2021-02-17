using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLanguageOverrideProvider : inkUserData
	{
		[Ordinal(0)] [RED("languageId")] public CEnum<inkLanguageId> LanguageId { get; set; }

		public inkLanguageOverrideProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
