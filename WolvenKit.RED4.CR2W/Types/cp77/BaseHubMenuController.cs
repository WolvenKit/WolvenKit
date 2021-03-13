using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseHubMenuController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(3)] [RED("menuData")] public CHandle<IScriptable> MenuData { get; set; }

		public BaseHubMenuController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
