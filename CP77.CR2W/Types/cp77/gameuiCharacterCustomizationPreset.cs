using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationPreset : CResource
	{
		[Ordinal(1)] [RED("isMale")] public CBool IsMale { get; set; }
		[Ordinal(2)] [RED("bodyGroups")] public CArray<gameuiCustomizationGroup> BodyGroups { get; set; }
		[Ordinal(3)] [RED("headGroups")] public CArray<gameuiCustomizationGroup> HeadGroups { get; set; }
		[Ordinal(4)] [RED("armsGroups")] public CArray<gameuiCustomizationGroup> ArmsGroups { get; set; }
		[Ordinal(5)] [RED("perspectiveInfo")] public CArray<gameuiPerspectiveInfo> PerspectiveInfo { get; set; }
		[Ordinal(6)] [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(7)] [RED("version")] public CUInt32 Version { get; set; }

		public gameuiCharacterCustomizationPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
