using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationGenderBackstoryPathHeader : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(2)]  [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(3)]  [RED("selectedColor")] public CColor SelectedColor { get; set; }
		[Ordinal(4)]  [RED("unSelectedColor")] public CColor UnSelectedColor { get; set; }
		[Ordinal(5)]  [RED("textSelectedColor")] public CColor TextSelectedColor { get; set; }
		[Ordinal(6)]  [RED("textUnselectedColor")] public CColor TextUnselectedColor { get; set; }

		public CharacterCreationGenderBackstoryPathHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
