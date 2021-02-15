using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowerDeviceCommand : AIFollowerCommand
	{
		[Ordinal(5)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(6)] [RED("overrideMovementTarget")] public wCHandle<gameObject> OverrideMovementTarget { get; set; }

		public AIFollowerDeviceCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
