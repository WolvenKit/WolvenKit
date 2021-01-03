using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationAppearance : gameuiCensorshipInfo
	{
		[Ordinal(0)]  [RED("definition")] public CName Definition { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("resource")] public raRef<appearanceAppearanceResource> Resource { get; set; }

		public gameuiCustomizationAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
