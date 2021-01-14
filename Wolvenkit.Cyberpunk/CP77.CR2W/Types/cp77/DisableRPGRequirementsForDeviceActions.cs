using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisableRPGRequirementsForDeviceActions : redEvent
	{
		[Ordinal(0)]  [RED("action")] public TweakDBID Action { get; set; }
		[Ordinal(1)]  [RED("disable")] public CBool Disable { get; set; }

		public DisableRPGRequirementsForDeviceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
