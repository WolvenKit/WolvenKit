using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpAndLaunchEvent : gameprojectileLaunchEvent
	{
		[Ordinal(4)] [RED("trajectoryParams")] public CHandle<gameprojectileTrajectoryParams> TrajectoryParams { get; set; }
		[Ordinal(5)] [RED("lerpMultiplier")] public CFloat LerpMultiplier { get; set; }

		public gameprojectileSetUpAndLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
