using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpAndLaunchEvent : gameprojectileLaunchEvent
	{
		[Ordinal(0)]  [RED("lerpMultiplier")] public CFloat LerpMultiplier { get; set; }
		[Ordinal(1)]  [RED("trajectoryParams")] public CHandle<gameprojectileTrajectoryParams> TrajectoryParams { get; set; }

		public gameprojectileSetUpAndLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
