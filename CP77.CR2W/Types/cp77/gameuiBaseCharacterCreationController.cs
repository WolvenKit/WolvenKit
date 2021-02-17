using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseCharacterCreationController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("eventDispatcher")] public wCHandle<inkMenuEventDispatcher> EventDispatcher { get; set; }
		[Ordinal(4)] [RED("characterCustomizationState")] public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState { get; set; }
		[Ordinal(5)] [RED("nextPageHitArea")] public inkWidgetReference NextPageHitArea { get; set; }

		public gameuiBaseCharacterCreationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
