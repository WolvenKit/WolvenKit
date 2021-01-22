using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationGenderSelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("clickTarget")] public inkWidgetReference ClickTarget { get; set; }
		[Ordinal(2)]  [RED("femaleAnimProxy")] public CHandle<inkanimProxy> FemaleAnimProxy { get; set; }
		[Ordinal(3)]  [RED("maleAnimProxy")] public CHandle<inkanimProxy> MaleAnimProxy { get; set; }
		[Ordinal(4)]  [RED("streetRat_female")] public inkWidgetReference StreetRat_female { get; set; }
		[Ordinal(5)]  [RED("streetRat_male")] public inkWidgetReference StreetRat_male { get; set; }

		public CharacterCreationGenderSelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
