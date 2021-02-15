using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("buttonContainer")] public inkWidgetReference ButtonContainer { get; set; }

		public IceMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
