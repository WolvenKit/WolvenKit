using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(0)]  [RED("options")] public CArray<gameuiSwitcherOption> Options { get; set; }
		[Ordinal(1)]  [RED("switchVisibility")] public CBool SwitchVisibility { get; set; }

		public gameuiSwitcherInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
