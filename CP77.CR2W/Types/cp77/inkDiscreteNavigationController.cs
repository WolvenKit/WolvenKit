using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkDiscreteNavigationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("isNavigalbe")] public CBool IsNavigalbe { get; set; }
		[Ordinal(1)]  [RED("shouldUpdateScrollController")] public CBool ShouldUpdateScrollController { get; set; }
		[Ordinal(2)]  [RED("supportsHoldInput")] public CBool SupportsHoldInput { get; set; }

		public inkDiscreteNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
