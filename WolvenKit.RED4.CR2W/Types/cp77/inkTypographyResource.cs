using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTypographyResource : CResource
	{
		[Ordinal(1)] [RED("languages")] public CArray<inkLanguageDefinition> Languages { get; set; }

		public inkTypographyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
