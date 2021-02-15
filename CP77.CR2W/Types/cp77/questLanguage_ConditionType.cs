using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLanguage_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("mode")] public CEnum<questLanguageMode> Mode { get; set; }
		[Ordinal(1)] [RED("languageCode")] public CString LanguageCode { get; set; }
		[Ordinal(2)] [RED("inverted")] public CBool Inverted { get; set; }

		public questLanguage_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
