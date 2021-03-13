using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAppearanceEvent : redEvent
	{
		[Ordinal(0)] [RED("appearanceName")] public CName AppearanceName { get; set; }

		public entAppearanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
