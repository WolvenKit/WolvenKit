using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPreset : CResource
	{
		[Ordinal(0)]  [RED("isMaleVO")] public CBool IsMaleVO { get; set; }
		[Ordinal(1)]  [RED("values")] public CArray<gameuiCharacterCustomizationUiPresetValue> Values { get; set; }

		public gameuiCharacterCustomizationUiPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
