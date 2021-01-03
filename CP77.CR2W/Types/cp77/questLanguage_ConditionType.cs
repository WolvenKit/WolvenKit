using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLanguage_ConditionType : questISystemConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)]  [RED("languageCode")] public CString LanguageCode { get; set; }
		[Ordinal(2)]  [RED("mode")] public CEnum<questLanguageMode> Mode { get; set; }

		public questLanguage_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
