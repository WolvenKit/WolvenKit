using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)]  [RED("constAccel")] public Vector4 ConstAccel { get; set; }
		[Ordinal(1)]  [RED("stickiness")] public CFloat Stickiness { get; set; }

		public gameprojectileSlideTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
