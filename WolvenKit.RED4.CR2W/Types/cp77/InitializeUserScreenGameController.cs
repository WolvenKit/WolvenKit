using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeUserScreenGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("backgroundVideo")] public inkVideoWidgetReference BackgroundVideo { get; set; }
		[Ordinal(4)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }

		public InitializeUserScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
