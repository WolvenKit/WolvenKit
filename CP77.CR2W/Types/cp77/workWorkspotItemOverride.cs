using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverride : CVariable
	{
		[Ordinal(0)] [RED("propOverrides")] public CArray<workWorkspotItemOverridePropOverride> PropOverrides { get; set; }
		[Ordinal(1)] [RED("itemOverrides")] public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides { get; set; }

		public workWorkspotItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
