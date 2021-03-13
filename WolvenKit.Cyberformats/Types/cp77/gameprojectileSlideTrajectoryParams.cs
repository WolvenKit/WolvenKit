using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] [RED("stickiness")] public CFloat Stickiness { get; set; }
		[Ordinal(1)] [RED("constAccel")] public Vector4 ConstAccel { get; set; }

		public gameprojectileSlideTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
