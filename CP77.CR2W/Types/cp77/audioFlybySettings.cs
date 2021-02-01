using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFlybySettings : CVariable
	{
		[Ordinal(0)]  [RED("flybyEvent")] public CName FlybyEvent { get; set; }
		[Ordinal(1)]  [RED("movementSpeed")] public CFloat MovementSpeed { get; set; }

		public audioFlybySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
