using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GamepadHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		[Ordinal(6)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(7)] [RED("partName")] public CString PartName { get; set; }
		[Ordinal(8)] [RED("progress")] public CInt32 Progress { get; set; }
		[Ordinal(9)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public GamepadHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
