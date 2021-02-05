using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiGenderSelectionPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("isRotatable")] public CBool IsRotatable { get; set; }

		public gameuiGenderSelectionPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
