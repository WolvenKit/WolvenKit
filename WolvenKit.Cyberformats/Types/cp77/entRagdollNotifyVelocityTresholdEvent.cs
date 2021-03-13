using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entRagdollNotifyVelocityTresholdEvent : redEvent
	{
		[Ordinal(0)] [RED("velocity")] public Vector4 Velocity { get; set; }

		public entRagdollNotifyVelocityTresholdEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
