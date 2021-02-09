using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetAttitudeAnimationController : BasicAnimationController
	{
		[Ordinal(5)]  [RED("hostileShowAnimation")] public CName HostileShowAnimation { get; set; }
		[Ordinal(6)]  [RED("hostileIdleAnimation")] public CName HostileIdleAnimation { get; set; }
		[Ordinal(7)]  [RED("hostileHideAnimation")] public CName HostileHideAnimation { get; set; }
		[Ordinal(8)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public TargetAttitudeAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
