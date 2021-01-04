using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiIndexedAppearanceDefinition : CVariable
	{
		[Ordinal(0)]  [RED("actions")] public CArray<gameuiCharacterCustomizationAction> Actions { get; set; }
		[Ordinal(1)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(2)]  [RED("icon")] public TweakDBID Icon { get; set; }
		[Ordinal(3)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(4)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(5)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(6)]  [RED("tags")] public redTagList Tags { get; set; }

		public gameuiIndexedAppearanceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
