using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPreset : CResource
	{
		[Ordinal(1)] [RED("isMaleVO")] public CBool IsMaleVO { get; set; }
		[Ordinal(2)] [RED("values")] public CArray<gameuiCharacterCustomizationUiPresetValue> Values { get; set; }

		public gameuiCharacterCustomizationUiPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
