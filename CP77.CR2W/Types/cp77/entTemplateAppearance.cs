using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTemplateAppearance : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("appearanceResource")] public raRef<appearanceAppearanceResource> AppearanceResource { get; set; }
		[Ordinal(2)]  [RED("appearanceName")] public CName AppearanceName { get; set; }

		public entTemplateAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
