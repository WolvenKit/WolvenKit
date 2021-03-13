using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
	{
		[Ordinal(0)] [RED("visualTagHash")] public CName VisualTagHash { get; set; }
		[Ordinal(1)] [RED("appearanceNames")] public CArray<CName> AppearanceNames { get; set; }

		public gameVisualTagsAppearanceNamesPreset_TagsAppearances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
