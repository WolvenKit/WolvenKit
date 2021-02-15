using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationBackstorySelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] [RED("nomad")] public inkWidgetReference Nomad { get; set; }
		[Ordinal(7)] [RED("streetRat")] public inkWidgetReference StreetRat { get; set; }
		[Ordinal(8)] [RED("corpo")] public inkWidgetReference Corpo { get; set; }
		[Ordinal(9)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(10)] [RED("clickTarget")] public CString ClickTarget { get; set; }
		[Ordinal(11)] [RED("nomadTarget")] public CString NomadTarget { get; set; }
		[Ordinal(12)] [RED("streetTarget")] public CString StreetTarget { get; set; }
		[Ordinal(13)] [RED("corpoTarget")] public CString CorpoTarget { get; set; }

		public CharacterCreationBackstorySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
