using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLanguageDefinition : CVariable
	{
		[Ordinal(0)] [RED("languageCode")] public CName LanguageCode { get; set; }
		[Ordinal(1)] [RED("isoScriptCode")] public CName IsoScriptCode { get; set; }
		[Ordinal(2)] [RED("textDirection")] public CEnum<inkETextDirection> TextDirection { get; set; }
		[Ordinal(3)] [RED("fonts")] public CArray<inkLanguageFont> Fonts { get; set; }

		public inkLanguageDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
