using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSnapTags : CVariable
	{
		[Ordinal(0)] [RED("includeTags")] public CArray<CName> IncludeTags { get; set; }
		[Ordinal(1)] [RED("excludeTags")] public CArray<CName> ExcludeTags { get; set; }

		public worldSnapTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
