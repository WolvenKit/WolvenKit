using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationInfoResource : CResource
	{
		[Ordinal(0)]  [RED("armsCustomizationOptions")] public CArray<CHandle<gameuiCharacterCustomizationInfo>> ArmsCustomizationOptions { get; set; }
		[Ordinal(1)]  [RED("armsGroups")] public CArray<gameuiOptionsGroup> ArmsGroups { get; set; }
		[Ordinal(2)]  [RED("bodyCustomizationOptions")] public CArray<CHandle<gameuiCharacterCustomizationInfo>> BodyCustomizationOptions { get; set; }
		[Ordinal(3)]  [RED("bodyGroups")] public CArray<gameuiOptionsGroup> BodyGroups { get; set; }
		[Ordinal(4)]  [RED("excludedFromRandomize")] public CArray<CName> ExcludedFromRandomize { get; set; }
		[Ordinal(5)]  [RED("headCustomizationOptions")] public CArray<CHandle<gameuiCharacterCustomizationInfo>> HeadCustomizationOptions { get; set; }
		[Ordinal(6)]  [RED("headGroups")] public CArray<gameuiOptionsGroup> HeadGroups { get; set; }
		[Ordinal(7)]  [RED("perspectiveInfo")] public CArray<gameuiPerspectiveInfo> PerspectiveInfo { get; set; }
		[Ordinal(8)]  [RED("uiPresets")] public CArray<gameuiCharacterCustomizationUiPresetInfo> UiPresets { get; set; }
		[Ordinal(9)]  [RED("version")] public CUInt32 Version { get; set; }

		public gameuiCharacterCustomizationInfoResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
