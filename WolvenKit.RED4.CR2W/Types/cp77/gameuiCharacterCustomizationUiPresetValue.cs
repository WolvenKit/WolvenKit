using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPresetValue : CVariable
	{
		[Ordinal(0)] [RED("optionName")] public CName OptionName { get; set; }
		[Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(2)] [RED("value")] public CUInt32 Value { get; set; }

		public gameuiCharacterCustomizationUiPresetValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
