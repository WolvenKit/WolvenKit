using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GamepadHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(2)]  [RED("partName")] public CString PartName { get; set; }
		[Ordinal(3)]  [RED("progress")] public CInt32 Progress { get; set; }

		public GamepadHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
