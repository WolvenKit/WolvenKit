using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFreeCamera : gameObject
	{
		[Ordinal(31)]  [RED("baseSpeed")] public CFloat BaseSpeed { get; set; }
		[Ordinal(32)]  [RED("analogTurnRate")] public CFloat AnalogTurnRate { get; set; }
		[Ordinal(33)]  [RED("mouseTurnRate")] public CFloat MouseTurnRate { get; set; }
		[Ordinal(34)]  [RED("activationBlendTime")] public CFloat ActivationBlendTime { get; set; }
		[Ordinal(35)]  [RED("deactivationBlendTime")] public CFloat DeactivationBlendTime { get; set; }
		[Ordinal(36)]  [RED("usePhysicalCollision")] public CBool UsePhysicalCollision { get; set; }

		public gameFreeCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
