using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("doorStaturTextWidget")] public wCHandle<inkTextWidget> DoorStaturTextWidget { get; set; }

		public DoorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
