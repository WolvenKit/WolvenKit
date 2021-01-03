using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)]  [RED("startVel")] public CFloat StartVel { get; set; }

		public gameprojectileLinearTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
