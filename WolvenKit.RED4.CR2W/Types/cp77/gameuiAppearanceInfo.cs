using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(12)] [RED("resource")] public raRef<appearanceAppearanceResource> Resource { get; set; }
		[Ordinal(13)] [RED("definitions")] public CArray<gameuiIndexedAppearanceDefinition> Definitions { get; set; }
		[Ordinal(14)] [RED("useThumbnails")] public CBool UseThumbnails { get; set; }

		public gameuiAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
