using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPreset : CResource
	{
		[Ordinal(0)]  [RED("isMaleVO")] public CBool IsMaleVO { get; set; }
		[Ordinal(1)]  [RED("values")] public CArray<gameuiCharacterCustomizationUiPresetValue> Values { get; set; }

		public gameuiCharacterCustomizationUiPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
