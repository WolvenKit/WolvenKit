using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeOptionSelectorData : CVariable
	{
		[Ordinal(0)] [RED("optionData")] public CInt32 OptionData { get; set; }
		[Ordinal(1)] [RED("optionText")] public CString OptionText { get; set; }

		public gameuiPhotoModeOptionSelectorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
