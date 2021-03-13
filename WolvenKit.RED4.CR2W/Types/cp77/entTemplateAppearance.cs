using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateAppearance : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("appearanceResource")] public raRef<appearanceAppearanceResource> AppearanceResource { get; set; }
		[Ordinal(2)] [RED("appearanceName")] public CName AppearanceName { get; set; }

		public entTemplateAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
