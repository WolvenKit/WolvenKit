using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseToggleView : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("OldState")] public CEnum<inkEToggleState> OldState { get; set; }
		[Ordinal(1)]  [RED("ToggleController")] public wCHandle<inkToggleController> ToggleController { get; set; }

		public BaseToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
