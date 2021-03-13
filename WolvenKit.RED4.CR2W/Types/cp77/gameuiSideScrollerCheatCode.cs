using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerCheatCode : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("keys")] public CArray<CName> Keys { get; set; }

		public gameuiSideScrollerCheatCode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
