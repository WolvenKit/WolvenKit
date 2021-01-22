using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerOtherVars : CVariable
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("enabledByToggle")] public CBool EnabledByToggle { get; set; }

		public PlayerVisionModeControllerOtherVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
