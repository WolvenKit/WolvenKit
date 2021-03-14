using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(12)] [RED("options")] public CArray<gameuiSwitcherOption> Options { get; set; }
		[Ordinal(13)] [RED("switchVisibility")] public CBool SwitchVisibility { get; set; }

		public gameuiSwitcherInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
