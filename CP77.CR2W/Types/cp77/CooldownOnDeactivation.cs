using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CooldownOnDeactivation : AICooldown
	{
		[Ordinal(0)]  [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(1)]  [RED("timestamp")] public CFloat Timestamp { get; set; }

		public CooldownOnDeactivation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
