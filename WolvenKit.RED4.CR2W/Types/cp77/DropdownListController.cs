using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownListController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("listContainer")] public inkCompoundWidgetReference ListContainer { get; set; }
		[Ordinal(2)] [RED("ownerController")] public wCHandle<IScriptable> OwnerController { get; set; }
		[Ordinal(3)] [RED("triggerButton")] public wCHandle<DropdownButtonController> TriggerButton { get; set; }
		[Ordinal(4)] [RED("displayContext")] public CEnum<DropdownDisplayContext> DisplayContext { get; set; }
		[Ordinal(5)] [RED("activeElement")] public CHandle<DropdownElementController> ActiveElement { get; set; }
		[Ordinal(6)] [RED("listOpened")] public CBool ListOpened { get; set; }
		[Ordinal(7)] [RED("data")] public CArray<CHandle<DropdownItemData>> Data { get; set; }

		public DropdownListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
