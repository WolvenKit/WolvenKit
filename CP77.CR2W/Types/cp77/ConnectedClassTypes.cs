using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConnectedClassTypes : CVariable
	{
		[Ordinal(0)] [RED("surveillanceCamera")] public CBool SurveillanceCamera { get; set; }
		[Ordinal(1)] [RED("securityTurret")] public CBool SecurityTurret { get; set; }
		[Ordinal(2)] [RED("puppet")] public CBool Puppet { get; set; }

		public ConnectedClassTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
