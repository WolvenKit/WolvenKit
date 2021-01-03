using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DebugHubMenuLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("defailtMenuName")] public CName DefailtMenuName { get; set; }
		[Ordinal(1)]  [RED("eventsList")] public CArray<CName> EventsList { get; set; }
		[Ordinal(2)]  [RED("menusList")] public CArray<CName> MenusList { get; set; }
		[Ordinal(3)]  [RED("selectorCtrl")] public wCHandle<hubSelectorController> SelectorCtrl { get; set; }
		[Ordinal(4)]  [RED("selectorWidget")] public wCHandle<inkWidget> SelectorWidget { get; set; }

		public DebugHubMenuLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
