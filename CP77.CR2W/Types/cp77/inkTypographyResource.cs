using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTypographyResource : CResource
	{
		[Ordinal(1)] [RED("languages")] public CArray<inkLanguageDefinition> Languages { get; set; }

		public inkTypographyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
