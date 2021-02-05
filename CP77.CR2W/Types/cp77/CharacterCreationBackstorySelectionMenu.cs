using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationBackstorySelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("eventDispatcher")] public wCHandle<inkMenuEventDispatcher> EventDispatcher { get; set; }
		[Ordinal(2)]  [RED("characterCustomizationState")] public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState { get; set; }
		[Ordinal(3)]  [RED("nextPageHitArea")] public inkWidgetReference NextPageHitArea { get; set; }
		[Ordinal(4)]  [RED("nomad")] public inkWidgetReference Nomad { get; set; }
		[Ordinal(5)]  [RED("streetRat")] public inkWidgetReference StreetRat { get; set; }
		[Ordinal(6)]  [RED("corpo")] public inkWidgetReference Corpo { get; set; }
		[Ordinal(7)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(8)]  [RED("clickTarget")] public CString ClickTarget { get; set; }
		[Ordinal(9)]  [RED("nomadTarget")] public CString NomadTarget { get; set; }
		[Ordinal(10)]  [RED("streetTarget")] public CString StreetTarget { get; set; }
		[Ordinal(11)]  [RED("corpoTarget")] public CString CorpoTarget { get; set; }

		public CharacterCreationBackstorySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
