using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		[Ordinal(6)] [RED("progress")] public inkImageWidgetReference Progress { get; set; }

		public KeyboardHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
