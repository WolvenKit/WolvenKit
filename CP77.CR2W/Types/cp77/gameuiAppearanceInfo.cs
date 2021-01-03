using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(0)]  [RED("definitions")] public CArray<gameuiIndexedAppearanceDefinition> Definitions { get; set; }
		[Ordinal(1)]  [RED("resource")] public raRef<appearanceAppearanceResource> Resource { get; set; }
		[Ordinal(2)]  [RED("useThumbnails")] public CBool UseThumbnails { get; set; }

		public gameuiAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
