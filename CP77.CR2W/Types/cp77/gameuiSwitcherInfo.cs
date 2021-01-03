using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(0)]  [RED("options")] public CArray<gameuiSwitcherOption> Options { get; set; }
		[Ordinal(1)]  [RED("switchVisibility")] public CBool SwitchVisibility { get; set; }

		public gameuiSwitcherInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
