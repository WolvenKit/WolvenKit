using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiHoldIndicatorGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("HoldFinish")] public inkEmptyCallback HoldFinish { get; set; }
		[Ordinal(1)]  [RED("HoldProgress")] public gameuiHoldIndicatorProgressCallback HoldProgress { get; set; }
		[Ordinal(2)]  [RED("HoldStart")] public inkEmptyCallback HoldStart { get; set; }
		[Ordinal(3)]  [RED("HoldStop")] public inkEmptyCallback HoldStop { get; set; }

		public gameuiHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
