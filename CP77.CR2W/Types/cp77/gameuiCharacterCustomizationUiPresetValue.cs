using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPresetValue : CVariable
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("optionName")] public CName OptionName { get; set; }
		[Ordinal(2)]  [RED("value")] public CUInt32 Value { get; set; }

		public gameuiCharacterCustomizationUiPresetValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
