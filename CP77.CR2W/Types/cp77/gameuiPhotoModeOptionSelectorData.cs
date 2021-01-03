using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeOptionSelectorData : CVariable
	{
		[Ordinal(0)]  [RED("optionData")] public CInt32 OptionData { get; set; }
		[Ordinal(1)]  [RED("optionText")] public CString OptionText { get; set; }

		public gameuiPhotoModeOptionSelectorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
