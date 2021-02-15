using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiHoldIndicatorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("HoldProgress")] public gameuiHoldIndicatorProgressCallback HoldProgress { get; set; }
		[Ordinal(3)] [RED("HoldStart")] public inkEmptyCallback HoldStart { get; set; }
		[Ordinal(4)] [RED("HoldFinish")] public inkEmptyCallback HoldFinish { get; set; }
		[Ordinal(5)] [RED("HoldStop")] public inkEmptyCallback HoldStop { get; set; }

		public gameuiHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
