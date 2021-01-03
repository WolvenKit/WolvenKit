using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationGroup : CVariable
	{
		[Ordinal(0)]  [RED("customization")] public CArray<gameuiCustomizationAppearance> Customization { get; set; }
		[Ordinal(1)]  [RED("morphs")] public CArray<gameuiCustomizationMorph> Morphs { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }

		public gameuiCustomizationGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
