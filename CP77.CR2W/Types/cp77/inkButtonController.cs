using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ButtonClick")] public inkButtonClickCallback ButtonClick { get; set; }
		[Ordinal(2)] [RED("ButtonHoldComplete")] public inkButtonHoldCompleteCallback ButtonHoldComplete { get; set; }
		[Ordinal(3)] [RED("ButtonStateChanged")] public inkButtonStateChangeCallback ButtonStateChanged { get; set; }
		[Ordinal(4)] [RED("ButtonSelectionChanged")] public inkButtonSelectionCallback ButtonSelectionChanged { get; set; }
		[Ordinal(5)] [RED("ButtonHoldProgressChanged")] public inkButtonProgressChangedCallback ButtonHoldProgressChanged { get; set; }
		[Ordinal(6)] [RED("canHold")] public CBool CanHold { get; set; }
		[Ordinal(7)] [RED("selectable")] public CBool Selectable { get; set; }
		[Ordinal(8)] [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(9)] [RED("autoUpdateWidgetState")] public CBool AutoUpdateWidgetState { get; set; }

		public inkButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
